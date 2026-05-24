Public Class Chat
    Private Sub pcbSend_Click(sender As Object, e As EventArgs) Handles pcbSend.Click
        txtChatUser.Text = txtChat.Text
        txtChat.Clear()
        txtAdminChat.Text = "An agent will be with you shortly"
        txtChatUser.Visible = True
        txtAdminChat.Visible = True

    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Homepage.Show()
        Me.Hide()
    End Sub

    Private Sub pcbHomepage_Click(sender As Object, e As EventArgs) Handles pcbHomepage.Click

        Homepage.Show()
        Me.Hide()
    End Sub
End Class