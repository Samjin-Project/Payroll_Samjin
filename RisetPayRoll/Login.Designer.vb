<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.box_user = New System.Windows.Forms.TextBox()
        Me.box_pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBoxLogin = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_login
        '
        Me.Btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_login.Location = New System.Drawing.Point(197, 224)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(75, 23)
        Me.Btn_login.TabIndex = 0
        Me.Btn_login.Text = "Login"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(133, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'box_user
        '
        Me.box_user.Location = New System.Drawing.Point(113, 172)
        Me.box_user.Name = "box_user"
        Me.box_user.Size = New System.Drawing.Size(159, 20)
        Me.box_user.TabIndex = 3
        '
        'box_pass
        '
        Me.box_pass.Location = New System.Drawing.Point(113, 198)
        Me.box_pass.Name = "box_pass"
        Me.box_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.box_pass.Size = New System.Drawing.Size(159, 20)
        Me.box_pass.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(347, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBaseToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'DataBaseToolStripMenuItem
        '
        Me.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem"
        Me.DataBaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DataBaseToolStripMenuItem.Text = "Data Base"
        '
        'CheckBoxLogin
        '
        Me.CheckBoxLogin.AutoSize = True
        Me.CheckBoxLogin.Location = New System.Drawing.Point(113, 228)
        Me.CheckBoxLogin.Name = "CheckBoxLogin"
        Me.CheckBoxLogin.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxLogin.TabIndex = 7
        Me.CheckBoxLogin.Text = "Tetap Login"
        Me.CheckBoxLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(110, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password dan User Name Salah"
        Me.Label3.Visible = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 332)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBoxLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.box_pass)
        Me.Controls.Add(Me.box_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_login)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LoginForm"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents box_user As TextBox
    Friend WithEvents box_pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBoxLogin As CheckBox
    Friend WithEvents Label3 As Label
End Class
