Imports System.Xml

Public Class XMLAlertController
    Shared alertFileLocation As String = "DATA\Alert.xml"
    Shared smsFileLocation As String = "DATA\Sms.xml"

    Shared XlDoc As New XmlDocument()

    'creating an xml file
    Sub New()

        'Settings List
        If System.IO.File.Exists(alertFileLocation) Then
            Console.WriteLine("ALERT FILE EXISTS")
        Else
            Console.WriteLine("ALERT FILE DOES NOT EXIST")
            ' Create XmlWriterSettings.
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            ' Create XmlWriter.
            Using writer As XmlWriter = XmlWriter.Create(alertFileLocation, settings)
                ' Begin writing.
                writer.WriteStartDocument()
                writer.WriteStartElement("Settings") ' Root.


                ' End document.
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            Console.WriteLine("FILE CREATED")
        End If

        'Sms List
        If System.IO.File.Exists(smsFileLocation) Then
            Console.WriteLine("SMS FILE EXISTS")
        Else
            Console.WriteLine("SMS FILE DOES NOT EXIST")
            ' Create XmlWriterSettings.
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True

            ' Create XmlWriter.
            Using writer As XmlWriter = XmlWriter.Create(smsFileLocation, settings)
                ' Begin writing.
                writer.WriteStartDocument()
                writer.WriteStartElement("Settings") ' Root.


                ' End document.
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
            Console.WriteLine("FILE CREATED")
        End If


        'load files into memory
        XlDoc.Load(alertFileLocation)
        XlDoc.Load(smsFileLocation)

    End Sub

    'create list of string based on XML settings
    '0 is Phone
    '1 is Email
    Public Shared Function goSettings() As List(Of String)
        Dim alert As New List(Of String)

        Try
            Dim doc As XmlDocument
            Dim nodeList As XmlNodeList
            Dim currentNode As XmlNode
            'Create the XML Document
            doc = New XmlDocument()
            'Load the Xml file
            doc.Load(alertFileLocation)
            'Get the alert of name nodes 
            nodeList = doc.SelectNodes("/Settings/Setting")
            'Loop through the nodes
            For Each currentNode In nodeList
                alert.Add(currentNode.ChildNodes(0).InnerText)
                alert.Add(currentNode.ChildNodes(1).InnerText)

                Return alert
            Next
        Catch errorVariable As Exception
            'error trapping
            Console.Write(errorVariable.ToString())
        End Try

        If alert.Count = 0 Then
            alert.AddRange({"", ""})
        End If

        Return alert

    End Function

    'create list of string based on XML settings
    '0 is Sms Username
    '1 is Sms API Key
    Public Shared Function loadSettings1() As List(Of String)
        Dim list As New List(Of String)

        Try
            Dim doc As XmlDocument
            Dim nodeList As XmlNodeList
            Dim currentNode As XmlNode
            'Create the XML Document
            doc = New XmlDocument()
            'Load the Xml file
            doc.Load(smsFileLocation)
            'Get the alert of name nodes 
            nodeList = doc.SelectNodes("/Settings/Setting")
            'Loop through the nodes
            For Each currentNode In nodeList
                list.Add(currentNode.ChildNodes(0).InnerText)
                list.Add(currentNode.ChildNodes(1).InnerText)

                Return list
            Next
        Catch errorVariable As Exception
            'error trapping
            Console.Write(errorVariable.ToString())
        End Try

        If list.Count = 0 Then
            list.AddRange({"", ""})
        End If

        Return list

    End Function

    'save settings from alert of string to setting xml file
    '0 is Sms Username
    '1 is Sms API Key

    Public Shared Sub saveSettings1(list As List(Of String))

        Dim doc As XDocument = XDocument.Load(smsFileLocation)

        Dim node As XElement = doc.Descendants("Setting").FirstOrDefault()

        Dim currEle = New XElement("Setting")

        'If the current connection does not exist, create it, otherwise skip if
        If node Is Nothing Then
            doc.Element("Settings").Add(currEle)
            node = currEle

        End If

        'updated current connection settings
        node.SetElementValue("User", list(0))
        node.SetElementValue("Key", list(1))

        doc.Save(smsFileLocation)

    End Sub

    'save settings from alert of string to setting xml file
    '0 is Phone
    '1 is Email

    Public Shared Sub persistSettings(alert As List(Of String))

        Dim doc As XDocument = XDocument.Load(alertFileLocation)

        Dim node As XElement = doc.Descendants("Setting").FirstOrDefault()

        Dim currEle = New XElement("Setting")

        'If the current connection does not exist, create it, otherwise skip if
        If node Is Nothing Then
            doc.Element("Settings").Add(currEle)
            node = currEle
        ElseIf node IsNot Nothing Then
            doc.Element("Settings").Add(currEle)
            node = currEle

        End If

        'updated current connection settings
        node.SetElementValue("Phone", alert(0))
        node.SetElementValue("Email", alert(1))

        doc.Save(alertFileLocation)

    End Sub
End Class
