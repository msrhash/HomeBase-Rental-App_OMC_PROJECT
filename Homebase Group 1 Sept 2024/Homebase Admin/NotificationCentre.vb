Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class NotificationCentre
    Private Sub pcbHomepage_Click(sender As Object, e As EventArgs) Handles pcbHomepage.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub NotificationCentre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
        Dim loadNotificationsQuery As String = "SELECT noti_id, message, created_at, is_read FROM notification WHERE user_id = @userId ORDER BY created_at DESC"
        Dim markAsReadQuery As String = "UPDATE notification SET is_read = TRUE WHERE user_id = @userId AND is_read = FALSE"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Using markCommand As New MySqlCommand(markAsReadQuery, connection)
                    markCommand.Parameters.AddWithValue("@userId", LoggedInUserID)
                    markCommand.ExecuteNonQuery()
                End Using

                Using loadCommand As New MySqlCommand(loadNotificationsQuery, connection)
                    loadCommand.Parameters.AddWithValue("@userId", LoggedInUserID)

                    Using reader As MySqlDataReader = loadCommand.ExecuteReader()
                        lstNotifications.Items.Clear()
                        While reader.Read()
                            Dim notificationItem As New ListViewItem(reader("message").ToString())
                            notificationItem.SubItems.Add(Convert.ToDateTime(reader("created_at")).ToString("g"))
                            If Not Convert.ToBoolean(reader("is_read")) Then
                                notificationItem.Font = New Font(lstNotifications.Font, FontStyle.Bold)
                            End If
                            lstNotifications.Items.Add(notificationItem)
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading notifications: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class