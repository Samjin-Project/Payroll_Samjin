Public Class ListNoCheck
    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        filterData(cb_dep.Text, nik.Text, dt_start.Value.ToString("yyyy-MM-dd"), dt_end.Value.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub filterData(dep As String, emp As String, stDate As String, endDate As String)
        Dim mainQuery As String = "SELECT `NIK`, `Name`, `Department`,`Date` FROM `tabel_harian_karyawan1` "
        Dim qnik As String = ""
        If nik.Text <> "" Then
            qnik = $"`NIK` = '{emp}' AND"
        End If
        Dim QuerySortDep As String = $"{mainQuery} WHERE  {qnik}`Department` = '{dep}' AND (`Date` BETWEEN '{stDate}' AND '{endDate}') AND `Type` = 'No Check'"
        dataOnSide(QuerySortDep)
    End Sub
    Private Sub dataOnSide(QueryOnReview As String)
        DGV_ListCheck.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Dim tglMasuk As String
        If indexDs > 0 Then
            For i As Integer = 0 To indexDs - 1
                Dim nik As String = ds.Tables(0).Rows(i).Item(0)
                Dim name As String = ds.Tables(0).Rows(i).Item(1)
                Dim dep As String = ds.Tables(0).Rows(i).Item(2)
                Dim dateCheck As String = ds.Tables(0).Rows(i).Item(3)

                Dim row As String() = New String() {nik,
                name,
                dep,
                dateCheck}

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
    Private Sub ListNoCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class