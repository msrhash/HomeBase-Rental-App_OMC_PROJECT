<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotificationCentre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotificationCentre))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.pcbHomepage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lstNotifications = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-1, 0)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(295, 63)
        Me.Guna2Shapes1.TabIndex = 42
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(-1, 57)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes2.Size = New System.Drawing.Size(295, 45)
        Me.Guna2Shapes2.TabIndex = 44
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 16)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "NOTIFICATION CENTRE"
        '
        'pcbBack
        '
        Me.pcbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbBack.Image = CType(resources.GetObject("pcbBack.Image"), System.Drawing.Image)
        Me.pcbBack.Location = New System.Drawing.Point(224, 9)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(26, 20)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 133
        Me.pcbBack.TabStop = False
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(256, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(21, 20)
        Me.lblExit.TabIndex = 132
        Me.lblExit.Text = "X"
        '
        'pcbHomepage
        '
        Me.pcbHomepage.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbHomepage.Image = CType(resources.GetObject("pcbHomepage.Image"), System.Drawing.Image)
        Me.pcbHomepage.ImageRotate = 0!
        Me.pcbHomepage.Location = New System.Drawing.Point(-6, 2)
        Me.pcbHomepage.Name = "pcbHomepage"
        Me.pcbHomepage.Size = New System.Drawing.Size(139, 49)
        Me.pcbHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHomepage.TabIndex = 134
        Me.pcbHomepage.TabStop = False
        '
        'lstNotifications
        '
        Me.lstNotifications.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lstNotifications.FormattingEnabled = True
        Me.lstNotifications.Location = New System.Drawing.Point(-1, 109)
        Me.lstNotifications.Name = "lstNotifications"
        Me.lstNotifications.Size = New System.Drawing.Size(295, 342)
        Me.lstNotifications.TabIndex = 135
        '
        'NotificationCentre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.lstNotifications)
        Me.Controls.Add(Me.pcbHomepage)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NotificationCentre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotificationCentre"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents pcbHomepage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lstNotifications As ListBox
End Class
