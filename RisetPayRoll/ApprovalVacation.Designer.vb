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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_ApprovalVacation = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.kolom_Aproval = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Kolom_Approver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_NamaKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_VacCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_RequestDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_ApprovalVacation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ApprovalVacation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_ApprovalVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_ApprovalVacation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_Aproval, Me.Kolom_Approver, Me.Kolom_NamaKaryawan, Me.Kolom_VacCode, Me.Kolom_StartDate, Me.Kolom_EndDate, Me.Kolom_RequestDate, Me.Kolom_Tel})
        Me.DGV_ApprovalVacation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ApprovalVacation.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_ApprovalVacation.Location = New System.Drawing.Point(0, 0)
        Me.DGV_ApprovalVacation.MultiSelect = False
        Me.DGV_ApprovalVacation.Name = "DGV_ApprovalVacation"
        Me.DGV_ApprovalVacation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_ApprovalVacation.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_ApprovalVacation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.DGV_ApprovalVacation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_ApprovalVacation.Size = New System.Drawing.Size(1084, 469)
        Me.DGV_ApprovalVacation.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1084, 25)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Departement"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Rubber Forming", "Rubber Printing", "Assembly", "Pcba"})
        Me.ComboBox3.Location = New System.Drawing.Point(353, 11)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox3.TabIndex = 55
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Start Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.RadioButton4)
        Me.Panel3.Controls.Add(Me.RadioButton3)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.ComboBox3)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1084, 42)
        Me.Panel3.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "since"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(887, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 59
        Me.CheckBox1.Text = "Full Aproval"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(638, 15)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(84, 17)
        Me.RadioButton4.TabIndex = 58
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Unapproved"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(550, 14)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(67, 17)
        Me.RadioButton3.TabIndex = 57
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Approval"
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Kolom_Approver.DefaultCellStyle = DataGridViewCellStyle2
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
        'Kolom_VacCode
        '
        Me.Kolom_VacCode.HeaderText = "Vacation Code"
        Me.Kolom_VacCode.Name = "Kolom_VacCode"
        Me.Kolom_VacCode.ReadOnly = True
        Me.Kolom_VacCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_StartDate
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Kolom_StartDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.Kolom_StartDate.HeaderText = "Start Date"
        Me.Kolom_StartDate.Name = "Kolom_StartDate"
        Me.Kolom_StartDate.ReadOnly = True
        Me.Kolom_StartDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_EndDate
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Kolom_EndDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.Kolom_EndDate.HeaderText = "End Date"
        Me.Kolom_EndDate.Name = "Kolom_EndDate"
        Me.Kolom_EndDate.ReadOnly = True
        Me.Kolom_EndDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kolom_RequestDate
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Kolom_RequestDate.DefaultCellStyle = DataGridViewCellStyle5
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGV_ApprovalVacation As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents kolom_Aproval As DataGridViewComboBoxColumn
    Friend WithEvents Kolom_Approver As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_NamaKaryawan As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_VacCode As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_StartDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_RequestDate As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Tel As DataGridViewTextBoxColumn
End Class
