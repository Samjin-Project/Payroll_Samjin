Public Class ViewDailyAttendance
    Private Sub ViewDailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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
        Dim rawData(DGV_ReviewDaily.Rows.Count, DGV_ReviewDaily.Columns.Count - 1) As Object

        ' Copy the column names to the first row of the object array

        For col = 0 To DGV_ReviewDaily.Columns.Count - 1
            rawData(0, col) = DGV_ReviewDaily.Columns(col).HeaderText.ToUpper

        Next

        For col = 0 To DGV_ReviewDaily.Columns.Count - 1
            For row = 0 To DGV_ReviewDaily.Rows.Count - 1
                rawData(row + 1, col) = DGV_ReviewDaily.Rows(row).Cells(col).Value

            Next
        Next
        ' Calculate the final column letter
        Dim finalColLetter As String = String.Empty
        finalColLetter = ExcelColName(DGV_ReviewDaily.Columns.Count) 'Generate Excel Column Name (Column ID)


        sheetIndex += 1
        Ws = Wb.Worksheets(sheetIndex)
        'Ws.name = "Test10"
        Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, DGV_ReviewDaily.Rows.Count + 1)
        Ws.Columns(1).ColumnWidth = 10
        Ws.Columns(2).ColumnWidth = 15
        Ws.Columns(3).ColumnWidth = 15
        Ws.Columns(4).ColumnWidth = 15
        Ws.Columns(5).ColumnWidth = 15
        Ws.Columns(6).ColumnWidth = 8
        Ws.Columns(7).ColumnWidth = 10
        Ws.Columns(8).ColumnWidth = 10
        Ws.Columns(9).ColumnWidth = 10
        Ws.Columns(10).ColumnWidth = 15
        Ws.Columns(11).ColumnWidth = 5
        Ws.Columns(12).ColumnWidth = 5
        Ws.Columns(13).ColumnWidth = 5
        Ws.Columns(14).ColumnWidth = 5
        Ws.Columns(15).ColumnWidth = 5
        Ws.Columns(16).ColumnWidth = 5
        Ws.Columns(17).ColumnWidth = 5
        Ws.Columns(18).ColumnWidth = 5
        Ws.Columns(19).ColumnWidth = 5
        Ws.Columns(20).ColumnWidth = 5
        Ws.Columns(21).ColumnWidth = 5
        Ws.Columns(22).ColumnWidth = 5
        Ws.Columns(23).ColumnWidth = 5
        Ws.Columns(24).ColumnWidth = 5
        Ws.Columns(25).ColumnWidth = 5
        Ws.Columns(26).ColumnWidth = 5
        Ws.Columns(27).ColumnWidth = 5
        Ws.Columns(28).ColumnWidth = 5
        Ws.Columns(29).ColumnWidth = 5
        Ws.Columns(30).ColumnWidth = 5
        Ws.Columns(31).ColumnWidth = 5
        Ws.Columns(32).ColumnWidth = 5
        Ws.Columns(33).ColumnWidth = 5
        Ws.Columns(34).ColumnWidth = 5
        Ws.Columns(35).ColumnWidth = 5
        Ws.Columns(36).ColumnWidth = 5
        Ws.Columns(37).ColumnWidth = 5
        Ws.Columns(38).ColumnWidth = 5
        Ws.Columns(39).ColumnWidth = 5
        Ws.Columns(40).ColumnWidth = 5
        Ws.Columns(41).ColumnWidth = 5
        Ws.Columns(42).ColumnWidth = 15

        Ws.Range(excelRange, Type.Missing).Value2 = rawData
        Ws.Range(excelRange, Type.Missing).WrapText = True
        Ws.Range(excelRange, Type.Missing).Borders.Color = RGB(0, 0, 0)
        Ws = Nothing


        Wb.SaveAs("D:\Test12.xlsx", Type.Missing, Type.Missing,
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