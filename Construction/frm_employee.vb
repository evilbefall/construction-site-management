Imports System.Data.SqlClient
Public Class frm_employee
    Dim doj As DateTime
    Public Sub clr()
        txtname.Clear()
        Txtadrs.Clear()
        txtcno.Clear()
        cmbdesig.Text = ""
        txtbasic.Clear()
        cmbsearch.SelectedIndex = -1
        txtsid.Visible = False
        txtsname.Visible = False
        dtpdate.Visible = False

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtname.Text = "" Then
            MsgBox("Please Enter The Employee Name", MsgBoxStyle.Critical, "Critical")
            txtname.Focus()
        ElseIf Txtadrs.Text = "" Then
            MsgBox("Please Enter The Address", MsgBoxStyle.Critical, "Critical")
            Txtadrs.Focus()
        ElseIf txtcno.Text = "" Then
            MsgBox("Please Enter The Contact Number", MsgBoxStyle.Critical, "Critical")
            txtcno.Focus()
        ElseIf cmbdesig.Text = "" Then
            MsgBox("Please Enter The Designation", MsgBoxStyle.Critical, "Critical")
            cmbdesig.Focus()
        ElseIf txtbasic.Text = "" Then
            MsgBox("Please Enter The Basic Salary", MsgBoxStyle.Critical, "Critical")
            txtbasic.Focus()
        ElseIf txtcno.TextLength < 10 Then
            MsgBox("Invalid Contact Number", MsgBoxStyle.Critical, "Critical")
            txtcno.Focus()
        ElseIf btnsave.Text = "Save" Then
            open_db()
            qry = "insert into tbl_employee (e_id,ename,addr,cno,desig,dob,doj,basic) values('" & txtid.Text & "','" & txtname.Text & "','" & Txtadrs.Text & "','" & txtcno.Text & "','" & cmbdesig.Text & "',convert(date,'" & dtpdob.Value & "',103),convert(date,'" & dtpdoj.Value & "',103),'" & txtbasic.Text & "') "
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            view_details()
        ElseIf btnsave.Text = "Update" Then
            open_db()
            qry = "update tbl_employee set ename='" & txtname.Text & "',addr='" & Txtadrs.Text & "',cno='" & txtcno.Text & "',desig='" & cmbdesig.Text & "',dob=convert(date,'" & dtpdob.Value & "',103),doj=convert(date,'" & dtpdoj.Value & "',103),basic='" & txtbasic.Text & "' where e_id='" & txtid.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            view_details()
            btnsave.Text = "Save"
            load_id()
        End If
    End Sub
    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(e_id,2,len(e_id))+1 as int)) from tbl_employee"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txtid.Text = "E1"
            Else
                txtid.Text = "E" & dr(0)
            End If
        End If
        close_db()
    End Sub

    Private Sub frm_employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_eid()
        load_name()
        load_id()
        load_desg()
        view_details()
        dtpdob.MaxDate = Today.AddYears(-18)
        dtpdoj.MinDate = dtpdob.Value.AddYears(18)
        txtsid.Visible = False
        txtsname.Visible = False
        dtpdate.Visible = False
    End Sub
    Public Sub view_details()
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_employee"
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
            dgvview.Item(7, i).Value = Format(dr(7), "00.00")

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub dgvview_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellContentClick
        If e.ColumnIndex = 8 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_employee where e_id ='" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            close_db()
            view_details()
            load_id()
        ElseIf e.ColumnIndex = 9 Then
            txtid.Text = dgvview.CurrentRow.Cells(0).Value
            txtname.Text = dgvview.CurrentRow.Cells(1).Value
            Txtadrs.Text = dgvview.CurrentRow.Cells(2).Value
            txtcno.Text = dgvview.CurrentRow.Cells(3).Value
            cmbdesig.Text = dgvview.CurrentRow.Cells(4).Value
            dtpdob.Value = dgvview.CurrentRow.Cells(5).Value
            dtpdoj.Value = dgvview.CurrentRow.Cells(6).Value
            txtbasic.Text = dgvview.CurrentRow.Cells(7).Value
            btnsave.Text = "Update"
        End If
    End Sub

    Private Sub txtname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtbasic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbasic.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Public Sub load_desg()
        open_db()
        qry = "select desig from tbl_employee"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbdesig.Items.Clear()
        While dr.Read = True
            cmbdesig.Items.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub cmbdesig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdesig.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clr()
        load_id()
        view_details()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbsearch.SelectedIndexChanged
        If cmbsearch.SelectedIndex = 0 Then
            txtsid.Visible = True
            txtsname.Visible = False
            dtpdate.Visible = False
        ElseIf cmbsearch.SelectedIndex = 1 Then
            txtsid.Visible = False
            txtsname.Visible = True
            dtpdate.Visible = False
        ElseIf cmbsearch.SelectedIndex = 2 Then
            txtsid.Visible = False
            txtsname.Visible = False
            dtpdate.Visible = True
        End If

    End Sub

    Private Sub txtsid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsid.TextChanged
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_employee where e_id like '" & txtsid.Text & "%'"
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
            dgvview.Item(7, i).Value = Format(dr(7), "00.00")

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub txtsname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsname.TextChanged

        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_employee where ename like '" & txtsname.Text & "%'"
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
            dgvview.Item(7, i).Value = Format(dr(7), "00.00")

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub dtpdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdate.ValueChanged
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_employee where doj=convert(date,'" & dtpdate.Value & "',103)"
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
            dgvview.Item(7, i).Value = Format(dr(7), "00.00")

            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub dtpdob_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpdob.TextChanged

    End Sub

    Private Sub dtpdob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdob.ValueChanged
        dtpdoj.MinDate = dtpdob.Value.AddYears(18)
        dtpdoj.Value = dtpdoj.MinDate
    End Sub
    Public Sub load_name()
        open_db()
        qry = "select ename from tbl_employee"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtsname.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_eid()
        open_db()
        qry = "select e_id from tbl_employee"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        While dr.Read = True
            txtsid.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
End Class