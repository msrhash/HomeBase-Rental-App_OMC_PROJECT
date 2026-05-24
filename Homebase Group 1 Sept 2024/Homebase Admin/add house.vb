Imports MySql.Data.MySqlClient
Imports System.IO
Public Class add_house
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            user_list.Show()
            Me.Close()
        Else

        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Search.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnHouselist_Click(sender As Object, e As EventArgs) Handles btnHouselist.Click

        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Houselist.ShowDialog()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnViewingRequest_Click(sender As Object, e As EventArgs) Handles btnViewingRequest.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Viewing_request.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            History.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnViewingSchedule_Click(sender As Object, e As EventArgs) Handles btnViewingSchedule.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Viewing_Schedule.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnApprovalDeposit_Click(sender As Object, e As EventArgs) Handles btnApprovalDeposit.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Deposit.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Houselist.ShowDialog()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picHouse.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connectionString As String = "server credentials"
        Dim query As String = "INSERT INTO house_list (id, image, home_info) VALUES (@id, @image, @home_info)"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            command.Parameters.AddWithValue("@id", txtId.Text)


            Dim imageBytes As Byte()
            If picHouse.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    picHouse.Image.Save(ms, picHouse.Image.RawFormat)
                    imageBytes = ms.ToArray()
                End Using
                command.Parameters.AddWithValue("@image", imageBytes)
            Else
                command.Parameters.AddWithValue("@image", DBNull.Value)
            End If


            command.Parameters.AddWithValue("@home_info", txtHouseInfo.Text)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("House information added successfully.")

                txtHouseInfo.Clear()
                txtId.Clear()
                picHouse.Image = Nothing
            Catch ex As Exception
                MessageBox.Show("Error adding house: " & ex.Message)
            End Try
        End Using
    End Sub


End Class
