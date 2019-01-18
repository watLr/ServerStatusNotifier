Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Xml

Public Class EditXML

    Private Sub EditXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateView()
    End Sub

    Public Sub UpdateView()
        Dim doc As New Xml.XmlDocument
        doc.Load("DATA/Alert.xml")
        For Each node As Xml.XmlNode In doc.SelectNodes("/Settings/Setting")
            Dim item As New ListViewItem(node.ChildNodes(0).InnerText)
            item.SubItems.Add(node.ChildNodes(1).InnerText)
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim doc As New XmlDocument()
        My.Computer.Audio.Play(My.Resources.removeaudio, AudioPlayMode.Background)
        doc.Load("DATA/Alert.xml")

        Dim node As XmlNode = doc.SelectSingleNode("/Settings/Setting")

        If node IsNot Nothing Then

            node.ParentNode.RemoveChild(node)

            ' Save change here or later e.g.
            doc.Save("DATA/Alert.xml")
            MessageBox.Show("item removed")
        End If

        For Each item As ListViewItem In ListView1.SelectedItems
            item.Remove()
        Next
    End Sub

    'Close the form
    Private Sub iconClose_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()

        ListView1.Refresh()
    End Sub

    Private Sub EditXML_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.ListView1.Items.Count = 0 Then
            UpdateView()
        End If
    End Sub

    Private Sub EditXML_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        'e.Cancel = False
    End Sub

    Private Sub EditXML_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ListView1.Refresh()
    End Sub
    'this makes the form draggable 

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub MenuStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip1.MouseDown
        'If left mouse button, then execute DRAG API Call
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub RemoveRecipientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveRecipientToolStripMenuItem.Click
        MessageBox.Show("Your email and phone are permanantly deleted in this form." & vbCrLf & "You will no longer recieve alerts.")
    End Sub
End Class