
Imports System.Data.OleDb
Public Class RegisterMaster
    Private Sub RegisterMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `Posisi_Karyawan` FROM `master_employer`"
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
        For i As Integer = 2 To indexRows - 1
            Dim masterQuery As String = $"INSERT INTO `master_employer`(`NIK`, `Nama_Karyawan`, `Posisi_Karyawan`, `Departement_Karyawan`, `TempatLahir_Karyawan`, `TanggalLahir_Karyawan`, `JenisKelamin_Karyawan`, `Pendidikan_Karyawan`, `TanggalMasuk_Karyawan`, `Status_Karyawan`, `Salary_Karyawan`) 
                 VALUES ('{DS.Tables(0).Rows(i).Item(1)}',
                         '{DS.Tables(0).Rows(i).Item(2)}',
                         '{DS.Tables(0).Rows(i).Item(3)}',
                         '{DS.Tables(0).Rows(i).Item(4)}',
                         '{DS.Tables(0).Rows(i).Item(5)}',
                         '{DS.Tables(0).Rows(i).Item(6)}',
                         '{DS.Tables(0).Rows(i).Item(7)}',
                         '{DS.Tables(0).Rows(i).Item(8)}',
                         '{DS.Tables(0).Rows(i).Item(9)}',
                         '{DS.Tables(0).Rows(i).Item(10)}',
                         '{DS.Tables(0).Rows(i).Item(11)}')"
            Console.WriteLine("DB Query : " + masterQuery)
            funcDB.uploadDB(masterQuery)
        Next
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
    End Sub

    Private Sub detailDataMaster(Nik As String)
        Dim QueryCMD As String = $"SELECT * FROM `master_employer` WHERE `NIK` = '{Nik}'"
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryCMD)
        'Console.WriteLine(ds.GetXml)
        If ds.Tables(0).Rows.Count > 0 Then
            TextBoxNama.Text = ds.Tables(0).Rows(0).Item(1)
            TextBoxPosisi.Text = ds.Tables(0).Rows(0).Item(2)
            TextBoxDep.Text = ds.Tables(0).Rows(0).Item(3)
            TextBoxTmptLahir.Text = ds.Tables(0).Rows(0).Item(4)
            TextBoxTglLahir.Text = ds.Tables(0).Rows(0).Item(5)
            TextBoxJKelamin.Text = ds.Tables(0).Rows(0).Item(6)
            TextBoxPend.Text = ds.Tables(0).Rows(0).Item(7)
            TextBoxStatus.Text = ds.Tables(0).Rows(0).Item(8)
            TextBoxSalary.Text = ds.Tables(0).Rows(0).Item(9)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UploadExcel()
    End Sub

    Private Sub DGV_ReviewMaster_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ReviewMaster.CellClick
        Dim Nik As String = DGV_ReviewMaster.Rows(e.RowIndex).Cells(1).Value
        detailDataMaster(Nik)
        Console.WriteLine("test")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class