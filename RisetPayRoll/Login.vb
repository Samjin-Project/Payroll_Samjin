Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Dim query As String = $"SELECT COUNT(*) FROM `user_admin` WHERE BINARY `Username` = '{box_user.Text}' AND BINARY `Password` = '{box_pass.Text}'"
        Dim DBmaster As DataBaseClass = New DataBaseClass
        Dim Akun As DataSet = DBmaster.downloadDB(query)

        If Akun.Tables(0).Rows(0).Item(0) = 0 Then
            Label3.Visible = True
        Else
            'MessageBox.Show("login berhasil !")
            FlagData()
            'Me.Hide()
            MDIParent1.Show()
            Close()
        End If
    End Sub

    Private Sub FlagData()
        Console.WriteLine("cheked : " + CheckBoxLogin.Checked.ToString)
        My.Settings.StatusLogin = CheckBoxLogin.Checked
        My.Settings.User = box_user.Text
        My.Settings.Save()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StatusLogin = True Then
            MDIParent1.Show()
            Close()
        End If
    End Sub

    Private Sub DataBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBaseToolStripMenuItem.Click

    End Sub
End Class