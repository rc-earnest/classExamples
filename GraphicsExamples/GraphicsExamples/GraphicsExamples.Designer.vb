<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GraphicsExamples
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForeGroundColorTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Custom1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PickMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FontContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ControlToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DrawEquationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinWaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CosWaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.DrawEquationToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForeGroundColorTopMenuItem, Me.BackgroundColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ForeGroundColorTopMenuItem
        '
        Me.ForeGroundColorTopMenuItem.Name = "ForeGroundColorTopMenuItem"
        Me.ForeGroundColorTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ForeGroundColorTopMenuItem.Text = "&Foreground Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "&Background Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorContextMenuItem, Me.BackgroundColorContextMenuItem, Me.WidthContextMenuItem, Me.FontContextMenuItem, Me.ClearContextMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(171, 114)
        '
        'ForegroundColorContextMenuItem
        '
        Me.ForegroundColorContextMenuItem.Name = "ForegroundColorContextMenuItem"
        Me.ForegroundColorContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ForegroundColorContextMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorContextMenuItem
        '
        Me.BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem"
        Me.BackgroundColorContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorContextMenuItem.Text = "Background Color"
        '
        'WidthContextMenuItem
        '
        Me.WidthContextMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomMenuItem, Me.PickMenuItem})
        Me.WidthContextMenuItem.Name = "WidthContextMenuItem"
        Me.WidthContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WidthContextMenuItem.Text = "Width"
        '
        'CustomMenuItem
        '
        Me.CustomMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Custom1ToolStripTextBox})
        Me.CustomMenuItem.Name = "CustomMenuItem"
        Me.CustomMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CustomMenuItem.Text = "Custom"
        '
        'Custom1ToolStripTextBox
        '
        Me.Custom1ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Custom1ToolStripTextBox.Name = "Custom1ToolStripTextBox"
        Me.Custom1ToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        Me.Custom1ToolStripTextBox.Text = "1"
        '
        'PickMenuItem
        '
        Me.PickMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.PickMenuItem.Name = "PickMenuItem"
        Me.PickMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PickMenuItem.Text = "Pick"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'FontContextMenuItem
        '
        Me.FontContextMenuItem.Name = "FontContextMenuItem"
        Me.FontContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FontContextMenuItem.Text = "Font"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.White
        Me.DrawingPictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawingPictureBox.Location = New System.Drawing.Point(0, 25)
        Me.DrawingPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(600, 260)
        Me.DrawingPictureBox.TabIndex = 1
        Me.DrawingPictureBox.TabStop = False
        Me.ControlToolTip.SetToolTip(Me.DrawingPictureBox, "Right-Click for more options")
        '
        'DrawEquationToolStripMenuItem
        '
        Me.DrawEquationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinWaveToolStripMenuItem, Me.CosWaveToolStripMenuItem})
        Me.DrawEquationToolStripMenuItem.Name = "DrawEquationToolStripMenuItem"
        Me.DrawEquationToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.DrawEquationToolStripMenuItem.Text = "Draw Equation"
        '
        'SinWaveToolStripMenuItem
        '
        Me.SinWaveToolStripMenuItem.Name = "SinWaveToolStripMenuItem"
        Me.SinWaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SinWaveToolStripMenuItem.Text = "Sin Wave"
        '
        'CosWaveToolStripMenuItem
        '
        Me.CosWaveToolStripMenuItem.Name = "CosWaveToolStripMenuItem"
        Me.CosWaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CosWaveToolStripMenuItem.Text = "Cos Wave"
        '
        'GraphicsExamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GraphicsExamples"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForeGroundColorTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents ForegroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorContextMenuItem As ToolStripMenuItem
    Friend WithEvents WidthContextMenuItem As ToolStripMenuItem
    Friend WithEvents FontContextMenuItem As ToolStripMenuItem
    Friend WithEvents ClearContextMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomMenuItem As ToolStripMenuItem
    Friend WithEvents PickMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Custom1ToolStripTextBox As ToolStripTextBox
    Friend WithEvents ControlToolTip As ToolTip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawEquationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SinWaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CosWaveToolStripMenuItem As ToolStripMenuItem
End Class
