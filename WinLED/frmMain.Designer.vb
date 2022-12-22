<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbPresets = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBrightness = New System.Windows.Forms.Label()
        Me.tbBrightness = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPalettes = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEffects = New System.Windows.Forms.ComboBox()
        Me.cmdOnOffToggle = New System.Windows.Forms.Button()
        Me.ColorWheel1 = New MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbColorWheelPreview = New System.Windows.Forms.PictureBox()
        Me.lblColorCodeRGB = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WLEDConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tbBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbColorWheelPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbPresets)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presets"
        '
        'lbPresets
        '
        Me.lbPresets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPresets.FormattingEnabled = True
        Me.lbPresets.Location = New System.Drawing.Point(6, 19)
        Me.lbPresets.Name = "lbPresets"
        Me.lbPresets.Size = New System.Drawing.Size(245, 119)
        Me.lbPresets.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBrightness)
        Me.GroupBox2.Controls.Add(Me.tbBrightness)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Brightness"
        '
        'lblBrightness
        '
        Me.lblBrightness.AutoSize = True
        Me.lblBrightness.Location = New System.Drawing.Point(6, 45)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(62, 13)
        Me.lblBrightness.TabIndex = 1
        Me.lblBrightness.Text = "Brightness: "
        '
        'tbBrightness
        '
        Me.tbBrightness.Location = New System.Drawing.Point(6, 14)
        Me.tbBrightness.Maximum = 255
        Me.tbBrightness.Name = "tbBrightness"
        Me.tbBrightness.Size = New System.Drawing.Size(447, 45)
        Me.tbBrightness.TabIndex = 0
        Me.tbBrightness.TickStyle = System.Windows.Forms.TickStyle.None
        Me.tbBrightness.Value = 255
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbPalettes)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmbEffects)
        Me.GroupBox3.Controls.Add(Me.cmdOnOffToggle)
        Me.GroupBox3.Location = New System.Drawing.Point(275, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 386)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Quick Commands"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Color Palettes"
        '
        'cmbPalettes
        '
        Me.cmbPalettes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPalettes.FormattingEnabled = True
        Me.cmbPalettes.Location = New System.Drawing.Point(6, 120)
        Me.cmbPalettes.Name = "cmbPalettes"
        Me.cmbPalettes.Size = New System.Drawing.Size(184, 21)
        Me.cmbPalettes.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Effects"
        '
        'cmbEffects
        '
        Me.cmbEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEffects.FormattingEnabled = True
        Me.cmbEffects.Location = New System.Drawing.Point(6, 71)
        Me.cmbEffects.Name = "cmbEffects"
        Me.cmbEffects.Size = New System.Drawing.Size(184, 21)
        Me.cmbEffects.TabIndex = 1
        '
        'cmdOnOffToggle
        '
        Me.cmdOnOffToggle.Location = New System.Drawing.Point(6, 19)
        Me.cmdOnOffToggle.Name = "cmdOnOffToggle"
        Me.cmdOnOffToggle.Size = New System.Drawing.Size(184, 26)
        Me.cmdOnOffToggle.TabIndex = 0
        Me.cmdOnOffToggle.Text = "On/Off"
        Me.cmdOnOffToggle.UseVisualStyleBackColor = True
        '
        'ColorWheel1
        '
        Me.ColorWheel1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColorWheel1.Location = New System.Drawing.Point(6, 19)
        Me.ColorWheel1.Name = "ColorWheel1"
        Me.ColorWheel1.Size = New System.Drawing.Size(251, 173)
        Me.ColorWheel1.TabIndex = 3
        Me.ColorWheel1.Text = "ColorWheel1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pbColorWheelPreview)
        Me.GroupBox4.Controls.Add(Me.lblColorCodeRGB)
        Me.GroupBox4.Controls.Add(Me.ColorWheel1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 231)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Color Wheel for static Colors"
        '
        'pbColorWheelPreview
        '
        Me.pbColorWheelPreview.Location = New System.Drawing.Point(195, 179)
        Me.pbColorWheelPreview.Name = "pbColorWheelPreview"
        Me.pbColorWheelPreview.Size = New System.Drawing.Size(56, 46)
        Me.pbColorWheelPreview.TabIndex = 5
        Me.pbColorWheelPreview.TabStop = False
        '
        'lblColorCodeRGB
        '
        Me.lblColorCodeRGB.AutoSize = True
        Me.lblColorCodeRGB.Location = New System.Drawing.Point(6, 206)
        Me.lblColorCodeRGB.Name = "lblColorCodeRGB"
        Me.lblColorCodeRGB.Size = New System.Drawing.Size(62, 13)
        Me.lblColorCodeRGB.TabIndex = 4
        Me.lblColorCodeRGB.Text = "Color Code:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(483, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WLEDConfigToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'WLEDConfigToolStripMenuItem
        '
        Me.WLEDConfigToolStripMenuItem.Name = "WLEDConfigToolStripMenuItem"
        Me.WLEDConfigToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WLEDConfigToolStripMenuItem.Text = "WLED Config"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OptionsToolStripMenuItem.Text = "WinLED Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 495)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "WinLED 0.1b"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tbBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbColorWheelPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbPresets As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbBrightness As TrackBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdOnOffToggle As Button
    Friend WithEvents ColorWheel1 As MechanikaDesign.WinForms.UI.ColorPicker.ColorWheel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pbColorWheelPreview As PictureBox
    Friend WithEvents lblColorCodeRGB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbPalettes As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEffects As ComboBox
    Friend WithEvents lblBrightness As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WLEDConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
