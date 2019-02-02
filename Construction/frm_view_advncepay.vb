Imports System.Data.SqlClient
Public Class frm_view_advncepay

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

    Private Sub frm_view_advncepay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view()
        load_id()
        load_name()
        txtid.Visible = False
        txtname.Visible = False
    End Sub
    Public Sub view()
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.tbl_advance.id, dbo.tbl_enquiry.E_name, dbo.tbl_advance.payment, dbo.tbl_advance.cheque_no, dbo.tbl_advance.bank, dbo.tbl_advance.cheque_amt, "
        qry = qry + "dbo.tbl_advance.cash, dbo.tbl_advance.total "
        qry = qry + "FROM         dbo.tbl_advance INNER JOIN "
        qry = qry + "dbo.tbl_booking ON dbo.tbl_advance.id = dbo.tbl_booking.id INNER JOIN "
        qry = qry + " dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id "
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
           
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtid.Visible = True
            txtname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 1 Then
            txtid.Visible = False
            txtname.Visible = True
        End If
        If cmbsearch.SelectedIndex = 2 Then
            txtid.Visible = False
            txtname.Visible = False
            view()
        End If
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.tbl_advance.id, dbo.tbl_enquiry.E_name, dbo.tbl_advance.payment, dbo.tbl_advance.cheque_no, dbo.tbl_advance.bank, dbo.tbl_advance.cheque_amt, "
        qry = qry + "dbo.tbl_advance.cash, dbo.tbl_advance.total "
        qry = qry + "FROM         dbo.tbl_advance INNER JOIN "
        qry = qry + "dbo.tbl_booking ON dbo.tbl_advance.id = dbo.tbl_booking.id INNER JOIN "
        qry = qry + " dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id where dbo.tbl_enquiry.E_name like '" & txtname.Text & "%'"
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

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECT     dbo.tbl_advance.id, dbo.tbl_enquiry.E_name, dbo.tbl_advance.payment, dbo.tbl_advance.cheque_no, dbo.tbl_advance.bank, dbo.tbl_advance.cheque_amt, "
        qry = qry + "dbo.tbl_advance.cash, dbo.tbl_advance.total "
        qry = qry + "FROM         dbo.tbl_advance INNER JOIN "
        qry = qry + "dbo.tbl_booking ON dbo.tbl_advance.id = dbo.tbl_booking.id INNER JOIN "
        qry = qry + " dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id where dbo.tbl_booking.id like '" & txtid.Text & "%'"
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

            i = i + 1
        End While
        close_db()
    End Sub
End Class