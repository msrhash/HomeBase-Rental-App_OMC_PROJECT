<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.txtChat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pcbSend = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.pcbHomepage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtChatUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdminChat = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pcbBack
        '
        Me.pcbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbBack.Image = CType(resources.GetObject("pcbBack.Image"), System.Drawing.Image)
        Me.pcbBack.Location = New System.Drawing.Point(223, 7)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(26, 20)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 137
        Me.pcbBack.TabStop = False
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(255, 7)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(21, 20)
        Me.lblExit.TabIndex = 136
        Me.lblExit.Text = "X"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-2, -2)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(295, 63)
        Me.Guna2Shapes1.TabIndex = 134
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'txtChat
        '
        Me.txtChat.BorderRadius = 3
        Me.txtChat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChat.DefaultText = ""
        Me.txtChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChat.Location = New System.Drawing.Point(12, 417)
        Me.txtChat.Name = "txtChat"
        Me.txtChat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChat.PlaceholderText = ""
        Me.txtChat.SelectedText = ""
        Me.txtChat.Size = New System.Drawing.Size(237, 24)
        Me.txtChat.TabIndex = 138
        '
        'pcbSend
        '
        Me.pcbSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pcbSend.Image = CType(resources.GetObject("pcbSend.Image"), System.Drawing.Image)
        Me.pcbSend.Location = New System.Drawing.Point(255, 417)
        Me.pcbSend.Name = "pcbSend"
        Me.pcbSend.Size = New System.Drawing.Size(26, 24)
        Me.pcbSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbSend.TabIndex = 139
        Me.pcbSend.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "AGENT"
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(-2, 58)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes2.Size = New System.Drawing.Size(295, 45)
        Me.Guna2Shapes2.TabIndex = 140
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'pcbHomepage
        '
        Me.pcbHomepage.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbHomepage.Image = CType(resources.GetObject("pcbHomepage.Image"), System.Drawing.Image)
        Me.pcbHomepage.ImageRotate = 0!
        Me.pcbHomepage.Location = New System.Drawing.Point(-3, 7)
        Me.pcbHomepage.Name = "pcbHomepage"
        Me.pcbHomepage.Size = New System.Drawing.Size(139, 49)
        Me.pcbHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHomepage.TabIndex = 142
        Me.pcbHomepage.TabStop = False
        '
        'txtChatUser
        '
        Me.txtChatUser.BorderRadius = 10
        Me.txtChatUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChatUser.DefaultText = ""
        Me.txtChatUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChatUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChatUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChatUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChatUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChatUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChatUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChatUser.Location = New System.Drawing.Point(87, 109)
        Me.txtChatUser.Name = "txtChatUser"
        Me.txtChatUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChatUser.PlaceholderText = ""
        Me.txtChatUser.SelectedText = ""
        Me.txtChatUser.Size = New System.Drawing.Size(189, 47)
        Me.txtChatUser.TabIndex = 143
        Me.txtChatUser.Visible = False
        '
        'txtAdminChat
        '
        Me.txtAdminChat.AutoSize = True
        Me.txtAdminChat.BorderRadius = 10
        Me.txtAdminChat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdminChat.DefaultText = ""
        Me.txtAdminChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdminChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdminChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdminChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminChat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAdminChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdminChat.Location = New System.Drawing.Point(12, 162)
        Me.txtAdminChat.Name = "txtAdminChat"
        Me.txtAdminChat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdminChat.PlaceholderText = ""
        Me.txtAdminChat.SelectedText = ""
        Me.txtAdminChat.Size = New System.Drawing.Size(189, 47)
        Me.txtAdminChat.TabIndex = 144
        Me.txtAdminChat.Visible = False
        '
        'Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.txtAdminChat)
        Me.Controls.Add(Me.txtChatUser)
        Me.Controls.Add(Me.pcbHomepage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.pcbSend)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat"
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents txtChat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pcbSend As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents pcbHomepage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtAdminChat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtChatUser As Guna.UI2.WinForms.Guna2TextBox
End Class
