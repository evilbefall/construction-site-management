Imports System.Data.SqlClient
Public Class frm_company

    Private Sub btnupdate_Click(sender As System.Object, e As System.EventArgs) Handles btnupdate.Click
        If txtname.Text = "" Then
            MsgBox("Please Enter The Company Name", MsgBoxStyle.Critical, "Critical")
            txtname.Focus()
        ElseIf txtaddrs.Text = "" Then
            MsgBox("Please Enter The Company Address", MsgBoxStyle.Critical, "Critical")
            txtaddrs.Focus()
        ElseIf txtphone.Text = "" Then
            MsgBox("Please Enter The Contact Number", MsgBoxStyle.Critical, "Critical")
            txtphone.Focus()
        ElseIf txtlogo.Text = "" Then
            MsgBox("Please Enter The Logo", MsgBoxStyle.Critical, "Critical")
            txtlogo.Focus()
            Exit Sub
        End If
        If txtname.Text = "" Then
            open_db()
            qry = "insert into tbl_company(Comp_name,Comp_addrs,Comp_phno,Comp_logo) values('" & txtname.Text & "','" & txtaddrs.Text & "','" & txtphone.Text & "','" & txtlogo.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Inserted", MsgBoxStyle.Information)
            close_db()
        ElseIf txtname.Text <> "" Then
            open_db()
            qry = "update tbl_company set Comp_name='" & txtname.Text & "',Comp_addrs='" & txtaddrs.Text & "',Comp_phno='" & txtphone.Text & "',Comp_logo='" & txtlogo.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("updated Successfully", MsgBoxStyle.Information)
            close_db()
        End If
    End Sub

    Private Sub frm_company_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        open_db()
        qry = "select * from tbl_company"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtname.Text = dr(0)
            txtaddrs.Text = dr(1)
            txtphone.Text = dr(2)
            txtlogo.Text = dr(3)
            PictureBox1.ImageLocation = dr(3)
        End If
        close_db()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
        txtlogo.Text = PictureBox1.ImageLocation
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtphone.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtname.TextChanged

    End Sub
End Class