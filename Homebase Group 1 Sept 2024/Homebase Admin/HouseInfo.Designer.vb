<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HouseInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HouseInfo))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.pcbHouse = New System.Windows.Forms.PictureBox()
        Me.btnSchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDeposit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChat = New Guna.UI2.WinForms.Guna2Button()
        Me.txtHouseDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pcbHome = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtHouseID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pcbBack.Location = New System.Drawing.Point(225, 8)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(26, 20)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 141
        Me.pcbBack.TabStop = False
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(257, 8)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(21, 20)
        Me.lblExit.TabIndex = 140
        Me.lblExit.Text = "X"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(0, -1)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(295, 63)
        Me.Guna2Shapes1.TabIndex = 138
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'pcbHouse
        '
        Me.pcbHouse.Location = New System.Drawing.Point(12, 68)
        Me.pcbHouse.Name = "pcbHouse"
        Me.pcbHouse.Size = New System.Drawing.Size(265, 96)
        Me.pcbHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHouse.TabIndex = 142
        Me.pcbHouse.TabStop = False
        '
        'btnSchedule
        '
        Me.btnSchedule.BorderRadius = 10
        Me.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchedule.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnSchedule.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.Black
        Me.btnSchedule.Location = New System.Drawing.Point(12, 390)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(123, 30)
        Me.btnSchedule.TabIndex = 146
        Me.btnSchedule.Text = "SCHEDULE FOR VIEWING"
        '
        'btnDeposit
        '
        Me.btnDeposit.BorderRadius = 10
        Me.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeposit.FillColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.btnDeposit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnDeposit.Location = New System.Drawing.Point(154, 390)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(123, 30)
        Me.btnDeposit.TabIndex = 147
        Me.btnDeposit.Text = "PAY DEPOSIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Interested?"
        '
        'btnChat
        '
        Me.btnChat.BorderRadius = 10
        Me.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChat.FillColor = System.Drawing.Color.White
        Me.btnChat.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChat.ForeColor = System.Drawing.Color.Black
        Me.btnChat.Location = New System.Drawing.Point(12, 423)
        Me.btnChat.Name = "btnChat"
        Me.btnChat.Size = New System.Drawing.Size(123, 16)
        Me.btnChat.TabIndex = 151
        Me.btnChat.Text = "CHAT WITH AGENT"
        '
        'txtHouseDescription
        '
        Me.txtHouseDescription.AutoSize = True
        Me.txtHouseDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHouseDescription.DefaultText = ""
        Me.txtHouseDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHouseDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHouseDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseDescription.Location = New System.Drawing.Point(12, 224)
        Me.txtHouseDescription.Multiline = True
        Me.txtHouseDescription.Name = "txtHouseDescription"
        Me.txtHouseDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHouseDescription.PlaceholderText = ""
        Me.txtHouseDescription.ReadOnly = True
        Me.txtHouseDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHouseDescription.SelectedText = ""
        Me.txtHouseDescription.Size = New System.Drawing.Size(265, 147)
        Me.txtHouseDescription.TabIndex = 152
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 170)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 153
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(66, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 154
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(124, 170)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 155
        Me.PictureBox5.TabStop = False
        '
        'pcbHome
        '
        Me.pcbHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbHome.Image = CType(resources.GetObject("pcbHome.Image"), System.Drawing.Image)
        Me.pcbHome.ImageRotate = 0!
        Me.pcbHome.Location = New System.Drawing.Point(-14, 8)
        Me.pcbHome.Name = "pcbHome"
        Me.pcbHome.Size = New System.Drawing.Size(139, 49)
        Me.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHome.TabIndex = 156
        Me.pcbHome.TabStop = False
        '
        'txtHouseID
        '
        Me.txtHouseID.Location = New System.Drawing.Point(248, 185)
        Me.txtHouseID.Name = "txtHouseID"
        Me.txtHouseID.ReadOnly = True
        Me.txtHouseID.Size = New System.Drawing.Size(29, 20)
        Me.txtHouseID.TabIndex = 157
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "House Description: "
        '
        'HouseInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHouseID)
        Me.Controls.Add(Me.pcbHome)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtHouseDescription)
        Me.Controls.Add(Me.btnChat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnSchedule)
        Me.Controls.Add(Me.pcbHouse)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HouseInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HouseInfo"
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents pcbHouse As PictureBox
    Friend WithEvents btnDeposit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtHouseDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pcbHome As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtHouseID As TextBox
    Friend WithEvents Label1 As Label
End Class
