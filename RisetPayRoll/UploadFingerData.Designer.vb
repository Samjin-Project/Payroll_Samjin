<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadFingerData
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.b_filter = New System.Windows.Forms.Button()
        Me.b_showall = New System.Windows.Forms.Button()
        Me.dt_upfinger = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cb_depfinger = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total_data = New System.Windows.Forms.Label()
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(636, 4)
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
        Me.GroupBox1.Controls.Add(Me.b_filter)
        Me.GroupBox1.Controls.Add(Me.b_showall)
        Me.GroupBox1.Controls.Add(Me.dt_upfinger)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cb_depfinger)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 79)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sorting"
        '
        'b_filter
        '
        Me.b_filter.Location = New System.Drawing.Point(516, 48)
        Me.b_filter.Name = "b_filter"
        Me.b_filter.Size = New System.Drawing.Size(77, 19)
        Me.b_filter.TabIndex = 32
        Me.b_filter.Text = "Search"
        Me.b_filter.UseVisualStyleBackColor = True
        '
        'b_showall
        '
        Me.b_showall.Location = New System.Drawing.Point(516, 19)
        Me.b_showall.Name = "b_showall"
        Me.b_showall.Size = New System.Drawing.Size(77, 19)
        Me.b_showall.TabIndex = 31
        Me.b_showall.Text = "Show All"
        Me.b_showall.UseVisualStyleBackColor = True
        '
        'dt_upfinger
        '
        Me.dt_upfinger.CustomFormat = "dd/MM/yyyy"
        Me.dt_upfinger.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_upfinger.Location = New System.Drawing.Point(337, 49)
        Me.dt_upfinger.Name = "dt_upfinger"
        Me.dt_upfinger.Size = New System.Drawing.Size(155, 20)
        Me.dt_upfinger.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(250, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Tanggal Masuk"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Departement"
        '
        'cb_depfinger
        '
        Me.cb_depfinger.FormattingEnabled = True
        Me.cb_depfinger.Location = New System.Drawing.Point(89, 48)
        Me.cb_depfinger.Name = "cb_depfinger"
        Me.cb_depfinger.Size = New System.Drawing.Size(155, 21)
        Me.cb_depfinger.TabIndex = 23
        Me.cb_depfinger.Text = " "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.StatusStrip1)
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
        Me.Panel5.Controls.Add(Me.total_data)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 344)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(904, 25)
        Me.Panel5.TabIndex = 19
        '
        'total_data
        '
        Me.total_data.AutoSize = True
        Me.total_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.total_data.Location = New System.Drawing.Point(144, 6)
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
        Me.DGV_DataModify.RowHeadersWidth = 60
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_DataModify.Size = New System.Drawing.Size(904, 391)
        Me.DGV_DataModify.TabIndex = 17
        '
        'KolomFinger_Nik
        '
        Me.KolomFinger_Nik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.KolomFinger_Nik.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.KolomFinger_ClockIn.DefaultCellStyle = DataGridViewCellStyle4
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(904, 22)
        Me.StatusStrip1.TabIndex = 25
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
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dt_upfinger As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cb_depfinger As ComboBox
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
    Friend WithEvents b_showall As Button
    Friend WithEvents total_data As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents b_filter As Button
End Class
