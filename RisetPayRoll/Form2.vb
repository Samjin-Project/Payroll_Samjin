Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function GetTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("NO", GetType(Integer))
        table.Columns.Add("EMPL NO.", GetType(String))
        table.Columns.Add("NAME", GetType(String))
        table.Columns.Add("POSITION", GetType(String))
        table.Columns.Add("DEPT", GetType(String))
        table.Columns.Add("HIRE OF DATE", GetType(String))
        table.Columns.Add("STATUS", GetType(String))
        table.Columns.Add("SUB TOTAL (GROSS SALARY)", GetType(Integer))
        table.Columns.Add("MANAGM FEE 8% X BASIC SALARY", GetType(Integer))
        table.Columns.Add("TOTAL", GetType(Integer))
        table.Columns.Add("GROSS SALARY", GetType(Integer))
        table.Columns.Add("JAMSOST(1.19% x BS)", GetType(Integer))
        table.Columns.Add("BPJS KESEHATAN", GetType(Integer))
        table.Columns.Add("SUB TOTAL", GetType(Integer))
        table.Columns.Add("TAKE HOME PAY", GetType(Integer))

        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        table.Rows.Add(1, "K216441019", "Reza Sup", "Supervisor", "Produksi", "22 September 2020", "Aktif", 10000000, 800000, 10800000, 10000000, 119000, 100000, 9900000, 10000000)
        Return table
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim table As DataTable = GetTable()
        Dim sheetIndex As Integer
        Dim Ex As Object
        Dim Wb As Object
        Dim Ws As Object
        Ex = CreateObject("Excel.Application")
        Wb = Ex.workbooks.add

        ' Copy each DataTable as a new Sheet

        'On Error Resume Next
        Dim col, row As Integer
        ' Copy the DataTable to an object array
        Dim rawData(table.Rows.Count, table.Columns.Count - 1) As Object

        ' Copy the column names to the first row of the object array

        For col = 0 To table.Columns.Count - 1
            rawData(0, col) = table.Columns(col).ColumnName.ToUpper
        Next

        For col = 0 To table.Columns.Count - 1
            For row = 0 To table.Rows.Count - 1
                rawData(row + 1, col) = table.Rows(row).ItemArray(col)

            Next
        Next


        ' Calculate the final column letter
        Dim finalColLetter As String = String.Empty
        finalColLetter = ExcelColName(table.Columns.Count) 'Generate Excel Column Name (Column ID)


        sheetIndex += 1
        Ws = Wb.Worksheets(sheetIndex)
        'Ws.name = "Test10"
        Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, table.Rows.Count + 1)

        Ws.Range(excelRange, Type.Missing).Value2 = rawData
        Ws.Range(excelRange, Type.Missing).Borders.Color = RGB(0, 0, 0)
        Ws.Range("A1:J1").interior.colorindex = 6
        Ws.Range("K1:O1").interior.colorindex = 45
        Ws = Nothing


        Wb.SaveAs("D:\test5.xlsx", Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
        Wb.Close(True, Type.Missing, Type.Missing)
        Wb = Nothing
        ' Release the Application object
        Ex.Quit()
        Ex = Nothing
        ' Collect the unreferenced objects
        GC.Collect()
        MsgBox("Exported Successfully.", MsgBoxStyle.Information)
    End Sub

    Public Function ExcelColName(ByVal Col As Integer) As String
        If Col < 0 And Col > 256 Then
            MsgBox("Invalid Argument", MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End If
        Dim i As Int16
        Dim r As Int16
        Dim S As String
        If Col <= 26 Then
            S = Chr(Col + 64)
        Else
            r = Col Mod 26
            i = System.Math.Floor(Col / 26)
            If r = 0 Then
                r = 26
                i = i - 1
            End If
            S = Chr(i + 64) & Chr(r + 64)
        End If
        ExcelColName = S
    End Function

End Class