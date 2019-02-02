<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBookingDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancePaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnquiryReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancePaymentReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserCreationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(100, 100)
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.NewProjectToolStripMenuItem, Me.EnquiryToolStripMenuItem, Me.BookingToolStripMenuItem, Me.PaymentToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ConfigurationToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1362, 133)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialToolStripMenuItem, Me.AddStockToolStripMenuItem, Me.ViewStockToolStripMenuItem})
        Me.MasterToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.master
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.MasterToolStripMenuItem.Text = "Master"
        Me.MasterToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'ViewStockToolStripMenuItem
        '
        Me.ViewStockToolStripMenuItem.Name = "ViewStockToolStripMenuItem"
        Me.ViewStockToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.ViewStockToolStripMenuItem.Text = "View Stock"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectDetailsToolStripMenuItem, Me.FlatToolStripMenuItem1, Me.ViewProjectDetailsToolStripMenuItem})
        Me.NewProjectToolStripMenuItem.Image = Global.Construction.My.Resources.Resources._new
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(132, 129)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        Me.NewProjectToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NewProjectToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProjectDetailsToolStripMenuItem
        '
        Me.ProjectDetailsToolStripMenuItem.Name = "ProjectDetailsToolStripMenuItem"
        Me.ProjectDetailsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.ProjectDetailsToolStripMenuItem.Text = "Project Details"
        '
        'FlatToolStripMenuItem1
        '
        Me.FlatToolStripMenuItem1.Name = "FlatToolStripMenuItem1"
        Me.FlatToolStripMenuItem1.Size = New System.Drawing.Size(259, 30)
        Me.FlatToolStripMenuItem1.Text = "Flat"
        '
        'ViewProjectDetailsToolStripMenuItem
        '
        Me.ViewProjectDetailsToolStripMenuItem.Name = "ViewProjectDetailsToolStripMenuItem"
        Me.ViewProjectDetailsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.ViewProjectDetailsToolStripMenuItem.Text = "View Project Details"
        '
        'EnquiryToolStripMenuItem
        '
        Me.EnquiryToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.eq
        Me.EnquiryToolStripMenuItem.Name = "EnquiryToolStripMenuItem"
        Me.EnquiryToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.EnquiryToolStripMenuItem.Text = "Enquiry"
        Me.EnquiryToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookingDetailsToolStripMenuItem, Me.ViewBookingDetailsToolStripMenuItem})
        Me.BookingToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.book
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.BookingToolStripMenuItem.Text = "Booking"
        Me.BookingToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BookingDetailsToolStripMenuItem
        '
        Me.BookingDetailsToolStripMenuItem.Name = "BookingDetailsToolStripMenuItem"
        Me.BookingDetailsToolStripMenuItem.Size = New System.Drawing.Size(272, 30)
        Me.BookingDetailsToolStripMenuItem.Text = "Booking Details"
        '
        'ViewBookingDetailsToolStripMenuItem
        '
        Me.ViewBookingDetailsToolStripMenuItem.Name = "ViewBookingDetailsToolStripMenuItem"
        Me.ViewBookingDetailsToolStripMenuItem.Size = New System.Drawing.Size(272, 30)
        Me.ViewBookingDetailsToolStripMenuItem.Text = "View Booking Details"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdvancePaymentToolStripMenuItem, Me.CustomerPaymentToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.payment
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        Me.PaymentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AdvancePaymentToolStripMenuItem
        '
        Me.AdvancePaymentToolStripMenuItem.Name = "AdvancePaymentToolStripMenuItem"
        Me.AdvancePaymentToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.AdvancePaymentToolStripMenuItem.Text = "Advance Payment"
        '
        'CustomerPaymentToolStripMenuItem
        '
        Me.CustomerPaymentToolStripMenuItem.Name = "CustomerPaymentToolStripMenuItem"
        Me.CustomerPaymentToolStripMenuItem.Size = New System.Drawing.Size(253, 30)
        Me.CustomerPaymentToolStripMenuItem.Text = "Customer Payment"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeDetailsToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.employee
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        Me.EmployeeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(232, 30)
        Me.EmployeeDetailsToolStripMenuItem.Text = "employee details"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnquiryReportsToolStripMenuItem, Me.PaymentReportsToolStripMenuItem, Me.AdvancePaymentReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.Task_Report_Hot
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EnquiryReportsToolStripMenuItem
        '
        Me.EnquiryReportsToolStripMenuItem.Name = "EnquiryReportsToolStripMenuItem"
        Me.EnquiryReportsToolStripMenuItem.Size = New System.Drawing.Size(317, 30)
        Me.EnquiryReportsToolStripMenuItem.Text = "Enquiry Reports"
        '
        'PaymentReportsToolStripMenuItem
        '
        Me.PaymentReportsToolStripMenuItem.Name = "PaymentReportsToolStripMenuItem"
        Me.PaymentReportsToolStripMenuItem.Size = New System.Drawing.Size(317, 30)
        Me.PaymentReportsToolStripMenuItem.Text = "Payment Reports"
        '
        'AdvancePaymentReportsToolStripMenuItem
        '
        Me.AdvancePaymentReportsToolStripMenuItem.Name = "AdvancePaymentReportsToolStripMenuItem"
        Me.AdvancePaymentReportsToolStripMenuItem.Size = New System.Drawing.Size(317, 30)
        Me.AdvancePaymentReportsToolStripMenuItem.Text = "Advance Payment Reports"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserCreationToolStripMenuItem, Me.TaxToolStripMenuItem, Me.CompanyToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.BackUpDatabaseToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.Setting_icon
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(150, 129)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        Me.ConfigurationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ConfigurationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UserCreationToolStripMenuItem
        '
        Me.UserCreationToolStripMenuItem.Name = "UserCreationToolStripMenuItem"
        Me.UserCreationToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.UserCreationToolStripMenuItem.Text = "User Creation"
        '
        'TaxToolStripMenuItem
        '
        Me.TaxToolStripMenuItem.Name = "TaxToolStripMenuItem"
        Me.TaxToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.TaxToolStripMenuItem.Text = "Tax"
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'BackUpDatabaseToolStripMenuItem
        '
        Me.BackUpDatabaseToolStripMenuItem.Name = "BackUpDatabaseToolStripMenuItem"
        Me.BackUpDatabaseToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.BackUpDatabaseToolStripMenuItem.Text = "Back Up Database"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Construction.My.Resources.Resources.shut_down
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 129)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(12, 147)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(105, 48)
        Me.btnlogin.TabIndex = 1
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        Me.btnlogin.Visible = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Construction.My.Resources.Resources.main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 423)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancePaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerPaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnquiryReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserCreationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewProjectDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents ViewStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancePaymentReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewBookingDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
