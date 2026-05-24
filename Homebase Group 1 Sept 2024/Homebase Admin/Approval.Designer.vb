<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Approval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Approval))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnApprove = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes9 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.btnViewingRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApprovalDeposit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewingSchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHouselist = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.btnNotApprove = New Guna.UI2.WinForms.Guna2Button()
        Me.txtHouseInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pcbHouseImage = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenantInfo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pcbEvidence = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHouseID = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.pcbHouseImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbEvidence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.lblExit.TabIndex = 120
        Me.lblExit.Text = "X"
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnApprove.BorderRadius = 10
        Me.btnApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnApprove.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnApprove.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.Black
        Me.btnApprove.Location = New System.Drawing.Point(109, 381)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(70, 33)
        Me.btnApprove.TabIndex = 119
        Me.btnApprove.Text = "APPROVE"
        '
        'Guna2Shapes9
        '
        Me.Guna2Shapes9.BorderColor = System.Drawing.Color.Black
        Me.Guna2Shapes9.BorderThickness = 1
        Me.Guna2Shapes9.FillColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2Shapes9.Location = New System.Drawing.Point(98, 68)
        Me.Guna2Shapes9.Name = "Guna2Shapes9"
        Me.Guna2Shapes9.PolygonSkip = 1
        Me.Guna2Shapes9.Rotate = 0!
        Me.Guna2Shapes9.RoundedRadius = 10
        Me.Guna2Shapes9.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes9.Size = New System.Drawing.Size(179, 359)
        Me.Guna2Shapes9.TabIndex = 118
        Me.Guna2Shapes9.Text = "Guna2Shapes9"
        Me.Guna2Shapes9.Zoom = 100
        '
        'btnViewingRequest
        '
        Me.btnViewingRequest.BorderRadius = 10
        Me.btnViewingRequest.BorderThickness = 1
        Me.btnViewingRequest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewingRequest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewingRequest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewingRequest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewingRequest.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnViewingRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewingRequest.ForeColor = System.Drawing.Color.Black
        Me.btnViewingRequest.Location = New System.Drawing.Point(-17, 224)
        Me.btnViewingRequest.Name = "btnViewingRequest"
        Me.btnViewingRequest.Size = New System.Drawing.Size(98, 46)
        Me.btnViewingRequest.TabIndex = 117
        Me.btnViewingRequest.Text = "Viewing Request"
        '
        'btnApprovalDeposit
        '
        Me.btnApprovalDeposit.BorderRadius = 10
        Me.btnApprovalDeposit.BorderThickness = 1
        Me.btnApprovalDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnApprovalDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnApprovalDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnApprovalDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnApprovalDeposit.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnApprovalDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprovalDeposit.ForeColor = System.Drawing.Color.Black
        Me.btnApprovalDeposit.Location = New System.Drawing.Point(-10, 381)
        Me.btnApprovalDeposit.Name = "btnApprovalDeposit"
        Me.btnApprovalDeposit.Size = New System.Drawing.Size(98, 46)
        Me.btnApprovalDeposit.TabIndex = 116
        Me.btnApprovalDeposit.Text = "Approval Deposit Page"
        '
        'btnViewingSchedule
        '
        Me.btnViewingSchedule.BorderRadius = 10
        Me.btnViewingSchedule.BorderThickness = 1
        Me.btnViewingSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewingSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewingSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewingSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewingSchedule.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnViewingSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewingSchedule.ForeColor = System.Drawing.Color.Black
        Me.btnViewingSchedule.Location = New System.Drawing.Point(-17, 328)
        Me.btnViewingSchedule.Name = "btnViewingSchedule"
        Me.btnViewingSchedule.Size = New System.Drawing.Size(98, 46)
        Me.btnViewingSchedule.TabIndex = 115
        Me.btnViewingSchedule.Text = "Viewing Schedule"
        '
        'btnHistory
        '
        Me.btnHistory.BorderRadius = 10
        Me.btnHistory.BorderThickness = 1
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Black
        Me.btnHistory.Location = New System.Drawing.Point(-14, 276)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(95, 46)
        Me.btnHistory.TabIndex = 114
        Me.btnHistory.Text = "History"
        '
        'btnHouselist
        '
        Me.btnHouselist.BorderRadius = 10
        Me.btnHouselist.BorderThickness = 1
        Me.btnHouselist.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHouselist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHouselist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHouselist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHouselist.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnHouselist.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHouselist.ForeColor = System.Drawing.Color.Black
        Me.btnHouselist.Location = New System.Drawing.Point(-10, 172)
        Me.btnHouselist.Name = "btnHouselist"
        Me.btnHouselist.Size = New System.Drawing.Size(91, 46)
        Me.btnHouselist.TabIndex = 113
        Me.btnHouselist.Text = "Houselist"
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.BorderThickness = 1
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(-99, 120)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(180, 46)
        Me.btnSearch.TabIndex = 112
        Me.btnSearch.Text = "Search User"
        Me.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnUser
        '
        Me.btnUser.BorderRadius = 10
        Me.btnUser.BorderThickness = 1
        Me.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Black
        Me.btnUser.Location = New System.Drawing.Point(-99, 68)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(180, 46)
        Me.btnUser.TabIndex = 111
        Me.btnUser.Text = "User Approval"
        Me.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-3, -1)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(295, 63)
        Me.Guna2Shapes1.TabIndex = 109
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'btnNotApprove
        '
        Me.btnNotApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnNotApprove.BorderRadius = 10
        Me.btnNotApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNotApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNotApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNotApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNotApprove.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnNotApprove.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotApprove.ForeColor = System.Drawing.Color.Black
        Me.btnNotApprove.Location = New System.Drawing.Point(199, 381)
        Me.btnNotApprove.Name = "btnNotApprove"
        Me.btnNotApprove.Size = New System.Drawing.Size(70, 33)
        Me.btnNotApprove.TabIndex = 121
        Me.btnNotApprove.Text = "NOT APPROVE"
        '
        'txtHouseInfo
        '
        Me.txtHouseInfo.AutoSize = True
        Me.txtHouseInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHouseInfo.DefaultText = ""
        Me.txtHouseInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHouseInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHouseInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHouseInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHouseInfo.Location = New System.Drawing.Point(184, 94)
        Me.txtHouseInfo.Multiline = True
        Me.txtHouseInfo.Name = "txtHouseInfo"
        Me.txtHouseInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHouseInfo.PlaceholderText = ""
        Me.txtHouseInfo.ReadOnly = True
        Me.txtHouseInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHouseInfo.SelectedText = ""
        Me.txtHouseInfo.Size = New System.Drawing.Size(85, 103)
        Me.txtHouseInfo.TabIndex = 122
        '
        'pcbHouseImage
        '
        Me.pcbHouseImage.Location = New System.Drawing.Point(109, 78)
        Me.pcbHouseImage.Name = "pcbHouseImage"
        Me.pcbHouseImage.Size = New System.Drawing.Size(70, 71)
        Me.pcbHouseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHouseImage.TabIndex = 123
        Me.pcbHouseImage.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(185, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "House Detail:"
        '
        'txtTenantInfo
        '
        Me.txtTenantInfo.AutoSize = True
        Me.txtTenantInfo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenantInfo.DefaultText = ""
        Me.txtTenantInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTenantInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTenantInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTenantInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTenantInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTenantInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTenantInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTenantInfo.Location = New System.Drawing.Point(109, 219)
        Me.txtTenantInfo.Multiline = True
        Me.txtTenantInfo.Name = "txtTenantInfo"
        Me.txtTenantInfo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTenantInfo.PlaceholderText = ""
        Me.txtTenantInfo.ReadOnly = True
        Me.txtTenantInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTenantInfo.SelectedText = ""
        Me.txtTenantInfo.Size = New System.Drawing.Size(160, 64)
        Me.txtTenantInfo.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Tenants' Detail:"
        '
        'pcbEvidence
        '
        Me.pcbEvidence.Location = New System.Drawing.Point(192, 289)
        Me.pcbEvidence.Name = "pcbEvidence"
        Me.pcbEvidence.Size = New System.Drawing.Size(77, 71)
        Me.pcbEvidence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbEvidence.TabIndex = 127
        Me.pcbEvidence.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(106, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Deposit Detail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(108, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "House ID:"
        '
        'lblHouseID
        '
        Me.lblHouseID.AutoSize = True
        Me.lblHouseID.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.lblHouseID.Location = New System.Drawing.Point(111, 172)
        Me.lblHouseID.Name = "lblHouseID"
        Me.lblHouseID.Size = New System.Drawing.Size(46, 13)
        Me.lblHouseID.TabIndex = 130
        Me.lblHouseID.Text = "Houseid"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-10, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(139, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 131
        Me.Guna2PictureBox1.TabStop = False
        '
        'Approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lblHouseID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pcbEvidence)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTenantInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbHouseImage)
        Me.Controls.Add(Me.txtHouseInfo)
        Me.Controls.Add(Me.btnNotApprove)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.Guna2Shapes9)
        Me.Controls.Add(Me.btnViewingRequest)
        Me.Controls.Add(Me.btnApprovalDeposit)
        Me.Controls.Add(Me.btnViewingSchedule)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnHouselist)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Approval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval"
        CType(Me.pcbHouseImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbEvidence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblExit As Label
    Friend WithEvents btnApprove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes9 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents btnViewingRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApprovalDeposit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewingSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHouselist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents btnNotApprove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pcbHouseImage As PictureBox
    Friend WithEvents txtHouseInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pcbEvidence As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenantInfo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblHouseID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
