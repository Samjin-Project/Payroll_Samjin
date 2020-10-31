<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DailyAttendance
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.b_clear = New System.Windows.Forms.Button()
        Me.cb_depSearch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.tb_namaSearch = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.tb_empSearch = New System.Windows.Forms.TextBox()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dt_create = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_depCreate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tb_empCreate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV_SideDaily = New System.Windows.Forms.DataGridView()
        Me.Kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGV_ReviewDaily = New System.Windows.Forms.DataGridView()
        Me.KolomView_NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_AttendDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_DayNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_CheckIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_CheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_CheckOutDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_Latness = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_EarlyCheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_BasicTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomView_x2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total_data = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_SideDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 94)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.b_clear)
        Me.GroupBox2.Controls.Add(Me.cb_depSearch)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.dt_end)
        Me.GroupBox2.Controls.Add(Me.tb_namaSearch)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.tb_empSearch)
        Me.GroupBox2.Controls.Add(Me.dt_start)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(572, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 88)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Conditions"
        '
        'b_clear
        '
        Me.b_clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.b_clear.Location = New System.Drawing.Point(489, 63)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(68, 20)
        Me.b_clear.TabIndex = 44
        Me.b_clear.Text = "Clear"
        Me.b_clear.UseVisualStyleBackColor = True
        '
        'cb_depSearch
        '
        Me.cb_depSearch.FormattingEnabled = True
        Me.cb_depSearch.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING"})
        Me.cb_depSearch.Location = New System.Drawing.Point(71, 63)
        Me.cb_depSearch.Name = "cb_depSearch"
        Me.cb_depSearch.Size = New System.Drawing.Size(118, 21)
        Me.cb_depSearch.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(420, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "~"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(5, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Departement"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(13, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Workplace"
        '
        'dt_end
        '
        Me.dt_end.CustomFormat = "MM/yyyy"
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_end.Location = New System.Drawing.Point(443, 16)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Size = New System.Drawing.Size(82, 20)
        Me.dt_end.TabIndex = 34
        '
        'tb_namaSearch
        '
        Me.tb_namaSearch.BackColor = System.Drawing.Color.White
        Me.tb_namaSearch.Location = New System.Drawing.Point(165, 38)
        Me.tb_namaSearch.Name = "tb_namaSearch"
        Me.tb_namaSearch.Size = New System.Drawing.Size(113, 20)
        Me.tb_namaSearch.TabIndex = 33
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(72, 14)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(87, 20)
        Me.TextBox9.TabIndex = 32
        Me.TextBox9.Text = "PT. SAMJIN"
        '
        'tb_empSearch
        '
        Me.tb_empSearch.BackColor = System.Drawing.Color.White
        Me.tb_empSearch.Location = New System.Drawing.Point(72, 38)
        Me.tb_empSearch.Name = "tb_empSearch"
        Me.tb_empSearch.Size = New System.Drawing.Size(87, 20)
        Me.tb_empSearch.TabIndex = 31
        '
        'dt_start
        '
        Me.dt_start.CustomFormat = "MM/yyyy"
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_start.Location = New System.Drawing.Point(331, 16)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Size = New System.Drawing.Size(82, 20)
        Me.dt_start.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(288, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Period"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(25, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Emp. No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dt_create)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cb_depCreate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.tb_empCreate)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 88)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Conditions"
        '
        'dt_create
        '
        Me.dt_create.CustomFormat = "MM/yyyy"
        Me.dt_create.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_create.Location = New System.Drawing.Point(370, 38)
        Me.dt_create.Name = "dt_create"
        Me.dt_create.Size = New System.Drawing.Size(82, 20)
        Me.dt_create.TabIndex = 45
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 24)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_depCreate
        '
        Me.cb_depCreate.FormattingEnabled = True
        Me.cb_depCreate.Items.AddRange(New Object() {"ALL", "PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_depCreate.Location = New System.Drawing.Point(370, 13)
        Me.cb_depCreate.Name = "cb_depCreate"
        Me.cb_depCreate.Size = New System.Drawing.Size(124, 21)
        Me.cb_depCreate.TabIndex = 42
        Me.cb_depCreate.Text = "ALL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Admin Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(282, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Departement"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Workplace"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(72, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(77, 20)
        Me.TextBox2.TabIndex = 32
        Me.TextBox2.Text = "PT. SAMJIN"
        '
        'tb_empCreate
        '
        Me.tb_empCreate.BackColor = System.Drawing.Color.White
        Me.tb_empCreate.Location = New System.Drawing.Point(72, 38)
        Me.tb_empCreate.Name = "tb_empCreate"
        Me.tb_empCreate.Size = New System.Drawing.Size(77, 20)
        Me.tb_empCreate.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(282, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Month"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.White
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox4.Location = New System.Drawing.Point(72, 62)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox4.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(19, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Emp. No"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGV_SideDaily)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(281, 517)
        Me.Panel2.TabIndex = 1
        '
        'DGV_SideDaily
        '
        Me.DGV_SideDaily.AllowUserToAddRows = False
        Me.DGV_SideDaily.AllowUserToDeleteRows = False
        Me.DGV_SideDaily.AllowUserToResizeColumns = False
        Me.DGV_SideDaily.AllowUserToResizeRows = False
        Me.DGV_SideDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_SideDaily.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_SideDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_SideDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_SideDaily.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kolom_emp, Me.Kolom_Nama})
        Me.DGV_SideDaily.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_SideDaily.Location = New System.Drawing.Point(0, 0)
        Me.DGV_SideDaily.MultiSelect = False
        Me.DGV_SideDaily.Name = "DGV_SideDaily"
        Me.DGV_SideDaily.ReadOnly = True
        Me.DGV_SideDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_SideDaily.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_SideDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_SideDaily.Size = New System.Drawing.Size(246, 517)
        Me.DGV_SideDaily.TabIndex = 2
        '
        'Kolom_emp
        '
        Me.Kolom_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_emp.DefaultCellStyle = DataGridViewCellStyle1
        Me.Kolom_emp.HeaderText = "Emp No."
        Me.Kolom_emp.Name = "Kolom_emp"
        Me.Kolom_emp.ReadOnly = True
        Me.Kolom_emp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Kolom_emp.Width = 54
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        Me.Kolom_Nama.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV_ReviewDaily)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(281, 94)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(903, 517)
        Me.Panel3.TabIndex = 2
        '
        'DGV_ReviewDaily
        '
        Me.DGV_ReviewDaily.AllowUserToAddRows = False
        Me.DGV_ReviewDaily.AllowUserToDeleteRows = False
        Me.DGV_ReviewDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ReviewDaily.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ReviewDaily.ColumnHeadersHeight = 30
        Me.DGV_ReviewDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ReviewDaily.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KolomView_NIK, Me.KolomView_Nama, Me.KolomView_Type, Me.KolomView_AttendDate, Me.KolomView_DayNumber, Me.KolomView_Shift, Me.KolomView_CheckIn, Me.KolomView_CheckOut, Me.KolomView_CheckOutDate, Me.KolomView_Latness, Me.KolomView_EarlyCheckOut, Me.KolomView_BasicTime, Me.KolomView_x2, Me.kolom_dep})
        Me.DGV_ReviewDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ReviewDaily.GridColor = System.Drawing.Color.Gainsboro
        Me.DGV_ReviewDaily.Location = New System.Drawing.Point(0, 0)
        Me.DGV_ReviewDaily.MultiSelect = False
        Me.DGV_ReviewDaily.Name = "DGV_ReviewDaily"
        Me.DGV_ReviewDaily.ReadOnly = True
        Me.DGV_ReviewDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_ReviewDaily.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_ReviewDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ReviewDaily.Size = New System.Drawing.Size(903, 492)
        Me.DGV_ReviewDaily.TabIndex = 21
        '
        'KolomView_NIK
        '
        Me.KolomView_NIK.HeaderText = "Emp No."
        Me.KolomView_NIK.Name = "KolomView_NIK"
        Me.KolomView_NIK.ReadOnly = True
        Me.KolomView_NIK.Width = 80
        '
        'KolomView_Nama
        '
        Me.KolomView_Nama.HeaderText = "Name"
        Me.KolomView_Nama.Name = "KolomView_Nama"
        Me.KolomView_Nama.ReadOnly = True
        Me.KolomView_Nama.Width = 150
        '
        'KolomView_Type
        '
        Me.KolomView_Type.HeaderText = "Type"
        Me.KolomView_Type.Name = "KolomView_Type"
        Me.KolomView_Type.ReadOnly = True
        Me.KolomView_Type.Width = 80
        '
        'KolomView_AttendDate
        '
        Me.KolomView_AttendDate.HeaderText = "Attendance Date"
        Me.KolomView_AttendDate.Name = "KolomView_AttendDate"
        Me.KolomView_AttendDate.ReadOnly = True
        Me.KolomView_AttendDate.Width = 120
        '
        'KolomView_DayNumber
        '
        Me.KolomView_DayNumber.HeaderText = "Day Number"
        Me.KolomView_DayNumber.Name = "KolomView_DayNumber"
        Me.KolomView_DayNumber.ReadOnly = True
        Me.KolomView_DayNumber.Width = 80
        '
        'KolomView_Shift
        '
        Me.KolomView_Shift.HeaderText = "SHIFT"
        Me.KolomView_Shift.Name = "KolomView_Shift"
        Me.KolomView_Shift.ReadOnly = True
        Me.KolomView_Shift.Width = 80
        '
        'KolomView_CheckIn
        '
        Me.KolomView_CheckIn.HeaderText = "Check In"
        Me.KolomView_CheckIn.Name = "KolomView_CheckIn"
        Me.KolomView_CheckIn.ReadOnly = True
        Me.KolomView_CheckIn.Width = 80
        '
        'KolomView_CheckOut
        '
        Me.KolomView_CheckOut.HeaderText = "Check Out"
        Me.KolomView_CheckOut.Name = "KolomView_CheckOut"
        Me.KolomView_CheckOut.ReadOnly = True
        Me.KolomView_CheckOut.Width = 80
        '
        'KolomView_CheckOutDate
        '
        Me.KolomView_CheckOutDate.HeaderText = "Check Out Date"
        Me.KolomView_CheckOutDate.Name = "KolomView_CheckOutDate"
        Me.KolomView_CheckOutDate.ReadOnly = True
        '
        'KolomView_Latness
        '
        Me.KolomView_Latness.HeaderText = "Lateness"
        Me.KolomView_Latness.Name = "KolomView_Latness"
        Me.KolomView_Latness.ReadOnly = True
        Me.KolomView_Latness.Width = 80
        '
        'KolomView_EarlyCheckOut
        '
        Me.KolomView_EarlyCheckOut.HeaderText = "Early Check Out"
        Me.KolomView_EarlyCheckOut.Name = "KolomView_EarlyCheckOut"
        Me.KolomView_EarlyCheckOut.ReadOnly = True
        Me.KolomView_EarlyCheckOut.Width = 110
        '
        'KolomView_BasicTime
        '
        Me.KolomView_BasicTime.HeaderText = "Basic Time"
        Me.KolomView_BasicTime.Name = "KolomView_BasicTime"
        Me.KolomView_BasicTime.ReadOnly = True
        Me.KolomView_BasicTime.Width = 80
        '
        'KolomView_x2
        '
        Me.KolomView_x2.HeaderText = "x2"
        Me.KolomView_x2.Name = "KolomView_x2"
        Me.KolomView_x2.ReadOnly = True
        '
        'kolom_dep
        '
        Me.kolom_dep.HeaderText = "Departement"
        Me.kolom_dep.Name = "kolom_dep"
        Me.kolom_dep.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.total_data)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 492)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(903, 25)
        Me.Panel5.TabIndex = 20
        '
        'total_data
        '
        Me.total_data.AutoSize = True
        Me.total_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.total_data.Location = New System.Drawing.Point(136, 6)
        Me.total_data.Name = "total_data"
        Me.total_data.Size = New System.Drawing.Size(0, 13)
        Me.total_data.TabIndex = 22
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
        'DailyAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DailyAttendance"
        Me.Text = "Daily Attendance"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV_SideDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tb_empCreate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV_SideDaily As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGV_ReviewDaily As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dt_end As DateTimePicker
    Friend WithEvents tb_namaSearch As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents tb_empSearch As TextBox
    Friend WithEvents dt_start As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cb_depSearch As ComboBox
    Friend WithEvents cb_depCreate As ComboBox
    Friend WithEvents total_data As Label
    Friend WithEvents b_clear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents KolomView_NIK As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_Nama As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_Type As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_AttendDate As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_DayNumber As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_Shift As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_CheckIn As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_CheckOut As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_CheckOutDate As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_Latness As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_EarlyCheckOut As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_BasicTime As DataGridViewTextBoxColumn
    Friend WithEvents KolomView_x2 As DataGridViewTextBoxColumn
    Friend WithEvents kolom_dep As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents dt_create As DateTimePicker
End Class
