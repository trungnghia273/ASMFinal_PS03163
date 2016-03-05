Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmHoaDon
    Dim chuoiketnoi As String = "workstation id=PS03163.mssql.somee.com;packet size=4096;user id=nguyennghia_SQLLogin_1;pwd=hibd7ik4o7;data source=PS03163.mssql.somee.com;persist security info=False;initial catalog=PS03163"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    'Bien lay du lieu tu Ham
    Dim hienthiSP As New Class2
    Public Class Class2 'Ham lay du lieu
        Dim chuoiketnoi As String = "Data Source=localhost;Initial Catalog=nghiantps03163;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu() As DataSet
            'Truy van du lieu
            Dim loadHD As New SqlDataAdapter("select MaHD as 'Mã hóa đơn',MaKH as 'Mã khách hàng', MaSP as 'Mã sản phẩm', NgayxuatHD as 'Ngày xuất hóa đơn', ThanhTien as 'Thành tiền' from HoaDon ", conn)
            Dim db As New DataSet
            conn.Open() 'Mo ket noi CSDL
            loadHD.Fill(db)
            conn.Close() 'Dong ket noi CSDL
            Return db 'Tra ket qua
        End Function
    End Class

    Private Sub bntHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        'Lay du lieu tu Ham da khai bao
        dgvHoaDon.DataSource = hienthiSP.dulieu.Tables(0)
    End Sub

    Private Sub dgvHoaDon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellContentClick
        'Thanh phan hien thi tren DataGridView
        Dim Dobble As Integer = dgvHoaDon.CurrentCell.RowIndex
        txtMaHD.Text = dgvHoaDon.Item(0, Dobble).Value
        txtMaKH.Text = dgvHoaDon.Item(1, Dobble).Value
        txtMaSP.Text = dgvHoaDon.Item(2, Dobble).Value
        txtNgayXuat.Text = dgvHoaDon.Item(3, Dobble).Value
        txtThanhTien.Text = dgvHoaDon.Item(4, Dobble).Value
    End Sub

   

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã hóa đơn',MaKH as 'Mã khách hàng', MaSP as 'Mã sản phẩm', NgayxuatHD as 'Ngày xuất hóa đơn', ThanhTien as 'Thành tiền'  from HoaDon where MaHD='" & txtMaHD.Text & "'", connect)
        Try
            If txtMaHD.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvHoaDon.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvHoaDon.DataSource = db.DefaultView
                    txtMaHD.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMaHD.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Lenh thu thi cap nhat
        Dim CAPNHAT As String = "UPDATE SanPham SET MaHD=@MaHD ,MaKH=@MaKH , MaSP=@MaSP, NgayXuatHD =@NgayXuatHD, ThanhTien=@ThanhTien WHERE MaHD=@MaHD"
        'Bien luu du lieu
        Dim ADDDATA As SqlCommand = New SqlCommand(CAPNHAT, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMaHD.Focus()
            If txtMaHD.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                txtMaKH.Focus()
                If txtMaKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtMaSP.Focus()
                    If txtMaSP.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        txtNgayXuat.Focus()
                        If txtNgayXuat.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập Ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            txtThanhTien.Focus()
                            If txtThanhTien.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập Ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                'Thuc thi chen du lieu
                                ADDDATA.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
                                ADDDATA.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                                ADDDATA.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                                ADDDATA.Parameters.AddWithValue("@NgayXuat", txtNgayXuat.Text)
                                ADDDATA.Parameters.AddWithValue("@ThanhTien", txtThanhTien.Text)
                                ADDDATA.ExecuteNonQuery()
                                conn.Close() 'Dong ket noi CSDL
                                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                End If
            End If
        Catch EX As Exception
            MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        'Lam moi du lieu
        db.Clear()
        dgvHoaDon.DataSource = db
        dgvHoaDon.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("MaHD as 'Mã hóa đơn',  MaKH as 'Mã khách hàng', MaSP as'Mã sản phẩm', NgayxuatHD as 'Ngày xuất hóa đơn', ThanhTien as 'Thành tiền' from HoaDon ", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvHoaDon.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

   

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

