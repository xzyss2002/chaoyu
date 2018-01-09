<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PicMario = New System.Windows.Forms.PictureBox()
        Me.PicBatman = New System.Windows.Forms.PictureBox()
        Me.CmdStart = New System.Windows.Forms.Button()
        Me.TmrMario = New System.Windows.Forms.Timer(Me.components)
        Me.TmrBatman = New System.Windows.Forms.Timer(Me.components)
        Me.PicFinishLine = New System.Windows.Forms.PictureBox()
        Me.Cmdreset = New System.Windows.Forms.Button()
        CType(Me.PicMario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBatman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFinishLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicMario
        '
        Me.PicMario.BackColor = System.Drawing.Color.Transparent
        Me.PicMario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicMario.Image = Global.GamePlay.My.Resources.Resources.mario
        Me.PicMario.Location = New System.Drawing.Point(-6, 410)
        Me.PicMario.Name = "PicMario"
        Me.PicMario.Size = New System.Drawing.Size(100, 123)
        Me.PicMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMario.TabIndex = 0
        Me.PicMario.TabStop = False
        '
        'PicBatman
        '
        Me.PicBatman.BackColor = System.Drawing.Color.Transparent
        Me.PicBatman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicBatman.Image = Global.GamePlay.My.Resources.Resources.batman
        Me.PicBatman.Location = New System.Drawing.Point(-6, 277)
        Me.PicBatman.Name = "PicBatman"
        Me.PicBatman.Size = New System.Drawing.Size(100, 127)
        Me.PicBatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBatman.TabIndex = 1
        Me.PicBatman.TabStop = False
        '
        'CmdStart
        '
        Me.CmdStart.Location = New System.Drawing.Point(43, 215)
        Me.CmdStart.Name = "CmdStart"
        Me.CmdStart.Size = New System.Drawing.Size(75, 23)
        Me.CmdStart.TabIndex = 2
        Me.CmdStart.Text = "Start"
        Me.CmdStart.UseVisualStyleBackColor = True
        '
        'TmrMario
        '
        Me.TmrMario.Interval = 1
        '
        'TmrBatman
        '
        Me.TmrBatman.Interval = 1
        '
        'PicFinishLine
        '
        Me.PicFinishLine.BackgroundImage = Global.GamePlay.My.Resources.Resources.finish_line
        Me.PicFinishLine.Location = New System.Drawing.Point(1695, 199)
        Me.PicFinishLine.Name = "PicFinishLine"
        Me.PicFinishLine.Size = New System.Drawing.Size(82, 726)
        Me.PicFinishLine.TabIndex = 3
        Me.PicFinishLine.TabStop = False
        '
        'Cmdreset
        '
        Me.Cmdreset.Location = New System.Drawing.Point(124, 215)
        Me.Cmdreset.Name = "Cmdreset"
        Me.Cmdreset.Size = New System.Drawing.Size(75, 23)
        Me.Cmdreset.TabIndex = 4
        Me.Cmdreset.Text = "Reset"
        Me.Cmdreset.UseVisualStyleBackColor = True
        '
        'Race
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GamePlay.My.Resources.Resources.racingtrack
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.Cmdreset)
        Me.Controls.Add(Me.PicFinishLine)
        Me.Controls.Add(Me.CmdStart)
        Me.Controls.Add(Me.PicBatman)
        Me.Controls.Add(Me.PicMario)
        Me.Name = "Race"
        Me.Text = "Racing"
        CType(Me.PicMario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBatman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFinishLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicMario As System.Windows.Forms.PictureBox
    Friend WithEvents PicBatman As System.Windows.Forms.PictureBox
    Friend WithEvents CmdStart As System.Windows.Forms.Button
    Friend WithEvents TmrMario As System.Windows.Forms.Timer
    Friend WithEvents TmrBatman As System.Windows.Forms.Timer
    Friend WithEvents PicFinishLine As System.Windows.Forms.PictureBox
    Friend WithEvents Cmdreset As System.Windows.Forms.Button

End Class
