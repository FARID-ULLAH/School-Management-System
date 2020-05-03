Imports System.Text.RegularExpressions

Public Class LoginPage
    Dim connection As New OleDb.OleDbConnection
    Dim command As OleDb.OleDbCommand
    Dim datareader As OleDb.OleDbDataReader
    Dim sql As String

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source =F:\Projects\VB.Net\SMS\SMS.accdb"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'calling Login Sub Routine

        Login()
    End Sub
    'Sub Routine For Login
    Private Sub Login()
        connection.Open()

        sql = "SELECT user, pass FROM log WHERE user = '" & Trim(nameTxtBox.Text) & "' AND pass = '" & Trim(passTxtBox.Text) & "'"

        command = New OleDb.OleDbCommand(sql, connection)

        datareader = command.ExecuteReader()
        Try
            If (datareader.HasRows) = False Then

                dataLab.Text = "Invalid Account"
                nameTxtBox.Text = ""
                passTxtBox.Text = ""
                nameTxtBox.Focus()
                connection.Close()
                Exit Sub
            Else
                While (datareader.Read())

                    If (nameTxtBox.Text) = datareader(0).ToString() And (passTxtBox.Text) = datareader(1).ToString() Then
                        Dim home As New HomePage
                        home.Show()
                        Me.Hide()
                    Else
                        dataLab.Text = "Authntication Fail"
                    End If
                End While

            End If
            datareader.Close()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message())
            connection.Close()
        End Try
    End Sub


End Class