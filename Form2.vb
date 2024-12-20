Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOut.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "insert into white.edata (eid,name,surname,age) values ('" & TextBox_Eid.Text & "','" & TextBox_Name.Text & "','" & TextBox_SurNm.Text & "','" & TextBox_Age.Text & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "update white.edata set eid='" & TextBox_Eid.Text & "',name='" & TextBox_Name.Text & "',surname='" & TextBox_SurNm.Text & "',age='" & TextBox_Age.Text & "' where eid='" & TextBox_Eid.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Updated")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "delete from white.edata where eid='" & TextBox_Eid.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Deleted")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = $"select * from white.edata"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("Name")
                List.Items.Add(sName)
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged

    End Sub
End Class