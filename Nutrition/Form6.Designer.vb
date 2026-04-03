<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.LightCyan
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(56, 162)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(595, 31)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.LightCyan
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(725, 162)
        ComboBox2.Margin = New Padding(4, 3, 4, 3)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(141, 31)
        ComboBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Teal
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(748, 268)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 46)
        Button1.TabIndex = 3
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.LightCyan
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(114, 351)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(610, 282)
        DataGridView1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.PaleTurquoise
        Label2.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        Label2.Location = New Point(218, 109)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(229, 21)
        Label2.TabIndex = 5
        Label2.Text = "Select your Activity level"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.PaleTurquoise
        Label3.Font = New Font("Arial", 10.8F, FontStyle.Bold)
        Label3.Location = New Point(748, 109)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 21)
        Label3.TabIndex = 6
        Label3.Text = " Age Group"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(15, 13)
        Button3.Margin = New Padding(4, 3, 4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 33)
        Button3.TabIndex = 8
        Button3.Text = "<-- Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGoldenrodYellow
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1000, 681)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form6"
        Text = "Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
