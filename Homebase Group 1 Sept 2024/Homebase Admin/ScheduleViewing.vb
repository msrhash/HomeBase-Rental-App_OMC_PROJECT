Public Class ScheduleViewing
    Private houseId As Integer
    Private houseInfor As String
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
        result = MessageBox.Show("You will lose the information changed! Are you sure you want to exit?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

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
    Public Sub New(houseIdParam As Integer, houseInfoParam As String)
        InitializeComponent()
        houseId = houseIdParam
        houseInfor = houseInfoParam
    End Sub
    Private Sub btnSelectDate_Click(sender As Object, e As EventArgs) Handles btnSelectDate.Click
        Dim selectedDate As Date = MonthCalendar1.SelectionStart

        Dim timeSlotForm As New ScheduleConfirmation(houseId, houseInfor, selectedDate)

        timeSlotForm.ShowDialog()
        Me.Close()
    End Sub
End Class