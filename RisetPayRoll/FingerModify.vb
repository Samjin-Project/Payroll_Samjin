Imports System.Data.SqlClient

Public Class FingerModify
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub FingerModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        dt_day.Value = DateTime.Now
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "HH:mm"


        'Dim row As String() = New String() {"1", True, "200001", "Riki", "2010/11/20", "Siang", "Check In", "07:30", "07:32", "True", "Rubber", "0000/00/00"}
        'DGV_DataModify.Rows.Add(row)

        Dim querycmd As String = "SELECT * FROM `finger_employer` "
        Dim DBClass As DataBaseClass = New DataBaseClass ' Inisiasi class yg telah di buat
        Dim ds As DataSet = DBClass.downloadDB(querycmd) ' tabel yg didapat di masukan kedalam variabel ds memiliki tipe data Dataset, queryCMD beris Query SQL atau perintah untuk SELECT atau UPDATE...
        Dim indexDs As Integer = ds.Tables(0).Rows.Count ' cek Jumlah Rows Tabel
        On Error Resume Next
        'Setelah jumalh tabel nya diketahui data pada masing2 tabel di masukan ke damal array bertipe data string

        Dim fingerStatus As Boolean
        Dim UploadEmp As String = "Pak Umar"
        For i As Integer = 0 To indexDs - 1 'looping mengambil data perbaris
            ' ds.tables = nama tabel
            ' rows = baris
            ' item = kolom
            Dim fingerTime As String = ""
            Dim StatusTabel As String = ""
            If RadioButton1.Checked = True Then
                fingerTime = ds.Tables(0).Rows(i).Item(7).ToString
                StatusTabel = "Check In"
            Else
                fingerTime = ds.Tables(0).Rows(i).Item(8).ToString
                StatusTabel = "Check Out"
            End If
            If ds.Tables(0).Rows(i).Item(11) = 0 Then
                fingerStatus = False
            Else
                fingerStatus = True
            End If
            Dim row As String() = New String() {(i + 1).ToString,
                                                False,
                                                ds.Tables(0).Rows(i).Item(1).ToString, 'NIK
                                                ds.Tables(0).Rows(i).Item(2).ToString, 'NAMA
                                                ds.Tables(0).Rows(i).Item(3).ToString, 'DATE_FINGER
                                                ds.Tables(0).Rows(i).Item(4).ToString, 'SHIFT
                                                StatusTabel, 'Check In Or Check Out
                                                fingerTime,
                                                "", ' rec time
                                                fingerStatus, 'FingerStatus
                                                ds.Tables(0).Rows(i).Item(9).ToString, 'DEP
                                                ds.Tables(0).Rows(i).Item(10).ToString, 'UPLOAD DATE
                                                UploadEmp 'UPLOAD EMP
                                                }
            'Setelah dapat dalam bentuk array, array tersebut dimasukan kedalam fungsi dibawah
            'DGV_DataModify.Rows.Add(row) : Row tersebut isinya data satu baris yg telah diambil
            DGV_DataModify.Rows.Add(row)

            'Di bawah ini hanya untuk memprecantik
            DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
            If i Mod 2 = 1 Then
                DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
        Next
    End Sub

    Private Sub rec_time_Click(sender As Object, e As EventArgs) Handles rec_time.Click
        For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
            Console.WriteLine(DGV_DataModify.Rows.Count)
            If DGV_DataModify.Rows(i).Cells(1).Value = True Then
                DGV_DataModify.Rows(i).Cells(8).Value = DateTimePicker1.Value
            End If
        Next
    End Sub

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "update table1 Check In or Out='"DateTimePicker1"'"
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class