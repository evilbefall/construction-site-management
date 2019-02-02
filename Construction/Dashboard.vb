Imports System.Data.SqlClient
Public Class Dashboard

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        FrmMaterial.Show()
    End Sub

    Private Sub AgrementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm_agrement.Show()
    End Sub

    Private Sub ProjectDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProjectDetailsToolStripMenuItem.Click
        frm_newProject.Show()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookingToolStripMenuItem.Click

    End Sub

    Private Sub EnquiryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnquiryToolStripMenuItem.Click
        frm_enquiry.Show()
    End Sub

    Private Sub AdvancePaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AdvancePaymentToolStripMenuItem.Click
        FrmAdvancePay.Show()
    End Sub

    Private Sub EnquiryReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnquiryReportsToolStripMenuItem.Click
        frmsearchenquiry.Show()
    End Sub

    Private Sub TaxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TaxToolStripMenuItem.Click
        frmtax.Show()
    End Sub

    Private Sub CompanyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CompanyToolStripMenuItem.Click
        frm_company.Show()
    End Sub

    Private Sub EmployeeDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeDetailsToolStripMenuItem.Click
        frm_employee.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frm_changepass.Show()
    End Sub

    Private Sub CustomerPaymentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerPaymentToolStripMenuItem.Click
        frm_custpay.Show()
    End Sub

    Private Sub PaymentReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PaymentReportsToolStripMenuItem.Click
        frm_view_custpay.Show()
    End Sub

    Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'MenuStrip1.Enabled = False
        'FrmLogin.ShowDialog()
        'If u_type = "User" Then
        '    PaymentReportsToolStripMenuItem.Visible = False
        '    UserCreationToolStripMenuItem.Visible = False
        '    AdvancePaymentReportsToolStripMenuItem.Visible = False
        'ElseIf u_type = "Admin" Then
        '    PaymentReportsToolStripMenuItem.Visible = True
        '    UserCreationToolStripMenuItem.Visible = True
        '    AdvancePaymentReportsToolStripMenuItem.Visible = True
        'End If
    End Sub

    Private Sub UserCreationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserCreationToolStripMenuItem.Click
        FrmRegister.Show()
    End Sub

    Private Sub FlatToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatToolStripMenuItem1.Click
        frm_flat.Show()
    End Sub

    Private Sub ViewProjectDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewProjectDetailsToolStripMenuItem.Click
        FrmViewProject.Show()
    End Sub

    Private Sub BackUpDatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BackUpDatabaseToolStripMenuItem.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        ' Then use the following code to create the Dialog window
        ' Change the .SelectedPath property to the default location
        With FolderBrowserDialog1
            ' Desktop is the root folder in the dialog.
            .RootFolder = Environment.SpecialFolder.Desktop
            ' Select the C:\Windows directory on entry.
            .SelectedPath = "d:\"
            ' Prompt the user with a custom message.
            .Description = "Select the source directory"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                ' Display the selected folder if the user clicked on the OK button.
                'MessageBox.Show(.SelectedPath)
                Dim bk = .SelectedPath & "\Construction_Philo.bak"
                Try

                    open_db()
                    qry = "BACKUP DATABASE Construction_Philo TO DISK ='" & bk & "'"
                    cmd = New SqlCommand(qry, cnn)
                    cmd.ExecuteNonQuery()
                    close_db()

                    MsgBox("DataBase BackUp Successfully Done", MsgBoxStyle.Information)


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        FrmLogin.Show()
        btnlogin.Visible = False
    End Sub

    Private Sub ViewStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewStockToolStripMenuItem.Click
        FrmRawStock.Show()
    End Sub

    Private Sub AddStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStockToolStripMenuItem.Click
        Frmaddstock.Show()
    End Sub

    Private Sub AdvancePaymentReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdvancePaymentReportsToolStripMenuItem.Click
        frm_view_advncepay.Show()
    End Sub

    Private Sub BookingDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookingDetailsToolStripMenuItem.Click
        frm_booking.Show()
    End Sub

    Private Sub ViewBookingDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewBookingDetailsToolStripMenuItem.Click
        FrmViewBooking.Show()
    End Sub

    Private Sub MasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub
End Class