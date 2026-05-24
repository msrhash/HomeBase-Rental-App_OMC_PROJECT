
Imports MySql.Data.MySqlClient

Public Class Login
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT * FROM user WHERE user = @username AND pass = @password AND approve = 2 AND level = 0", connection)


        command.Parameters.AddWithValue("@username", txtUsername.Text)
        command.Parameters.AddWithValue("@password", txtPass.Text)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then


                Dim user As New User()
                user_list.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub
End Class