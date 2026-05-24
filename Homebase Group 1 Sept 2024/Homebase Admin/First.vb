Public Class First

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Width += 3
        If Panel1.Width >= 223 Then
            Timer1.Stop()
            Admin.Show()
            Me.Hide()
        End If

    End Sub
End Class
