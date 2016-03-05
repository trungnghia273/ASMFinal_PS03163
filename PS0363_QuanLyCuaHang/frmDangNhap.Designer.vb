<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhap))
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.txtmk = New System.Windows.Forms.TextBox()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.lblMatkhau = New System.Windows.Forms.Label()
        Me.lblTenDangNhap = New System.Windows.Forms.Label()
        Me.lblDangNhap = New System.Windows.Forms.Label()
        Me.ptbLogo = New System.Windows.Forms.PictureBox()
        Me.lblMSV = New System.Windows.Forms.Label()
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHuy
        '
        Me.btnHuy.Location = New System.Drawing.Point(325, 203)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(95, 29)
        Me.btnHuy.TabIndex = 21
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(195, 203)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(95, 29)
        Me.btnDangNhap.TabIndex = 20
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'txtmk
        '
        Me.txtmk.Location = New System.Drawing.Point(195, 152)
        Me.txtmk.Name = "txtmk"
        Me.txtmk.Size = New System.Drawing.Size(225, 20)
        Me.txtmk.TabIndex = 19
        Me.txtmk.UseSystemPasswordChar = True
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Location = New System.Drawing.Point(195, 106)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(225, 20)
        Me.txtdangnhap.TabIndex = 18
        '
        'lblMatkhau
        '
        Me.lblMatkhau.AutoSize = True
        Me.lblMatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatkhau.Location = New System.Drawing.Point(111, 153)
        Me.lblMatkhau.Name = "lblMatkhau"
        Me.lblMatkhau.Size = New System.Drawing.Size(78, 16)
        Me.lblMatkhau.TabIndex = 17
        Me.lblMatkhau.Text = "Mật khẩu :"
        '
        'lblTenDangNhap
        '
        Me.lblTenDangNhap.AutoSize = True
        Me.lblTenDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenDangNhap.Location = New System.Drawing.Point(69, 107)
        Me.lblTenDangNhap.Name = "lblTenDangNhap"
        Me.lblTenDangNhap.Size = New System.Drawing.Size(120, 16)
        Me.lblTenDangNhap.TabIndex = 16
        Me.lblTenDangNhap.Text = "Tên đăng nhập :"
        '
        'lblDangNhap
        '
        Me.lblDangNhap.AutoSize = True
        Me.lblDangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDangNhap.ForeColor = System.Drawing.Color.Red
        Me.lblDangNhap.Location = New System.Drawing.Point(207, 39)
        Me.lblDangNhap.Name = "lblDangNhap"
        Me.lblDangNhap.Size = New System.Drawing.Size(190, 37)
        Me.lblDangNhap.TabIndex = 15
        Me.lblDangNhap.Text = "Đăng Nhập"
        '
        'ptbLogo
        '
        Me.ptbLogo.BackgroundImage = CType(resources.GetObject("ptbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbLogo.Location = New System.Drawing.Point(0, 4)
        Me.ptbLogo.Name = "ptbLogo"
        Me.ptbLogo.Size = New System.Drawing.Size(189, 80)
        Me.ptbLogo.TabIndex = 22
        Me.ptbLogo.TabStop = False
        '
        'lblMSV
        '
        Me.lblMSV.AutoSize = True
        Me.lblMSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSV.Location = New System.Drawing.Point(10, 242)
        Me.lblMSV.Name = "lblMSV"
        Me.lblMSV.Size = New System.Drawing.Size(118, 16)
        Me.lblMSV.TabIndex = 23
        Me.lblMSV.Text = "MASV :PS03163"
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(510, 281)
        Me.Controls.Add(Me.lblMSV)
        Me.Controls.Add(Me.ptbLogo)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.txtmk)
        Me.Controls.Add(Me.txtdangnhap)
        Me.Controls.Add(Me.lblMatkhau)
        Me.Controls.Add(Me.lblTenDangNhap)
        Me.Controls.Add(Me.lblDangNhap)
        Me.Name = "frmDangNhap"
        Me.Text = "Đăng Nhập"
        CType(Me.ptbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents txtmk As System.Windows.Forms.TextBox
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents lblMatkhau As System.Windows.Forms.Label
    Friend WithEvents lblTenDangNhap As System.Windows.Forms.Label
    Friend WithEvents lblDangNhap As System.Windows.Forms.Label
    Friend WithEvents ptbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblMSV As System.Windows.Forms.Label

End Class
