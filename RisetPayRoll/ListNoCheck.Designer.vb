<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListNoCheck
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
        Me.DGV_ListCheck = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.b_delete = New System.Windows.Forms.Button()
        Me.b_showall = New System.Windows.Forms.Button()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nik = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dt_end = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dt_start = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateFinger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_ListCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_ListCheck
        '
        Me.DGV_ListCheck.AllowUserToAddRows = False
        Me.DGV_ListCheck.AllowUserToDeleteRows = False
        Me.DGV_ListCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_ListCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ListCheck.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ListCheck.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ListCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ListCheck.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_emp, Me.Kolom_Nama, Me.kolom_department, Me.DateFinger})
        Me.DGV_ListCheck.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_ListCheck.Location = New System.Drawing.Point(0, 57)
        Me.DGV_ListCheck.MultiSelect = False
        Me.DGV_ListCheck.Name = "DGV_ListCheck"
        Me.DGV_ListCheck.ReadOnly = True
        Me.DGV_ListCheck.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_ListCheck.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_ListCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_ListCheck.Size = New System.Drawing.Size(636, 410)
        Me.DGV_ListCheck.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.b_delete)
        Me.Panel2.Controls.Add(Me.b_showall)
        Me.Panel2.Controls.Add(Me.cb_dep)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.nik)
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
        Me.Panel2.Size = New System.Drawing.Size(636, 57)
        Me.Panel2.TabIndex = 21
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
        'b_showall
        '
        Me.b_showall.Location = New System.Drawing.Point(555, 3)
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
        Me.cb_dep.Text = "PCBA"
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
        'nik
        '
        Me.nik.Location = New System.Drawing.Point(414, 29)
        Me.nik.Name = "nik"
        Me.nik.Size = New System.Drawing.Size(125, 20)
        Me.nik.TabIndex = 8
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
        'kolom_emp
        '
        Me.kolom_emp.FillWeight = 70.0!
        Me.kolom_emp.HeaderText = "Emp No."
        Me.kolom_emp.Name = "kolom_emp"
        Me.kolom_emp.ReadOnly = True
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.FillWeight = 165.0399!
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        '
        'kolom_department
        '
        Me.kolom_department.FillWeight = 90.32571!
        Me.kolom_department.HeaderText = "Department"
        Me.kolom_department.Name = "kolom_department"
        Me.kolom_department.ReadOnly = True
        '
        'DateFinger
        '
        Me.DateFinger.FillWeight = 116.6964!
        Me.DateFinger.HeaderText = "Date"
        Me.DateFinger.Name = "DateFinger"
        Me.DateFinger.ReadOnly = True
        '
        'ListNoCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 467)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DGV_ListCheck)
        Me.Name = "ListNoCheck"
        Me.Text = "List No Check"
        CType(Me.DGV_ListCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_ListCheck As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents b_delete As Button
    Friend WithEvents b_showall As Button
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents nik As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dt_end As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents dt_start As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents kolom_department As DataGridViewTextBoxColumn
    Friend WithEvents DateFinger As DataGridViewTextBoxColumn
End Class
