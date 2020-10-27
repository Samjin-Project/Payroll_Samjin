Public Class RegisterVacation
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub RegisterVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StatusUser = "admin" Then
            cb_dep.Text = My.Settings.Departement
            cb_dep.Enabled = False

        Else

            For Each x As String In MDIParent1.JenisDepartement
                cb_dep.Items.Add(x)
            Next
        End If

        Dim QueryCMD As String = "SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation`"
        dataOnSide(QueryCMD)

    End Sub

    Private Sub dataOnSide(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Dim tglMasuk As String
        If indexDs > 0 Then
            For i As Integer = 0 To indexDs - 1
                Dim nik As String = ds.Tables(0).Rows(i).Item(0)
                Dim AdmDate As DataBaseClass = New DataBaseClass
                Dim queryAdm As String = $"SELECT `Tanggal_Masuk` FROM `master employer` WHERE `NIK` = '{nik}' "
                Dim adm As DataSet = AdmDate.downloadDB(queryAdm)
                If adm.Tables(0).Rows.Count > 0 Then
                    Dim tgl As Date = adm.Tables(0).Rows(0).Item(0)
                    tglMasuk = tgl.ToString("dd/MM/yyyy")
                Else
                    tglMasuk = "Not found"
                End If

                Dim stDate As Date = ds.Tables(0).Rows(i).Item(4)
                Dim endDate As Date = ds.Tables(0).Rows(i).Item(5)

                Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0),
                ds.Tables(0).Rows(i).Item(2).ToString,
                tglMasuk,
                ds.Tables(0).Rows(i).Item(6),
                ds.Tables(0).Rows(i).Item(3),
                ds.Tables(0).Rows(i).Item(1),
                stDate.ToString("dd/MM/yyyy"),
                endDate.ToString("dd/MM/yyyy"),
                ds.Tables(0).Rows(i).Item(7)}
                DGV_DataModify.Rows.Add(row)
                DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
                If i Mod 2 = 1 Then
                    DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        Else
            MsgBox("Data Not Found", MsgBoxStyle.Information, "Register Vacation")
        End If
        total_data.Text = DGV_DataModify.Rows.Count
    End Sub

    Sub uploadData()

        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim masterQuery As String = $"INSERT INTO `approval_vacation`(`NIK`, `Status_Approval`, `Approver`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, `EndVacation_Date`, `ReqVacation_Date`, `Department`, `Telp`, `Reason`) 
                 VALUES ('{tb_emp.Text}',
                         'No',
                         'Admin',
                         '{tb_nama.Text}',
                         '{cb_holtype.Text}',
                         '{dt_startdate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_anddate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_reqdate.Value.ToString("yyyy-MM-dd")}',
                         '{cb_department.Text}',
                         '{tb_telp.Text}',
                         '{tb_reason.Text}')"
        Console.WriteLine("DB Query : " + masterQuery)
        funcDB.uploadDB(masterQuery)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_save.Click
        If cb_holtype.Text = "" Or tb_nama.Text = "" Or tb_emp.Text = "" Or cb_department.Text = "" Or tb_telp.Text = "" Or tb_reason.Text = "" Then
            MsgBox("Data tidak boleh kosong !", MsgBoxStyle.Exclamation, "Register Vacation")
        Else
            uploadData()
            tb_emp.Text = ""
            tb_nama.Text = ""
            cb_holtype.Text = ""
            tb_telp.Text = ""
            cb_department.Text = ""
            dt_startdate.Value = Now
            dt_anddate.Value = Now
            dt_reqdate.Value = Now
            tb_reason.Text = ""
            MsgBox("Data Saved", MsgBoxStyle.Information, "Register Vacation")
        End If

    End Sub
    'filter data master
    Private Sub filterData(dep As String, emp As String, stDate As String, endDate As String)

        Dim QueryALL As String = "SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation`"
        Dim QuerySortEmp As String = $"{QueryALL} WHERE `NIK` = '{emp}' "
        Dim QuerySortDep As String = $"{QueryALL} WHERE `Department` = '{dep}' "
        Dim QuerySortAll As String = $"{QueryALL} WHERE `Department` = '{dep}' AND `NIK` = '{emp}'"

        Dim QueryALLwTime As String = $"{QueryALL} WHERE `StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}'"
        Dim QuerySortEmpwTime As String = $"{QueryALL} WHERE (`NIK` = '{emp}') 
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}')"
        Dim QuerySortDepwTime As String = $"{QueryALL} WHERE (`Department` = '{dep}') 
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}')"
        Dim QuerySortAllwTime As String = $"{QueryALL} WHERE (`Department` = '{dep}') 
            AND (`NIK` = '{emp}')
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}')"

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

    End Sub
    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        tb_emp.Text = ""
        tb_nama.Text = ""
        cb_dep.Text = ""
        fil_emp.Text = ""
        cb_department.Text = ""
        cb_holtype.Text = ""
        dt_start.Value = Now
        dt_end.Value = Now
        DGV_DataModify.Rows.Clear()
        Dim QueryCMD As String = "SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation`"
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
        DGV_DataModify.Rows.Clear()
        filterData(cb_dep.Text, tb_emp.Text, stDate, endDate)
    End Sub

    Private Sub dt_end_ValueChanged(sender As Object, e As EventArgs) Handles dt_end.ValueChanged
        Dim stDate As String = dt_start.Value.ToString("yyyy-MM-dd")
        Dim endDate As String = dt_end.Value.ToString("yyyy-MM-dd")
        DGV_DataModify.Rows.Clear()
        filterData(cb_dep.Text, tb_emp.Text, stDate, endDate)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class