Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Search
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        user_list.Show()
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

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgrdUser.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        dgrdUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgrdUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgrdUser.ReadOnly = True

        Loaduser()
    End Sub

    Public Sub Loaduser(Optional searchQuery As String = "")
        Dim query As String
        If String.IsNullOrEmpty(searchQuery) Then
            query = "SELECT id, name, email, tel FROM user WHERE approve = 1"
        Else
            query = "SELECT id, name, email, tel FROM user WHERE approve = 1 AND " &
                "(name LIKE @search OR email LIKE @search OR tel LIKE @search)"
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            If Not String.IsNullOrEmpty(searchQuery) Then
                command.Parameters.AddWithValue("@search", "%" & searchQuery & "%")
            End If

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                Dim table As New DataTable()
                table.Load(reader)
                dgrdUser.DataSource = table
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchBar.Text <> "" Then
            Dim searchTerm As String = txtSearchBar.Text.Trim()

            Loaduser(searchTerm)
        Else

        End If

    End Sub
End Class