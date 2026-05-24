Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ScheduleConfirmation
    Private houseId As Integer
    Private houseInfor As String
    Private selectedDate As Date

    Public Sub New(houseIdParam As Integer, houseInfoParam As String, selectedDateParam As Date)
        InitializeComponent()
        houseId = houseIdParam
        houseInfor = houseInfoParam
        selectedDate = selectedDateParam
    End Sub
    Private Sub pcbHomepage_Click(sender As Object, e As EventArgs) Handles pcbHomepage.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Homepage.Show()
            Me.Close()
        Else
            ' Do nothing if No ehehe
        End If
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            ' Do nothing if No ehehe
        End If

    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Homepage.Show()
            Me.Close()
        Else
            ' Do nothing if No ehehe
        End If
    End Sub

    Private Sub ScheduleConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = selectedDate.ToShortDateString()
    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        If cboTimeSlot.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a time slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected time slot
        Dim selectedTime As String = cboTimeSlot.SelectedItem.ToString()

        ' Retrieve the image from the PictureBox in the house_info form
        Dim houseImage As Byte() = Nothing
        If HouseInfo.pcbHouse.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                HouseInfo.pcbHouse.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                houseImage = ms.ToArray()
            End Using
        End If

        ' Save the data into the database
        Using connection As New MySqlConnection("server credentials")
            Dim query As String = "INSERT INTO viewing (id, information, approve, image) VALUES (@houseId, @information, @approve, @image)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@houseId", houseId)
            command.Parameters.AddWithValue("@information", houseInfor & selectedTime)
            command.Parameters.AddWithValue("@approve", "0")
            command.Parameters.AddWithValue("@image", houseImage)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Viewing request submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error submitting request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnBack2_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        Dim result As DialogResult
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then

            Homepage.Show()
            Me.Close()
        Else
            ' Do nothing if No ehehe
        End If
    End Sub
End Class
