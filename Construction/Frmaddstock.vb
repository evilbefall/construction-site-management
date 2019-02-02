Imports System.Data.SqlClient
Public Class Frmaddstock

    Private Sub Frmaddstock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        laod_mat()
    End Sub
    Public Sub laod_mat()
        open_db()
        qry = "SELECT     dbo.Tbl_Material.Material "
        qry = qry + "FROM         dbo.Tbl_Material INNER JOIN "
        qry = qry + "              dbo.tbl_rawstock ON dbo.Tbl_Material.M_ID = dbo.tbl_rawstock.m_id"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        cmbmat.Items.Clear()
        While dr.Read = True
            cmbmat.Items.Add(dr(0))
        End While
        close_db()
    End Sub

    Private Sub cmbmat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmat.SelectedIndexChanged
        If cmbmat.SelectedIndex > -1 Then
            open_db()
            qry = "SELECT     dbo.tbl_rawstock.quantity,dbo.tbl_rawstock.m_id "
            qry = qry + "FROM         dbo.Tbl_Material INNER JOIN "
            qry = qry + "         dbo.tbl_rawstock ON dbo.Tbl_Material.M_ID = dbo.tbl_rawstock.m_id where dbo.Tbl_Material.material='" & cmbmat.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtqty.Text = dr(0)
                txtid.Text = dr(1)
            End If
            close_db()
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If cmbmat.Text = "" Then
            MsgBox("Please Enter The Material Name", MsgBoxStyle.Critical, "Critical")
            cmbmat.Focus()
        ElseIf txtadd.Text = "" Then
            MsgBox("Please Enter The Quantity To Add", MsgBoxStyle.Critical, "Critical")
            txtadd.Focus()
        Else
            open_db()
            qry = "update tbl_rawstock set quantity=quantity+'" & txtadd.Text & "' where m_id='" & txtid.Text & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Updated Successfully", MsgBoxStyle.Information, "Information")
            close_db()
            clr()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmRawStock.Show()
    End Sub
    Public Sub clr()
        cmbmat.SelectedIndex = -1
        txtqty.Clear()
        txtadd.Clear()
    End Sub
    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        clr()
    End Sub

    Private Sub txtadd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtadd.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class