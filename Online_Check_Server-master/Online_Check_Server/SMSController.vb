Imports TextmagicRest

Public Class SMSController
    Dim phone As String
    Dim user As String
    Dim key As String
    ', user As String, key As String
    Sub New(phone As String, user As String, key As String)
        Me.user = user
        Me.key = key
        Me.phone = phone
    End Sub

    Public Sub SendText(con As Connection, ByVal sender As String, ByVal acc As String, ByVal api As String)
        Dim client = New Client(acc, api)
        Dim link = client.SendMessage("Server " + con.getIP() + "is Down!", sender)
        If link.Success Then
            Console.WriteLine("Message with ID {0} has been successfully sent", link.Id)
        Else
            Console.WriteLine("Message was not sent due to following exception: " + link.ClientException.Message)
        End If
    End Sub

    Public Sub SetPhone(phone As String)
        Me.phone = phone
    End Sub

    Public Sub SetUser(user As String)
        Me.user = user
    End Sub

    Public Sub SetKey(key As String)
        Me.key = key
    End Sub
End Class
