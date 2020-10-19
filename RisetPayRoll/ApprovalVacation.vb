Public Class ApprovalVacation
    Public basicQuery As String = "SELECT `No`,
`NIK`,
`Status_Approval`,
`Approver`,
`Nama_Karyawan`,
`Vacation_Code`,
DATE_FORMAT(`StartVacation_Date`,""%d/%m/%Y""),
DATE_FORMAT(`EndVacation_Date`,""%d/%m/%Y""),
DATE_FORMAT(`ReqVacation_Date`,""%d/%m/%Y""),
`Department`,
`Telp`
FROM `approval_vacation` "

    Dim f_tgl As Boolean = False
    Private Sub ApprovalVacation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RbAll.Checked = True
        RbApproved.Checked = False
        RbUnapproved.Checked = False
        cb_dep.SelectedItem = "PCBA"
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
                                                    ds.Tables(0).Rows(i).Item(9).ToString,
                                                    ds.Tables(0).Rows(i).Item(5).ToString,
                                                    ds.Tables(0).Rows(i).Item(6).ToString,
                                                    ds.Tables(0).Rows(i).Item(7).ToString,
                                                    ds.Tables(0).Rows(i).Item(8).ToString,
                                                    ds.Tables(0).Rows(i).Item(10).ToString}
                'Dim row1 As String() = New String() {"Yes", "Putri Permatasari", "Riki", "Anual Leave", "2010/11/20", "2010/11/20", "2010/ 11/20", "085860147440"}
                DGV_ApprovalVacation.Rows.Add(row)
                DGV_ApprovalVacation.Rows(i).HeaderCell.Value = (i + 1).ToString
                If i Mod 2 = 1 Then
                    DGV_ApprovalVacation.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        End If

        total_data.Text = DGV_ApprovalVacation.Rows.Count()
        'EDITED BY RIKI
    End Sub
    Private Sub SortingTabel()
        Dim datePilihan As String = dt_since.Value.ToString("yyyy-MM-dd")
        Dim querycmd As String
        If f_tgl = True Then
            If cb_dep.Text <> "" Then
                If RbAll.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Department` = '{cb_dep.Text}'"
                ElseIf RbApproved.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'Yes' AND `Department` = '{cb_dep.Text}'"
                ElseIf RbUnapproved.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'No' AND `Department` = '{cb_dep.Text}'"
                ElseIf RbAll.Checked = False And RbApproved.Checked = False And RbUnapproved.Checked = False Then
                    querycmd = basicQuery
                End If
            Else
                If RbAll.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}'"
                ElseIf RbApproved.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'Yes'"
                ElseIf RbUnapproved.Checked Then
                    querycmd = basicQuery + $"WHERE `StartVacation_Date` = '{datePilihan}' AND `Status_Approval` = 'No'"
                ElseIf RbAll.Checked = False And RbApproved.Checked = False And RbUnapproved.Checked = False Then
                    querycmd = basicQuery
                End If
            End If

        Else
            If cb_dep.Text <> "" Then
                If RbAll.Checked Then
                    querycmd = basicQuery + $"WHERE `Department` = '{cb_dep.Text}'"
                ElseIf RbApproved.Checked Then
                    querycmd = basicQuery + $"WHERE `Status_Approval` = 'Yes' AND `Department` = '{cb_dep.Text}'"
                ElseIf RbUnapproved.Checked Then
                    querycmd = basicQuery + $"WHERE`Status_Approval` = 'No' AND `Department` = '{cb_dep.Text}'"
                ElseIf RbAll.Checked = False And RbApproved.Checked = False And RbUnapproved.Checked = False Then
                    querycmd = basicQuery
                End If
            Else
                If RbAll.Checked Then
                    querycmd = basicQuery
                ElseIf RbApproved.Checked Then
                    querycmd = basicQuery + $"WHERE `Status_Approval` = 'Yes'"
                ElseIf RbUnapproved.Checked Then
                    querycmd = basicQuery + $"WHERE `Status_Approval` = 'No'"
                ElseIf RbAll.Checked = False And RbApproved.Checked = False And RbUnapproved.Checked = False Then
                    querycmd = basicQuery
                End If
            End If
        End If
        Console.WriteLine("QUERY : " + querycmd)
        DGV_ApprovalVacation.Rows.Clear()
        dataOnRevieweDaily(querycmd)
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt_since.ValueChanged
        f_tgl = True
        SortingTabel()
    End Sub

    Private Sub RbApproved_CheckedChanged(sender As Object, e As EventArgs) Handles RbApproved.CheckedChanged, RbUnapproved.CheckedChanged, RbAll.CheckedChanged
        SortingTabel()
    End Sub

    Private Sub DGV_ApprovalVacation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ApprovalVacation.CellContentClick

    End Sub
    Private Sub DGV_ApprovalVacation_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ApprovalVacation.CellEndEdit
        Dim indexRows As Integer = e.RowIndex
        Dim nama As String = DGV_ApprovalVacation.Rows(indexRows).Cells(2).Value
        Dim startDate As String = DGV_ApprovalVacation.Rows(indexRows).Cells(5).Value
        Dim endDate As String = DGV_ApprovalVacation.Rows(indexRows).Cells(6).Value
        Dim editAproval As String = DGV_ApprovalVacation.Rows(indexRows).Cells(0).Value

        Dim startDateParse As Date = Date.ParseExact(startDate, "dd/MM/yyyy", Nothing)
        Dim endDateParse As Date = Date.ParseExact(endDate, "dd/MM/yyyy", Nothing)
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim queryEdit As String = $"UPDATE `approval_vacation` SET `Status_Approval`='{editAproval}' WHERE `Nama_Karyawan` = '{nama}' AND `StartVacation_Date` = '{startDateParse.ToString("yyyy-MM-dd")}' AND `EndVacation_Date` = '{endDateParse.ToString("yyyy-MM-dd")}'"
        DBClass.uploadDB(queryEdit)
    End Sub

    Private Sub b_show_Click(sender As Object, e As EventArgs) Handles b_clear.Click
        RbAll.Checked = True
        RbApproved.Checked = False
        RbUnapproved.Checked = False
        cb_dep.Text = ""
        dt_since.Value = Now
        DGV_ApprovalVacation.Rows.Clear()
        dataOnRevieweDaily(basicQuery)
        f_tgl = False
    End Sub

    Private Sub cb_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_dep.SelectedIndexChanged
        SortingTabel()
    End Sub
End Class