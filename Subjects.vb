Public Class Subjects

    Dim conn As New OleDb.OleDbConnection
    Dim com As OleDb.OleDbCommand
    Dim data_adap As OleDb.OleDbDataAdapter
    Dim data_set As DataSet
    Dim data_reader As OleDb.OleDbDataReader
    Dim query As String

    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"

        load_Data()
    End Sub

    Private Sub subCloseBtn_Click(sender As Object, e As EventArgs) Handles subCloseBtn.Click
        Me.Hide()
    End Sub


    Public Sub load_Data()
        query = "SELECT subTit, Class_Name FROM sub,clas"

        Try
            conn.Open()

            data_adap = New OleDb.OleDbDataAdapter(query, conn)

            data_set = New DataSet()
            data_adap.Fill(data_set)

            DataGridView1.DataSource = data_set.Tables(0)
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            conn.Close()
        End Try

    End Sub

End Class
