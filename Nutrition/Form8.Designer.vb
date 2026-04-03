<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        ListBox1 = New ListBox()
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(623, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 33)
        Button1.TabIndex = 1
        Button1.Text = "ok"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(676, 170)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(78, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.PaleTurquoise
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(657, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 4
        Label1.Text = "Qty: plate\cup"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.PaleTurquoise
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(197, 368)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 20)
        Label2.TabIndex = 5
        Label2.Text = "*The Qty for 1 plate\cup = 100 gram only"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Info
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "<- Back"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Microsoft YaHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 24
        ListBox1.Location = New Point(3, 47)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(618, 268)
        ListBox1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(ListBox1)
        Panel1.Location = New Point(27, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(624, 318)
        Panel1.TabIndex = 7
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold)
        Button5.Location = New Point(193, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(103, 50)
        Button5.TabIndex = 10
        Button5.Text = "Beverages"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold)
        Button4.Location = New Point(102, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 50)
        Button4.TabIndex = 9
        Button4.Text = "Non-veg"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold)
        Button3.Location = New Point(3, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 50)
        Button3.TabIndex = 8
        Button3.Text = "Veg"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form8"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
