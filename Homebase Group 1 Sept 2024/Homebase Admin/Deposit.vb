Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Policy

Public Class Deposit
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
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

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgrdApprovalList.RowTemplate.Height = 100

        If dgrdApprovalList.ColumnCount = 0 Then
            dgrdApprovalList.Columns.Add("deposit_id", "Deposit ID")

            Dim imgColumn As New DataGridViewImageColumn()
            imgColumn.Name = "image"
            imgColumn.HeaderText = "Image"
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgrdApprovalList.Columns.Add(imgColumn)

            dgrdApprovalList.Columns.Add("home_info", "House Information")
            dgrdApprovalList.Columns.Add("tenant_info", "Tenant Information")

            Dim evidenceColumn As New DataGridViewImageColumn()
            evidenceColumn.Name = "deposit_evidence"
            evidenceColumn.HeaderText = "Depostit Evidence"
            evidenceColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
            dgrdApprovalList.Columns.Add(evidenceColumn)

        End If

        LoadDepositData()
    End Sub


    Public Sub LoadDepositData()
        Dim query As String = "SELECT deposit_id, image, house_info, tenant_info, deposit_evidence FROM deposit"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                dgrdApprovalList.Rows.Clear()

                While reader.Read()
                    Dim depositID As Integer = reader("deposit_id")

                    Dim img As Image = Nothing
                    If Not IsDBNull(reader("image")) Then
                        Dim imageData As Byte() = CType(reader("image"), Byte())
                        Using ms As New MemoryStream(imageData)
                            img = Image.FromStream(ms)
                        End Using
                    End If

                    Dim houseInfo As String = reader("house_info").ToString().Replace("\n", Environment.NewLine)
                    Dim tenantInfo As String = reader("tenant_info").ToString().Replace("\n", Environment.NewLine)


                    Dim deposit As Image = Nothing
                    If Not IsDBNull(reader("deposit_evidence")) Then
                        Dim evidenceData As Byte() = CType(reader("deposit_evidence"), Byte())
                        Using ms As New MemoryStream(evidenceData)
                            deposit = Image.FromStream(ms)
                        End Using
                    End If

                    dgrdApprovalList.Rows.Add(depositID, img, houseInfo, tenantInfo, deposit)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            If dgrdApprovalList.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgrdApprovalList.SelectedRows(0)

                Dim HouseID As Integer = Convert.ToInt32(selectedRow.Cells("deposit_id").Value)
                Dim houseInfo As String = selectedRow.Cells("home_info").Value.ToString().Replace("\n", Environment.NewLine)
                Dim tenantInfo As String = selectedRow.Cells("tenant_info").Value.ToString().Replace("\n", Environment.NewLine)

                Dim mainImage As Image = CType(selectedRow.Cells("image").Value, Image)
                Dim depositEvidence As Image = CType(selectedRow.Cells("deposit_evidence").Value, Image)

                Dim detailForm As New Approval()
                detailForm.mainFormReference = Me '

                detailForm.LoadDetails(houseInfo, tenantInfo, mainImage, depositEvidence, HouseID)
                detailForm.ShowDialog()
            Else
                MessageBox.Show("Please select a row to open.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class