<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_2 = New System.Windows.Forms.RadioButton()
        Me.Button_1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_4 = New System.Windows.Forms.RadioButton()
        Me.Button_3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loading_text = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Setting_1 = New System.Windows.Forms.Label()
        Me.Setting_2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(175, 0, 172, 0)
        Me.Label1.Size = New System.Drawing.Size(429, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SETTINGS"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(430, 317)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 430
        Me.LineShape1.Y1 = 217
        Me.LineShape1.Y2 = 216
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.RosyBrown
        Me.RectangleShape2.FillColor = System.Drawing.Color.CadetBlue
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(19, 110)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(392, 60)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.RosyBrown
        Me.RectangleShape1.FillColor = System.Drawing.Color.CadetBlue
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(18, 32)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(392, 59)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CadetBlue
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Display Calculation Process?"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.Button_2)
        Me.GroupBox1.Controls.Add(Me.Button_1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(236, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 36)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Button_2
        '
        Me.Button_2.AutoSize = True
        Me.Button_2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_2.Location = New System.Drawing.Point(89, 10)
        Me.Button_2.Name = "Button_2"
        Me.Button_2.Size = New System.Drawing.Size(45, 23)
        Me.Button_2.TabIndex = 1
        Me.Button_2.Text = "No"
        Me.Button_2.UseVisualStyleBackColor = True
        '
        'Button_1
        '
        Me.Button_1.AutoSize = True
        Me.Button_1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_1.Location = New System.Drawing.Point(6, 10)
        Me.Button_1.Name = "Button_1"
        Me.Button_1.Size = New System.Drawing.Size(54, 23)
        Me.Button_1.TabIndex = 0
        Me.Button_1.Text = "Yes"
        Me.Button_1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CadetBlue
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Display Word Result in Which System?"
        '
        'Button_4
        '
        Me.Button_4.AutoSize = True
        Me.Button_4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_4.Location = New System.Drawing.Point(170, 10)
        Me.Button_4.Name = "Button_4"
        Me.Button_4.Size = New System.Drawing.Size(81, 23)
        Me.Button_4.TabIndex = 1
        Me.Button_4.Text = "Nepali"
        Me.Button_4.UseVisualStyleBackColor = True
        '
        'Button_3
        '
        Me.Button_3.AutoSize = True
        Me.Button_3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_3.Location = New System.Drawing.Point(6, 10)
        Me.Button_3.Name = "Button_3"
        Me.Button_3.Size = New System.Drawing.Size(144, 23)
        Me.Button_3.TabIndex = 0
        Me.Button_3.Text = "International"
        Me.Button_3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.Button_4)
        Me.GroupBox2.Controls.Add(Me.Button_3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(119, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 40)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightGray
        Me.Button1.Location = New System.Drawing.Point(153, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save Settings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'loading_text
        '
        Me.loading_text.AutoSize = True
        Me.loading_text.BackColor = System.Drawing.Color.Black
        Me.loading_text.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loading_text.ForeColor = System.Drawing.Color.Yellow
        Me.loading_text.Location = New System.Drawing.Point(15, 226)
        Me.loading_text.Name = "loading_text"
        Me.loading_text.Size = New System.Drawing.Size(137, 22)
        Me.loading_text.TabIndex = 7
        Me.loading_text.Text = "Current Settings:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PowderBlue
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(19, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Display Process:"
        '
        'Setting_1
        '
        Me.Setting_1.AutoSize = True
        Me.Setting_1.BackColor = System.Drawing.Color.PowderBlue
        Me.Setting_1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Setting_1.ForeColor = System.Drawing.Color.Crimson
        Me.Setting_1.Location = New System.Drawing.Point(158, 253)
        Me.Setting_1.Name = "Setting_1"
        Me.Setting_1.Size = New System.Drawing.Size(43, 23)
        Me.Setting_1.TabIndex = 9
        Me.Setting_1.Text = "Yes"
        '
        'Setting_2
        '
        Me.Setting_2.AutoSize = True
        Me.Setting_2.BackColor = System.Drawing.Color.PowderBlue
        Me.Setting_2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Setting_2.ForeColor = System.Drawing.Color.Crimson
        Me.Setting_2.Location = New System.Drawing.Point(136, 283)
        Me.Setting_2.Name = "Setting_2"
        Me.Setting_2.Size = New System.Drawing.Size(153, 23)
        Me.Setting_2.TabIndex = 11
        Me.Setting_2.Text = "International"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PowderBlue
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(19, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Word System:"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(430, 317)
        Me.Controls.Add(Me.Setting_2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Setting_1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.loading_text)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(446, 356)
        Me.Name = "settings"
        Me.Text = "SETTINGS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Button_2 As RadioButton
    Friend WithEvents Button_1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_4 As RadioButton
    Friend WithEvents Button_3 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents loading_text As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Setting_1 As Label
    Friend WithEvents Setting_2 As Label
    Friend WithEvents Label6 As Label
End Class
