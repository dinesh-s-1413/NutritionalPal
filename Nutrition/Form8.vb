Imports Microsoft.Data.SqlClient

Public Class Form8
    ' These properties are used to pass data between Form7 and Form8
    Public Property SelectedFood As String
    Public Property Quantity As String
    Public Property Target As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex <> -1 Then
            ' Check if quantity is empty and default to 1
            If String.IsNullOrWhiteSpace(TextBox1.Text) Then
                Quantity = "1"
            Else
                Quantity = TextBox1.Text
            End If

            ' Pass the selected food item and quantity back to Form7
            SelectedFood = ListBox1.SelectedItem.ToString()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please select a food item.")
        End If
    End Sub
    Dim con As New SqlConnection("Data Source=DINESH;Initial Catalog=users;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear() ' Clear the ListBox before populating it

        Try
            con.Open()

            ' Select both Name and Calories from the Diary table
            Dim cmd As New SqlCommand("SELECT Name, Calories FROM Diary", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Combine Name and Calories to show both in ListBox
                Dim foodItem As String = reader("Name").ToString() & " - " & reader("Calories").ToString() & " kcal"
                ListBox1.Items.Add(foodItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading food items: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub UpdateTotalCalories()
        Dim totalCalories As Integer = 0

        For Each item As String In ListBox1.Items
            ' Expected format: "Idli - 150 kcal - 2 plates"
            Dim parts() As String = item.Split("-"c)

            If parts.Length >= 3 Then
                Dim caloriesPart As String = parts(1).Trim() ' "150 kcal"
                Dim quantityPart As String = parts(2).Trim() ' "2 plates"

                ' Extract number from calories
                Dim caloriesPerUnit As Integer = 0
                Dim calStr As String = New String(caloriesPart.TakeWhile(Function(c) Char.IsDigit(c)).ToArray())
                Integer.TryParse(calStr, caloriesPerUnit)

                ' Extract number from quantity
                Dim quantity As Integer = 1
                Dim qtyStr As String = New String(quantityPart.TakeWhile(Function(c) Char.IsDigit(c)).ToArray())
                Integer.TryParse(qtyStr, quantity)

                totalCalories += caloriesPerUnit * quantity
            End If
        Next

        TextBox1.Text = totalCalories.ToString() & " kcal"
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
        Me.Hide()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT Name, Calories FROM Diary WHERE Category = 'Veg'", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim foodItem As String = reader("Name").ToString() & " - " & reader("Calories").ToString() & " kcal"
                ListBox1.Items.Add(foodItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading veg items: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT Name, Calories FROM Diary WHERE Category = 'Non-Veg'", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim foodItem As String = reader("Name").ToString() & " - " & reader("Calories").ToString() & " kcal"
                ListBox1.Items.Add(foodItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading non-veg items: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SELECT Name, Calories FROM Diary WHERE Category = 'Beverage'", con)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim foodItem As String = reader("Name").ToString() & " - " & reader("Calories").ToString() & " kcal"
                ListBox1.Items.Add(foodItem)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading beverage items: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


End Class