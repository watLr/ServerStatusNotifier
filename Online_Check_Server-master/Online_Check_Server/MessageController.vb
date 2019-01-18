Imports System.Net
Imports System.Net.Mail

Public Class MessageController

    Dim email As String
    Sub New(email As String)
        Me.email = email
    End Sub

    Public Sub SendEmail(con As Connection, ByVal sendTo As String)

        Dim MyMailMessage As New MailMessage
        MyMailMessage.From = New MailAddress("NYCCTServers@gmail.com")
        MyMailMessage.To.Add(sendTo)
        MyMailMessage.Subject = "Server Status"
        MyMailMessage.Body = "Server at IP " + con.getIP() + " is down!"
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

    Public Sub SetEmail(email As String)
        Me.email = email
    End Sub

End Class