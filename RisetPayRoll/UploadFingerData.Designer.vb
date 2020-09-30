<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadFingerData
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.KolomFinger_Nik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_OnDuty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_OffDuty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_ClockIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_ClockOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KolomFinger_Dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialogImport = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 95)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(556, 5)
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
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(527, 79)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sorting"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(354, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(267, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Tanggal Masuk"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Departement"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Rubber Forming", "Rubber Printing", "Assembly", "Pcba"})
        Me.ComboBox1.Location = New System.Drawing.Point(106, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(155, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.DGV_DataModify)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 391)
        Me.Panel2.TabIndex = 19
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 366)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(904, 25)
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
        Me.DGV_DataModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_DataModify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KolomFinger_Nik, Me.KolomFinger_Nama, Me.KolomFinger_Date, Me.Kolom_Shift, Me.KolomFinger_OnDuty, Me.KolomFinger_OffDuty, Me.KolomFinger_ClockIn, Me.KolomFinger_ClockOut, Me.KolomFinger_Dep})
        Me.DGV_DataModify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_DataModify.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_DataModify.Location = New System.Drawing.Point(0, 0)
        Me.DGV_DataModify.MultiSelect = False
        Me.DGV_DataModify.Name = "DGV_DataModify"
        Me.DGV_DataModify.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_DataModify.RowHeadersWidth = 30
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_DataModify.Size = New System.Drawing.Size(904, 391)
        Me.DGV_DataModify.TabIndex = 17
        '
        'KolomFinger_Nik
        '
        Me.KolomFinger_Nik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.KolomFinger_Nik.DefaultCellStyle = DataGridViewCellStyle1
        Me.KolomFinger_Nik.HeaderText = "NIK"
        Me.KolomFinger_Nik.Name = "KolomFinger_Nik"
        Me.KolomFinger_Nik.ReadOnly = True
        Me.KolomFinger_Nik.Width = 50
        '
        'KolomFinger_Nama
        '
        Me.KolomFinger_Nama.HeaderText = "Nama"
        Me.KolomFinger_Nama.Name = "KolomFinger_Nama"
        '
        'KolomFinger_Date
        '
        Me.KolomFinger_Date.HeaderText = "Date"
        Me.KolomFinger_Date.Name = "KolomFinger_Date"
        '
        'Kolom_Shift
        '
        Me.Kolom_Shift.HeaderText = "Shift"
        Me.Kolom_Shift.Name = "Kolom_Shift"
        '
        'KolomFinger_OnDuty
        '
        Me.KolomFinger_OnDuty.HeaderText = "On Duty"
        Me.KolomFinger_OnDuty.Name = "KolomFinger_OnDuty"
        '
        'KolomFinger_OffDuty
        '
        Me.KolomFinger_OffDuty.HeaderText = "Off Duty"
        Me.KolomFinger_OffDuty.Name = "KolomFinger_OffDuty"
        '
        'KolomFinger_ClockIn
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KolomFinger_ClockIn.DefaultCellStyle = DataGridViewCellStyle2
        Me.KolomFinger_ClockIn.HeaderText = "Clock In"
        Me.KolomFinger_ClockIn.Name = "KolomFinger_ClockIn"
        '
        'KolomFinger_ClockOut
        '
        Me.KolomFinger_ClockOut.HeaderText = "Clock Out"
        Me.KolomFinger_ClockOut.Name = "KolomFinger_ClockOut"
        '
        'KolomFinger_Dep
        '
        Me.KolomFinger_Dep.HeaderText = "Departement"
        Me.KolomFinger_Dep.Name = "KolomFinger_Dep"
        '
        'OpenFileDialogImport
        '
        Me.OpenFileDialogImport.FileName = "OpenFileDialog1"
        '
        'UploadFingerData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 486)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UploadFingerData"
        Me.Text = "Upload Finger Data"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGV_DataModify As DataGridView
    Friend WithEvents KolomFinger_Nik As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_Nama As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_Date As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Shift As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_OnDuty As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_OffDuty As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_ClockIn As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_ClockOut As DataGridViewTextBoxColumn
    Friend WithEvents KolomFinger_Dep As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialogImport As OpenFileDialog
End Class
