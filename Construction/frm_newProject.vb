Imports System.Data.SqlClient
Public Class frm_newProject

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        clr()
        txtpname.Focus()
    End Sub
    Public Sub clr()
        txtpname.Clear()
        cmbloc.Text = ""
        cmbarea.Text = ""
        cmbcity.Text = ""
        txtpin.Clear()
        cmbstate.Text = ""
        cmbcountry.Text = ""
        txtowner.Clear()
        txtph.Clear()
        txtinfo.Clear()
        dtpstart.Value = Today.Date
        dtpend.MinDate = dtpstart.Value.AddYears(1)
        cmbfloars.Text = ""
        cmbflats.Text = ""
    End Sub

    Private Sub btnsave_Click(sender As System.Object, e As System.EventArgs) Handles btnsave.Click
        If txtpname.Text = "" Then
            MsgBox("Please Enter The Project Name", MsgBoxStyle.Critical, "Critical")
            txtpname.Focus()
        ElseIf cmbloc.Text = "" Then
            MsgBox("Please Enter The Location", MsgBoxStyle.Critical, "Critical")
            cmbloc.Focus()
        ElseIf cmbarea.Text = "" Then
            MsgBox("Please Enter The Area", MsgBoxStyle.Critical, "Critical")
            cmbarea.Focus()
        ElseIf cmbcity.Text = "" Then
            MsgBox("Please Enter The City", MsgBoxStyle.Critical, "Critical")
            cmbcity.Focus()
        ElseIf txtpin.Text = "" Then
            MsgBox("Please Enter The Pincode", MsgBoxStyle.Critical, "Critical")
            txtpin.Focus()
        ElseIf cmbstate.Text = "" Then
            MsgBox("Please Enter The State", MsgBoxStyle.Critical, "Critical")
            cmbstate.Focus()
        ElseIf cmbcountry.Text = "" Then
            MsgBox("Please Enter The Country", MsgBoxStyle.Critical, "Critical")
            cmbcountry.Focus()
        ElseIf txtowner.Text = "" Then
            MsgBox("Please Enter The Owner Name", MsgBoxStyle.Critical, "Critical")
            txtowner.Focus()
        ElseIf txtph.Text = "" Then
            MsgBox("Please Enter The Phone Number", MsgBoxStyle.Critical, "Critical")
            txtph.Focus()
        ElseIf txtinfo.Text = "" Then
            MsgBox("Please Enter The Legal Information", MsgBoxStyle.Critical, "Critical")
            txtinfo.Focus()
        ElseIf cmbfloars.Text = "" Then
            MsgBox("Please Enter The Number of Floors", MsgBoxStyle.Critical, "Critical")
            cmbfloars.Focus()
        ElseIf cmbflats.Text = "" Then
            MsgBox("Please Enter The Number of Flats", MsgBoxStyle.Critical, "Critical")
            cmbflats.Focus()
        ElseIf txtpin.TextLength < 6 Then
            MsgBox("Invalid Pin Code", MsgBoxStyle.Exclamation)
        ElseIf txtph.TextLength < 10 Then
            MsgBox("Invalid Phone Number", MsgBoxStyle.Exclamation)
        ElseIf btnsave.Text = "Save" Then
            open_db()
            qry = "insert into Tbl_NewProject(P_id,P_name,P_loc,Area,City,Pincode,State,Country,Owner,Ph_no,Legal_info,St_date,End_date,No_floars,No_flats) values('" & txtpid.Text & "','" & txtpname.Text & "','" & cmbloc.Text & "','" & cmbarea.Text & "','" & cmbcity.Text & "','" & txtpin.Text & "','" & cmbstate.Text & "','" & cmbcountry.Text & "','" & txtowner.Text & "','" & txtph.Text & "','" & txtinfo.Text & "',convert(date,'" & dtpstart.Value & "',103),convert(date,'" & dtpend.Value & "',103),'" & cmbfloars.Text & "','" & cmbflats.Text & "')"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Added Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            txtpname.Focus()
            load_id()
            load_loc()
            load_area()
            load_city()
            load_state()
            load_country()
            load_floars()
            load_flats()
        ElseIf btnsave.Text = "Update" Then
            open_db()
            qry = "update tbl_newproject set p_id='" & txtpid.Text & "',p_name='" & txtpname.Text & "',p_loc='" & cmbloc.Text & "',area='" & cmbarea.Text & "',city='" & cmbcity.Text & "',pincode='" & txtpin.Text & "',state='" & cmbstate.Text & "',country='" & cmbcountry.Text & "',owner='" & txtowner.Text & "',ph_no='" & txtph.Text & "',legal_info='" & txtinfo.Text & "',st_date=convert(date,'" & dtpstart.Value & "',103),end_date=convert(date,'" & dtpend.Value & "',103),no_floars='" & cmbfloars.Text & "',no_flats='" & cmbflats.Text & "' where p_id='" & prjid & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information)
            close_db()
            clr()
            txtpname.Focus()
            load_id()
            load_loc()
            load_area()
            load_city()
            load_state()
            load_country()
            load_floars()
            load_flats()
            FrmViewProject.viewdetails()

            btnsave.Text = "Save"
        End If
    End Sub

    Public Sub load_id()
        open_db()
        qry = "select max(cast(substring(p_id,2,len(p_id))+1 as int)) from tbl_NewProject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            If IsDBNull(dr(0)) = True Then
                txtpid.Text = "P1"
            Else
                txtpid.Text = "P" & dr(0)
            End If
        End If
        close_db()
    End Sub

    Private Sub frm_newProject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If editrec = True Then
            load_loc()
            load_area()
            load_city()
            load_state()
            load_country()
            load_floars()
            load_flats()
            open_db()
            qry = "select * from tbl_newproject where p_id='" & prjid & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtpid.Text = dr(0)
                txtpname.Text = dr(1)
                cmbloc.Text = dr(2)
                cmbarea.Text = dr(3)
                cmbcity.Text = dr(4)
                txtpin.Text = dr(5)
                cmbstate.Text = dr(6)
                cmbcountry.Text = dr(7)
                txtowner.Text = dr(8)
                txtph.Text = dr(9)
                txtinfo.Text = dr(10)
                dtpstart.Value = dr(11)
                dtpend.Value = dr(12)
                cmbfloars.Text = dr(13)
                cmbflats.Text = dr(14)
                editrec = False
                btnsave.Text = "Update"
            End If
        Else
            load_id()
            load_loc()
            load_area()
            load_city()
            load_state()
            load_country()
            load_floars()
            load_flats()
            dtpend.MinDate = dtpstart.Value.AddYears(1)
        End If
      
    End Sub

    Private Sub txtpname_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpname.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtpin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbloc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbloc.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub load_loc()
        open_db()
        qry = "select distinct(p_loc) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbloc.Items.Clear()
        While dr.Read = True
            cmbloc.Items.Add(dr(0))
            cmbloc.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_area()
        open_db()
        qry = "select distinct(area) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbarea.Items.Clear()
        While dr.Read = True
            cmbarea.Items.Add(dr(0))
            cmbarea.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_city()
        open_db()
        qry = "select distinct(city) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbcity.Items.Clear()
        While dr.Read = True
            cmbcity.Items.Add(dr(0))
            cmbcity.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_state()
        open_db()
        qry = "select distinct(state) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbstate.Items.Clear()
        While dr.Read = True
            cmbstate.Items.Add(dr(0))
            cmbstate.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_country()
        open_db()
        qry = "select distinct(country) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbcountry.Items.Clear()
        While dr.Read = True
            cmbcountry.Items.Add(dr(0))
            cmbcountry.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_floars()
        open_db()
        qry = "select distinct(no_floars) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbfloars.Items.Clear()
        While dr.Read = True
            cmbfloars.Items.Add(dr(0))
            cmbfloars.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub
    Public Sub load_flats()
        open_db()
        qry = "select distinct(no_flats) from tbl_newproject"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbflats.Items.Clear()
        While dr.Read = True
            cmbflats.Items.Add(dr(0))
            cmbflats.AutoCompleteCustomSource.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub cmbarea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbarea.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcity.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbstate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbstate.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbcountry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcountry.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtowner_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtowner.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtph.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbflats_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbfloars_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class