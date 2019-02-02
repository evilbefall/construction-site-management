Imports System.Data.SqlClient
Public Class FrmRegister

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
        btnreg.Text = "Register"
        txtname.ReadOnly = False
    End Sub
    Public Sub clr()
        cmbtype.SelectedIndex = -1
        txtname.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub btnreg_Click(sender As System.Object, e As System.EventArgs) Handles btnreg.Click
        If cmbtype.Text = "" Then
            MsgBox("Please Enter The Type", MsgBoxStyle.Critical, "Critical")
            cmbtype.Focus()
        ElseIf txtname.Text = "" Then
            MsgBox("Please Enter The Name", MsgBoxStyle.Critical, "Critical")
            txtname.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please Enter The Password", MsgBoxStyle.Critical, "Critical")
            txtpassword.Focus()
        ElseIf btnreg.Text = "Register" Then
            open_db()
            qry = "select usr_name from tbl_login where usr_name='" & txtname.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("User Name Already Exists! ", MsgBoxStyle.Exclamation)
                Exit Sub
            Else

                open_db()
                qry = "insert into tbl_login(usr_type,usr_name,usr_pwd)values('" & cmbtype.Text & "','" & txtname.Text & "','" & txtpassword.Text & "')"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Registered Successfully", MsgBoxStyle.Information)
                close_db()
                clr()
                view_details()
            End If
        ElseIf btnreg.Text = "Update" Then
            open_db()
            qry = "update tbl_login set usr_type='" & cmbtype.Text & "',usr_name='" & txtname.Text & "',usr_pwd='" & txtpassword.Text & "' where usr_id='" & rid & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            view_details()
            btnreg.Text = "Register"
            txtname.ReadOnly = False
        End If
    End Sub

    Public Sub view_details()
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_login"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(2)
            dgvview.Item(3, i).Value = dr(3)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        view_details()
    End Sub

    Private Sub dgvview_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellClick
        If e.ColumnIndex = 5 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_login where usr_id='" & dgvview.CurrentRow.Cells(0).Value & "' "
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            view_details()
        ElseIf e.ColumnIndex = 4 Then
            rid = dgvview.CurrentRow.Cells(0).Value
            cmbtype.Text = dgvview.CurrentRow.Cells(1).Value
            txtname.Text = dgvview.CurrentRow.Cells(2).Value
            txtpassword.Text = dgvview.CurrentRow.Cells(3).Value
            btnreg.Text = "Update"
            txtname.ReadOnly = True
        End If
    End Sub
End Class
