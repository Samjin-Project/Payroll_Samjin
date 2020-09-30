<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterVacation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_reqdate = New System.Windows.Forms.DateTimePicker()
        Me.dt_anddate = New System.Windows.Forms.DateTimePicker()
        Me.dt_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadioButtonAprN = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAprY = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxTelp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_reason = New System.Windows.Forms.RichTextBox()
        Me.tb_time = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.tb_holtype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_emp = New System.Windows.Forms.TextBox()
        Me.kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Admision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_rehire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 510)
        Me.Panel1.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 485)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(435, 25)
        Me.Panel5.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(89, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Count"
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Total"
        '
        'DGV_DataModify
        '
        Me.DGV_DataModify.AllowUserToAddRows = False
        Me.DGV_DataModify.AllowUserToDeleteRows = False
        Me.DGV_DataModify.AllowUserToResizeColumns = False
        Me.DGV_DataModify.AllowUserToResizeRows = False
        Me.DGV_DataModify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_DataModify.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_DataModify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_DataModify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_emp, Me.Kolom_Nama, Me.Kolom_Admision, Me.kolom_rehire})
        Me.DGV_DataModify.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_DataModify.Location = New System.Drawing.Point(3, 57)
        Me.DGV_DataModify.MultiSelect = False
        Me.DGV_DataModify.Name = "DGV_DataModify"
        Me.DGV_DataModify.ReadOnly = True
        Me.DGV_DataModify.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_DataModify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DataModify.Size = New System.Drawing.Size(540, 442)
        Me.DGV_DataModify.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.dt_end)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.dt_start)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(925, 57)
        Me.Panel2.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(556, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Register Vacation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(352, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Emp No."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(414, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(414, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(332, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Departement"
        '
        'dt_end
        '
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_end.Location = New System.Drawing.Point(205, 33)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(106, 20)
        Me.dt_end.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "~"
        '
        'dt_start
        '
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_start.Location = New System.Drawing.Point(79, 33)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(106, 20)
        Me.dt_start.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Period"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "PT. SAMJIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Workcenter"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.dt_reqdate)
        Me.Panel4.Controls.Add(Me.dt_anddate)
        Me.Panel4.Controls.Add(Me.dt_startdate)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.TextBoxTelp)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.tb_reason)
        Me.Panel4.Controls.Add(Me.tb_time)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tb_nama)
        Me.Panel4.Controls.Add(Me.tb_holtype)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.tb_emp)
        Me.Panel4.Location = New System.Drawing.Point(525, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(388, 467)
        Me.Panel4.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(304, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "time"
        '
        'dt_reqdate
        '
        Me.dt_reqdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_reqdate.Location = New System.Drawing.Point(125, 180)
        Me.dt_reqdate.Name = "dt_reqdate"
        Me.dt_reqdate.Size = New System.Drawing.Size(110, 20)
        Me.dt_reqdate.TabIndex = 45
        '
        'dt_anddate
        '
        Me.dt_anddate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_anddate.Location = New System.Drawing.Point(125, 144)
        Me.dt_anddate.Name = "dt_anddate"
        Me.dt_anddate.Size = New System.Drawing.Size(110, 20)
        Me.dt_anddate.TabIndex = 44
        '
        'dt_startdate
        '
        Me.dt_startdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_startdate.Location = New System.Drawing.Point(125, 109)
        Me.dt_startdate.Name = "dt_startdate"
        Me.dt_startdate.Size = New System.Drawing.Size(110, 20)
        Me.dt_startdate.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Aproval"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RadioButtonAprN)
        Me.Panel6.Controls.Add(Me.RadioButtonAprY)
        Me.Panel6.Location = New System.Drawing.Point(125, 372)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(93, 21)
        Me.Panel6.TabIndex = 41
        '
        'RadioButtonAprN
        '
        Me.RadioButtonAprN.AutoSize = True
        Me.RadioButtonAprN.Location = New System.Drawing.Point(50, 2)
        Me.RadioButtonAprN.Name = "RadioButtonAprN"
        Me.RadioButtonAprN.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonAprN.TabIndex = 39
        Me.RadioButtonAprN.TabStop = True
        Me.RadioButtonAprN.Text = "No"
        Me.RadioButtonAprN.UseVisualStyleBackColor = True
        '
        'RadioButtonAprY
        '
        Me.RadioButtonAprY.AutoSize = True
        Me.RadioButtonAprY.Location = New System.Drawing.Point(4, 2)
        Me.RadioButtonAprY.Name = "RadioButtonAprY"
        Me.RadioButtonAprY.Size = New System.Drawing.Size(43, 17)
        Me.RadioButtonAprY.TabIndex = 38
        Me.RadioButtonAprY.TabStop = True
        Me.RadioButtonAprY.Text = "Yes"
        Me.RadioButtonAprY.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tel No."
        '
        'TextBoxTelp
        '
        Me.TextBoxTelp.BackColor = System.Drawing.Color.Aqua
        Me.TextBoxTelp.Location = New System.Drawing.Point(125, 339)
        Me.TextBoxTelp.Name = "TextBoxTelp"
        Me.TextBoxTelp.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxTelp.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Reasons"
        '
        'tb_reason
        '
        Me.tb_reason.Location = New System.Drawing.Point(125, 221)
        Me.tb_reason.Name = "tb_reason"
        Me.tb_reason.Size = New System.Drawing.Size(226, 104)
        Me.tb_reason.TabIndex = 31
        Me.tb_reason.Text = ""
        '
        'tb_time
        '
        Me.tb_time.BackColor = System.Drawing.Color.Aqua
        Me.tb_time.Location = New System.Drawing.Point(241, 73)
        Me.tb_time.Name = "tb_time"
        Me.tb_time.Size = New System.Drawing.Size(57, 20)
        Me.tb_time.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Start Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Request Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Holiday Type"
        '
        'tb_nama
        '
        Me.tb_nama.BackColor = System.Drawing.Color.Aqua
        Me.tb_nama.Location = New System.Drawing.Point(241, 36)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(110, 20)
        Me.tb_nama.TabIndex = 4
        '
        'tb_holtype
        '
        Me.tb_holtype.BackColor = System.Drawing.Color.Aqua
        Me.tb_holtype.Location = New System.Drawing.Point(125, 73)
        Me.tb_holtype.Name = "tb_holtype"
        Me.tb_holtype.Size = New System.Drawing.Size(110, 20)
        Me.tb_holtype.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'tb_emp
        '
        Me.tb_emp.BackColor = System.Drawing.Color.Aqua
        Me.tb_emp.Location = New System.Drawing.Point(125, 36)
        Me.tb_emp.Name = "tb_emp"
        Me.tb_emp.Size = New System.Drawing.Size(110, 20)
        Me.tb_emp.TabIndex = 0
        '
        'kolom_emp
        '
        Me.kolom_emp.FillWeight = 72.07229!
        Me.kolom_emp.HeaderText = "Emp No."
        Me.kolom_emp.Name = "kolom_emp"
        Me.kolom_emp.ReadOnly = True
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.FillWeight = 207.1237!
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        '
        'Kolom_Admision
        '
        Me.Kolom_Admision.FillWeight = 50.87394!
        Me.Kolom_Admision.HeaderText = "Admision Date"
        Me.Kolom_Admision.Name = "Kolom_Admision"
        Me.Kolom_Admision.ReadOnly = True
        '
        'kolom_rehire
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolom_rehire.DefaultCellStyle = DataGridViewCellStyle1
        Me.kolom_rehire.FillWeight = 69.93007!
        Me.kolom_rehire.HeaderText = "Re-hire Date"
        Me.kolom_rehire.Name = "kolom_rehire"
        Me.kolom_rehire.ReadOnly = True
        '
        'RegisterVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 567)
        Me.Controls.Add(Me.DGV_DataModify)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "RegisterVacation"
        Me.Text = "Register Vacation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGV_DataModify As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxTelp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_reason As RichTextBox
    Friend WithEvents tb_time As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents tb_holtype As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_emp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButtonAprN As RadioButton
    Friend WithEvents RadioButtonAprY As RadioButton
    Friend WithEvents dt_reqdate As DateTimePicker
    Friend WithEvents dt_anddate As DateTimePicker
    Friend WithEvents dt_startdate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dt_end As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_start As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Admision As DataGridViewTextBoxColumn
    Friend WithEvents kolom_rehire As DataGridViewTextBoxColumn
End Class
