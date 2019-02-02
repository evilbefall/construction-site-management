Imports System.Data.SqlClient
Public Class FrmViewProject
    Public Sub load_id()
        open_db()
        qry = "select p_id from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtid.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_name()
        open_db()
        qry = "select p_name from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtname.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub viewdetails()
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_newproject"
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
            i = i + 1
        End While
        close_db()
    End Sub
    Private Sub dgvview_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellContentClick
        If e.ColumnIndex = 16 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_newproject where p_id= '" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            viewdetails()
        ElseIf e.ColumnIndex = 15 Then
            prjid = dgvview.CurrentRow.Cells(0).Value
            editrec = True
            frm_newProject.Show()
        End If
    End Sub

    Private Sub FrmViewProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        viewdetails()
        load_id()
        load_name()
        txtid.Visible = False
        txtname.Visible = False
    End Sub
    Public Sub view()
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECt * from tbl_newproject"
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
            i = i + 1
        End While
        close_db()
    End Sub
    Private Sub cmbsearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtid.Visible = False
            txtname.Visible = True
        End If
        If cmbsearch.SelectedIndex = 1 Then
            txtid.Visible = True
            txtname.Visible = False
        End If
        If cmbsearch.SelectedIndex = 2 Then
            txtid.Visible = False
            txtname.Visible = False
            View()
        End If
    End Sub

    Private Sub txtid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECt * from tbl_newproject where p_id like '" & txtid.Text & "%'"
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
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname.TextChanged
        dgvview.Rows.Clear()
        open_db()
        qry = "SELECt * from tbl_newproject where p_name like '" & txtname.Text & "%'"
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
            i = i + 1
        End While
        close_db()
    End Sub
End Class