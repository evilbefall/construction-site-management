Imports System.Data.SqlClient
Public Class FrmViewBooking
    Public Sub viewdetails()
        open_db()
        dgvview.Rows.Clear()
        qry = "SELECT   dbo.tbl_booking.id, dbo.tbl_booking.e_id, dbo.tbl_enquiry.E_name, dbo.Tbl_flat.f_no, dbo.tbl_booking.p_id, dbo.Tbl_NewProject.P_name, dbo.tbl_booking.age, "
        qry = qry + "dbo.tbl_booking.father, dbo.tbl_booking.b_date, dbo.tbl_booking.Address, dbo.tbl_booking.pan, dbo.tbl_booking.passport, dbo.Tbl_flat.Area, dbo.tbl_booking.rate,"
        qry = qry + "dbo.tbl_booking.total, dbo.tbl_booking.car_park, dbo.tbl_booking.c_dep, dbo.tbl_booking.grand_tot, dbo.tbl_booking.service_tax "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "           dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
        qry = qry + "         dbo.Tbl_NewProject ON dbo.tbl_booking.p_id = dbo.Tbl_NewProject.P_id INNER JOIN "
        qry = qry + "          dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id AND dbo.tbl_booking.f_no = dbo.Tbl_flat.f_no"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            dgvview.Item(3, i).Value = dr(3)
            dgvview.Item(4, i).Value = dr(4)
            dgvview.Item(5, i).Value = dr(5)
            dgvview.Item(6, i).Value = dr(6)
            dgvview.Item(7, i).Value = dr(7)
            dgvview.Item(8, i).Value = dr(8)
            dgvview.Item(9, i).Value = dr(9)
            dgvview.Item(10, i).Value = dr(10)
            dgvview.Item(11, i).Value = dr(11)
            dgvview.Item(12, i).Value = dr(12)
            dgvview.Item(13, i).Value = dr(13)
            dgvview.Item(14, i).Value = dr(14)
            dgvview.Item(15, i).Value = dr(15)
            dgvview.Item(16, i).Value = dr(16)
            dgvview.Item(17, i).Value = dr(17)
            dgvview.Item(18, i).Value = dr(18)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub FrmViewAttendance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        viewdetails()
        load_id()
        load_name()
        load_pname()
    End Sub

    Private Sub dgvview_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellClick
        If e.ColumnIndex = 20 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_booking where id= '" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            viewdetails()
        ElseIf e.ColumnIndex = 19 Then
            bid = dgvview.CurrentRow.Cells(0).Value
            editrec = True
            frm_booking.Show()
        End If
    End Sub

    Private Sub txtname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname.TextChanged
        open_db()
        dgvview.Rows.Clear()
        qry = "SELECT   dbo.tbl_booking.id, dbo.tbl_booking.e_id, dbo.tbl_enquiry.E_name, dbo.Tbl_flat.f_no, dbo.tbl_booking.p_id, dbo.Tbl_NewProject.P_name, dbo.tbl_booking.age, "
        qry = qry + "dbo.tbl_booking.father, dbo.tbl_booking.b_date, dbo.tbl_booking.Address, dbo.tbl_booking.pan, dbo.tbl_booking.passport, dbo.Tbl_flat.Area, dbo.tbl_booking.rate,"
        qry = qry + "dbo.tbl_booking.total, dbo.tbl_booking.car_park, dbo.tbl_booking.c_dep, dbo.tbl_booking.grand_tot, dbo.tbl_booking.service_tax "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "           dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
        qry = qry + "         dbo.Tbl_NewProject ON dbo.tbl_booking.p_id = dbo.Tbl_NewProject.P_id INNER JOIN "
        qry = qry + "          dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id AND dbo.tbl_booking.f_no = dbo.Tbl_flat.f_no where dbo.tbl_enquiry.E_name like '" & txtname.Text & "%'"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            dgvview.Item(3, i).Value = dr(3)
            dgvview.Item(4, i).Value = dr(4)
            dgvview.Item(5, i).Value = dr(5)
            dgvview.Item(6, i).Value = dr(6)
            dgvview.Item(7, i).Value = dr(7)
            dgvview.Item(8, i).Value = dr(8)
            dgvview.Item(9, i).Value = dr(9)
            dgvview.Item(10, i).Value = dr(10)
            dgvview.Item(11, i).Value = dr(11)
            dgvview.Item(12, i).Value = dr(12)
            dgvview.Item(13, i).Value = dr(13)
            dgvview.Item(14, i).Value = dr(14)
            dgvview.Item(15, i).Value = dr(15)
            dgvview.Item(16, i).Value = dr(16)
            dgvview.Item(17, i).Value = dr(17)
            dgvview.Item(18, i).Value = dr(18)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtid.TextChanged
        open_db()
        dgvview.Rows.Clear()
        qry = "SELECT   dbo.tbl_booking.id, dbo.tbl_booking.e_id, dbo.tbl_enquiry.E_name, dbo.Tbl_flat.f_no, dbo.tbl_booking.p_id, dbo.Tbl_NewProject.P_name, dbo.tbl_booking.age, "
        qry = qry + "dbo.tbl_booking.father, dbo.tbl_booking.b_date, dbo.tbl_booking.Address, dbo.tbl_booking.pan, dbo.tbl_booking.passport, dbo.Tbl_flat.Area, dbo.tbl_booking.rate,"
        qry = qry + "dbo.tbl_booking.total, dbo.tbl_booking.car_park, dbo.tbl_booking.c_dep, dbo.tbl_booking.grand_tot, dbo.tbl_booking.service_tax "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "           dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
        qry = qry + "         dbo.Tbl_NewProject ON dbo.tbl_booking.p_id = dbo.Tbl_NewProject.P_id INNER JOIN "
        qry = qry + "          dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id AND dbo.tbl_booking.f_no = dbo.Tbl_flat.f_no where dbo.tbl_booking.id like '" & txtid.Text & "%'"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            dgvview.Item(3, i).Value = dr(3)
            dgvview.Item(4, i).Value = dr(4)
            dgvview.Item(5, i).Value = dr(5)
            dgvview.Item(6, i).Value = dr(6)
            dgvview.Item(7, i).Value = dr(7)
            dgvview.Item(8, i).Value = dr(8)
            dgvview.Item(9, i).Value = dr(9)
            dgvview.Item(10, i).Value = dr(10)
            dgvview.Item(11, i).Value = dr(11)
            dgvview.Item(12, i).Value = dr(12)
            dgvview.Item(13, i).Value = dr(13)
            dgvview.Item(14, i).Value = dr(14)
            dgvview.Item(15, i).Value = dr(15)
            dgvview.Item(16, i).Value = dr(16)
            dgvview.Item(17, i).Value = dr(17)
            dgvview.Item(18, i).Value = dr(18)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtpname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtpname.TextChanged
        open_db()
        dgvview.Rows.Clear()
        qry = "SELECT   dbo.tbl_booking.id, dbo.tbl_booking.e_id, dbo.tbl_enquiry.E_name, dbo.Tbl_flat.f_no, dbo.tbl_booking.p_id, dbo.Tbl_NewProject.P_name, dbo.tbl_booking.age, "
        qry = qry + "dbo.tbl_booking.father, dbo.tbl_booking.b_date, dbo.tbl_booking.Address, dbo.tbl_booking.pan, dbo.tbl_booking.passport, dbo.Tbl_flat.Area, dbo.tbl_booking.rate,"
        qry = qry + "dbo.tbl_booking.total, dbo.tbl_booking.car_park, dbo.tbl_booking.c_dep, dbo.tbl_booking.grand_tot, dbo.tbl_booking.service_tax "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "           dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
        qry = qry + "         dbo.Tbl_NewProject ON dbo.tbl_booking.p_id = dbo.Tbl_NewProject.P_id INNER JOIN "
        qry = qry + "          dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id AND dbo.tbl_booking.f_no = dbo.Tbl_flat.f_no where dbo.Tbl_NewProject.P_name like '" & txtpname.Text & "%'"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            dgvview.Item(3, i).Value = dr(3)
            dgvview.Item(4, i).Value = dr(4)
            dgvview.Item(5, i).Value = dr(5)
            dgvview.Item(6, i).Value = dr(6)
            dgvview.Item(7, i).Value = dr(7)
            dgvview.Item(8, i).Value = dr(8)
            dgvview.Item(9, i).Value = dr(9)
            dgvview.Item(10, i).Value = dr(10)
            dgvview.Item(11, i).Value = dr(11)
            dgvview.Item(12, i).Value = dr(12)
            dgvview.Item(13, i).Value = dr(13)
            dgvview.Item(14, i).Value = dr(14)
            dgvview.Item(15, i).Value = dr(15)
            dgvview.Item(16, i).Value = dr(16)
            dgvview.Item(17, i).Value = dr(17)
            dgvview.Item(18, i).Value = dr(18)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtid.Visible = True
            txtpname.Visible = False
            txtname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 1 Then
            txtid.Visible = False
            txtpname.Visible = True
            txtname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 2 Then
            txtid.Visible = False
            txtname.Visible = True
            txtpname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 3 Then
            txtid.Visible = False
            txtname.Visible = False
            txtpname.Visible = False
            viewdetails()
        End If
    End Sub

    Public Sub load_id()
        open_db()
        qry = "select id from tbl_booking"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtid.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_pname()
        open_db()
        qry = "select p_name from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtpname.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub

    Public Sub load_name()
        open_db()
        qry = "select e_name from tbl_enquiry"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtname.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
End Class