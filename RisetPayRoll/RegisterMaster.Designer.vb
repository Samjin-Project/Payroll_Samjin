<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterMaster
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b_search = New System.Windows.Forms.Button()
        Me.b_clear = New System.Windows.Forms.Button()
        Me.dt_masuk = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb_jk = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_department = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tb_emp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.cb_stat = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_empDet = New System.Windows.Forms.TextBox()
        Me.b_cancel = New System.Windows.Forms.Button()
        Me.b_create = New System.Windows.Forms.Button()
        Me.b_save = New System.Windows.Forms.Button()
        Me.b_edit = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_aktif = New System.Windows.Forms.ComboBox()
        Me.cb_bpjs = New System.Windows.Forms.ComboBox()
        Me.tb_salary = New System.Windows.Forms.TextBox()
        Me.tb_pend = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_pob = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_nama = New System.Windows.Forms.TextBox()
        Me.cb_createJK = New System.Windows.Forms.ComboBox()
        Me.dt_createMasuk = New System.Windows.Forms.DateTimePicker()
        Me.dt_lahir = New System.Windows.Forms.DateTimePicker()
        Me.dt_createKeluar = New System.Windows.Forms.DateTimePicker()
        Me.DGV_ReviewMaster = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total_data = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.OpenFileDialogImport = New System.Windows.Forms.OpenFileDialog()
        Me.cb_createPosisi = New System.Windows.Forms.ComboBox()
        Me.Kolom_Nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_ReviewMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 134)
        Me.Panel1.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(355, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Detail Data Karyawan"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(556, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 76)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Upload Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload From Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.b_search)
        Me.GroupBox1.Controls.Add(Me.b_clear)
        Me.GroupBox1.Controls.Add(Me.dt_masuk)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cb_jk)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cb_department)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 79)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'b_search
        '
        Me.b_search.Location = New System.Drawing.Point(343, 51)
        Me.b_search.Name = "b_search"
        Me.b_search.Size = New System.Drawing.Size(57, 23)
        Me.b_search.TabIndex = 32
        Me.b_search.Text = "Search"
        Me.b_search.UseVisualStyleBackColor = True
        '
        'b_clear
        '
        Me.b_clear.Location = New System.Drawing.Point(446, 51)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(57, 23)
        Me.b_clear.TabIndex = 31
        Me.b_clear.Text = "Clear"
        Me.b_clear.UseVisualStyleBackColor = True
        '
        'dt_masuk
        '
        Me.dt_masuk.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_masuk.Location = New System.Drawing.Point(348, 23)
        Me.dt_masuk.Name = "dt_masuk"
        Me.dt_masuk.Size = New System.Drawing.Size(155, 20)
        Me.dt_masuk.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(267, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Tanggal Masuk"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Jenis Kelamin"
        '
        'cb_jk
        '
        Me.cb_jk.FormattingEnabled = True
        Me.cb_jk.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cb_jk.Location = New System.Drawing.Point(97, 48)
        Me.cb_jk.Name = "cb_jk"
        Me.cb_jk.Size = New System.Drawing.Size(155, 21)
        Me.cb_jk.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Department"
        '
        'cb_department
        '
        Me.cb_department.FormattingEnabled = True
        Me.cb_department.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_department.Location = New System.Drawing.Point(97, 21)
        Me.cb_department.Name = "cb_department"
        Me.cb_department.Size = New System.Drawing.Size(155, 21)
        Me.cb_department.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Controls.Add(Me.tb_emp)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(4, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(289, 26)
        Me.Panel3.TabIndex = 15
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
        Me.Label12.Location = New System.Drawing.Point(79, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Emp No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-3, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Find"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cb_dep)
        Me.Panel2.Controls.Add(Me.cb_createPosisi)
        Me.Panel2.Controls.Add(Me.cb_stat)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.tb_empDet)
        Me.Panel2.Controls.Add(Me.b_cancel)
        Me.Panel2.Controls.Add(Me.b_create)
        Me.Panel2.Controls.Add(Me.b_save)
        Me.Panel2.Controls.Add(Me.b_edit)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cb_aktif)
        Me.Panel2.Controls.Add(Me.cb_bpjs)
        Me.Panel2.Controls.Add(Me.tb_salary)
        Me.Panel2.Controls.Add(Me.tb_pend)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tb_pob)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tb_nama)
        Me.Panel2.Controls.Add(Me.cb_createJK)
        Me.Panel2.Controls.Add(Me.dt_createMasuk)
        Me.Panel2.Controls.Add(Me.dt_lahir)
        Me.Panel2.Controls.Add(Me.dt_createKeluar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(354, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 433)
        Me.Panel2.TabIndex = 2
        '
        'cb_dep
        '
        Me.cb_dep.AutoCompleteCustomSource.AddRange(New String() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_dep.BackColor = System.Drawing.Color.Cyan
        Me.cb_dep.Enabled = False
        Me.cb_dep.FormattingEnabled = True
        Me.cb_dep.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cb_dep.Location = New System.Drawing.Point(396, 152)
        Me.cb_dep.Name = "cb_dep"
        Me.cb_dep.Size = New System.Drawing.Size(110, 21)
        Me.cb_dep.TabIndex = 45
        '
        'cb_stat
        '
        Me.cb_stat.BackColor = System.Drawing.Color.Cyan
        Me.cb_stat.Enabled = False
        Me.cb_stat.FormattingEnabled = True
        Me.cb_stat.Items.AddRange(New Object() {"Magang"})
        Me.cb_stat.Location = New System.Drawing.Point(396, 191)
        Me.cb_stat.Name = "cb_stat"
        Me.cb_stat.Size = New System.Drawing.Size(110, 21)
        Me.cb_stat.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(311, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(79, 13)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Tanggal Keluar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(25, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 13)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "Tanggal Masuk"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(53, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Emp. No"
        '
        'tb_empDet
        '
        Me.tb_empDet.BackColor = System.Drawing.Color.Aqua
        Me.tb_empDet.Location = New System.Drawing.Point(113, 10)
        Me.tb_empDet.Name = "tb_empDet"
        Me.tb_empDet.ReadOnly = True
        Me.tb_empDet.Size = New System.Drawing.Size(110, 20)
        Me.tb_empDet.TabIndex = 32
        '
        'b_cancel
        '
        Me.b_cancel.Location = New System.Drawing.Point(547, 390)
        Me.b_cancel.Name = "b_cancel"
        Me.b_cancel.Size = New System.Drawing.Size(61, 29)
        Me.b_cancel.TabIndex = 31
        Me.b_cancel.Text = "Cancel"
        Me.b_cancel.UseVisualStyleBackColor = True
        '
        'b_create
        '
        Me.b_create.Location = New System.Drawing.Point(34, 390)
        Me.b_create.Name = "b_create"
        Me.b_create.Size = New System.Drawing.Size(61, 29)
        Me.b_create.TabIndex = 30
        Me.b_create.Text = "Create"
        Me.b_create.UseVisualStyleBackColor = True
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(441, 390)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(65, 29)
        Me.b_save.TabIndex = 29
        Me.b_save.Text = "Save"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'b_edit
        '
        Me.b_edit.Location = New System.Drawing.Point(135, 390)
        Me.b_edit.Name = "b_edit"
        Me.b_edit.Size = New System.Drawing.Size(61, 29)
        Me.b_edit.TabIndex = 28
        Me.b_edit.Text = "Edit"
        Me.b_edit.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(359, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(28, 13)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Aktif"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(73, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "BPJS"
        '
        'cb_aktif
        '
        Me.cb_aktif.BackColor = System.Drawing.Color.Cyan
        Me.cb_aktif.Enabled = False
        Me.cb_aktif.FormattingEnabled = True
        Me.cb_aktif.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.cb_aktif.Location = New System.Drawing.Point(396, 271)
        Me.cb_aktif.Name = "cb_aktif"
        Me.cb_aktif.Size = New System.Drawing.Size(110, 21)
        Me.cb_aktif.TabIndex = 18
        '
        'cb_bpjs
        '
        Me.cb_bpjs.BackColor = System.Drawing.Color.Cyan
        Me.cb_bpjs.Enabled = False
        Me.cb_bpjs.FormattingEnabled = True
        Me.cb_bpjs.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.cb_bpjs.Location = New System.Drawing.Point(113, 270)
        Me.cb_bpjs.Name = "cb_bpjs"
        Me.cb_bpjs.Size = New System.Drawing.Size(110, 21)
        Me.cb_bpjs.TabIndex = 17
        '
        'tb_salary
        '
        Me.tb_salary.BackColor = System.Drawing.Color.Aqua
        Me.tb_salary.Location = New System.Drawing.Point(396, 233)
        Me.tb_salary.Name = "tb_salary"
        Me.tb_salary.ReadOnly = True
        Me.tb_salary.Size = New System.Drawing.Size(110, 20)
        Me.tb_salary.TabIndex = 16
        '
        'tb_pend
        '
        Me.tb_pend.BackColor = System.Drawing.Color.Aqua
        Me.tb_pend.Location = New System.Drawing.Point(112, 233)
        Me.tb_pend.Name = "tb_pend"
        Me.tb_pend.ReadOnly = True
        Me.tb_pend.Size = New System.Drawing.Size(110, 20)
        Me.tb_pend.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Salary"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(319, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Departement"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pendidikan Terakhir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Status Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(353, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Posisi"
        '
        'tb_pob
        '
        Me.tb_pob.BackColor = System.Drawing.Color.Aqua
        Me.tb_pob.Location = New System.Drawing.Point(113, 155)
        Me.tb_pob.Name = "tb_pob"
        Me.tb_pob.ReadOnly = True
        Me.tb_pob.Size = New System.Drawing.Size(110, 20)
        Me.tb_pob.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Lengkap"
        '
        'tb_nama
        '
        Me.tb_nama.BackColor = System.Drawing.Color.Aqua
        Me.tb_nama.Location = New System.Drawing.Point(396, 10)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.ReadOnly = True
        Me.tb_nama.Size = New System.Drawing.Size(150, 20)
        Me.tb_nama.TabIndex = 0
        '
        'cb_createJK
        '
        Me.cb_createJK.BackColor = System.Drawing.Color.Cyan
        Me.cb_createJK.Enabled = False
        Me.cb_createJK.FormattingEnabled = True
        Me.cb_createJK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cb_createJK.Location = New System.Drawing.Point(112, 113)
        Me.cb_createJK.Name = "cb_createJK"
        Me.cb_createJK.Size = New System.Drawing.Size(110, 21)
        Me.cb_createJK.TabIndex = 38
        '
        'dt_createMasuk
        '
        Me.dt_createMasuk.CustomFormat = "dd/MM/yyyy"
        Me.dt_createMasuk.Enabled = False
        Me.dt_createMasuk.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_createMasuk.Location = New System.Drawing.Point(112, 73)
        Me.dt_createMasuk.Name = "dt_createMasuk"
        Me.dt_createMasuk.Size = New System.Drawing.Size(110, 20)
        Me.dt_createMasuk.TabIndex = 32
        '
        'dt_lahir
        '
        Me.dt_lahir.CustomFormat = "dd/MM/yyyy"
        Me.dt_lahir.Enabled = False
        Me.dt_lahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_lahir.Location = New System.Drawing.Point(113, 194)
        Me.dt_lahir.Name = "dt_lahir"
        Me.dt_lahir.Size = New System.Drawing.Size(110, 20)
        Me.dt_lahir.TabIndex = 39
        '
        'dt_createKeluar
        '
        Me.dt_createKeluar.CustomFormat = "dd/MM/yyyy"
        Me.dt_createKeluar.Enabled = False
        Me.dt_createKeluar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_createKeluar.Location = New System.Drawing.Point(396, 73)
        Me.dt_createKeluar.Name = "dt_createKeluar"
        Me.dt_createKeluar.Size = New System.Drawing.Size(110, 20)
        Me.dt_createKeluar.TabIndex = 42
        '
        'DGV_ReviewMaster
        '
        Me.DGV_ReviewMaster.AllowUserToAddRows = False
        Me.DGV_ReviewMaster.AllowUserToDeleteRows = False
        Me.DGV_ReviewMaster.AllowUserToResizeColumns = False
        Me.DGV_ReviewMaster.AllowUserToResizeRows = False
        Me.DGV_ReviewMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ReviewMaster.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ReviewMaster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_ReviewMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ReviewMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kolom_Nik, Me.Kolom_Nama, Me.kolom_dep})
        Me.DGV_ReviewMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ReviewMaster.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_ReviewMaster.Location = New System.Drawing.Point(0, 0)
        Me.DGV_ReviewMaster.MultiSelect = False
        Me.DGV_ReviewMaster.Name = "DGV_ReviewMaster"
        Me.DGV_ReviewMaster.ReadOnly = True
        Me.DGV_ReviewMaster.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_ReviewMaster.RowHeadersWidth = 50
        Me.DGV_ReviewMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_ReviewMaster.Size = New System.Drawing.Size(350, 429)
        Me.DGV_ReviewMaster.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.DGV_ReviewMaster)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 134)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(354, 433)
        Me.Panel4.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.total_data)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 403)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(350, 26)
        Me.Panel5.TabIndex = 16
        '
        'total_data
        '
        Me.total_data.AutoSize = True
        Me.total_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.total_data.Location = New System.Drawing.Point(145, 6)
        Me.total_data.Name = "total_data"
        Me.total_data.Size = New System.Drawing.Size(0, 13)
        Me.total_data.TabIndex = 17
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
        'OpenFileDialogImport
        '
        Me.OpenFileDialogImport.FileName = "OpenFileDialog1"
        '
        'cb_createPosisi
        '
        Me.cb_createPosisi.BackColor = System.Drawing.Color.Cyan
        Me.cb_createPosisi.Enabled = False
        Me.cb_createPosisi.FormattingEnabled = True
        Me.cb_createPosisi.Items.AddRange(New Object() {"Operator"})
        Me.cb_createPosisi.Location = New System.Drawing.Point(396, 113)
        Me.cb_createPosisi.Name = "cb_createPosisi"
        Me.cb_createPosisi.Size = New System.Drawing.Size(110, 21)
        Me.cb_createPosisi.TabIndex = 44
        '
        'Kolom_Nik
        '
        Me.Kolom_Nik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Nik.DefaultCellStyle = DataGridViewCellStyle1
        Me.Kolom_Nik.HeaderText = "NIK"
        Me.Kolom_Nik.Name = "Kolom_Nik"
        Me.Kolom_Nik.ReadOnly = True
        Me.Kolom_Nik.Width = 50
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.HeaderText = "Nama Lengkap"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        '
        'kolom_dep
        '
        Me.kolom_dep.HeaderText = "Department"
        Me.kolom_dep.Name = "kolom_dep"
        Me.kolom_dep.ReadOnly = True
        '
        'RegisterMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(992, 567)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RegisterMaster"
        Me.Text = "RegisterMaster"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGV_ReviewMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tb_nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_pob As TextBox
    Friend WithEvents tb_salary As TextBox
    Friend WithEvents tb_pend As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dt_masuk As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cb_jk As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cb_department As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tb_emp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents DGV_ReviewMaster As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents OpenFileDialogImport As OpenFileDialog
    Friend WithEvents total_data As Label
    Friend WithEvents b_clear As Button
    Friend WithEvents b_save As Button
    Friend WithEvents b_edit As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents b_create As Button
    Friend WithEvents b_cancel As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_empDet As TextBox
    Friend WithEvents cb_aktif As ComboBox
    Friend WithEvents cb_bpjs As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cb_createJK As ComboBox
    Friend WithEvents dt_createMasuk As DateTimePicker
    Friend WithEvents dt_lahir As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents dt_createKeluar As DateTimePicker
    Friend WithEvents cb_stat As ComboBox
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents b_search As Button
    Friend WithEvents cb_createPosisi As ComboBox
    Friend WithEvents Kolom_Nik As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents kolom_dep As DataGridViewTextBoxColumn
End Class
