Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices

Public Class Settings
    'default should Richard's email
    Private Default_Email = "david.whitegoode@mail.citytech.cuny.edu"
    Private Default_TimeToOffline = "3"
    Private Default_RefreshRate = "10000"



    Public Email As String = ""
    Public TimeToOffline As String = ""
    Public RefreshRate As String = ""
    Public Phone As String = ""
    Public User As String = ""
    Public Key As String = ""

    Private mainForm As Form1


    Sub New(mainForm As Form1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.mainForm = mainForm

        'list of settings
        'explained in XML controller class
        Dim list As List(Of String) = XMLController.loadSettings()

        'Email = list(0)
        RefreshRate = list(0)
        TimeToOffline = list(1)

        Dim alert As List(Of String) = XMLAlertController.goSettings()
        Phone = alert(0)
        Email = alert(1)

        'saving edited sms fields
        Dim sms As List(Of String) = XMLAlertController.loadSettings1()
        'sm.SUser = sms(0)
        'sm.SKey = sms(1)
        User = sms(0)
        Key = sms(1)

        'sm.no1.Text = User
        'sm.no1.Text = Key
        tb_User.Text = User
        tb_Key.Text = Key
        tb_Phone.Text = Phone
        tb_Email.Text = Email
        tb_RefreshRate.Text = RefreshRate
        tb_TimeToOffline.Text = TimeToOffline


        'set text boxes to settings or defaults
        If tb_Email.Text = "" Then
            tb_Email.Text = Default_Email
            Email = Default_Email
        End If
        If tb_RefreshRate.Text = "" Then
            tb_RefreshRate.Text = Default_RefreshRate
            RefreshRate = Default_RefreshRate
        End If
        If tb_TimeToOffline.Text = "" Then
            tb_TimeToOffline.Text = Default_TimeToOffline
            TimeToOffline = Default_TimeToOffline
        End If

    End Sub

    'Sets the refresh rate variables
    'everytime the texbox changes, we're going to try to parse it and display or hide an error based on regex
    Private Sub tb_RefreshRate_TextChanged(sender As Object, e As EventArgs) Handles tb_RefreshRate.TextChanged
        Dim tb As TextBox = sender
        Dim regexString = "^[0-9]*$" 'Numbers only
        ' if lower and higher ip matches regex
        If Not Regex.IsMatch(tb.Text, regexString) Then
            ep_refresh.SetError(tb, "Must be a number")
        Else
            ep_refresh.SetError(tb, "")
            RefreshRate = tb.Text
        End If


    End Sub

    'sets the time to offline text box
    'everytime the texbox changes, we're going to try to parse it and display or hide an error based on regex
    Private Sub tb_TimeToOffline_TextChanged(sender As Object, e As EventArgs) Handles tb_TimeToOffline.TextChanged

        Dim tb As TextBox = sender
        Dim regexString = "^[0-9]\d{0,9}(\.\d{1,3})?%?$" 'numbers only
        ' if lower and higher ip matches regex
        If Not Regex.IsMatch(tb.Text, regexString) Then
            ep_offlineTime.SetError(tb, "Must be a number")
        Else
            ep_offlineTime.SetError(tb, "")
            TimeToOffline = tb.Text
        End If

    End Sub

    'sets the email address variables
    'everytime the texbox changes, we're going to try to parse it and display or hide an error based on regex
    Private Sub tb_EmailAddress_TextChanged(sender As Object, e As EventArgs) Handles tb_Email.TextChanged

        Dim tb As TextBox = sender
        Dim regexString = "^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$" 'matches email
        ' if lower and higher ip matches regex
        If Not Regex.IsMatch(tb.Text, regexString) Then
            ep_Email.SetError(tb, "Must be a valid email")
        Else
            ep_Email.SetError(tb, "")
            Email = tb.Text
        End If

    End Sub

    'on clicking X, hide the window
    'needed because otherwise it'll either crash the program due to null variables
    'or it'll just close it.
    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        e.Cancel = True
    End Sub

    'save settings to XML file and memory
    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        'make sure all 3 text boxes dont have an arror
        'if they do not, save them to xml and memory and display a message to confirm
        'otherwise, do nothing and pop up an error message
        If ep_Email.GetError(tb_Email) Is "" _
                        And ep_refresh.GetError(tb_RefreshRate) Is "" _
                        And ep_offlineTime.GetError(tb_TimeToOffline) Is "" Then
            Dim list As New List(Of String)
            list.AddRange({RefreshRate, TimeToOffline})
            XMLController.saveSettings(list)
            mainForm.UpdateSettingsValues()
            MsgBox("Settings Saved", MsgBoxStyle.Information)

        Else
            MsgBox("Invalid inputs, settings not saved", MsgBoxStyle.Exclamation, "Error")


        End If

    End Sub

    Private Sub btn_addPhone_Click(sender As Object, e As EventArgs) Handles btn_Phone.Click
        'add validation here
        Dim regexString = "^\s*(?:\+?(\d{1,3}))?[-. (]*(\d{3})[-. )]*(\d{3})[-. ]*(\d{4})(?: *x(\d+))?\s*$" 'matches phone
        If Not Regex.IsMatch(Phone, regexString) Then
            MessageBox.Show("Must be a valid phone number")
        Else
            'adding a number to list for xml controller
            Dim alert As New List(Of String)
            alert.AddRange({Phone, Email})
            XMLAlertController.persistSettings(alert)
            'mainForm.UpdateSettingsValues()
            My.Computer.Audio.Play(My.Resources.alertaudio2, AudioPlayMode.Background)
        End If
    End Sub

    'Close the form
    Private Sub iconClose_Click(sender As Object, e As EventArgs) Handles iconClose.Click
        Me.Close()
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

    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown, ServerLogo.MouseDown, MenuStrip1.MouseDown
        'If left mouse button, then execute DRAG API Call
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub RemoveRecipientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveRecipientToolStripMenuItem.Click
        Me.Hide()

        Dim ed As New EditXML
        ed.Show()

    End Sub

    Private Sub EditSMSSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'sm.Show()
    End Sub

    Private Sub tb_Phone_TextChanged(sender As Object, e As EventArgs) Handles tb_Phone.TextChanged
        Phone = tb_Phone.Text
    End Sub

    Private Sub tb_User_TextChanged(sender As Object, e As EventArgs) Handles tb_User.TextChanged
        User = tb_User.Text
    End Sub

    Private Sub tb_Key_TextChanged(sender As Object, e As EventArgs) Handles tb_Key.TextChanged
        Key = tb_Key.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' MessageBox.Show("added")
        My.Computer.Audio.Play(My.Resources.settingsupdate, AudioPlayMode.Background)
        Dim list As New List(Of String)
        list.AddRange({User, Key})
        XMLAlertController.saveSettings1(list)
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        Dim fbf As New FeedbackForm
        fbf.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Use a TextMagic API Key and Username to start receiving texts alerts." & vbCrLf & "To use a different SMS service such as Twilio, please contact your developers.")
    End Sub
End Class