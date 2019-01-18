Imports System.IO
'Imports System.IO.File

Public Class LogController

    Dim mailLogController As New MailLogController

    Public Sub WriteErrorLog(con As Connection)

        Dim errFile As String = "REPORT/ERROR_LOG.txt"

        'writes continuously by appending to the file
        Using sw As StreamWriter = File.AppendText(errFile)

            sw.WriteLine("time=" + Date.Now + "  error='CONNECTION REFUSED' ip='" + con.getIP)
            sw.WriteLine("------------------------------------------------")

            'the process needs to be closed before the file can be read
            sw.Close()

            'counts the lines of the log file
            Dim lineCount = File.ReadAllLines(errFile).Length

            'condition for limiting log file size
            'sends log attachment at limit and deletes file after
            If lineCount > 2 Then

                'when condition Is met the method to mail log Is invoked
                'creating array of objects from xml document to send email addresses to method mailing the log

                Dim filed As FileStream = New FileStream("DATA/Alert.xml", FileMode.Open)
                Dim xmldoc As XDocument = XDocument.Load(filed)
                Dim recipient = (From p In xmldoc.Descendants("Setting") Select New With {
            Key .Phone = p.Element("Phone").Value, Key .Mail = p.Element("Email").Value}).ToArray()

                For Each person In recipient
                    mailLogController.MailMe(person.Mail)
                Next

                File.Delete(errFile)

            End If

        End Using

    End Sub


End Class
