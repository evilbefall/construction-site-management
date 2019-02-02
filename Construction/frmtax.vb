Imports System.Data.SqlClient
Public Class frmtax

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        If txttax.Text = "" Then
            MsgBox("Please Enter The Tax", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If txttax.Text = "" Then
            open_db()
            qry = "insert into tbl_tax(tax)values('" & txttax.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Entered Successfully", MsgBoxStyle.Information)
            close_db()
        ElseIf txttax.Text <> "" Then
            open_db()
            qry = "update tbl_tax set tax='" & txttax.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)
            close_db()
        End If
        

    End Sub

    Private Sub frmtax_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_db()
        qry = "select * from tbl_tax"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txttax.Text = dr(0)

        End If
        close_db()

    End Sub

    Private Sub txttax_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttax.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

End Class