Imports MySql.Data.MySqlClient
Public Class DataBaseClass
    Public connDB As New MySqlConnection
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public cmd As MySqlCommand

    Dim strServer As String = My.Settings.DB_Server
    Dim strDbase As String = My.Settings.DB_Name 'Database name
    Dim strUser As String = My.Settings.DB_User  'Database user
    Dim strPass As String = My.Settings.DB_Pass     'Database password

    Public Sub uploadDB(ByVal QueryUpload As String)
        '        Dim UploadQ As String = "INSERT INTO `master_employer`(`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Dep_Karyawan`, `TmptLahir_Karyawan`, `TglLahir_Karyawan`, `JKelamin_Karyawan`, `Pendidikan_Karyawan`, `TgllMasuk_Karyawan`, `Status_Karyawan`, `Salary_Karyawan`) 
        '        VALUES ('K200191,'Marlina Agustin','Operator','Rubber Forming','Bekasi','2008-01-13','Perempuan','SMA','2002-20-17','Magang',3524207)"

        Try
            Console.WriteLine("Query Upload : " + QueryUpload)
            If connDB.State <> ConnectionState.Open Then
                connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass.Trim & ";Convert Zero Datetime='True'"
                connDB.Open()
            End If
            cmd = New MySqlCommand(QueryUpload, connDB)
            cmd.CommandTimeout = 200
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connDB.Close()
            Console.WriteLine("Connection Oke")
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Console.WriteLine("Connection Error")
        End Try
    End Sub
    Function downloadDB(QueryCMD As String) As DataSet

        Try
            Console.WriteLine("Query Download : " + QueryCMD)
            If connDB.State <> ConnectionState.Open Then
                connDB.ConnectionString = "server=" & strServer.Trim & ";database=" & strDbase.Trim & ";user=" & strUser.Trim & ";password=" & strPass
                connDB.Open()
            End If

            ds = New DataSet
            da = New MySqlDataAdapter(QueryCMD, connDB)
            da.Fill(ds)
            connDB.Close()
            Console.WriteLine("OKE")
            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Return Nothing
        End Try
    End Function
End Class
