Imports MySql.Data.MySqlClient

Public Class PayDeposit
    Private connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Private houseId As Integer


    Public Sub New(houseId As Integer)
        InitializeComponent()
        Me.houseId = houseId
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub pcbBack_Click(sender As Object, e As EventArgs) Handles pcbBack.Click
        Me.Hide()
        HouseInfo.Show()
    End Sub

    Private Sub PayDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadHousePrice()
    End Sub
    Private Sub LoadHousePrice()
        Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT price FROM house_list WHERE id = @houseId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@houseId", houseId)

                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        lblAmount.Text = "RM " & result.ToString()
                    Else
                        MessageBox.Show("House not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading house price: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If lstPaymentMethod.SelectedIndex = 0 Then
            Me.Hide()
            UploadResit.Show()
        Else
            MessageBox.Show("This payment method is not implemented yet. It will be implemented in the future development.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pcbHomepage_Click(sender As Object, e As EventArgs) Handles pcbHomepage.Click
        Me.Hide()
        Homepage.Show()
    End Sub
End Class
