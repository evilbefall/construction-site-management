Imports System.Data.SqlClient
Public Class frm_agrement

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
        btnsave.Text = "Save"
    End Sub
    Public Sub clr()
        txtagr.Clear()
        txttax.Clear()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If txtagr.Text = "" Or txttax.Text = "" Then
            MsgBox("Enter All The Details", MsgBoxStyle.Critical)
        ElseIf btnsave.Text = "Save" Then
            open_db()
            qry = "insert into tbl_agrement(name_of_agrement,tax) values('" & txtagr.Text & "','" & txttax.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            view()
        ElseIf btnsave.Text = "Update" Then
            open_db()
            qry = "update tbl_agrement set name_of_agrement='" & txtagr.Text & "',tax='" & txttax.Text & "' where id='" & gid & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            view()
            btnsave.Text = "Save"
        End If
    End Sub
    Public Sub view()
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_agrement"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub dgvview_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellClick
        If e.ColumnIndex = 4 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete", MsgBoxStyle.Question + MsgBoxStyle.YesNo) Then Exit Sub
            open_db()
            qry = "delete from tbl_agrement where id='" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            view()
        ElseIf e.ColumnIndex = 3 Then
            gid = dgvview.CurrentRow.Cells(0).Value
            txtagr.Text = dgvview.CurrentRow.Cells(1).Value
            txttax.Text = dgvview.CurrentRow.Cells(2).Value
            btnsave.Text = "Update"
        End If
    End Sub
  

    Private Sub frm_agrement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view()
    End Sub

    Private Sub txtagr_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtagr.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txttax_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttax.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class