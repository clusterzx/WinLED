Imports System.Reflection
Imports Microsoft.Win32
Imports WinLED.API

Public Class frmWinLEDSettings
    Dim presets As List(Of API.Presets)
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If chkAutoStartWindows.Checked = True Then
            My.Settings.Autostart = True
            Dim apppath As String = Assembly.GetExecutingAssembly().Location
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            key.SetValue("WinLED", apppath)
            key.Close()
        Else
            My.Settings.Autostart = False
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            key.DeleteValue("WinLED", False)
            key.Close()
        End If
        If chkPresetRunUp.Checked = True Then
            My.Settings.RunPreset = True
            My.Settings.PresetID = cmbPresets.SelectedIndex
        Else
            My.Settings.RunPreset = False
            My.Settings.PresetID = Nothing
        End If
    End Sub

    Private Sub frmWinLEDSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkAutoStartWindows.Checked = My.Settings.Autostart
        chkPresetRunUp.Checked = My.Settings.RunPreset
    End Sub

    Private Sub chkPresetRunUp_CheckedChanged(sender As Object, e As EventArgs) Handles chkPresetRunUp.CheckedChanged
        If chkPresetRunUp.Checked = True Then
            presets = API.GetPresets()
            For Each effect In presets
                cmbPresets.Items.Add(effect.ID)
            Next
            cmbPresets.Enabled = True
        Else
            cmbPresets.Enabled = False
        End If
    End Sub
End Class