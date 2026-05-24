Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Houselist
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        user_list.Show()
        Me.Hide()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search.Show()
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
    Private Sub btnAddHouse_Click(sender As Object, e As EventArgs) Handles btnAddHouse.Click

        add_house.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub Houselist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgrdHouseList.RowTemplate.Height = 100

        If dgrdHouseList.ColumnCount = 0 Then

            dgrdHouseList.Columns.Add("id", "House ID")

            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "image"
            imgColumn.HeaderText = "Image"
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgrdHouseList.Columns.Add(imgColumn)

            dgrdHouseList.Columns.Add("home_info", "House Information")
        End If

        LoadHouseData()
    End Sub

    Private Sub LoadHouseData()
        Dim query As String = "SELECT id, image, home_info FROM house_list"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                dgrdHouseList.Rows.Clear()

                While reader.Read()
                    Dim houseID As Integer = reader("id")
                    Dim houseInfo As String = reader("home_info").ToString().Replace("\n", Environment.NewLine)

                    Dim img As Image = Nothing
                    If Not IsDBNull(reader("image")) Then
                        Dim imageData As Byte() = CType(reader("image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            img = Image.FromStream(ms)
                        End Using
                    End If

                    dgrdHouseList.Rows.Add(houseID, img, houseInfo)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgrdHouseList.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgrdHouseList.SelectedRows(0).Cells("id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this house information?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM house_list WHERE id = @id"
                Using connection As New MySqlConnection(connectionString)
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", selectedID)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Removed successfully.")

                        LoadHouseData()
                    Catch ex As Exception
                        MessageBox.Show("Error deleting House Information: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Please select a House to remove.")
        End If
    End Sub
End Class