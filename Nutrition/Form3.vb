Imports Microsoft.Data.SqlClient

Public Class Form3



    Private connectionString As String = "Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"


    ' Function to check if profile exists (by Email or Phone Number)
    Private Function ProfileExists(email As String) As Boolean
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM UserProfile WHERE Email = @Email "
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Email", TextBox3.Text)


                con.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                con.Close()

                Return count > 0 ' Returns True if a profile already exists
            End Using
        End Using
    End Function
    Private Function IsFormValid() As Boolean
        If TextBox1.Text.Trim() = "" Then
            MessageBox.Show("first Name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox2.Text.Trim() = "" Then
            MessageBox.Show("last name field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox3.Text.Trim() = "" Then
            MessageBox.Show("email field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox5.Text.Trim() = "" Then
            MessageBox.Show(" phone number field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox6.Text.Trim() = "" Then
            MessageBox.Show(" gender field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox7.Text.Trim() = "" Then
            MessageBox.Show(" state field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox8.Text.Trim() = "" Then
            MessageBox.Show(" city field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox9.Text.Trim() = "" Then
            MessageBox.Show(" street field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox10.Text.Trim() = "" Then
            MessageBox.Show(" pincode field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf TextBox4.Text.Trim() = "" Then
            MessageBox.Show("DOB field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        ElseIf Not IsDate(TextBox4.Text.Trim()) Then
            MessageBox.Show("Please enter a valid date (YYYY-MM-DD).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsFormValid() Then Exit Sub

        Dim firstName As String = TextBox1.Text
        Dim lastName As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim dob As Date = TextBox4.Text
        Dim phoneNumber As String = TextBox5.Text
        Dim gender As String = TextBox6.Text
        Dim state As String = TextBox7.Text
        Dim city As String = TextBox8.Text
        Dim street As String = TextBox9.Text
        Dim pincode As String = TextBox10.Text
        If ProfileExists(email) Then
            MessageBox.Show("Profile already exists!")
            Exit Sub
        End If



        Using con As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO UserProfile (FirstName, LastName, Email, DOB, PhoneNumber, Gender, State, City, Street, Pincode) VALUES (@FirstName, @LastName, @Email, @DOB, @PhoneNumber, @Gender, @State, @City, @Street, @Pincode)"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Email", TextBox3.Text)
                cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(TextBox4.Text))
                cmd.Parameters.AddWithValue("@PhoneNumber", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Gender", TextBox6.Text)
                cmd.Parameters.AddWithValue("@State", TextBox7.Text)
                cmd.Parameters.AddWithValue("@City", TextBox8.Text)
                cmd.Parameters.AddWithValue("@Street", TextBox9.Text)
                cmd.Parameters.AddWithValue("@Pincode", TextBox10.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        MessageBox.Show("profile created sucessfully")
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Form1.Show()

            ' Close All Other Forms Except Form1
            For Each frm As Form In Application.OpenForms.OfType(Of Form).ToList()
                If frm IsNot Form1 Then
                    frm.Close()
                End If
            Next

            ' Hide the current form
            Me.Hide()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Me.Hide()

    End Sub
End Class