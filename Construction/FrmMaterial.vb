Imports System.Data.SqlClient

Public Class FrmMaterial
    Dim matid As Integer
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtmaterial.Text = "" Then
            MsgBox("Please Enter The Material Name", MsgBoxStyle.Critical, "Critical")
            txtmaterial.Focus()
        ElseIf txtqty.Text = "" Then
            MsgBox("Please Enter The Quantity", MsgBoxStyle.Critical, "Critical")
            txtqty.Focus()
        ElseIf txtrate.Text = "" Then
            MsgBox("Please Enter The Rate", MsgBoxStyle.Critical, "Critical")
            txtrate.Focus()
        ElseIf btnsave.Text = "Save" Then
            open_db()
            qry = "select material from tbl_material where material='" & txtmaterial.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Already Exist", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            close_db()

            open_db()
            qry = "insert into tbl_material(material,rate,quantity) values('" & txtmaterial.Text & "','" & txtrate.Text & "','" & txtqty.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            close_db()

            open_db()
            qry = "select max(m_id) from tbl_material"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                matid = dr(0)
            End If
            close_db()


            open_db()
            qry = "insert into tbl_rawstock(m_id,quantity)values('" & matid & "','" & txtqty.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
            close_db()
            txtmaterial.Focus()
            clr()
            veiwdetails()
        ElseIf btnsave.Text = "Update" Then
            open_db()
            qry = "update tbl_material set material='" & txtmaterial.Text & "',rate='" & txtrate.Text & "',quantity='" & txtqty.Text & "' where m_id='" & mid & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information, "Information")
            close_db()
            clr()
            veiwdetails()
            txtmaterial.ReadOnly = False
            btnsave.Text = "Save"
        End If
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clr()
        txtmaterial.ReadOnly = False
        txtmaterial.Focus()
        btnsave.Text = "Save"
    End Sub
    Public Sub clr()
        txtmaterial.Clear()
        txtrate.Clear()
        txtqty.Clear()
    End Sub

    Public Sub veiwdetails()
        open_db()
        dgvview.Rows.Clear()
        qry = "select * from tbl_material"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvview.Rows.Add()
            dgvview.Item(0, i).Value = dr(0)
            dgvview.Item(1, i).Value = dr(1)
            dgvview.Item(2, i).Value = dr(3)
            dgvview.Item(3, i).Value = dr(2)
            i = i + 1

        End While
        close_db()
    End Sub

    Private Sub FrmMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        veiwdetails()

    End Sub

    Private Sub dgvview_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvview.CellClick
        If e.ColumnIndex = 5 Then
            If MsgBoxResult.No = MsgBox("Are You Sure You Want To Delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) Then Exit Sub
            open_db()
            qry = "delete from tbl_material where m_id= '" & dgvview.CurrentRow.Cells(0).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information, "Information")
            close_db()

            veiwdetails()
        ElseIf e.ColumnIndex = 4 Then
            mid = dgvview.CurrentRow.Cells(0).Value
            txtmaterial.Text = dgvview.CurrentRow.Cells(1).Value
            txtqty.Text = dgvview.CurrentRow.Cells(2).Value
            txtrate.Text = dgvview.CurrentRow.Cells(3).Value
            btnsave.Text = "Update"
            txtmaterial.ReadOnly = True
        End If
    End Sub

    Private Sub txtmaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaterial.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class