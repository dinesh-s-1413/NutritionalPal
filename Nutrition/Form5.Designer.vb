<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Button2 = New Button()
        Timer1 = New Timer(components)
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(161, 167)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(449, 171)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(657, 175)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.GradientInactiveCaption
        Label2.Font = New Font("Arial Black", 10.2F, FontStyle.Bold)
        Label2.Location = New Point(606, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 24)
        Label2.TabIndex = 4
        Label2.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Black", 10.2F, FontStyle.Bold)
        Label3.Location = New Point(312, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 24)
        Label3.TabIndex = 5
        Label3.Text = "Height"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.GradientInactiveCaption
        Label4.Font = New Font("Arial Black", 10.2F, FontStyle.Bold)
        Label4.Location = New Point(27, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 24)
        Label4.TabIndex = 6
        Label4.Text = "Weight"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.GradientInactiveCaption
        Label5.Font = New Font("Arial Black", 10.2F, FontStyle.Bold)
        Label5.Location = New Point(179, 489)
        Label5.Name = "Label5"
        Label5.Size = New Size(226, 24)
        Label5.TabIndex = 7
        Label5.Text = "Total Intake of calories"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.GradientInactiveCaption
        Label6.Font = New Font("Arial Black", 10.2F, FontStyle.Bold)
        Label6.Location = New Point(179, 553)
        Label6.Name = "Label6"
        Label6.Size = New Size(218, 24)
        Label6.TabIndex = 8
        Label6.Text = "Total Intake of protein"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(427, 490)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(130, 30)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(427, 550)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(130, 30)
        TextBox5.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.GradientInactiveCaption
        Label7.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(107, 171)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 17)
        Label7.TabIndex = 11
        Label7.Text = "(in kg)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(389, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 17)
        Label8.TabIndex = 12
        Label8.Text = "(in cm)"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(509, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(142, 40)
        Button1.TabIndex = 13
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = SystemColors.GradientInactiveCaption
        RadioButton1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        RadioButton1.Location = New Point(312, 254)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(63, 26)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = SystemColors.GradientInactiveCaption
        RadioButton2.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold Or FontStyle.Italic)
        RadioButton2.Location = New Point(437, 254)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(80, 26)
        RadioButton2.TabIndex = 15
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(179, 354)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 40)
        Button2.TabIndex = 16
        Button2.Text = "clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(7, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 18
        Button4.Text = "<-- Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(799, 721)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Font = New Font("Arial", 10.2F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
End Class
