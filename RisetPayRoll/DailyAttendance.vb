Public Class DailyAttendance
    Dim queryAll As String = "SELECT `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, `Check Out Date`, `Lateness`, `Early Check Out`, `Basic Time`, `Department` FROM `tabel_harian_karyawan1`"
    Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Departement_Karyawan` FROM `master_employer`"
    Dim flag As Boolean = False
    Dim nik As String
    Private Sub DailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        nik = DGV_SideDaily.Rows(e.RowIndex).Cells(0).Value
        dt_start.Value = Now
        dt_end.Value = Now
        Dim queryGetData As String = $"{queryAll} WHERE `NIK` = '{nik}'"
        showDaily(queryGetData)
        flag = True
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

    Private Sub cb_depSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_depSearch.SelectedIndexChanged
        tb_empSearch.Text = ""
        tb_namaSearch.Text = ""
        DGV_SideDaily.Rows.Clear()
        DGV_ReviewDaily.Rows.Clear()
        Dim dep = cb_depSearch.Text
        dt_start.Value = Now
        dt_end.Value = Now
        Dim querydep As String = $"{QueryCMD} WHERE `Departement_Karyawan` = '{dep}'"
        showEmploye(querydep)
        total_data.Text = DGV_SideDaily.Rows.Count
        Console.WriteLine("Done")
        flag = False
    End Sub

    Private Sub tb_empSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_empSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            tb_namaSearch.Text = ""
            cb_depSearch.Text = ""
            DGV_SideDaily.Rows.Clear()
            DGV_ReviewDaily.Rows.Clear()
            dt_start.Value = Now
            dt_end.Value = Now
            Dim emp As String = tb_empSearch.Text
            Dim queryemp As String = $"{QueryCMD} WHERE `NIK` = '{emp}' "
            showEmploye(queryemp)
            total_data.Text = DGV_SideDaily.Rows.Count
            Console.WriteLine("Done")
            flag = False
        End If
    End Sub

    Private Sub tb_namaSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_namaSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            tb_empSearch.Text = ""
            cb_depSearch.Text = ""
            DGV_SideDaily.Rows.Clear()
            DGV_ReviewDaily.Rows.Clear()
            dt_start.Value = Now
            dt_end.Value = Now
            Dim name As String = tb_namaSearch.Text
            Dim queryname As String = $"{QueryCMD} WHERE `Nama_Karyawan` = '{name}' "
            showEmploye(queryname)
            total_data.Text = DGV_SideDaily.Rows.Count
            Console.WriteLine("Done")
            flag = False
        End If
    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        DGV_ReviewDaily.Rows.Clear()
        If flag = True Then
            Dim queryCmd As String = $"{queryAll} WHERE `NIK` = '{nik}' AND `Date` BETWEEN '{stDate}' AND '{endDate}'"
            showDaily(queryCmd)
        Else
            Dim queryCmd As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
            showDaily(queryCmd)
        End If
        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        DGV_ReviewDaily.Rows.Clear()
        If flag = True Then
            Dim queryCmd As String = $"{queryAll} WHERE `NIK` = '{nik}' AND `Date` BETWEEN '{stDate}' AND '{endDate}'"
            showDaily(queryCmd)
        Else
            Dim queryCmd As String = $"{queryAll} WHERE `Date` BETWEEN '{stDate}' AND '{endDate}'"
            showDaily(queryCmd)
        End If

        total_data.Text = DGV_ReviewDaily.Rows.Count
    End Sub

    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        tb_empSearch.Text = ""
        tb_namaSearch.Text = ""
        cb_depSearch.Text = ""
        dt_start.Value = Now
        dt_end.Value = Now
        DGV_SideDaily.Rows.Clear()
        DGV_ReviewDaily.Rows.Clear()
        showDaily(queryAll)
        showEmploye(QueryCMD)
        flag = False
    End Sub
End Class