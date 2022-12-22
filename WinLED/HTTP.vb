Imports System.Net.WebClient
Public Class HTTP_API
    Public Function CallApi(ByVal query As String) As Boolean
        Dim wc As New Net.WebClient
        If wc.DownloadString(My.Settings.WLEDInstanceIP & "win&" + query) IsNot Nothing Then
            Clipboard.SetText(My.Settings.WLEDInstanceIP & "win&" + query)
            Return True
        End If
    End Function
End Class
