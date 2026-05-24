<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.pcbProfile = New System.Windows.Forms.PictureBox()
        Me.pcbNotification = New System.Windows.Forms.PictureBox()
        Me.pcbChat = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtSearchBar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Shapes3 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.pcbExit = New System.Windows.Forms.PictureBox()
        Me.dgrdHouseList = New System.Windows.Forms.DataGridView()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrdHouseList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-12, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(139, 49)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 39
        Me.Guna2PictureBox1.TabStop = False
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
        Me.Guna2Shapes1.TabIndex = 38
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(162, -1)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes2.Size = New System.Drawing.Size(130, 63)
        Me.Guna2Shapes2.TabIndex = 40
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pcbProfile.Image = CType(resources.GetObject("pcbProfile.Image"), System.Drawing.Image)
        Me.pcbProfile.Location = New System.Drawing.Point(169, 22)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(32, 30)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbProfile.TabIndex = 41
        Me.pcbProfile.TabStop = False
        '
        'pcbNotification
        '
        Me.pcbNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pcbNotification.Image = CType(resources.GetObject("pcbNotification.Image"), System.Drawing.Image)
        Me.pcbNotification.Location = New System.Drawing.Point(207, 22)
        Me.pcbNotification.Name = "pcbNotification"
        Me.pcbNotification.Size = New System.Drawing.Size(32, 30)
        Me.pcbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbNotification.TabIndex = 42
        Me.pcbNotification.TabStop = False
        '
        'pcbChat
        '
        Me.pcbChat.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.pcbChat.Image = CType(resources.GetObject("pcbChat.Image"), System.Drawing.Image)
        Me.pcbChat.Location = New System.Drawing.Point(245, 22)
        Me.pcbChat.Name = "pcbChat"
        Me.pcbChat.Size = New System.Drawing.Size(32, 30)
        Me.pcbChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbChat.TabIndex = 43
        Me.pcbChat.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageRotate = 0!
        Me.btnSearch.Location = New System.Drawing.Point(194, 77)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(37, 35)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 107
        Me.btnSearch.TabStop = False
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BorderRadius = 10
        Me.txtSearchBar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchBar.DefaultText = "Search"
        Me.txtSearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchBar.Location = New System.Drawing.Point(52, 77)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchBar.PlaceholderText = ""
        Me.txtSearchBar.SelectedText = ""
        Me.txtSearchBar.Size = New System.Drawing.Size(149, 35)
        Me.txtSearchBar.TabIndex = 106
        '
        'Guna2Shapes3
        '
        Me.Guna2Shapes3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Guna2Shapes3.Location = New System.Drawing.Point(169, 354)
        Me.Guna2Shapes3.Name = "Guna2Shapes3"
        Me.Guna2Shapes3.PolygonSkip = 1
        Me.Guna2Shapes3.Rotate = 0!
        Me.Guna2Shapes3.Size = New System.Drawing.Size(295, 315)
        Me.Guna2Shapes3.TabIndex = 109
        Me.Guna2Shapes3.Text = "Guna2Shapes3"
        Me.Guna2Shapes3.Zoom = 100
        '
        'pcbExit
        '
        Me.pcbExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.pcbExit.Image = CType(resources.GetObject("pcbExit.Image"), System.Drawing.Image)
        Me.pcbExit.Location = New System.Drawing.Point(245, 411)
        Me.pcbExit.Name = "pcbExit"
        Me.pcbExit.Size = New System.Drawing.Size(44, 38)
        Me.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbExit.TabIndex = 110
        Me.pcbExit.TabStop = False
        '
        'dgrdHouseList
        '
        Me.dgrdHouseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgrdHouseList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgrdHouseList.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdHouseList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrdHouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdHouseList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgrdHouseList.Location = New System.Drawing.Point(0, 118)
        Me.dgrdHouseList.Name = "dgrdHouseList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(184, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgrdHouseList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgrdHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrdHouseList.Size = New System.Drawing.Size(289, 257)
        Me.dgrdHouseList.TabIndex = 111
        '
        'Homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.dgrdHouseList)
        Me.Controls.Add(Me.pcbExit)
        Me.Controls.Add(Me.Guna2Shapes3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchBar)
        Me.Controls.Add(Me.pcbChat)
        Me.Controls.Add(Me.pcbNotification)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Homepage"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrdHouseList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents pcbProfile As PictureBox
    Friend WithEvents pcbChat As PictureBox
    Friend WithEvents pcbNotification As PictureBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtSearchBar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pcbExit As PictureBox
    Friend WithEvents Guna2Shapes3 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents dgrdHouseList As DataGridView
End Class
