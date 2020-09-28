Public Class FingerModify
    Private Sub FingerModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As String() = New String() {"1", True, "200001", "Riki", "2010/11/20", "Siang", "Check In", "07:30", "07:32", "True", "Rubber", "0000/00/00"}
        DGV_DataModify.Rows.Add(row)
    End Sub

End Class