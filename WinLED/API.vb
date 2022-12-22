Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class API
    Public Structure Presets
        Public Property ID As Integer
        Public Property Name As String
    End Structure

    Public Class Root
        Public Property state As State
        Public Property info As Info
        Public Property effects As List(Of String)
        Public Property palettes As List(Of String)
    End Class

    Public Class State
        Public Property [On] As Boolean
        ' Other properties omitted for brevity
    End Class

    Public Class Info
        Public Property ver As String
        ' Other properties omitted for brevity
    End Class

    Public Shared Function GetPresets() As List(Of Presets)
        Dim jsonLoader As New JsonSerializer
        Dim webRequest As New WebClient
        Dim jsonString As String = webRequest.DownloadString(My.Settings.WLEDInstanceIP & "presets.json")
        ' parse the JSON string into a JObject
        Dim jsonObject As JObject = JObject.Parse(jsonString)
        Dim presetList As New List(Of Presets)
        Dim counter As Integer = 0 ' counter variable
        For Each prop As JProperty In jsonObject.Properties
            counter += 1 ' increment the counter
            If counter = 1 Then ' skip the first object
                Continue For
            End If
            ' get the value of the property, which should be a JObject
            Dim item As JObject = prop.Value
            ' check if the "n" value is not empty
            If Not String.IsNullOrEmpty(item("n").Value(Of String)) Then
                ' extract the "n" value from the JObject
                Dim name As String = item("n").Value(Of String)
                Dim id As Integer = Convert.ToInt32(prop.Name)
                Dim newPreset As New Presets With {
                    .ID = id,
                    .Name = name
                }
                presetList.Add(newPreset)
            End If
        Next
        Return presetList
    End Function
    Public Shared Function GetEffects() As List(Of String)
        Try
Restart:
            Dim jsonLoader As New JsonSerializer
            Dim webRequest As New WebClient
            Dim jsonString As String = webRequest.DownloadString(My.Settings.WLEDInstanceIP & "json")
            Dim root As Root = JsonConvert.DeserializeObject(Of Root)(jsonString)
            Dim effects As List(Of String) = root.effects
            Return effects
        Catch ex As Exception
            GoTo Restart
        End Try
    End Function

    Public Shared Function GetPalettes() As List(Of String)
        Try
Restart:
            Dim jsonLoader As New JsonSerializer
            Dim webRequest As New WebClient
            Dim jsonString As String = webRequest.DownloadString(My.Settings.WLEDInstanceIP & "json")
            Dim root As Root = JsonConvert.DeserializeObject(Of Root)(jsonString)
            Dim palettes As List(Of String) = root.palettes
            Return palettes
        Catch ex As Exception
            GoTo Restart
        End Try
    End Function
End Class
