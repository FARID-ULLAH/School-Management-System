Public Class Examination

    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_reader As OleDb.OleDbDataReader
    Dim query As String

    Private Sub Examination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        load_Data()
    End Sub


    Private Sub examCloseBtn_Click(sender As Object, e As EventArgs) Handles examCloseBtn.Click
        Me.Hide()
    End Sub

    Private Sub addFeeBtn_Click(sender As Object, e As EventArgs) Handles addFeeBtn.Click
        insert_Data()
    End Sub

    Private Sub seaBtn_Click(sender As Object, e As EventArgs) Handles seaBtn.Click
        search_Data()
    End Sub

    Public Sub load_Data()
        query = "SELECT RollNo, Name, FatherName, Class, sub1, sub2, sub3, sub4, sub5,
                 Total, Obt, Per FROM exams"

        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set)

            listEG.DataSource = data_set.Tables(0)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try


    End Sub

    Public Sub insert_Data()

        query = "INSERT INTO exams (RollNo, Name, FatherName, Class, sub1, sub2, sub3, sub4, sub5, Total, Obt, Per)
                 VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)"

        Try
            conn.Open()
            com = New OleDb.OleDbCommand(query, conn)

            com.Parameters.AddWithValue("@p1", rollTxtBox.Text)
            com.Parameters.AddWithValue("@p2", stuTxtBox.Text)
            com.Parameters.AddWithValue("@p3", fathTxtBox.Text)
            com.Parameters.AddWithValue("@p4", claTxtBox.Text)
            com.Parameters.AddWithValue("@p5", sub1TxtBox.Text)
            com.Parameters.AddWithValue("@p6", sub2TxtBox.Text)
            com.Parameters.AddWithValue("@p7", sub3TxtBox.Text)
            com.Parameters.AddWithValue("@p8", sub4TxtBox.Text)
            com.Parameters.AddWithValue("@p9", sub5TxtBox.Text)

            cal_Ave()

            com.Parameters.AddWithValue("@p10", tottxtBox.Text)
            com.Parameters.AddWithValue("@p11", obtTxtBox.Text)
            com.Parameters.AddWithValue("@p12", perTxtBox.Text)


            Dim i As Integer

            i = com.ExecuteNonQuery()

            If (i > 0) Then
                MsgBox("Data Added")
                conn.Close()
            Else
                MsgBox("Sorry Try Again")
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox("Sorry Record Not Saved : " & ex.Message())
        End Try
        stuTxtBox.Text = ""
        fathTxtBox.Text = ""
        rollTxtBox.Text = ""
        claTxtBox.Text = ""
        sub1TxtBox.Text = ""
        sub2TxtBox.Text = ""
        sub3TxtBox.Text = ""
        sub4TxtBox.Text = ""
        sub5TxtBox.Text = ""


    End Sub


    Public Sub search_Data()
        Dim i As Integer
        query = " SELECT RollNo, Name, FatherName, Class, sub1, sub2, sub3, sub4, sub5,
                 Total, Obt, Per FROM exams WHERE RollNo = " & Trim(rollSeaTxtBox.Text) & ""

        conn.Open()
        com = New OleDb.OleDbCommand(query, conn)
        data_reader = com.ExecuteReader()

        Try
            If (data_reader.HasRows) = False Then
                MsgBox("No Record")
                conn.Close()
                Exit Sub
            Else

                While (data_reader.Read())

                    If (rollSeaTxtBox.Text) = data_reader(0).ToString() Then

                        'MsgBox("Find")
                        data_adap = New OleDb.OleDbDataAdapter(query, conn)

                        data_set = New DataSet
                        data_adap.Fill(data_set)

                        listEG.DataSource = data_set.Tables(0)
                    Else
                        MsgBox("Sorry Searching Fails")

                    End If

                End While

            End If
            data_reader.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub

    Public Sub update_Record()

        query = "UPDATE exams SET Name = @p1, FatherName = @p2, Class= @p3, sub1 = @p4, sub2 = @p5,
                 sub3 = @p6, sub4 = @p7, sub5 = @p8, Total = @p9, Obt = @p10, Per = @p11 WHERE RollNo = " & examUPTxtBox.Text & ""
        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@p1", stuTxtBox.Text)
            com.Parameters.AddWithValue("@p2", fathTxtBox.Text)
            com.Parameters.AddWithValue("@p3", claTxtBox.Text)
            com.Parameters.AddWithValue("@p4", sub1TxtBox.Text)
            com.Parameters.AddWithValue("@p5", sub2TxtBox.Text)
            com.Parameters.AddWithValue("@p6", sub3TxtBox.Text)
            com.Parameters.AddWithValue("@p7", sub4TxtBox.Text)
            com.Parameters.AddWithValue("@p8", sub5TxtBox.Text)
            com.Parameters.AddWithValue("@p9", tottxtBox.Text)
            com.Parameters.AddWithValue("@p10", obtTxtBox.Text)
            com.Parameters.AddWithValue("@p11", perTxtBox.Text)


            Dim i As Integer

            i = com.ExecuteNonQuery()

            If i > 0 Then
                dataLab.Text = "Record Updated"
                conn.Close()
            Else
                dataLab.Text = " Sorry ! Record Not Updated"
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub

    Public Sub delete_Record()

        query = "DELETE FROM exams WHERE RollNo = @stuN"

        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@stuN", examdelTxtBox.Text)
            Dim i As Integer

            i = com.ExecuteNonQuery()

            If i > 0 Then
                dataLab.Text = "Record Deleted"
                conn.Close()
            Else
                dataLab.Text = "Record Not Deleted"
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub

    Public Sub cal_Ave()

        Dim per, sum As Double

        Dim sub1, sub2, sub3, sub4, sub5 As Double

        sub1 = sub1TxtBox.Text
        sub2 = sub2TxtBox.Text
        sub3 = sub3TxtBox.Text
        sub4 = sub4TxtBox.Text
        sub5 = sub5TxtBox.Text

        sum = sub1 + sub2 + sub3 + sub4 + sub5
        obtTxtBox.Text = sum
        per = (sum * 100) / 500
        perTxtBox.Text = per

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        update_Record()
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        delete_Record()
    End Sub

    Private Sub calBtn_Click(sender As Object, e As EventArgs) Handles calBtn.Click
        cal_Ave()
    End Sub
End Class
