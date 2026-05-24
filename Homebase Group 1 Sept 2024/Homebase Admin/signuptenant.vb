Imports MySql.Data.MySqlClient

Public Class signuptenant
    Dim connectionString As String = "server credentials"
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        If String.IsNullOrWhiteSpace(txtName.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtPass.Text) OrElse
           String.IsNullOrWhiteSpace(txtRePass.Text) OrElse
           String.IsNullOrWhiteSpace(txtNoTel.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtPass.Text <> txtRePass.Text Then
            MessageBox.Show("Please Re-Enter the same Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM user WHERE email = @checkEmail OR user = @checkUsername"
                Using checkCommand As New MySqlCommand(checkQuery, connection)
                    checkCommand.Parameters.AddWithValue("@checkEmail", txtEmail.Text)
                    checkCommand.Parameters.AddWithValue("@checkUsername", txtUsername.Text)

                    Dim existingCount As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                    If existingCount > 0 Then
                        MessageBox.Show("Email or Username already exists. Please choose another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If
                End Using


                Dim query As String = "INSERT INTO user ( name, email, `user`, pass, tel, level, approve) VALUES ( @name, @email, @username, @password, @tel, @level, @approve)"
                Using command As New MySqlCommand(query, connection)

                    command.Parameters.AddWithValue("@name", txtName.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@username", txtUsername.Text)
                    command.Parameters.AddWithValue("@password", txtPass.Text)
                    command.Parameters.AddWithValue("@tel", txtNoTel.Text)
                    command.Parameters.AddWithValue("@level", "1")
                    command.Parameters.AddWithValue("@approve", "0")

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Please wait for 3-4 business days for you to be approved by an admin", "Pending", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        txtName.Clear()
                        txtEmail.Clear()
                        txtUsername.Clear()
                        txtPass.Clear()
                        txtRePass.Clear()
                        txtNoTel.Clear()
                    Else
                        MessageBox.Show("Sign-Up Failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

End Class
