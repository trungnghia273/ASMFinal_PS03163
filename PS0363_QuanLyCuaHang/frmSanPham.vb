Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSanPham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=PS03163.mssql.somee.com;packet size=4096;user id=nguyennghia_SQLLogin_1;pwd=hibd7ik4o7;data source=PS03163.mssql.somee.com;persist security info=False;initial catalog=PS03163"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnHienThi_Click(sender As Object, e As EventArgs) Handles btnHienThi.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm',TenSP as 'Tên sản phẩm', NgaySX as 'Ngày Sản Xuất', NoiSX as 'Nơi Sản Xuất' from SANPHAM where MaSP='" & txtMaSP.Text & "'", connect)
        Try
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvSanpham.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvSanpham.DataSource = db.DefaultView
                    txtMaSP.Text = Nothing

                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMaSP.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgvSanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanpham.CellContentClick
        Dim click As Integer = dgvSanpham.CurrentCell.RowIndex
        txtMaSP.Text = dgvSanpham.Item(0, click).Value
        txtTENSP.Text = dgvSanpham.Item(1, click).Value
        txtNgaySX.Text = dgvSanpham.Item(2, click).Value
        txtNoiSX.Text = dgvSanpham.Item(3, click).Value
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm',TenSP as 'Tên sản phẩm', NgaySX as 'Ngày Sản Xuất', NoiSX as 'Nơi Sản Xuất' from SANPHAM", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SANPHAM set MaSP=@MASP, TenSP=@TENSP, NgaySX =@NgaySX, NoiSX = @NoiSX  where MaSP=@MaSP"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTENSP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTENSP.Focus()
                    If txtNgaySX.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaySX.Focus()
                        If txtNgaySX.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập ngày sản xuất", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtNoiSX.Focus()
                            If txtNoiSX.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập nơi sản xuất", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                addupdate.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                                addupdate.Parameters.AddWithValue("@TenSP", txtTENSP.Text)
                                addupdate.Parameters.AddWithValue("@NgaySX", txtNgaySX.Text)
                                addupdate.Parameters.AddWithValue("@NoiSX", txtNoiSX.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMaSP.Text = Nothing
                                txtTENSP.Text = Nothing
                                txtNgaySX.Text = Nothing
                                txtNoiSX.Text = Nothing

                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from SANPHAM where MaSP=@MASP"
        Dim delete As SqlCommand = New SqlCommand(delquery, connect)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        connect.Open()
        Try
            If txtMASP.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMASP.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                    delete.ExecuteNonQuery()
                    connect.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox
                    txtMASP.Text = Nothing
                    txtTENSP.Text = Nothing
                    txtNgaySX.Text = Nothing
                    txtNoiSX.Text = Nothing
                    txtMaSP.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sản phẩm cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvSanpham.DataSource = db
        dgvSanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM values(@MASP,@TENSP,@NgaySX,@NoiSX)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMaSP.Focus()
            If txtMaSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtTENSP.Focus()
                If txtTENSP.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtNgaySX.Focus()
                    If txtNgaySX.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập ngày sản xuất", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNoiSX.Focus()
                        If txtNoiSX.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập nơi sản xuất", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MASP", txtMaSP.Text)
                            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
                            save.Parameters.AddWithValue("@NgaySX", txtNgaySX.Text)
                            save.Parameters.AddWithValue("@NoiSX", txtNoiSX.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtMaSP.Text = Nothing
                            txtNgaySX.Text = Nothing
                            txtTENSP.Text = Nothing
                            txtNoiSX.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm',TenSP as 'Tên sản phẩm', NgaySX as 'Ngày Sản Xuất', NoiSX as 'Nơi Sản Xuất' from SANPHAM", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã sản phẩm',TenSP as 'Tên sản phẩm', NgaySX as 'Ngày Sản Xuất', NoiSX as 'Nơi Sản Xuất' from SANPHAM", conn)

        conn.Open()
        load.Fill(db)
        dgvSanpham.DataSource = db.DefaultView
    End Sub
End Class