Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ExcelApp As Excel.Application
            Dim ExcelWorkBook As Excel.Workbook
            Dim ExcelWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim a As Integer
            Dim b As Integer

            ExcelApp = New Excel.Application
            ExcelWorkBook = ExcelApp.Workbooks.Add(misValue)
            ExcelWorkSheet = ExcelWorkBook.Sheets("sheet1")

            For a = 0 To DataGridView1.RowCount - 2
                For b = 0 To DataGridView1.ColumnCount - 1
                    For c As Integer = 1 To DataGridView1.Columns.Count
                        ExcelWorkSheet.Cells(1, c) = DataGridView1.Columns(c - 1).HeaderText
                        ExcelWorkSheet.Cells(a + 2, b + 1) = DataGridView1(b, a).Value.ToString()
                    Next
                Next
            Next

            ExcelWorkSheet.SaveAs("D:\Test.xls")
            ExcelWorkBook.Close()
            ExcelApp.Quit()

            releaseObject(ExcelApp)
            releaseObject(ExcelWorkBook)
            releaseObject(ExcelWorkSheet)

            MsgBox("Hasil export tersimpan di D:\DB, dengan nama Test.xlsx")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
