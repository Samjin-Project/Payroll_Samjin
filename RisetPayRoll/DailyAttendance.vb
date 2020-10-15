﻿Imports System.Math
Public Class DailyAttendance
    Dim queryAll As String = "SELECT `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, DATE_FORMAT(`Check Out Date`,""%d/%m/%Y""), `Lateness`, `Early Check Out`, `Basic Time`, `Over Time`,`Department` FROM `tabel_harian_karyawan1`"
    Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Department` FROM `master employer`"
    Dim QueryCMDKosong As String = "SELECT `NIK`, `Nama_Karyawan`, `Status_Shift`, `Department` FROM `master employer` WHERE `NIK` = "
    Dim flag As Boolean = False
    Dim nik As String
    Private Sub DailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            showEmploye(QueryCMD)
            Dim nikSyarat As String = DGV_SideDaily.Rows(0).Cells(0).Value
            Dim queryGetData As String = $"{queryAll} WHERE `NIK` = '{nikSyarat}'"
            showDaily(queryGetData)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub showEmploye(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Console.WriteLine("Query : " + QueryOnReview)
        If ds IsNot Nothing Then
            Dim indexDs As Integer = ds.Tables(0).Rows.Count
            For i As Integer = 0 To indexDs - 1
                Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString}
                DGV_SideDaily.Rows.Add(row)
                DGV_SideDaily.Rows(i).HeaderCell.Value = (i + 1).ToString
                If i Mod 2 = 1 Then
                    DGV_SideDaily.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        End If
    End Sub
    Private Sub DGV_SideDaily_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_SideDaily.CellClick
        PickingLeftDgv(e.RowIndex)
    End Sub
    Private Sub DGV_SideDaily_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_SideDaily.RowHeaderMouseClick
        PickingLeftDgv(e.RowIndex)
    End Sub
    Sub PickingLeftDgv(indexRows As Integer)
        Console.WriteLine("PickingLeftDgv")

        Try
            nik = DGV_SideDaily.Rows(indexRows).Cells(0).Value
            DGV_ReviewDaily.Rows.Clear()
            Dim queryGetData As String = $"{queryAll} WHERE `NIK` = '{nik}'"
            showDaily(queryGetData)
        Catch ex As Exception

        End Try

    End Sub
    Function CekTanggal(tanggal As String, rowNow As Integer) As Boolean
        Dim tempTgl As Integer = Convert.ToInt32(tanggal.Substring(0, 2))
        Dim result As Boolean
        Console.WriteLine("Tgl = " + tempTgl.ToString + ", result = " + rowNow.ToString)
        If tempTgl = rowNow + 1 Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function
    Private Sub showDaily(QueryDaily As String)
        Console.WriteLine(QueryDaily)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryDaily)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Dim selisih As Integer = 0
        Dim tanggalNow As Integer = Convert.ToInt32(DateTime.Now.ToString("dd"))

        Dim indexRows As Integer = DGV_SideDaily.CurrentRow.Index
        Dim query As String = QueryCMDKosong + $"'{DGV_SideDaily.Rows(indexRows).Cells(0).Value}'"
        Dim dsKosong As DataSet = DBClass.downloadDB(query)
        Dim indexDsKosong As Integer = dsKosong.Tables(0).Rows.Count
        selisih = tanggalNow - indexDs
        Dim tempHeaderCell As Integer = 1

        For j As Integer = 0 To tanggalNow - 1
            Dim jejak As Integer = 0
            Dim row As String()
            Dim syaratTgl As Boolean
            Dim k As Integer = 0
            Console.WriteLine("jejak " + jejak.ToString + "index rows " + indexDs.ToString)
            If jejak < indexDs Then
                Try
                    For z As Integer = 0 To indexDs - 1
                        syaratTgl = CekTanggal(ds.Tables(0).Rows(z).Item(3), j)
                        If syaratTgl = True Then
                            k = z
                            Exit For
                        End If
                    Next
                Catch ex As IndexOutOfRangeException
                    syaratTgl = False
                End Try
            Else
                syaratTgl = False
            End If
            Console.WriteLine("Urutan" + (j + 1).ToString)
            If syaratTgl = True Then
                row = New String() {ds.Tables(0).Rows(k).Item(0).ToString,
                ds.Tables(0).Rows(k).Item(1).ToString,
                ds.Tables(0).Rows(k).Item(2).ToString,
                ds.Tables(0).Rows(k).Item(3),
                ds.Tables(0).Rows(k).Item(4).ToString,
                ds.Tables(0).Rows(k).Item(5).ToString,
                ds.Tables(0).Rows(k).Item(6).ToString,
                ds.Tables(0).Rows(k).Item(7).ToString,
                ds.Tables(0).Rows(k).Item(8).ToString,
                ds.Tables(0).Rows(k).Item(9).ToString,
                ds.Tables(0).Rows(k).Item(10).ToString,
                ds.Tables(0).Rows(k).Item(11).ToString,
                ds.Tables(0).Rows(k).Item(12).ToString,
                ds.Tables(0).Rows(k).Item(13).ToString}
                jejak = jejak + 1
            Else
                row = New String() {dsKosong.Tables(0).Rows(0).Item(0).ToString,
                dsKosong.Tables(0).Rows(0).Item(1).ToString,
                "No Check",
                DateTime.Now.AddDays((j + 1) - tanggalNow).ToString("dd/MM/yyyy"),
                DateTime.Now.AddDays((j + 1) - tanggalNow).ToString("ddd"),
                dsKosong.Tables(0).Rows(0).Item(2).ToString,
                "-",
                "-",
                "00/00/0000",
                "",
                "",
                "",
                "",
                dsKosong.Tables(0).Rows(0).Item(3).ToString}
            End If

            DGV_ReviewDaily.Rows.Add(row)
            DGV_ReviewDaily.Rows(j).HeaderCell.Value = (j + 1).ToString
            tempHeaderCell = (j + 1)
            If j Mod 2 = 1 Then
                DGV_ReviewDaily.Rows(j).DefaultCellStyle.BackColor = Color.LightGray
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
    Sub clearArea()
        tb_empSearch.Text = ""
        tb_namaSearch.Text = ""
        cb_depSearch.Text = ""
        dt_start.Value = Now
        dt_end.Value = Now
        DGV_SideDaily.Rows.Clear()
        DGV_ReviewDaily.Rows.Clear()
        'showDaily(queryAll)
        showEmploye(QueryCMD)
        flag = False
    End Sub
    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        clearArea()
    End Sub
    Function deleteQuery(nik As String, tgl As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim queryDelete As String = $"DELETE FROM `tabel_harian_karyawan1` WHERE `NIK` = '{nik}' AND `Date` = '{tgl}'"
        DBClass.uploadDB(queryDelete)
    End Function
    Sub CreateFunction()
        If DGV_SideDaily.Rows.Count <> 0 Then
            For i As Integer = 0 To DGV_SideDaily.Rows.Count - 1
                Dim InitDate As String = ""
                Dim NikCreate As String = DGV_SideDaily.Rows(i).Cells(0).Value
                Console.WriteLine("NIK CREATE : " + NikCreate)
                For x As Integer = 0 To DGV_ReviewDaily.Rows.Count - 1
                    'If DGV_ReviewDaily.Rows(x).Cells(2).Value = "No Check" Then
                    For y As Integer = x To DGV_ReviewDaily.Rows.Count - 1
                            InitDate = DGV_ReviewDaily.Rows(y).Cells(3).Value
                            Dim expenddt As Date = Date.ParseExact(InitDate, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                            Dim DBClass As DataBaseClass = New DataBaseClass
                            Dim QueryCreateAbsen As String = $"SELECT `NIK`,`Nama_Karyawan`,DATE_FORMAT(`Date_Finger`,""%y-%m-%d""),`Shift_Finger`,`RecFinIN`,`RecFinOut`,`Departement`, `Finger Status` FROM `finger_employer` WHERE `NIK` = '{NikCreate}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}'"
                            Dim dsAbsen As DataSet = DBClass.downloadDB(QueryCreateAbsen)
                            If dsAbsen IsNot Nothing AndAlso dsAbsen.Tables.Count > 0 AndAlso dsAbsen.Tables(0).Rows.Count > 0 Then
                                Dim QueryInsertCreate As String = ""
                                If dsAbsen.Tables(0).Rows(0).Item(7) = "0" Then
                                    Dim QueryCekVacation As String = $"SELECT `status_approval`,DATE_FORMAT(`StartVacation_Date`,""%y-%m-%d""),DATE_FORMAT(`EndVacation_Date`,""%y-%m-%d"") FROM `approval_vacation` WHERE `NIK` = '{NikCreate}'"
                                    Dim dsCekVacation As DataSet = DBClass.downloadDB(QueryCekVacation)
                                    Dim dateVacation As Nullable(Of Date) = getVcationDate(dsCekVacation, expenddt.ToString("yyyy-MM-dd"))
                                    Console.WriteLine(dateVacation.ToString)
                                    If dateVacation.ToString = #1/1/0001 12:00:00 AM# Then
                                        Console.WriteLine("bolos")
                                        deleteQuery(dsAbsen.Tables(0).Rows(0).Item(0), dsAbsen.Tables(0).Rows(0).Item(2))
                                        QueryInsertCreate = $"INSERT INTO `tabel_harian_karyawan1`( `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, `Check Out Date`, `Lateness`, `Early Check Out`, `Basic Time`, `Over Time`, `Department`,`Absen_Paid`) VALUES ('{dsAbsen.Tables(0).Rows(0).Item(0)}','{dsAbsen.Tables(0).Rows(0).Item(1)}','Absent','{dsAbsen.Tables(0).Rows(0).Item(2)}','{DGV_ReviewDaily.Rows(y).Cells(4).Value}','{dsAbsen.Tables(0).Rows(0).Item(3)}','','','{dsAbsen.Tables(0).Rows(0).Item(2)}','','','0','0','{dsAbsen.Tables(0).Rows(0).Item(6)}','0')"
                                        Dim DBClassUp As DataBaseClass = New DataBaseClass
                                        'Dim queryInsert As String = ""
                                        DBClassUp.uploadDB(QueryInsertCreate)
                                    Else
                                        Console.WriteLine("ijin")
                                        QueryInsertCreate = $"INSERT INTO `tabel_harian_karyawan1`( `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, `Check Out Date`, `Lateness`, `Early Check Out`, `Basic Time`, `Over Time`, `Department`, `Absen_Paid`) VALUES 
                                                        ('{dsAbsen.Tables(0).Rows(0).Item(0)}',
                                                         '{dsAbsen.Tables(0).Rows(0).Item(1)}',
                                                         'Paid Vacation',
                                                         '{dsAbsen.Tables(0).Rows(0).Item(2)}',
                                                         '{DGV_ReviewDaily.Rows(y).Cells(4).Value}',
                                                         '{dsAbsen.Tables(0).Rows(0).Item(3)}',
                                                         '',
                                                         '',
                                                         '{dsAbsen.Tables(0).Rows(0).Item(2)}',
                                                         '',
                                                         '',
                                                         '0',
                                                         '0',
                                                         '{dsAbsen.Tables(0).Rows(0).Item(6)}',
                                                         '1')"
                                        DBClass.uploadDB(QueryInsertCreate)

                                    End If
                                Else
                                    Dim QueryCreate As String = $"SELECT `NIK`,`Nama_Karyawan`,DATE_FORMAT(`Date_Finger`,""%y-%m-%d""),`Shift_Finger`,`RecFinIN`,`RecFinOut`,`Departement`, `Finger Status` FROM `finger_employer` WHERE `NIK` = '{NikCreate}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}' AND `RecFinIN` <> '' AND `RecFinOut` <> ''"
                                    Dim ds As DataSet = DBClass.downloadDB(QueryCreate)
                                    Console.WriteLine("DS : " + ds.Tables.Count.ToString)
                                    Console.WriteLine(ds.GetXml)
                                    If dsAbsen IsNot Nothing AndAlso dsAbsen.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                                        Dim DateOut As DateTime = CheckTime(ds.Tables(0).Rows(0).Item(4), ds.Tables(0).Rows(0).Item(5), expenddt)

                                        Dim indexDs As Integer = ds.Tables(0).Rows.Count
                                        Dim JamKerja As Long() = basicTime(ds.Tables(0).Rows(0).Item(4), ds.Tables(0).Rows(0).Item(5), ds.Tables(0).Rows(0).Item(3), DGV_ReviewDaily.Rows(y).Cells(4).Value, ds.Tables(0).Rows(0).Item(2))
                                        Dim basic As Long = JamKerja(0)
                                        Dim overTime As Long = JamKerja(1)
                                        deleteQuery(ds.Tables(0).Rows(0).Item(0), ds.Tables(0).Rows(0).Item(2))
                                        QueryInsertCreate = $"INSERT INTO `tabel_harian_karyawan1`( `NIK`, `Name`, `Type`, `Date`, `Day`, `Shift`, `Check In`, `Check Out`, `Check Out Date`, `Lateness`, `Early Check Out`, `Basic Time`, `Over Time`, `Department` , `Absen_Paid`) VALUES 
                                                        ('{ds.Tables(0).Rows(0).Item(0)}',
                                                         '{ds.Tables(0).Rows(0).Item(1)}',
                                                         'Check IN',
                                                         '{ds.Tables(0).Rows(0).Item(2)}',
                                                         '{DGV_ReviewDaily.Rows(y).Cells(4).Value}',
                                                         '{ds.Tables(0).Rows(0).Item(3)}',
                                                         '{ds.Tables(0).Rows(0).Item(4)}',
                                                         '{ds.Tables(0).Rows(0).Item(5)}',
                                                         '{DateOut.ToString("yyyy-MM-dd")}',
                                                         '',
                                                         '',
                                                         '{basic.ToString}',
                                                         '{overTime.ToString}',
                                                         '{ds.Tables(0).Rows(0).Item(6)}',
                                                         '1')"
                                        DBClass.uploadDB(QueryInsertCreate)
                                        Console.WriteLine("Jmlah Tabel : " + indexDs.ToString)
                                    End If
                                End If
                                CreateViewDaily(dsAbsen, x)
                            End If
                        Next
                        Exit For
                    'End If
                Next
            Next
        End If
    End Sub
    Function cekDataBulanan(nik As String, cekDate As String) As String
        Dim dateCekData As Date = Date.ParseExact(cekDate, "yy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim query As String = $"SELECT `attendance` FROM `tabel_bulanan_karyawan` WHERE MONTH(`DateMonth`) = '{dateCekData.ToString("MM")}' AND `NIK` = '{nik}'"
        Dim dsAbsen As DataSet = DBClass.downloadDB(query)
        If dsAbsen.Tables(0).Rows.Count <> 0 Then
            Return dsAbsen.Tables(0).Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
    Function cekOverTime(nik As String, cekDate As Date) As String()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim query As String = $"SELECT `Over Time`, `absen_paid` FROM `tabel_harian_karyawan1` WHERE `Date` = '{cekDate.ToString("yyyy-MM-dd")}' AND `NIK` = '{nik}'"
        Dim dsAbsen As DataSet = DBClass.downloadDB(query)
        Dim outPut As String()
        If dsAbsen.Tables(0).Rows.Count > 0 Then
            outPut = New String() {dsAbsen.Tables(0).Rows(0).Item(0), dsAbsen.Tables(0).Rows(0).Item(1)}
        Else
            outPut = New String() {"", ""}
        End If
        Console.WriteLine("Out " + outPut(0) + outPut(1))
        Return outPut
    End Function
    Sub CreateViewDaily(ds As DataSet, rowsData As Integer)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim nik As String = ds.Tables(0).Rows(rowsData).Item(0)
        Dim nama As String = ds.Tables(0).Rows(rowsData).Item(1)
        Dim dep As String = ds.Tables(0).Rows(rowsData).Item(6)
        Dim dateMonth As String = ds.Tables(0).Rows(rowsData).Item(2)
        Dim nilai As String = ""
        Console.WriteLine("date month : " + dateMonth.ToString)
        Dim tempDate As Date = Date.ParseExact(dateMonth, "yy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim hari As String = tempDate.ToString("dd")

        If hari.Substring(0, 1) = "0" Then
            hari = hari.Substring(1, 1)
        End If

        Dim overTime As String() = cekOverTime(nik, tempDate)
        If overTime(0) <> "" Then
            Dim updateAtte As String = cekDataBulanan(nik, dateMonth)
            Dim QueryCreateViewDaily As String
            If updateAtte <> "" Then
                Console.WriteLine("update daily view : " + overTime(1))
                Dim attendance As Integer
                Dim inQuery As String
                If overTime(1) = "False" Then
                    attendance = Convert.ToInt32(updateAtte) + 1
                    inQuery = $"`attendance`='{attendance}',"
                Else
                    inQuery = ""
                End If

                Dim nilaiOt As String = overTime(0)
                If nilaiOt = "0" Then
                    nilaiOt = ""
                End If
                Dim kehadiran As String = $"SELECT * FROM `tabel_harian_karyawan1` WHERE `NIK`='{nik}' AND `Date` BETWEEN '{tempDate.ToString("yyyy-MM")}-01' AND '{tempDate.ToString("yyyy-MM")}-31' AND `Basic Time` <> '0' AND `Absen_Paid` = '1' "
                Dim dsKehadiran As DataSet = DBClass.downloadDB(kehadiran)
                Dim kehadiranValue As String = "0"
                If dsKehadiran IsNot Nothing Then
                    kehadiranValue = dsKehadiran.Tables(0).Rows.Count
                End If

                QueryCreateViewDaily = $"UPDATE `tabel_bulanan_karyawan` SET 
                                            `Transport`='',
                                            `Transport_Amount`='',
                                            `Shift`='',
                                            `Shift_Amount`='',
                                            `Meal`='',
                                            `Meal Amount`='',
                                            {inQuery}
                                            `{hari}`='{overTime(0)}',
                                            `Kehadiran` = '{kehadiranValue}' 
                                            WHERE MONTH(`DateMonth`)='{tempDate.ToString("MM")}' AND `NIK` = '{nik}'"
            Else
                Console.WriteLine("insert daily view")
                Console.WriteLine("overtime 1")


                Dim attendance(2) As String
                If overTime(1) = "False" Then
                    attendance = {"`attendance`,", "'1',"}
                Else
                    attendance = {"`attendance`,", "'0',"}
                End If
                dateMonth = tempDate.ToString("yyyy-MM-dd")
                Dim nilaiOt As String = overTime(0)
                If nilaiOt = "0" Then
                    nilaiOt = ""
                End If
                Dim kehadiran As String = $"SELECT * FROM `tabel_harian_karyawan1` WHERE `NIK`='{nik}' AND `Date` BETWEEN '{tempDate.ToString("yyyy-MM")}-01' AND '{tempDate.ToString("yyyy-MM")}-31' AND `Basic Time` <> '0' AND `Absen_Paid` = '1' "
                Dim dsKehadiran As DataSet = DBClass.downloadDB(kehadiran)
                Dim kehadiranValue As String = "0"
                If dsKehadiran Is Nothing Then
                    kehadiranValue = dsKehadiran.Tables(0).Rows.Count
                End If

                QueryCreateViewDaily = $"INSERT INTO `tabel_bulanan_karyawan`(`NIK`, `Name`,`DateMonth`, `Department`, `Transport`, `Transport_Amount`, `Shift`, `Shift_Amount`, `Meal`, `Meal Amount`, {attendance(0)}`{hari}`,`Kehadiran`, `BasicSalary`) VALUES 
                                        (
                                            '{nik}',
                                            '{nama}',
                                            '{dateMonth}',
                                            '{dep}',
                                            '',
                                            '',
                                            '',
                                            '',
                                            '',
                                            '',
                                            {attendance(1)}
                                            '{nilaiOt}',
                                            '{kehadiranValue}',
                                            '') "
            End If
            DBClass.uploadDB(QueryCreateViewDaily)
        End If

    End Sub
    Function getVcationDate(ds As DataSet, dateNow As String) As Date
        Dim outputDate As String = ""
        Dim indexTabel As Integer = ds.Tables(0).Rows.Count

        If indexTabel > 0 Then
            Console.WriteLine("data set vacation Start : " + ds.Tables(0).Rows(0).Item(1))
            Console.WriteLine("data set vacation End : " + ds.Tables(0).Rows(0).Item(2))
        End If

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Dim startDate As Date = Date.ParseExact(ds.Tables(0).Rows(i).Item(1), "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim endDate As Date = Date.ParseExact(ds.Tables(0).Rows(i).Item(2), "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)

            If startDate = dateNow Then
                Return dateNow
            ElseIf endDate = dateNow Then
                Return dateNow
            Else
                Dim diffTimeday As Long = DateDiff(DateInterval.Day, startDate, startDate)
                For j As Integer = outputDate To Convert.ToInt32(diffTimeday) - 1
                    Dim tempDate As Date = startDate.AddDays(i + 1)
                    If tempDate = dateNow Then
                        Return dateNow
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function
    Function CheckTime(timeIn As String, timeOut As String, dateIn As Date) As Date

        Dim tempTimeIn As DateTime = Convert.ToDateTime(timeIn)
        Dim tempTimeOut As DateTime = Convert.ToDateTime(timeOut)
        Dim OutDate As DateTime
        If tempTimeIn > tempTimeOut Then
            OutDate = dateIn.AddDays(1)
        Else
            OutDate = dateIn
        End If
        Return OutDate
    End Function
    Function cekLibur(tanggal As String) As Boolean
        Dim QueryCreate As String = $"SELECT * FROM `hari_kerja` WHERE `Date` = '{tanggal}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryCreate)
        Dim fa As Boolean
        If ds.Tables(0).Rows.Count <> 0 Then
            fa = True
        Else
            fa = False
        End If

        Return fa
    End Function

    Function basicTime(timeIn As String, timeOut As String, ShiftData As String, WorkDay As String, tanggal As String) As Long()
        Dim OutputCounter(2) As Long
        Dim tempTimeIn As DateTime = Convert.ToDateTime(timeIn)
        Dim tempTimeOut As DateTime = Convert.ToDateTime(timeOut)
        Dim OutDate As DateTime
        Dim libur As Boolean = cekLibur(tanggal)
        If ShiftData = "SHIFT1" Or ShiftData = "SHIFT2" Or ShiftData = "SHIFT3" Then
            Dim resultDiff As Long
            If tempTimeIn > tempTimeOut Then
                Dim diffTimeA As Long = DateDiff(DateInterval.Minute, tempTimeIn, #23:59#) + 1
                Dim diffTimeB As Long = DateDiff(DateInterval.Minute, #00:00#, tempTimeOut) + 1
                Console.WriteLine("Result Diff A : " + diffTimeA.ToString)
                Console.WriteLine("Result Diff B : " + diffTimeB.ToString)
                resultDiff = (diffTimeA + diffTimeB) / 60
            Else
                Dim diffTimeA As Long = DateDiff(DateInterval.Minute, tempTimeIn, tempTimeOut)
                resultDiff = diffTimeA / 60
            End If

            If libur = False Then
                If WorkDay = "Sat" Then
                    OutputCounter(0) = 5
                    OutputCounter(1) = resultDiff - 5
                Else
                    OutputCounter(0) = 7
                    OutputCounter(1) = resultDiff - 7
                End If
            Else
                OutputCounter(0) = 0
                OutputCounter(1) = resultDiff
            End If
            Console.WriteLine("Result Diff : " + resultDiff.ToString)
        Else
            Dim diffTimeA As Long = DateDiff(DateInterval.Minute, tempTimeOut, tempTimeIn)
            Dim resultDiff As Long = diffTimeA / 60
            If libur = False Then
                If resultDiff > 8 Then
                    OutputCounter(0) = 8
                    OutputCounter(1) = resultDiff - 8
                Else
                    OutputCounter(0) = 8
                    OutputCounter(1) = 0
                End If
            Else
                OutputCounter(0) = 0
                OutputCounter(1) = resultDiff
            End If
        End If
        Return OutputCounter
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CreateFunction()
        DGV_SideDaily.Rows.Clear()
        DGV_ReviewDaily.Rows.Clear()
        Try
            showEmploye(QueryCMD)
            Dim nikSyarat As String = DGV_SideDaily.Rows(0).Cells(0).Value
            Dim queryGetData As String = $"{queryAll} WHERE `NIK` = '{nikSyarat}'"
            showDaily(queryGetData)
            MsgBox("Create Succes")
        Catch ex As Exception

        End Try
    End Sub

End Class