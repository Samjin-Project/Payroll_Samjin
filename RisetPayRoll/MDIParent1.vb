Imports System.Windows.Forms
Imports System.Linq ' need to add 

Public Class MDIParent1
    Dim widthForm As Integer
    Dim heightForm As Integer
    Public Shared JenisDepartement As String() = {"PCBA", "RUBBER FORMING", "MOULDING", "ASSEMBLING", "PURCHASING", "SMD"}
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        'DailyAttendance()
    End Sub

    Public Sub DailyAttendanceForm()
        If Application.OpenForms().OfType(Of DailyAttendance).Any Then
        Else
            Dim ChildForm As New DailyAttendance()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.Control
                .ClientSize = New System.Drawing.Size(1200, 650)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "DailyAttendance"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Daily Attendance"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If
    End Sub

    Public Sub ViewDailyAttendanceForm()
        If Application.OpenForms().OfType(Of ViewDailyAttendance).Any Then
        Else
            Dim ChildForm As New ViewDailyAttendance()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.Control
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "ViewDailyAttendance"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "View Daily Attendance"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
        End If
    End Sub

    Public Sub ComputePayrollForm()
        If Application.OpenForms().OfType(Of ComputePayroll).Any Then
        Else
            Dim ChildForm As New ComputePayroll()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.Control
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "PayrollView"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Payroll View"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
        End If
    End Sub

    Public Sub FingerModifyForm()
        If Application.OpenForms().OfType(Of FingerModify).Any Then
        Else
            Dim ChildForm As New FingerModify()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "FingerModify"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Finger Modify"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
                Console.WriteLine("New Form Raised")
            End With
        End If
    End Sub
    Public Sub RegisterVacationForm()
        If Application.OpenForms().OfType(Of RegisterVacation).Any Then
        Else
            Dim ChildForm As New RegisterVacation()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "RegisterVacation"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Register Vacation"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If
    End Sub
    Public Sub UploadFingerDataForm()
        If Application.OpenForms().OfType(Of UploadFingerData).Any Then
        Else
            Dim ChildForm As New UploadFingerData()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "UploadFingerData"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Upload Finger Data"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If
    End Sub
    Public Sub RegisterMasterForm()
        If Application.OpenForms().OfType(Of RegisterMaster).Any Then
        Else
            Dim ChildForm As New RegisterMaster()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(1200, 650)
                'ChildForm.ClientSize = New System.Drawing.Size(1100, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "RegisterMaster"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Register Master"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If
    End Sub
    Public Sub ApprovalVacationForm()
        If Application.OpenForms().OfType(Of ApprovalVacation).Any Then
        Else
            Dim ChildForm As New ApprovalVacation()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(heightForm, widthForm)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "ApprovalVacation"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "Approval Vacation"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If

    End Sub
    Public Sub ListNoCheckForm()
        If Application.OpenForms().OfType(Of ListNoCheck).Any Then
        Else
            Dim ChildForm As New ListNoCheck()
            With ChildForm
                .MdiParent = Me
                .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
                .BackColor = System.Drawing.SystemColors.ControlDark
                .ClientSize = New System.Drawing.Size(900, 575)
                .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
                .Location = New System.Drawing.Point(0, 0)
                .MaximizeBox = False
                .MinimizeBox = False
                .Name = "ListNoCheck"
                .StartPosition = System.Windows.Forms.FormStartPosition.Manual
                .TopMost = True
                .WindowState = System.Windows.Forms.FormWindowState.Normal
                .Text = "List No Check"
                .Anchor = AnchorStyles.Top And AnchorStyles.Left
                .Show()
            End With
            Console.WriteLine("New Form Raised")
        End If

    End Sub
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Login.Close()
        Console.WriteLine("Status Ceklist : " + My.Settings.StatusLogin.ToString)
        Dim QueryAkun As String = $"SELECT * FROM `user_admin` WHERE `Username` = '{My.Settings.User}'"
        Dim DBAkun As DataBaseClass = New DataBaseClass
        Dim AkunData As DataSet = DBAkun.downloadDB(QueryAkun)
        Me.WindowState = FormWindowState.Maximized
        My.Settings.NamaUser = AkunData.Tables(0).Rows(0).Item(2)
        My.Settings.StatusUser = AkunData.Tables(0).Rows(0).Item(3)
        My.Settings.Departement = AkunData.Tables(0).Rows(0).Item(4)
        My.Settings.Save()
        TextBoxUser.Text = My.Settings.User
        TextBoxDep.Text = My.Settings.Departement

        SettingRasioScreen()
        Console.WriteLine(My.Settings.StatusUser)
        If My.Settings.StatusUser = "admin" Then
            TreeView1.Nodes(0).Nodes(0).Remove()
        End If


    End Sub

    Private Sub SettingRasioScreen()
        Console.WriteLine($"Resolution {My.Settings.Reso_Height} x {My.Settings.Reso_Width}")
        My.Settings.Reso_Height = Screen.PrimaryScreen.Bounds.Height
        My.Settings.Reso_Width = Screen.PrimaryScreen.Bounds.Width
        My.Settings.Save()
        Dim rasioFit As Boolean = (Screen.PrimaryScreen.Bounds.Height > 720 And Screen.PrimaryScreen.Bounds.Width > 1280)
        Console.WriteLine($"RasioFit {rasioFit}")
        If rasioFit Then
            widthForm = 900
            heightForm = 1700
        Else
            widthForm = 575
            heightForm = 1070
        End If
        Console.WriteLine($"Resolution Form {widthForm} x {heightForm}")
    End Sub

    Private Sub TreeViewMenu(ByVal NamePicked As String)
        Dim tempNamePicked As String = NamePicked.Replace(" ", "")
        For Each f As Form In Me.MdiChildren
            If f.Name <> tempNamePicked Then
                f.Close()
            End If
        Next
        Call CallByName(Me, tempNamePicked + "Form", vbMethod)
    End Sub
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        'Console.WriteLine(e.Node.Name.ToString)
        If e.Node.Name.ToString.Contains("Node") Then
            TreeViewMenu(e.Node.Text)
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click

        My.Settings.StatusLogin = False
        My.Settings.NamaUser = String.Empty
        My.Settings.Departement = String.Empty
        My.Settings.Save()
        LoginForm.Show()
        Me.Close()

    End Sub

    'reza supriyatna
End Class
