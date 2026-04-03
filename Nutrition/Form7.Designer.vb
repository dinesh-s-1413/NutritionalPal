<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Label14 = New Label()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        ListBox3 = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PapayaWhip
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label1.Location = New Point(359, 264)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 25)
        Label1.TabIndex = 6
        Label1.Text = "Breakfast"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.PapayaWhip
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label2.Location = New Point(373, 411)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 25)
        Label2.TabIndex = 7
        Label2.Text = "Lunch"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.PapayaWhip
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold)
        Label3.Location = New Point(373, 542)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 25)
        Label3.TabIndex = 8
        Label3.Text = "Dinner"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Location = New Point(13, 12)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 34)
        Button1.TabIndex = 27
        Button1.Text = "<- Go Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.PapayaWhip
        Label14.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(857, 52)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(241, 24)
        Label14.TabIndex = 29
        Label14.Text = "The total remaining calories is"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 24
        ListBox1.Location = New Point(470, 249)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(399, 76)
        ListBox1.TabIndex = 30
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 24
        ListBox2.Location = New Point(473, 397)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(396, 76)
        ListBox2.TabIndex = 31
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.ItemHeight = 24
        ListBox3.Location = New Point(473, 538)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(399, 76)
        ListBox3.TabIndex = 32
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.Blue
        Button2.Location = New Point(878, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(80, 29)
        Button2.TabIndex = 34
        Button2.Text = "+ Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.ForeColor = Color.Blue
        Button3.Location = New Point(878, 411)
        Button3.Name = "Button3"
        Button3.Size = New Size(80, 29)
        Button3.TabIndex = 35
        Button3.Text = "+ Add"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.ForeColor = Color.Blue
        Button4.Location = New Point(878, 538)
        Button4.Name = "Button4"
        Button4.Size = New Size(80, 29)
        Button4.TabIndex = 36
        Button4.Text = "+ Add"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.ForeColor = Color.Red
        Button5.Location = New Point(942, 682)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 35)
        Button5.TabIndex = 37
        Button5.Text = "- Remove"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(1046, 284)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 30)
        TextBox1.TabIndex = 38
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(1046, 423)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 30)
        TextBox2.TabIndex = 39
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1046, 584)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 30)
        TextBox3.TabIndex = 40
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1115, 50)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 30)
        TextBox4.TabIndex = 41
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1560, 743)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListBox3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Label14)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox


End Class
