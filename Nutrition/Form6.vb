Imports Microsoft.Data.SqlClient

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add Activity Levels (With Descriptions for Display)
        ComboBox1.Items.Add("Sedentary - Minimal activity | Ex: Desk job, Student")
        ComboBox1.Items.Add("Lightly Active - Light movement | Ex: Teacher, Shopkeeper")
        ComboBox1.Items.Add("Moderately Active - Regular workouts | Ex: Gym-goer, Delivery Person")
        ComboBox1.Items.Add("Very Active - Intense exercise | Ex: Athlete, Construction Worker")
        ComboBox1.Items.Add("Extra Active - Heavy training | Ex: Professional Athlete, Soldier")

        ' Add Age Groups
        ComboBox2.Items.Add("18-25")
        ComboBox2.Items.Add("26-35")
        ComboBox2.Items.Add("36-45")
        ComboBox2.Items.Add("46-60")
    End Sub

    ' Function to extract only the activity level name (before "-")
    Private Function GetSelectedActivityLevel() As String
        If ComboBox1.SelectedIndex <> -1 Then
            Dim selectedText As String = ComboBox1.SelectedItem.ToString()
            Return selectedText.Split("-"c)(0).Trim() ' Extracts only "Sedentary", "Lightly Active", etc.
        End If
        Return ""
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear any previous results in the DataGridView
        DataGridView1.Rows.Clear()

        ' Validate if both ComboBox selections are made
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select both Activity Level and Age Group.")
            Exit Sub
        End If

        ' Extract clean values for query
        Dim activityLevel As String = GetSelectedActivityLevel() ' Extracted activity level name only
        Dim ageGroup As String = ComboBox2.SelectedItem.ToString()

        ' Database connection string (Replace with your actual database credentials)
        Dim connectionString As String = "Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Trust Server Certificate=True"
        Dim query As String = "SELECT MealType, MealRecommendation FROM MealRecommendations " &
                              "WHERE ActivityLevel = @ActivityLevel AND AgeGroup = @AgeGroup"

        ' Create a connection to the database
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Create a SQL Command
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@ActivityLevel", activityLevel)
                    command.Parameters.AddWithValue("@AgeGroup", ageGroup)

                    ' Execute the query and get the results
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' Ensure columns are defined only once
                            If DataGridView1.Columns.Count = 0 Then
                                DataGridView1.Columns.Add("MealType", "Meal Type")
                                DataGridView1.Columns.Add("MealRecommendation", "Meal Recommendation")
                            End If

                            ' Loop through results and add them to DataGridView
                            While reader.Read()
                                DataGridView1.Rows.Add(reader("MealType").ToString(), reader("MealRecommendation").ToString())
                            End While

                            ' Adjust DataGridView display settings
                            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
                            DataGridView1.Columns("MealRecommendation").Width = 400
                            DataGridView1.Columns("MealRecommendation").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        Else
                            MessageBox.Show("No meals found for the selected Activity Level and Age Group.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace)
            End Try
        End Using
    End Sub

    ' Navigation buttons
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    ' Event handler for ComboBox1 selection (if needed for additional actions)
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
End Class
