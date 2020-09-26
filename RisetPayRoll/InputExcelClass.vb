Imports System.Data.OleDb
Public Class InputExcelClass
    Public conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public cmd As OleDbCommand

    Function ImportExcel() As DataSet
        On Error Resume Next
        Dim fileDialog As OpenFileDialog = RegisterMaster.OpenFileDialogImport
        fileDialog.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*"
        fileDialog.ShowDialog()
        conn = New OleDbConnection("provider=Microsoft.ace.OLEDB..0;" & "data source='" & fileDialog.FileName & "';Extended Properties=Excel 8.0;")
        da = New OleDbDataAdapter("select * from [Sheet1$]", conn)
        conn.Open()
        ds.Clear()
        da.Fill(ds)
        conn.Close()
        Return ds
    End Function

    Public Sub ExcelToServer()
        Dim ds As DataSet = ImportExcel()
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 2 To indexRows - 1
            Dim masterQuery As String = $"INSERT INTO `master_employer`(`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Dep_Karyawan`, `TmptLahir_Karyawan`, `TglLahir_Karyawan`, `JKelamin_Karyawan`, `Pendidikan_Karyawan`, `TgllMasuk_Karyawan`, `Status_Karyawan`, `Salary_Karyawan`) 
                 VALUES ('{ds.Tables(0).Rows(i).Item(1)}',
                         '{ds.Tables(0).Rows(i).Item(2)}',
                         '{ds.Tables(0).Rows(i).Item(3)}',
                         '{ds.Tables(0).Rows(i).Item(4)}',
                         '{ds.Tables(0).Rows(i).Item(5)}',
                         '{ds.Tables(0).Rows(i).Item(6)}',
                         '{ds.Tables(0).Rows(i).Item(7)}',
                         '{ds.Tables(0).Rows(i).Item(8)}',
                         '{ds.Tables(0).Rows(i).Item(9)}',
                         '{ds.Tables(0).Rows(i).Item(10)}',
                         {ds.Tables(0).Rows(i).Item(11)})"
            Console.WriteLine("DB Query : " + masterQuery)
            funcDB.uploadDB(masterQuery)
        Next
        'test
    End Sub
End Class
