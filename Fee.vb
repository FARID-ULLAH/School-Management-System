Public Class Fee

    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_reader As OleDb.OleDbDataReader
    Dim query As String



    Private Sub Fee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        load_Data()
    End Sub

    Private Sub feeCloseBtn_Click(sender As Object, e As EventArgs) Handles feeCloseBtn.Click
        Me.Hide()
    End Sub

    Private Sub addFeeBtn_Click(sender As Object, e As EventArgs) Handles addFeeBtn.Click
        insert_Data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        search_Data()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        update_Record()
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        delete_Record()
    End Sub


    Public Sub insert_Data()

        query = "INSERT INTO fee ( Amount, Remaining, Fee_Date, Slip ) VALUES ( @p1, @p2, @p3, @p4 )"

        Try
            conn.Open()
            com = New OleDb.OleDbCommand(query, conn)

            com.Parameters.AddWithValue("@p1", admitFeeTxtBox.Text)
            com.Parameters.AddWithValue("@p2", remFeeTxtBox.Text)
            com.Parameters.AddWithValue("@p3", datePic.Text)
            com.Parameters.AddWithValue("@p4", feeSlipTxtBox.Text)

            Dim i As Integer

            i = com.ExecuteNonQuery()

            If (i > 0) Then
                dataLab.Text = "Record Saved"
                conn.Close()
            Else
                dataLab.Text = "Record Not Added"
                conn.Close()
            End If

        Catch ex As Exception
            MsgBox("Sorry Record Not Saved : " & ex.Message())
            conn.Close()
        End Try
        admitFeeTxtBox.Text = ""
        remFeeTxtBox.Text = ""

        feeSlipTxtBox.Text = ""
        admitFeeTxtBox.Focus()
    End Sub

    Public Sub load_Data()
        query = "SELECT RollNo, Name, FatherName, Class, Amount, Remaining, Fee_Date, Slip From fee, stu WHERE stu.ID = fee.ID"
        'RollNo, Name, FatherName, Class, 
        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set)

            listFG.DataSource = data_set.Tables(0)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub




    Public Sub search_Data()
        Dim i As Integer
        query = " SELECT RollNo, Name, FatherName, Class, Amount, Remaining, Fee_Date, Slip FROM stu,fee WHERE RollNo = " & Trim(stuSeaTxtBox.Text) & " AND stu.ID = fee.ID"

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

                    If (stuSeaTxtBox.Text) = data_reader(0).ToString() Then

                        'MsgBox("Find")
                        data_adap = New OleDb.OleDbDataAdapter(query, conn)

                        data_set = New DataSet
                        data_adap.Fill(data_set)

                        listFG.DataSource = data_set.Tables(0)
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

        query = "UPDATE fee SET Amount = @p1, Remaining = @p2, Fee_Date= @p3, Slip = @p4 WHERE ID = " & feeUPTxtBox.Text & ""
        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@p1", admitFeeTxtBox.Text)
            com.Parameters.AddWithValue("@p2", remFeeTxtBox.Text)
            com.Parameters.AddWithValue("@p3", datePic.Text)
            com.Parameters.AddWithValue("@p4", feeSlipTxtBox.Text)

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

        query = "DELETE FROM fee WHERE ID = @stuN"

        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)
            com.Parameters.AddWithValue("@stuN", feeTxtBox.Text)
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



    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
