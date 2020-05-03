Imports System.Text.RegularExpressions

Public Class Faculty

    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As New OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_Table As DataTable = New DataTable()
    Dim query As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        'Get data From DataBase on Load
        load_Data()

    End Sub

    Private Sub facAddBtn_Click(sender As Object, e As EventArgs) Handles facAddBtn.Click
        insert_Data()
    End Sub


    Private Sub facCloseBtn_Click(sender As Object, e As EventArgs) Handles facCloseBtn.Click
        Me.Hide()

    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        delete_Record()
    End Sub

    Private Sub updateBtn_Click_1(sender As Object, e As EventArgs) Handles updateBtn.Click
        update_Record()
    End Sub

    'Data Insertion Sub Routine

    Public Sub insert_Data()

        query = "INSERT INTO fac (TeacherName, FatherName, Address, Contact, Education,  Gender, HireDate, Designation)
                VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)"

        If valid() = False Then
            dataLab.Text = "Please Fill Empty Text"
        Else

            Try
                conn.Open()
                com = New OleDb.OleDbCommand(query, conn)

                com.Parameters.AddWithValue("@p1", teaTxtName.Text)
                com.Parameters.AddWithValue("@p2", teafathTxtName.Text)
                com.Parameters.AddWithValue("@p3", eduTxt.Text)
                com.Parameters.AddWithValue("@p4", desigTxtBox.Text)
                com.Parameters.AddWithValue("@p5", contactTxt.Text)
                com.Parameters.AddWithValue("@p6", datePic.Text)
                If maleBox.Checked = True Then
                    com.Parameters.AddWithValue("@p7", maleBox.Text)
                Else
                    com.Parameters.AddWithValue("@p7", femaleBox.Text)
                End If
                com.Parameters.AddWithValue("@p8", addressTxt.Text)


                Dim i As Integer

                i = com.ExecuteNonQuery()

                If (i > 0) Then
                    dataLab.Text = "Record Saved"
                    conn.Close()
                Else
                    dataLab.Text = "Sorry Try Again"
                    conn.Close()
                End If

            Catch ex As Exception
                MsgBox("Sorry Record Not Saved : " & ex.Message())
                conn.Close()
            End Try

        End If

        teaTxtName.Text = ""
        teafathTxtName.Text = ""
        eduTxt.Text = ""
        contactTxt.Text = ""
        addressTxt.Text = ""
        desigTxtBox.Text = ""
        maleBox.Checked = False
        femaleBox.Checked = False
        teaTxtName.Focus()

    End Sub

    'End Data Insertion Subroutine

    'Populate Data From Database
    Public Sub load_Data()
        query = "SELECT * FROM fac"

        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set, "fac")

            listFG.DataSource = data_set.Tables("fac")

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try


    End Sub

    'End Load Subroutine

    'Update Record SubRoutine
    Public Sub update_Record()

        query = "UPDATE fac SET TeacherName =@p1, FatherName=@p2, Education=@p3,
                                Designation=@p4, Contact=@p5, Address=@p6, Gender=@p7, HireDate=@p8 WHERE ID = " & idUTxtBox.Text & ""
        If valid() = False Then
            dataLab.Text = "Sorry Fill Empty Boxes"
        Else
            Try
                conn.Open()

                com = New OleDb.OleDbCommand(query, conn)
                com.Parameters.AddWithValue("@p1", teaTxtName.Text)
                com.Parameters.AddWithValue("@p2", teafathTxtName.Text)
                com.Parameters.AddWithValue("@p3", eduTxt.Text)
                com.Parameters.AddWithValue("@p4", desigTxtBox.Text)
                'If Not Char.IsDigit(contactTxt.Text) Then
                '    dataLab.Text = "Please Fill Text Boxes with Correct Format"
                'Else
                com.Parameters.AddWithValue("@p5", contactTxt.Text)
                'End If

                com.Parameters.AddWithValue("@p6", addressTxt.Text)

                If maleBox.Checked = True Then
                    com.Parameters.AddWithValue("@p7", maleBox.Text)
                Else
                    com.Parameters.AddWithValue("@p7", femaleBox.Text)
                End If
                com.Parameters.AddWithValue("@p8", datePic.Text)

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

    End Sub

    'End Update Record

    'validation Subroutine
    Public Function valid() As Boolean
        Dim res As Boolean
        res = False

        If teaTxtName.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(teaTxtName.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect Type"
        ElseIf teaTxtName.Text <> "" Then
            res = True
        End If

        If teafathTxtName.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(teafathTxtName.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect Type"
        ElseIf teafathTxtName.Text <> "" Then
            res = True
        End If

        If eduTxt.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(eduTxt.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect Type"
        ElseIf eduTxt.Text <> "" Then
            res = True
        End If

        If desigTxtBox.Text = "" Then
            res = False
            dataLab.Text = "Empty Text Boxes"
        ElseIf IsNumeric(desigTxtBox.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect Type"
        ElseIf desigTxtBox.Text <> "" Then
            res = True
        End If

        If contactTxt.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf valid_Contact() = False Then
            dataLab.Text = "Incorrecr Format"
        Else
            res = True
        End If

        If maleBox.Checked = False And femaleBox.Checked = False Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf maleBox.Checked = True Or femaleBox.Checked = True Then
            res = True
        End If

        If addressTxt.Text = "" Then
            dataLab.Text = "Empty Text Boxes"
            res = False
        ElseIf IsNumeric(addressTxt.Text) Then
            dataLab.Text = "Empty Text Boxes And Incorrect Type"
        ElseIf addressTxt.Text <> "" Then
            res = True
        End If

        Return res

        'End Validation Subroutine
    End Function

    'Contact Validation SubRoutine
    Public Function valid_Contact() As Boolean
        Dim res As Boolean
        Dim phonenumber As New Regex("/d{4}-/d{7}")
        If phonenumber.IsMatch(contactTxt.Text) Then
            res = True
        Else
            dataLab.Text = "Incorrect Format"
            res = False
        End If
        Return res
    End Function

    'End Contact Validation SubRoutine

    'Record Deletion SubRoutine

    Public Sub delete_Record()

        query = "Delete FROM fac WHERE ID = @teaN"

        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@teaN", teadelTxtBox.Text)
            Dim i As Integer

            i = com.ExecuteNonQuery()

            If i > 0 Then
                dataLab.Text = "Record Deleted"
                conn.Close()
            Else
                dataLab.Text = "Record Not Deleted"
            End If
        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub

    ' End Record Deletion SubRoutine


End Class
