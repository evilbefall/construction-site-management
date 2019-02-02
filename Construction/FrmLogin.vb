Imports System.Data.SqlClient
Public Class FrmLogin

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
        cmbtype.Focus()
    End Sub
    Public Sub clr()
        cmbtype.SelectedIndex = -1
        txtname.Clear()
        txtpassword.Clear()

    End Sub

    Private Sub btnlogin_Click(sender As System.Object, e As System.EventArgs) Handles btnlogin.Click
        If cmbtype.Text = "" Then
            MsgBox("Please Enter The User Type", MsgBoxStyle.Critical, "Error")
            cmbtype.Focus()
        ElseIf txtname.Text = "" Then
            MsgBox("Please Enter The User Name", MsgBoxStyle.Critical, "Error")
            txtname.Focus()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please Enter The Password", MsgBoxStyle.Critical, "Error")
            txtpassword.Focus()
        Else
            open_db()
            qry = "select * from tbl_login where usr_type='" & cmbtype.Text & "' and usr_name='" & txtname.Text & "' and usr_pwd='" & txtpassword.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                u_id = dr(0)
                u_type = cmbtype.Text
                Dashboard.MenuStrip1.Enabled = True
                Dashboard.btnlogin.Visible = False
                Me.Hide()
            Else
                MsgBox("Invalid User Name or Password", MsgBoxStyle.Critical, "Error")
            End If
            close_db()
        End If
    End Sub

    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dashboard.btnlogin.Visible = True
    End Sub
End Class