<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hcf_lcm_help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hcf_lcm_help))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.content_box = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Note For End Users"
        '
        'content_box
        '
        Me.content_box.BackColor = System.Drawing.Color.DarkCyan
        Me.content_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.content_box.Font = New System.Drawing.Font("Comic Sans MS", 12.75!)
        Me.content_box.ForeColor = System.Drawing.Color.Black
        Me.content_box.Location = New System.Drawing.Point(12, 35)
        Me.content_box.Name = "content_box"
        Me.content_box.ReadOnly = True
        Me.content_box.Size = New System.Drawing.Size(533, 263)
        Me.content_box.TabIndex = 7
        Me.content_box.Text = ""
        '
        'hcf_lcm_help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(557, 317)
        Me.Controls.Add(Me.content_box)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "hcf_lcm_help"
        Me.Text = "About HCF & LCM Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents content_box As RichTextBox
End Class
