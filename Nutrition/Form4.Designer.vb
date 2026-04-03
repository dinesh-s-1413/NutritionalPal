<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        TextBox1 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        ListBox1 = New ListBox()
        Timer1 = New Timer(components)
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(691, 221)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(385, 27)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1084, 221)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 35)
        Button1.TabIndex = 1
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Linen
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.GradientActiveCaption
        DataGridView1.Location = New Point(699, 459)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(377, 249)
        DataGridView1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(750, 435)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 20)
        Label1.TabIndex = 3
        Label1.Text = "#The below result is only for per 100 gram "
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 21
        ListBox1.Location = New Point(691, 240)
        ListBox1.Margin = New Padding(4)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(385, 46)
        ListBox1.TabIndex = 4
        ' 
        ' Timer1
        ' 
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(403, 850)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(203, 60)
        Button2.TabIndex = 5
        Button2.Text = " Daily Intake"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(142, 33)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 24)
        Label2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(763, 17)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(266, 43)
        Label3.TabIndex = 7
        Label3.Text = "NutritionPal"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.Location = New Point(763, 850)
        Button3.Name = "Button3"
        Button3.Size = New Size(208, 60)
        Button3.TabIndex = 8
        Button3.Text = "Personalized Meal"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ButtonShadow
        Button4.Location = New Point(12, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(123, 45)
        Button4.TabIndex = 9
        Button4.Text = "View Profile"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Silver
        Button5.Location = New Point(1133, 850)
        Button5.Name = "Button5"
        Button5.Size = New Size(208, 60)
        Button5.TabIndex = 10
        Button5.Text = "Food Diary"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1816, 1055)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
