Imports MySql.Data.MySqlClient

Public Class History
    Dim connectionString As String = "server credentials"
    Private conn As MySqlConnection = New MySqlConnection(connectionString)
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

    Private Sub btnViewingSchedule_Click(sender As Object, e As EventArgs) Handles btnViewingSchedule.Click
        Viewing_Schedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnApprovalDeposit_Click(sender As Object, e As EventArgs) Handles btnApprovalDeposit.Click
        Deposit.Show()
        Me.Hide()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdHistory.RowTemplate.Height = 100

        If dgrdHistory.ColumnCount = 0 Then
            dgrdHistory.Columns.Add("deposit_id", "ID")
            dgrdHistory.Columns.Add("history", "Issue")

            dgrdHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgrdHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            dgrdHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgrdHistory.ReadOnly = True
        End If

        LoadHistoryData()
    End Sub

    Public Sub LoadHistoryData()

        Dim query As String = "SELECT deposit_id, history FROM deposit"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim houseID As Integer = reader("deposit_id")
                    Dim history As String = reader("history").ToString().Replace("\n", Environment.NewLine)

                    dgrdHistory.Rows.Add(houseID, history)
                End While


                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
