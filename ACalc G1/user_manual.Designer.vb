<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_manual))
        Me.content_box = New System.Windows.Forms.RichTextBox()
        Me.topic_box = New System.Windows.Forms.Label()
        Me.previous_button = New System.Windows.Forms.Button()
        Me.next_button = New System.Windows.Forms.Button()
        Me.page_notice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'content_box
        '
        Me.content_box.BackColor = System.Drawing.Color.DarkCyan
        Me.content_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.content_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.content_box.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.content_box.Location = New System.Drawing.Point(47, 39)
        Me.content_box.Name = "content_box"
        Me.content_box.ReadOnly = True
        Me.content_box.Size = New System.Drawing.Size(569, 316)
        Me.content_box.TabIndex = 8
        Me.content_box.Text = ""
        '
        'topic_box
        '
        Me.topic_box.AutoSize = True
        Me.topic_box.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.topic_box.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topic_box.ForeColor = System.Drawing.Color.Black
        Me.topic_box.Location = New System.Drawing.Point(226, 26)
        Me.topic_box.Name = "topic_box"
        Me.topic_box.Size = New System.Drawing.Size(78, 23)
        Me.topic_box.TabIndex = 9
        Me.topic_box.Text = "TOPIC:"
        '
        'previous_button
        '
        Me.previous_button.BackColor = System.Drawing.Color.White
        Me.previous_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previous_button.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous_button.ForeColor = System.Drawing.Color.Black
        Me.previous_button.Location = New System.Drawing.Point(12, 173)
        Me.previous_button.Name = "previous_button"
        Me.previous_button.Size = New System.Drawing.Size(29, 26)
        Me.previous_button.TabIndex = 10
        Me.previous_button.Text = "<<"
        Me.previous_button.UseVisualStyleBackColor = False
        '
        'next_button
        '
        Me.next_button.BackColor = System.Drawing.Color.White
        Me.next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.next_button.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_button.ForeColor = System.Drawing.Color.Black
        Me.next_button.Location = New System.Drawing.Point(622, 173)
        Me.next_button.Name = "next_button"
        Me.next_button.Size = New System.Drawing.Size(29, 26)
        Me.next_button.TabIndex = 11
        Me.next_button.Text = ">>"
        Me.next_button.UseVisualStyleBackColor = False
        '
        'page_notice
        '
        Me.page_notice.AutoSize = True
        Me.page_notice.BackColor = System.Drawing.Color.Black
        Me.page_notice.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.page_notice.ForeColor = System.Drawing.Color.Gold
        Me.page_notice.Location = New System.Drawing.Point(257, 358)
        Me.page_notice.Name = "page_notice"
        Me.page_notice.Size = New System.Drawing.Size(143, 23)
        Me.page_notice.TabIndex = 12
        Me.page_notice.Text = "Page ** of **"
        '
        'user_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(657, 397)
        Me.Controls.Add(Me.page_notice)
        Me.Controls.Add(Me.next_button)
        Me.Controls.Add(Me.previous_button)
        Me.Controls.Add(Me.topic_box)
        Me.Controls.Add(Me.content_box)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "user_manual"
        Me.Text = "User Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents content_box As RichTextBox
    Friend WithEvents topic_box As Label
    Friend WithEvents previous_button As Button
    Friend WithEvents next_button As Button
    Friend WithEvents page_notice As Label
End Class
