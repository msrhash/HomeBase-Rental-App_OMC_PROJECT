Imports MySql.Data.MySqlClient
Public Class Profile
    Dim connectionString As String = "server credentials"

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserProfile()
    End Sub

    Private Sub LoadUserProfile()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT name, user, email, tel FROM user WHERE id = @id"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", LoggedInUserID)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then

                    lblName.Text = reader("name").ToString()
                    lblUsername.Text = reader("user").ToString()
                    lblEmail.Text = reader("email").ToString()
                    lblNoTel.Text = reader("tel").ToString()


                Else
                    MessageBox.Show("User profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        LoggedInUserID = 0

        Dim loginForm As New LoginTenant()
        loginForm.Show()

        Me.Close()
    End Sub

    Private Sub pcbHomepage_Click(sender As Object, e As EventArgs) Handles pcbHomepage.Click
        Me.Hide()
        Homepage.Show()
    End Sub
End Class
