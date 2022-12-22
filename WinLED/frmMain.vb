Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports MechanikaDesign.WinForms.UI.ColorPicker
Imports WinLED.Functions.HSL
Imports WinLED.Functions.RGB
Imports WinLED.HTTP_API
Imports System.Net.Http
Imports System.Text.RegularExpressions

Public Class frmMain
    Dim presets As List(Of API.Presets)
    Dim webCall As New HTTP_API
    Dim wledInstance As String = My.Settings.WLEDInstanceIP
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If wledInstance = "" Then
            MsgBox("Please Setup your Instance", vbExclamation, "Warning")
            Dim answer = InputBox("For ex. http://192.168.0.54/ or http://wledinstance.local/", "Enter address to your WLED Instance")
            My.Settings.WLEDInstanceIP = answer
            wledInstance = answer
            MsgBox("WinLED is now set up. Please restart the application now. It will automatically terminate after you click ok", MsgBoxStyle.OkOnly, "NOICE!")
            Application.Exit()
        Else
            If My.Settings.RunPreset = True And My.Settings.PresetID > 0 Then
                webCall.CallApi("PL=" & My.Settings.PresetID + 1)
            End If
            cmbEffects.Items.AddRange(API.GetEffects().ToArray)
            cmbPalettes.Items.AddRange(API.GetPalettes().ToArray)
            presets = API.GetPresets
            Dim parentMenuItem As New ToolStripMenuItem("Presets")
            Dim counter As Integer = 0
            For Each effect In presets
                lbPresets.Items.Add(effect.Name)
                counter += 1
                Dim menuItem As New ToolStripMenuItem(counter & "-" & effect.Name)
                parentMenuItem.DropDownItems.Add(menuItem)
                AddHandler menuItem.Click, AddressOf MenuItem_Click
            Next
            ' Add the parent menu item (the drop-down menu) to the ContextMenuStrip
            ContextMenuStrip1.Items.Add(parentMenuItem)
        End If
    End Sub
    Private Sub MenuItem_Click(sender As Object, e As EventArgs)
        Dim clickedItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        ' Get the name of the clicked MenuItem
        Dim name As String = clickedItem.Text
        Dim id As Integer = GetNumberBeforeHyphen(name)
        webCall.CallApi("PL=" & id)
    End Sub
    Public Function GetNumberBeforeHyphen(input As String) As Integer
        Dim pattern As String = "^\d+-"
        Dim match As Match = Regex.Match(input, pattern)
        If match.Success Then
            Dim number As String = match.Value.TrimEnd("-"c)
            Return Int32.Parse(number)
        Else
            Return 0
        End If
    End Function

    Private Sub ColorWheel1_ColorChangedAsync(sender As Object, e As EventArgs) Handles ColorWheel1.ColorChanged
        If ColorWheel1.Color.R And ColorWheel1.Color.G And ColorWheel1.Color.B = 127 Then
            Dim tempColor As Color
            lblColorCodeRGB.Text = "RGB Code: 255-255-255"
            tempColor = ColorWheel1.Color
            pbColorWheelPreview.BackColor = Color.White
            Dim c As Color = Color.White
            webCall.CallApi("CL=255255255&FX=0")
        Else
            Dim tempColor As Color
            lblColorCodeRGB.Text = "RGB Code: " & ColorWheel1.Color.R & "-" & ColorWheel1.Color.G & "-" & ColorWheel1.Color.B
            tempColor = ColorWheel1.Color
            pbColorWheelPreview.BackColor = tempColor
            Dim c As Color = tempColor
            webCall.CallApi("R=" + ColorWheel1.Color.R.ToString + "&G=" + ColorWheel1.Color.G.ToString + "&B=" + ColorWheel1.Color.B.ToString + "&W=" + ColorWheel1.Color.A.ToString + "&FX=0")
        End If
    End Sub

    Private Sub tbBrightness_Scroll(sender As Object, e As EventArgs) Handles tbBrightness.Scroll
        lblBrightness.Text = "Brightness: " + tbBrightness.Value.ToString
        webCall.CallApi("A=" + tbBrightness.Value.ToString)
    End Sub

    Private Sub cmdOnOffToggle_Click(sender As Object, e As EventArgs) Handles cmdOnOffToggle.Click
        If webCall.CallApi("T=2") = False Then
            MsgBox("Error")
        End If
    End Sub

    Private Sub lbPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPresets.SelectedIndexChanged
        Try
            For i As Integer = 0 To presets.Count - 1
                If presets(i).Name = lbPresets.SelectedItem.ToString Then
                    If webCall.CallApi("PL=" & i + 1) = False Then
                        MsgBox("Error")
                    End If
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbEffects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEffects.SelectedIndexChanged
        If webCall.CallApi("FX=" + cmbEffects.SelectedIndex.ToString) = False Then
            MsgBox("Error")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        frmWinLEDSettings.Show()
    End Sub

    Private Sub WLEDConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WLEDConfigToolStripMenuItem.Click
        If My.Settings.WLEDInstanceIP = "" Then
            Dim answer = InputBox("For ex. http://192.168.0.54/ or http://wledinstance.local/", "Enter address to your WLED Instance")
            If answer IsNot "" Or answer.Length > 5 Then
                My.Settings.WLEDInstanceIP = answer
                MsgBox("WinLED is now set up. Please restart the application now. It will automatically terminate after you click ok", MsgBoxStyle.OkOnly, "NOICE!")
                Application.Exit()
            End If
        Else
            Dim answer = MsgBox("Following WLED Instance is registered: " + My.Settings.WLEDInstanceIP + vbNewLine + "Would you like to reset it?", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                My.Settings.WLEDInstanceIP = ""
                Dim answerx = InputBox("For ex. http://192.168.0.54/ or http://wledinstance.local/", "Enter address to your WLED Instance")
                If answerx IsNot "" Or answerx.Length > 5 Then
                    My.Settings.WLEDInstanceIP = answerx
                    MsgBox("WinLED is now set up. Please restart the application now. It will automatically terminate after you click ok", MsgBoxStyle.OkOnly, "NOICE!")
                    Application.Exit()
                End If
            Else
                MsgBox("Ok :) ... you are still good to go.", vbInformation, "KEK")
            End If
        End If
    End Sub

    Private Sub notifyBar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notifyBar.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = True
            Me.Visible = False
        End If
    End Sub
End Class
