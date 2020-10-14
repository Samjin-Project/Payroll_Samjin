Imports System.Data.SqlClient
Public Class Login
    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click

        Dim connection As New SqlConnection("Server= Riki; Database = Ridwan; Integrated security = true")

        Dim command As New SqlCommand("select * from sqlpayroll where Username = @username and Password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = box_user.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = box_pass.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable

        'adapter.Fill()(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("username atau password salah !")
        Else
            MessageBox.Show("login berhasil !")
            Me.Hide()
            MDIParent1.Show()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class