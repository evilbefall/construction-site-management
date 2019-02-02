<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_newProject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_newProject))
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpstart = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpend = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbfloars = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbflats = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbcity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbloc = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbstate = New System.Windows.Forms.ComboBox()
        Me.cmbarea = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbcountry = New System.Windows.Forms.ComboBox()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtowner = New System.Windows.Forms.TextBox()
        Me.txtph = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtinfo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(250, 466)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(98, 37)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnreset.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.Location = New System.Drawing.Point(368, 466)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(98, 37)
        Me.btnreset.TabIndex = 22
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(38, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(186, 33)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Project Details:"
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = Global.Construction.My.Resources.Resources.Presentation1
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(685, 385)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Project Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpstart)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.dtpend)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.cmbfloars)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.cmbflats)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(357, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(322, 171)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        '
        'dtpstart
        '
        Me.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpstart.Location = New System.Drawing.Point(149, 12)
        Me.dtpstart.Name = "dtpstart"
        Me.dtpstart.Size = New System.Drawing.Size(121, 20)
        Me.dtpstart.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 133)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 19)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Number of flats"
        '
        'dtpend
        '
        Me.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpend.Location = New System.Drawing.Point(149, 51)
        Me.dtpend.Name = "dtpend"
        Me.dtpend.Size = New System.Drawing.Size(121, 20)
        Me.dtpend.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(126, 19)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Number of floors"
        '
        'cmbfloars
        '
        Me.cmbfloars.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbfloars.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbfloars.FormattingEnabled = True
        Me.cmbfloars.Location = New System.Drawing.Point(149, 86)
        Me.cmbfloars.Name = "cmbfloars"
        Me.cmbfloars.Size = New System.Drawing.Size(121, 21)
        Me.cmbfloars.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 19)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "End Date"
        '
        'cmbflats
        '
        Me.cmbflats.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbflats.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbflats.FormattingEnabled = True
        Me.cmbflats.Location = New System.Drawing.Point(149, 133)
        Me.cmbflats.Name = "cmbflats"
        Me.cmbflats.Size = New System.Drawing.Size(121, 21)
        Me.cmbflats.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 14)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 19)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Start Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtpid)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbcity)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtpname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbloc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbstate)
        Me.GroupBox2.Controls.Add(Me.cmbarea)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbcountry)
        Me.GroupBox2.Controls.Add(Me.txtpin)
        Me.GroupBox2.Location = New System.Drawing.Point(16, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 375)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(149, 16)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.ReadOnly = True
        Me.txtpid.Size = New System.Drawing.Size(167, 20)
        Me.txtpid.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Project Location"
        '
        'cmbcity
        '
        Me.cmbcity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbcity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbcity.FormattingEnabled = True
        Me.cmbcity.Location = New System.Drawing.Point(149, 192)
        Me.cmbcity.Name = "cmbcity"
        Me.cmbcity.Size = New System.Drawing.Size(167, 21)
        Me.cmbcity.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Project Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Area"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(149, 57)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(167, 20)
        Me.txtpname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Project Id"
        '
        'cmbloc
        '
        Me.cmbloc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbloc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbloc.FormattingEnabled = True
        Me.cmbloc.Location = New System.Drawing.Point(149, 98)
        Me.cmbloc.Name = "cmbloc"
        Me.cmbloc.Size = New System.Drawing.Size(167, 21)
        Me.cmbloc.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "City"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 342)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Country"
        '
        'cmbstate
        '
        Me.cmbstate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbstate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbstate.FormattingEnabled = True
        Me.cmbstate.Location = New System.Drawing.Point(149, 288)
        Me.cmbstate.Name = "cmbstate"
        Me.cmbstate.Size = New System.Drawing.Size(167, 21)
        Me.cmbstate.TabIndex = 6
        '
        'cmbarea
        '
        Me.cmbarea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbarea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbarea.FormattingEnabled = True
        Me.cmbarea.Location = New System.Drawing.Point(149, 149)
        Me.cmbarea.Name = "cmbarea"
        Me.cmbarea.Size = New System.Drawing.Size(167, 21)
        Me.cmbarea.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Pincode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "State"
        '
        'cmbcountry
        '
        Me.cmbcountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbcountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbcountry.FormattingEnabled = True
        Me.cmbcountry.Location = New System.Drawing.Point(149, 339)
        Me.cmbcountry.Name = "cmbcountry"
        Me.cmbcountry.Size = New System.Drawing.Size(167, 21)
        Me.cmbcountry.TabIndex = 7
        '
        'txtpin
        '
        Me.txtpin.Location = New System.Drawing.Point(149, 246)
        Me.txtpin.MaxLength = 6
        Me.txtpin.Name = "txtpin"
        Me.txtpin.Size = New System.Drawing.Size(167, 20)
        Me.txtpin.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtowner)
        Me.GroupBox1.Controls.Add(Me.txtph)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtinfo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(357, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 202)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'txtowner
        '
        Me.txtowner.Location = New System.Drawing.Point(136, 20)
        Me.txtowner.Name = "txtowner"
        Me.txtowner.Size = New System.Drawing.Size(157, 20)
        Me.txtowner.TabIndex = 8
        '
        'txtph
        '
        Me.txtph.Location = New System.Drawing.Point(136, 68)
        Me.txtph.MaxLength = 11
        Me.txtph.Name = "txtph"
        Me.txtph.Size = New System.Drawing.Size(157, 20)
        Me.txtph.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 19)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Legal Information"
        '
        'txtinfo
        '
        Me.txtinfo.Location = New System.Drawing.Point(136, 114)
        Me.txtinfo.Multiline = True
        Me.txtinfo.Name = "txtinfo"
        Me.txtinfo.Size = New System.Drawing.Size(157, 65)
        Me.txtinfo.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Owner"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 19)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Phone Number"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(693, 411)
        Me.TabControl1.TabIndex = 20
        '
        'frm_newProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Construction.My.Resources.Resources.Presentation1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(735, 509)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_newProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Project"
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpend As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbfloars As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbflats As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbcity As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbloc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbstate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbarea As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbcountry As System.Windows.Forms.ComboBox
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtowner As System.Windows.Forms.TextBox
    Friend WithEvents txtph As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
