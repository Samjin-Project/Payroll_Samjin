Public Class ApprovalVacation
    Private Sub ApprovalVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row1 As String() = New String() {"No", "Putri Permatasari", "Riki", "Anual Leave", "2010/11/20", "2010/11/20", "2010/ 11/20", "085860147440"}
        Dim queryCMD As String = "SELECT * FROM `approval_vacation`"
        dataOnRevieweDaily(queryCMD)
    End Sub

    Private Sub dataOnRevieweDaily(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Console.WriteLine($"Status Aproval {ds.Tables(0).Rows(0).Item(1).ToString}")
        For i As Integer = 0 To indexDs - 1
            Dim row As String() = New String() {ds.Tables(0).Rows(i).Item(2).ToString,
                                                ds.Tables(0).Rows(i).Item(3).ToString,
                                                ds.Tables(0).Rows(i).Item(4).ToString,
                                                ds.Tables(0).Rows(i).Item(5).ToString,
                                                ds.Tables(0).Rows(i).Item(6).ToString,
                                                ds.Tables(0).Rows(i).Item(7).ToString,
                                                ds.Tables(0).Rows(i).Item(8).ToString}
            'Dim row1 As String() = New String() {"Yes", "Putri Permatasari", "Riki", "Anual Leave", "2010/11/20", "2010/11/20", "2010/ 11/20", "085860147440"}
            DGV_ApprovalVacation.Rows.Add(row)
            DGV_ApprovalVacation.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_ApprovalVacation.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next

        'COBA COBA GITHUB'
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class