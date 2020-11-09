﻿Imports System.Data.OleDb
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
        'console.WriteLine($"Row Count {indexRows}")
        'console.WriteLine($"Cell Count {indexCell}")
        ''console.WriteLine(DS.GetXml.ToString)
        Dim flag As Boolean = False
        MDIParent1.TreeView1.Enabled = flag
        MDIParent1.MenuStrip.Enabled = flag
        'MDIParent1.ControlBox = flag

        GroupBox1.Enabled = flag
        GroupBox1.Enabled = flag
        DGV_DataModify.Enabled = flag
        'Me.ControlBox = flag
        Me.Cursor = Cursors.WaitCursor

        ToolStripStatusLabel1.Text = "Creating..."
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = indexRows
        For i As Integer = 0 To indexRows - 1
            'console.WriteLine("0")
            Dim Date_Finger As String = DS.Tables(0).Rows(i).Item(2)
            'console.WriteLine("opopopo " + Date_Finger)
            Dim Check_In As String = DS.Tables(0).Rows(i).Item(6).ToString
            'console.WriteLine("2")
            Dim Check_Out As String = DS.Tables(0).Rows(i).Item(7).ToString
            'console.WriteLine("3")
            ''console.WriteLine(Check_In.Length)
            ''console.WriteLine(Check_Out.Length)
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
            'console.WriteLine("xaxa " + xaxa)
            Dim expenddt As Date = Date.ParseExact(edate, xaxa, System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'console.WriteLine("masuk Data " + Date_Finger.ToString + "=" + expenddt.ToString("dd-MMM-yyyy"))
            Dim queryNIK As String = $"SELECT `NIK`, `DEPARTMENT` FROM `master employer` WHERE `AC_Nomor` = '{DS.Tables(0).Rows(i).Item(0)}'"
            Dim dsNik As DataSet = funcDB.downloadDB(queryNIK)
            'console.WriteLine($"Check In " + Check_In.ToString)
            If Check_In = "" Or Check_Out = "" Then
                'console.WriteLine("START BOLOS")

                Dim DeleteQuery As String = $"DELETE FROM `finger_employer` WHERE `NIK` = '{dsNik.Tables(0).Rows(0).Item(0).ToString}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}'"
                funcDB.uploadDB(DeleteQuery)
                Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`,`AC_Nomor`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                 VALUES ('{dsNik.Tables(0).Rows(0).Item(0).ToString}',
                         '{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{expenddt.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{dsNik.Tables(0).Rows(0).Item(1).ToString}',
                         '0')"
                funcDB.uploadDB(masterQuery)
                'console.WriteLine("END BOLOS")

            Else
                If Check_In.Length > 4 And Check_Out.Length > 4 Then
                    Dim DeleteQuery As String = $"DELETE FROM `finger_employer` WHERE `NIK` = '{dsNik.Tables(0).Rows(0).Item(0).ToString}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}'"
                    funcDB.uploadDB(DeleteQuery)
                    Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`,`AC_Nomor`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                 VALUES ('{dsNik.Tables(0).Rows(0).Item(0).ToString}',
                         '{DS.Tables(0).Rows(i).Item(0)}',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{expenddt.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{dsNik.Tables(0).Rows(0).Item(1).ToString}',
                         '1')"
                    funcDB.uploadDB(masterQuery)
                End If

            End If
            ToolStripProgressBar1.Value = i
        Next
        ToolStripStatusLabel1.Text = "Done"
        flag = True
        MDIParent1.TreeView1.Enabled = flag
        MDIParent1.MenuStrip.Enabled = flag
        MDIParent1.ControlBox = flag

        GroupBox1.Enabled = flag
        GroupBox1.Enabled = flag
        DGV_DataModify.Enabled = flag
        Me.ControlBox = flag

        ToolStripStatusLabel1.Text = "Creating..."
        ToolStripProgressBar1.Visible = True
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = indexRows
        Me.Cursor = Cursors.Default
        MsgBox("UploadExcel Succesfully")
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim queryProses As String = "SELECT * FROM `aktivitas_proses` WHERE 1"
        Dim queryTempBefore As String = $"UPDATE `aktivitas_proses` SET `nama_proses`='up_finger',`nama_user`='{My.Settings.NamaUser}',`status_proses`='1' WHERE `no` = '1'"
        Dim queryTempAfter As String = $"UPDATE `aktivitas_proses` SET `nama_proses`='',`nama_user`='',`status_proses`='0' WHERE `no` = '1'"
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim proses As DataSet = funcDB.downloadDB(queryProses)
        Dim status_proses As Integer = proses.Tables(0).Rows(0).Item(3)
        If proses.Tables(0).Rows(0).Item(0) = 1 Then
            funcDB.uploadDB(queryTempBefore)
            UploadExcel()
            insertToDgv("", "")
            funcDB.uploadDB(queryTempBefore)
        Else
            MsgBox("Upload Data Tidak Bisa Dilakukan, Server sedang sibuk")
        End If
    End Sub

    Private Sub insertToDgv(Dep As String, tanggal As String)
        Dim QueryALL As String = $"SELECT `NIK`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement` FROM `finger_employer` "
        Dim QuerySortTgl As String = $"{QueryALL} WHERE `Date_Finger` = '{tanggal}' "
        Dim QuerySortDep As String = $"{QueryALL} WHERE `Departement` = '{Dep}' "
        Dim QuerySortAll As String = $"{QueryALL} WHERE `Departement` = '{Dep}' AND `Date_Finger` = '{tanggal}'"
        Dim querycmd As String = ""

        If dt_upfinger.Text = " " And Dep = "" Then
            querycmd = QueryALL
        ElseIf dt_upfinger.Text = " " And Dep <> "" Then
            querycmd = QuerySortDep
        ElseIf dt_upfinger.Text <> " " And Dep = "" Then
            querycmd = QuerySortTgl
        ElseIf dt_upfinger.Text <> " " And Dep <> "" Then
            querycmd = QuerySortAll
        End If
        Console.WriteLine(QuerySortTgl)

        'Dibawah ini Contoh Pengambilan data Dari MySql
        Dim DBClass As DataBaseClass = New DataBaseClass ' Inisiasi class yg telah di buat
        Dim ds As DataSet = DBClass.downloadDB(querycmd) ' tabel yg didapat di masukan kedalam variabel ds memiliki tipe data Dataset, queryCMD beris Query SQL atau perintah untuk SELECT atau UPDATE...
        Dim indexDs As Integer = ds.Tables(0).Rows.Count ' cek Jumlah Rows Tabel

        'Setelah jumalh tabel nya diketahui data pada masing2 tabel di masukan ke damal array bertipe data string
        For i As Integer = 0 To indexDs - 1 'looping mengambil data perbaris
            ' ds.tables = nama tabel
            ' rows = baris
            ' item = kolom
            Dim tgl As Date = ds.Tables(0).Rows(i).Item(2)
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString,
                                                ds.Tables(0).Rows(i).Item(1).ToString,
                                                tgl.ToString("dd/MM/yyyy"),
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
        'console.WriteLine("Done")
    End Sub

    Private Sub UploadFingerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StatusUser = "admin" Then
            cb_depfinger.Text = My.Settings.Departement
            cb_depfinger.Enabled = False
        Else
            For Each x As String In MDIParent1.JenisDepartement
                cb_depfinger.Items.Add(x)
            Next
        End If
        dt_upfinger.CustomFormat = " "
        cb_depfinger.Text = ""

    End Sub

    Private Sub b_showall_Click(sender As Object, e As EventArgs) Handles b_showall.Click
        cb_depfinger.Text = ""
        dt_upfinger.CustomFormat = " "
        DGV_DataModify.Rows.Clear()
        insertToDgv("", "")
    End Sub

    Private Sub b_filter_Click(sender As Object, e As EventArgs) Handles b_filter.Click
        Dim datePilihan As String = dt_upfinger.Value.ToString("yyyy/MM/dd")
        Dim depPilihan As String = cb_depfinger.Text
        DGV_DataModify.Rows.Clear()
        insertToDgv(depPilihan, datePilihan)
        'console.WriteLine("Done")
    End Sub

    Private Sub dt_upfinger_ValueChanged(sender As Object, e As EventArgs) Handles dt_upfinger.ValueChanged
        dt_upfinger.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class