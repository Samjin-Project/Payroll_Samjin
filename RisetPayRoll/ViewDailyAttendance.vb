Public Class ViewDailyAttendance
    Dim flag As Boolean = False
    Dim QueryCMD As String = "SELECT * FROM `tabel_bulanan_karyawan`"
    Private Sub ViewDailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_dep.Text = "PCBA"
        Dim query As String = $"{QueryCMD} WHERE `Department` = '{cb_dep.Text}'"
        showData(query)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Excel File|*.xls"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            saveExcelFile(saveFileDialog1.FileName)
        End If
    End Sub

    Public Sub saveExcelFile(ByVal FileName As String)
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


        Wb.SaveAs(FileName)
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
    Function jumlah(ds As DataSet, x As Integer) As String
        Dim tempNilai As Integer = 0
        For i As Integer = 0 To 30
            Dim valueTemp As String = ds.Tables(0).Rows(x).Item(i + 10)
            If valueTemp = "" Then
                valueTemp = "0"
            End If
            tempNilai += Convert.ToInt32(valueTemp)
        Next
        Return tempNilai.ToString
    End Function
    Private Sub showData(QueryOnReview As String)
        DGV_ReviewDaily.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim dateCekData As Date = DateTime.ParseExact(ds.Tables(0).Rows(i).Item(3), "yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(1),
            ds.Tables(0).Rows(i).Item(2),
            ds.Tables(0).Rows(i).Item(4),
            dateCekData.ToString("MMM, yyyy"),
            ds.Tables(0).Rows(i).Item(5),
            ds.Tables(0).Rows(i).Item(6),
            ds.Tables(0).Rows(i).Item(7),
            ds.Tables(0).Rows(i).Item(8),
            ds.Tables(0).Rows(i).Item(9),
            ds.Tables(0).Rows(i).Item(10),
            ds.Tables(0).Rows(i).Item(11),
            ds.Tables(0).Rows(i).Item(12),
            ds.Tables(0).Rows(i).Item(13),
            ds.Tables(0).Rows(i).Item(14),
            ds.Tables(0).Rows(i).Item(15),
            ds.Tables(0).Rows(i).Item(16),
            ds.Tables(0).Rows(i).Item(17),
            ds.Tables(0).Rows(i).Item(18),
            ds.Tables(0).Rows(i).Item(19),
            ds.Tables(0).Rows(i).Item(20),
            ds.Tables(0).Rows(i).Item(21),
            ds.Tables(0).Rows(i).Item(22),
            ds.Tables(0).Rows(i).Item(23),
            ds.Tables(0).Rows(i).Item(24),
            ds.Tables(0).Rows(i).Item(25),
            ds.Tables(0).Rows(i).Item(26),
            ds.Tables(0).Rows(i).Item(27),
            ds.Tables(0).Rows(i).Item(28),
            ds.Tables(0).Rows(i).Item(29),
            ds.Tables(0).Rows(i).Item(30),
            ds.Tables(0).Rows(i).Item(31),
            ds.Tables(0).Rows(i).Item(32),
            ds.Tables(0).Rows(i).Item(33),
            ds.Tables(0).Rows(i).Item(34),
            ds.Tables(0).Rows(i).Item(35),
            ds.Tables(0).Rows(i).Item(36),
            ds.Tables(0).Rows(i).Item(37),
            ds.Tables(0).Rows(i).Item(38),
            ds.Tables(0).Rows(i).Item(39),
            ds.Tables(0).Rows(i).Item(40),
            ds.Tables(0).Rows(i).Item(41),
            ds.Tables(0).Rows(i).Item(42),
            jumlah(ds, i)
            }
            DGV_ReviewDaily.Rows.Add(row)
            DGV_ReviewDaily.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ReviewDaily.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
            DGV_ReviewDaily.Columns(1).Frozen = True
        Next
    End Sub
    Private Sub filterDataDep(dep As String, tgl As String)
        Dim queryAll As String = "SELECT * FROM `tabel_bulanan_karyawan`"
        Dim queryDep As String = $"{queryAll} WHERE `Department` ='{dep}' "
        Dim querySortAll As String = $"{queryAll} WHERE `Department` ='{dep}' AND `Period` = '{tgl}'"

        Dim querycmd As String = ""
        If dep = "" And flag = False Then
            querycmd = queryAll
        ElseIf dep <> "" And flag = False Then
            querycmd = queryDep
        ElseIf dep <> "" And flag = True Then
            querycmd = querySortAll
        End If
        showData(querycmd)
    End Sub

    Private Sub filterDataEmp(emp As String, tgl As String)
        Dim queryAll As String = "SELECT * FROM `tabel_bulanan_karyawan`"
        Dim queryEmp As String = $"{queryAll} WHERE `NIK` ='{emp}' "
        Dim querySortAll As String = $"{queryAll} WHERE `NIK` ='{emp}' AND `Period` = '{tgl}'"

        Dim querycmd As String = ""
        If emp = "" And flag = False Then
            querycmd = queryAll
        ElseIf emp <> "" And flag = False Then
            querycmd = queryEmp
        ElseIf emp <> "" And flag = True Then
            querycmd = querySortAll
        End If
        showData(querycmd)
    End Sub

    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        tb_emp.Text = ""
        dt_filter.Value = Now
        cb_dep.Text = ""
        showData(QueryCMD)
        flag = False
    End Sub

    Private Sub dt_filter_ValueChanged(sender As Object, e As EventArgs) Handles dt_filter.ValueChanged
        Dim tgl As String = dt_filter.Value.ToString("MMM yyy")
        Dim dep As String = cb_dep.Text
        Dim emp As String = tb_emp.Text
        Dim queryDate As String = ""
        If emp = "" And dep = "" Then
            queryDate = $"{QueryCMD} WHERE `Period` = '{tgl}'"
        ElseIf emp <> "" Then
            queryDate = $"{QueryCMD} WHERE `Period` = '{tgl}' AND `NIK` = '{emp}'"
        ElseIf dep <> "" Then
            queryDate = $"{QueryCMD} WHERE `Period` = '{tgl}' AND `Department` = '{dep}'"
        End If
        showData(queryDate)
        flag = True
    End Sub

    Private Sub cb_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dep.SelectedIndexChanged
        tb_emp.Text = ""
        Dim dep As String = cb_dep.Text
        Dim tgl As String = dt_filter.Value.ToString("MMM yyy")
        filterDataDep(dep, tgl)
    End Sub

    Private Sub tb_emp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_emp.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            cb_dep.Text = ""
            Dim emp As String = tb_emp.Text
            Dim tgl As String = dt_filter.Value.ToString("MMM yyyy")
            filterDataEmp(emp, tgl)
        End If
    End Sub
End Class