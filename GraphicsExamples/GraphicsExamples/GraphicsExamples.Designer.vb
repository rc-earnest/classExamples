﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ForegroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WidthContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.MainContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForeGroundColorTopMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ForeGroundColorTopMenuItem
        '
        Me.ForeGroundColorTopMenuItem.Name = "ForeGroundColorTopMenuItem"
        Me.ForeGroundColorTopMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ForeGroundColorTopMenuItem.Text = "Fore Ground Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForegroundColorContextMenuItem, Me.BackgroundColorContextMenuItem, Me.WidthContextMenuItem, Me.FontContextMenuItem, Me.ClearContextMenuItem})
        Me.MainContextMenuStrip.Name = "MainContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(211, 152)
        '
        'ForegroundColorContextMenuItem
        '
        Me.ForegroundColorContextMenuItem.Name = "ForegroundColorContextMenuItem"
        Me.ForegroundColorContextMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ForegroundColorContextMenuItem.Text = "Foreground Color"
        '
        'BackgroundColorContextMenuItem
        '
        Me.BackgroundColorContextMenuItem.Name = "BackgroundColorContextMenuItem"
        Me.BackgroundColorContextMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.BackgroundColorContextMenuItem.Text = "Background Color"
        '
        'WidthContextMenuItem
        '
        Me.WidthContextMenuItem.Name = "WidthContextMenuItem"
        Me.WidthContextMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.WidthContextMenuItem.Text = "Width"
        '
        'FontContextMenuItem
        '
        Me.FontContextMenuItem.Name = "FontContextMenuItem"
        Me.FontContextMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.FontContextMenuItem.Text = "Font"
        '
        'ClearContextMenuItem
        '
        Me.ClearContextMenuItem.Name = "ClearContextMenuItem"
        Me.ClearContextMenuItem.Size = New System.Drawing.Size(210, 24)
        Me.ClearContextMenuItem.Text = "Clear"
        '
        'GraphicsExamples
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "GraphicsExamples"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.MainContextMenuStrip.ResumeLayout(False)
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
End Class
