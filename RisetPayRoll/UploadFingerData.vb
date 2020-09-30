Imports System.Data.OleDb
Public Class UploadFingerData

    Private Sub UploadExcel()
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet
        Dim CMD As OleDbCommand

        On Error Resume Next
        OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        OpenFileDialogImport.ShowDialog()

        CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 8.0;")

        DA = New OleDbDataAdapter("select * from [1$]", CONN)
        CONN.Open()
        DS.Clear()
        DA.Fill(DS)
        CONN.Close()

        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = DS.Tables(0).Rows.Count
        Dim indexCell As Integer = DS.Tables(0).Columns.Count
        Console.WriteLine($"Row Count {indexRows}")
        Console.WriteLine($"Cell Count {indexCell}")

        For i As Integer = 0 To indexRows - 1
            Dim nik As String = DS.Tables(0).Rows(i).Item(0)
            Dim Nama_Karyawan As String = DS.Tables(0).Rows(i).Item(1)
            Dim Date_Finger As String = DS.Tables(0).Rows(i).Item(2)
            Dim Shift_Finger As String = DS.Tables(0).Rows(i).Item(3)
            Dim On_Duty As String = DS.Tables(0).Rows(i).Item(4)
            Dim Off_Duty As String = DS.Tables(0).Rows(i).Item(5)
            Dim Check_In As String = DS.Tables(0).Rows(i).Item(6)
            Dim Check_Out As String = DS.Tables(0).Rows(i).Item(7)
            Dim Departement As String = DS.Tables(0).Rows(i).Item(8)
            Console.WriteLine(Check_In.Length)
            Console.WriteLine(Check_Out.Length)
            If Check_In.Length > 4 And Check_Out.Length > 4 Then
                Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}')"
                Console.WriteLine("DB Query : " + masterQuery)
                funcDB.uploadDB(masterQuery)
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadExcel()
        insertToDgv("", "")
    End Sub

    Private Sub insertToDgv(Dep As String, tanggal As String)
        Dim QueryALL As String = $"SELECT `NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement` FROM `finger_employer` "
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