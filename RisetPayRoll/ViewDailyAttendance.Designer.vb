<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDailyAttendance
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b_clear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tb_emp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_filter = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_name = New System.Windows.Forms.ComboBox()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.DGV_ReviewDaily = New System.Windows.Forms.DataGridView()
        Me.KolomHasil_NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Departement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_bulan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Transport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_TransportAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_ShiftAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Meal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_MealAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Attendance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_D31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomHasil_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 88)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.b_clear)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dt_filter)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cb_name)
        Me.GroupBox1.Controls.Add(Me.cb_dep)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1178, 85)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sorting"
        '
        'b_clear
        '
        Me.b_clear.Location = New System.Drawing.Point(293, 56)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(98, 21)
        Me.b_clear.TabIndex = 43
        Me.b_clear.Text = "CLEAR"
        Me.b_clear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(483, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "EXPORT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.tb_emp)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(-1, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 26)
        Me.Panel3.TabIndex = 41
        '
        'tb_emp
        '
        Me.tb_emp.BackColor = System.Drawing.Color.White
        Me.tb_emp.Location = New System.Drawing.Point(130, 3)
        Me.tb_emp.Name = "tb_emp"
        Me.tb_emp.Size = New System.Drawing.Size(155, 20)
        Me.tb_emp.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(65, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Emp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Find"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Admin Name"
        '
        'dt_filter
        '
        Me.dt_filter.CustomFormat = "MMM yyyy"
        Me.dt_filter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_filter.Location = New System.Drawing.Point(48, 20)
        Me.dt_filter.Name = "dt_filter"
        Me.dt_filter.Size = New System.Drawing.Size(98, 20)
        Me.dt_filter.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Month"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(159, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Departement"
        '
        'cb_name
        '
        Me.cb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_name.FormattingEnabled = True
        Me.cb_name.Location = New System.Drawing.Point(483, 19)
        Me.cb_name.Name = "cb_name"
        Me.cb_name.Size = New System.Drawing.Size(171, 21)
        Me.cb_name.TabIndex = 27
        '
        'cb_dep
        '
        Me.cb_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_dep.FormattingEnabled = True
        Me.cb_dep.Items.AddRange(New Object() {"PCBA", "RUBBER  FORMING", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_dep.Location = New System.Drawing.Point(232, 19)
        Me.cb_dep.Name = "cb_dep"
        Me.cb_dep.Size = New System.Drawing.Size(171, 21)
        Me.cb_dep.TabIndex = 23
        '
        'DGV_ReviewDaily
        '
        Me.DGV_ReviewDaily.AllowUserToAddRows = False
        Me.DGV_ReviewDaily.AllowUserToDeleteRows = False
        Me.DGV_ReviewDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_ReviewDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ReviewDaily.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ReviewDaily.ColumnHeadersHeight = 30
        Me.DGV_ReviewDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ReviewDaily.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KolomHasil_NIK, Me.KolomHasil_Nama, Me.KolomHasil_Departement, Me.kolom_bulan, Me.KolomHasil_Transport, Me.KolomHasil_TransportAmount, Me.KolomHasil_Shift, Me.KolomHasil_ShiftAmount, Me.KolomHasil_Meal, Me.KolomHasil_MealAmount, Me.KolomHasil_Attendance, Me.KolomHasil_D1, Me.KolomHasil_D2, Me.KolomHasil_D3, Me.KolomHasil_D4, Me.KolomHasil_D5, Me.KolomHasil_D6, Me.KolomHasil_D7, Me.KolomHasil_D8, Me.KolomHasil_D9, Me.KolomHasil_D10, Me.KolomHasil_D11, Me.KolomHasil_D12, Me.KolomHasil_D13, Me.KolomHasil_D14, Me.KolomHasil_D15, Me.KolomHasil_D16, Me.KolomHasil_D17, Me.KolomHasil_D18, Me.KolomHasil_D19, Me.KolomHasil_D20, Me.KolomHasil_D21, Me.KolomHasil_D22, Me.KolomHasil_D23, Me.KolomHasil_D24, Me.KolomHasil_D25, Me.KolomHasil_D26, Me.KolomHasil_D27, Me.KolomHasil_D28, Me.KolomHasil_D29, Me.KolomHasil_D30, Me.KolomHasil_D31, Me.KolomHasil_Total})
        Me.DGV_ReviewDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ReviewDaily.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_ReviewDaily.Location = New System.Drawing.Point(0, 88)
        Me.DGV_ReviewDaily.MultiSelect = False
        Me.DGV_ReviewDaily.Name = "DGV_ReviewDaily"
        Me.DGV_ReviewDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_ReviewDaily.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ReviewDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ReviewDaily.Size = New System.Drawing.Size(1370, 523)
        Me.DGV_ReviewDaily.TabIndex = 22
        '
        'KolomHasil_NIK
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.KolomHasil_NIK.DefaultCellStyle = DataGridViewCellStyle2
        Me.KolomHasil_NIK.HeaderText = "Emp No."
        Me.KolomHasil_NIK.Name = "KolomHasil_NIK"
        Me.KolomHasil_NIK.Width = 73
        '
        'KolomHasil_Nama
        '
        Me.KolomHasil_Nama.HeaderText = "Name"
        Me.KolomHasil_Nama.Name = "KolomHasil_Nama"
        Me.KolomHasil_Nama.Width = 60
        '
        'KolomHasil_Departement
        '
        Me.KolomHasil_Departement.HeaderText = "Departement"
        Me.KolomHasil_Departement.Name = "KolomHasil_Departement"
        Me.KolomHasil_Departement.Width = 93
        '
        'kolom_bulan
        '
        Me.kolom_bulan.HeaderText = "Periode"
        Me.kolom_bulan.Name = "kolom_bulan"
        Me.kolom_bulan.Width = 68
        '
        'KolomHasil_Transport
        '
        Me.KolomHasil_Transport.HeaderText = "Transport"
        Me.KolomHasil_Transport.Name = "KolomHasil_Transport"
        Me.KolomHasil_Transport.Width = 77
        '
        'KolomHasil_TransportAmount
        '
        Me.KolomHasil_TransportAmount.HeaderText = "Transport Amount"
        Me.KolomHasil_TransportAmount.Name = "KolomHasil_TransportAmount"
        Me.KolomHasil_TransportAmount.Width = 116
        '
        'KolomHasil_Shift
        '
        Me.KolomHasil_Shift.HeaderText = "Shift"
        Me.KolomHasil_Shift.Name = "KolomHasil_Shift"
        Me.KolomHasil_Shift.Width = 53
        '
        'KolomHasil_ShiftAmount
        '
        Me.KolomHasil_ShiftAmount.HeaderText = "Shift Amount"
        Me.KolomHasil_ShiftAmount.Name = "KolomHasil_ShiftAmount"
        Me.KolomHasil_ShiftAmount.Width = 92
        '
        'KolomHasil_Meal
        '
        Me.KolomHasil_Meal.HeaderText = "Meal"
        Me.KolomHasil_Meal.Name = "KolomHasil_Meal"
        Me.KolomHasil_Meal.Width = 55
        '
        'KolomHasil_MealAmount
        '
        Me.KolomHasil_MealAmount.HeaderText = "Meal Amount"
        Me.KolomHasil_MealAmount.Name = "KolomHasil_MealAmount"
        Me.KolomHasil_MealAmount.Width = 94
        '
        'KolomHasil_Attendance
        '
        Me.KolomHasil_Attendance.HeaderText = "Attendance"
        Me.KolomHasil_Attendance.Name = "KolomHasil_Attendance"
        Me.KolomHasil_Attendance.Width = 87
        '
        'KolomHasil_D1
        '
        Me.KolomHasil_D1.HeaderText = "1"
        Me.KolomHasil_D1.Name = "KolomHasil_D1"
        Me.KolomHasil_D1.Width = 38
        '
        'KolomHasil_D2
        '
        Me.KolomHasil_D2.HeaderText = "2"
        Me.KolomHasil_D2.Name = "KolomHasil_D2"
        Me.KolomHasil_D2.Width = 38
        '
        'KolomHasil_D3
        '
        Me.KolomHasil_D3.HeaderText = "3"
        Me.KolomHasil_D3.Name = "KolomHasil_D3"
        Me.KolomHasil_D3.Width = 38
        '
        'KolomHasil_D4
        '
        Me.KolomHasil_D4.HeaderText = "4"
        Me.KolomHasil_D4.Name = "KolomHasil_D4"
        Me.KolomHasil_D4.Width = 38
        '
        'KolomHasil_D5
        '
        Me.KolomHasil_D5.HeaderText = "5"
        Me.KolomHasil_D5.Name = "KolomHasil_D5"
        Me.KolomHasil_D5.Width = 38
        '
        'KolomHasil_D6
        '
        Me.KolomHasil_D6.HeaderText = "6"
        Me.KolomHasil_D6.Name = "KolomHasil_D6"
        Me.KolomHasil_D6.Width = 38
        '
        'KolomHasil_D7
        '
        Me.KolomHasil_D7.HeaderText = "7"
        Me.KolomHasil_D7.Name = "KolomHasil_D7"
        Me.KolomHasil_D7.Width = 38
        '
        'KolomHasil_D8
        '
        Me.KolomHasil_D8.HeaderText = "8"
        Me.KolomHasil_D8.Name = "KolomHasil_D8"
        Me.KolomHasil_D8.Width = 38
        '
        'KolomHasil_D9
        '
        Me.KolomHasil_D9.HeaderText = "9"
        Me.KolomHasil_D9.Name = "KolomHasil_D9"
        Me.KolomHasil_D9.Width = 38
        '
        'KolomHasil_D10
        '
        Me.KolomHasil_D10.HeaderText = "10"
        Me.KolomHasil_D10.Name = "KolomHasil_D10"
        Me.KolomHasil_D10.Width = 44
        '
        'KolomHasil_D11
        '
        Me.KolomHasil_D11.HeaderText = "11"
        Me.KolomHasil_D11.Name = "KolomHasil_D11"
        Me.KolomHasil_D11.Width = 44
        '
        'KolomHasil_D12
        '
        Me.KolomHasil_D12.HeaderText = "12"
        Me.KolomHasil_D12.Name = "KolomHasil_D12"
        Me.KolomHasil_D12.Width = 44
        '
        'KolomHasil_D13
        '
        Me.KolomHasil_D13.HeaderText = "13"
        Me.KolomHasil_D13.Name = "KolomHasil_D13"
        Me.KolomHasil_D13.Width = 44
        '
        'KolomHasil_D14
        '
        Me.KolomHasil_D14.HeaderText = "14"
        Me.KolomHasil_D14.Name = "KolomHasil_D14"
        Me.KolomHasil_D14.Width = 44
        '
        'KolomHasil_D15
        '
        Me.KolomHasil_D15.HeaderText = "15"
        Me.KolomHasil_D15.Name = "KolomHasil_D15"
        Me.KolomHasil_D15.Width = 44
        '
        'KolomHasil_D16
        '
        Me.KolomHasil_D16.HeaderText = "16"
        Me.KolomHasil_D16.Name = "KolomHasil_D16"
        Me.KolomHasil_D16.Width = 44
        '
        'KolomHasil_D17
        '
        Me.KolomHasil_D17.HeaderText = "17"
        Me.KolomHasil_D17.Name = "KolomHasil_D17"
        Me.KolomHasil_D17.Width = 44
        '
        'KolomHasil_D18
        '
        Me.KolomHasil_D18.HeaderText = "18"
        Me.KolomHasil_D18.Name = "KolomHasil_D18"
        Me.KolomHasil_D18.Width = 44
        '
        'KolomHasil_D19
        '
        Me.KolomHasil_D19.HeaderText = "19"
        Me.KolomHasil_D19.Name = "KolomHasil_D19"
        Me.KolomHasil_D19.Width = 44
        '
        'KolomHasil_D20
        '
        Me.KolomHasil_D20.HeaderText = "20"
        Me.KolomHasil_D20.Name = "KolomHasil_D20"
        Me.KolomHasil_D20.Width = 44
        '
        'KolomHasil_D21
        '
        Me.KolomHasil_D21.HeaderText = "21"
        Me.KolomHasil_D21.Name = "KolomHasil_D21"
        Me.KolomHasil_D21.Width = 44
        '
        'KolomHasil_D22
        '
        Me.KolomHasil_D22.HeaderText = "22"
        Me.KolomHasil_D22.Name = "KolomHasil_D22"
        Me.KolomHasil_D22.Width = 44
        '
        'KolomHasil_D23
        '
        Me.KolomHasil_D23.HeaderText = "23"
        Me.KolomHasil_D23.Name = "KolomHasil_D23"
        Me.KolomHasil_D23.Width = 44
        '
        'KolomHasil_D24
        '
        Me.KolomHasil_D24.HeaderText = "24"
        Me.KolomHasil_D24.Name = "KolomHasil_D24"
        Me.KolomHasil_D24.Width = 44
        '
        'KolomHasil_D25
        '
        Me.KolomHasil_D25.HeaderText = "25"
        Me.KolomHasil_D25.Name = "KolomHasil_D25"
        Me.KolomHasil_D25.Width = 44
        '
        'KolomHasil_D26
        '
        Me.KolomHasil_D26.HeaderText = "26"
        Me.KolomHasil_D26.Name = "KolomHasil_D26"
        Me.KolomHasil_D26.Width = 44
        '
        'KolomHasil_D27
        '
        Me.KolomHasil_D27.HeaderText = "27"
        Me.KolomHasil_D27.Name = "KolomHasil_D27"
        Me.KolomHasil_D27.Width = 44
        '
        'KolomHasil_D28
        '
        Me.KolomHasil_D28.HeaderText = "28"
        Me.KolomHasil_D28.Name = "KolomHasil_D28"
        Me.KolomHasil_D28.Width = 44
        '
        'KolomHasil_D29
        '
        Me.KolomHasil_D29.HeaderText = "29"
        Me.KolomHasil_D29.Name = "KolomHasil_D29"
        Me.KolomHasil_D29.Width = 44
        '
        'KolomHasil_D30
        '
        Me.KolomHasil_D30.HeaderText = "30"
        Me.KolomHasil_D30.Name = "KolomHasil_D30"
        Me.KolomHasil_D30.Width = 44
        '
        'KolomHasil_D31
        '
        Me.KolomHasil_D31.HeaderText = "31"
        Me.KolomHasil_D31.Name = "KolomHasil_D31"
        Me.KolomHasil_D31.Width = 44
        '
        'KolomHasil_Total
        '
        Me.KolomHasil_Total.HeaderText = "Total"
        Me.KolomHasil_Total.Name = "KolomHasil_Total"
        Me.KolomHasil_Total.Width = 56
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(579, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Retrive"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewDailyAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 611)
        Me.Controls.Add(Me.DGV_ReviewDaily)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewDailyAttendance"
        Me.Text = "View Daily Attendance"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dt_filter As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_name As ComboBox
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents DGV_ReviewDaily As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tb_emp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents KolomHasil_NIK As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Nama As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Departement As DataGridViewTextBoxColumn
    Friend WithEvents kolom_bulan As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Transport As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_TransportAmount As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Shift As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_ShiftAmount As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Meal As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_MealAmount As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Attendance As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D1 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D2 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D3 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D4 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D5 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D6 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D7 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D8 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D9 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D10 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D11 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D12 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D13 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D14 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D15 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D16 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D17 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D18 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D19 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D20 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D21 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D22 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D23 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D24 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D25 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D26 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D27 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D28 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D29 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D30 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_D31 As DataGridViewTextBoxColumn
    Friend WithEvents KolomHasil_Total As DataGridViewTextBoxColumn
    Friend WithEvents b_clear As Button
    Friend WithEvents Button1 As Button
End Class
