<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
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
        Me.DGV_date_Holiday = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.b_save = New System.Windows.Forms.Button()
        Me.tb_emp = New System.Windows.Forms.TextBox()
        Me.kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Admision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tb_holtype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV_date_Holiday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_date_Holiday
        '
        Me.DGV_date_Holiday.AllowUserToAddRows = False
        Me.DGV_date_Holiday.AllowUserToDeleteRows = False
        Me.DGV_date_Holiday.AllowUserToResizeColumns = False
        Me.DGV_date_Holiday.AllowUserToResizeRows = False
        Me.DGV_date_Holiday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_date_Holiday.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_date_Holiday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_date_Holiday.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_emp, Me.Kolom_Nama, Me.Kolom_Admision})
        Me.DGV_date_Holiday.Dock = System.Windows.Forms.DockStyle.Left
        Me.DGV_date_Holiday.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_date_Holiday.Location = New System.Drawing.Point(0, 0)
        Me.DGV_date_Holiday.MultiSelect = False
        Me.DGV_date_Holiday.Name = "DGV_date_Holiday"
        Me.DGV_date_Holiday.ReadOnly = True
        Me.DGV_date_Holiday.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_date_Holiday.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DGV_date_Holiday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_date_Holiday.Size = New System.Drawing.Size(396, 450)
        Me.DGV_date_Holiday.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.b_save)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.tb_holtype)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.tb_emp)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(393, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 450)
        Me.Panel4.TabIndex = 22
        '
        'b_save
        '
        Me.b_save.Location = New System.Drawing.Point(40, 122)
        Me.b_save.Name = "b_save"
        Me.b_save.Size = New System.Drawing.Size(75, 23)
        Me.b_save.TabIndex = 47
        Me.b_save.Text = "Add"
        Me.b_save.UseVisualStyleBackColor = True
        '
        'tb_emp
        '
        Me.tb_emp.BackColor = System.Drawing.Color.Aqua
        Me.tb_emp.Location = New System.Drawing.Point(97, 26)
        Me.tb_emp.Name = "tb_emp"
        Me.tb_emp.Size = New System.Drawing.Size(110, 20)
        Me.tb_emp.TabIndex = 0
        '
        'kolom_emp
        '
        Me.kolom_emp.FillWeight = 118.4005!
        Me.kolom_emp.HeaderText = "Nama Libur"
        Me.kolom_emp.Name = "kolom_emp"
        Me.kolom_emp.ReadOnly = True
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.FillWeight = 83.7741!
        Me.Kolom_Nama.HeaderText = "Hari"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        '
        'Kolom_Admision
        '
        Me.Kolom_Admision.FillWeight = 127.8953!
        Me.Kolom_Admision.HeaderText = "Tanggal"
        Me.Kolom_Admision.Name = "Kolom_Admision"
        Me.Kolom_Admision.ReadOnly = True
        '
        'tb_holtype
        '
        Me.tb_holtype.BackColor = System.Drawing.Color.Aqua
        Me.tb_holtype.Location = New System.Drawing.Point(97, 63)
        Me.tb_holtype.Name = "tb_holtype"
        Me.tb_holtype.Size = New System.Drawing.Size(110, 20)
        Me.tb_holtype.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tanggal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.DGV_date_Holiday)
        Me.Name = "Setting"
        Me.Text = "Tanggal Libur Tahunan"
        CType(Me.DGV_date_Holiday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_date_Holiday As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents b_save As Button
    Friend WithEvents tb_emp As TextBox
    Friend WithEvents kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Admision As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_holtype As TextBox
    Friend WithEvents Label1 As Label
End Class
