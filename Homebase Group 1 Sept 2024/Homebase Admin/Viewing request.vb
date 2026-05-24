Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Viewing_request
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        user_list.Show()
        Me.Hide()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub btnHouselist_Click(sender As Object, e As EventArgs) Handles btnHouselist.Click
        Houselist.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewingSchedule_Click(sender As Object, e As EventArgs) Handles btnViewingSchedule.Click
        Viewing_Schedule.Show()
        Viewing_Schedule.LoadHouseData2()
        Me.Hide()
    End Sub

    Private Sub btnApprovalDeposit_Click(sender As Object, e As EventArgs) Handles btnApprovalDeposit.Click
        Deposit.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub Viewing_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdViewing.RowTemplate.Height = 100

        dgrdViewing.Columns.Add("id", "House ID")

        Dim imgColumn As New DataGridViewImageColumn()
        imgColumn.Name = "image"
        imgColumn.HeaderText = "Image"
        imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgrdViewing.Columns.Add(imgColumn)

        dgrdViewing.Columns.Add("information", " Viewing Details")

        LoadHouseData()
    End Sub
    Private Sub LoadHouseData()
        Dim query As String = "SELECT id, image, information FROM viewing WHERE approve = 0"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                dgrdViewing.Rows.Clear()

                While reader.Read()
                    Dim houseID As Integer = reader("id")
                    Dim houseInfo As String = reader("information").ToString().Replace("\n", Environment.NewLine)

                    Dim img As Image = Nothing
                    If Not IsDBNull(reader("image")) Then
                        Dim imageData As Byte() = CType(reader("image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            img = Image.FromStream(ms)
                        End Using
                    End If

                    dgrdViewing.Rows.Add(houseID, img, houseInfo)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        ApproveSelectedViewingRequest(User.SelectedUserID)
    End Sub

    Private Sub ApproveSelectedViewingRequest(userID As Integer)
        If dgrdViewing.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgrdViewing.SelectedRows(0).Cells("id").Value)

            Dim query As String = "UPDATE viewing SET approve = 1 WHERE id = @id"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", selectedID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Request approved successfully.")

                    LoadHouseData()
                Catch ex As Exception
                    MessageBox.Show("Error updating approval: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a user to approve.")
        End If
    End Sub

    Private Sub btnNotApprove_Click(sender As Object, e As EventArgs) Handles btnNotApprove.Click
        If dgrdViewing.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgrdViewing.SelectedRows(0).Cells("id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this request?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then

                Dim query As String = "DELETE FROM viewing WHERE id = @id"
                Using connection As New MySqlConnection(connectionString)
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", selectedID)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Request removed successfully.")

                        LoadHouseData()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting request: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a request to remove.")
        End If
    End Sub
End Class