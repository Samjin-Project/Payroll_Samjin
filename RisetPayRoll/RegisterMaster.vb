
Imports System.Data.OleDb
Public Class RegisterMaster
    Dim flag As Boolean = False
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
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        dataOnReview(QueryCMD)
        DGV_Setting_Display()
        clearData()

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

        'On Error Resume Next
        OpenFileDialogImport.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"

        Dim result As DialogResult = OpenFileDialogImport.ShowDialog()

        If result = DialogResult.OK Then

            CONN = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" & "data source='" & OpenFileDialogImport.FileName & "';Extended Properties=Excel 12.0 Xml;")

            DA = New OleDbDataAdapter("select * from [Sheet1$]", CONN)
            CONN.Open()
            DS.Clear()
            DA.Fill(DS)
            DGV_ReviewMaster.DataSource = DS.Tables("a")
            CONN.Close()



            Dim funcDB As DataBaseClass = New DataBaseClass
            Dim indexRows As Integer = DS.Tables(0).Rows.Count
            Console.WriteLine("Tanggal Masuk : " + DS.Tables(0).Rows(2).Item(9))
            Console.WriteLine("indexRows" + indexRows.ToString)
            For i As Integer = 1 To indexRows - 3
                Console.WriteLine("nilai" + i.ToString)
                Dim AC_no As String = DS.Tables(0).Rows(i).Item(1).ToString.Substring(1, 6)
                Dim admisionDateIn As Date = Date.ParseExact(DS.Tables(0).Rows(i).Item(9), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                Dim admisionDateOut As String
                If DS.Tables(0).Rows(i).Item(10).ToString = "" Then
                    admisionDateOut = ""
                Else
                    admisionDateOut = Date.ParseExact(DS.Tables(0).Rows(i).Item(10), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString("yyyy-MM-dd")
                End If
                Dim masterQuery As String = $"INSERT INTO `master employer`(`AC_nomor`,`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`,`Tanggal_Keluar`, `Salary`,`StatusBpjs`,`StatusAktive`) 
                 VALUES ('{AC_no }',
                         '{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '{admisionDateIn.ToString("yyyy-MM-dd")}',
                         '{admisionDateOut}',
                         '{DS.Tables(0).Rows(i).Item(11)}',
                         '{DS.Tables(0).Rows(i).Item(12)}',
                         '{DS.Tables(0).Rows(i).Item(13)}'
                         )"
                Console.WriteLine("DB Query : " + masterQuery)
                funcDB.uploadDB(masterQuery)
            Next
            MsgBox("Upload Selesai")
        End If
    End Sub

    Private Sub dataOnReview(QueryOnReview As String)
        DGV_ReviewMaster.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString}
            DGV_ReviewMaster.Rows.Add(row)
            DGV_ReviewMaster.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ReviewMaster.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
        total_data.Text = DGV_ReviewMaster.Rows.Count
    End Sub

    Private Sub detailDataMaster(Nik As String)
        Dim QueryCMD As String = $"SELECT *FROM `master employer` WHERE `NIK` = '{Nik}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryCMD)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        'Console.WriteLine(ds.GetXml)
        If indexDs > 0 Then
            Dim tglLahir As Date = DateTime.ParseExact(ds.Tables(0).Rows(0).Item(7), "dd/MM/yyyy", Nothing)
            Dim tglMasuk As Date = DateTime.ParseExact(ds.Tables(0).Rows(0).Item(10), "yyyy-MM-dd", Nothing)
            Dim tglKeluar As String = ds.Tables(0).Rows(0).Item(11)
            Console.WriteLine("tglOut" + ds.Tables(0).Rows(0).Item(11).ToString)
            If ds.Tables(0).Rows(0).Item(11).ToString = "0" Then
                dt_createKeluar.Format = DateTimePickerFormat.Custom
                dt_createKeluar.CustomFormat = " "
            Else
                dt_createKeluar.Value = DateTime.ParseExact(tglKeluar, "yyyy-MM-dd", Nothing)
            End If
            Dim gaji As Double = ds.Tables(0).Rows(0).Item(13)

            tb_empDet.Text = ds.Tables(0).Rows(0).Item(2)
            tb_nama.Text = ds.Tables(0).Rows(0).Item(3).ToString
            cb_createPosisi.Text = ds.Tables(0).Rows(0).Item(4).ToString
            tb_dep.Text = ds.Tables(0).Rows(0).Item(5).ToString
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
            cb_bpjs.Text = ds.Tables(0).Rows(0).Item(14)
            cb_aktif.Text = ds.Tables(0).Rows(0).Item(15)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadExcel()
    End Sub
    Private Sub filterData(posisi As String, jk As String, masuk As String)
        Dim queryAll As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        Dim querySortPosisi As String = $"{queryAll} WHERE `Posisi_Karyawan` = '{posisi}'"
        Dim querySortJK As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'"
        Dim querySortAll As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'AND `Posisi_Karyawan` = '{posisi}'"

        Dim queryAllwTime As String = $"{queryAll} WHERE `Tanggal_Masuk` = '{masuk}' AND `Tanggal_Masuk` = '{masuk}'"
        Dim querySortPosisiwTime As String = $"{queryAll} WHERE `Posisi_Karyawan` = '{posisi}' AND `Tanggal_Masuk` = '{masuk}'"
        Dim querySortJKwTime As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}' AND `Tanggal_Masuk` = '{masuk}'"
        Dim querySortAllwTime As String = $"{queryAll} WHERE `Jenis_Kelamin` = '{jk}'AND `Posisi_Karyawan` = '{posisi}' AND `Tanggal_Masuk` = '{masuk}'"

        Dim querycmd As String = ""
        If flag = False Then
            If posisi = "" And jk <> "" Then
                querycmd = querySortJK
            ElseIf posisi <> "" And jk = "" Then
                querycmd = querySortPosisi
            ElseIf posisi <> "" And jk <> "" Then
                querycmd = querySortAll
            ElseIf posisi = "" And jk = "" Then
                querycmd = queryAll
            End If
        Else
            If posisi = "" And jk <> "" Then
                querycmd = querySortJKwTime
            ElseIf posisi <> "" And jk = "" Then
                querycmd = querySortPosisiwTime
            ElseIf posisi <> "" And jk <> "" Then
                querycmd = querySortAllwTime
            ElseIf posisi = "" And jk = "" Then
                querycmd = queryAllwTime
            End If
        End If

        dataOnReview(querycmd)
    End Sub

    Private Sub dt_masuk_ValueChanged(sender As Object, e As EventArgs) Handles dt_masuk.ValueChanged
        flag = True
        Dim masuk As String = dt_masuk.Value.ToString("yyyy-MM-dd")
        Dim posisi As String = cb_posisi.Text
        Dim jk As String
        tb_emp.Text = ""
        If cb_jk.Text = "Laki-Laki" Then
            jk = "L"
        ElseIf cb_jk.Text = "Perempuan" Then
            jk = "P"
        Else
            jk = ""
        End If
        filterData(posisi, jk, masuk)
        clearData()
    End Sub

    Private Sub cb_posisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_posisi.SelectedIndexChanged
        Dim masuk As String = dt_masuk.Value.ToString("yyyy-MM-dd")
        Dim posisi As String = cb_posisi.Text
        Dim jk As String
        tb_emp.Text = ""
        If cb_jk.Text = "Laki-Laki" Then
            jk = "L"
        ElseIf cb_jk.Text = "Perempuan" Then
            jk = "P"
        Else
            jk = ""
        End If
        filterData(posisi, jk, masuk)
        clearData()
    End Sub

    Private Sub cb_jk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_jk.SelectedIndexChanged
        Dim masuk As String = dt_masuk.Value.ToString("yyyy-MM-dd")
        Dim posisi As String = cb_posisi.Text
        Dim jk As String
        tb_emp.Text = ""
        If cb_jk.Text = "Laki-Laki" Then
            jk = "L"
        ElseIf cb_jk.Text = "Perempuan" Then
            jk = "P"
        Else
            jk = ""
        End If
        filterData(posisi, jk, masuk)
        clearData()
    End Sub


    Private Sub tb_emp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles tb_emp.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            cb_jk.Text = ""
            cb_posisi.Text = ""
            Dim nik As String = tb_emp.Text
            Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer` WHERE `NIK` = '{nik}'"
            dataOnReview(querycmd)
            clearData()
        End If
    End Sub
    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        dt_masuk.Value = Now
        cb_jk.Text = ""
        cb_posisi.Text = ""
        tb_emp.Text = ""
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        dataOnReview(QueryCMD)
        DGV_Setting_Display()
        flag = False
        b_edit.Enabled = False
        clearData()
    End Sub

    Private Sub b_create_Click(sender As Object, e As EventArgs) Handles b_create.Click
        clearData()
        b_save.Visible = True
        b_cancel.Visible = True
        b_create.Enabled = False
        b_edit.Enabled = False
        f_create = True
        dataFill()
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
    End Sub

    Private Sub b_save_Click(sender As Object, e As EventArgs) Handles b_save.Click
        Dim queryAll As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        If tb_empDet.Text = "" Or tb_nama.Text = "" Or cb_createJK.Text = "" Or tb_pob.Text = "" Or tb_pend.Text = "" Or cb_bpjs.Text = "" Or cb_createPosisi.Text = "" Or tb_dep.Text = "" Or cb_stat.Text = "" Or tb_salary.Text = "" Or cb_aktif.Text = "" Then
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
        dataFill()
    End Sub

    Private Sub dataFill()
        tb_empDet.ReadOnly = False
        tb_nama.ReadOnly = False
        tb_pob.ReadOnly = False
        tb_pend.ReadOnly = False
        cb_createPosisi.Enabled = True
        tb_dep.ReadOnly = False
        cb_stat.Enabled = True
        tb_salary.ReadOnly = False
        dt_createKeluar.Enabled = True
        dt_createKeluar.CustomFormat = "dd/MM/yyyy"
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
        tb_dep.ReadOnly = True
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
        tb_dep.Text = ""
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
        Dim AC_No As String = tb_empDet.Text.Substring(1, 6)
        Dim masterQuery As String = $"INSERT INTO `master employer`(`AC_Nomor`,`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`,`Tanggal_Keluar`, `Salary`, `BPJS`, `Aktif`) 
                 VALUES ('{AC_No}',
                         '{tb_empDet.Text}',
                         '{tb_nama.Text}',
                         '{cb_createPosisi.Text}',
                         '{tb_dep.Text}',
                         '{tb_pob.Text}',
                         '{dt_lahir.Value.ToString("yyyy-MM-dd")}',
                         '{jk}',
                         '{tb_pend.Text}',
                         '{dt_createMasuk.Value.ToString("yyyy-MM-dd")}',
                         '{dt_createKeluar.Value.ToString("yyyy-MM-dd")}',
                         '{cb_stat.Text}'
                         '{tb_salary.Text}'
                         '{cb_bpjs.Text}'
                         '{cb_aktif.Text}')"
        Console.WriteLine("DB Query : " + masterQuery)
        funcDB.uploadDB(masterQuery)
        MsgBox("Data already uploaded")
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
        Dim AC_No As String = tb_empDet.Text.Substring(1, 6)
        Dim masterQuery As String = $"UPDATE `master employer`(`AC_Nomor`,`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`,`Tanggal_Keluar`, `Salary`, `BPJS`, `Aktif`) 
                 VALUES ('{AC_No}',
                         '{tb_empDet.Text}',
                         '{tb_nama.Text}',
                         '{cb_createPosisi.Text}',
                         '{tb_dep.Text}',
                         '{tb_pob.Text}',
                         '{dt_lahir.Value.ToString("yyyy-MM-dd")}',
                         '{jk}',
                         '{tb_pend.Text}',
                         '{dt_createMasuk.Value.ToString("yyyy-MM-dd")}',
                         '{cb_stat.Text}'
                         '{tb_salary.Text}'
                         '{cb_bpjs.Text}'
                         '{cb_aktif.Text}') WHERE `NIK` = '{nik}'"
        Console.WriteLine("DB Query : " + masterQuery)
        funcDB.uploadDB(masterQuery)
        MsgBox("Data already updated")
    End Sub

    Private Sub tb_masuk_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGV_ReviewMaster_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewMaster.CellClick
        Dim Nik As String = DGV_ReviewMaster.Rows(e.RowIndex).Cells(0).Value
        detailDataMaster(Nik)
        b_edit.Enabled = True
        r_index = e.RowIndex
    End Sub
End Class