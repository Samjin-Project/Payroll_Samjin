Public Class DailyAttendance
    Private Sub DailyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row1 As String() = New String() {"K000000", "Riki Tardiansyah", "Check In", "2020.06.05", "Sun", "SHIFT3", "23:30", "07:30", "2020.06.05", "", "", "7.0", "1.0"}
        For x As Integer = 0 To 30
            DGV_ReviewDaily.Rows.Add(row1)
            DGV_ReviewDaily.Rows(x).HeaderCell.Value = (x + 1).ToString
            If x Mod 2 = 1 Then
                DGV_ReviewDaily.Rows(x).DefaultCellStyle.BackColor = Color.Gainsboro
            End If
        Next

        Dim row2 As String() = New String() {"K000000", "Riki Tardiansyah"}
        For x As Integer = 0 To 30
            DGV_SideDaily.Rows.Add(row1)
            DGV_SideDaily.Rows(x).HeaderCell.Value = (x + 1).ToString
            If x Mod 2 = 1 Then
                DGV_SideDaily.Rows(x).DefaultCellStyle.BackColor = Color.Gainsboro
            End If
        Next
    End Sub
End Class