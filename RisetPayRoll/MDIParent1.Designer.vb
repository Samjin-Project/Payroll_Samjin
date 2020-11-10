<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Register Master")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Approval Vacation")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Daily Attendance")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compute Payroll")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Upload Finger Data")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("List No Check")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("User", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finger Modify")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Register Vacation")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Daily Attendance")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Admin", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Attendance App", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode11})
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelMdi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBarMdi = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxDep = New System.Windows.Forms.Label()
        Me.TextBoxUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.OptionsToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(114, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelMdi, Me.ToolStripProgressBarMdi})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabelMdi
        '
        Me.ToolStripStatusLabelMdi.Name = "ToolStripStatusLabelMdi"
        Me.ToolStripStatusLabelMdi.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabelMdi.Text = "Status"
        '
        'ToolStripProgressBarMdi
        '
        Me.ToolStripProgressBarMdi.Name = "ToolStripProgressBarMdi"
        Me.ToolStripProgressBarMdi.Size = New System.Drawing.Size(100, 16)
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageKey = "(default)"
        TreeNode1.Name = "RegisterMasterNode"
        TreeNode1.Text = "Register Master"
        TreeNode2.Name = "ApprovalVacationNode"
        TreeNode2.Text = "Approval Vacation"
        TreeNode3.Name = "DailyAttendanceNode"
        TreeNode3.Text = "Daily Attendance"
        TreeNode4.Name = "ComputePayrollNode"
        TreeNode4.Text = "Compute Payroll"
        TreeNode5.Name = "UploadFingerDataNode"
        TreeNode5.Text = "Upload Finger Data"
        TreeNode6.Name = "ListNoCheckNode"
        TreeNode6.Text = "List No Check"
        TreeNode7.Name = "AprovalChild"
        TreeNode7.Text = "User"
        TreeNode7.ToolTipText = "Admin"
        TreeNode8.Name = "FingerModifyNode"
        TreeNode8.Text = "Finger Modify"
        TreeNode9.Name = "RegisterVacationNode"
        TreeNode9.Text = "Register Vacation"
        TreeNode10.Name = "ViewDailyAttendanceNode"
        TreeNode10.Text = "View Daily Attendance"
        TreeNode11.Name = "AdminChild"
        TreeNode11.Text = "Admin"
        TreeNode12.Name = "ParentTree"
        TreeNode12.Text = "Attendance App"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode12})
        Me.TreeView1.Size = New System.Drawing.Size(200, 1200)
        Me.TreeView1.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.TextBoxDep)
        Me.Panel1.Controls.Add(Me.TextBoxUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 547)
        Me.Panel1.MaximumSize = New System.Drawing.Size(200, 68)
        Me.Panel1.MinimumSize = New System.Drawing.Size(200, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 68)
        Me.Panel1.TabIndex = 15
        '
        'TextBoxDep
        '
        Me.TextBoxDep.AutoSize = True
        Me.TextBoxDep.Location = New System.Drawing.Point(53, 42)
        Me.TextBoxDep.Name = "TextBoxDep"
        Me.TextBoxDep.Size = New System.Drawing.Size(0, 13)
        Me.TextBoxDep.TabIndex = 20
        '
        'TextBoxUser
        '
        Me.TextBoxUser.AutoSize = True
        Me.TextBoxUser.Location = New System.Drawing.Point(53, 16)
        Me.TextBoxUser.Name = "TextBoxUser"
        Me.TextBoxUser.Size = New System.Drawing.Size(0, 13)
        Me.TextBoxUser.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Dep :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "User :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 615)
        Me.Panel2.TabIndex = 16
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1284, 661)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "MDIParent1"
        Me.Text = "Payroll System Application 1.0.1.1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabelMdi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxDep As Label
    Friend WithEvents TextBoxUser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripProgressBarMdi As ToolStripProgressBar
End Class
