Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
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
        load_table()
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
        load_table()
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
        load_table()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

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
                ListBox1.Items.Add(sName)
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub List_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from white.edata where name='" & List.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_Eid.Text = READER.GetInt32("Eid")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_SurNm.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")

            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from white.edata where name='" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_Eid.Text = READER.GetInt32("Eid")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_SurNm.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")

            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub load_table()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "select eid as 'Employee ID',name as 'First Name',surname as 'Last Name',age as 'Age' from white.edata"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataList.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            conn.Close()
        End Try
    End Sub

    Private Sub LoadTable_Click(sender As Object, e As EventArgs) Handles LoadTable.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Try
            conn.Open
            Dim Query As String
            Query = "select eid as 'Employee ID',name as 'First Name',surname as 'Last Name',age as 'Age' from white.edata"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataList.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close
        Catch ex As Exception
            conn.Close
        End Try
    End Sub

    Private Sub DataList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataList.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataList.Rows(e.RowIndex)

            TextBox_Eid.Text = row.Cells("eid").Value.ToString
            TextBox_Name.Text = row.Cells("name").Value.ToString
            TextBox_SurNm.Text = row.Cells("surname").Value.ToString
            TextBox_Age.Text = row.Cells("age").Value.ToString
        End If
    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("name Like '%{0}%'", Search_txt.Text)
        DataList.DataSource = DV
    End Sub

    Private Sub Load_Chart_Click(sender As Object, e As EventArgs) Handles Load_Chart.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=white"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from white.edata"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Chart1.Series("Name_vs_Age").Points.AddXY(READER.GetString("name"), READER.GetInt32("age"))
            End While

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class