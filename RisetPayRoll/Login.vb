Imports System.Data.SqlClient
Public Class LoginForm
    Dim DBmaster As DataBaseClass = New DataBaseClass
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Try
            If DBmaster.cekKoneksi = False Then
                Label4.Visible = True
            Else
                Dim query As String = $"SELECT COUNT(*) FROM `user_admin` WHERE BINARY `Username` = '{box_user.Text}' AND BINARY `Password` = '{box_pass.Text}'"
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
            End If

        Catch ex As Exception
            Label4.Visible = True
        End Try

    End Sub

    Private Sub FlagData()
        Console.WriteLine("cheked : " + CheckBoxLogin.Checked.ToString)
        My.Settings.StatusLogin = CheckBoxLogin.Checked
        My.Settings.User = box_user.Text
        My.Settings.Save()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AlreadyRunning() Then
            MessageBox.Show(
        "Another instance is already running.",
        "Already Running",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation)
            Me.Close()
        End If

        'Try
        If My.Settings.StatusLogin = True Then
            If DBmaster.cekKoneksi = False Then
                Label4.Visible = True
                Debug.WriteLine("error")
            Else
                MDIParent1.Show()
                Close()
            End If
        End If
        'Catch ex As Exception
        'Label4.Visible = True
        'End Try

    End Sub

    Private Function AlreadyRunning() As Boolean
        ' Get our process name.
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName

        ' Get information about processes with this name.
        Dim procs() As Process =
        Process.GetProcessesByName(my_name)

        ' If there is only one, it's us.
        If procs.Length = 1 Then Return False

        ' If there is more than one process,
        ' see if one has a StartTime before ours.
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
            Return True
        Next i

        ' If we get here, we were first.
        Return False
    End Function
End Class