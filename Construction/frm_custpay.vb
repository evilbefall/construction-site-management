Imports System.Data.SqlClient
Public Class frm_custpay

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If txtbno.Text = "" Or cmbcid.Text = "" Or cmbname.Text = "" Or cmbfno.Text = "" Or txtarea.Text = "" Or txttotamt.Text = "" Or txtrec.Text = "" Or txtpend.Text = "" Or txtvat.Text = "" Or txttax.Text = "" Or txtamtpaid.Text = "" Then
            MsgBox("Please Enter All The Details", MsgBoxStyle.Critical)
            Exit Sub
        End If
        open_db()
        qry = "insert into tbl_custpay (b_no,recieved,pending,vat,amt_paid,c_id,bal) values('" & txtbno.Text & "','" & txtrec.Text & "','" & txtpend.Text & "','" & txtvat.Text & "','" & txtamtpaid.Text & "','" & cmbcid.Text & "','" & txtbal.Text & "')"
        cmd = New SqlCommand(qry, cnn)
        cmd.ExecuteNonQuery()
        close_db()

        open_db()
        qry = "update tbl_gtot set g_tot=g_tot+'" & txtamtpaid.Text & "' where id='" & cmbcid.Text & "'"
        cmd = New SqlCommand(qry, cnn)
        cmd.ExecuteNonQuery()
        MsgBox("Inserted Successfully", MsgBoxStyle.Information)
        close_db()
        btnsave.Enabled = False
        btnprint.Enabled = True

    End Sub
    Public Sub clr()
        cmbcid.SelectedIndex = -1
        cmbname.Clear()
        cmbfno.Clear()
        txtarea.Clear()
        txttotamt.Clear()
        txtrec.Clear()
        txtpend.Clear()
        'cmbagrname.SelectedIndex = -1
        txtvat.Clear()
        txtamtpaid.Clear()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        clr()
    End Sub
    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(b_no,3,len(b_no))+1 as int)) from tbl_custpay"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txtbno.Text = "BL1"
            Else
                txtbno.Text = "BL" & dr(0)
            End If
        End If
        close_db()
    End Sub
    Public Sub load_bid()

        open_db()
        qry = "select id from tbl_booking"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbcid.Items.Clear()
        While dr.Read = True
            cmbcid.Items.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub frm_custpay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_id()
        load_bid()
        'load_agr()
        load_tax()
      
        btnprint.Enabled = False
    End Sub

    Private Sub cmbcid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbcid.SelectedIndexChanged
        If cmbcid.SelectedIndex > -1 Then
            open_db()
            qry = "SELECT     dbo.tbl_enquiry.E_name, dbo.Tbl_flat.f_no, dbo.Tbl_flat.Area, dbo.tbl_booking.grand_tot, dbo.tbl_gtot.g_tot "
            qry = qry + "FROM         dbo.Tbl_NewProject INNER JOIN "
            qry = qry + "dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id INNER JOIN "
            qry = qry + "dbo.tbl_booking INNER JOIN "
            qry = qry + "dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
            qry = qry + "dbo.tbl_gtot ON dbo.tbl_booking.id = dbo.tbl_gtot.id ON dbo.Tbl_NewProject.P_id = dbo.tbl_enquiry.P_id AND dbo.Tbl_flat.f_no = dbo.tbl_booking.f_no where dbo.tbl_booking.id='" & cmbcid.Text & "'"

            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                cmbname.Text = dr(0)
                cmbfno.Text = dr(1)
                txtarea.Text = dr(2)
                txttotamt.Text = dr(3)
                txtrec.Text = dr(4)
            End If
            close_db()
        End If
       
    End Sub

    Private Sub txtrec_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrec.TextChanged
        txtpend.Text = Val(txttotamt.Text) - Val(txtrec.Text)
    End Sub

    Private Sub txttotamt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttotamt.TextChanged
        txtpend.Text = Val(txttotamt.Text) - Val(txtrec.Text)
    End Sub

    Public Sub load_tax()

        open_db()
        qry = "select tax from tbl_tax"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txttax.Text = dr(0)
        End If
        close_db()
    End Sub

    Private Sub txtamtpaid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtamtpaid.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtamtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtamtpaid.TextChanged
        If Val(txtamtpaid.Text) > Val(txtpend.Text) Then
            MsgBox("Invalid Amount", MsgBoxStyle.Exclamation)
            txtamtpaid.Clear()
        Else
            txtbal.Text = Val(txtpend.Text) - Val(txtamtpaid.Text)
        End If

    End Sub

    Private Sub btnprint_Click(sender As System.Object, e As System.EventArgs) Handles btnprint.Click
        dbconf()
        Dim rpt As New Cryst_Pay
        rpt.DataSourceConnections.Item(0).SetConnection(sqlconn, sqldb, sqluser, sqlpass)
        rpt.DataSourceConnections.Item(0).SetLogon(sqluser, sqlpass)
        rpt.SetParameterValue("bno", txtbno.Text)

        Frm_Cryst_Pay.Text = "RECEIPT"
        Frm_Cryst_Pay.CrystalReportViewer1.ReportSource = rpt
        Frm_Cryst_Pay.CrystalReportViewer1.Refresh()
        Frm_Cryst_Pay.ShowDialog()

        clr()
        load_bid()
        load_id()
        load_tax()
        'load_agr()
        btnsave.Enabled = True
        btnprint.Enabled = False
    End Sub

    Private Sub txtvat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvat.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpend_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpend.TextChanged
        If Val(txtpend.Text) = 0 Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True
        End If
    End Sub
End Class