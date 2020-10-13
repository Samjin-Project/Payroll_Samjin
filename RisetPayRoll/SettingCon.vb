Imports System.Windows.Forms

Public Class SettingCon

    Private Sub frmConnection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDatabaseSetting()
        server_box.Text = dbServer
        user_box.Text = dbUser
        pass_box.Text = dbPassword
        db_box.Text = dbName
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If DatabaseConnected(server_box.Text, user_box.Text, pass_box.Text, db_box.Text) = True Then
            With My.Settings
                .DB_Server = server_box.Text
                .DB_User = user_box.Text
                .DB_Pass = pass_box.Text
                .DB_Name = db_box.Text
                .Save()
            End With

            GetDatabaseSetting()

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
