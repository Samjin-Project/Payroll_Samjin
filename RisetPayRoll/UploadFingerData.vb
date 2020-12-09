Imports System.ComponentModel
Imports System.Data.OleDb
Public Class UploadFingerData
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Public Class ArgumentType
        Public _ds As DataSet
    End Class
    Private Sub UploadExcel()
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet
        Dim CMD As OleDbCommand

        On Error Resume Next
        OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        Dim result As DialogResult = OpenFileDialogImport.ShowDialog()
        If result = DialogResult.OK Then
            CONN = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 8.0;")
            DA = New OleDbDataAdapter("select * from [Sheet1$]", CONN)
            CONN.Open()
            DS.Clear()
            DA.Fill(DS)
            CONN.Close()
            Dim flag As Boolean = False
            MDIParent1.TreeView1.Enabled = flag
            MDIParent1.MenuStrip.Enabled = flag
            GroupBox1.Enabled = flag
            GroupBox1.Enabled = flag
            DGV_DataModify.Enabled = flag
            Button1.Enabled = flag
            Me.Cursor = Cursors.WaitCursor
            Me.ControlBox = flag

            ToolStripStatusLabel1.Text = "Creating..."
            ToolStripProgressBar1.Visible = True
            ToolStripProgressBar1.Maximum = 100
            'ToolStripProgressBar1.Value = 0
            Dim args As ArgumentType = New ArgumentType()
            args._ds = DS

            'temporary,,,,,
            mainExportExcel(DS)
            'insertToDgv("", "")
            'BackgroundWorker1.RunWorkerAsync(args)
        End If
    End Sub
    Sub mainExportExcel(ds As DataSet)
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = ds.Tables(0).Rows.Count
        Dim indexCell As Integer = ds.Tables(0).Columns.Count
        For i As Integer = 0 To indexRows - 1
            If ds.Tables(0).Rows(i).Item(2).ToString <> "" Then
                'Dim t As Date = ds.Tables(0).Rows(i).Item(2)
                'Debug.WriteLine("date finger: " + ds.Tables(0).Rows(i).Item(2).ToString("yyyy-MM-dd"))

                Dim Date_Finger As String = ds.Tables(0).Rows(i).Item(2)

                Dim Check_In As String = ds.Tables(0).Rows(i).Item(6).ToString
                Dim Check_Out As String = ds.Tables(0).Rows(i).Item(7).ToString
                Dim On_Duty As String = ds.Tables(0).Rows(i).Item(4).ToString
                Dim Off_duty As String = ds.Tables(0).Rows(i).Item(5).ToString
                Debug.WriteLine("In: " + Check_In)
                Debug.WriteLine("Out: " + Check_Out)

                Dim edate = Date_Finger
                Dim tangal_fin As String() = edate.Split("/")
                Dim daySub As String = ""
                Dim dateFinger As String = ""
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
                Dim expenddt As Date = Date.ParseExact(edate, xaxa, System.Globalization.DateTimeFormatInfo.InvariantInfo)
                Dim syaratNik As String


                If ds.Tables(0).Rows(i).Item(0).ToString.Contains("A") Or ds.Tables(0).Rows(i).Item(0).ToString.Contains("K") Then
                    syaratNik = $"`NIK` = '{ds.Tables(0).Rows(i).Item(0)}'"
                Else
                    syaratNik = $"`AC_Nomor` = '{ds.Tables(0).Rows(i).Item(0)}'"
                End If

                Dim queryNIK As String = $"SELECT `NIK`, `DEPARTMENT` FROM `master employer` WHERE {syaratNik}"
                Dim dsNik As DataSet = funcDB.downloadDB(queryNIK)
                If dsNik.Tables(0).Rows.Count <> 0 Then
                    If Check_In = "" Or Check_Out = "" Then
                        Dim DeleteQuery As String = $"DELETE FROM `finger_employer` WHERE `NIK` = '{dsNik.Tables(0).Rows(0).Item(0).ToString}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}'"
                        funcDB.uploadDB(DeleteQuery)
                        Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`,`AC_Nomor`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                        VALUES ('{dsNik.Tables(0).Rows(0).Item(0).ToString}',
                        '{ds.Tables(0).Rows(i).Item(0)}',
                        '{ds.Tables(0).Rows(i).Item(1)}',
                        '{expenddt.ToString("yyyy-MM-dd")}',
                        '{ds.Tables(0).Rows(i).Item(3)}',
                        '{ds.Tables(0).Rows(i).Item(4)}',
                        '{ds.Tables(0).Rows(i).Item(5)}',
                        '{ds.Tables(0).Rows(i).Item(6)}',
                        '{ds.Tables(0).Rows(i).Item(7)}',
                        '{dsNik.Tables(0).Rows(0).Item(1).ToString}',
                        '0')"
                        funcDB.uploadDB(masterQuery)
                        'console.WriteLine("END BOLOS")

                    Else
                        If Check_In.Length > 4 And Check_Out.Length > 4 Then
                            Dim C_in As Date
                            Dim C_out As Date
                            Dim On_d As Date
                            Dim Off_d As Date

                            If Check_In.Contains("/") And Check_Out.Contains("/") Then
                                C_in = ds.Tables(0).Rows(i).Item(6)
                                C_out = ds.Tables(0).Rows(i).Item(7)
                                On_d = ds.Tables(0).Rows(i).Item(4)
                                Off_d = ds.Tables(0).Rows(i).Item(5)

                                Check_In = Format(C_in, "HH:mm").ToString
                                Check_Out = Format(C_out, "HH:mm").ToString
                                On_Duty = Format(On_d, "HH:mm").ToString
                                Off_duty = Format(Off_d, "HH:mm").ToString

                                Debug.WriteLine("IN JOOOOOOOOOOOOOOOOOON")
                            End If



                            Dim DeleteQuery As String = $"DELETE FROM `finger_employer` WHERE `NIK` = '{dsNik.Tables(0).Rows(0).Item(0).ToString}' AND `Date_Finger` = '{expenddt.ToString("yyyy-MM-dd")}'"
                            funcDB.uploadDB(DeleteQuery)
                            Dim masterQuery As String = $"INSERT INTO `finger_employer`(`NIK`,`AC_Nomor`, `Nama_Karyawan`, `Date_Finger`, `Shift_Finger`, `On_Duty`, `Off_Duty`, `Check_In`, `Check_Out`, `Departement`,`Finger Status`) 
                            VALUES ('{dsNik.Tables(0).Rows(0).Item(0).ToString}',
                            '{ds.Tables(0).Rows(i).Item(0)}',
                            '{ds.Tables(0).Rows(i).Item(1)}',
                            '{expenddt.ToString("yyyy-MM-dd")}',
                            '{ds.Tables(0).Rows(i).Item(3)}',
                            '{On_Duty}',
                            '{Off_duty}',
                            '{Check_In}',
                            '{Check_Out}',
                            '{dsNik.Tables(0).Rows(0).Item(1).ToString}',
                            '1')"
                            funcDB.uploadDB(masterQuery)
                        End If

                    End If
                End If

                'Catch ex As Exception

                'End Try
            End If
            BackgroundWorker1.ReportProgress((i / indexRows) * 100)
        Next

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
            'BackgroundWorker1.RunWorkerAsync()
            UploadExcel()
            insertToDgv("", "")
            funcDB.uploadDB(queryTempAfter)

            Me.Cursor = Cursors.Default
            ToolStripStatusLabel1.Text = "Done"
            Dim flag As Boolean = True
            MDIParent1.TreeView1.Enabled = flag
            MDIParent1.MenuStrip.Enabled = flag
            MDIParent1.ControlBox = flag
            GroupBox1.Enabled = flag
            GroupBox1.Enabled = flag
            DGV_DataModify.Enabled = flag
            Me.ControlBox = flag
            MsgBox("UploadExcel Succesfully")
            Button1.Enabled = flag
            ToolStripStatusLabel1.Text = "Ready"
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.Visible = True
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

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim args As ArgumentType = e.Argument
        mainExportExcel(args._ds)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim queryTempAfter As String = $"UPDATE `aktivitas_proses` SET `nama_proses`='',`nama_user`='',`status_proses`='0' WHERE `no` = '1'"
        Dim funcDB As DataBaseClass = New DataBaseClass
        insertToDgv("", "")
        funcDB.uploadDB(queryTempAfter)

        Me.Cursor = Cursors.Default
        ToolStripStatusLabel1.Text = "Done"
        Dim flag As Boolean = True
        MDIParent1.TreeView1.Enabled = flag
        MDIParent1.MenuStrip.Enabled = flag
        MDIParent1.ControlBox = flag
        GroupBox1.Enabled = flag
        GroupBox1.Enabled = flag
        DGV_DataModify.Enabled = flag
        Me.ControlBox = flag
        MsgBox("UploadExcel Succesfully")
        Button1.Enabled = flag
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Visible = True
    End Sub
End Class