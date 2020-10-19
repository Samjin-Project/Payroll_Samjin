<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FingerModify
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.kolom_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Kolom_No_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_InOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_FingerTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_RecTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cb_finger = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.kolom_departement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_upload_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_upload_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_shift = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b_filter = New System.Windows.Forms.Button()
        Me.dt_filter = New System.Windows.Forms.DateTimePicker()
        Me.rec_time = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dt_day = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DGV_DataModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_DataModify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_No, Me.Kolom_Check, Me.Kolom_No_Emp, Me.Kolom_Nama, Me.Kolom_Day, Me.Kolom_Shift, Me.Kolom_InOut, Me.Kolom_FingerTime, Me.Kolom_RecTime, Me.cb_finger, Me.kolom_departement, Me.kolom_upload_date, Me.kolom_upload_emp})
        Me.DGV_DataModify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_DataModify.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_DataModify.Location = New System.Drawing.Point(0, 0)
        Me.DGV_DataModify.MultiSelect = False
        Me.DGV_DataModify.Name = "DGV_DataModify"
        Me.DGV_DataModify.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_DataModify.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_DataModify.RowHeadersWidth = 30
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_DataModify.Size = New System.Drawing.Size(1370, 472)
        Me.DGV_DataModify.TabIndex = 17
        '
        'kolom_No
        '
        Me.kolom_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolom_No.DefaultCellStyle = DataGridViewCellStyle1
        Me.kolom_No.HeaderText = "No"
        Me.kolom_No.Name = "kolom_No"
        Me.kolom_No.ReadOnly = True
        Me.kolom_No.Width = 30
        '
        'Kolom_Check
        '
        Me.Kolom_Check.FillWeight = 71.42857!
        Me.Kolom_Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Kolom_Check.HeaderText = "Check"
        Me.Kolom_Check.Name = "Kolom_Check"
        '
        'Kolom_No_Emp
        '
        Me.Kolom_No_Emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_No_Emp.DefaultCellStyle = DataGridViewCellStyle2
        Me.Kolom_No_Emp.HeaderText = "Emp. No."
        Me.Kolom_No_Emp.Name = "Kolom_No_Emp"
        Me.Kolom_No_Emp.ReadOnly = True
        Me.Kolom_No_Emp.Width = 76
        '
        'Kolom_Nama
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Nama.DefaultCellStyle = DataGridViewCellStyle3
        Me.Kolom_Nama.FillWeight = 102.381!
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        '
        'Kolom_Day
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Day.DefaultCellStyle = DataGridViewCellStyle4
        Me.Kolom_Day.FillWeight = 102.381!
        Me.Kolom_Day.HeaderText = "Day"
        Me.Kolom_Day.Name = "Kolom_Day"
        Me.Kolom_Day.ReadOnly = True
        '
        'Kolom_Shift
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Shift.DefaultCellStyle = DataGridViewCellStyle5
        Me.Kolom_Shift.FillWeight = 102.381!
        Me.Kolom_Shift.HeaderText = "SHIFT"
        Me.Kolom_Shift.Name = "Kolom_Shift"
        Me.Kolom_Shift.ReadOnly = True
        '
        'Kolom_InOut
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_InOut.DefaultCellStyle = DataGridViewCellStyle6
        Me.Kolom_InOut.FillWeight = 102.381!
        Me.Kolom_InOut.HeaderText = "Check In Or Out"
        Me.Kolom_InOut.Name = "Kolom_InOut"
        Me.Kolom_InOut.ReadOnly = True
        '
        'Kolom_FingerTime
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_FingerTime.DefaultCellStyle = DataGridViewCellStyle7
        Me.Kolom_FingerTime.FillWeight = 102.381!
        Me.Kolom_FingerTime.HeaderText = "Finger Time"
        Me.Kolom_FingerTime.Name = "Kolom_FingerTime"
        Me.Kolom_FingerTime.ReadOnly = True
        '
        'Kolom_RecTime
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Format = "t"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Kolom_RecTime.DefaultCellStyle = DataGridViewCellStyle8
        Me.Kolom_RecTime.FillWeight = 102.381!
        Me.Kolom_RecTime.HeaderText = "Recognized Time"
        Me.Kolom_RecTime.Name = "Kolom_RecTime"
        '
        'cb_finger
        '
        Me.cb_finger.FillWeight = 102.381!
        Me.cb_finger.HeaderText = "Finger"
        Me.cb_finger.Name = "cb_finger"
        Me.cb_finger.ReadOnly = True
        '
        'kolom_departement
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolom_departement.DefaultCellStyle = DataGridViewCellStyle9
        Me.kolom_departement.FillWeight = 102.381!
        Me.kolom_departement.HeaderText = "Departement"
        Me.kolom_departement.Name = "kolom_departement"
        Me.kolom_departement.ReadOnly = True
        '
        'kolom_upload_date
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolom_upload_date.DefaultCellStyle = DataGridViewCellStyle10
        Me.kolom_upload_date.FillWeight = 102.381!
        Me.kolom_upload_date.HeaderText = "Upload Date"
        Me.kolom_upload_date.Name = "kolom_upload_date"
        Me.kolom_upload_date.ReadOnly = True
        '
        'kolom_upload_emp
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.kolom_upload_emp.DefaultCellStyle = DataGridViewCellStyle11
        Me.kolom_upload_emp.FillWeight = 102.381!
        Me.kolom_upload_emp.HeaderText = "Upload Emp"
        Me.kolom_upload_emp.Name = "kolom_upload_emp"
        Me.kolom_upload_emp.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.DGV_DataModify)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 472)
        Me.Panel1.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 447)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1370, 25)
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(260, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Include fingerprint data"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(42, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "SHIFT"
        '
        'cb_shift
        '
        Me.cb_shift.FormattingEnabled = True
        Me.cb_shift.Items.AddRange(New Object() {"SHIFT1", "SHIFT2", "SHIFT3", "PENDEK1", "PENDEK2", "PENDEK3", "SIANG", "MALAM", "NONSHIFT", "ALL"})
        Me.cb_shift.Location = New System.Drawing.Point(91, 30)
        Me.cb_shift.Name = "cb_shift"
        Me.cb_shift.Size = New System.Drawing.Size(156, 21)
        Me.cb_shift.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(54, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Day"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.TextBox10)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(6, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 26)
        Me.Panel3.TabIndex = 37
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(130, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(155, 20)
        Me.TextBox10.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(83, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Emp No."
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Check In"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Location = New System.Drawing.Point(382, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(190, 22)
        Me.Panel2.TabIndex = 39
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(97, 1)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.Text = "Check Out"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Division"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Admin Name"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox2.Location = New System.Drawing.Point(660, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox2.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(587, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Departement"
        '
        'cb_dep
        '
        Me.cb_dep.FormattingEnabled = True
        Me.cb_dep.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_dep.Location = New System.Drawing.Point(660, 2)
        Me.cb_dep.Name = "cb_dep"
        Me.cb_dep.Size = New System.Drawing.Size(155, 21)
        Me.cb_dep.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(827, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Recognized Time"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.b_filter)
        Me.Panel4.Controls.Add(Me.dt_filter)
        Me.Panel4.Controls.Add(Me.rec_time)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.dt_day)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.cb_shift)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.cb_dep)
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1370, 95)
        Me.Panel4.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1046, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Recognized Time"
        '
        'b_filter
        '
        Me.b_filter.Location = New System.Drawing.Point(1146, 27)
        Me.b_filter.Name = "b_filter"
        Me.b_filter.Size = New System.Drawing.Size(75, 23)
        Me.b_filter.TabIndex = 51
        Me.b_filter.Text = "Filter"
        Me.b_filter.UseVisualStyleBackColor = True
        '
        'dt_filter
        '
        Me.dt_filter.CustomFormat = "HH:mm"
        Me.dt_filter.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_filter.Location = New System.Drawing.Point(1146, 4)
        Me.dt_filter.Name = "dt_filter"
        Me.dt_filter.ShowUpDown = True
        Me.dt_filter.Size = New System.Drawing.Size(75, 20)
        Me.dt_filter.TabIndex = 50
        '
        'rec_time
        '
        Me.rec_time.Location = New System.Drawing.Point(923, 30)
        Me.rec_time.Name = "rec_time"
        Me.rec_time.Size = New System.Drawing.Size(75, 23)
        Me.rec_time.TabIndex = 49
        Me.rec_time.Text = "Enter"
        Me.rec_time.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(923, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(75, 20)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.CheckBox1)
        Me.Panel6.Location = New System.Drawing.Point(382, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(190, 20)
        Me.Panel6.TabIndex = 47
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(37, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'dt_day
        '
        Me.dt_day.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_day.Location = New System.Drawing.Point(91, 5)
        Me.dt_day.Name = "dt_day"
        Me.dt_day.Size = New System.Drawing.Size(156, 20)
        Me.dt_day.TabIndex = 20
        '
        'FingerModify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FingerModify"
        Me.Text = "Finger Data Modify"
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_DataModify As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_shift As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dt_day As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rec_time As Button
    Friend WithEvents kolom_No As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Check As DataGridViewCheckBoxColumn
    Friend WithEvents Kolom_No_Emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Day As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Shift As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_InOut As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_FingerTime As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_RecTime As DataGridViewTextBoxColumn
    Friend WithEvents cb_finger As DataGridViewCheckBoxColumn
    Friend WithEvents kolom_departement As DataGridViewTextBoxColumn
    Friend WithEvents kolom_upload_date As DataGridViewTextBoxColumn
    Friend WithEvents kolom_upload_emp As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents b_filter As Button
    Friend WithEvents dt_filter As DateTimePicker
End Class
