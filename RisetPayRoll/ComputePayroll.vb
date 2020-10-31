Imports System.Math
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ComputePayroll
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Function GetTable(ds As DataSet) As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("NO", GetType(Integer))
        table.Columns.Add("EMPL NO.", GetType(String))
        table.Columns.Add("NAME", GetType(String))
        table.Columns.Add("POSITION", GetType(String))
        table.Columns.Add("DEPT", GetType(String))
        table.Columns.Add("HIRE OF DATE", GetType(String))
        table.Columns.Add("STATUS", GetType(String))
        table.Columns.Add("BASIC SALARY", GetType(String))
        table.Columns.Add("LEMBUR / JAM HARI KERJA", GetType(String))
        table.Columns.Add("JAMSOST (1.19% x BS)", GetType(String))
        table.Columns.Add("BPJS KESEHATAN", GetType(String))
        table.Columns.Add("MANAGM FEE 8 % x BASIC SALARY", GetType(String))
        table.Columns.Add("DAYS / WEEK", GetType(String))
        table.Columns.Add("FORMULA PEMBAGI", GetType(String))
        table.Columns.Add("DAYS ACTIVE", GetType(String))
        table.Columns.Add("JAM LEMBUR HARI KERJA", GetType(String))
        table.Columns.Add("BASIC SALARY ", GetType(String))
        table.Columns.Add("OVERTIME WAGES", GetType(String))
        table.Columns.Add("UANG MAKAN PUASA", GetType(String))
        table.Columns.Add("JAMSOST (1.19% x BS) ", GetType(String))
        table.Columns.Add("BPJS KESEHATAN ", GetType(String))
        table.Columns.Add("SUB TOTAL (GROSS SALARY)", GetType(String))
        table.Columns.Add("MANAGM FEE 8% X BASIC SALARY ", GetType(String))
        table.Columns.Add("TOTAL", GetType(String))
        table.Columns.Add("GROSS SALARY", GetType(String))
        table.Columns.Add("JAMSOST(1.19% x BS)  ", GetType(String))
        table.Columns.Add("BPJS KESEHATAN  ", GetType(String))
        table.Columns.Add("SUB TOTAL", GetType(String))
        table.Columns.Add("TAKE HOME PAY", GetType(String))

        Dim DBClass As DataBaseClass = New DataBaseClass

        Dim indexMaster As Integer = ds.Tables(0).Rows.Count
        Dim dep As String = ComboBoxDep.Text



        For i As Integer = 0 To indexMaster - 1
            Dim nama, posisi, hairDate, status As String

            Dim nik As String = ds.Tables(0).Rows(i).Item(0)
            nama = ds.Tables(0).Rows(i).Item(1)
            posisi = ds.Tables(0).Rows(i).Item(2)
            hairDate = ds.Tables(0).Rows(i).Item(4)
            status = ds.Tables(0).Rows(i).Item(5)

            Dim QueryPayroll As String = $"SELECT `BasicSalary`,`Gross_Salary`,`managFee_salary`,`payFromSamjin`,`jamsostek`,`bpjs`,`deduction`,`takeHomePay`,`kehadiran`,`total_OT`, DATE_FORMAT(`DateMonth`,""%d/%m/%Y""),`Ot_wages`,`Attendance` FROM `tabel_bulanan_karyawan` WHERE `Department` = '{dep}' AND `NIK` = '{nik}'"
            Dim queryBase As String = "SELECT * FROM `tabel_basic_payroll` "
            Dim querySalary As String = $"SELECT `Salary` FROM `master employer` WHERE `NIK` = '{nik}'"
            Dim dsPayroll As DataSet = DBClass.downloadDB(QueryPayroll)
            Dim dsBasePayRoll As DataSet = DBClass.downloadDB(queryBase)
            Dim salary As DataSet = DBClass.downloadDB(querySalary)

            Dim totalOT As Integer
            Dim managfeeSalary, grossSalary, attendance, kehadiran, makanPuasa, pureSalary, basicSalary, otSalary, jamsostSalary, deductin, paymentFromSamjin, takeHomePay, bpjs, upahLembur, jumlahHAriKerja, bulan As String
            Dim tanggal As String = ""
            If dsPayroll.Tables(0).Rows.Count <> 0 Then
                basicSalary = makeDot((dsPayroll.Tables(0).Rows(0).Item(0)).ToString)
                grossSalary = makeDot((dsPayroll.Tables(0).Rows(0).Item(1)).ToString)
                managfeeSalary = makeDot((dsPayroll.Tables(0).Rows(0).Item(2)).ToString)
                jamsostSalary = makeDot((dsPayroll.Tables(0).Rows(0).Item(4)).ToString)
                bpjs = makeDot((dsPayroll.Tables(0).Rows(0).Item(5)).ToString)
                deductin = makeDot((dsPayroll.Tables(0).Rows(0).Item(6)).ToString)
                takeHomePay = makeDot((dsPayroll.Tables(0).Rows(0).Item(7)).ToString)

                kehadiran = dsPayroll.Tables(0).Rows(0).Item(8).ToString
                totalOT = CInt(dsPayroll.Tables(0).Rows(0).Item(9))

                tanggal = dsPayroll.Tables(0).Rows(0).Item(10).ToString
                otSalary = makeDot((dsPayroll.Tables(0).Rows(0).Item(11)).ToString)
                attendance = (dsPayroll.Tables(0).Rows(0).Item(12)).ToString


                upahLembur = makeDot((dsBasePayRoll.Tables(0).Rows(0).Item(2)).ToString)
                makanPuasa = makeDot((dsBasePayRoll.Tables(0).Rows(0).Item(6)).ToString)

                pureSalary = makeDot((salary.Tables(0).Rows(0).Item(0)).ToString)
                paymentFromSamjin = makeDot(dsPayroll.Tables(0).Rows(0).Item(2) + (dsPayroll.Tables(0).Rows(0).Item(1)).ToString)
                'PCBA -(Ayu Elia Letari ) 2020018
                'RUBBER -(Fitria Nurmegawati E ) 20190198
                'MOULDING -(Sumarni) 20110126
                'ASSEMBLING -(Tati Suryati ) 20110220
                'PURCHASING


                Dim expenddt As DateTime = DateTime.ParseExact(tanggal, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)

                bulan = DateTime.DaysInMonth(expenddt.Year, expenddt.Month)

                If dep = "PCBA" And dep = "RUBBER" And dep = "MOULDING" Then
                    jumlahHAriKerja = 5
                Else
                    jumlahHAriKerja = 6
                End If

                table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, pureSalary, upahLembur, jamsostSalary, bpjs, managfeeSalary, jumlahHAriKerja, bulan, kehadiran, totalOT, basicSalary, otSalary, makanPuasa, jamsostSalary, bpjs, grossSalary, managfeeSalary, paymentFromSamjin, grossSalary, jamsostSalary, bpjs, deductin, takeHomePay)
                Console.WriteLine("RowCount " + table.Rows.Count.ToString)
                Console.WriteLine($"table.Rows.Add({i + 1}, {nik}, {nama}, {posisi}, {dep}, {hairDate}, {status}, {basicSalary}, {grossSalary}, {managfeeSalary}, {paymentFromSamjin}, {grossSalary}, {jamsostSalary}, {bpjs}, {deductin}, {takeHomePay})")
            Else
                table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            End If
        Next
        Return table
    End Function
    Function makeDot(tempValueInput As String) As String
        If tempValueInput.Length > 3 And tempValueInput.Length < 7 Then
            Dim tempSubValue0 As String = tempValueInput.Substring(0, tempValueInput.Length - 3)
            Dim tempSubValue1 As String = tempValueInput.Substring(tempValueInput.Length - 3, 3)
            tempValueInput = tempSubValue0 + "," + tempSubValue1
            Return tempValueInput
        ElseIf tempValueInput.Length > 6 And tempValueInput.Length < 10 Then

            Dim tempSubValue0 As String = tempValueInput.Substring(0, tempValueInput.Length - 6)
            Dim tempSubValue1 As String = tempValueInput.Substring(tempValueInput.Length - 6, 3)
            Dim tempSubValue2 As String = tempValueInput.Substring(tempValueInput.Length - 3, 3)
            tempValueInput = tempSubValue0 + "," + tempSubValue1 + "," + tempSubValue2
            Return tempValueInput
        Else
            Return tempValueInput
        End If
        Console.WriteLine("make dot done")
    End Function
    Public Sub saveExcelFile(ByVal FileName As String)
        Dim nik As String = ""
        Dim dep As String = ComboBoxDep.Text
        Dim QueryMaster As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tanggal_Masuk`, `Status_karyawan` FROM `master employer` WHERE `Department` = '{dep}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim dsMaster As DataSet = DBClass.downloadDB(QueryMaster)

        Dim table As DataTable = GetTable(dsMaster)

        Console.WriteLine("jumlah rows : " + table.Rows.Count.ToString)
        For y As Integer = 0 To table.Rows.Count - 1
            Console.WriteLine(table.Rows(y).Item(1))
        Next

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
        Dim rawData(table.Rows.Count, table.Columns.Count - 1) As Object

        ' Copy the column names to the first row of the object array

        For col = 0 To table.Columns.Count - 1
            rawData(0, col) = table.Columns(col).ColumnName.ToUpper
        Next

        For col = 0 To table.Columns.Count - 1
            For row = 0 To table.Rows.Count - 1
                rawData(row + 1, col) = table.Rows(row).ItemArray(col)

            Next
        Next


        ' Calculate the final column letter
        Dim finalColLetter As String = String.Empty
        finalColLetter = ExcelColName(table.Columns.Count) 'Generate Excel Column Name (Column ID)


        sheetIndex += 1
        Ws = Wb.Worksheets(sheetIndex)
        'Ws.name = "Test10"
        Dim excelRange As String = String.Format("A5:{0}{1}", finalColLetter, table.Rows.Count + 4)
        Ws.Cells(1, 2).Value = "Dept :"
        Ws.Cells(1, 3).Value = "Assembly"
        Ws.Cells(2, 2).Value = "Bulan :"
        Ws.Cells(2, 3).Value = "Oktober"
        Ws.Cells(3, 2).Value = "Date Export"
        Ws.Cells(3, 3).Value = DateTime.Now
        Ws.Range(excelRange, Type.Missing).Value2 = rawData
        Ws.Range("A5:AC5").WrapText = True
        Ws.Range("A5:AC5").VerticalAlignment = 2
        Ws.Range(excelRange, Type.Missing).Borders.Color = RGB(0, 0, 0)
        Ws.Range("A5:X5").interior.colorindex = 6
        Ws.Range("Y5:AC5").interior.colorindex = 45
        Ws.Rows(5).RowHeight = 45
        Ws.Columns(1).ColumnWidth = 5
        Ws.Columns(2).ColumnWidth = 15
        Ws.Columns(3).ColumnWidth = 15
        Ws.Columns(4).ColumnWidth = 12
        Ws.Columns(5).ColumnWidth = 12
        Ws.Columns(6).ColumnWidth = 12
        Ws.Columns(7).ColumnWidth = 8
        Ws.Columns(8).ColumnWidth = 15
        Ws.Columns(9).ColumnWidth = 15
        Ws.Columns(10).ColumnWidth = 15
        Ws.Columns(11).ColumnWidth = 15
        Ws.Columns(12).ColumnWidth = 15
        Ws.Columns(13).ColumnWidth = 15
        Ws.Columns(14).ColumnWidth = 15
        Ws.Columns(15).ColumnWidth = 15
        Ws.Columns(16).ColumnWidth = 15
        Ws.Columns(17).ColumnWidth = 15
        Ws.Columns(18).ColumnWidth = 15
        Ws.Columns(19).ColumnWidth = 15
        Ws.Columns(20).ColumnWidth = 15
        Ws.Columns(21).ColumnWidth = 15
        Ws.Columns(22).ColumnWidth = 15
        Ws.Columns(23).ColumnWidth = 15
        Ws.Columns(24).ColumnWidth = 15
        Ws.Columns(25).ColumnWidth = 15
        Ws.Columns(26).ColumnWidth = 15
        Ws.Columns(27).ColumnWidth = 15
        Ws.Columns(28).ColumnWidth = 15
        Ws.Columns(29).ColumnWidth = 15
        Ws = Nothing


        Wb.SaveAs(FileName)
        Wb.Close(True, Type.Missing, Type.Missing)
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
    Private Sub ComputePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim querycmd As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Status_Karyawan` FROM `master employer`"
        showEmployelist(querycmd)
    End Sub

    Private Sub showEmployelist(QueryOnReview As String)
        DGV_ReviewDaily.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString,
             ds.Tables(0).Rows(i).Item(1).ToString,
             ds.Tables(0).Rows(i).Item(2).ToString,
             ds.Tables(0).Rows(i).Item(3).ToString}
            DGV_ReviewDaily.Rows.Add(row)
            DGV_ReviewDaily.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ReviewDaily.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub

    Private Sub detailEmpSal(nik As String)
        Dim tgl As String = dt_month.Value.ToString("yyyy-MM")
        Dim querycmd As String = $"SELECT `BasicSalary`, `Kehadiran`, `Total_OT`, `Ot_wages`, `jamsostek`, `bpjs`  FROM `tabel_bulanan_karyawan` WHERE `NIK` = '{nik}' AND `DateMonth` LIKE '{tgl}%'"
        Dim querymaster As String = $"SELECT `Salary` FROM `master employer` WHERE `NIK` = '{nik}'"
        Dim basicSal As Double

        Dim DBmaster As DataBaseClass = New DataBaseClass
        Dim dm As DataSet = DBmaster.downloadDB(querymaster)
        If dm.Tables(0).Rows.Count > 0 Then
            basicSal = Double.Parse(dm.Tables(0).Rows(0).Item(0))
            tb_basicSal.Text = basicSal.ToString("##,##,###")
        Else
            tb_basicSal.Text = ""
        End If

        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        If indexDs > 0 Then
            Dim cut As Double = (ds.Tables(0).Rows(0).Item(0))
            Dim jamsos As Double = ds.Tables(0).Rows(0).Item(4)
            Dim bpjs As Double = ds.Tables(0).Rows(0).Item(5)
            Dim wages As Double = ds.Tables(0).Rows(0).Item(3)
            Dim deduct As Double = cut + jamsos + bpjs
            Dim sup As Double = basicSal + jamsos + bpjs + wages

            tb_potsal.Text = cut.ToString("##,##,###")
            tb_ot.Text = ds.Tables(0).Rows(0).Item(2)
            tb_x1.Text = tb_ot.Text
            tb_attendance.Text = ds.Tables(0).Rows(0).Item(1)
            tb_otwages.Text = wages.ToString("##,##,###")
            tb_jamsostek.Text = jamsos.ToString("##,##,###")
            tb_bpjs.Text = bpjs.ToString("##,##,###")
            tb_jamsostekPot.Text = jamsos.ToString("##,##,###")
            tb_bpjsPot.Text = bpjs.ToString("##,##,###")

            tb_sup.Text = sup.ToString("##,##,###")
            tb_deduct.Text = deduct.ToString("##,##,###")
            tb_total.Text = (sup - deduct).ToString("##,##,###")
        Else
            tb_basicSal.Text = ""
            tb_ot.Text = ""
            tb_attendance.Text = ""
            tb_otwages.Text = ""
            tb_jamsostek.Text = ""
            tb_bpjs.Text = ""
            tb_potsal.Text = ""
            tb_bpjsPot.Text = ""
            tb_jamsostekPot.Text = ""
            tb_sup.Text = ""
            tb_deduct.Text = ""
            tb_total.Text = ""
            MsgBox("Data belum tersedia", MsgBoxStyle.Information, "Compute Payroll Samjin")
        End If

    End Sub
    Private Sub filterData(emp As String)
        Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Tanggal_Masuk` FROM `master employer`WHERE `NIK` = '{emp}'"
        showEmployelist(querycmd)
    End Sub
    Private Sub filterName(name As String)
        Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Tanggal_Masuk` FROM `master employer`WHERE `Nama_Karyawan` LIKE '%{name}%' "
        showEmployelist(querycmd)
    End Sub
    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        tb_empSearch.Text = ""
        tb_nameSearch.Text = ""
        tb_basicSal.Text = ""
        tb_posisi.Text = ""

        dt_month.Value = Now
        Dim querycmd As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Status_Karyawan` FROM `master employer`"
        showEmployelist(querycmd)
    End Sub

    Private Sub tb_empSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_empSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            tb_nameSearch.Text = ""
            Dim emp As String = tb_empSearch.Text
            filterData(emp)
        End If
    End Sub

    Private Sub tb_nameSearch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_nameSearch.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            tb_empSearch.Text = ""
            Dim name As String = tb_nameSearch.Text
            filterName(name)
        End If
    End Sub
    Sub createPayroll(dep As String, bulan As Date)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim queryDep As String = $"SELECT `NIK`, `Nama_Karyawan`, `Salary`, `statusBpjs` FROM `master employer` WHERE `Department` = '{dep}' AND `StatusAktive` = '1'"
        Dim dsMaster As DataSet = DBClass.downloadDB(queryDep)
        Dim indexMaster As Integer = dsMaster.Tables(0).Rows.Count
        Console.WriteLine("indMAs : " + indexMaster.ToString)
        For i As Integer = 0 To indexMaster - 1
            Dim nik, nama, salary, hariKerja, attendance As String
            Dim statusBpjs As Boolean
            nik = dsMaster.Tables(0).Rows(i).Item(0)
            nama = dsMaster.Tables(0).Rows(i).Item(1)
            salary = dsMaster.Tables(0).Rows(i).Item(2)
            statusBpjs = dsMaster.Tables(0).Rows(i).Item(3)
            Dim dataPayrol As String()

            Dim queryall As String = $"SELECT * FROM `tabel_bulanan_karyawan` WHERE MONTH(`DateMonth`)='{bulan.ToString("MM")}' AND `NIK` = '{nik}'"
            Dim dsPayroll As DataSet = DBClass.downloadDB(queryall)
            If dsPayroll.Tables(0).Rows.Count <> 0 Then
                hariKerja = dsPayroll.Tables(0).Rows(0).Item(44)
                attendance = dsPayroll.Tables(0).Rows(0).Item(11)
                Dim jumlahLembur As Integer = 0

                For j As Integer = 0 To 30
                    Dim tempOT As String = dsPayroll.Tables(0).Rows(0).Item(j + 12)
                    Console.WriteLine("tempOT : " + tempOT)
                    If tempOT = "" Then
                        tempOT = "0"
                    End If
                    jumlahLembur += CInt(tempOT)
                Next

                dataPayrol = FormulaPayroll(CDbl(salary), CInt(hariKerja), CInt(attendance), jumlahLembur, bulan, statusBpjs)

                Dim pureSalary, otSalary, jamsostSalary, managfeeSalary, grossSalary, deductin, paymentFromSamjin, takeHomePay, bpjs

                pureSalary = dataPayrol(0)
                otSalary = dataPayrol(1)
                jamsostSalary = dataPayrol(2)
                managfeeSalary = dataPayrol(3)
                grossSalary = dataPayrol(4)
                bpjs = dataPayrol(5)
                deductin = dataPayrol(6)
                paymentFromSamjin = dataPayrol(7)
                takeHomePay = dataPayrol(8)

                Dim queryUpdatePayroll As String = $"UPDATE  `tabel_bulanan_karyawan` SET 
                                                `Total_OT`='{jumlahLembur}',
                                                `BasicSalary`='{pureSalary}',
                                                `Ot_wages`='{otSalary}',
                                                `jamsostek`='{jamsostSalary}',
                                                `Gross_Salary`='{grossSalary}',
                                                `managFee_salary`='{managfeeSalary}',
                                                `payFromSamjin`='{paymentFromSamjin}',
                                                `bpjs`='{bpjs}',
                                                `deduction`='{deductin}',
                                                `takeHomePay`='{takeHomePay}' 
                                                WHERE `NIK` = '{nik}' AND MONTH(`DateMonth`) = '{bulan.ToString("MM")}'"
                DBClass.uploadDB(queryUpdatePayroll)
            End If
        Next

    End Sub
    Function FormulaPayroll(basicSalary As Double, hariKerja As Integer, attendance As Integer, jumlahLembur As Integer, bulan As Date, StatusBpjs As Boolean) As String()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim query As String = $"SELECT * FROM `tabel_basic_payroll`"
        Dim dsFormula As DataSet = DBClass.downloadDB(query)
        Dim namaPayroll As String = dsFormula.Tables(0).Rows(0).Item(1)
        Dim upahLembur As Double = CDbl(dsFormula.Tables(0).Rows(0).Item(2))
        Dim jamsostek As Double = CDbl(dsFormula.Tables(0).Rows(0).Item(3))
        Dim bpjs As Double = CDbl(dsFormula.Tables(0).Rows(0).Item(4))
        Dim managFee As Double = CDbl(dsFormula.Tables(0).Rows(0).Item(5))
        Dim indexHari As Integer = CInt(Date.DaysInMonth(CInt(bulan.ToString("yyyy")), CInt(bulan.ToString("MM"))))
        Dim Total As Double
        Dim paymentFromSamjin As Double
        Dim takeHomePay As Double

        If StatusBpjs = False Then
            bpjs = 0
        End If

        Dim pureSalary As Double = basicSalary / indexHari * (hariKerja)
        Console.WriteLine($"rumus pure : {basicSalary} / {indexHari} * ({hariKerja})")
        Dim otSalary As Double = upahLembur * jumlahLembur
        Dim jamsostSalary As Double = Math.Round(basicSalary * Math.Round(jamsostek, 4), 0)
        Dim managfeeSalary As Double = Math.Round(pureSalary * Math.Round(managFee, 4), 0)
        Dim grossSalary As Double = Math.Round((otSalary + pureSalary + jamsostSalary + bpjs), 0)
        Dim deductin As Double = Math.Round((jamsostSalary + bpjs), 0)

        paymentFromSamjin = Math.Round((grossSalary + managfeeSalary), 0)
        takeHomePay = Math.Round((grossSalary - deductin), 0)

        Console.WriteLine(pureSalary)
        Console.WriteLine(otSalary)
        Console.WriteLine(jamsostSalary)
        Console.WriteLine(managfeeSalary)
        Console.WriteLine(grossSalary)
        Console.WriteLine(deductin)

        'Console.WriteLine($"RUMUS HITUNG  {Total} = Math.Round(({otSalary} + {potonganSalary} + {bpjs}), 0)")
        Dim dataPayroll As String() = New String() {pureSalary.ToString, otSalary.ToString, jamsostSalary.ToString, managfeeSalary.ToString, grossSalary.ToString, bpjs.ToString, deductin.ToString, paymentFromSamjin.ToString, takeHomePay.ToString}
        Return dataPayroll

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each obj In ComboBoxDep.Items
            Dim item = TryCast(obj, String)
            If Not item Is Nothing Then
                Console.WriteLine("item : " + item)
                createPayroll(item, dt_month.Value)
            End If
        Next
        MsgBox("Create Payroll Done")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_export.Click
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Excel File|*.xls"
        saveFileDialog1.Title = "Save an Excel File"
        saveFileDialog1.ShowDialog()
        If saveFileDialog1.FileName <> "" Then
            saveExcelFile(saveFileDialog1.FileName)
        End If
    End Sub


    Private Sub DGV_ReviewDaily_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewDaily.CellClick
        Dim nik As String = DGV_ReviewDaily.Rows(e.RowIndex).Cells(0).Value
        detailEmpSal(nik)
    End Sub

End Class