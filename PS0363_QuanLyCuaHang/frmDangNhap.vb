Public Class frmDangNhap

    Private Sub frmDangNhap_click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If txtdangnhap.Text = "Admin" And txtmk.Text = "123" Then
            MessageBox.Show("Đăng Nhập Thành Công")
            frmTrangChu.Show()

        ElseIf txtdangnhap.Text = "" Then
            MessageBox.Show("Nhập tên đăng nhập")
        ElseIf txtmk.Text = "" Then
            MessageBox.Show("Nhập mật khẩu")
        End If
    End Sub
    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        Me.Close()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMSV.Click

    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
