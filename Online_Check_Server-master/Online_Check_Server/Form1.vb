Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Timers
Imports System.Runtime.InteropServices
Imports System.Xml

Public Class Form1


    Dim localPort As Integer = 20000
    Dim localip As IPAddress = GetLocalIP()
    Dim listener As TcpListener

    Dim connections As New List(Of Connection)

    Dim xmlController As New XMLController
    Dim smsAlertController As New XMLAlertController
    Dim logController As New LogController

    Dim ipListLower As IPAddress = IPAddress.Parse("0.0.0.0")
    Dim ipListHigher As IPAddress = IPAddress.Parse("255.255.255.255")

    Dim isLoaded As Boolean = False

    Dim ONLINE_COLOR As Color = Color.Green
    Dim OFFLINE_COLOR As Color = Color.Red
    Dim ONLINE_TEXT As String = "Online"
    Dim OFFLINE_TEXT As String = "Offline"

    Dim SEND_EMAIL_TEXT As String = "True"
    Dim NO_SEND_EMAIL_TEXT As String = "False"

    Dim previousSelectedListViewItem As ListViewItem = Nothing

    Dim timer As Timers.Timer
    Dim timerTickTime As Integer = 10000

    'prevents message spam on program start
    Dim MINS_TO_CHECK_SERVERS = 1

    Dim email As String = ""
    Dim phone As String = ""
    Dim smsUser As String = ""
    Dim smsKey As String = ""

    Dim messageController As New MessageController(email)
    Dim smsController As New SMSController(phone, smsUser, smsKey)

    Dim form_Settings As New Settings(Me)
    'Dim form_SendClient As New TransferClient(Me)


    'enum to better keep track of strings and IDs
    'Used so you dont have to memorise what "4" means.
    Enum ListViewConsIDs
        ServerIP = 0
        ServerName = 1
        ServerStatus = 2
        SendEmail = 3
        TimeSinceCheck = 4
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim logpath As String = "REPORT"
        If Not Directory.Exists(logpath) Then
            Directory.CreateDirectory(logpath)
        End If


        'begin listening for connections
        StartListener()
        ' XMLController.AddItemToXML(New Connection("1.2.3.4.5", "name goes here", ConnectionStatus.Offline, False, "Time since last check goes here"))

        Hmpf()
        UpdateSettingsValues()
        UpdateViewFromXML()


        'select the first item in the listbox if any exist
        If listView_Connections.Items.Count > 0 Then
            listView_Connections.TopItem.Selected = True
            previousSelectedListViewItem = listView_Connections.TopItem
        End If

        'time for automatic refresh and time since last online check
        timer = New Timers.Timer(timerTickTime)
        AddHandler timer.Elapsed, New ElapsedEventHandler(AddressOf TimerTick)
        timer.Enabled = True

        'Make sure to avoid exceptions relating to executing functions before the GUI is loaded
        isLoaded = True


        'Upate the view if an update is needed
        'this is called alot throughout the program to make sure that the GUI is always correct.
        UpdateViewFromXML()
    End Sub

    'Creates 255 threads to listen for incomming pings
    'Allows for 255 constant connections
    Public Sub StartListener()
        Console.Write("Trying to create listener on ip " & localip.ToString() & " , port " & localPort & " ...")
        listener = New TcpListener(localip, localPort)
        listener.Start()
        Console.WriteLine("Listener created successfully")
        Console.WriteLine()
        Console.WriteLine("LISTENING ON IP: " & localip.ToString())
        Console.WriteLine()
        Console.Write("Trying to create thread(s)...")

        'using multiple threads for multiple connections at once
        Dim Threads(255) As Thread
        For i As Integer = 0 To Threads.Length
            Dim threadID = i
            Dim thread = New Thread(Sub() Service(threadID))
            thread.Start()
        Next
        Console.WriteLine("Threads Started")

    End Sub

    'Ran on each thread, listens for an incomming connection
    'On connecting, it will automatically add the connection to both the GUI and the XML file
    Public Sub Service(id As Integer)

        'Loop infinitely to constantly scan for incomming packets
        While True
            'set up variables
            Dim socket As Socket = listener.AcceptSocket()
            Dim ip As String = socket.RemoteEndPoint.ToString()
            ip = ip.Substring(0, ip.LastIndexOf(":"))

            'create a new connection based on incoming IP
            Console.WriteLine("Connected " & ip & "on thread ID " & id)
            Dim host As IPHostEntry = Dns.GetHostEntry(ip)
            Dim currCon As New Connection(IPAddress.Parse(ip), host.HostName, Connection.ConnectionStatus.Online, True.ToString(), DateTime.Now)

            'add connection to xml and GUI
            XMLController.AddItemToClientListXML(currCon)
            UpdateViewFromXML()



            'recieves a message from the client computer
            'presently doesnt actually do anything, but you can make it do whatever you want based on the message
            'implementation of this is in the Client program.
            Try
                Dim networkStream As NetworkStream = New NetworkStream(socket)
                Dim streamWriter As StreamWriter = New StreamWriter(networkStream)
                streamWriter.AutoFlush = True
                streamWriter.WriteLine("Message from SERVER")

                Dim streamReader As StreamReader = New StreamReader(networkStream)
                Console.WriteLine("Message from connected client: " & streamReader.ReadLine())


                networkStream.Close()
            Catch e As Exception
                Console.WriteLine("EXCEPTION: " & e.Message)
            End Try

            socket.Close()
        End While
    End Sub


    'Delegates needed due to multithreaded nature of program
    Public Delegate Sub TimerTickDeleage(ByVal sender As Object, ByVal e As ElapsedEventArgs)

    'Runs every timerTrickTime(3000?) seconds
    Public Sub TimerTick(ByVal sender As Object, ByVal e As ElapsedEventArgs)

        'standard mutli thread invoke
        'just runs the function, but makes sure threads do not interfere
        If Me.InvokeRequired Then
            Dim del As TimerTickDeleage = New TimerTickDeleage(AddressOf TimerTick)
            Dim params() = {sender, e}
            Me.Invoke(del, params)

        Else
            Console.WriteLine("Tick")

            UpdateViewFromXML()


        End If

    End Sub

    'checks if the connection has been offline for MINS TO CHECK SERVERS minutes
    'if it has, set it to offline and update the XML file accordingly
    'also pop up a box to alert the user that the connection is down
    'else, do nothing
    Private Sub CheckServerForOffline(item As ListViewItem)
        ' For Each item As ListViewItem In listView_Connections.Items
        Dim timeSinceCheck As String = item.SubItems(ListViewConsIDs.TimeSinceCheck).Text
        Dim con As Connection = XMLController.GetConnectionFromClientListXML(IPAddress.Parse(item.SubItems(ListViewConsIDs.ServerIP).Text))
        Console.WriteLine("Time since check = " + timeSinceCheck)
        timeSinceCheck = timeSinceCheck.Substring(0, timeSinceCheck.IndexOf(" "))
        Console.WriteLine("Time since check as int = " + timeSinceCheck)
        If Integer.Parse(timeSinceCheck) >= MINS_TO_CHECK_SERVERS Then
            Console.WriteLine("Time since check exceeds " + MINS_TO_CHECK_SERVERS.ToString() + " seconds")
            con.SetOffline()
            XMLController.AddItemToClientListXML(con)
        Else
            con.SetOnline()
            XMLController.AddItemToClientListXML(con)
        End If

        If item.SubItems(ListViewConsIDs.ServerStatus).Text = OFFLINE_TEXT _
        And item.SubItems(ListViewConsIDs.SendEmail).Text = SEND_EMAIL_TEXT Then
            con.sendEmailOnCrash = False
            item.SubItems(ListViewConsIDs.SendEmail).Text = NO_SEND_EMAIL_TEXT
            XMLController.AddItemToClientListXML(con)

            'the following code turns the xml document into an array of objects
            Dim file As FileStream = New FileStream("DATA/Alert.xml", FileMode.Open)
            Dim xmldoc As XDocument = XDocument.Load(file)
            Dim recipient = (From p In xmldoc.Descendants("Setting") Select New With {
            Key .Phone = p.Element("Phone").Value, Key .Mail = p.Element("Email").Value}).ToArray()

            'comment out to disable send condition for testing
            My.Computer.Audio.Play(My.Resources.alertaudio, AudioPlayMode.Background)
            MsgBox("Server at IP " + con.getIP() + " is down")

            For Each person In recipient
                MessageBox.Show(person.Phone)
                ' smsController.SendText(XMLController.GetConnectionFromClientListXML(IPAddress.Parse(item.SubItems(ListViewConsIDs.ServerIP).Text)), person.Phone, smsUser, smsKey)

                If email IsNot Nothing AndAlso email IsNot "" Then
                    ' messageController.SendEmail(XMLController.GetConnectionFromClientListXML(IPAddress.Parse(item.SubItems(ListViewConsIDs.ServerIP).Text)), person.Mail)
                End If
            Next

            'pass ip addresses of down servers to method creating error log
            logController.WriteErrorLog(XMLController.GetConnectionFromClientListXML(IPAddress.Parse(item.SubItems(ListViewConsIDs.ServerIP).Text)))

        End If
        '  Next
    End Sub

    'returns Local ip for use in creating TCPListener
    Public Function GetLocalIP() As IPAddress
        Dim host = Dns.GetHostEntry(Dns.GetHostName())

        For Each ip In host.AddressList

            If ip.AddressFamily = AddressFamily.InterNetwork Then
                Return ip
            End If
        Next

        Throw New Exception("No network adapters with an IPv4 address in the system!")
    End Function

    'standard mutli thread delegate
    Public Delegate Sub updateViewFromXMLDeleage()

    'this is the main function of the entire program
    'it will check the XML file for all connections
    'and display their data on the GUI
    'main complexity comes from displaying the correct list of connections
    'and correctly displaying it's sub data
    Public Sub UpdateViewFromXML()

        'standard mutli thread invoke
        'just runs the function, but makes sure threads do not interfere
        If Me.InvokeRequired Then
            Dim del As updateViewFromXMLDeleage = New updateViewFromXMLDeleage(AddressOf UpdateViewFromXML)
            'Invoke(del)
        Else
            'load cons from xml
            Dim connectionListFromFile As List(Of Connection) = XMLController.GetAllConnectionsFromClientListXML()


            'Loop through all connection in XML
            For Each connection In connectionListFromFile

                'Limits selected con to be within the currently selected IP range
                If Not IsNotBetweenLimitIPs(connection) Then

                    Dim foundItem As ListViewItem = Nothing
                    'Check if connection is already in the view
                    For Each item As ListViewItem In listView_Connections.Items
                        If connection.getIP() = item.SubItems(0).Text Then
                            Console.WriteLine("Con found, editing view to update")
                            foundItem = item
                        End If
                    Next


                    If foundItem Is Nothing Then
                        'if item is new, add it


                        Console.WriteLine("Function addConToViewFromXML called")

                        'Create list view item with IP as the first item, add subsequent items
                        foundItem = New ListViewItem(connection.getIP())
                        foundItem.SubItems.Add(connection.getName())
                        foundItem.SubItems.Add(connection.getStatusAsString())
                        foundItem.SubItems.Add(connection.getSendEmailOnCrash())
                        foundItem.SubItems.Add(getTimeDifferenceInConnection(connection))





                        'Adds a item to the main listview with the IP, and string based on connection status
                        listView_Connections.Items.Add(foundItem)

                    Else
                        'if item is already in the view, update it
                        'Check each item first incase its the same, limits flickering
                        If foundItem.SubItems(0).Text IsNot connection.getIP() Then
                            foundItem.SubItems(0).Text = connection.getIP()
                        End If

                        If foundItem.SubItems(1).Text IsNot connection.getName() Then
                            foundItem.SubItems(1).Text = connection.getName()
                        End If

                        If foundItem.SubItems(2).Text IsNot connection.getStatusAsString() Then
                            foundItem.SubItems(2).Text = connection.getStatusAsString()
                        End If

                        If foundItem.SubItems(3).Text IsNot connection.getSendEmailOnCrash() Then
                            foundItem.SubItems(3).Text = connection.getSendEmailOnCrash()
                        End If

                        If foundItem.SubItems(4).Text IsNot getTimeDifferenceInConnection(connection) Then
                            foundItem.SubItems(4).Text = getTimeDifferenceInConnection(connection)
                        End If

                    End If

                    CheckServerForOffline(foundItem)

                    'Make sure the Online Status is the correct color
                    foundItem.UseItemStyleForSubItems = False
                    If foundItem.SubItems(ListViewConsIDs.ServerStatus).Text = ONLINE_TEXT Then
                        foundItem.SubItems(ListViewConsIDs.ServerStatus).BackColor = ONLINE_COLOR
                    Else
                        foundItem.SubItems(ListViewConsIDs.ServerStatus).BackColor = OFFLINE_COLOR
                    End If

                Else
                    'make sure item is not in the view if it is not needed
                    'if found, remove it
                    Dim foundItem As ListViewItem = Nothing
                    'Check if connection is already in the view
                    For Each item As ListViewItem In listView_Connections.Items
                        If connection.getIP() = item.SubItems(0).Text Then
                            item.Remove()
                        End If
                    Next
                End If



            Next


        End If


    End Sub


    'returns the time between the last successful connection and the current time
    Public Function getTimeDifferenceInConnection(input As Connection) As String
        Dim time As String = (DateTime.Now - input.getTimeOfLastCheck()).TotalSeconds.ToString()
        time = time.Substring(0, time.IndexOf(".")) + " seconds ago"
        Return time
    End Function


    'check if current con's ip is not in range
    Public Function IsNotBetweenLimitIPs(con As Connection) As Boolean
        If (IpToIntRep(con.ip) > IpToIntRep(ipListLower)) And (IpToIntRep(con.ip) < IpToIntRep(ipListHigher)) Then
            Return False
        Else
            Return True
        End If
    End Function

    'Creates an integer representation of an IP address for use in comparing them
    'might not be needed, but it looks cool.
    Public Function IpToIntRep(ip As IPAddress) As Int64
        Dim val As Int64 = 0
        Dim ipStr As String = ip.ToString()
        Dim subIpList As New List(Of Integer)

        While ipStr.IndexOf(".") <> -1
            subIpList.Add(ipStr.Substring(0, ipStr.IndexOf(".")))
            ipStr = ipStr.Substring(ipStr.IndexOf(".") + 1, ipStr.Length - 1 - ipStr.IndexOf("."))
        End While
        subIpList.Add(ipStr)

        For i As Integer = 0 To 3
            val += subIpList(i) * (Math.Pow(255, 3 - i))
        Next

        Return val



    End Function

    'on clicking enable/disable, flip the server's email check
    Private Sub btn_toggleServerCheck_Click(sender As Object, e As EventArgs) Handles btn_toggleServerCheck.Click

        ' Console.WriteLine("toggling ip: " + listView_Connections.Items(0).ToString())

        Dim currCon As Connection = XMLController.GetConnectionFromClientListXML(IPAddress.Parse(listView_Connections.SelectedItems(0).Text))
        currCon.flipEmailStatus()
        XMLController.AddItemToClientListXML(currCon)

        UpdateViewFromXML()

        'Change the button Text to let the user know the state of the selected IP
        If Not currCon.ConnectionStatus.Offline Then
            btn_toggleServerCheck.Text = "Set Offline"
        Else
            btn_toggleServerCheck.Text = "Set Online"
        End If
    End Sub

    'Sends message to connection to force send a connection
    'thus refreshing the connection's last connect time
    Private Sub btn_forceRefresh_Click(sender As Object, e As EventArgs) Handles btn_forceRefresh.Click

        UpdateViewFromXML()

        Dim conList As List(Of Connection) = XMLController.GetAllConnectionsFromClientListXML()

        Dim Threads(conList.Count) As Thread
        For Each con As Connection In conList
            'Dim thread = New Thread(Sub() Service(threadID))
            Dim thread = New Thread(Sub() con.ForceRefresh())
            thread.Start()
        Next

    End Sub

    'limit GUI to only show ips between the lower and upper textboxes
    Private Sub tb_lowerIPRange_TextChanged(sender As Object, e As EventArgs) Handles tb_lowerIPRange.TextChanged, tb_higherIPRange.TextChanged


        Dim item As TextBox = sender
        Dim startingIpListLower = ipListLower
        Dim startingIpListHigher = ipListHigher
        Dim regexString = "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"
        ' if lower and higher ip matches regex
        If Regex.IsMatch(item.Text, regexString) Then
            error_ip.SetError(item, "")

            '  If RegularExpressions.Regex.IsMatch(tb_lowerIPRange.Text, regexString) Then
            If IPAddress.TryParse(tb_lowerIPRange.Text, ipListLower) Then
                'If ip parsing worked for the LOWER range

            Else
                ipListLower = IPAddress.Parse("0.0.0.0")
            End If

            If IPAddress.TryParse(tb_higherIPRange.Text, ipListHigher) Then
                'if ip parsing worked for the HIGHER range

            Else
                ipListHigher = IPAddress.Parse("255.255.255.255")
            End If

            If startingIpListHigher.Equals(ipListHigher) And startingIpListLower.Equals(ipListLower) Then
                'if they match, dont do anything
            Else
                'if one of the addresses has changed, update view
                UpdateViewFromXML()
            End If

        Else
            error_ip.SetError(item, "Invalid IPv4 format")

        End If




    End Sub


    'on clicking a new connection, change buttons to be enabled/disabled
    'update name textbox to reflect change
    Private Sub listView_Connections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView_Connections.SelectedIndexChanged

        'enable and disable the buttons if a listviewitem is selected
        If listView_Connections.SelectedItems.Count <> 0 Then
            previousSelectedListViewItem = listView_Connections.SelectedItems(0)
            btn_forceRefresh.Enabled = True
            btn_toggleServerCheck.Enabled = True
            btnRemove.Enabled = True
            tb_ServerName.Enabled = True
            tb_ServerName.Text = listView_Connections.SelectedItems(0).SubItems(ListViewConsIDs.ServerName).Text
        Else
            btn_forceRefresh.Enabled = False
            btn_toggleServerCheck.Enabled = False
            btnRemove.Enabled = False
            tb_ServerName.Enabled = False
        End If

        'change server name if clicked and selected

    End Sub


    Private Sub listView_Connections_Disposed(sender As Object, e As EventArgs) Handles listView_Connections.Disposed

    End Sub

    'properly quit application on hitting X
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
        End
    End Sub

    'change the server's name on every change in the texbox
    'updates XML automatically
    Private Sub tb_ServerName_TextChanged(sender As Object, e As EventArgs) Handles tb_ServerName.TextChanged

        ' Console.WriteLine("toggling ip: " + listView_Connections.Items(0).ToString())
        If previousSelectedListViewItem IsNot Nothing Then
            previousSelectedListViewItem.Selected = True

            Dim currCon As Connection = XMLController.GetConnectionFromClientListXML(IPAddress.Parse(previousSelectedListViewItem.Text))
            currCon.setName(tb_ServerName.Text)
            XMLController.AddItemToClientListXML(currCon)

            'added due to crash relating to executing this code before loading the GUI
            If isLoaded Then
                UpdateViewFromXML()
            End If
        End If
        previousSelectedListViewItem.Selected = True

    End Sub



    'Set connection's status to be Offline, then refresh GUI
    Private Sub SetStatusToOffline(con As Connection)

        con.SetOffline()
        XMLController.AddItemToClientListXML(con)

        'added due to crash relating to executing this code before loading the GUI
        If isLoaded Then
            UpdateViewFromXML()
        End If
    End Sub

    'on click Settings, show the form
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If form_Settings.Visible Then
            form_Settings.Hide()
        Else
            form_Settings.Show()
        End If
    End Sub
    'Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
    'If form_Settings.Visible Then
    '       form_Settings.Hide()
    'Else
    '       form_Settings.Show()
    'End If
    'End Sub



    'update current memory to reflect settings form's textboxes,
    'then set all the correct variables And refresh program
    Public Sub UpdateSettingsValues()
        timerTickTime = form_Settings.RefreshRate
        MINS_TO_CHECK_SERVERS = form_Settings.TimeToOffline
        email = form_Settings.Email
        phone = form_Settings.Phone
        smsController.SetPhone(phone)


        If timer IsNot Nothing Then
            timer.Interval = timerTickTime
        End If

        messageController.SetEmail(email)


        Console.WriteLine("settings updated")
    End Sub

    Public Sub Hmpf()
        smsUser = form_Settings.User
        smsKey = form_Settings.Key
        phone = form_Settings.Phone

        smsController.SetUser(smsUser)
        smsController.SetKey(smsKey)
        smsController.SetPhone(phone)
    End Sub

    'pop up transfter client form
    'Private Sub btnTransClient_Click(sender As Object, e As EventArgs) Handles btnTransClient.Click
    '    If form_SendClient.Visible Then
    '        form_SendClient.Hide()
    '    Else
    '        form_SendClient.Show()
    '    End If
    'End Sub

    'remove items from the ListView
    'TODO: Make it work
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each item As ListViewItem In listView_Connections.SelectedItems
            Dim doc As New XmlDocument
            Dim nodes As XmlNodeList

            doc.Load("DATA\ClientList.xml")
            nodes = doc.SelectNodes("/Connections/Connection")

            item.Remove()
            For Each node As XmlNode In doc
                If node IsNot Nothing Then
                    node.RemoveAll()
                    doc.Save("DATA\ClientList.xml")

                End If
            Next
            MessageBox.Show("Removed offline nodes!")
        Next
    End Sub

    'Close the form
    Private Sub iconClose_Click(sender As Object, e As EventArgs) Handles iconClose.Click
        Me.Close()
    End Sub

    'Minimize the form
    Private Sub iconMinimize_Click(sender As Object, e As EventArgs) Handles iconMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Creates functions that call the Windows API, to allow the form to be dragged
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown, Label2.MouseDown, ServerLogo.MouseDown, gb_serverControls.MouseDown
        'If left mouse button, then execute DRAG API Call
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class




