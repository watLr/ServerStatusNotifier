Imports System.Runtime.InteropServices

Public Class FeedbackForm

    Dim fbmessage As String
    Dim defaultmessage As String = "How are we doing?"
    Dim fbcontroller As New FeedBController


    'Creates functions that call the Windows API, to allow the form to be dragged
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown, ServerLogo.MouseDown
        'If left mouse button, then execute DRAG API Call
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub iconClose_Click(sender As Object, e As EventArgs) Handles iconClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("your feedback is appreciated")

        'sends contents to method for email
        fbcontroller.SendFeedback(fbmessage)
        Me.Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        fbmessage = RichTextBox1.Text
    End Sub

    Private Sub FeedbackForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        RichTextBox1.Text = defaultmessage
    End Sub

    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If RichTextBox1.Text = defaultmessage Then
            RichTextBox1.Text = ""
        End If
    End Sub

End Class