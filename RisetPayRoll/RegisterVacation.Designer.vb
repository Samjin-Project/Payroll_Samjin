<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterVacation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Admision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reasons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total_data = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.b_showall = New System.Windows.Forms.Button()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fil_emp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tb_dep = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_reason = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cb_holtype = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b_save = New System.Windows.Forms.Button()
        Me.dt_reqdate = New System.Windows.Forms.DateTimePicker()
        Me.dt_anddate = New System.Windows.Forms.DateTimePicker()
        Me.dt_startdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_telp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_emp = New System.Windows.Forms.TextBox()
        Me.b_search = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGV_DataModify)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1031, 510)
        Me.Panel1.TabIndex = 19
        '
        'DGV_DataModify
        '
        Me.DGV_DataModify.AllowUserToAddRows = False
        Me.DGV_DataModify.AllowUserToDeleteRows = False
        Me.DGV_DataModify.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_DataModify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_DataModify.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_DataModify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_DataModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_DataModify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_emp, Me.Kolom_Nama, Me.Kolom_Admision, Me.kolom_department, Me.HolidayType, Me.Approval, Me.StartDate, Me.EndDate, Me.Reasons})
        Me.DGV_DataModify.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_DataModify.Location = New System.Drawing.Point(0, 0)
        Me.DGV_DataModify.MultiSelect = False
        Me.DGV_DataModify.Name = "DGV_DataModify"
        Me.DGV_DataModify.ReadOnly = True
        Me.DGV_DataModify.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_DataModify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_DataModify.Size = New System.Drawing.Size(1031, 485)
        Me.DGV_DataModify.TabIndex = 17
        '
        'kolom_emp
        '
        Me.kolom_emp.FillWeight = 120.0703!
        Me.kolom_emp.HeaderText = "Emp No."
        Me.kolom_emp.Name = "kolom_emp"
        Me.kolom_emp.ReadOnly = True
        Me.kolom_emp.Width = 73
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.FillWeight = 141.4268!
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        Me.Kolom_Nama.Width = 60
        '
        'Kolom_Admision
        '
        Me.Kolom_Admision.FillWeight = 91.17045!
        Me.Kolom_Admision.HeaderText = "Admision Date"
        Me.Kolom_Admision.Name = "Kolom_Admision"
        Me.Kolom_Admision.ReadOnly = True
        '
        'kolom_department
        '
        Me.kolom_department.FillWeight = 77.40235!
        Me.kolom_department.HeaderText = "Department"
        Me.kolom_department.Name = "kolom_department"
        Me.kolom_department.ReadOnly = True
        Me.kolom_department.Width = 87
        '
        'HolidayType
        '
        Me.HolidayType.HeaderText = "Holiday Type"
        Me.HolidayType.Name = "HolidayType"
        Me.HolidayType.ReadOnly = True
        Me.HolidayType.Width = 94
        '
        'Approval
        '
        Me.Approval.HeaderText = "Approval"
        Me.Approval.Name = "Approval"
        Me.Approval.ReadOnly = True
        Me.Approval.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Approval.Width = 74
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        Me.StartDate.Width = 80
        '
        'EndDate
        '
        Me.EndDate.HeaderText = "End Date"
        Me.EndDate.Name = "EndDate"
        Me.EndDate.ReadOnly = True
        Me.EndDate.Width = 77
        '
        'Reasons
        '
        Me.Reasons.HeaderText = "Reasons"
        Me.Reasons.Name = "Reasons"
        Me.Reasons.ReadOnly = True
        Me.Reasons.Width = 74
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.total_data)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 485)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1031, 25)
        Me.Panel5.TabIndex = 19
        '
        'total_data
        '
        Me.total_data.AutoSize = True
        Me.total_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.total_data.Location = New System.Drawing.Point(148, 6)
        Me.total_data.Name = "total_data"
        Me.total_data.Size = New System.Drawing.Size(0, 13)
        Me.total_data.TabIndex = 15
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.b_search)
        Me.Panel2.Controls.Add(Me.b_delete)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.b_showall)
        Me.Panel2.Controls.Add(Me.cb_dep)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.fil_emp)
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
        Me.Panel2.Size = New System.Drawing.Size(1370, 57)
        Me.Panel2.TabIndex = 20
        '
        'b_delete
        '
        Me.b_delete.Location = New System.Drawing.Point(555, 29)
        Me.b_delete.Name = "b_delete"
        Me.b_delete.Size = New System.Drawing.Size(63, 23)
        Me.b_delete.TabIndex = 14
        Me.b_delete.Text = "Delete"
        Me.b_delete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(635, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 22)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'b_showall
        '
        Me.b_showall.Location = New System.Drawing.Point(635, 3)
        Me.b_showall.Name = "b_showall"
        Me.b_showall.Size = New System.Drawing.Size(63, 22)
        Me.b_showall.TabIndex = 12
        Me.b_showall.Text = "Show All"
        Me.b_showall.UseVisualStyleBackColor = True
        '
        'cb_dep
        '
        Me.cb_dep.FormattingEnabled = True
        Me.cb_dep.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_dep.Location = New System.Drawing.Point(414, 4)
        Me.cb_dep.Name = "cb_dep"
        Me.cb_dep.Size = New System.Drawing.Size(125, 21)
        Me.cb_dep.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(1026, 29)
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
        'fil_emp
        '
        Me.fil_emp.Location = New System.Drawing.Point(414, 29)
        Me.fil_emp.Name = "fil_emp"
        Me.fil_emp.Size = New System.Drawing.Size(125, 20)
        Me.fil_emp.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(332, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Department"
        '
        'dt_end
        '
        Me.dt_end.CustomFormat = "dd/MM/yyyy"
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom
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
        Me.dt_start.CustomFormat = "dd/MM/yyyy"
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
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
        Me.TextBox1.ReadOnly = True
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
        Me.Panel4.Controls.Add(Me.tb_dep)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.tb_reason)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.cb_holtype)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.b_save)
        Me.Panel4.Controls.Add(Me.dt_reqdate)
        Me.Panel4.Controls.Add(Me.dt_anddate)
        Me.Panel4.Controls.Add(Me.dt_startdate)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.tb_telp)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tb_nama)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.tb_emp)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(1031, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(339, 510)
        Me.Panel4.TabIndex = 21
        '
        'tb_dep
        '
        Me.tb_dep.BackColor = System.Drawing.Color.Aqua
        Me.tb_dep.Location = New System.Drawing.Point(145, 119)
        Me.tb_dep.Name = "tb_dep"
        Me.tb_dep.ReadOnly = True
        Me.tb_dep.Size = New System.Drawing.Size(110, 20)
        Me.tb_dep.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(80, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Emp. No."
        '
        'tb_reason
        '
        Me.tb_reason.Location = New System.Drawing.Point(141, 336)
        Me.tb_reason.MaxLength = 150
        Me.tb_reason.Multiline = True
        Me.tb_reason.Name = "tb_reason"
        Me.tb_reason.Size = New System.Drawing.Size(149, 98)
        Me.tb_reason.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Reason"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(68, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Department"
        '
        'cb_holtype
        '
        Me.cb_holtype.BackColor = System.Drawing.Color.Cyan
        Me.cb_holtype.FormattingEnabled = True
        Me.cb_holtype.Items.AddRange(New Object() {"Permission", "Sick", "No permission"})
        Me.cb_holtype.Location = New System.Drawing.Point(144, 150)
        Me.cb_holtype.Name = "cb_holtype"
        Me.cb_holtype.Size = New System.Drawing.Size(109, 21)
        Me.cb_holtype.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 48
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(144, 460)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 47
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'dt_reqdate
        '
        Me.dt_reqdate.CustomFormat = "dd/MM/yyyy"
        Me.dt_reqdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_reqdate.Location = New System.Drawing.Point(143, 257)
        Me.dt_reqdate.Name = "dt_reqdate"
        Me.dt_reqdate.Size = New System.Drawing.Size(110, 20)
        Me.dt_reqdate.TabIndex = 45
        '
        'dt_anddate
        '
        Me.dt_anddate.CustomFormat = "dd/MM/yyyy"
        Me.dt_anddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_anddate.Location = New System.Drawing.Point(143, 221)
        Me.dt_anddate.Name = "dt_anddate"
        Me.dt_anddate.Size = New System.Drawing.Size(110, 20)
        Me.dt_anddate.TabIndex = 44
        '
        'dt_startdate
        '
        Me.dt_startdate.CustomFormat = "dd/MM/yyyy"
        Me.dt_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_startdate.Location = New System.Drawing.Point(143, 186)
        Me.dt_startdate.Name = "dt_startdate"
        Me.dt_startdate.Size = New System.Drawing.Size(110, 20)
        Me.dt_startdate.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tel No."
        '
        'tb_telp
        '
        Me.tb_telp.BackColor = System.Drawing.Color.Aqua
        Me.tb_telp.Location = New System.Drawing.Point(143, 295)
        Me.tb_telp.Name = "tb_telp"
        Me.tb_telp.Size = New System.Drawing.Size(110, 20)
        Me.tb_telp.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Start Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Request Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Holiday Type"
        '
        'tb_nama
        '
        Me.tb_nama.BackColor = System.Drawing.Color.Aqua
        Me.tb_nama.Location = New System.Drawing.Point(144, 93)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.ReadOnly = True
        Me.tb_nama.Size = New System.Drawing.Size(110, 20)
        Me.tb_nama.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'tb_emp
        '
        Me.tb_emp.BackColor = System.Drawing.Color.Aqua
        Me.tb_emp.Location = New System.Drawing.Point(145, 67)
        Me.tb_emp.Name = "tb_emp"
        Me.tb_emp.Size = New System.Drawing.Size(110, 20)
        Me.tb_emp.TabIndex = 0
        '
        'b_search
        '
        Me.b_search.Location = New System.Drawing.Point(555, 3)
        Me.b_search.Name = "b_search"
        Me.b_search.Size = New System.Drawing.Size(63, 22)
        Me.b_search.TabIndex = 15
        Me.b_search.Text = "Search"
        Me.b_search.UseVisualStyleBackColor = True
        '
        'RegisterVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 567)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "RegisterVacation"
        Me.Text = "Register Vacation"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents tb_telp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_emp As TextBox
    Friend WithEvents dt_reqdate As DateTimePicker
    Friend WithEvents dt_anddate As DateTimePicker
    Friend WithEvents dt_startdate As DateTimePicker
    Friend WithEvents b_save As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents fil_emp As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dt_end As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_start As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents total_data As Label
    Friend WithEvents b_showall As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_holtype As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_reason As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Admision As DataGridViewTextBoxColumn
    Friend WithEvents kolom_department As DataGridViewTextBoxColumn
    Friend WithEvents HolidayType As DataGridViewTextBoxColumn
    Friend WithEvents Approval As DataGridViewTextBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Reasons As DataGridViewTextBoxColumn
    Friend WithEvents b_delete As Button
    Friend WithEvents tb_dep As TextBox
    Friend WithEvents b_search As Button
End Class
