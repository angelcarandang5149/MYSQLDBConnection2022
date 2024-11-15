Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"

        Try
            conn.Open()
            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from white.edata where user_name='" & TextBox_Un.Text & "' and password='" & TextBox_Pass.Text & "' "
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username and Password are correct!")
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate.")
            Else
                MessageBox.Show("Username and Password are not correct.")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class