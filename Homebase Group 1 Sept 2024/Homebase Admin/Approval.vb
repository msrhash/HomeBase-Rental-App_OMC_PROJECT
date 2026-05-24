Imports System.IO
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Approval
    Dim connectionString As String = "server credentials"
    Public mainFormReference As Deposit

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

    Public Sub LoadDetails(houseInfo As String, tenantInfo As String, mainImage As Object, evidenceImage As Object, HouseID As Integer)
        txtHouseInfo.Text = houseInfo.Replace("\n", Environment.NewLine)
        txtTenantInfo.Text = tenantInfo.Replace("\n", Environment.NewLine)

        If mainImage IsNot Nothing Then
            pcbHouseImage.Image = mainImage
        Else
            pcbHouseImage.Image = Nothing
        End If

        If evidenceImage IsNot Nothing Then
            pcbEvidence.Image = evidenceImage
        Else
            pcbEvidence.Image = Nothing
        End If

        lblHouseID.Text = HouseID.ToString()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Try
            Dim recordId As Integer = Convert.ToInt32(lblHouseID.Text)

            DeleteRecord(recordId)

            MessageBox.Show("Record approved and deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

            If mainFormReference IsNot Nothing Then
                mainFormReference.LoadDepositData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnNotApprove_Click(sender As Object, e As EventArgs) Handles btnNotApprove.Click
        Try

            Dim recordId As Integer = Convert.ToInt32(lblHouseID.Text)

            DeleteRecord(recordId)

            MessageBox.Show("Record Deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

            If mainFormReference IsNot Nothing Then
                mainFormReference.LoadDepositData()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteRecord(id As Integer)
        Dim connection As New MySqlConnection(connectionString)
        Dim query As String = "DELETE FROM deposit WHERE deposit_id = @id"

        Try
            connection.Open()

            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", id)

            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class
