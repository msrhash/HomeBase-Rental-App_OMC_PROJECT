<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayDeposit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayDeposit))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btnSignUp = New Guna.UI2.WinForms.Guna2Button()
        Me.pcbBack = New System.Windows.Forms.PictureBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Guna2Shapes2 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPaymentMethod = New System.Windows.Forms.ListBox()
        Me.pcbHomepage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnProceed = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
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
        Me.btnSignUp.Location = New System.Drawing.Point(57, 82)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(136, 20)
        Me.btnSignUp.TabIndex = 156
        Me.btnSignUp.Text = "Pay Deposit"
        '
        'pcbBack
        '
        Me.pcbBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pcbBack.Image = CType(resources.GetObject("pcbBack.Image"), System.Drawing.Image)
        Me.pcbBack.Location = New System.Drawing.Point(13, 82)
        Me.pcbBack.Name = "pcbBack"
        Me.pcbBack.Size = New System.Drawing.Size(26, 20)
        Me.pcbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbBack.TabIndex = 155
        Me.pcbBack.TabStop = False
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblExit.Location = New System.Drawing.Point(259, 8)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(21, 20)
        Me.lblExit.TabIndex = 154
        Me.lblExit.Text = "X"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Guna2Shapes1.Location = New System.Drawing.Point(-15, -1)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes1.Size = New System.Drawing.Size(312, 63)
        Me.Guna2Shapes1.TabIndex = 152
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Guna2Shapes2
        '
        Me.Guna2Shapes2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Shapes2.Location = New System.Drawing.Point(13, 134)
        Me.Guna2Shapes2.Name = "Guna2Shapes2"
        Me.Guna2Shapes2.PolygonSkip = 1
        Me.Guna2Shapes2.Rotate = 0!
        Me.Guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle
        Me.Guna2Shapes2.Size = New System.Drawing.Size(264, 81)
        Me.Guna2Shapes2.TabIndex = 157
        Me.Guna2Shapes2.Text = "Guna2Shapes2"
        Me.Guna2Shapes2.Zoom = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "DEPOSIT AMOUNT:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(16, 168)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(116, 25)
        Me.lblAmount.TabIndex = 159
        Me.lblAmount.Text = "lblAmount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 13)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "CHOOSE A PAYMENT METHOD:"
        '
        'lstPaymentMethod
        '
        Me.lstPaymentMethod.FormattingEnabled = True
        Me.lstPaymentMethod.Items.AddRange(New Object() {"DUITNOW QR", "CREDIT/DEBIT CARD", "ONLINE TRANSFER", "FPX ONLINE BANKING"})
        Me.lstPaymentMethod.Location = New System.Drawing.Point(21, 293)
        Me.lstPaymentMethod.Name = "lstPaymentMethod"
        Me.lstPaymentMethod.Size = New System.Drawing.Size(172, 56)
        Me.lstPaymentMethod.TabIndex = 161
        '
        'pcbHomepage
        '
        Me.pcbHomepage.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.pcbHomepage.Image = CType(resources.GetObject("pcbHomepage.Image"), System.Drawing.Image)
        Me.pcbHomepage.ImageRotate = 0!
        Me.pcbHomepage.Location = New System.Drawing.Point(-7, 8)
        Me.pcbHomepage.Name = "pcbHomepage"
        Me.pcbHomepage.Size = New System.Drawing.Size(139, 49)
        Me.pcbHomepage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbHomepage.TabIndex = 162
        Me.pcbHomepage.TabStop = False
        '
        'btnProceed
        '
        Me.btnProceed.BorderRadius = 10
        Me.btnProceed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProceed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProceed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProceed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProceed.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.btnProceed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.Black
        Me.btnProceed.Location = New System.Drawing.Point(21, 384)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(123, 30)
        Me.btnProceed.TabIndex = 163
        Me.btnProceed.Text = "PROCEED"
        '
        'PayDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 453)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.pcbHomepage)
        Me.Controls.Add(Me.lstPaymentMethod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes2)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.pcbBack)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PayDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayDeposit"
        CType(Me.pcbBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbHomepage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnSignUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pcbBack As PictureBox
    Friend WithEvents lblExit As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Guna2Shapes2 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPaymentMethod As ListBox
    Friend WithEvents pcbHomepage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnProceed As Guna.UI2.WinForms.Guna2Button
End Class
