Imports MySql.Data.MySqlClient

Public Class User
    Public Property SelectedUserID As Integer

    Dim connectionString As String = "server credentials"


    Public Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set DataGridView properties
        dgrdUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgrdUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgrdUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgrdUser.ReadOnly = True

        ' Load data from the database into DataGridView
        LoadDataFromDatabase()
    End Sub

    Public Sub LoadDataFromDatabase()
        Dim query As String = "SELECT name, email, tel FROM user where approve = 0"

        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Create a DataTable to hold the data
                Dim table As New DataTable()
                table.Load(reader)

                ' Bind the DataTable to the DataGridView
                dgrdUser.DataSource = table

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message)
            End Try
        End Using
    End Sub



End Class
