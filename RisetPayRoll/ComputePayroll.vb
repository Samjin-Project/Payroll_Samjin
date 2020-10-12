Public Class ComputePayroll
    Private Sub ComputePayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim querycmd As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Status_Karyawan` FROM `master_employer`"
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
End Class