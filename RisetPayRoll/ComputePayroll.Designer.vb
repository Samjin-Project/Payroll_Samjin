<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComputePayroll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.DGV_ReviewDaily = New System.Windows.Forms.DataGridView()
        Me.KolomPayroll_NIK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomPayroll_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomPayroll_Posisition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomPayroll_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.b_showall = New System.Windows.Forms.Button()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.tb_nameSearch = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.tb_empSearch = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dt_month = New System.Windows.Forms.DateTimePicker()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.tb_sup = New System.Windows.Forms.TextBox()
        Me.tb_deduct = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.tb_bpjsPot = New System.Windows.Forms.TextBox()
        Me.tb_potsal = New System.Windows.Forms.TextBox()
        Me.tb_jamsostekPot = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.tb_jamsostek = New System.Windows.Forms.TextBox()
        Me.tb_bpjs = New System.Windows.Forms.TextBox()
        Me.tb_otwages = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tb_ot = New System.Windows.Forms.TextBox()
        Me.tb_attendance = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.tb_basicSal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_posisi = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ComboBoxDep = New System.Windows.Forms.ComboBox()
        Me.b_export = New System.Windows.Forms.Button()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 665)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.StatusStrip1)
        Me.Panel4.Controls.Add(Me.DGV_ReviewDaily)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 190)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(324, 475)
        Me.Panel4.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 449)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(320, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.Visible = False
        '
        'DGV_ReviewDaily
        '
        Me.DGV_ReviewDaily.AllowUserToAddRows = False
        Me.DGV_ReviewDaily.AllowUserToDeleteRows = False
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
        Me.DGV_ReviewDaily.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KolomPayroll_NIK, Me.KolomPayroll_Nama, Me.KolomPayroll_Posisition, Me.KolomPayroll_Status})
        Me.DGV_ReviewDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ReviewDaily.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_ReviewDaily.Location = New System.Drawing.Point(0, 0)
        Me.DGV_ReviewDaily.MultiSelect = False
        Me.DGV_ReviewDaily.Name = "DGV_ReviewDaily"
        Me.DGV_ReviewDaily.ReadOnly = True
        Me.DGV_ReviewDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_ReviewDaily.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_ReviewDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ReviewDaily.Size = New System.Drawing.Size(320, 471)
        Me.DGV_ReviewDaily.TabIndex = 23
        '
        'KolomPayroll_NIK
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.KolomPayroll_NIK.DefaultCellStyle = DataGridViewCellStyle2
        Me.KolomPayroll_NIK.HeaderText = "Emp No."
        Me.KolomPayroll_NIK.Name = "KolomPayroll_NIK"
        Me.KolomPayroll_NIK.ReadOnly = True
        Me.KolomPayroll_NIK.Width = 80
        '
        'KolomPayroll_Nama
        '
        Me.KolomPayroll_Nama.HeaderText = "Name"
        Me.KolomPayroll_Nama.Name = "KolomPayroll_Nama"
        Me.KolomPayroll_Nama.ReadOnly = True
        Me.KolomPayroll_Nama.Width = 150
        '
        'KolomPayroll_Posisition
        '
        Me.KolomPayroll_Posisition.HeaderText = "Posisition"
        Me.KolomPayroll_Posisition.Name = "KolomPayroll_Posisition"
        Me.KolomPayroll_Posisition.ReadOnly = True
        '
        'KolomPayroll_Status
        '
        Me.KolomPayroll_Status.HeaderText = "Status"
        Me.KolomPayroll_Status.Name = "KolomPayroll_Status"
        Me.KolomPayroll_Status.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.b_showall)
        Me.Panel3.Controls.Add(Me.Label51)
        Me.Panel3.Controls.Add(Me.Label46)
        Me.Panel3.Controls.Add(Me.tb_nameSearch)
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Controls.Add(Me.tb_empSearch)
        Me.Panel3.Controls.Add(Me.Label44)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(324, 104)
        Me.Panel3.TabIndex = 0
        '
        'b_showall
        '
        Me.b_showall.Location = New System.Drawing.Point(228, 38)
        Me.b_showall.Name = "b_showall"
        Me.b_showall.Size = New System.Drawing.Size(70, 22)
        Me.b_showall.TabIndex = 58
        Me.b_showall.Text = "Show All"
        Me.b_showall.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(8, 61)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 13)
        Me.Label51.TabIndex = 57
        Me.Label51.Text = "Name"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(342, 30)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(35, 13)
        Me.Label46.TabIndex = 56
        Me.Label46.Text = "Name"
        '
        'tb_nameSearch
        '
        Me.tb_nameSearch.BackColor = System.Drawing.Color.White
        Me.tb_nameSearch.Location = New System.Drawing.Point(47, 62)
        Me.tb_nameSearch.Name = "tb_nameSearch"
        Me.tb_nameSearch.Size = New System.Drawing.Size(155, 20)
        Me.tb_nameSearch.TabIndex = 55
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(-2, 37)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 13)
        Me.Label45.TabIndex = 54
        Me.Label45.Text = "Emp No."
        '
        'tb_empSearch
        '
        Me.tb_empSearch.BackColor = System.Drawing.Color.White
        Me.tb_empSearch.Location = New System.Drawing.Point(47, 37)
        Me.tb_empSearch.Name = "tb_empSearch"
        Me.tb_empSearch.Size = New System.Drawing.Size(69, 20)
        Me.tb_empSearch.TabIndex = 53
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(3, 1)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(129, 18)
        Me.Label44.TabIndex = 52
        Me.Label44.Text = "[Payroll Person]"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.dt_month)
        Me.Panel7.Controls.Add(Me.Label43)
        Me.Panel7.Controls.Add(Me.Label39)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(324, 86)
        Me.Panel7.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(186, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Create Payroll"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dt_month
        '
        Me.dt_month.CustomFormat = "MMM yyyy"
        Me.dt_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_month.Location = New System.Drawing.Point(84, 53)
        Me.dt_month.Name = "dt_month"
        Me.dt_month.Size = New System.Drawing.Size(197, 20)
        Me.dt_month.TabIndex = 73
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(3, 7)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(148, 18)
        Me.Label43.TabIndex = 64
        Me.Label43.Text = "[Search Condition]"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(3, 56)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(83, 13)
        Me.Label39.TabIndex = 61
        Me.Label39.Text = "Month of Payroll"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(324, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 665)
        Me.Panel2.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.AutoScroll = True
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.ProgressBar1)
        Me.Panel6.Controls.Add(Me.tb_total)
        Me.Panel6.Controls.Add(Me.tb_sup)
        Me.Panel6.Controls.Add(Me.tb_deduct)
        Me.Panel6.Controls.Add(Me.TextBox12)
        Me.Panel6.Controls.Add(Me.TextBox14)
        Me.Panel6.Controls.Add(Me.TextBox15)
        Me.Panel6.Controls.Add(Me.TextBox16)
        Me.Panel6.Controls.Add(Me.tb_bpjsPot)
        Me.Panel6.Controls.Add(Me.tb_potsal)
        Me.Panel6.Controls.Add(Me.tb_jamsostekPot)
        Me.Panel6.Controls.Add(Me.TextBox11)
        Me.Panel6.Controls.Add(Me.TextBox8)
        Me.Panel6.Controls.Add(Me.tb_jamsostek)
        Me.Panel6.Controls.Add(Me.tb_bpjs)
        Me.Panel6.Controls.Add(Me.tb_otwages)
        Me.Panel6.Controls.Add(Me.TextBox6)
        Me.Panel6.Controls.Add(Me.TextBox7)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.tb_ot)
        Me.Panel6.Controls.Add(Me.tb_attendance)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label47)
        Me.Panel6.Controls.Add(Me.tb_basicSal)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.tb_posisi)
        Me.Panel6.Location = New System.Drawing.Point(0, 118)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(935, 545)
        Me.Panel6.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(515, 175)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(331, 54)
        Me.ProgressBar1.TabIndex = 98
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.White
        Me.tb_total.Location = New System.Drawing.Point(643, 98)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(110, 20)
        Me.tb_total.TabIndex = 97
        Me.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_sup
        '
        Me.tb_sup.BackColor = System.Drawing.Color.White
        Me.tb_sup.Location = New System.Drawing.Point(643, 47)
        Me.tb_sup.Name = "tb_sup"
        Me.tb_sup.ReadOnly = True
        Me.tb_sup.Size = New System.Drawing.Size(110, 20)
        Me.tb_sup.TabIndex = 96
        Me.tb_sup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_deduct
        '
        Me.tb_deduct.BackColor = System.Drawing.Color.White
        Me.tb_deduct.Location = New System.Drawing.Point(643, 72)
        Me.tb_deduct.Name = "tb_deduct"
        Me.tb_deduct.ReadOnly = True
        Me.tb_deduct.Size = New System.Drawing.Size(110, 20)
        Me.tb_deduct.TabIndex = 95
        Me.tb_deduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(399, 204)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(110, 20)
        Me.TextBox12.TabIndex = 94
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.White
        Me.TextBox14.Location = New System.Drawing.Point(399, 178)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(110, 20)
        Me.TextBox14.TabIndex = 92
        Me.TextBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.White
        Me.TextBox15.Location = New System.Drawing.Point(399, 127)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(110, 20)
        Me.TextBox15.TabIndex = 91
        Me.TextBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.White
        Me.TextBox16.Location = New System.Drawing.Point(399, 152)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(110, 20)
        Me.TextBox16.TabIndex = 90
        Me.TextBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_bpjsPot
        '
        Me.tb_bpjsPot.BackColor = System.Drawing.Color.White
        Me.tb_bpjsPot.Location = New System.Drawing.Point(399, 101)
        Me.tb_bpjsPot.Name = "tb_bpjsPot"
        Me.tb_bpjsPot.ReadOnly = True
        Me.tb_bpjsPot.Size = New System.Drawing.Size(110, 20)
        Me.tb_bpjsPot.TabIndex = 89
        Me.tb_bpjsPot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_potsal
        '
        Me.tb_potsal.BackColor = System.Drawing.Color.White
        Me.tb_potsal.Location = New System.Drawing.Point(399, 50)
        Me.tb_potsal.Name = "tb_potsal"
        Me.tb_potsal.ReadOnly = True
        Me.tb_potsal.Size = New System.Drawing.Size(110, 20)
        Me.tb_potsal.TabIndex = 88
        Me.tb_potsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_jamsostekPot
        '
        Me.tb_jamsostekPot.BackColor = System.Drawing.Color.White
        Me.tb_jamsostekPot.Location = New System.Drawing.Point(399, 75)
        Me.tb_jamsostekPot.Name = "tb_jamsostekPot"
        Me.tb_jamsostekPot.ReadOnly = True
        Me.tb_jamsostekPot.Size = New System.Drawing.Size(110, 20)
        Me.tb_jamsostekPot.TabIndex = 87
        Me.tb_jamsostekPot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(122, 355)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(110, 20)
        Me.TextBox11.TabIndex = 86
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(122, 329)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(110, 20)
        Me.TextBox8.TabIndex = 85
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_jamsostek
        '
        Me.tb_jamsostek.BackColor = System.Drawing.Color.White
        Me.tb_jamsostek.Location = New System.Drawing.Point(122, 278)
        Me.tb_jamsostek.Name = "tb_jamsostek"
        Me.tb_jamsostek.ReadOnly = True
        Me.tb_jamsostek.Size = New System.Drawing.Size(110, 20)
        Me.tb_jamsostek.TabIndex = 84
        Me.tb_jamsostek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_bpjs
        '
        Me.tb_bpjs.BackColor = System.Drawing.Color.White
        Me.tb_bpjs.Location = New System.Drawing.Point(122, 303)
        Me.tb_bpjs.Name = "tb_bpjs"
        Me.tb_bpjs.ReadOnly = True
        Me.tb_bpjs.Size = New System.Drawing.Size(110, 20)
        Me.tb_bpjs.TabIndex = 83
        Me.tb_bpjs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_otwages
        '
        Me.tb_otwages.BackColor = System.Drawing.Color.White
        Me.tb_otwages.Location = New System.Drawing.Point(122, 252)
        Me.tb_otwages.Name = "tb_otwages"
        Me.tb_otwages.ReadOnly = True
        Me.tb_otwages.Size = New System.Drawing.Size(110, 20)
        Me.tb_otwages.TabIndex = 82
        Me.tb_otwages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(122, 201)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(110, 20)
        Me.TextBox6.TabIndex = 81
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(122, 226)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(110, 20)
        Me.TextBox7.TabIndex = 80
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(122, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox2.TabIndex = 79
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_ot
        '
        Me.tb_ot.BackColor = System.Drawing.Color.White
        Me.tb_ot.Location = New System.Drawing.Point(122, 124)
        Me.tb_ot.Name = "tb_ot"
        Me.tb_ot.ReadOnly = True
        Me.tb_ot.Size = New System.Drawing.Size(110, 20)
        Me.tb_ot.TabIndex = 78
        Me.tb_ot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tb_attendance
        '
        Me.tb_attendance.BackColor = System.Drawing.Color.White
        Me.tb_attendance.Location = New System.Drawing.Point(122, 149)
        Me.tb_attendance.Name = "tb_attendance"
        Me.tb_attendance.ReadOnly = True
        Me.tb_attendance.Size = New System.Drawing.Size(110, 20)
        Me.tb_attendance.TabIndex = 77
        Me.tb_attendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(122, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 76
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(56, 50)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(65, 13)
        Me.Label47.TabIndex = 75
        Me.Label47.Text = "Basic Salary"
        '
        'tb_basicSal
        '
        Me.tb_basicSal.BackColor = System.Drawing.Color.White
        Me.tb_basicSal.Location = New System.Drawing.Point(122, 47)
        Me.tb_basicSal.Name = "tb_basicSal"
        Me.tb_basicSal.ReadOnly = True
        Me.tb_basicSal.Size = New System.Drawing.Size(110, 20)
        Me.tb_basicSal.TabIndex = 74
        Me.tb_basicSal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(581, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 13)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "Deduct tot."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(578, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 13)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "Pembulatan"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(584, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 71
        Me.Label26.Text = "Supply tot."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 154)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 67
        Me.Label17.Text = "Etc."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(361, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = "Loan"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(280, 205)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 13)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "JAMSOSTEK Pensiun"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(321, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 64
        Me.Label20.Text = "JAMSOSTEK"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(359, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 13)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "BPJS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(352, 130)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 62
        Me.Label22.Text = "TAX21"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(356, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 13)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Salary"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(88, 307)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "BPJS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Annual Allowance"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(76, 358)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 58
        Me.Label16.Text = "Pensiun"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Shift"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Overtime wages"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Jamsostek"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(91, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Meal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Transport"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(573, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 18)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "[Sum]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "[Potongan]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "[Pendapatan]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Other Allowance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Overtime"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Attendance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Posisition"
        '
        'tb_posisi
        '
        Me.tb_posisi.BackColor = System.Drawing.Color.White
        Me.tb_posisi.Location = New System.Drawing.Point(122, 72)
        Me.tb_posisi.Name = "tb_posisi"
        Me.tb_posisi.ReadOnly = True
        Me.tb_posisi.Size = New System.Drawing.Size(110, 20)
        Me.tb_posisi.TabIndex = 19
        Me.tb_posisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(938, 86)
        Me.Panel5.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.ComboBoxDep)
        Me.Panel8.Controls.Add(Me.b_export)
        Me.Panel8.Controls.Add(Me.Label48)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(934, 85)
        Me.Panel8.TabIndex = 64
        '
        'ComboBoxDep
        '
        Me.ComboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDep.FormattingEnabled = True
        Me.ComboBoxDep.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.ComboBoxDep.Location = New System.Drawing.Point(83, 13)
        Me.ComboBoxDep.Name = "ComboBoxDep"
        Me.ComboBoxDep.Size = New System.Drawing.Size(110, 21)
        Me.ComboBoxDep.TabIndex = 74
        '
        'b_export
        '
        Me.b_export.Location = New System.Drawing.Point(21, 45)
        Me.b_export.Name = "b_export"
        Me.b_export.Size = New System.Drawing.Size(75, 23)
        Me.b_export.TabIndex = 73
        Me.b_export.Text = "Export"
        Me.b_export.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(18, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(62, 13)
        Me.Label48.TabIndex = 72
        Me.Label48.Text = "Department"
        '
        'ComputePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 665)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ComputePayroll"
        Me.Text = "Compute Payroll"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DGV_ReviewDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_ReviewDaily As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents tb_nameSearch As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents tb_empSearch As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents dt_month As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents tb_total As TextBox
    Friend WithEvents tb_sup As TextBox
    Friend WithEvents tb_deduct As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents tb_bpjsPot As TextBox
    Friend WithEvents tb_potsal As TextBox
    Friend WithEvents tb_jamsostekPot As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents tb_jamsostek As TextBox
    Friend WithEvents tb_bpjs As TextBox
    Friend WithEvents tb_otwages As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tb_ot As TextBox
    Friend WithEvents tb_attendance As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents tb_basicSal As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_posisi As TextBox
    Friend WithEvents b_showall As Button
    Friend WithEvents KolomPayroll_NIK As DataGridViewTextBoxColumn
    Friend WithEvents KolomPayroll_Nama As DataGridViewTextBoxColumn
    Friend WithEvents KolomPayroll_Posisition As DataGridViewTextBoxColumn
    Friend WithEvents KolomPayroll_Status As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ComboBoxDep As ComboBox
    Friend WithEvents b_export As Button
    Friend WithEvents Label48 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
