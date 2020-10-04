Public Class DailyAttendance
    Dim queryAll As String = "SELECT `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, `Check Out Date`, `Lateness`, `Early Check Out`, `Basic Time`, `Department` FROM `tabel_harian_karyawan1`"
    Private Sub DailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`FROM `master_employer`"
        showEmploye(QueryCMD)
        showDaily(queryAll)
    End Sub

    Private Sub showEmploye(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString}
            DGV_SideDaily.Rows.Add(row)
            DGV_SideDaily.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_SideDaily.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub

    Private Sub DGV_SideDaily_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_SideDaily.RowHeaderMouseClick
        DGV_ReviewDaily.Rows.Clear()
        Dim nik As String = DGV_SideDaily.Rows(e.RowIndex).Cells(0).Value
        Dim queryGetData As String = $"{queryAll} WHERE `NIK` = '{nik}'"
        showDaily(queryGetData)
    End Sub
    Private Sub showDaily(QueryDaily As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryDaily)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString,
            ds.Tables(0).Rows(i).Item(1).ToString,
            ds.Tables(0).Rows(i).Item(2).ToString,
            ds.Tables(0).Rows(i).Item(3),
            ds.Tables(0).Rows(i).Item(4).ToString,
            ds.Tables(0).Rows(i).Item(5).ToString,
            ds.Tables(0).Rows(i).Item(6).ToString,
            ds.Tables(0).Rows(i).Item(7).ToString,
            ds.Tables(0).Rows(i).Item(8).ToString,
            ds.Tables(0).Rows(i).Item(9).ToString,
            ds.Tables(0).Rows(i).Item(10).ToString,
            ds.Tables(0).Rows(i).Item(11).ToString,
            ds.Tables(0).Rows(i).Item(12).ToString}
            DGV_ReviewDaily.Rows.Add(row)
            DGV_ReviewDaily.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ReviewDaily.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next

    End Sub
    Private Sub filterDataGroup(dep As String, group As String, stDate As Date, endDate As Date)

        Dim QuerySortDep As String = $"{queryAll} WHERE `Department` = '{dep}' "
        Dim QuerySortGroup As String = $"{queryAll} WHERE `shift` = '{group}' "
        Dim QuerySortAll As String = $"{queryAll} WHERE `shift` = '{group}' AND `Department` = '{dep}' "

        Dim QueryAllwTime As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
        Dim QuerySortDepwTime As String = $"{queryAll} WHERE (`Department` = '{dep}') 
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortGroupwTime As String = $"{queryAll} WHERE (`shift` = '{group}') 
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortAllwTime As String = $"{queryAll} WHERE `shift` = '{group}' AND `Department` = '{dep}'
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"

        Dim querycmd As String = ""
        If stDate = endDate Then
            If dep = "" And group = "" Then
                querycmd = queryAll
            ElseIf dep = "" And group <> "" Then
                querycmd = QuerySortGroup
            ElseIf dep <> "" And group = "" Then
                querycmd = QuerySortDep
            ElseIf dep <> "" And group <> "" Then
                querycmd = QuerySortAll
            End If
        End If

        If Not stDate = endDate Then
            If dep = "" And group = "" Then
                querycmd = QueryAllwTime
            ElseIf dep = "" And group <> "" Then
                querycmd = QuerySortGroupwTime
            ElseIf dep <> "" And group = "" Then
                querycmd = QuerySortDepwTime
            ElseIf dep <> "" And group <> "" Then
                querycmd = QuerySortAllwTime
            End If
        End If

        showDaily(querycmd)
        'menampilkan total data dalan datagrid
        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub
    Private Sub filterDataPerson(emp As String, name As String, stDate As Date, endDate As Date)
        Dim QuerySortEmp As String = $"{queryAll} WHERE `NIK` = '{emp}' "
        Dim QuerySortName As String = $"{queryAll} WHERE `Name` = '{name}' "
        Dim QuerySortAll As String = $"{queryAll} WHERE `NIK` = '{emp}' AND `Name` = '{name}' "

        Dim QueryAllwTime As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
        Dim QuerySortEmpwTime As String = $"{queryAll} WHERE (`NIK` = '{emp}') 
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortNamewTime As String = $"{queryAll} WHERE (`Name` = '{name}') 
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortAllwTime As String = $"{queryAll} WHERE `Name` = '{name}' AND `NIK` = '{emp}'
            AND (`Date` BETWEEN  '{stDate}' AND '{endDate}')"

        Dim querycmd As String = ""
        If stDate = endDate Then
            If name = "" And emp = "" Then
                querycmd = queryAll
            ElseIf name = "" And emp <> "" Then
                querycmd = QuerySortEmp
            ElseIf name <> "" And emp = "" Then
                querycmd = QuerySortName
            ElseIf name <> "" And emp <> "" Then
                querycmd = QuerySortAll
            End If
        End If

        If Not stDate = endDate Then
            If name = "" And emp = "" Then
                querycmd = queryAll
            ElseIf name = "" And emp <> "" Then
                querycmd = QuerySortEmpwTime
            ElseIf name <> "" And emp = "" Then
                querycmd = QuerySortNamewTime
            ElseIf name <> "" And emp <> "" Then
                querycmd = QuerySortAllwTime
            End If
        End If

        showDaily(querycmd)
        'menampilkan total data dalan datagrid
        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub
    Private Sub cb_depSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_depSearch.SelectedIndexChanged
        DGV_ReviewDaily.Rows.Clear()
        Dim dep As String = cb_depSearch.Text
        Dim group As String = cb_groupSearch.Text
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")

        filterDataGroup(dep, group, stDate, endDate)
        Console.WriteLine("Done")
    End Sub

    Private Sub cb_groupSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_groupSearch.SelectedIndexChanged
        DGV_ReviewDaily.Rows.Clear()
        Dim dep As String = cb_depSearch.Text
        Dim group As String = cb_groupSearch.Text
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")

        filterDataGroup(dep, group, stDate, endDate)
        Console.WriteLine("Done")
    End Sub

    Private Sub tb_empSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_empSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            DGV_ReviewDaily.Rows.Clear()
            Dim emp As String = tb_empSearch.Text
            Dim name As String = tb_namaSearch.Text
            Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
            filterDataPerson(emp, name, stDate, endDate)
            Console.WriteLine("Done")
        End If
    End Sub

    Private Sub tb_namaSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_namaSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            DGV_ReviewDaily.Rows.Clear()
            Dim emp As String = tb_empSearch.Text
            Dim name As String = tb_namaSearch.Text
            Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
            filterDataPerson(emp, name, stDate, endDate)
            Console.WriteLine("Done")
        End If
    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        DGV_ReviewDaily.Rows.Clear()
        Dim queryCmd As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
        showDaily(queryCmd)
        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        DGV_ReviewDaily.Rows.Clear()
        Dim queryCmd As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
        showDaily(queryCmd)
        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub

    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        tb_empSearch.Text = ""
        tb_namaSearch.Text = ""
        cb_depSearch.Text = ""
        cb_groupSearch.Text = ""
        dt_start.Value = Now
        dt_end.Value = Now
        showDaily(queryAll)
    End Sub
End Class