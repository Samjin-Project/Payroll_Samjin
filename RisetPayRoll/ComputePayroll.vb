Imports System.Math
Imports Excel = Microsoft.Office.Interop.Excel
Public Class ComputePayroll
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
        table.Columns.Add("BASIC SALARY", GetType(Integer))
        table.Columns.Add("LEMBUR / JAM HARI KERJA", GetType(Integer))
        table.Columns.Add("JAMSOST (1.19% x BS)", GetType(Integer))
        table.Columns.Add("BPJS KESEHATAN", GetType(Integer))
        table.Columns.Add("MANAGM FEE 8 % x BASIC SALARY", GetType(Integer))
        table.Columns.Add("DAYS / WEEK", GetType(Integer))
        table.Columns.Add("FORMULA PEMBAGI", GetType(Integer))
        table.Columns.Add("DAYS ACTIVE", GetType(Integer))
        table.Columns.Add("JAM LEMBUR HARI KERJA", GetType(Integer))
        table.Columns.Add("BASIC SALARY ", GetType(Integer))
        table.Columns.Add("OVERTIME WAGES", GetType(Integer))
        table.Columns.Add("UANG MAKAN PUASA", GetType(Integer))
        table.Columns.Add("JAMSOST (1.19% x BS) ", GetType(Integer))
        table.Columns.Add("BPJS KESEHATAN ", GetType(Integer))
        table.Columns.Add("SUB TOTAL (GROSS SALARY)", GetType(Integer))
        table.Columns.Add("MANAGM FEE 8% X BASIC SALARY ", GetType(Integer))
        table.Columns.Add("TOTAL", GetType(Integer))
        table.Columns.Add("GROSS SALARY", GetType(Integer))
        table.Columns.Add("JAMSOST(1.19% x BS)  ", GetType(Integer))
        table.Columns.Add("BPJS KESEHATAN  ", GetType(Integer))
        table.Columns.Add("SUB TOTAL", GetType(Integer))
        table.Columns.Add("TAKE HOME PAY", GetType(Integer))

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

            Dim QueryPayroll As String = $"SELECT `BasicSalary`,`Gross_Salary`,`managFee_salary`,`payFromSamjin`,`jamsostek`,`bpjs`,`deduction`,`takeHomePay` FROM `tabel_bulanan_karyawan` WHERE `Department` = '{dep}' AND `NIK` = '{nik}'"
            Dim dsPayroll As DataSet = DBClass.downloadDB(QueryPayroll)

            Dim pureSalary, otSalary, jamsostSalary, managfeeSalary, grossSalary, deductin, paymentFromSamjin, takeHomePay, bpjs As Integer

            If dsPayroll.Tables(0).Rows.Count <> 0 Then
                pureSalary = CInt(dsPayroll.Tables(0).Rows(0).Item(0))
                grossSalary = CInt(dsPayroll.Tables(0).Rows(0).Item(1))
                managfeeSalary = CInt(dsPayroll.Tables(0).Rows(0).Item(2))
                paymentFromSamjin = CInt(dsPayroll.Tables(0).Rows(0).Item(3))
                jamsostSalary = CInt(dsPayroll.Tables(0).Rows(0).Item(4))
                bpjs = CInt(dsPayroll.Tables(0).Rows(0).Item(5))
                deductin = CInt(dsPayroll.Tables(0).Rows(0).Item(6))
                takeHomePay = CInt(dsPayroll.Tables(0).Rows(0).Item(7))

                table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, pureSalary, grossSalary, managfeeSalary, paymentFromSamjin, grossSalary, jamsostSalary, bpjs, deductin, takeHomePay)
                'table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, pureSalary, grossSalary, managfeeSalary, paymentFromSamjin, grossSalary, jamsostSalary, bpjs, deductin, takeHomePay)
                'table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, pureSalary, grossSalary, managfeeSalary, paymentFromSamjin, grossSalary, jamsostSalary, bpjs, deductin, takeHomePay)
                Console.WriteLine("RowCount " + table.Rows.Count.ToString)
                Console.WriteLine($"table.Rows.Add({i + 1}, {nik}, {nama}, {posisi}, {dep}, {hairDate}, {status}, {pureSalary}, {grossSalary}, {managfeeSalary}, {paymentFromSamjin}, {grossSalary}, {jamsostSalary}, {bpjs}, {deductin}, {takeHomePay})")
            Else
                table.Rows.Add(i + 1, nik, nama, posisi, dep, hairDate, status, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            End If
        Next
        Return table
    End Function
    Private Sub ExportExcel()
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


        Wb.SaveAs($"D:\ujike5_{DateTime.Now.ToString("mm_ss")}.xlsx", Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing,
         Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
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

    Private Sub DGV_ReviewDaily_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewDaily.CellContentClick
        Dim nik As String = DGV_ReviewDaily.Rows(e.RowIndex).Cells(0).Value
        detailEmpInfo(nik)
        detailEmpSal(nik)
    End Sub
    Private Sub detailEmpInfo(nik As String)
        Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `TanggalMasuk_Karyawan` FROM `master_employer`WHERE `NIK` = '{nik}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Dim tgl As DateTime
        If indexDs > 0 Then
            tb_empDet.Text = ds.Tables(0).Rows(0).Item(0)
            tb_nameDet.Text = ds.Tables(0).Rows(0).Item(1)
            tb_posisiDet.Text = ds.Tables(0).Rows(0).Item(2)
            tgl = ds.Tables(0).Rows(0).Item(3)
            tb_admiss.Text = tgl.ToString("dd MMM yyyy")
        End If
    End Sub
    Private Sub detailEmpSal(nik As String)
        Dim tgl As String = dt_month.Value.ToString("MMM yyyy")
        Dim querycmd As String = $"SELECT `Salary` FROM `tabel_bulanan_karyawan` WHERE `NIK` = '{nik}' AND `Period` = '{tgl}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        If indexDs > 0 Then
            Dim basic As Double = ds.Tables(0).Rows(0).Item(0)
            tb_basicSal.Text = basic.ToString("##,##,###")
            tb_jamsostek.Text = (basic * 1.19 / 100).ToString("##,##,###")
            tb_jamsostekPot.Text = tb_jamsostek.Text
        Else
            tb_basicSal.Text = ""
            tb_jamsostek.Text = ""
        End If

    End Sub
    Private Sub filterData(emp As String)
        Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `TanggalMasuk_Karyawan` FROM `master_employer`WHERE `NIK` = '{emp}'"
        showEmployelist(querycmd)
    End Sub
    Private Sub filterName(name As String)
        Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `TanggalMasuk_Karyawan` FROM `master_employer`WHERE `Nama_Karyawan` LIKE '{name}%' OR `Nama_Karyawan` LIKE '%{name}'"
        showEmployelist(querycmd)
    End Sub
    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        tb_empSearch.Text = ""
        tb_nameSearch.Text = ""
        tb_empDet.Text = ""
        tb_nameDet.Text = ""
        tb_posisiDet.Text = ""
        tb_admiss.Text = ""
        tb_basicSal.Text = ""
        tb_posisi.Text = ""

        dt_month.Value = Now
        Dim querycmd As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Status_Karyawan` FROM `master_employer`"
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

    Private Sub dt_month_ValueChanged(sender As Object, e As EventArgs) Handles dt_month.ValueChanged
        Dim nik As String = tb_empDet.Text
        detailEmpSal(nik)
    End Sub
    Sub createPayroll(dep As String, bulan As Date)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim queryDep As String = $"SELECT `NIK`, `Nama_Karyawan`, `Salary`, `statusBpjs` FROM `master employer` WHERE `Department` = '{dep}' AND `StatusAktive` = '1'"
        Dim dsMaster As DataSet = DBClass.downloadDB(queryDep)
        Dim indexMaster As Integer = dsMaster.Tables(0).Rows.Count
        For i As Integer = 0 To indexMaster - 1
            Dim nik, nama, salary, hariKerja As String
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
                Dim jumlahLembur As Integer = 0
                For j As Integer = 0 To 30
                    Dim tempOT As String = dsPayroll.Tables(0).Rows(0).Item(j + 12)
                    If tempOT = "" Then
                        tempOT = "0"
                    End If
                    Dim loopOt As Integer = CInt(tempOT)
                    jumlahLembur += loopOt
                Next
                dataPayrol = FormulaPayroll(CDbl(salary), hariKerja, jumlahLembur, bulan, statusBpjs)

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
                                                `bpjs`='{bpjs}'
                                                `deduction`='{deductin}',
                                                `takeHomePay`='{takeHomePay}' 
                                                WHERE `NIK` = '{nik}' AND MONTH(`DateMonth`) = '{bulan.ToString("MM")}'"
                DBClass.uploadDB(queryUpdatePayroll)
            End If
        Next

    End Sub
    Function FormulaPayroll(basicSalary As Double, hariKerja As Integer, jumlahLembur As Integer, bulan As Date, StatusBpjs As Boolean) As String()
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

        Dim pureSalary As Double = (basicSalary / indexHari) * hariKerja
        Dim otSalary As Double = upahLembur * jumlahLembur
        Dim jamsostSalary As Double = Math.Round(pureSalary * Math.Round(jamsostek, 4), 0)
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
        createPayroll("ASSEMBLING", dt_month.Value)
        MsgBox("Create Payroll Done")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExportExcel()
    End Sub
End Class