Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Viewing_Schedule
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

    Private Sub btnViewingRequest_Click(sender As Object, e As EventArgs) Handles btnViewingRequest.Click
        Viewing_request.Show()
        Me.Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.Show()
        Me.Hide()
    End Sub

    Private Sub btnApprovalDeposit_Click(sender As Object, e As EventArgs) Handles btnApprovalDeposit.Click
        Deposit.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub Viewing_Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdViewing.RowTemplate.Height = 100

        If dgrdViewing.Columns.Count = 0 Then
            dgrdViewing.Columns.Add("id", "House ID")

            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "image"
            imgColumn.HeaderText = "Image"
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgrdViewing.Columns.Add(imgColumn)

            dgrdViewing.Columns.Add("information", "Viewing Details")
        End If

        LoadHouseData2()
    End Sub

    Public Sub LoadHouseData2()
        Dim query As String = "SELECT id, image, information FROM viewing WHERE approve = 1"

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

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If dgrdViewing.SelectedRows.Count > 0 Then
            Dim selectedID As Integer = Convert.ToInt32(dgrdViewing.SelectedRows(0).Cells("id").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure this schedule is done?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM viewing WHERE id = @id"
                Using connection As New MySqlConnection(connectionString)
                    Dim command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", selectedID)

                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Request removed successfully.")

                        LoadHouseData2()
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