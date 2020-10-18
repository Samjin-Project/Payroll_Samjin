Imports System.Data.OleDb
Public Class UploadFingerData
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub UploadExcel()
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet
        Dim CMD As OleDbCommand

        On Error Resume Next
        OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        OpenFileDialogImport.ShowDialog()

        CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 8.0;")

        DA = New OleDbDataAdapter("select * from [Sheet1$]", CONN)
        CONN.Open()
        DS.Clear()
        DA.Fill(DS)
        CONN.Close()

        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = DS.Tables(0).Rows.Count
        Dim indexCell As Integer = DS.Tables(0).Columns.Count
        Console.WriteLine($"Row Count {indexRows}")
        Console.WriteLine($"Cell Count {indexCell}")
        'Console.WriteLine(DS.GetXml.ToString)

        For i As Integer = 0 To indexRows - 1
            Console.WriteLine("0")
            Dim Date_Finger As String = DS.Tables(0).Rows(i).Item(2)
            Console.WriteLine("opopopo " + Date_Finger)
            Dim Check_In As String = DS.Tables(0).Rows(i).Item(6).ToString
            Console.WriteLine("2")
            Dim Check_Out As String = DS.Tables(0).Rows(i).Item(7).ToString
            Console.WriteLine("3")
            'Console.WriteLine(Check_In.Length)
            'Console.WriteLine(Check_Out.Length)
            Dim edate = Date_Finger
            'edate = "1/12/2010"
            Dim tangal_fin As String() = edate.Split("/")
            Dim daySub As String = ""
            If tangal_fin(1).Length = 2 Then
                daySub = "dd"
            Else
                daySub = "d"
            End If
            Dim monthSub As String = ""
            If tangal_fin(0).Length = 2 Then
                monthSub = "MM"
            Else
                monthSub = "M"
            End If
            Dim xaxa As String = $"{monthSub}/{daySub}/yyyy"
            Console.WriteLine("xaxa " + xaxa)
            Dim expenddt As Date = Date.ParseExact(edate, xaxa, System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Console.WriteLine("masuk Data " + Date_Finger.ToString + "=" + expenddt.ToString("dd-MMM-yyyy"))
            If Check_In Is Nothing Then
                Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{expenddt.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '0')"
                funcDB.uploadDB(masterQuery)
            Else
                If Check_In.Length > 4 And Check_Out.Length > 4 Then
                    Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{expenddt.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '1')"
                    funcDB.uploadDB(masterQuery)
                End If

            End If
        Next
        MsgBox("UploadExcel Succesfully")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadExcel()
        insertToDgv("", "")
    End Sub

    Private Sub insertToDgv(Dep As String, tanggal As String)
        Dim QueryALL As String = $"SELECT `NIK`, `Nama_Karyawan`, DATE_FORMAT(`Date_Finger`,""%d/%m/%Y""), `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement` FROM `finger_employer` "
        Dim QuerySortTgl As String = $"{QueryALL} WHERE `Date_Finger` = '{tanggal}' "
        Dim QuerySortDep As String = $"{QueryALL} WHERE `Departement` = '{Dep}' "
        Dim QuerySortAll As String = $"{QueryALL} WHERE `Departement` = '{Dep}' AND `Date_Finger` = '{tanggal}'"
        Dim querycmd As String = ""
        If tanggal = "" And Dep = "" Then
            querycmd = QueryALL
        ElseIf tanggal = "" And Dep <> "" Then
            querycmd = QuerySortDep
        ElseIf tanggal <> "" And Dep = "" Then
            querycmd = QuerySortTgl
        ElseIf tanggal <> "" And Dep <> "" Then
            querycmd = QuerySortAll
        End If




        'Dibawah ini Contoh Pengambilan data Dari MySql
        Dim DBClass As DataBaseClass = New DataBaseClass ' Inisiasi class yg telah di buat
        Dim ds As DataSet = DBClass.downloadDB(querycmd) ' tabel yg didapat di masukan kedalam variabel ds memiliki tipe data Dataset, queryCMD beris Query SQL atau perintah untuk SELECT atau UPDATE...
        Dim indexDs As Integer = ds.Tables(0).Rows.Count ' cek Jumlah Rows Tabel

        'Setelah jumalh tabel nya diketahui data pada masing2 tabel di masukan ke damal array bertipe data string
        For i As Integer = 0 To indexDs - 1 'looping mengambil data perbaris
            ' ds.tables = nama tabel
            ' rows = baris
            ' item = kolom
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString,
                                                ds.Tables(0).Rows(i).Item(1).ToString,
                                                ds.Tables(0).Rows(i).Item(2).ToString,
                                                ds.Tables(0).Rows(i).Item(3).ToString,
                                                ds.Tables(0).Rows(i).Item(4).ToString,
                                                ds.Tables(0).Rows(i).Item(5).ToString,
                                                ds.Tables(0).Rows(i).Item(6).ToString,
                                                ds.Tables(0).Rows(i).Item(7).ToString,
                                                ds.Tables(0).Rows(i).Item(8).ToString}
            'Setelah dapat dalam bentuk array, array tersebut dimasukan kedalam fungsi dibawah
            'DGV_DataModify.Rows.Add(row) : Row tersebut isinya data satu baris yg telah diambil
            DGV_DataModify.Rows.Add(row)

            'Di bawah ini hanya untuk memprecantik
            DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 0 Then
                DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If

            'menampilkan total data dalan datagrid
            total_data.Text = DGV_DataModify.Rows.Count
        Next
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt_upfinger.ValueChanged
        Dim datePilihan As String = dt_upfinger.Value.ToString("M/d/yyyy")
        Dim depPilihan As String = cb_depfinger.Text
        DGV_DataModify.Rows.Clear()
        insertToDgv(depPilihan, datePilihan)
        Console.WriteLine("Done")
    End Sub

    Private Sub UploadFingerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cb_depfinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_depfinger.SelectedIndexChanged
        Dim datePilihan As String = dt_upfinger.Value.ToString("M/d/yyyy")
        Dim depPilihan As String = cb_depfinger.Text
        DGV_DataModify.Rows.Clear()
        insertToDgv(depPilihan, datePilihan)
        Console.WriteLine("Done")
    End Sub

    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        dt_upfinger.Value = Now
        cb_depfinger.Text = ""
        DGV_DataModify.Rows.Clear()
        insertToDgv("", "")
    End Sub

End Class