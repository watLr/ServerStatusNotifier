Imports System.Net
Imports System.Net.Mail

Public Class FeedBController

    Public Sub SendFeedback(fb As String)
        Dim MyMailMessage As New MailMessage
        MyMailMessage.From = New MailAddress("NYCCTServers@gmail.com")
        MyMailMessage.To.Add("nycctservers@gmail.com")
        MyMailMessage.Subject = "Feedback from Customer"
        MyMailMessage.Body = fb
        Dim SMTPServer As New SmtpClient("smtp.gmail.com")
        SMTPServer.Port = 587
        SMTPServer.Credentials = New NetworkCredential("NYCCTservers", "cstmonitor")
        SMTPServer.EnableSsl = True
        Try
            SMTPServer.Send(MyMailMessage)
            Console.Write("Your Email has been sent sucessfully - Thank You")
        Catch ex As SmtpException
            Console.Write(ex.Message)
        End Try
    End Sub

End Class
