Imports System.Data.SqlClient
Public Class FrmAdvancePay

    Private Sub txtcheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcheque.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbid.Text = "" Or cmbproj.Text = "" Or txtname.Text = "" Or txtcontact.Text = "" Or cmbflat.Text = "" Or txtfamt.Text = "" Then
            MsgBox("Enter All The Details", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf cmbpay.Text = "" Then
            MsgBox("Please Enter The Payment Method", MsgBoxStyle.Critical, "Critical")
            cmbpay.Focus()
            Exit Sub
        ElseIf cmbpay.Text = "Both" Then
            If txtcheque.Text = "" Then
                MsgBox("Please Enter The Cheque Number", MsgBoxStyle.Critical, "Critical")
                txtcheque.Focus()
                Exit Sub
            ElseIf txtbank.Text = "" Then
                MsgBox("Please Enter The Bank Or Branch Name", MsgBoxStyle.Critical, "Critical")
                txtbank.Focus()
                Exit Sub
            ElseIf txtamt.Text = "" Then
                MsgBox("Please Enter The Cheque Amount", MsgBoxStyle.Critical, "Critical")
                txtamt.Focus()
                Exit Sub
            ElseIf txtcash.Text = "" Then
                MsgBox("Please Enter The Cash Amount", MsgBoxStyle.Critical, "Critical")
                txtcash.Focus()
            Else
                open_db()
                qry = "insert into tbl_advance(id,payment,cheque_no,bank,cheque_amt,cash,total)values('" & cmbid.Text & "','" & cmbpay.Text & "','" & txtcheque.Text & "','" & txtbank.Text & "','" & txtamt.Text & "','" & txtcash.Text & "','" & txttotal.Text & "')"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                close_db()

                open_db()
                qry = "update tbl_gtot set g_tot='" & txttotal.Text & "' where id='" & cmbid.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
                close_db()

                clr()
                Exit Sub
            End If
        ElseIf cmbpay.Text = "Cheque" Then
            If txtcheque.Text = "" Then
                MsgBox("Please Enter The Cheque Number", MsgBoxStyle.Critical, "Critical")
                txtcheque.Focus()
                Exit Sub
            ElseIf txtbank.Text = "" Then
                MsgBox("Please Enter The Bank Or Branch Name", MsgBoxStyle.Critical, "Critical")
                txtbank.Focus()
                Exit Sub
            ElseIf txtamt.Text = "" Then
                MsgBox("Please Enter The Cheque Amount", MsgBoxStyle.Critical, "Critical")
                txtamt.Focus()
            Else
                open_db()
                qry = "insert into tbl_advance(id,payment,cheque_no,bank,cheque_amt,cash,total)values('" & cmbid.Text & "','" & cmbpay.Text & "','" & txtcheque.Text & "','" & txtbank.Text & "','" & txtamt.Text & "','" & txtcash.Text & "','" & txttotal.Text & "')"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                close_db()

                open_db()
                qry = "update tbl_gtot set g_tot='" & txttotal.Text & "' where id='" & cmbid.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
                close_db()

                clr()
                Exit Sub
            End If
        ElseIf cmbpay.Text = "Cash" Then
            If txtcash.Text = "" Then
                MsgBox("Please Enter The Cash Amount", MsgBoxStyle.Critical, "Critical")
                txtcash.Focus()
            Else
                open_db()
                qry = "insert into tbl_advance(id,payment,cheque_no,bank,cheque_amt,cash,total)values('" & cmbid.Text & "','" & cmbpay.Text & "','" & txtcheque.Text & "','" & txtbank.Text & "','" & txtamt.Text & "','" & txtcash.Text & "','" & txttotal.Text & "')"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                close_db()

                open_db()
                qry = "update tbl_gtot set g_tot='" & txttotal.Text & "' where id='" & cmbid.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
                close_db()

                clr()
                Exit Sub
            End If
            'Else

            '    open_db()
            '    qry = "insert into tbl_advance(id,payment,cheque_no,bank,cheque_amt,cash,total)values('" & cmbid.Text & "','" & cmbpay.Text & "','" & txtcheque.Text & "','" & txtbank.Text & "','" & txtamt.Text & "','" & txtcash.Text & "','" & txttotal.Text & "')"
            '    cmd = New SqlCommand(qry, cnn)
            '    cmd.ExecuteNonQuery()
            '    close_db()

            '    open_db()
            '    qry = "update tbl_gtot set g_tot='" & txtfbal.Text & "' where id='" & cmbid.Text & "'"
            '    cmd = New SqlCommand(qry, cnn)
            '    cmd.ExecuteNonQuery()
            '    MsgBox("Saved Successfully", MsgBoxStyle.Information, "Information")
            '    close_db()

            '    clr()
        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcash.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfamt.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub load_id()
        open_db()
        qry = "select id from tbl_booking"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbid.Items.Clear()
        While dr.Read = True
            cmbid.Items.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub frmadvance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cmbpay.SelectedIndex = -1 Then
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
        End If
        'load_flat()
        load_id()
        'load_name()
        clr()
    End Sub

    Private Sub cmbid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbid.SelectedIndexChanged
        If cmbid.SelectedIndex > -1 Then
            open_db()
            qry = "SELECT     dbo.Tbl_NewProject.P_name, dbo.tbl_enquiry.E_name, dbo.tbl_enquiry.phno, dbo.tbl_booking.f_no, dbo.tbl_booking.grand_tot, dbo.tbl_gtot.g_tot "
            qry = qry + "FROM         dbo.tbl_enquiry INNER JOIN "
            qry = qry + "          dbo.tbl_booking ON dbo.tbl_enquiry.E_id = dbo.tbl_booking.e_id INNER JOIN "
            qry = qry + "       dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id INNER JOIN "
            qry = qry + "      dbo.Tbl_NewProject ON dbo.tbl_enquiry.P_id = dbo.Tbl_NewProject.P_id where  dbo.tbl_booking.id='" & cmbid.SelectedItem & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cmbproj.Text = dr(0)
                txtname.Text = dr(1)
                txtcontact.Text = dr(2)
                cmbflat.Text = dr(3)
                txtfamt.Text = dr(4)
                txtbal.Text = dr(5)
            End If
            txtfbal.Text = txtbal.Text
            close_db()
        End If
    End Sub

    Private Sub txtcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged
        'If cmbpay.SelectedIndex = 0 Then
        '    txttotal.Text = Val(txtamt.Text)
        'ElseIf cmbpay.SelectedIndex = 1 Then
        '    txttotal.Text = Val(txtcash.Text)
        If Val(txtcash.Text) > Val(txtfamt.Text) Then
            MsgBox("Invalid Amount", MsgBoxStyle.Exclamation, "Information")
            txtcash.Clear()
            txtcash.Focus()
            Exit Sub
        End If
        If cmbpay.SelectedIndex = 1 Then
            If Val(txtcash.Text) > Val(txtbal.Text) Then

                txtfbal.Text = 0
            Else
                txtfbal.Text = Val(txtbal.Text) - Val(txtcash.Text)
                txttotal.Text = Val(txtcash.Text)
            End If
   
        ElseIf cmbpay.SelectedIndex = 2 Then
            txttotal.Text = Val(txtamt.Text) + Val(txtcash.Text)
            txtfbal.Text = Val(txtbal.Text) - Val(txttotal.Text)
        End If
        'End If
    End Sub

    Private Sub txtamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamt.TextChanged
        'If cmbpay.SelectedIndex = 0 Then

        'ElseIf cmbpay.SelectedIndex = 1 Then
        '  
       
        'End If
        If Val(txtamt.Text) > Val(txtfamt.Text) Then
            MsgBox("Invalid Amount", MsgBoxStyle.Exclamation, "Information")
            txtamt.Clear()
            txtamt.Focus()
            Exit Sub
        End If
        If cmbpay.SelectedIndex = 0 Then
            txtfbal.Text = Val(txtfamt.Text) - Val(txtamt.Text)
            txttotal.Text = Val(txtamt.Text)
        ElseIf cmbpay.SelectedIndex = 2 Then
            txttotal.Text = Val(txtamt.Text) + Val(txtcash.Text)
            txtfbal.Text = Val(txtbal.Text) - Val(txttotal.Text)
        End If
    End Sub
    'Public Sub load_name()
    '    open_db()
    '    qry = "select p_name from tbl_newproject"
    '    cmd = New SqlCommand(qry, cnn)
    '    dr = cmd.ExecuteReader
    '    cmbproj.Items.Clear()
    '    While dr.Read = True
    '        cmbproj.Items.Add(dr(0))
    '    End While
    '    close_db()
    'End Sub
    'Public Sub load_flat()
    '    open_db()
    '    qry = "SELECT     dbo.Tbl_flat.f_no "
    '    qry = qry + "FROM         dbo.Tbl_flat INNER JOIN "
    '    qry = qry + "             dbo.Tbl_NewProject ON dbo.Tbl_flat.p_id = dbo.Tbl_NewProject.P_id where dbo.Tbl_NewProject.P_name='" & cmbproj.Text & "'"
    '    cmd = New SqlCommand(qry, cnn)
    '    dr = cmd.ExecuteReader
    '    cmbflat.Items.Clear()
    '    While dr.Read = True
    '        cmbflat.Items.Add(dr(0))
    '    End While
    '    close_db()
    'End Sub

    Private Sub cmbflat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbflat.SelectedIndex > -1 Then


        '    open_db()
        '    qry = "select area from tbl_flat where f_no='" & cmbflat.SelectedItem & "'"
        '    cmd = New SqlCommand(qry, cnn)
        '    dr = cmd.ExecuteReader
        '    If dr.Read = True Then
        '        txtarea.Text = dr(0)
        '    End If
        '    close_db()
        'End If
    End Sub

    Private Sub cmbpay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpay.SelectedIndexChanged
        If cmbpay.SelectedIndex = 0 Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = False
            txtcash.Clear()
            txttotal.Clear()
            txtfbal.Text = txtbal.Text
            'txtbal.Clear()
        ElseIf cmbpay.SelectedIndex = 1 Then
            GroupBox3.Enabled = True
            GroupBox2.Enabled = False
            txtcheque.Clear()
            txtbank.Clear()
            txtamt.Clear()
            txtfbal.Text = txtbal.Text
            txttotal.Clear()
        ElseIf cmbpay.SelectedIndex = 2 Then
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            txtcheque.Clear()
            txtbank.Clear()
            txtamt.Clear()
            txtfbal.Text = txtbal.Text
            txttotal.Clear()
            txtcash.Clear()
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub cmbproj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'load_flat()
    End Sub

    Private Sub txttotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttotal.TextChanged
        If Val(txttotal.Text) > Val(txtfamt.Text) Then
            MsgBox("You Are Paying More Than The Total Amount Of Flat", MsgBoxStyle.Exclamation, "Information")
            txttotal.Clear()
            txtamt.Clear()
            txtcash.Clear()
            Exit Sub
        End If
        If Val(txttotal.Text) > Val(txtfamt.Text) Then
            txtfbal.Text = 0
        Else
            If Val(txtfbal.Text) <> 0 Then
                txtfbal.Text = Val(txtbal.Text) - Val(txttotal.Text)
            End If
        End If
    End Sub

    Private Sub txtfamt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfamt.TextChanged
        If Val(txttotal.Text) > Val(txtfamt.Text) Then
            txtfbal.Text = 0
        Else
            txtfbal.Text = Val(txtbal.Text) - Val(txttotal.Text)
        End If
    End Sub
    Public Sub clr()
        cmbid.SelectedIndex = -1
        cmbproj.Clear()
        txtname.Text = ""
        txtcontact.Text = ""
        cmbflat.Clear()
        'txtarea.Text = ""
        txtfamt.Text = ""
        cmbpay.SelectedIndex = -1
        txtcheque.Text = ""
        txtbank.Text = ""
        txtamt.Text = ""
        txtcash.Text = ""
        txttotal.Text = ""
        txtfbal.Text = ""
        txtbal.Text = ""
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clr()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class