Imports System.Data.SqlClient
Public Class frmsearchenquiry

  

    Public Sub view()
        dgvview.Rows.Clear()
        open_db()
        qry = "Select * from tbl_enquiry"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub frmsearchenquiry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtname.Visible = False
        txtid.Visible = False
        dtpdate.Visible = False
        load_name()
        load_id()
        view()
    End Sub

    Private Sub cmbstatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbstatus.SelectedIndexChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "Select * from tbl_enquiry where e_status='" & cmbstatus.Text & "'"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtid.Visible = True
            dtpdate.Visible = False
            txtname.Visible = False
            txtname.Clear()
        ElseIf cmbsearch.SelectedIndex = 1 Then
            txtid.Visible = False
            dtpdate.Visible = True
            txtname.Visible = False
            txtid.Clear()
            txtname.Clear()
        ElseIf cmbsearch.SelectedIndex = 2 Then
            txtid.Visible = False
            dtpdate.Visible = False
            txtname.Visible = True
            txtid.Clear()
        ElseIf cmbsearch.SelectedIndex = 3 Then
            txtid.Visible = False
            dtpdate.Visible = False
            txtname.Visible = False
            txtid.Clear()
            txtname.Clear()
            view()
        End If
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "Select * from tbl_enquiry where e_id like '" & txtid.Text & "%'"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "Select * from tbl_enquiry where e_name like '" & txtname.Text & "%'"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub dtpdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdate.ValueChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "Select * from tbl_enquiry where e_date = convert(date,'" & dtpdate.Value & "',103)"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Public Sub load_id()
        open_db()
        qry = "select e_id from tbl_enquiry"
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
End Class