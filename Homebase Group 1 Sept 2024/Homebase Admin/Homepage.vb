Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Homepage
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Private Sub pcbExit_Click(sender As Object, e As EventArgs) Handles pcbExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbChat_Click(sender As Object, e As EventArgs) Handles pcbChat.Click
        Chat.Show()
        Me.Hide()
    End Sub

    Private Sub pcbNotification_Click(sender As Object, e As EventArgs) Handles pcbNotification.Click
        NotificationCentre.Show()
        Me.Hide()
    End Sub

    Private Sub pcbProfile_Click(sender As Object, e As EventArgs) Handles pcbProfile.Click
        Profile.Show()
        Me.Hide()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdHouseList.RowTemplate.Height = 100

        If dgrdHouseList.ColumnCount = 0 Then

            dgrdHouseList.Columns.Add("id", "House ID")

            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "image"
            imgColumn.HeaderText = "Image"
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgrdHouseList.Columns.Add(imgColumn)

            dgrdHouseList.Columns.Add("home_info", "House Information")
            dgrdHouseList.Columns.Add("description", "Description")
        End If


        LoadHouseData()
    End Sub

    Private Sub LoadHouseData(Optional searchQuery As String = "")
        Dim query As String

        If String.IsNullOrEmpty(searchQuery) Then
            query = "SELECT id, image, home_info, description FROM house_list"
        Else
            query = "SELECT id, image, home_info, description FROM house_list " &
                "WHERE home_info LIKE @search OR description LIKE @search"
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            If Not String.IsNullOrEmpty(searchQuery) Then
                command.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
            End If

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                dgrdHouseList.Rows.Clear()

                While reader.Read()
                    Dim houseID As String = reader("id")
                    Dim houseInfo As String = reader("home_info").ToString().Replace("\n", Environment.NewLine)
                    Dim housedesc As String = reader("description").ToString().Replace("\n", Environment.NewLine)

                    Dim img As Image = Nothing
                    If Not IsDBNull(reader("image")) Then
                        Dim imageData As Byte() = CType(reader("image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            img = Image.FromStream(ms)
                        End Using
                    End If

                    dgrdHouseList.Rows.Add(houseID, img, houseInfo, housedesc)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub dgrdHouseList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgrdHouseList.CellContentDoubleClick
        Try

            If dgrdHouseList.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgrdHouseList.SelectedRows(0)


                Dim houseID As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
                Dim houseInfo As String = selectedRow.Cells("home_info").Value.ToString().Replace("\n", Environment.NewLine)
                Dim housedesc As String = selectedRow.Cells("description").Value.ToString().Replace("\n", Environment.NewLine)

                Dim mainImage As Image = CType(selectedRow.Cells("image").Value, Image)



                Dim detailForm As New HouseInfo()

                detailForm.mainFormReference = Me
                detailForm.LoadHouseInfo(houseID, houseInfo, housedesc, mainImage)
                detailForm.ShowDialog()
                Me.Hide()
            Else
                MessageBox.Show("Please select a row to open.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim searchTerm As String = txtSearchBar.Text.Trim()

        LoadHouseData(searchTerm)
    End Sub
End Class