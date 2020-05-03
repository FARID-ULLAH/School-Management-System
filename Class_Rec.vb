Public Class Class_Rec

    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_reader As OleDb.OleDbDataReader
    Dim query As String

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        load_Data()
    End Sub

    Private Sub classCloseBtn_Click(sender As Object, e As EventArgs) Handles classCloseBtn.Click
        Me.Hide()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        search_Data()
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        update_Record()
    End Sub

    Public Sub load_Data()
        query = "SELECT * FROM clas"

        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set)

            listCG.DataSource = data_set.Tables(0)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try


    End Sub

    Public Sub search_Data()
        Dim i As Integer
        query = " SELECT * FROM clas WHERE ID = " & Trim(classSeaTxtBox.Text) & ""

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

                    If (classSeaTxtBox.Text) = data_reader(0).ToString() Then
                        'MsgBox("Find")
                        data_adap = New OleDb.OleDbDataAdapter(query, conn)

                        data_set = New DataSet
                        data_adap.Fill(data_set)

                        listSCG.DataSource = data_set.Tables(0)
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

        query = "UPDATE clas SET Strength = @p1, Head= @p2 WHERE ID = " & claUPTxtBox.Text & ""
        Try
            conn.Open()

            com = New OleDb.OleDbCommand(query, conn)

            com.Parameters.AddWithValue("@p1", claStreTxtBox.Text)
            com.Parameters.AddWithValue("@p2", claHeadTxtBox.Text)

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


End Class
