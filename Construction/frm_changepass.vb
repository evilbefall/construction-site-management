Imports System.Data.SqlClient
Public Class frm_changepass

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If txtop.Text = "" Or txtnp.Text = "" Or txtcp.Text = "" Then
            MsgBox("Please Enter All The Fields", MsgBoxStyle.Critical)
            Exit Sub
        End If
        open_db()
        qry = "select usr_pwd from tbl_login where usr_id = '" & u_id & "'"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If dr(0) <> txtop.Text Then
                MsgBox("Old Password is Incorrect", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf txtnp.Text <> txtcp.Text Then
                MsgBox("Confirm Your Password", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                open_db()
                qry = "update tbl_login set usr_pwd='" & txtcp.Text & "' where usr_id = '" & u_id & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Password Changed Successfully", MsgBoxStyle.Information)
                close_db()
                clr()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        clr()
    End Sub
    Public Sub clr()
        txtop.Text = ""
        txtnp.Text = ""
        txtcp.Text = ""
    End Sub
End Class