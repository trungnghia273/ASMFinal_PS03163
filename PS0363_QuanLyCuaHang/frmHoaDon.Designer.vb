<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoaDon))
        Me.dgvHoaDon = New System.Windows.Forms.DataGridView()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.btnHienThi = New System.Windows.Forms.Button()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.txtNgayXuat = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.lblThanhTien = New System.Windows.Forms.Label()
        Me.lblNgayXuat = New System.Windows.Forms.Label()
        Me.lblMaKH = New System.Windows.Forms.Label()
        Me.lblHoaDon = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ptbgiaohang = New System.Windows.Forms.PictureBox()
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbgiaohang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHoaDon
        '
        Me.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoaDon.Location = New System.Drawing.Point(26, 243)
        Me.dgvHoaDon.Name = "dgvHoaDon"
        Me.dgvHoaDon.Size = New System.Drawing.Size(570, 185)
        Me.dgvHoaDon.TabIndex = 70
        '
        'btnCapnhat
        '
        Me.btnCapnhat.BackgroundImage = CType(resources.GetObject("btnCapnhat.BackgroundImage"), System.Drawing.Image)
        Me.btnCapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapnhat.Location = New System.Drawing.Point(208, 189)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 48)
        Me.btnCapnhat.TabIndex = 67
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'btnTimKiem
        '
        Me.btnTimKiem.BackgroundImage = CType(resources.GetObject("btnTimKiem.BackgroundImage"), System.Drawing.Image)
        Me.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiem.Location = New System.Drawing.Point(120, 189)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(75, 48)
        Me.btnTimKiem.TabIndex = 68
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'btnHienThi
        '
        Me.btnHienThi.BackgroundImage = CType(resources.GetObject("btnHienThi.BackgroundImage"), System.Drawing.Image)
        Me.btnHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHienThi.Location = New System.Drawing.Point(26, 189)
        Me.btnHienThi.Name = "btnHienThi"
        Me.btnHienThi.Size = New System.Drawing.Size(75, 48)
        Me.btnHienThi.TabIndex = 69
        Me.btnHienThi.UseVisualStyleBackColor = True
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(86, 158)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(197, 20)
        Me.txtThanhTien.TabIndex = 62
        '
        'txtNgayXuat
        '
        Me.txtNgayXuat.Location = New System.Drawing.Point(86, 120)
        Me.txtNgayXuat.Name = "txtNgayXuat"
        Me.txtNgayXuat.Size = New System.Drawing.Size(197, 20)
        Me.txtNgayXuat.TabIndex = 63
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(86, 50)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(197, 20)
        Me.txtMaKH.TabIndex = 64
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(86, 12)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(197, 20)
        Me.txtMaHD.TabIndex = 65
        '
        'lblThanhTien
        '
        Me.lblThanhTien.AutoSize = True
        Me.lblThanhTien.Location = New System.Drawing.Point(23, 161)
        Me.lblThanhTien.Name = "lblThanhTien"
        Me.lblThanhTien.Size = New System.Drawing.Size(62, 13)
        Me.lblThanhTien.TabIndex = 58
        Me.lblThanhTien.Text = "Thành Tiền"
        '
        'lblNgayXuat
        '
        Me.lblNgayXuat.AutoSize = True
        Me.lblNgayXuat.Location = New System.Drawing.Point(23, 123)
        Me.lblNgayXuat.Name = "lblNgayXuat"
        Me.lblNgayXuat.Size = New System.Drawing.Size(57, 13)
        Me.lblNgayXuat.TabIndex = 59
        Me.lblNgayXuat.Text = "Ngày Xuất"
        '
        'lblMaKH
        '
        Me.lblMaKH.AutoSize = True
        Me.lblMaKH.Location = New System.Drawing.Point(23, 53)
        Me.lblMaKH.Name = "lblMaKH"
        Me.lblMaKH.Size = New System.Drawing.Size(40, 13)
        Me.lblMaKH.TabIndex = 60
        Me.lblMaKH.Text = "Mã KH"
        '
        'lblHoaDon
        '
        Me.lblHoaDon.AutoSize = True
        Me.lblHoaDon.Location = New System.Drawing.Point(24, 15)
        Me.lblHoaDon.Name = "lblHoaDon"
        Me.lblHoaDon.Size = New System.Drawing.Size(41, 13)
        Me.lblHoaDon.TabIndex = 61
        Me.lblHoaDon.Text = "Mã HĐ"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(86, 87)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(197, 20)
        Me.txtMaSP.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Mã SP"
        '
        'ptbgiaohang
        '
        Me.ptbgiaohang.BackgroundImage = CType(resources.GetObject("ptbgiaohang.BackgroundImage"), System.Drawing.Image)
        Me.ptbgiaohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbgiaohang.Location = New System.Drawing.Point(358, 15)
        Me.ptbgiaohang.Name = "ptbgiaohang"
        Me.ptbgiaohang.Size = New System.Drawing.Size(214, 159)
        Me.ptbgiaohang.TabIndex = 73
        Me.ptbgiaohang.TabStop = False
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 440)
        Me.Controls.Add(Me.ptbgiaohang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.dgvHoaDon)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.btnHienThi)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtNgayXuat)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.lblThanhTien)
        Me.Controls.Add(Me.lblNgayXuat)
        Me.Controls.Add(Me.lblMaKH)
        Me.Controls.Add(Me.lblHoaDon)
        Me.Name = "frmHoaDon"
        Me.Text = "HoaDon"
        CType(Me.dgvHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbgiaohang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvHoaDon As System.Windows.Forms.DataGridView
    Friend WithEvents btnCapnhat As System.Windows.Forms.Button
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents btnHienThi As System.Windows.Forms.Button
    Friend WithEvents txtThanhTien As System.Windows.Forms.TextBox
    Friend WithEvents txtNgayXuat As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaHD As System.Windows.Forms.TextBox
    Friend WithEvents lblThanhTien As System.Windows.Forms.Label
    Friend WithEvents lblNgayXuat As System.Windows.Forms.Label
    Friend WithEvents lblMaKH As System.Windows.Forms.Label
    Friend WithEvents lblHoaDon As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ptbgiaohang As System.Windows.Forms.PictureBox
End Class
