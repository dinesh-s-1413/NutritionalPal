<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        TextBox1.Location = New Point(367, 41)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(215, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        TextBox2.Location = New Point(367, 110)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(215, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Silver
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.Location = New Point(193, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.Location = New Point(193, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SpringGreen
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button1.Location = New Point(534, 283)
        Button1.Name = "Button1"
        Button1.Size = New Size(109, 40)
        Button1.TabIndex = 6
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.Location = New Point(193, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 7
        Label3.Text = "Confirm Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        TextBox3.Location = New Point(367, 165)
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "*"c
        TextBox3.Size = New Size(215, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Info
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 9
        Button2.Text = "<-- Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.What_is_a_registration_form___Definition_free_templates_cover
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
End Class
