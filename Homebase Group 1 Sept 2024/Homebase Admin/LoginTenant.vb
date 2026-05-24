Imports Homebase_Admin.LoggedInUser
Imports MySql.Data.MySqlClient
Public Class LoginTenant
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Public Shared UserID As Integer
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New MySqlConnection(connectionString)
        Dim command As New MySqlCommand("SELECT * FROM user WHERE user = @username AND pass = @password AND approve = 1 AND level = 1", connection)


        command.Parameters.AddWithValue("@username", txtUsername.Text)
        command.Parameters.AddWithValue("@password", txtPass.Text)

        Try
            connection.Open()
            Dim userID As Object = command.ExecuteScalar()

            If userID IsNot Nothing Then

                LoggedInUserID = Convert.ToInt32(userID)


                Dim user As New User()
                Homepage.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class