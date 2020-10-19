<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApprovalVacation
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_ApprovalVacation = New System.Windows.Forms.DataGridView()
        Me.kolom_Aproval = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Kolom_Approver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_NamaKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_VacCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_RequestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total_data = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.dt_since = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.b_clear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbAll = New System.Windows.Forms.RadioButton()
        Me.RbUnapproved = New System.Windows.Forms.RadioButton()
        Me.RbApproved = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ApprovalVacation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DGV_ApprovalVacation)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 494)
        Me.Panel1.TabIndex = 19
        '
        'DGV_ApprovalVacation
        '
        Me.DGV_ApprovalVacation.AllowUserToAddRows = False
        Me.DGV_ApprovalVacation.AllowUserToDeleteRows = False
        Me.DGV_ApprovalVacation.AllowUserToResizeColumns = False
        Me.DGV_ApprovalVacation.AllowUserToResizeRows = False
        Me.DGV_ApprovalVacation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_ApprovalVacation.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ApprovalVacation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ApprovalVacation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_ApprovalVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ApprovalVacation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_Aproval, Me.Kolom_Approver, Me.Kolom_NamaKaryawan, Me.kolom_dep, Me.Kolom_VacCode, Me.Kolom_StartDate, Me.Kolom_EndDate, Me.Kolom_RequestDate, Me.Kolom_Tel})
        Me.DGV_ApprovalVacation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ApprovalVacation.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_ApprovalVacation.Location = New System.Drawing.Point(0, 0)
        Me.DGV_ApprovalVacation.MultiSelect = False
        Me.DGV_ApprovalVacation.Name = "DGV_ApprovalVacation"
        Me.DGV_ApprovalVacation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ApprovalVacation.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGV_ApprovalVacation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DGV_ApprovalVacation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ApprovalVacation.Size = New System.Drawing.Size(1084, 469)
        Me.DGV_ApprovalVacation.TabIndex = 17
        '
        'kolom_Aproval
        '
        Me.kolom_Aproval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.kolom_Aproval.HeaderText = "Aproval Y/N"
        Me.kolom_Aproval.Items.AddRange(New Object() {"Yes", "No"})
        Me.kolom_Aproval.Name = "kolom_Aproval"
        Me.kolom_Aproval.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.kolom_Aproval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.kolom_Aproval.Width = 91
        '
        'Kolom_Approver
        '
        Me.Kolom_Approver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Approver.DefaultCellStyle = DataGridViewCellStyle8
        Me.Kolom_Approver.HeaderText = "Approver"
        Me.Kolom_Approver.Name = "Kolom_Approver"
        Me.Kolom_Approver.ReadOnly = True
        Me.Kolom_Approver.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Kolom_Approver.Width = 75
        '
        'Kolom_NamaKaryawan
        '
        Me.Kolom_NamaKaryawan.HeaderText = "Nama Karyawan"
        Me.Kolom_NamaKaryawan.Name = "Kolom_NamaKaryawan"
        Me.Kolom_NamaKaryawan.ReadOnly = True
        Me.Kolom_NamaKaryawan.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'kolom_dep
        '
        Me.kolom_dep.HeaderText = "Department"
        Me.kolom_dep.Name = "kolom_dep"
        '
        'Kolom_VacCode
        '
        Me.Kolom_VacCode.HeaderText = "Vacation Code"
        Me.Kolom_VacCode.Name = "Kolom_VacCode"
        Me.Kolom_VacCode.ReadOnly = True
        Me.Kolom_VacCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_StartDate
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Kolom_StartDate.DefaultCellStyle = DataGridViewCellStyle9
        Me.Kolom_StartDate.HeaderText = "Start Date"
        Me.Kolom_StartDate.Name = "Kolom_StartDate"
        Me.Kolom_StartDate.ReadOnly = True
        Me.Kolom_StartDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_EndDate
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Kolom_EndDate.DefaultCellStyle = DataGridViewCellStyle10
        Me.Kolom_EndDate.HeaderText = "End Date"
        Me.Kolom_EndDate.Name = "Kolom_EndDate"
        Me.Kolom_EndDate.ReadOnly = True
        Me.Kolom_EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_RequestDate
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Kolom_RequestDate.DefaultCellStyle = DataGridViewCellStyle11
        Me.Kolom_RequestDate.HeaderText = "Request Date"
        Me.Kolom_RequestDate.Name = "Kolom_RequestDate"
        Me.Kolom_RequestDate.ReadOnly = True
        Me.Kolom_RequestDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_Tel
        '
        Me.Kolom_Tel.HeaderText = "Telephone"
        Me.Kolom_Tel.Name = "Kolom_Tel"
        Me.Kolom_Tel.ReadOnly = True
        Me.Kolom_Tel.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.total_data)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1084, 25)
        Me.Panel5.TabIndex = 19
        '
        'total_data
        '
        Me.total_data.AutoSize = True
        Me.total_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.total_data.Location = New System.Drawing.Point(130, 6)
        Me.total_data.Name = "total_data"
        Me.total_data.Size = New System.Drawing.Size(0, 13)
        Me.total_data.TabIndex = 20
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Departement"
        '
        'cb_dep
        '
        Me.cb_dep.FormattingEnabled = True
        Me.cb_dep.Items.AddRange(New Object() {"PCBA", "RUBBER", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"})
        Me.cb_dep.Location = New System.Drawing.Point(353, 11)
        Me.cb_dep.Name = "cb_dep"
        Me.cb_dep.Size = New System.Drawing.Size(155, 21)
        Me.cb_dep.TabIndex = 55
        '
        'dt_since
        '
        Me.dt_since.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_since.Location = New System.Drawing.Point(66, 11)
        Me.dt_since.Name = "dt_since"
        Me.dt_since.Size = New System.Drawing.Size(98, 20)
        Me.dt_since.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Start Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.b_clear)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.dt_since)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.cb_dep)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 42)
        Me.Panel3.TabIndex = 61
        '
        'b_clear
        '
        Me.b_clear.Location = New System.Drawing.Point(927, 12)
        Me.b_clear.Name = "b_clear"
        Me.b_clear.Size = New System.Drawing.Size(63, 23)
        Me.b_clear.TabIndex = 20
        Me.b_clear.Text = "Clear"
        Me.b_clear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbAll)
        Me.GroupBox1.Controls.Add(Me.RbUnapproved)
        Me.GroupBox1.Controls.Add(Me.RbApproved)
        Me.GroupBox1.Location = New System.Drawing.Point(550, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 36)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Approval"
        '
        'RbAll
        '
        Me.RbAll.AutoSize = True
        Me.RbAll.Checked = True
        Me.RbAll.Location = New System.Drawing.Point(183, 16)
        Me.RbAll.Name = "RbAll"
        Me.RbAll.Size = New System.Drawing.Size(44, 17)
        Me.RbAll.TabIndex = 60
        Me.RbAll.TabStop = True
        Me.RbAll.Text = "ALL"
        Me.RbAll.UseVisualStyleBackColor = True
        '
        'RbUnapproved
        '
        Me.RbUnapproved.AutoSize = True
        Me.RbUnapproved.Location = New System.Drawing.Point(88, 16)
        Me.RbUnapproved.Name = "RbUnapproved"
        Me.RbUnapproved.Size = New System.Drawing.Size(84, 17)
        Me.RbUnapproved.TabIndex = 58
        Me.RbUnapproved.Text = "Unapproved"
        Me.RbUnapproved.UseVisualStyleBackColor = True
        '
        'RbApproved
        '
        Me.RbApproved.AutoSize = True
        Me.RbApproved.Location = New System.Drawing.Point(6, 16)
        Me.RbApproved.Name = "RbApproved"
        Me.RbApproved.Size = New System.Drawing.Size(71, 17)
        Me.RbApproved.TabIndex = 57
        Me.RbApproved.Text = "Approved"
        Me.RbApproved.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(170, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "since"
        '
        'ApprovalVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 536)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "ApprovalVacation"
        Me.Text = "Approval Vacation"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV_ApprovalVacation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGV_ApprovalVacation As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents dt_since As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RbUnapproved As RadioButton
    Friend WithEvents RbApproved As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RbAll As RadioButton
    Friend WithEvents b_clear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents total_data As Label
    Friend WithEvents kolom_Aproval As DataGridViewComboBoxColumn
    Friend WithEvents Kolom_Approver As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_NamaKaryawan As DataGridViewTextBoxColumn
    Friend WithEvents kolom_dep As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_VacCode As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_StartDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_RequestDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Tel As DataGridViewTextBoxColumn
End Class
