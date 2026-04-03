Imports Microsoft.Data.SqlClient

Public Class Form4

    Dim connectionString As String = "Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Trust Server Certificate=True"

    ' When user types in TextBox1, show suggestions in ListBox1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ShowSuggestions(TextBox1.Text.Trim())
        Dim searchText As String = TextBox1.Text.Trim()
        ShowSuggestions(searchText)



    End Sub

    ' Fetch matching names and display in ListBox1
    Private Sub ShowSuggestions(searchQuery As String)
        ListBox1.Items.Clear() ' Clear previous suggestions

        If String.IsNullOrWhiteSpace(searchQuery) Then
            ListBox1.Visible = False ' Hide list when empty
            Exit Sub
        End If

        Dim query As String = "SELECT Name FROM Grains WHERE LOWER(Name) LIKE LOWER(@search)"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%") ' Match anywhere in the name

                Try
                    conn.Open()
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        ListBox1.Items.Add(reader("Name").ToString()) ' Add matching names
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        ListBox1.Visible = ListBox1.Items.Count > 0 ' Show only if there are matches
    End Sub

    ' When user clicks a name in ListBox1, show details in DataGridView1
    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedIndex <> -1 Then
            TextBox1.Text = ListBox1.SelectedItem.ToString()
            ListBox1.Visible = False ' Hide ListBox after selection
            ShowGrainDetails(TextBox1.Text) ' Show full details in DataGridView1
        End If
    End Sub


    ' Fetch and display full details of the selected grain in vertical format
    Private Sub ShowGrainDetails(grainName As String)
        Dim query As String = "SELECT * FROM Grains WHERE Name = @name"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", grainName)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)

                    ' If no record found, clear the table
                    If table.Rows.Count = 0 Then
                        DataGridView1.DataSource = Nothing
                        Exit Sub
                    End If

                    ' Convert table to vertical format
                    Dim transposedTable As New DataTable()
                    transposedTable.Columns.Add("    ") ' Column for field names
                    transposedTable.Columns.Add("     ") ' Column for values

                    For Each col As DataColumn In table.Columns
                        transposedTable.Rows.Add(col.ColumnName, table.Rows(0)(col)) ' Only first row's data
                    Next

                    DataGridView1.DataSource = transposedTable ' Show transposed table in DataGridView1

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' Hide ListBox when TextBox loses focus
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        Timer1.Start() ' Small delay before hiding
    End Sub

    ' Allow clicking in ListBox before hiding
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not ListBox1.Focused Then
            ListBox1.Visible = False
        End If
        Timer1.Stop()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()


    End Sub

    Private Sub Form4_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Not ListBox1.Focused AndAlso Not TextBox1.Focused Then
            ListBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchText As String = TextBox1.Text.Trim()

        ' Show details only if the search text is not empty
        If Not String.IsNullOrWhiteSpace(searchText) Then
            ShowGrainDetails(searchText)
        Else
            MessageBox.Show("Please enter a grain name to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class


