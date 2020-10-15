
Imports System.Data.OleDb
Public Class RegisterMaster
    Dim flag As Boolean = False
    Private Sub RegisterMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        dataOnReview(QueryCMD)
        DGV_Setting_Display()

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
        OpenFileDialogImport.ShowDialog()

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
        For i As Integer = 2 To indexRows - 1
            Dim admisionDate As Date = Date.ParseExact(DS.Tables(0).Rows(i).Item(9), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim masterQuery As String = $"INSERT INTO `master employer`(`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, `Jenis_Kelamin`, `Pendidikan_Karyawan`, `Tanggal_Masuk`, `Status_Karyawan`, `Salary`,`StatusBpjs`,`StatusAktive`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '{admisionDate.ToString("yyyy-MM-dd")}',
                         '{DS.Tables(0).Rows(i).Item(10)}',
                         '{DS.Tables(0).Rows(i).Item(11)}',
                         '{DS.Tables(0).Rows(i).Item(12)}',
                         '{DS.Tables(0).Rows(i).Item(13)}'
                         )"
            Console.WriteLine("DB Query : " + masterQuery)
            funcDB.uploadDB(masterQuery)
        Next
        MsgBox("Upload Selesai")
    End Sub

    Private Sub dataOnReview(QueryOnReview As String)
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
        Dim QueryCMD As String = $"SELECT `Nama_Karyawan`, `Posisi_Karyawan`, `Department`, `Tempat_Lahir`, `Tanggal_Lahir`, 
        `Jenis_Kelamin`, `Pendidikan_Karyawan`, 
        `Status_Karyawan`, `Salary`FROM `master employer` WHERE `NIK` = '{Nik}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryCMD)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        'Console.WriteLine(ds.GetXml)
        If indexDs > 0 Then
            tb_nama.Text = ds.Tables(0).Rows(0).Item(0).ToString
            tb_posisi.Text = ds.Tables(0).Rows(0).Item(1).ToString
            tb_dep.Text = ds.Tables(0).Rows(0).Item(2).ToString
            tb_pob.Text = ds.Tables(0).Rows(0).Item(3).ToString
            tb_dob.Text = ds.Tables(0).Rows(0).Item(4)
            If ds.Tables(0).Rows(0).Item(5).ToString = "L" Then
                tb_jk.Text = "Laki-laki"
            ElseIf ds.Tables(0).Rows(0).Item(5).ToString = "P" Then
                tb_jk.Text = "Perempuan"
            End If
            tb_pend.Text = ds.Tables(0).Rows(0).Item(6).ToString
            tb_stat.Text = ds.Tables(0).Rows(0).Item(7).ToString
            tb_salary.Text = ds.Tables(0).Rows(0).Item(8).ToString
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

        DGV_ReviewMaster.Rows.Clear()
        dataOnReview(querycmd)
    End Sub
    Private Sub b_clear_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        dt_masuk.Value = Now
        cb_jk.Text = ""
        cb_posisi.Text = ""
        tb_emp.Text = ""
        DGV_ReviewMaster.Rows.Clear()
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer`"
        dataOnReview(QueryCMD)
        DGV_Setting_Display()
        flag = False
        clearData()
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
            DGV_ReviewMaster.Rows.Clear()
            cb_jk.Text = ""
            cb_posisi.Text = ""
            Dim nik As String = tb_emp.Text
            Dim querycmd As String = $"SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master employer` WHERE `NIK` = '{nik}'"
            dataOnReview(querycmd)
            clearData()
        End If
    End Sub

    Private Sub DGV_ReviewMaster_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewMaster.CellContentClick
        Dim Nik As String = DGV_ReviewMaster.Rows(e.RowIndex).Cells(0).Value
        detailDataMaster(Nik)
    End Sub
    Private Sub clearData()
        tb_nama.Text = ""
        tb_posisi.Text = ""
        tb_jk.Text = ""
        tb_dob.Text = ""
        tb_pob.Text = ""
        tb_salary.Text = ""
        tb_stat.Text = ""
        tb_dep.Text = ""
        tb_pend.Text = ""

    End Sub
End Class