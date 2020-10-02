Public Class ApprovalVacation
    Public basicQuery As String = "SELECT `No`,
`NIK`,
`Status_Approval`,
`Approver`,
`Nama_Karyawan`,
`Vacation_Code`,
DATE_FORMAT(`StartVacation_Date`,""%d/%m/%Y""),
DATE_FORMAT(`EndVacation_Date`,""%d/%m/%Y""),
DATE_FORMAT(`ReqVacation_Date`,""%d/%m/%Y"") 
FROM `approval_vacation` "
    Private Sub ApprovalVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SortingTabel()
    End Sub

    Private Sub dataOnRevieweDaily(QueryOnReview As String)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(QueryOnReview)
        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        '        Console.WriteLine($"Status Aproval {ds.Tables(0).Rows(0).Item(1).ToString}")
        If indexDs > 0 Then
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
        End If

        'EDITED BY RIKI
    End Sub
    Private Sub SortingTabel()
        Dim datePilihan As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim querycmd As String
        If RbAll.Checked Then
            querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}'"
        ElseIf RbApproved.Checked Then
            querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'Yes'"
        ElseIf RbUnapproved.Checked Then
            querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'No'"
        End If
        Console.WriteLine("QUERY : " + querycmd)
        DGV_ApprovalVacation.Rows.Clear()
        dataOnRevieweDaily(querycmd)
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        SortingTabel()
    End Sub

    Private Sub RbApproved_CheckedChanged(sender As Object, e As EventArgs) Handles RbApproved.CheckedChanged, RbUnapproved.CheckedChanged, RbAll.CheckedChanged
        SortingTabel()
    End Sub
End Class