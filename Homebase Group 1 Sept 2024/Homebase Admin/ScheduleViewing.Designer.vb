<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleViewing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleViewing))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.pcbHomepage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btnSelectDate = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pcbBack
        '
        Me.pcbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pcbBack.Image = CType(resources.GetObject("pcbBack.Image"), System.Drawing.Image)
        Me.pcbBack.Location = New System.Drawing.Point(12, 83)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(26, 20)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 145
        Me.pcbBack.TabStop = False
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(258, 9)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(21, 20)
        Me.lblExit.TabIndex = 144
        Me.lblExit.Text = "X"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-10, 0)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(306, 63)
        Me.Guna2Shapes1.TabIndex = 142
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'btnSignUp
        '
        Me.btnSignUp.BorderRadius = 10
        Me.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnSignUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.ForeColor = System.Drawing.Color.Black
        Me.btnSignUp.Location = New System.Drawing.Point(56, 83)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(136, 20)
        Me.btnSignUp.TabIndex = 146
        Me.btnSignUp.Text = "Schedule Viewing"
        '
        'pcbHomepage
        '
        Me.pcbHomepage.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbHomepage.Image = CType(resources.GetObject("pcbHomepage.Image"), System.Drawing.Image)
        Me.pcbHomepage.ImageRotate = 0!
        Me.pcbHomepage.Location = New System.Drawing.Point(-10, 9)
        Me.pcbHomepage.Name = "pcbHomepage"
        Me.pcbHomepage.Size = New System.Drawing.Size(139, 49)
        Me.pcbHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHomepage.TabIndex = 147
        Me.pcbHomepage.TabStop = False
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(-10, 109)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes2.Size = New System.Drawing.Size(306, 315)
        Me.Guna2Shapes2.TabIndex = 148
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(29, 163)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 149
        '
        'btnSelectDate
        '
        Me.btnSelectDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.btnSelectDate.BorderRadius = 10
        Me.btnSelectDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSelectDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSelectDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSelectDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnSelectDate.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDate.ForeColor = System.Drawing.Color.Black
        Me.btnSelectDate.Location = New System.Drawing.Point(29, 337)
        Me.btnSelectDate.Name = "btnSelectDate"
        Me.btnSelectDate.Size = New System.Drawing.Size(123, 30)
        Me.btnSelectDate.TabIndex = 150
        Me.btnSelectDate.Text = "Select Date"
        '
        'ScheduleViewing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.btnSelectDate)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.pcbHomepage)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScheduleViewing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleViewing"
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pcbHomepage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btnSelectDate As Guna.UI2.WinForms.Guna2Button
End Class
