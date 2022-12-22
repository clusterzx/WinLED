<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWinLEDSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAutoStartWindows = New System.Windows.Forms.CheckBox()
        Me.chkPresetRunUp = New System.Windows.Forms.CheckBox()
        Me.cmbPresets = New System.Windows.Forms.ComboBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.cmbPresets)
        Me.GroupBox1.Controls.Add(Me.chkPresetRunUp)
        Me.GroupBox1.Controls.Add(Me.chkAutoStartWindows)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 94)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'chkAutoStartWindows
        '
        Me.chkAutoStartWindows.AutoSize = True
        Me.chkAutoStartWindows.Location = New System.Drawing.Point(6, 19)
        Me.chkAutoStartWindows.Name = "chkAutoStartWindows"
        Me.chkAutoStartWindows.Size = New System.Drawing.Size(166, 17)
        Me.chkAutoStartWindows.TabIndex = 0
        Me.chkAutoStartWindows.Text = "Start WinLED with Windows?"
        Me.chkAutoStartWindows.UseVisualStyleBackColor = True
        '
        'chkPresetRunUp
        '
        Me.chkPresetRunUp.AutoSize = True
        Me.chkPresetRunUp.Location = New System.Drawing.Point(6, 42)
        Me.chkPresetRunUp.Name = "chkPresetRunUp"
        Me.chkPresetRunUp.Size = New System.Drawing.Size(145, 17)
        Me.chkPresetRunUp.TabIndex = 1
        Me.chkPresetRunUp.Text = "Apply Preset on StartUp?"
        Me.chkPresetRunUp.UseVisualStyleBackColor = True
        '
        'cmbPresets
        '
        Me.cmbPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPresets.Enabled = False
        Me.cmbPresets.FormattingEnabled = True
        Me.cmbPresets.Location = New System.Drawing.Point(157, 38)
        Me.cmbPresets.Name = "cmbPresets"
        Me.cmbPresets.Size = New System.Drawing.Size(208, 21)
        Me.cmbPresets.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(6, 65)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(359, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Save Settings"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'frmWinLEDSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 109)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmWinLEDSettings"
        Me.Text = "WinLED - Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmbPresets As ComboBox
    Friend WithEvents chkPresetRunUp As CheckBox
    Friend WithEvents chkAutoStartWindows As CheckBox
End Class
