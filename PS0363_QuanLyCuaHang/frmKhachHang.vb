Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.Data
Public Class frmKhachHang
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03163.mssql.somee.com;packet size=4096;user id=nguyennghia_SQLLogin_1;pwd=hibd7ik4o7;data source=PS03163.mssql.somee.com;persist security info=False;initial catalog=PS03163"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    'Bien lay du lieu tu Ham
    Dim hienthi As New Class1
    Public Class Class1 'Ham lay du lieu
        Dim chuoiketnoi As String = "Data Source=localhost;Initial Catalog=nghiantps03163;Integrated Security=True"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim db As New DataTable
        Public Function dulieu() As DataSet
            'Truy van du lieu
            Dim load As New SqlDataAdapter("select MaKH as 'Mã Khách Hàng', TenKH as 'Tên Khách hàng', SDT as 'số điện thoại', Email as 'Email',DiaChi as 'Địa Chỉ' from KhachHang", conn)
            Dim db As New DataSet
            conn.Open() 'Mo ket noi CSDL
            load.Fill(db)
            conn.Close() 'Dong ket noi CSDL
            Return db 'Tra ket qua
        End Function
    End Class

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng', TenKH as 'Tên Khách hàng', SDT as 'số điện thoại', Email as 'Email',DiaChi as 'Địa Chỉ' from KhachHang where MaKH='" & txtMAKH.Text & "'", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemkh.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemkh.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dgvHienThi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvXemkh.CellContentClick
        Dim click As Integer = dgvXemkh.CurrentCell.RowIndex
        txtMAKH.Text = dgvXemkh.Item(0, click).Value
    End Sub

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        dgvXemkh.DataSource = hienthi.dulieu.Tables(0)
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Close()
    End Sub

    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class