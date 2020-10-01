Imports System.Data.SqlClient

Public Class FingerModify
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FingerModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        RadioButton1.Checked = True
        dt_day.Value = DateTime.Now
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "HH:mm"

        Dim querycmd As String = "SELECT * FROM `finger_employer` "
        DGV_DataModify.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        insertToDgv(ds)
    End Sub

    Private Sub rec_time_Click(sender As Object, e As EventArgs) Handles rec_time.Click
        For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
            Console.WriteLine(DGV_DataModify.Rows.Count)
            If DGV_DataModify.Rows(i).Cells(1).Value = True Then
                DGV_DataModify.Rows(i).Cells(8).Value = DateTimePicker1.Value
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
                Console.WriteLine(DGV_DataModify.Rows.Count)
                Dim RecFinger As String = DGV_DataModify.Rows(i).Cells(7).Value = True
                Dim querycmd As String = "UPDATE `finger_employer` SET  "
                DGV_DataModify.Rows.Clear()
                Dim DBClass As DataBaseClass = New DataBaseClass
                Dim ds As DataSet = DBClass.downloadDB(querycmd)
            Next
        End If
    End Sub



    Private Sub insertToDgv(ds As DataSet)

        Dim indexDs As Integer = ds.Tables(0).Rows.Count
        Dim fingerStatus As Boolean
        Dim UploadEmp As String = "Pak Umar"
        For i As Integer = 0 To indexDs - 1 'looping mengambil data perbaris
            ' ds.tables = nama tabel
            ' rows = baris
            ' item = kolom
            Dim fingerTime As String = ""
            Dim StatusTabel As String = ""
            If RadioButton1.Checked = True Then
                fingerTime = ds.Tables(0).Rows(i).Item(8).ToString
                StatusTabel = "Check In"
            Else
                fingerTime = ds.Tables(0).Rows(i).Item(9).ToString
                StatusTabel = "Check Out"
            End If
            If ds.Tables(0).Rows(i).Item(13) = 0 Then
                fingerStatus = False
            Else
                fingerStatus = True
            End If
            Dim row As String() = New String() {(i + 1).ToString,
                                                False,
                                                ds.Tables(0).Rows(i).Item(2).ToString, 'NIK
                                                ds.Tables(0).Rows(i).Item(3).ToString, 'NAMA
                                                ds.Tables(0).Rows(i).Item(4).ToString, 'DATE_FINGER
                                                ds.Tables(0).Rows(i).Item(5).ToString, 'SHIFT
                                                StatusTabel, 'Check In Or Check Out
                                                fingerTime,
                                                "", ' rec time
                                                fingerStatus, 'FingerStatus
                                                ds.Tables(0).Rows(i).Item(12).ToString, 'DEP
                                                ds.Tables(0).Rows(i).Item(1).ToString, 'UPLOAD DATE
                                                UploadEmp 'UPLOAD EMP
                                                }
            DGV_DataModify.Rows.Add(row)

            DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub
    Private Sub SortingTabel(sortType As Boolean)
        Dim shift As String = cb_shift.Text
        Dim datePilihan As String = dt_day.Value.ToString("M/d/yyyy")
        Dim querycmd As String
        If sortType = False Then
            If shift = "ALL" Then
                querycmd = $"SELECT * FROM `finger_employer` WHERE `Date_Finger` = '{datePilihan}'"
            Else
                querycmd = $"SELECT * FROM `finger_employer` WHERE `Shift_Finger` = '{shift}' AND `Date_Finger` = '{datePilihan}'"
            End If
        ElseIf sortType = True Then
            querycmd = $"SELECT * FROM `finger_employer` WHERE `Date_Finger` = '{datePilihan}' AND `NIK` = '{TextBox10.Text}'"
        End If
        DGV_DataModify.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        insertToDgv(ds)
        Console.WriteLine("Query : " + querycmd)
    End Sub
    Private Sub dt_day_ValueChanged(sender As Object, e As EventArgs) Handles dt_day.ValueChanged
        SortingTabel(False)
    End Sub

    Private Sub cb_shift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_shift.SelectedIndexChanged
        SortingTabel(False)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        SortingTabel(False)
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (e.KeyChar = Chr(13)) Then
            SortingTabel(True)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
            'DGV_DataModify.Rows(i).Cells(0).Value
        Next
    End Sub

    Private Sub tes()

    End Sub
    Private Sub DGV_DataModify_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGV_DataModify.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf cell_KeyDown
    End Sub

    Private Sub cell_KeyDown(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

            MessageBox.Show("Success")
            Dim indexRows As Integer = DGV_DataModify.CurrentRow.Index
            If indexRows > 0 Then
                Dim recFinger As String = DGV_DataModify.Rows(indexRows).Cells(8).Value
                Dim syaratPanjang As Boolean = recFinger.Length = 5
                Dim syaratInput As Boolean
                If syaratPanjang Then
                    syaratInput = recFinger(2) = ":" And Char.IsDigit(recFinger(0)) And Char.IsDigit(recFinger(1)) And Char.IsDigit(recFinger(3)) And Char.IsDigit(recFinger(4))
                Else
                    syaratInput = False
                End If
                Console.WriteLine("recfinger : " + recFinger)
                If syaratInput Then
                    Dim DBClass As DataBaseClass = New DataBaseClass
                    Dim querycmd As String
                    If RadioButton1.Checked = True Then
                        querycmd = $"UPDATE `finger_employer` SET `recFingerIn` = '{recFinger}'"
                    Else
                        querycmd = $"UPDATE `finger_employer` SET `recFingerOut` = '{recFinger}'"
                    End If
                    Console.WriteLine(querycmd)
                    DBClass.uploadDB(querycmd)
                Else
                    DGV_DataModify.CurrentCell = DGV_DataModify(indexRows - 1, 8)
                End If
            End If
        End If
    End Sub

    Private Sub DGV_DataModify_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_DataModify.CellEndEdit
        Dim indexRows As Integer = e.RowIndex
        Dim recFinger As String = DGV_DataModify.Rows(indexRows).Cells(8).Value
        Dim syaratPanjang As Boolean = recFinger.Length = 5
        Dim syaratInput As Boolean
        If syaratPanjang Then
            syaratInput = recFinger(2) = ":" And Char.IsDigit(recFinger(0)) And Char.IsDigit(recFinger(1)) And Char.IsDigit(recFinger(3)) And Char.IsDigit(recFinger(4))
        Else
            syaratInput = False
        End If
        If syaratInput Then
            If Convert.ToInt32(recFinger.Substring(0, 2)) < 24 And Convert.ToInt32(recFinger.Substring(3, 2)) < 60 Then
                Dim DBClass As DataBaseClass = New DataBaseClass
                Dim querycmd As String
                If RadioButton1.Checked = True Then
                    querycmd = $"UPDATE `finger_employer` SET `recFingerIn` = '{recFinger}'"
                Else
                    querycmd = $"UPDATE `finger_employer` SET `recFingerOut` = '{recFinger}'"
                End If
                DBClass.uploadDB(querycmd)
            Else
                DGV_DataModify.Rows(indexRows).Cells(8).Value = "00:00"
                MessageBox.Show("Wrong Format")
            End If
        Else
            DGV_DataModify.Rows(indexRows).Cells(8).Value = "00:00"
        End If

    End Sub
End Class