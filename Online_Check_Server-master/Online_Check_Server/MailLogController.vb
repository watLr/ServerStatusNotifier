Imports System.Net.Mail

Public Class MailLogController
    Public Property OpenFileDialog1 As Object

    Public Sub MailMe(sendTo As String)
        Dim errlog As String = "REPORT/ERROR_LOG.txt"
        Dim mail As New MailMessage()
        Dim SmtpServer As New SmtpClient("smtp.gmail.com")
        mail.From = New MailAddress("nycctservers@gmail.com")
        mail.[To].Add(sendTo)
        mail.Subject = "CST LAB: Server Error Report"
        mail.Body = "You are receiving a log summary of the servers which have gone down during this program's operation."
        Dim attachment As Attachment
        attachment = New Attachment(errlog)
        mail.Attachments.Add(attachment)

        SmtpServer.Port = 587
        SmtpServer.Credentials = New Net.NetworkCredential("nycctservers@gmail.com", "cstmonitor")
        SmtpServer.EnableSsl = True
        SmtpServer.Send(mail)
        mail.From = New MailAddress("nycctservers@gmail.com")
        MsgBox("E-mail Has Been Send Successfully !")

        'dispose of the process handling the file here allowing us to delete it
        mail.Attachments.Dispose()

    End Sub

End Class
