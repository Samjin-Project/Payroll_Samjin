Public Class RegisterVacation
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Dim selectedRow As Integer

    Private Sub RegisterVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StatusUser = "admin" Then
            cb_dep.Text = My.Settings.Departement
            cb_dep.Enabled = False

        Else
            cb_dep.Items.Clear()
            For Each x As String In MDIParent1.JenisDepartement
                cb_dep.Items.Add(x)
            Next
        End If

        Dim QueryCMD As String = $"SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation` WHERE `Status_Approval` = 'Yes'"
        dataOnSide(QueryCMD)
        b_delete.Enabled = True
    End Sub

    Private Sub dataOnSide(QueryOnReview As String)
        DGV_DataModify.Rows.Clear()
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
            DGV_DataModify.Rows.Clear()
        End If
        total_data.Text = DGV_DataModify.Rows.Count
    End Sub

    Function uploadData() As Boolean
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim cekQuery As String = $"select count(*) from `approval_vacation` WHERE `NIK` = '{tb_emp.Text}' AND `StartVacation_Date` = '{dt_startdate.Value.ToString("yyyy-MM-dd")}'"
        Dim CekDs As DataSet = funcDB.downloadDB(cekQuery)
        Dim jumlahSyarat As Integer = CInt(CekDs.Tables(0).Rows(0).Item(0))

        If jumlahSyarat < 1 Then
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
            MsgBox("Data Saved", MsgBoxStyle.Information, "Register Vacation")
            Return True
        Else
            MsgBox("Perhatian !" + vbCrLf + "Vacation Sudah Dibuat, Silahkan Cek Kembali", MsgBoxStyle.Critical, "Register Vacation")
            Return False
        End If

    End Function

    Sub deleteData(rowIndex As Integer)
        Console.WriteLine("row index :" + DGV_DataModify.Rows(rowIndex).Cells(6).Value.ToString)
        Dim expenddt As Date = Date.ParseExact(DGV_DataModify.Rows(rowIndex).Cells(6).Value.ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

        Dim deleteDB As DataBaseClass = New DataBaseClass
        Dim queryCmd As String = $"DELETE FROM `approval_vacation` WHERE `NIK` = '{DGV_DataModify.Rows(rowIndex).Cells(0).Value.ToString}' AND `StartVacation_Date` = '{expenddt.ToString("yyyy-MM-dd")}' AND `Status_Approval` = 'Yes'"
        deleteDB.uploadDB(queryCmd)
        Dim queryAll As String = $"SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation` WHERE `Status_Approval` = 'Yes'"
        dataOnSide(queryAll)
        MsgBox("Data deleted !", MsgBoxStyle.Information, "Register Vacation")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_save.Click
        If cb_holtype.Text = "" Or tb_nama.Text = "" Or tb_emp.Text = "" Or cb_department.Text = "" Or tb_telp.Text = "" Or tb_reason.Text = "" Then
            MsgBox("Data tidak boleh kosong !", MsgBoxStyle.Exclamation, "Register Vacation")
        Else
            If uploadData() = True Then
                tb_emp.Text = ""
                tb_nama.Text = ""
                cb_holtype.Text = ""
                tb_telp.Text = ""
                cb_department.Text = ""
                dt_startdate.Value = Now
                dt_anddate.Value = Now
                dt_reqdate.Value = Now
                tb_reason.Text = ""
            End If
        End If
    End Sub
    'filter data master
    Private Sub filterData(dep As String, emp As String, stDate As String, endDate As String)
        Dim mainQuery As String = "SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`,
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation`"
        Dim QueryALL As String = $"{mainQuery} WHERE `Status_Approval` = 'Yes'"
        Dim QuerySortEmp As String = $"{mainQuery} WHERE `NIK` = '{emp}' AND `Status_Approval` = 'Yes'"
        Dim QuerySortDep As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `Status_Approval` = 'Yes'"
        Dim QuerySortAll As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `NIK` = '{emp}' AND `Status_Approval` = 'Yes'"

        Dim QueryALLwTime As String = $"{mainQuery} WHERE (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}') AND `Status_Approval` = 'Yes'"
        Dim QuerySortEmpwTime As String = $"{mainQuery} WHERE `NIK` = '{emp}' 
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}') AND `Status_Approval` = 'Yes'"
        Dim QuerySortDepwTime As String = $"{mainQuery} WHERE `Department` = '{dep}'
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}') AND `Status_Approval` = 'Yes'"
        Dim QuerySortAllwTime As String = $"{mainQuery} WHERE `Department` = '{dep}' AND `NIK` = '{emp}'
            AND (`StartVacation_Date` BETWEEN '{stDate}' AND '{endDate}' OR `EndVacation_Date` BETWEEN '{stDate}' AND '{endDate}') AND `Status_Approval` = 'Yes'"

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
        Dim QueryCMD As String = $"SELECT `NIK`, `Status_Approval`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, 
        `EndVacation_Date`,  `Department`,`Reason` FROM `approval_vacation` WHERE `Status_Approval` = 'Yes'"
        dataOnSide(QueryCMD)
        b_delete.Enabled = False
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
        Dim rawData(DGV_DataModify.Rows.Count, DGV_DataModify.Columns.Count - 1) As Object

        ' Copy the column names to the first row of the object array

        For col = 0 To DGV_DataModify.Columns.Count - 1
            rawData(0, col) = DGV_DataModify.Columns(col).HeaderText.ToUpper

        Next

        For col = 0 To DGV_DataModify.Columns.Count - 1
            For row = 0 To DGV_DataModify.Rows.Count - 1
                rawData(row + 1, col) = DGV_DataModify.Rows(row).Cells(col).Value

            Next
        Next
        ' Calculate the final column letter
        Dim finalColLetter As String = String.Empty
        finalColLetter = ExcelColName(DGV_DataModify.Columns.Count) 'Generate Excel Column Name (Column ID)


        sheetIndex += 1
        Ws = Wb.Worksheets(sheetIndex)
        'Ws.name = "Test10"
        Dim excelRange As String = String.Format("A1:{0}{1}", finalColLetter, DGV_DataModify.Rows.Count + 1)
        Ws.Columns(1).ColumnWidth = 10
        Ws.Columns(2).ColumnWidth = 15
        Ws.Columns(3).ColumnWidth = 15
        Ws.Columns(4).ColumnWidth = 15
        Ws.Columns(5).ColumnWidth = 15
        Ws.Columns(6).ColumnWidth = 15
        Ws.Columns(7).ColumnWidth = 15
        Ws.Columns(8).ColumnWidth = 15
        Ws.Columns(9).ColumnWidth = 15


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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Excel File|*.xls,*.xlsx"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            saveExcelFile(saveFileDialog1.FileName)
        End If
    End Sub

    Private Sub b_delete_Click(sender As Object, e As EventArgs) Handles b_delete.Click
        Dim selectedRows As Integer = DGV_DataModify.CurrentRow.Index
        deleteData(selectedRows)
    End Sub
End Class