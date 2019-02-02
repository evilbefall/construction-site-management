Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frm_enquiry

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"

        Dim emailAddressMatch As Match = Regex.Match(txtemail.Text, pattern)

        If txtename.Text = "" Then
            MsgBox("Please Enter The Enquiry Name", MsgBoxStyle.Critical, "Critical")
            txtename.Focus()
        ElseIf txtphno.Text = "" Then
            MsgBox("Please Enter The Phone Number", MsgBoxStyle.Critical, "Critical")
            txtphno.Focus()
        ElseIf txtemail.Text = "" Then
            MsgBox("Please Enter The E-mail Address", MsgBoxStyle.Critical, "Critical")
            txtemail.Focus()
        ElseIf cmbmode.Text = "" Then
            MsgBox("Please Enter The Mode Of Enquiry", MsgBoxStyle.Critical, "Critical")
            cmbmode.Focus()
        ElseIf cmbpname.Text = "" Then
            MsgBox("Please Enter The Project Name", MsgBoxStyle.Critical, "Critical")
            cmbpname.Focus()
        ElseIf cmbptype.Text = "" Then
            MsgBox("Please Enter The Preference Type", MsgBoxStyle.Critical, "Critical")
            cmbptype.Focus()
        ElseIf cmbpstatus.Text = "" Then
            MsgBox("Please Enter The Project Status", MsgBoxStyle.Critical, "Critical")
            cmbpstatus.Focus()
        ElseIf cmbstatus.Text = "" Then
            MsgBox("Please Enter The Enquiry Status", MsgBoxStyle.Critical, "Critical")
            cmbstatus.Focus()
        ElseIf txtcomments.Text = "" Then
            MsgBox("Please Enter The Comment", MsgBoxStyle.Critical, "Critical")
        ElseIf txtphno.TextLength < 10 Then
            MsgBox("Invalid Phone Number", MsgBoxStyle.Exclamation)
            txtphno.Focus()
        ElseIf emailAddressMatch.Success Then
            open_db()
            qry = "insert into tbl_enquiry(e_id,e_name,phno,email,mode_enq,p_id,pref_type,proj_status,e_date,e_time,e_status,e_comments) values('" & txteid.Text & "','" & txtename.Text & "','" & txtphno.Text & "','" & txtemail.Text & "','" & cmbmode.Text & "','" & cmbpname.SelectedValue & "','" & cmbptype.Text & "','" & cmbpstatus.Text & "',convert(date,'" & dtpdate.Value & "',103),convert(time(7),'" & dtptime.Value & "',105),'" & cmbstatus.Text & "','" & txtcomments.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
            close_db()
            clr()
            load_id()
            load_pname()
            txtename.Focus()
        Else
            MsgBox("Email-Address Is Invalid", MsgBoxStyle.Exclamation, "Information")
            txtemail.Focus()
            Exit Sub
        End If
    End Sub
    Public Sub clr()
        txtename.Clear()
        txtphno.Clear()
        txtemail.Clear()
        cmbpname.SelectedIndex = -1
        cmbmode.SelectedIndex = -1
        cmbptype.SelectedIndex = -1
        cmbpstatus.SelectedIndex = -1
        cmbstatus.SelectedIndex = -1
        txtcomments.Clear()
    End Sub

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
    End Sub
    Public Sub load_pname()
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



    Private Sub frm_enquiry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_pname()
        load_id()
    End Sub
    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(E_id,2,len(E_id))+1 as int)) from tbl_enquiry"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txteid.Text = "E1"
            Else
                txteid.Text = "E" & dr(0)
            End If
        End If
        close_db()
    End Sub

    Private Sub txtename_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtename.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtphno_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtphno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class