<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(history))
        Me.display_box = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'display_box
        '
        Me.display_box.BackColor = System.Drawing.Color.DarkSlateGray
        Me.display_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.display_box.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display_box.ForeColor = System.Drawing.Color.Orange
        Me.display_box.Location = New System.Drawing.Point(12, 37)
        Me.display_box.Name = "display_box"
        Me.display_box.Size = New System.Drawing.Size(666, 316)
        Me.display_box.TabIndex = 7
        Me.display_box.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "History:"
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(691, 365)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.display_box)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(707, 404)
        Me.Name = "history"
        Me.Text = "history"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents display_box As RichTextBox
    Friend WithEvents Label1 As Label
End Class
