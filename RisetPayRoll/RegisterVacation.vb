Public Class RegisterVacation
    Private Sub RegisterVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim QueryCMD As String = "SELECT `NIK`, `Nama_Karyawan`, `TanggalMasuk_Karyawan` FROM `master_employer`"
        RadioButtonAprY.Checked = True
        dataOnSide(QueryCMD)
    End Sub

    Private Sub dataOnSide(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(0).ToString, ds.Tables(0).Rows(i).Item(1).ToString, ds.Tables(0).Rows(i).Item(2).ToString}
            DGV_DataModify.Rows.Add(row)
            DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub


    Private Sub DGV_DataModify_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV_DataModify.RowHeaderMouseClick
        Console.WriteLine($"Clicked Cell {e.RowIndex}")
        tb_emp.Text = DGV_DataModify.Rows(e.RowIndex).Cells(1).Value
        tb_nama.Text = DGV_DataModify.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Sub uploadData()
        Dim status As String = ""
        If RadioButtonAprY.Checked Then
            status = "Yes"
        ElseIf RadioButtonAprN.Checked Then
            status = "No"
        End If
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim masterQuery As String = $"INSERT INTO `approval_vacation`(`NIK`, `Status_Approval`, `Approver`, `Nama_Karyawan`, `Vacation_Code`, `StartVacation_Date`, `EndVacation_Date`, `ReqVacation_Date`) 
                 VALUES ('{tb_nama.Text}',
                         '{status}',
                         'Putri',
                         '{tb_emp.Text}',
                         '{tb_holtype.Text}',
                         '{dt_startdate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_anddate.Value.ToString("yyyy-MM-dd")}',
                         '{dt_reqdate.Value.ToString("yyyy-MM-dd")}')"
        Console.WriteLine("DB Query : " + masterQuery)
        funcDB.uploadDB(masterQuery)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uploadData()
    End Sub

End Class