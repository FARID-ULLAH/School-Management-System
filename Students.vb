Imports System.Text.RegularExpressions

Public Class Students
    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_reader As OleDb.OleDbDataReader
    Dim data_Table As DataTable = New DataTable()
    Dim query As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        load_Data()
    End Sub

    Private Sub Closebtn_Click_1(sender As Object, e As EventArgs) Handles Closebtn.Click
        Me.Hide()
    End Sub

    Private Sub stuAddbtn_Click(sender As Object, e As EventArgs) Handles stuAddBtn.Click
        insert_Data()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        search_Data()
    End Sub

    Private Sub updatBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        update_Record()
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        delete_Record()
    End Sub

    Public Sub insert_Data()

        query = "INSERT INTO stu (Name, FatherName, Class, DOB, Gender, Contact, Address, Remarks, Fee) 
                           VALUES(@p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)"

        If valid() = False Then
            dataLab.Text = "Please Fill Text Boxes with Correct Format"
        Else
            Try
                conn.Open()
                com = New OleDb.OleDbCommand(query, conn)


                com.Parameters.AddWithValue("@p2", stuTxtBox.Text)
                com.Parameters.AddWithValue("@p3", stufathTxtBox.Text)
                com.Parameters.AddWithValue("@p4", classTxtBox.Text)
                com.Parameters.AddWithValue("@p5", datePic.Text)
                If maleBox.Checked Then
                    com.Parameters.AddWithValue("@p6", maleBox.Text)
                Else
                    com.Parameters.AddWithValue("@p6", femaleBox.Text)
                End If

                com.Parameters.AddWithValue("@p7", stuConTxtBox.Text)
                com.Parameters.AddWithValue("@p8", stuAddTxtBox.Text)
                com.Parameters.AddWithValue("@p9", stuRemTxtBox.Text)
                com.Parameters.AddWithValue("@p10", feeTxtBox.Text)


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
        End If


        stuTxtBox.Text = ""
        stufathTxtBox.Text = ""
        classTxtBox.Text = ""
        maleBox.Checked = False
        femaleBox.Checked = False
        stuConTxtBox.Text = ""
        stuAddTxtBox.Text = ""
        stuRemTxtBox.Text = ""
        feeTxtBox.Text = ""

    End Sub

    Public Sub load_Data()
        query = "SELECT * From stu"

        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set)

            listSG.DataSource = data_set.Tables(0)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try


    End Sub



    'validation Subroutine
    Public Function valid() As Boolean
        Dim res As Boolean
        res = False

        If stuTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(stuTxtBox.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect DataType"
        ElseIf stuTxtBox.Text <> "" Then
            res = True
        End If

        If stufathTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(stufathTxtBox.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect DataType"
        ElseIf stufathTxtBox.Text <> "" Then
            res = True
        End If

        If classTxtBox.Text = "" Then
            res = False
        ElseIf IsNumeric(classTxtBox.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect DataType"
            dataLab.Text = "Empty Text Boxes"
        ElseIf classTxtBox.Text <> "" Then
            res = True
        End If



        If stuConTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf stuConTxtBox.Text < 11 Or stuConTxtBox.Text > 12 Then
            stuConTxtBox.Text = "Length Not Match"
            res = False
        Else
            res = True
        End If

        If stuAddTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(stuAddTxtBox.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect DataType"
        ElseIf stuAddTxtBox.Text <> "" Then
            res = True
        End If


        If maleBox.Checked = False And femaleBox.Checked = False Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf maleBox.Checked = True Or femaleBox.Checked = True Then
            res = True
        End If

        If stuRemTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf stuRemTxtBox.Text <> "" Then
            res = True
        End If

        If feeTxtBox.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf feeTxtBox.Text <> "" Then
            res = True
        End If

        Return res


    End Function
    'End Validation Subroutine

    'Contact Validation Subroutine
    Public Function validContact() As Boolean
        Dim res As Boolean
        Dim phonenumber As New Regex("\d{4}-\d{7}")
        If phonenumber.IsMatch(stuConTxtBox.Text) Then
            res = True
        Else
            dataLab.Text = "Incorrect Format"
            res = False
        End If
        Return res
    End Function

    'End Contact Validation Subroutine

    'Search Subroutine

    Public Sub search_Data()
        Dim i As Integer
        query = " SELECT * FROM stu WHERE RollNo = " & Trim(stuRollTxtBox.Text) & ""

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

                    If (stuRollTxtBox.Text) = data_reader(0).ToString() Then

                        'MsgBox("Find")
                        data_adap = New OleDb.OleDbDataAdapter(query, conn)

                        data_set = New DataSet
                        data_adap.Fill(data_set)

                        listSG.DataSource = data_set.Tables(0)
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

    'End Search Subroutine

    'Update Record SubRoutine
    Public Sub update_Record()

        query = "UPDATE stu SET Name = @p1, FatherName= @p2, Class= @p3,
                                DOB = @p4, Contact = @p5, Address = @p6, Gender = @p7 WHERE RollNo = " & stuUpTxtBox.Text & ""

        If valid() = False Then

            dataLab.Text = "Please Fill Empty Text Boxes with Correct Format"

        Else

            Try
                conn.Open()

                com = New OleDb.OleDbCommand(query, conn)

                com.Parameters.AddWithValue("@p1", stuTxtBox.Text)
                com.Parameters.AddWithValue("@p2", stufathTxtBox.Text)
                com.Parameters.AddWithValue("@p3", classTxtBox.Text)
                com.Parameters.AddWithValue("@p4", datePic.Text)
                com.Parameters.AddWithValue("@p5", stuConTxtBox.Text)
                com.Parameters.AddWithValue("@p6", stuAddTxtBox.Text)

                If maleBox.Checked = True Then
                    com.Parameters.AddWithValue("@p7", maleBox.Text)
                Else
                    com.Parameters.AddWithValue("@p7", femaleBox.Text)
                End If
                'com.Parameters.AddWithValue("@p8", datePic.Text)

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

        End If

        stuTxtBox.Text = ""
        stufathTxtBox.Text = ""
        classTxtBox.Text = ""
        maleBox.Checked = False
        femaleBox.Checked = False
        stuConTxtBox.Text = ""
        stuAddTxtBox.Text = ""
        stuRemTxtBox.Text = ""
        feeTxtBox.Text = ""

    End Sub


    'End Update Record

    'Record Deletion SubRoutine

    Public Sub delete_Record()

        query = "DELETE FROM stu WHERE Name = @stuN"

        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@stuN", studelTxtBox.Text)
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



    ' End Record Deletion SubRoutine

End Class
