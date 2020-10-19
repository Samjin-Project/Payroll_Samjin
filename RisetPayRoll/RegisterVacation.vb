Public Class RegisterVacation

    Private Sub RegisterVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Tanggal_Masuk`, `Department` FROM `master employer`"
        dataOnSide(QueryCMD)
        total_data.Text = DGV_DataModify.Rows.Count
        If tb_emp.Text = "" Or tb_nama.Text = "" Then
            b_save.Enabled = False
        End If
 
    End Sub

    Private Sub dataOnSide(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(3), ds.Tables(0).Rows(i).Item(2)}
            DGV_DataModify.Rows.Add(row)
            DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub
    Private Sub DGV_DataModify_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_DataModify.RowHeaderMouseClick
        Console.WriteLine($"Clicked Cell {e.RowIndex}")
        tb_emp.Text = DGV_DataModify.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = DGV_DataModify.Rows(e.RowIndex).Cells(1).Value
        tb_dep.Text = DGV_DataModify.Rows(e.RowIndex).Cells(2).Value
        b_save.Enabled = True
    End Sub

    Sub uploadData()

        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim masterQuery As String = $"INSERT INTO `approval_vacation`(`NIK`, `Status_Approval`, `Approver`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, `EndVacation_Date`, `ReqVacation_Date`, `Department`, `Telp`) 
                 VALUES ('{tb_emp.Text}',
                         'No',
                         'Admin',
                         '{tb_nama.Text}',
                         '{cb_holtype.Text}',
                         '{dt_startdate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_anddate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_reqdate.Value.ToString("yyyy-MM-dd")}',
                         '{tb_dep.Text}',
                         '{tb_telp.Text}')"
        Console.WriteLine("DB Query : " + masterQuery)
        funcDB.uploadDB(masterQuery)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_save.Click
        If cb_holtype.Text = "" Or tb_telp.Text = "" Then
            MsgBox("Data field are empty !", MsgBoxStyle.Exclamation, "Register Vacation")
        Else
            uploadData()
            tb_emp.Text = ""
            tb_nama.Text = ""
            cb_holtype.Text = ""
            tb_telp.Text = ""
            tb_dep.Text = ""
            dt_startdate.Value = Now
            dt_anddate.Value = Now
            dt_reqdate.Value = Now
            b_save.Enabled = False
            MsgBox("Data Saved", MsgBoxStyle.Information, "Register Vacation")
        End If

    End Sub
    'filter data master
    Private Sub filterData(dep As String, emp As String, stDate As String, endDate As String)

        Dim QueryALL As String = $"SELECT `NIK`, `Nama_Karyawan`, `Tanggal_Masuk` , `Department` FROM `master employer`"
        Dim QuerySortEmp As String = $"{QueryALL} WHERE `NIK` = '{emp}' "
        Dim QuerySortDep As String = $"{QueryALL} WHERE `Department` = '{dep}' "
        Dim QuerySortAll As String = $"{QueryALL} WHERE `Department` = '{dep}' AND `NIK` = '{emp}'"

        Dim QueryALLwTime As String = $"{QueryALL} WHERE `Tanggal_Masuk` BETWEEN '{stDate}' AND '{endDate}'"
        Dim QuerySortEmpwTime As String = $"{QueryALL} WHERE (`NIK` = '{emp}') 
            AND (`Tanggal_Masuk` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortDepwTime As String = $"{QueryALL} WHERE (`Department` = '{dep}') 
            AND (`Tanggal_Masuk` BETWEEN  '{stDate}' AND '{endDate}')"
        Dim QuerySortAllwTime As String = $"{QueryALL} WHERE (`Department` = '{dep}') 
            AND (`NIK` = '{emp}')
            AND (`Tanggal_Masuk` BETWEEN  '{stDate}' AND '{endDate}')"

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

        ElseIf Not stDate = endDate Then
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
        dataOnSide(querycmd)
        'menampilkan total data dalan datagrid
        total_data.Text = DGV_DataModify.Rows.Count
    End Sub
    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        tb_emp.Text = ""
        tb_nama.Text = ""
        cb_dep.Text = ""
        fil_emp.Text = ""
        tb_dep.Text = ""
        cb_holtype.Text = ""
        dt_start.Value = Now
        dt_end.Value = Now
        DGV_DataModify.Rows.Clear()
        b_save.Enabled = False
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Tanggal_Masuk`, `Department` FROM `master employer`"
        dataOnSide(QueryCMD)
        Console.WriteLine("Done")
    End Sub
    Private Sub cb_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dep.SelectedIndexChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        Dim depPilihan As String = cb_dep.Text
        Dim emp As String = fil_emp.Text
        DGV_DataModify.Rows.Clear()
        filterData(depPilihan, emp, stDate, endDate)
        Console.WriteLine("Done")
    End Sub

    Private Sub fil_emp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles fil_emp.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
            Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
            Dim depPilihan As String = cb_dep.Text
            Dim emp As String = fil_emp.Text
            DGV_DataModify.Rows.Clear()
            filterData(depPilihan, emp, stDate, endDate)
            Console.WriteLine("Done")
        End If
    End Sub

    Private Sub dt_start_ValueChanged(sender As Object, e As EventArgs) Handles dt_start.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        Dim queryCmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Tanggal_Masuk`, `Department` FROM `master employer` WHERE `Tanggal_Masuk` BETWEEN '{stDate}' AND '{endDate}'"
        DGV_DataModify.Rows.Clear()
        filterData(cb_dep.Text, tb_emp.Text, stDate, endDate)
        total_data.Text = DGV_DataModify.Rows.Count
    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        Dim queryCmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Tanggal_Masuk`, `Department` FROM `master employer` WHERE `Tanggal_Masuk` BETWEEN '{stDate}' AND '{endDate}'"
        DGV_DataModify.Rows.Clear()
        filterData(cb_dep.Text, tb_emp.Text, stDate, endDate)
        total_data.Text = DGV_DataModify.Rows.Count
    End Sub

    Private Sub DGV_DataModify_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataModify.CellContentClick
        Console.WriteLine($"Clicked Cell {e.RowIndex}")
        tb_emp.Text = DGV_DataModify.Rows(e.RowIndex).Cells(0).Value
        tb_nama.Text = DGV_DataModify.Rows(e.RowIndex).Cells(1).Value
        tb_dep.Text = DGV_DataModify.Rows(e.RowIndex).Cells(2).Value
        b_save.Enabled = True
    End Sub
End Class