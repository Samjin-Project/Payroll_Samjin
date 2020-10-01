﻿Public Class ViewDailyAttendance
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

        Ws.Range(excelRange, Type.Missing).Value2 = rawData
        Ws = Nothing


        Wb.SaveAs("D:\Test10.xlsx", Type.Missing, Type.Missing,
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