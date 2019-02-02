Imports System.Data.SqlClient
Public Class FrmRawStock
    Private WithEvents TextBox As New DataGridViewTextBoxEditingControl
    Public tb As TextBox
    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Public Sub viewstock()
        open_db()
        dgvStock.Rows.Clear()
        qry = "SELECT     dbo.Tbl_Material.Material, dbo.tbl_rawstock.quantity, dbo.tbl_rawstock.m_id "
        qry = qry + "FROM         dbo.Tbl_Material INNER JOIN "
        qry = qry + "            dbo.tbl_rawstock ON dbo.Tbl_Material.M_ID = dbo.tbl_rawstock.m_id"
        cmd = New SqlCommand(qry, cnn)
        dr = cmd.ExecuteReader
        i = 0
        While dr.Read = True
            dgvStock.Rows.Add()
            dgvStock.Item(0, i).Value = dr(0)
            dgvStock.Item(1, i).Value = dr(1)
            dgvStock.Item(2, i).Value = dr(2)
            i = i + 1
        End While
        close_db()
    End Sub

    Private Sub FrmRawStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        viewstock()
    End Sub

    Private Sub dgvStock_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvStock.CellClick
        If e.ColumnIndex = 4 Then
            If dgvStock.CurrentRow.Cells(3).Value = "" Then
                MsgBox("Please Enter The Stock Used", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            If Val(dgvStock.CurrentRow.Cells(3).Value) > Val(dgvStock.CurrentRow.Cells(1).Value) Then
                MsgBox("Insufficient Stock", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            open_db()
            qry = "update tbl_rawstock set quantity=quantity-'" & dgvStock.CurrentRow.Cells(3).Value & "' where m_id='" & dgvStock.CurrentRow.Cells(2).Value & "'"
            cmd = New SqlCommand(qry, cnn)
            cmd.ExecuteNonQuery()
            MsgBox("Stock Updated", MsgBoxStyle.Information, "Information")
            dgvStock.CurrentRow.Cells(3).Value = ""
            viewstock()
            close_db()

        End If
    End Sub

    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub dgvStock_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvStock.EditingControlShowing
        Try

            If Me.dgvStock.CurrentCell.ColumnIndex = 3 And Not e.Control Is Nothing Then
                tb = (CType(e.Control, TextBox))
                'col = Me.dgvmark.CurrentCell.ColumnIndex

                AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            Else
                RemoveHandler tb.KeyPress, AddressOf TextBox_KeyPress
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class