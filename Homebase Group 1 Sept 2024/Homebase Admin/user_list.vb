Imports MySql.Data.MySqlClient

Public Class user_list
    Dim connectionString As String = "server credentials"
    Private conn As MySqlConnection = New MySqlConnection(connectionString)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search.Show()
        Search.Loaduser()
        Me.Hide()
    End Sub

    Private Sub btnHouselist_Click(sender As Object, e As EventArgs) Handles btnHouselist.Click
        Houselist.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewingRequest_Click(sender As Object, e As EventArgs) Handles btnViewingRequest.Click
        Viewing_request.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewingSchedule_Click(sender As Object, e As EventArgs) Handles btnViewingSchedule.Click
        Viewing_Schedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnApprovalDeposit_Click(sender As Object, e As EventArgs) Handles btnApprovalDeposit.Click

        Deposit.Show()
        Me.Hide()
    End Sub

    Private Sub user_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgrdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgrdUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgrdUser.ReadOnly = True

        LoadDataFromDatabase()
    End Sub

    Public Sub LoadDataFromDatabase()
        Dim query As String = "SELECT id, name, email, tel FROM user where approve = 0"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                Dim table As New DataTable()
                table.Load(reader)

                dgrdUser.DataSource = table

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        ApproveSelectedUser(User.SelectedUserID)
    End Sub

    Private Sub ApproveSelectedUser(userID As Integer)
        If dgrdUser.SelectedRows.Count > 0 Then

            Dim selectedID As Integer = Convert.ToInt32(dgrdUser.SelectedRows(0).Cells("id").Value)

            Dim query As String = "UPDATE user SET approve = 1 WHERE id = @id"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", selectedID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("User approved successfully.")

                    ' Refresh DataGridView to remove approved item
                    LoadDataFromDatabase()
                Catch ex As Exception
                    MessageBox.Show("Error updating approval: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a user to approve.")
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnNotApprove_Click(sender As Object, e As EventArgs) Handles btnNotApprove.Click
        If dgrdUser.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgrdUser.SelectedRows(0).Cells("id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM user WHERE id = @id"
                Using connection As New MySqlConnection(connectionString)
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", selectedID)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("User removed successfully.")

                        LoadDataFromDatabase()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting user: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a user to remove.")
        End If
    End Sub
End Class
