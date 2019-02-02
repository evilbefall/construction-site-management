Imports System.Data.SqlClient
Public Class frm_booking

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If cmbeid.Text = "" Then
            MsgBox("Please Enter The Enquiry Id", MsgBoxStyle.Critical, "Critical")
            cmbeid.Focus()
            Exit Sub
        ElseIf txtage.Text = "" Then
            MsgBox("Please Enter The Age", MsgBoxStyle.Critical, "Critical")
            txtage.Focus()
            Exit Sub
        ElseIf txtfhname.Text = "" Then
            MsgBox("Please Enter The Father/Husband Name", MsgBoxStyle.Critical, "Critical")
            txtfhname.Focus()
            Exit Sub
        ElseIf txtadrs.Text = "" Then
            MsgBox("Please Enter The Address", MsgBoxStyle.Critical, "Critical")
            txtadrs.Focus()
            Exit Sub
        ElseIf cmbpark.Text = "" Then
            MsgBox("Please Enter If Parking Is Yes/No", MsgBoxStyle.Critical, "Critical")
            cmbpark.Focus()
            Exit Sub
            
        ElseIf txtpan.Text = "" Then
            MsgBox("Please Enter The Pan Card Number", MsgBoxStyle.Critical, "Critical")
            txtpan.Focus()
            Exit Sub
        ElseIf cmbpname.Text = "" Then
            MsgBox("Please Enter The Project Name", MsgBoxStyle.Critical, "Critical")
            cmbpname.Focus()
            Exit Sub
        ElseIf cmbfno.Text = "" Then
            MsgBox("Please Enter The Flat Number", MsgBoxStyle.Critical, "Critical")
            cmbfno.Focus()
            Exit Sub
        ElseIf txtrate.Text = "" Then
            MsgBox("Please Enter The Rate", MsgBoxStyle.Critical, "Critical")
            txtrate.Focus()
            Exit Sub
        ElseIf cmbagr.Text = "" Then
            MsgBox("Please Enter The Terms & Condition Yes/No", MsgBoxStyle.Critical, "Critical")
            cmbagr.Focus()
            Exit Sub
        End If
        If cmbpark.Text = "Yes" Then
            If txtdep.Text = "" Then
                MsgBox("Please Enter All The Maintanance Deposite Amount", MsgBoxStyle.Critical)
                txtdep.Focus()
                Exit Sub
            End If
        End If
       
        If Val(txtage.Text) < 18 Then
            MsgBox("Invalid Age", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If btnsave.Text = "Save" Then
            If cmbagr.Text = "Yes" Then
                open_db()
                qry = "select f_no,p_id from tbl_booking where f_no='" & cmbfno.Text & "' and p_id='" & cmbpname.SelectedValue & "'"
                cmd = New SqlCommand(qry, cnn)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    MsgBox("Already Booked", MsgBoxStyle.Exclamation)
                    Exit Sub
                Else

                    open_db()
                    qry = "insert into tbl_booking(id,e_id,f_no,p_id,age,father,b_date,address,pan,passport,rate,total,car_park,c_dep,grand_tot,service_tax) values('" & txtbid.Text & "','" & cmbeid.Text & "','" & cmbfno.Text & "','" & cmbpname.SelectedValue & "','" & txtage.Text & "','" & txtfhname.Text & "',Convert(date,'" & dtpdate.Value & "',103),'" & txtadrs.Text & "','" & txtpan.Text & "','" & txtpass.Text & "','" & txtrate.Text & "','" & txttot.Text & "','" & cmbpark.Text & "','" & txtdep.Text & "','" & txtgrandtot.Text & "','" & txttax.Text & "')"
                    cmd = New SqlCommand(qry, cnn)
                    cmd.ExecuteNonQuery()
                    close_db()

                    open_db()
                    qry = "insert into tbl_gtot(id,g_tot)values('" & txtbid.Text & "','" & txtgrandtot.Text & "')"
                    cmd = New SqlCommand(qry, cnn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Saved Successfully", MsgBoxStyle.Information)
                    close_db()
                    clr()
                    load_id()
                End If
            ElseIf cmbagr.Text = "No" Then
                MsgBox("Booking Cancelled", MsgBoxStyle.Exclamation)
            End If
        End If

        If btnsave.Text = "Update" Then
            If cmbagr.Text = "Yes" Then
                open_db()
                qry = "update tbl_booking set e_id='" & cmbeid.Text & "',f_no='" & cmbfno.Text & "',p_id='" & cmbpname.SelectedValue & "',age='" & txtage.Text & "',father='" & txtfhname.Text & "',b_date=Convert(date,'" & dtpdate.Value & "',103),address='" & txtadrs.Text & "',pan='" & txtpan.Text & "',passport='" & txtpass.Text & "',rate='" & txtrate.Text & "',total='" & txttot.Text & "',car_park='" & cmbpark.Text & "',c_dep='" & txtdep.Text & "',grand_tot='" & txtgrandtot.Text & "',service_tax='" & txttax.Text & "' where id='" & txtbid.Text & "'"
                cmd = New SqlCommand(qry, cnn)
                cmd.ExecuteNonQuery()
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                close_db()
                clr()
                load_id()
                btnsave.Text = "Save"
            ElseIf cmbagr.Text = "No" Then
                MsgBox("Booking Cancelled", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Public Sub clr()
        cmbeid.SelectedIndex = -1
        txtname.Clear()
        cmbagr.SelectedIndex = -1
        txtage.Clear()
        txtfhname.Clear()
        txtadrs.Clear()
        txtmode.Clear()
        txtpan.Clear()
        txtpass.Clear()
        txtcont.Clear()
        txtmail.Clear()
        cmbpname.SelectedIndex = -1
        cmbfno.SelectedIndex = -1
        txtarea.Clear()
        txtrate.Clear()
        txttot.Clear()
        cmbpark.SelectedIndex = -1
        txtdep.Clear()
        txtgrandtot.Clear()
    End Sub
    Public Sub loadeid()
        open_db()
        qry = "select e_id from tbl_enquiry"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbeid.Items.Clear()
        While dr.Read = True
            cmbeid.Items.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub frm_booking_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If editrec = True Then
            loadtax()
            load_id()
            loadeid()
            loadpname()
            loadfno()
            open_db()
            qry = "SELECT     dbo.tbl_booking.e_id, dbo.tbl_booking.id, dbo.tbl_enquiry.E_name, dbo.tbl_booking.age, dbo.tbl_booking.father, dbo.tbl_booking.b_date, dbo.tbl_booking.Address, "
            qry = qry + "dbo.tbl_enquiry.Mode_Enq, dbo.tbl_booking.car_park, dbo.tbl_booking.c_dep, dbo.tbl_booking.service_tax, dbo.tbl_booking.pan, dbo.tbl_booking.passport,"
            qry = qry + "dbo.tbl_enquiry.phno, dbo.tbl_enquiry.Email, dbo.Tbl_NewProject.P_name, dbo.Tbl_flat.f_no, dbo.Tbl_flat.Area, dbo.tbl_booking.rate, dbo.tbl_booking.total,"
            qry = qry + "dbo.tbl_booking.grand_tot "
            qry = qry + "FROM         dbo.tbl_booking INNER JOIN "
            qry = qry + "     dbo.tbl_enquiry ON dbo.tbl_booking.e_id = dbo.tbl_enquiry.E_id INNER JOIN "
            qry = qry + "       dbo.Tbl_NewProject ON dbo.tbl_booking.p_id = dbo.Tbl_NewProject.P_id INNER JOIN "
            qry = qry + "       dbo.Tbl_flat ON dbo.Tbl_NewProject.P_id = dbo.Tbl_flat.p_id where id='" & bid & "'"
            cmd = New SqlCommand(qry, cnn)
            dr1 = cmd.ExecuteReader
            If dr1.Read = True Then
                cmbeid.Text = dr1(0)
                txtbid.Text = dr1(1)
                txtname.Text = dr1(2)
                txtage.Text = dr1(3)
                txtfhname.Text = dr1(4)
                dtpdate.Value = dr1(5)
                txtadrs.Text = dr1(6)
                txtmode.Text = dr1(7)
                cmbpark.Text = dr1(8)
                txtdep.Text = dr1(9)
                txttax.Text = dr1(10)
                txtpan.Text = dr1(11)
                txtpass.Text = dr1(12)
                txtcont.Text = dr1(13)
                txtmail.Text = dr1(14)
                cmbpname.Text = dr1(15)
                cmbfno.Text = dr1(16)
                txtarea.Text = dr1(17)
                txtrate.Text = dr1(18)
                txttot.Text = dr1(19)
                txtgrandtot.Text = dr1(20)
                cmbagr.Text = "Yes"
                editrec = False
                btnsave.Text = "Update"
            End If
            close_db()
        ElseIf editrec = False Then
            loadtax()
            load_id()
            loadeid()
            loadpname()
            loadfno()
        End If

    End Sub

    Private Sub cmbeid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbeid.SelectedIndexChanged
        If cmbeid.SelectedIndex > -1 Then
            open_db()
            qry = "select * from tbl_enquiry where e_id='" & cmbeid.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtname.Text = dr(1)
                txtmode.Text = dr(4)
                txtmail.Text = dr(3)
                txtcont.Text = dr(2)
            End If
            close_db()
        End If

    End Sub
    'Public Sub loadpid()
    '    open_db()
    '    qry = "select P_name,p_id from Tbl_NewProject"
    '    cmd = New SqlCommand(qry, cnn)
    '    dr = cmd.ExecuteReader
    '    cmbpname.Items.Clear()
    '    While dr.Read = True
    '        cmbpname.Items.Add(dr(0))
    '        prid = dr(1)
    '    End While
    '    close_db()
    'End Sub
    Public Sub loadpname()
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
        close_db()
    End Sub

    Public Sub loadfno()
        Try
            open_db()
            qry = "SELECT     dbo.Tbl_flat.f_no "
            qry = qry + "FROM         dbo.Tbl_flat INNER JOIN "
            qry = qry + "             dbo.Tbl_NewProject ON dbo.Tbl_flat.p_id = dbo.Tbl_NewProject.P_id where dbo.tbl_flat.p_id='" & cmbpname.SelectedValue & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            cmbfno.Items.Clear()
            While dr.Read = True
                cmbfno.Items.Add(dr(0))
            End While
            close_db()
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub cmbfno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbfno.SelectedIndexChanged
        If cmbfno.SelectedIndex > -1 Then
            open_db()
            qry = "select Area from tbl_flat where f_no='" & cmbfno.Text & "' and p_id='" & cmbpname.SelectedValue & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtarea.Text = dr(0)
            End If
            close_db()
        End If
    End Sub
    'Public Sub loadagrment()
    '    open_db()
    '    qry = "Select name_of_agrement from tbl_agrement"
    '    cmd = New SqlCommand(qry, cnn)
    '    dr = cmd.ExecuteReader
    '    cmbagr.Items.Clear()
    '    While dr.Read = True
    '        cmbagr.Items.Add(dr(0))
    '    End While
    '    close_db()

    'End Sub
    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(id,2,len(id))+1 as int)) from tbl_booking"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txtbid.Text = "B1"
            Else
                txtbid.Text = "B" & dr(0)
            End If
        End If
        close_db()
    End Sub

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
    End Sub
    Public Sub loadtax()
        open_db()
        qry = "Select tax from tbl_tax"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txttax.Text = dr(0)
        End If
        close_db()
    End Sub

    Private Sub txtarea_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtarea.TextChanged
        txttot.Text = Val(txtarea.Text) * Val(txtrate.Text)
    End Sub

    Private Sub txtrate_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtrate.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtrate_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtrate.TextChanged
        txttot.Text = Val(txtarea.Text) * Val(txtrate.Text)
    End Sub

    Private Sub txtdep_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtdep.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdep_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdep.TextChanged
        Dim val1 As Double
        val1 = Val(txttot.Text) + Val(txtdep.Text)
        txtgrandtot.Text = (val1 * Val(txttax.Text)) / 100
        
    End Sub

    Private Sub txttot_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttot.TextChanged
        Dim val1 As Double
        val1 = Val(txttot.Text) + Val(txtdep.Text)
        txtgrandtot.Text = (val1 * Val(txttax.Text)) / 100
    End Sub

    Private Sub txtage_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtage.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtfhname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtfhname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnpayment_Click(sender As System.Object, e As System.EventArgs) Handles btnpayment.Click
        FrmAdvancePay.Show()
    End Sub

    Private Sub cmbpark_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbpark.SelectedIndexChanged
        If cmbpark.Text = "Yes" Then
            Panel2.Enabled = True
        Else
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub cmbpname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbpname.SelectedIndexChanged
        loadfno()
    End Sub
End Class