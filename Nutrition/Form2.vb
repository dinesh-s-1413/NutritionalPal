
Imports Azure.Identity
Imports Microsoft.Data.SqlClient
Public Class Form2
    Dim connectionString As String = "Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any of the textboxes are empty
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Or String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return ' Exit the subroutine without doing anything
        End If

        ' Proceed with database insert if fields are filled
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO users (Username, Password) VALUES (@Username, @Password)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", TextBox1.Text)
            command.Parameters.AddWithValue("@Password", TextBox2.Text)

            Try
                connection.Open()
                command.ExecuteNonQuery()

                ' Check if the passwords match
                If TextBox3.Text <> TextBox2.Text Then
                    MessageBox.Show("Passwords do not match. Please try again.")
                    Return ' Stop execution if passwords do not match
                End If

                MessageBox.Show("User registered successfully!")

                Form1.Show()
                Me.Close()

            Catch ex As SqlException When ex.Number = 2627
                MessageBox.Show("Username already registered!")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class
