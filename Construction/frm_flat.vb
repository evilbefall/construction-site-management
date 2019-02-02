Imports System.Data.SqlClient
Public Class frm_flat
    Dim flno As Integer
    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If cmbpname.Text = "" Then
            MsgBox("Please Enter The Project Name", MsgBoxStyle.Critical, "Critical")
            cmbpname.Focus()
            Exit Sub
        ElseIf txtfno.Text = "" Then
            MsgBox("Please Enter The Flat Number", MsgBoxStyle.Critical, "Critical")
            txtfno.Focus()
            Exit Sub
        ElseIf txtarea.Text = "" Then
            MsgBox("Please Enter The Area", MsgBoxStyle.Critical, "Critical")
            txtarea.Focus()
            Exit Sub
        End If
        If btnsave.Text = "Save" Then
            open_db()
            qry = "select f_no from tbl_flat where f_no='" & txtfno.Text & "' and  p_id='" & cmbpname.SelectedValue & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Already Assigned", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                open_db()
                qry = "select no_flats from tbl_newproject where p_name='" & cmbpname.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                dr = cmd.ExecuteReader
                If dr.Read Then
                    flno = dr(0)
                End If
                open_db()
                qry = "select count(f_no) from tbl_flat where p_id='" & cmbpname.SelectedValue & "'"
                cmd = New SqlCommand(qry, cnn)
                dr1 = cmd.ExecuteReader
                If dr1.Read Then
                    If dr1(0) = dr(0) Then
                        MsgBox("Total Flats Already Assigned", MsgBoxStyle.Exclamation, "Information")
                        Exit Sub
                    Else

                        open_db()
                        qry = "insert into tbl_flat(f_id,p_id,f_no,Area) values('" & txtfid.Text & "','" & cmbpname.SelectedValue & "','" & txtfno.Text & "','" & txtarea.Text & "')"
                        cmd = New SqlCommand(qry, cnn)
                        cmd.ExecuteNonQuery()
                        MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
                        close_db()
                        clr()
                        cmbpname.Focus()
                        load_id()
                        load_proj()
                        view()
                    End If
                End If
            End If
            If btnsave.Text = "Update" Then
                open_db()
                qry = "update tbl_flat set p_id='" & cmbpname.SelectedValue & "',f_no='" & txtfno.Text & "',Area='" & txtarea.Text & "' where f_id='" & txtfid.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Information")
                close_db()
                clr()
                cmbpname.Focus()
                load_id()
                load_proj()
                view()
                btnsave.Text = "Save"
            End If
        End If
    End Sub

    Public Sub load_proj()
        ds.Clear()
        open_db()
        qry = "select * from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        adapter.SelectCommand = cmd
        adapter.Fill(ds)
        With cmbpname
            .DataSource = ds.Tables(0)
            .ValueMember = "p_id"
            .DisplayMember = "p_name"
            .SelectedValue = -1
        End With
    End Sub

    Private Sub frm_flat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_proj()
        load_id()
        view()

    End Sub
    Public Sub view()
        open_db()
        dgvview.Rows.Clear()
        qry = "SELECT dbo.Tbl_flat.f_id, dbo.Tbl_NewProject.P_name, dbo.Tbl_flat.f_no, dbo.Tbl_flat.Area "
        qry = qry + "FROM dbo.Tbl_NewProject INNER JOIN "
        qry = qry + "dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id"
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
    Private Sub dgvview_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellContentClick
        If e.ColumnIndex = 5 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_flat where f_id ='" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            view()
            load_id()
        ElseIf e.ColumnIndex = 4 Then
            txtfid.Text = dgvview.CurrentRow.Cells(0).Value
            cmbpname.Text = dgvview.CurrentRow.Cells(1).Value
            txtfno.Text = dgvview.CurrentRow.Cells(2).Value
            txtarea.Text = dgvview.CurrentRow.Cells(3).Value
            btnsave.Text = "Update"
        End If
    End Sub
    Public Sub clr()
        cmbpname.SelectedIndex = -1
        txtfno.Clear()
        txtarea.Clear()
    End Sub
    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
        btnsave.Text = "Save"
    End Sub
    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(f_id,2,len(f_id))+1 as int)) from tbl_flat"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txtfid.Text = "F1"
            Else
                txtfid.Text = "F" & dr(0)
            End If
        End If
        close_db()
    End Sub

    Private Sub txtfno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtarea.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class