Public Class Form5



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please fill in all fields (Weight, Height, and Age).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Event handler for calculating the TDEE and Protein intake when a button is clicked

        ' Declaring variables for BMR, TDEE, and Protein Intake
        Dim weight As Double = Convert.ToDouble(TextBox1.Text)  ' Weight in kg
        Dim height As Double = Convert.ToDouble(TextBox2.Text) ' Height in cm
        Dim age As Integer = Convert.ToInt32(TextBox3.Text)    ' Age in years
        Dim gender As String = ""

        ' Check which gender is selected
        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        Else
            MessageBox.Show("Please select your gender.")
            Return

        End If

        ' Calculate BMR using Mifflin-St Jeor equation
        Dim BMR As Double
        If gender = "Male" Then
            BMR = (10 * weight) + (6.25 * height) - (5 * age) + 5
        Else
            BMR = (10 * weight) + (6.25 * height) - (5 * age) - 161
        End If

        ' Since activity level is not included, we calculate TDEE based only on BMR
        ' Assuming a standard multiplier (Moderately Active) for example, 1.55
        Dim TDEE As Double = BMR * 1.55

        ' Calculate Protein intake (for muscle maintenance: 1.6g/kg)
        Dim proteinIntake As Double = 1.6 * weight

        ' Display results in TextBox4 (for TDEE) and TextBox5 (for Protein Intake)
        ' Display results as whole numbers
        TextBox4.Text = Math.Truncate(TDEE)
        TextBox5.Text = Math.Truncate(proteinIntake)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Me.Hide()

    End Sub



    ' Method to get the value of TextBox4 from Form5
    Public Function GetCaloriesGoal() As Double
        Return Double.Parse(TextBox4.Text) ' Assuming TextBox4 contains a numeric value
    End Function

End Class