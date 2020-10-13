Module GlobalVar

    Public dbServer As String
    Public dbUser As String
    Public dbPassword As String
    Public dbName As String
    Public sLocalConn As String

    Public Sub GetDatabaseSetting()
        dbServer = My.Settings.DB_Server
        dbUser = My.Settings.DB_User
        dbPassword = My.Settings.DB_Pass
        dbName = My.Settings.DB_Name
        sLocalConn = "server=" & dbServer & ";user id=" & dbUser & ";" & "password=" & dbPassword & ";database=" & dbName
    End Sub

    Public Function DatabaseConnected(Optional ByVal Server As String = "", Optional ByVal User As String = "", Optional ByVal Password As String = "", Optional ByVal DatabaseName As String = "") As Boolean

        Dim conn As MySqlConnection

        conn = New MySqlConnection()

        If Server = "" And User = "" And Password = "" And DatabaseName = "" Then
            conn.ConnectionString = sLocalConn
        Else
            conn.ConnectionString = "server=" & Server & ";user id=" & User & ";password=" & Password & ";database=" & DatabaseName
        End If

        Try
            conn.Open()
            conn.Close()
            Return True
        Catch myerror As MySqlException
            Return False
            MessageBox.Show("Error: " & myerror.Message)
        Finally
            conn.Dispose()
        End Try

        Return False
    End Function

End Module
