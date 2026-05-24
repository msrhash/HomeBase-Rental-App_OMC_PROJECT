Imports MySql.Data.MySqlClient

Public Class UploadResit
    Dim connectionString As String = "Server=110.4.43.110;Database=homebasegponecs;Uid=maisarah;Pwd=maisarah;"
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim receiptImage As Image = Image.FromFile(openFileDialog.FileName)

                MessageBox.Show("Receipt uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                SaveReceiptToDatabase(receiptImage)
            End If
        End Using
    End Sub

    Private Sub SaveReceiptToDatabase(receiptImage As Image)

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE house_list SET deposit_evidence = @receipt WHERE id = @houseId"
                Using command As New MySqlCommand(query, connection)

                    Dim receiptBytes() As Byte = ImageToByteArray(receiptImage)
                    command.Parameters.AddWithValue("@receipt", receiptBytes)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Failed to save receipt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception

            End Try
        End Using
    End Sub
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New System.IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
End Class