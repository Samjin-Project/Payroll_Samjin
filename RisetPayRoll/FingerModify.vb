Imports System.Data.SqlClient

Public Class FingerModify
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FingerModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As String() = New String() {"1", True, "200001", "Riki", "2010/11/20", "Siang", "Check In", "07:30", "07:32", "True", "Rubber", "0000/00/00"}
        DGV_DataModify.Rows.Add(row)

        con.ConnectionString = ""

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub rec_time_Click(sender As Object, e As EventArgs) Handles rec_time.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update table1 Check In or Out='"DateTimePicker1"'"
        cmd.ExecuteNonQuery()
    End Sub
End Class