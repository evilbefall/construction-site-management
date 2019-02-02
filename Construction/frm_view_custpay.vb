Imports System.Data.SqlClient
Public Class frm_view_custpay

    Public Sub load_bno()
        open_db()
        qry = "select b_no from tbl_custpay"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtbno.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_cname()
        open_db()
        qry = "select e_name from tbl_enquiry"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtcname.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_cid()
        open_db()
        qry = "select id from tbl_booking"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtcid.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub

    Public Sub view()
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.Tbl_custpay.b_no, dbo.Tbl_custpay.c_id, dbo.tbl_enquiry.E_name, dbo.tbl_booking.grand_tot, dbo.Tbl_custpay.recieved, dbo.Tbl_custpay.pending, "
        qry = qry + " dbo.Tbl_custpay.vat, dbo.Tbl_custpay.amt_paid, dbo.Tbl_custpay.bal "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "              dbo.Tbl_custpay ON dbo.tbl_booking.id = dbo.Tbl_custpay.c_id INNER JOIN "
        qry = qry + "             dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id INNER JOIN "
        qry = qry + "            dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id"
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

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub frm_view_custpay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtbno.Visible = False
        txtcid.Visible = False
        txtcname.Visible = False
        view()
        load_bno()
        load_cname()
        load_cid()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtbno.Visible = True
            txtcid.Visible = False
            txtcname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 1 Then
            txtbno.Visible = False
            txtcid.Visible = True
            txtcname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 2 Then
            txtbno.Visible = False
            txtcid.Visible = False
            txtcname.Visible = True
        End If
        If cmbsearch.SelectedIndex = 3 Then
            txtbno.Visible = False
            txtcid.Visible = False
            txtcname.Visible = False
            view()
        End If
    End Sub

    Private Sub txtcid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcid.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.Tbl_custpay.b_no, dbo.Tbl_custpay.c_id, dbo.tbl_enquiry.E_name, dbo.tbl_booking.grand_tot, dbo.Tbl_custpay.recieved, dbo.Tbl_custpay.pending, "
        qry = qry + " dbo.Tbl_custpay.vat, dbo.Tbl_custpay.amt_paid, dbo.Tbl_custpay.bal "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "              dbo.Tbl_custpay ON dbo.tbl_booking.id = dbo.Tbl_custpay.c_id INNER JOIN "
        qry = qry + "             dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id INNER JOIN "
        qry = qry + "            dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id where dbo.Tbl_custpay.c_id like '" & txtcid.Text & "%'"
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

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtbno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbno.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.Tbl_custpay.b_no, dbo.Tbl_custpay.c_id, dbo.tbl_enquiry.E_name, dbo.tbl_booking.grand_tot, dbo.Tbl_custpay.recieved, dbo.Tbl_custpay.pending, "
        qry = qry + " dbo.Tbl_custpay.vat, dbo.Tbl_custpay.amt_paid, dbo.Tbl_custpay.bal "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "              dbo.Tbl_custpay ON dbo.tbl_booking.id = dbo.Tbl_custpay.c_id INNER JOIN "
        qry = qry + "             dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id INNER JOIN "
        qry = qry + "            dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id where dbo.Tbl_custpay.b_no like '" & txtbno.Text & "%'"
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

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtcname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcname.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.Tbl_custpay.b_no, dbo.Tbl_custpay.c_id, dbo.tbl_enquiry.E_name, dbo.tbl_booking.grand_tot, dbo.Tbl_custpay.recieved, dbo.Tbl_custpay.pending, "
        qry = qry + " dbo.Tbl_custpay.vat, dbo.Tbl_custpay.amt_paid, dbo.Tbl_custpay.bal "
        qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
        qry = qry + "              dbo.Tbl_custpay ON dbo.tbl_booking.id = dbo.Tbl_custpay.c_id INNER JOIN "
        qry = qry + "             dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id INNER JOIN "
        qry = qry + "            dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id where dbo.tbl_enquiry.E_name like '" & txtcname.Text & "%'"
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

            i = i + 1
        End While
        close_db()
    End Sub
End Class