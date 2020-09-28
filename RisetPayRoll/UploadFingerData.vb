Imports System.Data.OleDb
Public Class UploadFingerData
    Private Sub UploadExcel()
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet
        Dim CMD As OleDbCommand

        On Error Resume Next
        OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        OpenFileDialogImport.ShowDialog()

        CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 8.0;")

        DA = New OleDbDataAdapter("select * from [1$]", CONN)
        CONN.Open()
        DS.Clear()
        DA.Fill(DS)
        CONN.Close()

        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = DS.Tables(0).Rows.Count
        Dim indexCell As Integer = DS.Tables(0).Columns.Count
        Console.WriteLine($"Row Count {indexRows}")
        Console.WriteLine($"Cell Count {indexCell}")

        For i As Integer = 0 To indexRows - 1
            Dim nik As String = DS.Tables(0).Rows(i).Item(0)
            Dim Nama_Karyawan As String = DS.Tables(0).Rows(i).Item(1)
            Dim Date_Finger As String = DS.Tables(0).Rows(i).Item(2)
            Dim Shift_Finger As String = DS.Tables(0).Rows(i).Item(3)
            Dim On_Duty As String = DS.Tables(0).Rows(i).Item(4)
            Dim Off_Duty As String = DS.Tables(0).Rows(i).Item(5)
            Dim Check_In As String = DS.Tables(0).Rows(i).Item(6)
            Dim Check_Out As String = DS.Tables(0).Rows(i).Item(7)
            Dim Departement As String = DS.Tables(0).Rows(i).Item(8)
            Console.WriteLine(Check_In.Length)
            Console.WriteLine(Check_Out.Length)

            If Check_In.Length > 4 And Check_Out.Length > 4 Then
                Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}')"
                Console.WriteLine("DB Query : " + masterQuery)
                funcDB.uploadDB(masterQuery)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadExcel()
    End Sub

    Private Sub UploadFingerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class