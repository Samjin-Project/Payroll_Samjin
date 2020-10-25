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
        Me.DGV_DataModify = New System.Windows.Forms.DataGridView()
        Me.kolom_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kolom_Admision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kolom_department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HolidayType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approval = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reasons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_DataModify
        '
        Me.DGV_DataModify.AllowUserToAddRows = False
        Me.DGV_DataModify.AllowUserToDeleteRows = False
        Me.DGV_DataModify.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGV_DataModify.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_DataModify.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGV_DataModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_DataModify.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kolom_emp, Me.Kolom_Nama, Me.Kolom_Admision, Me.kolom_department, Me.HolidayType, Me.Approval, Me.StartDate, Me.EndDate, Me.Reasons})
        Me.DGV_DataModify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_DataModify.GridColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DGV_DataModify.Location = New System.Drawing.Point(0, 0)
        Me.DGV_DataModify.MultiSelect = False
        Me.DGV_DataModify.Name = "DGV_DataModify"
        Me.DGV_DataModify.ReadOnly = True
        Me.DGV_DataModify.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV_DataModify.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGV_DataModify.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DGV_DataModify.Size = New System.Drawing.Size(800, 450)
        Me.DGV_DataModify.TabIndex = 18
        '
        'kolom_emp
        '
        Me.kolom_emp.FillWeight = 120.0703!
        Me.kolom_emp.HeaderText = "Emp No."
        Me.kolom_emp.Name = "kolom_emp"
        Me.kolom_emp.ReadOnly = True
        Me.kolom_emp.Width = 73
        '
        'Kolom_Nama
        '
        Me.Kolom_Nama.FillWeight = 141.4268!
        Me.Kolom_Nama.HeaderText = "Name"
        Me.Kolom_Nama.Name = "Kolom_Nama"
        Me.Kolom_Nama.ReadOnly = True
        Me.Kolom_Nama.Width = 60
        '
        'Kolom_Admision
        '
        Me.Kolom_Admision.FillWeight = 91.17045!
        Me.Kolom_Admision.HeaderText = "Admision Date"
        Me.Kolom_Admision.Name = "Kolom_Admision"
        Me.Kolom_Admision.ReadOnly = True
        '
        'kolom_department
        '
        Me.kolom_department.FillWeight = 77.40235!
        Me.kolom_department.HeaderText = "Department"
        Me.kolom_department.Name = "kolom_department"
        Me.kolom_department.ReadOnly = True
        Me.kolom_department.Width = 87
        '
        'HolidayType
        '
        Me.HolidayType.HeaderText = "Holiday Type"
        Me.HolidayType.Name = "HolidayType"
        Me.HolidayType.ReadOnly = True
        Me.HolidayType.Width = 94
        '
        'Approval
        '
        Me.Approval.HeaderText = "Approval"
        Me.Approval.Name = "Approval"
        Me.Approval.ReadOnly = True
        Me.Approval.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Approval.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Approval.Width = 74
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Start Date"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.ReadOnly = True
        Me.StartDate.Width = 80
        '
        'EndDate
        '
        Me.EndDate.HeaderText = "End Date"
        Me.EndDate.Name = "EndDate"
        Me.EndDate.ReadOnly = True
        Me.EndDate.Width = 77
        '
        'Reasons
        '
        Me.Reasons.HeaderText = "Reasons"
        Me.Reasons.Name = "Reasons"
        Me.Reasons.ReadOnly = True
        Me.Reasons.Width = 74
        '
        'ListNoCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGV_DataModify)
        Me.Name = "ListNoCheck"
        Me.Text = "List No Check"
        CType(Me.DGV_DataModify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_DataModify As DataGridView
    Friend WithEvents kolom_emp As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Nama As DataGridViewTextBoxColumn
    Friend WithEvents Kolom_Admision As DataGridViewTextBoxColumn
    Friend WithEvents kolom_department As DataGridViewTextBoxColumn
    Friend WithEvents HolidayType As DataGridViewTextBoxColumn
    Friend WithEvents Approval As DataGridViewComboBoxColumn
    Friend WithEvents StartDate As DataGridViewTextBoxColumn
    Friend WithEvents EndDate As DataGridViewTextBoxColumn
    Friend WithEvents Reasons As DataGridViewTextBoxColumn
End Class
