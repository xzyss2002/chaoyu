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
        Me.PicWelcome = New System.Windows.Forms.PictureBox()
        Me.TxtTo = New System.Windows.Forms.TextBox()
        Me.PicRace = New System.Windows.Forms.PictureBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtName2 = New System.Windows.Forms.TextBox()
        CType(Me.PicWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicWelcome
        '
        Me.PicWelcome.Image = CType(resources.GetObject("PicWelcome.Image"), System.Drawing.Image)
        Me.PicWelcome.Location = New System.Drawing.Point(193, 12)
        Me.PicWelcome.Name = "PicWelcome"
        Me.PicWelcome.Size = New System.Drawing.Size(791, 143)
        Me.PicWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWelcome.TabIndex = 0
        Me.PicWelcome.TabStop = False
        '
        'TxtTo
        '
        Me.TxtTo.BackColor = System.Drawing.Color.Black
        Me.TxtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 90.0!)
        Me.TxtTo.ForeColor = System.Drawing.SystemColors.Window
        Me.TxtTo.Location = New System.Drawing.Point(79, 239)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.ReadOnly = True
        Me.TxtTo.Size = New System.Drawing.Size(176, 177)
        Me.TxtTo.TabIndex = 1
        Me.TxtTo.Text = "To"
        '
        'PicRace
        '
        Me.PicRace.Image = CType(resources.GetObject("PicRace.Image"), System.Drawing.Image)
        Me.PicRace.Location = New System.Drawing.Point(382, 199)
        Me.PicRace.Name = "PicRace"
        Me.PicRace.Size = New System.Drawing.Size(602, 243)
        Me.PicRace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRace.TabIndex = 2
        Me.PicRace.TabStop = False
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.Black
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TxtName.ForeColor = System.Drawing.Color.White
        Me.TxtName.Location = New System.Drawing.Point(193, 507)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(415, 45)
        Me.TxtName.TabIndex = 3
        Me.TxtName.Text = "Please Enter Your Name:"
        '
        'TxtName2
        '
        Me.TxtName2.BackColor = System.Drawing.Color.Black
        Me.TxtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TxtName2.ForeColor = System.Drawing.Color.White
        Me.TxtName2.Location = New System.Drawing.Point(607, 507)
        Me.TxtName2.Name = "TxtName2"
        Me.TxtName2.Size = New System.Drawing.Size(295, 45)
        Me.TxtName2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1152, 662)
        Me.Controls.Add(Me.TxtName2)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.PicRace)
        Me.Controls.Add(Me.TxtTo)
        Me.Controls.Add(Me.PicWelcome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicWelcome As System.Windows.Forms.PictureBox
    Friend WithEvents TxtTo As System.Windows.Forms.TextBox
    Friend WithEvents PicRace As System.Windows.Forms.PictureBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtName2 As System.Windows.Forms.TextBox

End Class
