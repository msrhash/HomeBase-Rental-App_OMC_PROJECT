<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes9 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.btnViewingRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.btnApprovalDeposit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnViewingSchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHouselist = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearchUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.dgrdUser = New System.Windows.Forms.DataGridView()
        Me.txtSearchBar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.dgrdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Shapes1.TabIndex = 20
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Shapes9
        '
        Me.Guna2Shapes9.BorderColor = System.Drawing.Color.Black
        Me.Guna2Shapes9.BorderThickness = 1
        Me.Guna2Shapes9.FillColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Guna2Shapes9.Location = New System.Drawing.Point(98, 121)
        Me.Guna2Shapes9.Name = "Guna2Shapes9"
        Me.Guna2Shapes9.PolygonSkip = 1
        Me.Guna2Shapes9.Rotate = 0!
        Me.Guna2Shapes9.RoundedRadius = 10
        Me.Guna2Shapes9.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes9.Size = New System.Drawing.Size(179, 307)
        Me.Guna2Shapes9.TabIndex = 36
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
        Me.btnViewingRequest.Location = New System.Drawing.Point(-13, 225)
        Me.btnViewingRequest.Name = "btnViewingRequest"
        Me.btnViewingRequest.Size = New System.Drawing.Size(98, 46)
        Me.btnViewingRequest.TabIndex = 82
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
        Me.btnApprovalDeposit.Location = New System.Drawing.Point(-6, 382)
        Me.btnApprovalDeposit.Name = "btnApprovalDeposit"
        Me.btnApprovalDeposit.Size = New System.Drawing.Size(91, 46)
        Me.btnApprovalDeposit.TabIndex = 81
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
        Me.btnViewingSchedule.Location = New System.Drawing.Point(-6, 330)
        Me.btnViewingSchedule.Name = "btnViewingSchedule"
        Me.btnViewingSchedule.Size = New System.Drawing.Size(91, 46)
        Me.btnViewingSchedule.TabIndex = 80
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
        Me.btnHistory.Location = New System.Drawing.Point(-6, 278)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(91, 46)
        Me.btnHistory.TabIndex = 79
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
        Me.btnHouselist.Location = New System.Drawing.Point(-6, 173)
        Me.btnHouselist.Name = "btnHouselist"
        Me.btnHouselist.Size = New System.Drawing.Size(91, 46)
        Me.btnHouselist.TabIndex = 78
        Me.btnHouselist.Text = "Houselist"
        '
        'btnSearchUser
        '
        Me.btnSearchUser.BorderRadius = 10
        Me.btnSearchUser.BorderThickness = 1
        Me.btnSearchUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearchUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSearchUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUser.ForeColor = System.Drawing.Color.Black
        Me.btnSearchUser.Location = New System.Drawing.Point(-88, 121)
        Me.btnSearchUser.Name = "btnSearchUser"
        Me.btnSearchUser.Size = New System.Drawing.Size(180, 46)
        Me.btnSearchUser.TabIndex = 77
        Me.btnSearchUser.Text = "Search User"
        Me.btnSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btnUser.Location = New System.Drawing.Point(-95, 69)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(180, 46)
        Me.btnUser.TabIndex = 76
        Me.btnUser.Text = "User Approval"
        Me.btnUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.lblExit.TabIndex = 102
        Me.lblExit.Text = "X"
        '
        'dgrdUser
        '
        Me.dgrdUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgrdUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgrdUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.dgrdUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgrdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdUser.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgrdUser.Location = New System.Drawing.Point(108, 132)
        Me.dgrdUser.Name = "dgrdUser"
        Me.dgrdUser.ReadOnly = True
        Me.dgrdUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdUser.Size = New System.Drawing.Size(159, 296)
        Me.dgrdUser.TabIndex = 103
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BorderRadius = 10
        Me.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBar.DefaultText = ""
        Me.txtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Location = New System.Drawing.Point(98, 69)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBar.PlaceholderText = ""
        Me.txtSearchBar.SelectedText = ""
        Me.txtSearchBar.Size = New System.Drawing.Size(149, 35)
        Me.txtSearchBar.TabIndex = 104
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageRotate = 0!
        Me.btnSearch.Location = New System.Drawing.Point(240, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(37, 35)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 105
        Me.btnSearch.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-13, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(139, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 106
        Me.Guna2PictureBox1.TabStop = False
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchBar)
        Me.Controls.Add(Me.dgrdUser)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.btnViewingRequest)
        Me.Controls.Add(Me.btnApprovalDeposit)
        Me.Controls.Add(Me.btnViewingSchedule)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnHouselist)
        Me.Controls.Add(Me.btnSearchUser)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.Guna2Shapes9)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.dgrdUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes9 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents btnViewingRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnApprovalDeposit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewingSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHouselist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearchUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblExit As Label
    Friend WithEvents dgrdUser As DataGridView
    Friend WithEvents txtSearchBar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
