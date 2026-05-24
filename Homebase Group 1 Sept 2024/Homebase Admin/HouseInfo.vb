Public Class HouseInfo

    Dim connectionString As String = "server credentials"
    Public mainFormReference As Homepage
    Private houseId As Integer
    Private houseInfor As String
    Public Sub LoadHouseInfo(houseID As String, houseInfo As String, housedesc As String, mainImage As Object)

        txtHouseID.Text = houseID
        txtHouseDescription.Text = houseInfo.Replace("\n", Environment.NewLine)

        If mainImage IsNot Nothing Then
            pcbHouse.Image = mainImage
        Else
            pcbHouse.Image = Nothing
        End If

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click

        Dim calendarForm As New ScheduleViewing(houseId, HouseInfor)
        calendarForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim houseId As Integer = Convert.ToInt32(txtHouseID.Text)

        Dim paymentForm As New PayDeposit(houseId)

        paymentForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnChat_Click(sender As Object, e As EventArgs) Handles btnChat.Click

        Chat.Show()
        Me.Hide()
    End Sub

    Private Sub pcbHome_Click(sender As Object, e As EventArgs) Handles pcbHome.Click

        Homepage.Show()
        Me.Hide()
    End Sub
End Class
