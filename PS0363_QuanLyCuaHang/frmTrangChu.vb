Public Class frmTrangChu

    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub LinklblSanPham_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblSanPham.LinkClicked
        frmSanPham.ShowDialog()
    End Sub

    Private Sub ptbKhachHang_Click(sender As Object, e As EventArgs) Handles ptbKhachHang.Click
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub LinkKhachHang_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkKhachHang.LinkClicked
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub ptbHoaDon_Click(sender As Object, e As EventArgs) Handles ptbHoaDon.Click
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub LinkHoaDon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkHoaDon.LinkClicked
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub LinklblLieHe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinklblLieHe.LinkClicked
        GioiThieu.ShowDialog()
    End Sub

    Private Sub Trang_chủ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ptbLienHe_Click(sender As Object, e As EventArgs) Handles ptbLienHe.Click
        GioiThieu.ShowDialog()
    End Sub
End Class