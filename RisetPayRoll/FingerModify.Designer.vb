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
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.total = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_dep = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.b_showAll = New System.Windows.Forms.Button()
        Me.b_search = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.b_filter = New System.Windows.Forms.Button()
        Me.dt_filter = New System.Windows.Forms.DateTimePicker()
        Me.rec_time = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dt_day = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_DataModify.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DGV_DataModify.RowHeadersWidth = 30
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGV_DataModify.Size = New System.Drawing.Size(1370, 472)
        Me.DGV_DataModify.TabIndex = 17
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
        Me.Panel5.Controls.Add(Me.total)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 447)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1370, 25)
        Me.Panel5.TabIndex = 19
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.total.Location = New System.Drawing.Point(160, 6)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(0, 13)
        Me.total.TabIndex = 20
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
        Me.cb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        'Me.Label2.AutoSize = True
        'Me.Label2.Location = New System.Drawing.Point(587, 32)
        'Me.Label2.Name = "Label2"
        'Me.Label2.Size = New System.Drawing.Size(67, 13)
        'Me.Label2.TabIndex = 44
        'Me.Label2.Text = "Admin Name"
        '
        'cb_name
        '
        'Me.cb_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        'Me.cb_name.FormattingEnabled = True
        'Me.cb_name.Location = New System.Drawing.Point(660, 29)
        'Me.cb_name.Name = "cb_name"
        'Me.cb_name.Size = New System.Drawing.Size(155, 21)
        'Me.cb_name.TabIndex = 43
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
        Me.cb_dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_dep.FormattingEnabled = True
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
        Me.Panel4.Controls.Add(Me.b_showAll)
        Me.Panel4.Controls.Add(Me.b_search)
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
        Me.Panel4.Controls.Add(Me.Label15)
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
        'b_showAll
        '
        Me.b_showAll.Location = New System.Drawing.Point(490, 66)
        Me.b_showAll.Name = "b_showAll"
        Me.b_showAll.Size = New System.Drawing.Size(75, 23)
        Me.b_showAll.TabIndex = 54
        Me.b_showAll.Text = "Show All"
        Me.b_showAll.UseVisualStyleBackColor = True
        '
        'b_search
        '
        Me.b_search.Location = New System.Drawing.Point(382, 66)
        Me.b_search.Name = "b_search"
        Me.b_search.Size = New System.Drawing.Size(75, 23)
        Me.b_search.TabIndex = 53
        Me.b_search.Text = "Search"
        Me.b_search.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Filter Time"
        '
        'b_filter
        '
        Me.b_filter.Location = New System.Drawing.Point(740, 30)
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
        Me.dt_filter.Location = New System.Drawing.Point(660, 31)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV_DataModify As DataGridView
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_dep As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dt_day As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rec_time As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents b_filter As Button
    Friend WithEvents dt_filter As DateTimePicker
    Friend WithEvents b_search As Button
    Friend WithEvents b_showAll As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents total As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
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
End Class
