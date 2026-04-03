Imports Microsoft.Data.SqlClient

Public Class Form7
    Public TargetListBox As ListBox

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateRemainingCalories()
    End Sub

    ' Add to Breakfast
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm8 As New Form8()
        frm8.Target = "Breakfast"
        If frm8.ShowDialog() = DialogResult.OK Then
            ListBox1.Items.Add(frm8.SelectedFood & " - plate/cup: " & frm8.Quantity)
            UpdateTotalCalories(ListBox1, TextBox1)
            UpdateRemainingCalories()
        End If
    End Sub

    ' Add to Lunch
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm8 As New Form8()
        frm8.Target = "Lunch"
        If frm8.ShowDialog() = DialogResult.OK Then
            ListBox2.Items.Add(frm8.SelectedFood & " - plate/cup: " & frm8.Quantity)
            UpdateTotalCalories(ListBox2, TextBox2)
            UpdateRemainingCalories()
        End If
    End Sub

    ' Add to Dinner
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm8 As New Form8()
        frm8.Target = "Dinner"
        If frm8.ShowDialog() = DialogResult.OK Then
            ListBox3.Items.Add(frm8.SelectedFood & " - plate/cup: " & frm8.Quantity)
            UpdateTotalCalories(ListBox3, TextBox3)
            UpdateRemainingCalories()
        End If
    End Sub

    ' Navigation Back
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    ' Delete selected item
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ListBox1.SelectedIndex <> -1 Then
            DeleteSelectedItem(ListBox1, TextBox1)
        ElseIf ListBox2.SelectedIndex <> -1 Then
            DeleteSelectedItem(ListBox2, TextBox2)
        ElseIf ListBox3.SelectedIndex <> -1 Then
            DeleteSelectedItem(ListBox3, TextBox3)
        Else
            MessageBox.Show("Please select an item to delete.")
        End If
        UpdateRemainingCalories()
    End Sub

    ' Delete item and update
    Private Sub DeleteSelectedItem(listBox As ListBox, textBox As TextBox)
        If listBox.SelectedIndex <> -1 Then
            listBox.Items.RemoveAt(listBox.SelectedIndex)
            UpdateTotalCalories(listBox, textBox)
        End If
    End Sub

    ' Total calorie calculation for ListBox
    Private Sub UpdateTotalCalories(listBox As ListBox, textBox As TextBox)
        Dim totalCalories As Integer = 0

        For Each item As String In listBox.Items
            Dim parts() As String = item.Split("-"c)

            If parts.Length >= 3 Then
                Dim caloriesPart As String = parts(1).Trim() ' "150 kcal"
                Dim quantityPart As String = parts(2).Trim() ' "plate/cup: 2"

                Dim caloriesPerUnit As Integer = 0
                Integer.TryParse(New String(caloriesPart.Where(Function(c) Char.IsDigit(c)).ToArray()), caloriesPerUnit)

                Dim quantity As Integer = 1
                Integer.TryParse(New String(quantityPart.Where(Function(c) Char.IsDigit(c)).ToArray()), quantity)

                totalCalories += caloriesPerUnit * quantity
            End If
        Next

        textBox.Text = totalCalories.ToString() & " kcal"
    End Sub

    ' Update remaining calories
    Private Sub UpdateRemainingCalories()
        Dim breakfastCalories As Integer = 0
        Dim lunchCalories As Integer = 0
        Dim dinnerCalories As Integer = 0

        Integer.TryParse(TextBox1.Text.Replace(" kcal", ""), breakfastCalories)
        Integer.TryParse(TextBox2.Text.Replace(" kcal", ""), lunchCalories)
        Integer.TryParse(TextBox3.Text.Replace(" kcal", ""), dinnerCalories)

        Dim totalCalories = breakfastCalories + lunchCalories + dinnerCalories

        Dim goalCalories As Integer = 0
        If Integer.TryParse(Form5.TextBox4.Text, goalCalories) Then
            Dim remaining = goalCalories - totalCalories
            TextBox4.Text = remaining.ToString() & " kcal"
        Else
            TextBox4.Text = "0 kcal"
        End If
    End Sub

End Class
