Public Class ListNoCheck
    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        dt_end.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub filterData(dep As String, emp As String, stDate As String, endDate As String)
        Dim mainQuery As String = "SELECT `NIK`, `Name`, `Department`,`Date` FROM `tabel_harian_karyawan1` "

        Dim QueryALL As String = $"{mainQuery} WHERE `Type` = 'No Check'"
        Dim QuerySortEmp As String = $"{mainQuery} WHERE `NIK` = '{emp}' AND `Type` = 'No Check'"
        Dim QuerySortDep As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `Type` = 'No Check'"
        Dim QuerySortAll As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `NIK` = '{emp}' AND `Type` = 'No Check'"

        Dim QueryALLwTime As String = $"{mainQuery} WHERE (`Date` BETWEEN '{stDate}' AND '{endDate}') AND `Type` = 'No Check'"
        Dim QuerySortEmpwTime As String = $"{mainQuery} WHERE `NIK` = '{emp}' 
            AND (`Date` BETWEEN '{stDate}' AND '{endDate}') AND `Type` = 'No Check'"
        Dim QuerySortDepwTime As String = $"{mainQuery} WHERE `Department` = '{dep}'
            AND (`Date` BETWEEN '{stDate}' AND '{endDate}') AND `Type` = 'No Check'"
        Dim QuerySortAllwTime As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `NIK` = '{emp}'
            AND (`Date` BETWEEN '{stDate}' AND '{endDate}') AND `Type` = 'No Check'"

        Dim querycmd As String = ""
        If stDate = endDate Then
            If dep = "" And emp = "" Then
                querycmd = QueryALL
            ElseIf dep = "" And emp <> "" Then
                querycmd = QuerySortEmp
            ElseIf dep <> "" And emp = "" Then
                querycmd = QuerySortDep
            ElseIf dep <> "" And emp <> "" Then
                querycmd = QuerySortAll
            End If

        Else
            If dep = "" And emp = "" Then
                querycmd = QueryALLwTime
            ElseIf dep = "" And emp <> "" Then
                querycmd = QuerySortEmpwTime
            ElseIf dep <> "" And emp = "" Then
                querycmd = QuerySortDepwTime
            ElseIf dep <> "" And emp <> "" Then
                querycmd = QuerySortAllwTime
            End If
        End If
        Console.WriteLine(querycmd)
        dataOnSide(querycmd)
    End Sub
    Private Sub dataOnSide(QueryOnReview As String)
        DGV_ListCheck.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        If indexDs > 0 Then
            For i As Integer = 0 To indexDs - 1
                Dim nik As String = ds.Tables(0).Rows(i).Item(0)
                Dim name As String = ds.Tables(0).Rows(i).Item(1)
                Dim dep As String = ds.Tables(0).Rows(i).Item(2)
                Dim dateCheck As Date = ds.Tables(0).Rows(i).Item(3)

                Dim row As String() = New String() {nik,
                name,
                dep,
                dateCheck.ToString("dd/MM/yyyy")}

                DGV_ListCheck.Rows.Add(row)
                DGV_ListCheck.Rows(i).HeaderCell.Value = (i + 1).ToString
                If i Mod 2 = 1 Then
                    DGV_ListCheck.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        Else
            DGV_ListCheck.Rows.Clear()
        End If
    End Sub
    Dim 
    Private Sub ListNoCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.StatusUser = "admin" Then
            cb_dep.Text = My.Settings.Departement.ToString
            cb_dep.Enabled = False
            Debug.WriteLine(My.Settings.Departement)

        Else
            For Each x As String In MDIParent1.JenisDepartement
                cb_dep.Items.Add(x)
            Next
        End If

        Dim querycmd As String = $"SELECT `NIK`, `Name`, `Department`,`Date` FROM `tabel_harian_karyawan1` WHERE `Type` = 'No Check' AND `Department` = '{cb_dep.Text}'"
        dataOnSide(querycmd)
        dt_start.CustomFormat = " "
        dt_end.CustomFormat = " "
    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged
        dt_start.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        'cb_dep.Text = ""
        nik.Text = ""
        dt_start.CustomFormat = " "
        dt_end.CustomFormat = " "
        Dim querycmd As String = $"SELECT `NIK`, `Name`, `Department`,`Date` FROM `tabel_harian_karyawan1` WHERE `Type` = 'No Check' AND `Department` = '{cb_dep.Text}'"
        dataOnSide(querycmd)
    End Sub

    Private Sub b_search_Click(sender As Object, e As EventArgs) Handles b_search.Click
        Dim emp As String = nik.Text
        Dim dep As String = cb_dep.Text
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        filterData(dep, emp, stDate, endDate)
    End Sub

    Private Sub nik_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles nik.PreviewKeyDown
        cb_dep.Text = ""
    End Sub

    Private Sub b_delete_Click(sender As Object, e As EventArgs) Handles b_delete.Click
        Dim selectedRows As Integer = DGV_ListCheck.CurrentRow.Index
        deleteData(selectedRows)
    End Sub
    Sub deleteData(rowIndex As Integer)
        Console.WriteLine("row index :" + DGV_ListCheck.Rows(rowIndex).Cells(0).Value.ToString)
        Dim deleteDB As DataBaseClass = New DataBaseClass
        Dim queryCmd As String = $"DELETE FROM `tabel_harian_karyawan1` WHERE `NIK` = '{DGV_ListCheck.Rows(rowIndex).Cells(0).Value}' AND `Type` = 'No Check'"
        deleteDB.uploadDB(queryCmd)
        cb_dep.SelectedIndex = 0
        Dim queryAll As String = $"SELECT `NIK`, `Name`, `Department`,`Date` FROM `tabel_harian_karyawan1` WHERE `Type` = 'No Check' AND `Department` = '{cb_dep.Text}'"
        dataOnSide(queryAll)
        MsgBox("Data deleted !", MsgBoxStyle.Information, "Register Vacation")
    End Sub
End Class