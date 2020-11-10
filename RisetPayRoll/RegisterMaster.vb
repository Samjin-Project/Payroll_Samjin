
Imports System.Data.OleDb
Public Class RegisterMaster
    Dim f_edit As Boolean = False
    Dim f_create As Boolean = False
    Dim r_index As Integer
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub RegisterMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Department`, `StatusAktive` FROM `master employer`"
        dataOnReview(QueryCMD)
        DGV_Setting_Display()
        clearData()

        dt_masuk.CustomFormat = " "

        'button
        b_save.Visible = False
        b_edit.Enabled = False
        b_cancel.Visible = False
        b_create.Enabled = True

    End Sub

    Private Sub DGV_Setting_Display()
        With DGV_ReviewMaster
            .Columns("kolom_Nik").Width = 80
        End With
    End Sub
    Private Sub UploadExcel()
        Dim CONN As OleDbConnection
        Dim DA As OleDbDataAdapter
        Dim DS As New DataSet
        Dim CMD As OleDbCommand
        Dim dataCount As Integer = 0
        Dim total As Integer = 0

        Dim funcDB As DataBaseClass = New DataBaseClass

        Dim flag As Boolean = False
        MDIParent1.TreeView1.Enabled = flag
        MDIParent1.MenuStrip.Enabled = flag
        MDIParent1.ControlBox = flag
        Me.ControlBox = flag
        Me.Enabled = flag

        MDIParent1.ToolStripStatusLabelMdi.Text = "Importing..."
        MDIParent1.ToolStripProgressBarMdi.Visible = True
        MDIParent1.ToolStripProgressBarMdi.Value = 0

        Try
            'On Error Resume Next
            OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"

            Dim result As DialogResult = OpenFileDialogImport.ShowDialog()

            If result = DialogResult.OK Then
                Debug.WriteLine("before Conn")
                CONN = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 12.0 Xml;")
                DA = New OleDbDataAdapter("select * from [Sheet1$]", CONN)
                Debug.WriteLine("Conn Open")
                CONN.Open()
                Debug.WriteLine("ds Clear")
                DS.Clear()
                DA.Fill(DS)
                DGV_ReviewMaster.DataSource = DS.Tables("a")
                CONN.Close()
                Debug.WriteLine("Conn Close")

                Dim indexRows As Integer = DS.Tables(0).Rows.Count
                Console.WriteLine("Tanggal Masuk : " + DS.Tables(0).Rows(2).Item(9))
                Console.WriteLine("indexRows" + indexRows.ToString)
                total = indexRows - 3
                MDIParent1.ToolStripProgressBarMdi.Maximum = total
                For i As Integer = 1 To indexRows - 3
                    Console.WriteLine("Nik " + DS.Tables(0).Rows(i).Item(1).ToString)
                    Dim AC_no As String = ""
                    If DS.Tables(0).Rows(i).Item(1).ToString.Count = 6 Then
                        AC_no = DS.Tables(0).Rows(i).Item(1).ToString.Substring(1, 5)
                    Else
                        AC_no = DS.Tables(0).Rows(i).Item(1).ToString.Substring(1, 6)
                    End If
                    Debug.WriteLine(DS.Tables(0).Rows(i).Item(9).ToString)
                    '                Dim admisionDateIn As Date = Date.ParseExact(DS.Tables(0).Rows(i).Item(9).ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    Dim admisionDateIn As Date = DS.Tables(0).Rows(i).Item(9)

                    Dim admisionDateOut As String
                    If DS.Tables(0).Rows(i).Item(10).ToString = "" Then
                        admisionDateOut = ""
                    Else
                        admisionDateOut = Date.ParseExact(DS.Tables(0).Rows(i).Item(10).ToString, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString("yyyy-MM-dd")
                    End If
                    Debug.WriteLine(DS.Tables(0).Rows(i).Item(6))

                    Dim tglLahir As Date = DS.Tables(0).Rows(i).Item(6)
                    Debug.WriteLine(tglLahir.ToString("yyyy-MM-dd"))

                    Dim masterQuery As String = $"INSERT INTO `master employer`(`AC_nomor`,`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`,`Tanggal_Keluar`, `Salary`,`StatusBpjs`,`StatusAktive`) 
                 VALUES ('{AC_no }',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{tglLahir.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '{admisionDateIn.ToString("yyyy-MM-dd")}',
                         '{admisionDateOut}',
                         '{DS.Tables(0).Rows(i).Item(11)}',
                         '{DS.Tables(0).Rows(i).Item(12)}',
                         '{DS.Tables(0).Rows(i).Item(13)}'
                         )"
                    Console.WriteLine("DB Query : " + masterQuery)
                    MDIParent1.ToolStripProgressBarMdi.Value = i

                    Try
                        funcDB.uploadDB(masterQuery)
                        dataCount = i
                    Catch ex As Exception
                        Debug.WriteLine($"Jumlah Duplicate {i}")
                    End Try
                Next
                MsgBox($"Upload Selesai, {dataCount.ToString} File Tersimpan")
            End If
        Catch ex As Exception
            MsgBox($"Data Excel Error Atau File Sedang Dibuka, {vbCrLf}{ dataCount.ToString} File Tersimpan, {(total - dataCount).ToString} Tidak Tersimpan")
        End Try
        flag = True
        MDIParent1.TreeView1.Enabled = flag
        MDIParent1.MenuStrip.Enabled = flag
        MDIParent1.ControlBox = flag
        Me.ControlBox = flag
        Me.Enabled = flag

        MDIParent1.ToolStripStatusLabelMdi.Text = "Status"
        MDIParent1.ToolStripProgressBarMdi.Visible = False
        MDIParent1.ToolStripProgressBarMdi.Value = 0
    End Sub

    Private Sub dataOnReview(QueryOnReview As String)
        DGV_ReviewMaster.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString}
            DGV_ReviewMaster.Rows.Add(row)
            Debug.WriteLine(ds.Tables(0).Rows(i).Item(3).ToString)
            If ds.Tables(0).Rows(i).Item(3).ToString = "False" Then
                DGV_ReviewMaster.Rows(i).DefaultCellStyle.ForeColor = Color.Blue
            End If
            DGV_ReviewMaster.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ReviewMaster.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
        total_data.Text = DGV_ReviewMaster.Rows.Count
    End Sub

    Private Sub detailDataMaster(Nik As String)
        Dim QueryCMD As String = $"SELECT * FROM `master employer` WHERE `NIK` = '{Nik}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryCMD)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        'Console.WriteLine(ds.GetXml)
        If indexDs > 0 Then
            Debug.WriteLine(ds.Tables(0).Rows(0).Item(7))
            Debug.WriteLine(ds.Tables(0).Rows(0).Item(10))

            Dim tglLahir As Date = DateTime.ParseExact(ds.Tables(0).Rows(0).Item(7), "yyyy-MM-dd", Nothing)
            Dim tglMasuk As Date = DateTime.ParseExact(ds.Tables(0).Rows(0).Item(10), "yyyy-MM-dd", Nothing)
            Dim tglKeluar As String = ds.Tables(0).Rows(0).Item(11).ToString
            Dim syaratOut As Integer = 0
            Debug.WriteLine(tglKeluar)
            If tglKeluar.Substring(0, 2).Contains("/") Then
                syaratOut = CInt(tglKeluar.Substring(4, 4))
            Else
                syaratOut = CInt(tglKeluar.Substring(6, 4))
            End If
            Debug.WriteLine(syaratOut)
            Console.WriteLine("tglOut" + ds.Tables(0).Rows(0).Item(11))
            If syaratOut = 1 Then
                'dt_createKeluar.Format = DateTimePickerFormat.Custom
                dt_createKeluar.CustomFormat = " "
                Debug.WriteLine("test 1")
            Else
                Debug.WriteLine("test 0")
                dt_createKeluar.CustomFormat = "dd/MM/yyyy"
                dt_createKeluar.Value = New Date(CInt(tglKeluar.Substring(6, 4)), CInt(tglKeluar.Substring(3, 2)), CInt(tglKeluar.Substring(0, 2)))
            End If
            Dim gaji As Double = ds.Tables(0).Rows(0).Item(13)

            tb_empDet.Text = ds.Tables(0).Rows(0).Item(2)
            tb_nama.Text = ds.Tables(0).Rows(0).Item(3).ToString
            cb_createPosisi.Text = ds.Tables(0).Rows(0).Item(4).ToString
            cb_dep.Text = ds.Tables(0).Rows(0).Item(5).ToString
            tb_pob.Text = ds.Tables(0).Rows(0).Item(6).ToString
            dt_lahir.CustomFormat = "dd/MM/yyyy"
            dt_lahir.Value = tglLahir
            If ds.Tables(0).Rows(0).Item(8) = "L" Then
                cb_createJK.Text = "Laki-laki"
            ElseIf ds.Tables(0).Rows(0).Item(8) = "P" Then
                cb_createJK.Text = "Perempuan"
            End If
            tb_pend.Text = ds.Tables(0).Rows(0).Item(9).ToString
            dt_createMasuk.CustomFormat = "dd/MM/yyyy"
            dt_createMasuk.Value = tglMasuk
            cb_stat.SelectedItem = ds.Tables(0).Rows(0).Item(12).ToString
            tb_salary.Text = gaji.ToString("##,##,###")

            If ds.Tables(0).Rows(0).Item(14) = "1" Then
                cb_bpjs.Text = "Ya"
            Else
                cb_bpjs.Text = "Tidak"
            End If

            If ds.Tables(0).Rows(0).Item(15) = "1" Then
                cb_aktif.Text = "Ya"
            Else
                cb_aktif.Text = "Tidak"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim queryProses As String = "SELECT * FROM `aktivitas_proses` WHERE 1"
        Dim queryTempBefore As String = $"UPDATE `aktivitas_proses` SET `nama_proses`='up_master',`nama_user`='{My.Settings.NamaUser}',`status_proses`='1' WHERE `no` = '1'"
        Dim queryTempAfter As String = $"UPDATE `aktivitas_proses` SET `nama_proses`='',`nama_user`='',`status_proses`='0' WHERE `no` = '1'"
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim proses As DataSet = funcDB.downloadDB(queryProses)
        Dim status_proses As Integer = proses.Tables(0).Rows(0).Item(3)
        If proses.Tables(0).Rows(0).Item(0) = 1 Then
            funcDB.uploadDB(queryTempBefore)
            UploadExcel()
            funcDB.uploadDB(queryTempAfter)
        Else
            MsgBox("Upload Data Tidak Bisa Dilakukan, Server sedang sibuk")
        End If

    End Sub
    Private Sub filterData(dep As String, jk As String, masuk As String)
        Dim AktiveStatus As String
        If CheckBoxRetired.Checked = True Then
            AktiveStatus = ""
        Else
            AktiveStatus = " AND `StatusAktive` = '1'"
        End If

        Dim queryAll As String = "SELECT `NIK`, `Nama_Karyawan`, `Department`, `StatusAktive` FROM `master employer`"
        Dim querySortDep As String = $"{queryAll} WHERE `Department` = '{dep}'" + AktiveStatus
        Dim querySortJK As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'" + AktiveStatus
        Dim querySortAll As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'AND `Department` = '{dep}'" + AktiveStatus

        Dim queryAllwTime As String = $"{queryAll} WHERE `Tanggal_Masuk` = '{masuk}'" + AktiveStatus
        Dim querySortDepwTime As String = $"{queryAll} WHERE `Department` = '{dep}' AND `Tanggal_Masuk` = '{masuk}'" + AktiveStatus
        Dim querySortJKwTime As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}' AND `Tanggal_Masuk` = '{masuk}'" + AktiveStatus
        Dim querySortAllwTime As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'AND `Department` = '{dep}' AND `Tanggal_Masuk` = '{masuk}'" + AktiveStatus



        Dim querycmd As String = ""
        If dt_masuk.Text = " " Then
            If dep = "" And jk <> "" Then
                querycmd = querySortJK
            ElseIf dep <> "" And jk = "" Then
                querycmd = querySortDep
            ElseIf dep <> "" And jk <> "" Then
                querycmd = querySortAll
            ElseIf dep = "" And jk = "" Then
                querycmd = queryAll
            End If
        Else
            If dep = "" And jk <> "" Then
                querycmd = querySortJKwTime
            ElseIf dep <> "" And jk = "" Then
                querycmd = querySortDepwTime
            ElseIf dep <> "" And jk <> "" Then
                querycmd = querySortAllwTime
            ElseIf dep = "" And jk = "" Then
                querycmd = queryAllwTime
            End If
        End If

        dataOnReview(querycmd)
    End Sub
    Private Sub tb_emp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_emp.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Dim AktiveStatus As String
            If CheckBoxRetired.Checked = True Then
                AktiveStatus = ""
            Else
                AktiveStatus = " AND `StatusAktive` = '1'"
            End If

            cb_jk.Text = ""
            cb_department.Text = ""
            Dim nik As String = tb_emp.Text
            Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`.`StatusAktive` FROM `master employer` WHERE `NIK` = '{nik}'" + AktiveStatus
            dataOnReview(querycmd)
            clearData()
        End If
    End Sub

    Private Sub b_create_Click(sender As Object, e As EventArgs) Handles b_create.Click
        clearData()
        b_save.Visible = True
        b_cancel.Visible = True
        b_create.Enabled = False
        b_edit.Enabled = False
        f_create = True
        DGV_ReviewMaster.Enabled = False
        dataFill("c")
    End Sub

    Private Sub b_cancel_Click(sender As Object, e As EventArgs) Handles b_cancel.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure want to cancel ?", MsgBoxStyle.YesNo, "Register Master")
        Dim r_sellect As DataGridViewRow = DGV_ReviewMaster.Rows(r_index)
        Dim nik As String = r_sellect.Cells(0).Value
        If result = MsgBoxResult.Yes Then
            clearData()
            b_create.Enabled = True
            b_edit.Enabled = True
            b_cancel.Visible = False
            b_save.Visible = False
            f_edit = False
            f_create = False
            detailDataMaster(nik)
            dataViewOnly()
        ElseIf result = MsgBoxResult.No Then
            b_save.Visible = True
            b_cancel.Visible = True
        End If
        DGV_ReviewMaster.Enabled = True

    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim queryAll As String = "SELECT `NIK`, `Nama_Karyawan`, `Department`, `StatusAktive` FROM `master employer`"
        If tb_empDet.Text = "" Or tb_nama.Text = "" Or cb_createJK.Text = "" Or tb_pob.Text = "" Or tb_pend.Text = "" Or cb_bpjs.Text = "" Or cb_createPosisi.Text = "" Or cb_dep.Text = "" Or cb_stat.Text = "" Or tb_salary.Text = "" Or cb_aktif.Text = "" Then
            MsgBox("Data tidak boleh kosong !", MsgBoxStyle.Exclamation)
        Else
            Dim result As MsgBoxResult = MsgBox("Are you sure want to save ?", MsgBoxStyle.YesNoCancel, "Register Master")
            If result = MsgBoxResult.Yes Then
                If f_create = True Then
                    create()
                    dataOnReview(queryAll)
                ElseIf f_edit = True Then
                    updateData()
                    dataOnReview(queryAll)
                End If
                b_save.Visible = False
                b_cancel.Visible = False
                b_create.Enabled = True
                b_edit.Enabled = False
                clearData()
                dataViewOnly()
            ElseIf result = MsgBoxResult.No Then
                If f_edit = True Then
                    Dim r_sellect As DataGridViewRow = DGV_ReviewMaster.Rows(r_index)
                    Dim nik As String = r_sellect.Cells(0).Value
                    detailDataMaster(nik)
                    b_edit.Enabled = True
                Else
                    clearData()
                    dataViewOnly()
                    b_edit.Enabled = False
                End If
                b_save.Visible = False
                b_cancel.Visible = False
                b_create.Enabled = True
            End If
            DGV_ReviewMaster.Enabled = True
            f_create = False
            f_edit = False
        End If
    End Sub

    Private Sub b_edit_Click(sender As Object, e As EventArgs) Handles b_edit.Click
        b_save.Visible = True
        b_create.Enabled = False
        b_cancel.Visible = True
        b_edit.Enabled = False
        f_edit = True
        DGV_ReviewMaster.Enabled = False
        dataFill("e")
    End Sub

    Private Sub dataFill(ByVal proses As String)
        tb_empDet.ReadOnly = False
        tb_nama.ReadOnly = False
        tb_pob.ReadOnly = False
        tb_pend.ReadOnly = False
        cb_createPosisi.Enabled = True
        cb_dep.Enabled = True
        cb_stat.Enabled = True
        tb_salary.ReadOnly = False
        If proses = "c" Then
            cb_aktif.Text = "Ya"
            dt_createKeluar.Enabled = False
            dt_createKeluar.CustomFormat = " "
        Else
            If cb_aktif.Text = "Tidak" Then
                Debug.WriteLine("ini ada")
                dt_createKeluar.Enabled = True
                dt_createKeluar.CustomFormat = "dd/MM/yyyy"
            Else
                dt_createKeluar.Enabled = False
                dt_createKeluar.CustomFormat = " "
            End If
        End If
        dt_createMasuk.Enabled = True
        dt_createMasuk.CustomFormat = "dd/MM/yyyy"
        dt_lahir.Enabled = True
        dt_lahir.CustomFormat = "dd/MM/yyyy"
        cb_bpjs.Enabled = True
        cb_aktif.Enabled = True
        cb_createJK.Enabled = True

    End Sub
    Private Sub dataViewOnly()
        tb_empDet.ReadOnly = True
        tb_nama.ReadOnly = True
        tb_pob.ReadOnly = True
        tb_pend.ReadOnly = True
        cb_createPosisi.Enabled = False
        cb_dep.Enabled = False
        cb_stat.Enabled = False
        tb_salary.ReadOnly = True

        dt_createKeluar.Enabled = False
        dt_createKeluar.CustomFormat = "dd/MM/yyyy"
        dt_createMasuk.Enabled = False
        dt_createMasuk.CustomFormat = "dd/MM/yyyy"
        dt_lahir.Enabled = False
        dt_lahir.CustomFormat = "dd/MM/yyyy"
        cb_bpjs.Enabled = False
        cb_aktif.Enabled = False
        cb_createJK.Enabled = False
    End Sub
    Private Sub clearData()
        tb_empDet.Text = ""
        tb_nama.Text = ""
        cb_createPosisi.Text = ""
        tb_pob.Text = ""
        tb_salary.Text = ""
        cb_stat.Text = ""
        cb_dep.Text = ""
        tb_pend.Text = ""
        dt_createKeluar.Enabled = False
        dt_createKeluar.CustomFormat = " "
        dt_createMasuk.Enabled = False
        dt_createMasuk.CustomFormat = " "
        dt_lahir.Enabled = False
        dt_lahir.CustomFormat = " "
        cb_bpjs.Enabled = False
        cb_bpjs.Text = ""
        cb_aktif.Enabled = False
        cb_aktif.Text = ""
        cb_createJK.Enabled = False
        cb_createJK.Text = ""

    End Sub
    Private Sub create()
        Dim jk As String
        If cb_createJK.Text = "Laki-laki" Then
            jk = "L"
        Else
            jk = "P"
        End If
        Dim funcDB As DataBaseClass = New DataBaseClass

        If tb_empDet.TextLength = 6 Or tb_empDet.TextLength = 7 Then
            Dim x As Integer = 0
            If tb_empDet.TextLength = 6 Then
                x = 5
            Else
                x = 6
            End If

            Dim createOut As String
            If dt_createKeluar.Enabled = False Then
                createOut = ""
            Else
                createOut = dt_createKeluar.Value.ToString("yyyy-MM-dd")
            End If
            Dim aktive As String
            If cb_aktif.Text = "Ya" Then
                aktive = "1"
            Else
                aktive = "0"
            End If
            Dim AC_No As String = tb_empDet.Text.Substring(1, x)
            Dim masterQuery As String = $"INSERT INTO `master employer`(`AC_Nomor`,`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`,`Tanggal_Keluar`,`Status_Karyawan`, `Salary`, `StatusBPJS`, `StatusAktive`) 
                 VALUES ('{AC_No}',
                         '{tb_empDet.Text}',
                         '{tb_nama.Text}',
                         '{cb_createPosisi.Text}',
                         '{cb_dep.Text}',
                         '{tb_pob.Text}',
                         '{dt_lahir.Value.ToString("yyyy-MM-dd")}',
                         '{jk}',
                         '{tb_pend.Text}',
                         '{dt_createMasuk.Value.ToString("yyyy-MM-dd")}',
                         '{createOut}',
                         '{cb_stat.Text}',
                         '{tb_salary.Text.Replace(".", "")}',
                         '{cb_bpjs.Text}',
                         '{aktive}')"
            Console.WriteLine("DB Query : " + masterQuery)
            funcDB.uploadDB(masterQuery)
            MsgBox("Data already uploaded")

        Else
            MsgBox("Wrong Input NIK")
        End If

    End Sub

    Private Sub updateData()
        Dim jk As String
        If cb_createJK.Text = "Laki-laki" Then
            jk = "L"
        Else
            jk = "P"
        End If
        Dim r_sellect As DataGridViewRow = DGV_ReviewMaster.Rows(r_index)
        Dim nik As String = r_sellect.Cells(0).Value
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim bpjs As String
        Dim aktif As String

        If cb_bpjs.Text = "Ya" Then
            bpjs = "1"
        Else
            bpjs = "0"
        End If

        If cb_aktif.Text = "Ya" Then
            aktif = "1"
        Else
            aktif = "0"
        End If

        If tb_empDet.TextLength = 6 Or tb_empDet.TextLength = 7 Then
            Dim x As Integer = 0
            If tb_empDet.TextLength = 6 Then
                x = 5
            Else
                x = 6
            End If
            Dim createOut As String
            If dt_createKeluar.Enabled = False Then
                createOut = ""
            Else
                createOut = dt_createKeluar.Value.ToString("yyyy-MM-dd")
            End If

            Dim AC_No As String = tb_empDet.Text.Substring(1, x)
            Dim masterQuery As String = $"UPDATE `master employer` SET `AC_Nomor` ='{AC_No}',
                                             `NIK`='{tb_empDet.Text}', 
                                             `Nama_Karyawan`='{tb_nama.Text}', 
                                             `Posisi_Karyawan`='{cb_createPosisi.Text}', 
                                             `Department`='{cb_dep.Text}', 
                                             `Tempat_Lahir`='{tb_pob.Text}', 
                                             `Tanggal_Lahir`='{dt_lahir.Value.ToString("yyyy-MM-dd")}', 
                                             `Jenis_Kelamin`='{jk}', 
                                             `Pendidikan_Karyawan`='{tb_pend.Text}', 
                                             `Tanggal_Masuk`='{dt_createMasuk.Value.ToString("yyyy-MM-dd")}',
                                             `Tanggal_Keluar`='{createOut}', 
                                             `Status_Karyawan`='{cb_stat.Text}',
                                             `Salary`='{tb_salary.Text.Replace(".", "")}', 
                                             `StatusBPJS`='{cb_bpjs.Text}', 
                                             `StatusAktive`= '{cb_aktif.Text}'
                                    WHERE `NIK` = '{nik}'"
            Console.WriteLine("DB Query : " + masterQuery)
            funcDB.uploadDB(masterQuery)
            MsgBox("Data already updated")
        Else
            MsgBox("Wrong Input NIK")
        End If

    End Sub


    Private Sub DGV_ReviewMaster_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewMaster.CellClick
        If e.RowIndex <> -1 Then
            Dim Nik As String = DGV_ReviewMaster.Rows(e.RowIndex).Cells(0).Value
            detailDataMaster(Nik)
            b_edit.Enabled = True
            r_index = e.RowIndex
        End If
    End Sub

    Private Sub dt_createKeluar_ValueChanged(sender As Object, e As EventArgs) Handles dt_createKeluar.ValueChanged
        cb_aktif.Text = "Yes"
    End Sub

    Private Sub b_search_Click(sender As Object, e As EventArgs) Handles b_search.Click
        Dim masuk As String = dt_masuk.Value.ToString("yyyy-MM-dd")
        Dim dep As String = cb_department.Text
        Dim jk As String
        tb_emp.Text = ""
        If cb_jk.Text = "Laki-Laki" Then
            jk = "L"
        ElseIf cb_jk.Text = "Perempuan" Then
            jk = "P"
        ElseIf cb_jk.Text = "All" Or cb_jk.Text = "" Then
            jk = ""
        End If
        filterData(dep, jk, masuk)
        clearData()
    End Sub

    Private Sub dt_masuk_ValueChanged(sender As Object, e As EventArgs) Handles dt_masuk.ValueChanged
        dt_masuk.Format = DateTimePickerFormat.Custom
        dt_masuk.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AktiveStatus As String
        If CheckBoxRetired.Checked = True Then
            AktiveStatus = ""
        Else
            AktiveStatus = "WHERE `StatusAktive` = '1'"
        End If
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Department`,`StatusAktive` FROM `master employer`" + AktiveStatus
        dataOnReview(QueryCMD)
        DGV_Setting_Display()
        clearData()

        dt_masuk.CustomFormat = " "

        'button
        b_save.Visible = False
        b_edit.Enabled = False
        b_cancel.Visible = False
        b_create.Enabled = True
    End Sub

    Private Sub cb_aktif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_aktif.SelectedIndexChanged
        Dim cb As ComboBox = CType(sender, ComboBox)

        If cb.Focused Then
            If cb_aktif.Text = "Ya" Then
                Debug.WriteLine("ada")
                dt_createKeluar.Format = DateTimePickerFormat.Custom
                dt_createKeluar.CustomFormat = " "
                dt_createKeluar.Enabled = False
            Else
                dt_createKeluar.Format = DateTimePickerFormat.Custom
                dt_createKeluar.CustomFormat = "dd/MM/yyyy"
                dt_createKeluar.Enabled = True
            End If

        End If
    End Sub

    Private Sub DGV_ReviewMaster_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles DGV_ReviewMaster.KeyDown, DGV_ReviewMaster.KeyUp
        If e.KeyCode.Equals(Keys.Up) Then
            moveUp()
        End If

        If e.KeyCode.Equals(Keys.Down) Then
            moveDown()
        End If

        'e.Handled = True
    End Sub

    Private Sub moveUp()
        If DGV_ReviewMaster.RowCount > 0 Then

            If DGV_ReviewMaster.SelectedRows.Count > 0 Then
                Dim rowCount As Integer = DGV_ReviewMaster.Rows.Count
                Dim index As Integer = DGV_ReviewMaster.SelectedCells(0).OwningRow.Index

                If index = 0 Then
                    Return
                End If
                Dim Nik As String = DGV_ReviewMaster.Rows(index).Cells(0).Value
                detailDataMaster(Nik)
                b_edit.Enabled = True
                r_index = index
            End If
        End If
    End Sub

    Private Sub moveDown()
        If DGV_ReviewMaster.RowCount > 0 Then
            If DGV_ReviewMaster.SelectedRows.Count > 0 Then
                Dim index As Integer = DGV_ReviewMaster.SelectedCells(0).OwningRow.Index
                Dim rowCount As Integer = DGV_ReviewMaster.Rows.Count
                If index = (rowCount - 2) Then
                    Return
                End If
                Dim Nik As String = DGV_ReviewMaster.Rows(index).Cells(0).Value
                detailDataMaster(Nik)
                b_edit.Enabled = True
                r_index = index
            End If
        End If
    End Sub
End Class