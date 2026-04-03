
Imports Microsoft.Data.SqlClient
Public Class Form1


    Dim connectionString As String = "Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Trust Server Certificate=True"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please fill both the username and password fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the function if the fields are empty
        End If

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM users WHERE Username = @Username AND Password = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Username", TextBox1.Text)
            command.Parameters.AddWithValue("@Password", TextBox2.Text)

            Try
                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then

                    TextBox1.Clear()
                    TextBox2.Clear()
                    Form4.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        Form2.Show()
        Me.Hide()
    End Sub
End Class
