Imports System.Data.SqlClient

Public Class FingerModify
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public QueryUtama As String = "SELECT `NO`,`Time_Upload`,`NIK`,`Nama_Karyawan`,`Date_Finger`,`Shift_Finger`,`On_Duty`,`Off_Duty`,`Check_In`,`Check_Out`,`Departement`,`Finger Status`,`RecFinIN`,`RecFinOut` FROM `finger_employer`"
    Public f_filterIn As Boolean = False
    Public f_filterOut As Boolean = False
    Public f_empSearch As Boolean = False

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
    Private Sub FingerModify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.StatusUser = "admin" Then
            If My.Settings.Departement.ToString = "PCBA" Then
                cb_dep_fin.Items.Clear()
                cb_dep_fin.Items.Add("PCBA")
                cb_dep_fin.Items.Add("SMD")
                cb_dep_fin.Text = My.Settings.Departement.ToString
            Else
                cb_dep_fin.Text = My.Settings.Departement.ToString
                cb_dep_fin.Enabled = False
                Debug.WriteLine(My.Settings.Departement)
            End If
        Else
            For Each x As String In MDIParent1.JenisDepartement
                cb_dep_fin.Items.Add(x)
            Next
        End If

        RadioButton1.Checked = True
        dt_day.Value = DateTime.Now
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "HH:mm"
        'cb_dep.Text = "PCBA"
        'Dim dep As String = cb_dep.Text
        'Dim querycmd As String = $"{QueryUtama} WHERE `Date_Finger` = '{dt_day.Value.ToString("yyyy-MM-dd")}' AND `Departement` = '{dep}' "
        'DGV_DataModify.Rows.Clear()
        'Dim DBClass As DataBaseClass = New DataBaseClass
        'Dim ds As DataSet = DBClass.downloadDB(querycmd)
        'insertToDgv(ds)
    End Sub

    Private Sub rec_time_Click(sender As Object, e As EventArgs) Handles rec_time.Click
        For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
            'Console.WriteLine(DGV_DataModify.Rows.Count)
            If DGV_DataModify.Rows(i).Cells(1).Value = True Then
                Dim recFinger As String = DateTimePicker1.Value.ToString("HH:mm")


                Dim dtimerow As DateTime = CDate(DGV_DataModify.Rows(i).Cells(7).Value)
                Dim statusCheck As String = DGV_DataModify.Rows(i).Cells(6).Value

                Dim recFingerTime As DateTime

                DGV_DataModify.Rows(i).Cells(8).Value = DateTimePicker1.Value.ToString("HH:mm")
                Dim Nik As String = DGV_DataModify.Rows(i).Cells(2).Value
                Dim DateFinger As String = dt_day.Value.ToString("yyyy-MM-dd")
                Dim syaratPanjang As Boolean = recFinger.Length = 5
                Dim syaratInput As Boolean
                Debug.WriteLine("L : " + recFinger.Length.ToString)
                If syaratPanjang Then
                    syaratInput = recFinger(2) = ":" And Char.IsDigit(recFinger(0)) And Char.IsDigit(recFinger(1)) And Char.IsDigit(recFinger(3)) And Char.IsDigit(recFinger(4))
                Else
                    syaratInput = False
                End If
                Dim isRec As Boolean = True

                'If recFinger <> "" And recFinger <> ":" Then
                recFingerTime = CDate(recFinger)
                If (dtimerow < recFingerTime And statusCheck = "Check Out") Or (dtimerow > recFingerTime And statusCheck = "Check In") Then
                    DGV_DataModify.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                    isRec = False
                Else
                    DGV_DataModify.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    DGV_DataModify.Rows(i).Cells(8).Style.ForeColor = Color.Red

                End If
                'End If

                Debug.WriteLine("syarat input : " + syaratInput.ToString)
                Debug.WriteLine("isRec : " + isRec.ToString)
                If syaratInput And isRec Then
                    If Convert.ToInt32(recFinger.Substring(0, 2)) < 24 And Convert.ToInt32(recFinger.Substring(3, 2)) < 60 Then
                        Dim DBClass As DataBaseClass = New DataBaseClass
                        Dim querycmd As String
                        If RadioButton1.Checked = True Then
                            querycmd = $"UPDATE `finger_employer` SET `recFinIn` = '{recFinger}',`Modified` = 1 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                        Else
                            querycmd = $"UPDATE `finger_employer` SET `recFinOut` = '{recFinger}',`Modified` = 1 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                        End If
                        DBClass.uploadDB(querycmd)
                    Else
                        DGV_DataModify.Rows(i).Cells(8).Value = ":"
                        MessageBox.Show("Wrong Format")
                    End If
                Else
                    Console.WriteLine("Harus Kodong : " + DGV_DataModify.Rows(i).Cells(8).Value.ToString)
                    If i = 8 Then
                        DGV_DataModify.Rows(i).Cells(8).Value = ":"
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
                Console.WriteLine(DGV_DataModify.Rows.Count)
                If DGV_DataModify.Rows(i).Cells(1).Value = False Then
                    DGV_DataModify.Rows(i).Cells(1).Value = True
                End If
                'Dim querycmd As String = "UPDATE `finger_employer` SET  "
                'DGV_DataModify.Rows.Clear()
                'Dim DBClass As DataBaseClass = New DataBaseClass
                'Dim ds As DataSet = DBClass.downloadDB(querycmd)
            Next
        Else
            For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
                Console.WriteLine(DGV_DataModify.Rows.Count)
                If DGV_DataModify.Rows(i).Cells(1).Value = True Then
                    DGV_DataModify.Rows(i).Cells(1).Value = False
                End If
                'Dim querycmd As String = "UPDATE `finger_employer` SET  "
                'DGV_DataModify.Rows.Clear()
                'Dim DBClass As DataBaseClass = New DataBaseClass
                'Dim ds As DataSet = DBClass.downloadDB(querycmd)
            Next
        End If
    End Sub
    Private Sub insertToDgv(ds As DataSet)
        If ds IsNot Nothing Then

            Dim indexDs As Integer = ds.Tables(0).Rows.Count
            Dim fingerStatus As Boolean
            Dim UploadEmp As String = My.Settings.NamaUser
            For i As Integer = 0 To indexDs - 1 'looping mengambil data perbaris
                ' ds.tables = nama tabel
                ' rows = baris
                ' item = kolom
                Dim fingerTime As String = ""
                Dim StatusTabel As String = ""
                Dim recTime As String = ""
                If RadioButton1.Checked = True Then
                    fingerTime = ds.Tables(0).Rows(i).Item(8).ToString
                    recTime = ds.Tables(0).Rows(i).Item(12).ToString
                    StatusTabel = "Check In"
                Else
                    fingerTime = ds.Tables(0).Rows(i).Item(9).ToString
                    recTime = ds.Tables(0).Rows(i).Item(13).ToString
                    StatusTabel = "Check Out"
                End If
                If ds.Tables(0).Rows(i).Item(11) = 0 Then
                    fingerStatus = False
                Else
                    fingerStatus = True
                End If
                Dim row As String() = New String() {(i + 1).ToString,
                                                        False,
                                                        ds.Tables(0).Rows(i).Item(2).ToString, 'NIK
                                                        ds.Tables(0).Rows(i).Item(3).ToString, 'NAMA
                                                        ds.Tables(0).Rows(i).Item(4).ToString.Substring(0, 10), 'DATE_FINGER
                                                        ds.Tables(0).Rows(i).Item(5).ToString, 'SHIFT
                                                        StatusTabel, 'Check In Or Check Out
                                                        fingerTime,
                                                        recTime, ' rec time
                                                        fingerStatus, 'FingerStatus
                                                        ds.Tables(0).Rows(i).Item(10).ToString, 'DEP
                                                        ds.Tables(0).Rows(i).Item(1).ToString, 'UPLOAD DATE
                                                        UploadEmp 'UPLOAD EMP
                                                        }
                DGV_DataModify.Rows.Add(row)

                DGV_DataModify.Rows(i).HeaderCell.Value = (i + 1).ToString
                If i Mod 2 = 1 Then
                    DGV_DataModify.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
            Next
        End If
        total.Text = DGV_DataModify.Rows.Count
    End Sub
    Private Sub SortingTabel(sortType As Boolean)
        'Console.WriteLine("Query : TEESTTTTTTIng")
        Dim shift As String = cb_shift.Text
        Dim datePilihan As String = dt_day.Value.ToString("yyyy-MM-dd")
        Dim datePilihan1 As String = dt_date1.Value.ToString("yyyy-MM-dd")
        Dim querycmd As String
        Dim dep As String = cb_dep_fin.Text
        Dim fingTime As String = dt_filter.Value.ToString("HH:mm")

        If sortType = False Then
            If f_filterIn = True Then
                If shift = "ALL" Then
                    querycmd = $"{QueryUtama} WHERE `Date_Finger` = '{datePilihan}' AND `Departement` = '{dep}' AND `Check_In` >= '{fingTime}'"
                Else
                    querycmd = $"{QueryUtama} WHERE `Shift_Finger` LIKE '{shift}' AND (`Date_Finger` BETWEEN '{datePilihan}' AND '{datePilihan1}' ) AND `Departement` = '{dep}' AND `Check_In` >= '{fingTime}'"
                End If
            ElseIf f_filterOut = True Then
                If shift = "ALL" Then
                    querycmd = $"{QueryUtama} WHERE `Date_Finger` = '{datePilihan}' AND `Departement` = '{dep}' AND `Check_Out` >= '{fingTime}' "
                Else
                    querycmd = $"{QueryUtama} WHERE `Shift_Finger` LIKE '{shift}' AND (`Date_Finger` BETWEEN '{datePilihan}' AND '{datePilihan1}' ) AND `Departement` = '{dep}' AND `Check_Out` >= '{fingTime}'"
                End If
            Else
                If shift = "ALL" Then
                    querycmd = $"{QueryUtama} WHERE `Date_Finger` = '{datePilihan}' AND `Departement` = '{dep}'"
                Else
                    querycmd = $"{QueryUtama} WHERE `Shift_Finger` LIKE '{shift}' AND (`Date_Finger` BETWEEN '{datePilihan}' AND '{datePilihan1}' ) AND `Departement` = '{dep}' AND (`Check_Out` <> '' OR `Check_In` <> '') "
                End If
            End If
        ElseIf sortType = True Then
            querycmd = $"{QueryUtama} WHERE (`Date_Finger` BETWEEN '{datePilihan}' AND '{datePilihan1}' ) AND `NIK` = '{TextBox10.Text}' AND `Departement` = '{dep}'"
        End If

        DGV_DataModify.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim ds As DataSet = DBClass.downloadDB(querycmd)
        insertToDgv(ds)
        Console.WriteLine("Query : " + querycmd)
    End Sub

    Private Sub b_search_Click(sender As Object, e As EventArgs) Handles b_search.Click
        If TextBox10.Text <> "" Then
            SortingTabel(True)
            f_empSearch = False
        Else
            SortingTabel(False)
        End If
        CheckBox1.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For i As Integer = 0 To DGV_DataModify.Rows.Count - 1
            'DGV_DataModify.Rows(i).Cells(0).Value
        Next
    End Sub

    Private Sub SaveAndUpload()
        Dim funcDB As DataBaseClass = New DataBaseClass
        Dim indexRows As Integer = DGV_DataModify.Rows.Count - 1
        For i As Integer = 2 To indexRows - 1
            'Dim admisionDate As Date = Date.ParseExact(DS.Tables(0).Rows(i).Item(9), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Dim masterQuery As String = $"UPDATE finger_employer
            '                             SET RecFinIN = {DGV_DataModify.Rows(i).Cells(8)}, RecFinOut = {}
            'WHERE condition"
            'Console.WriteLine("DB Query : " + masterQuery)
            'funcDB.uploadDB(masterQuery)
        Next
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
        Dim Nik As String = DGV_DataModify.Rows(indexRows).Cells(2).Value
        Dim DateFinger As String = dt_day.Value.ToString("yyyy-MM-dd")
        Dim syaratPanjang As Boolean = recFinger.Length = 5
        Dim syaratInput As Boolean
        Dim dtimerow As DateTime
        Dim statusCheck As String
        Dim recFingerTime As DateTime
        Try
            dtimerow = CDate(DGV_DataModify.Rows(indexRows).Cells(7).Value)
            statusCheck = DGV_DataModify.Rows(indexRows).Cells(6).Value
            recFingerTime = CDate(recFinger)
        Catch ex As Exception
            Exit Sub
        End Try


        If syaratPanjang Then
            syaratInput = recFinger(2) = ":" And Char.IsDigit(recFinger(0)) And Char.IsDigit(recFinger(1)) And Char.IsDigit(recFinger(3)) And Char.IsDigit(recFinger(4))
        Else
            syaratInput = False
        End If

        Dim isrec As Boolean = True
        If (dtimerow < recFingerTime And statusCheck = "Check Out") Or (dtimerow > recFingerTime And statusCheck = "Check In") Then
            DGV_DataModify.Rows(indexRows).DefaultCellStyle.ForeColor = Color.Red
            isRec = False
        Else
            DGV_DataModify.Rows(indexRows).DefaultCellStyle.ForeColor = Color.Black
            DGV_DataModify.Rows(indexRows).Cells(8).Style.ForeColor = Color.Red

        End If


        If syaratInput And isrec Then
            If Convert.ToInt32(recFinger.Substring(0, 2)) < 24 And Convert.ToInt32(recFinger.Substring(3, 2)) < 60 Then
                Dim DBClass As DataBaseClass = New DataBaseClass
                Dim querycmd As String
                If RadioButton1.Checked = True Then
                    querycmd = $"UPDATE `finger_employer` SET `recFinIn` = '{recFinger}', `Modified` = 1 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                Else
                    querycmd = $"UPDATE `finger_employer` SET `recFinOut` = '{recFinger}',`Modified` = 1 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                End If
                DBClass.uploadDB(querycmd)
            Else
                DGV_DataModify.Rows(indexRows).Cells(8).Value = "00:00"
                MessageBox.Show("Wrong Format")
            End If
        Else
            Console.WriteLine("Harus Kodong : " + DGV_DataModify.Rows(indexRows).Cells(8).Value.ToString)
            If e.ColumnIndex = 8 Then
                DGV_DataModify.Rows(indexRows).Cells(8).Value = ":"
                Dim DBClass As DataBaseClass = New DataBaseClass
                Dim querycmd As String
                If RadioButton1.Checked = True Then
                    querycmd = $"UPDATE `finger_employer` SET `recFinIn` = '', `Modified` = 0 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                Else
                    querycmd = $"UPDATE `finger_employer` SET `recFinOut` = '',`Modified` = 0 WHERE `NIK` = '{Nik}' And `Date_Finger` = '{DateFinger}'"
                End If
                DBClass.uploadDB(querycmd)

            End If
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles b_filter.Click
        If RadioButton1.Checked Then
            f_filterIn = True
        ElseIf RadioButton2.Checked Then
            f_filterOut = True
        End If
        SortingTabel(False)
        f_filterIn = False
        f_filterOut = False
        CheckBox1.Checked = False
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        f_empSearch = True
    End Sub

    Private Sub b_showAll_Click(sender As Object, e As EventArgs) Handles b_showAll.Click
        DGV_DataModify.Rows.Clear()
        Dim DBClass As DataBaseClass = New DataBaseClass
        Dim q As String = QueryUtama
        If cb_dep_fin.Enabled = False Or cb_dep_fin.Text = "PCBA" Or cb_dep_fin.Text = "SMD" Then
            q = QueryUtama + $" WHERE `Departement` = '{cb_dep_fin.Text}'"
        End If
        Dim ds As DataSet = DBClass.downloadDB(q)
        insertToDgv(ds)
        CheckBox1.Checked = False
    End Sub

    Private Sub dt_date1_ValueChanged(sender As Object, e As EventArgs) Handles dt_date1.ValueChanged
        If dt_date1.Value < dt_day.Value Then
            dt_day.Value = dt_date1.Value
        End If
    End Sub

    Private Sub dt_day_ValueChanged(sender As Object, e As EventArgs) Handles dt_day.ValueChanged
        If dt_date1.Value < dt_day.Value Then
            dt_date1.Value = dt_day.Value
        End If
    End Sub

End Class