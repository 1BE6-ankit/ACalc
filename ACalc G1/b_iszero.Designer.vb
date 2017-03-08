<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class b_iszero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(b_iszero))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Box7 = New System.Windows.Forms.Label()
        Me.Box6 = New System.Windows.Forms.Label()
        Me.Box5 = New System.Windows.Forms.Label()
        Me.Box4 = New System.Windows.Forms.Label()
        Me.Box3 = New System.Windows.Forms.Label()
        Me.Box2 = New System.Windows.Forms.Label()
        Me.Box1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.MaximumSize = New System.Drawing.Size(533, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(240, 0, 240, 0)
        Me.Label1.Size = New System.Drawing.Size(533, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Result"
        '
        'Box7
        '
        Me.Box7.AutoSize = True
        Me.Box7.Font = New System.Drawing.Font("Trebuchet MS", 14.0!)
        Me.Box7.ForeColor = System.Drawing.Color.PaleGreen
        Me.Box7.Location = New System.Drawing.Point(12, 191)
        Me.Box7.Name = "Box7"
        Me.Box7.Size = New System.Drawing.Size(216, 24)
        Me.Box7.TabIndex = 22
        Me.Box7.Text = "Therefore, x  =  ±1.4142"
        '
        'Box6
        '
        Me.Box6.AutoSize = True
        Me.Box6.Font = New System.Drawing.Font("Consolas", 12.75!)
        Me.Box6.ForeColor = System.Drawing.Color.DarkGray
        Me.Box6.Location = New System.Drawing.Point(12, 141)
        Me.Box6.Name = "Box6"
        Me.Box6.Size = New System.Drawing.Size(207, 20)
        Me.Box6.TabIndex = 21
        Me.Box6.Text = "or, x        = ±1.4142"
        '
        'Box5
        '
        Me.Box5.AutoSize = True
        Me.Box5.Font = New System.Drawing.Font("Consolas", 12.75!)
        Me.Box5.ForeColor = System.Drawing.Color.DarkGray
        Me.Box5.Location = New System.Drawing.Point(12, 119)
        Me.Box5.Name = "Box5"
        Me.Box5.Size = New System.Drawing.Size(153, 20)
        Me.Box5.TabIndex = 20
        Me.Box5.Text = "or, x²       = 2"
        '
        'Box4
        '
        Me.Box4.AutoSize = True
        Me.Box4.Font = New System.Drawing.Font("Consolas", 12.75!)
        Me.Box4.ForeColor = System.Drawing.Color.DarkGray
        Me.Box4.Location = New System.Drawing.Point(12, 97)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(153, 20)
        Me.Box4.TabIndex = 19
        Me.Box4.Text = "or, 2x²      = 4"
        '
        'Box3
        '
        Me.Box3.AutoSize = True
        Me.Box3.Font = New System.Drawing.Font("Consolas", 12.75!)
        Me.Box3.ForeColor = System.Drawing.Color.DarkGray
        Me.Box3.Location = New System.Drawing.Point(52, 75)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(117, 20)
        Me.Box3.TabIndex = 18
        Me.Box3.Text = "2x² - 4  = 0"
        '
        'Box2
        '
        Me.Box2.AutoSize = True
        Me.Box2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box2.ForeColor = System.Drawing.Color.Green
        Me.Box2.Location = New System.Drawing.Point(12, 56)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(54, 19)
        Me.Box2.TabIndex = 17
        Me.Box2.Text = "Given,"
        '
        'Box1
        '
        Me.Box1.AutoSize = True
        Me.Box1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Box1.ForeColor = System.Drawing.Color.Gold
        Me.Box1.Location = New System.Drawing.Point(12, 28)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(73, 19)
        Me.Box1.TabIndex = 16
        Me.Box1.Text = "Solution:"
        '
        'b_iszero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(531, 318)
        Me.Controls.Add(Me.Box7)
        Me.Controls.Add(Me.Box6)
        Me.Controls.Add(Me.Box5)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(547, 357)
        Me.Name = "b_iszero"
        Me.Text = "b_iszero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Box7 As Label
    Friend WithEvents Box6 As Label
    Friend WithEvents Box5 As Label
    Friend WithEvents Box4 As Label
    Friend WithEvents Box3 As Label
    Friend WithEvents Box2 As Label
    Friend WithEvents Box1 As Label
End Class
