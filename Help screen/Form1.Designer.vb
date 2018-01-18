<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.TxtPlay = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TxtInstructions = New System.Windows.Forms.TextBox()
        Me.TxtNerf = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TxtInstructions2 = New System.Windows.Forms.TextBox()
        Me.CmdBack = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 100.0!)
        Me.TxtTitle.Location = New System.Drawing.Point(469, 32)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.Size = New System.Drawing.Size(353, 196)
        Me.TxtTitle.TabIndex = 0
        Me.TxtTitle.Text = "Help"
        '
        'TxtPlay
        '
        Me.TxtPlay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.TxtPlay.Location = New System.Drawing.Point(28, 250)
        Me.TxtPlay.Name = "TxtPlay"
        Me.TxtPlay.Size = New System.Drawing.Size(596, 83)
        Me.TxtPlay.TabIndex = 1
        Me.TxtPlay.Text = "How to play?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(950, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(251, 182)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'TxtInstructions
        '
        Me.TxtInstructions.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TxtInstructions.Location = New System.Drawing.Point(28, 349)
        Me.TxtInstructions.Multiline = True
        Me.TxtInstructions.Name = "TxtInstructions"
        Me.TxtInstructions.ReadOnly = True
        Me.TxtInstructions.Size = New System.Drawing.Size(1051, 175)
        Me.TxtInstructions.TabIndex = 4
        Me.TxtInstructions.Text = resources.GetString("TxtInstructions.Text")
        '
        'TxtNerf
        '
        Me.TxtNerf.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtNerf.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TxtNerf.Location = New System.Drawing.Point(28, 530)
        Me.TxtNerf.Name = "TxtNerf"
        Me.TxtNerf.ReadOnly = True
        Me.TxtNerf.Size = New System.Drawing.Size(766, 45)
        Me.TxtNerf.TabIndex = 5
        Me.TxtNerf.Text = "Oppoent Nerf: Decreases your oppoents speed."
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox2.Location = New System.Drawing.Point(28, 669)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(656, 45)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "Speed Boost: Boosts your own speed"
        '
        'TxtInstructions2
        '
        Me.TxtInstructions2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TxtInstructions2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TxtInstructions2.Location = New System.Drawing.Point(28, 596)
        Me.TxtInstructions2.Name = "TxtInstructions2"
        Me.TxtInstructions2.ReadOnly = True
        Me.TxtInstructions2.Size = New System.Drawing.Size(684, 45)
        Me.TxtInstructions2.TabIndex = 7
        Me.TxtInstructions2.Text = "Rewards boost: Get aditional rhea per win"
        '
        'CmdBack
        '
        Me.CmdBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.CmdBack.Location = New System.Drawing.Point(827, 596)
        Me.CmdBack.Name = "CmdBack"
        Me.CmdBack.Size = New System.Drawing.Size(269, 109)
        Me.CmdBack.TabIndex = 8
        Me.CmdBack.Text = "Back"
        Me.CmdBack.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(1271, 755)
        Me.Controls.Add(Me.CmdBack)
        Me.Controls.Add(Me.TxtInstructions2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TxtNerf)
        Me.Controls.Add(Me.TxtInstructions)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPlay)
        Me.Controls.Add(Me.TxtTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlay As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents TxtNerf As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtInstructions2 As System.Windows.Forms.TextBox

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtInstructions2.TextChanged

    End Sub
    Friend WithEvents CmdBack As System.Windows.Forms.Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdBack.Click

    End Sub
End Class
