<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quad_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quad_form))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menufile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fsettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mmcalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mquad = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mprime = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhcf = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mchist = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mcdelhist = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_a = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.text_c = New System.Windows.Forms.TextBox()
        Me.text_b = New System.Windows.Forms.TextBox()
        Me.dynamic_box = New System.Windows.Forms.RichTextBox()
        Me.Equate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menufile, Me.Mmcalc, Me.menuhistory, Me.menuhelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(638, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menufile
        '
        Me.menufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Fsettings, Me.Fexit})
        Me.menufile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menufile.ForeColor = System.Drawing.Color.LavenderBlush
        Me.menufile.Name = "menufile"
        Me.menufile.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.menufile.Size = New System.Drawing.Size(52, 22)
        Me.menufile.Text = "FILE"
        '
        'Fsettings
        '
        Me.Fsettings.BackColor = System.Drawing.Color.DimGray
        Me.Fsettings.Name = "Fsettings"
        Me.Fsettings.Size = New System.Drawing.Size(119, 22)
        Me.Fsettings.Text = "Settings"
        '
        'Fexit
        '
        Me.Fexit.BackColor = System.Drawing.Color.DimGray
        Me.Fexit.Name = "Fexit"
        Me.Fexit.Size = New System.Drawing.Size(119, 22)
        Me.Fexit.Text = "Exit"
        '
        'Mmcalc
        '
        Me.Mmcalc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MMain, Me.Mquad, Me.Mprime, Me.Mhcf})
        Me.Mmcalc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mmcalc.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Mmcalc.Name = "Mmcalc"
        Me.Mmcalc.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.Mmcalc.Size = New System.Drawing.Size(70, 22)
        Me.Mmcalc.Text = "MODES"
        '
        'MMain
        '
        Me.MMain.BackColor = System.Drawing.Color.DimGray
        Me.MMain.Name = "MMain"
        Me.MMain.Size = New System.Drawing.Size(209, 22)
        Me.MMain.Text = "Main Calculaotor"
        '
        'Mquad
        '
        Me.Mquad.BackColor = System.Drawing.Color.DimGray
        Me.Mquad.Name = "Mquad"
        Me.Mquad.Size = New System.Drawing.Size(209, 22)
        Me.Mquad.Text = "Quadratic Calculator"
        '
        'Mprime
        '
        Me.Mprime.BackColor = System.Drawing.Color.DimGray
        Me.Mprime.Name = "Mprime"
        Me.Mprime.Size = New System.Drawing.Size(209, 22)
        Me.Mprime.Text = "Prime Composite Finder"
        '
        'Mhcf
        '
        Me.Mhcf.BackColor = System.Drawing.Color.DimGray
        Me.Mhcf.Name = "Mhcf"
        Me.Mhcf.Size = New System.Drawing.Size(209, 22)
        Me.Mhcf.Text = "HCF and LCM Finder"
        '
        'menuhistory
        '
        Me.menuhistory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mchist, Me.Mcdelhist})
        Me.menuhistory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuhistory.ForeColor = System.Drawing.Color.LavenderBlush
        Me.menuhistory.Name = "menuhistory"
        Me.menuhistory.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.menuhistory.Size = New System.Drawing.Size(79, 22)
        Me.menuhistory.Text = "HISTORY"
        '
        'Mchist
        '
        Me.Mchist.BackColor = System.Drawing.Color.DimGray
        Me.Mchist.Name = "Mchist"
        Me.Mchist.Size = New System.Drawing.Size(210, 22)
        Me.Mchist.Text = "Calculator History"
        '
        'Mcdelhist
        '
        Me.Mcdelhist.BackColor = System.Drawing.Color.DimGray
        Me.Mcdelhist.Name = "Mcdelhist"
        Me.Mcdelhist.Size = New System.Drawing.Size(210, 22)
        Me.Mcdelhist.Text = "Delete Calculator History"
        '
        'menuhelp
        '
        Me.menuhelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuhelp.ForeColor = System.Drawing.Color.LavenderBlush
        Me.menuhelp.Name = "menuhelp"
        Me.menuhelp.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.menuhelp.Size = New System.Drawing.Size(74, 22)
        Me.menuhelp.Text = "HELP(?)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGreen
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Those  Values:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Cyan
        Me.Label2.Location = New System.Drawing.Point(182, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ax² + bx + c = 0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(182, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 19)
        Me.Label6.TabIndex = 9
        '
        'text_a
        '
        Me.text_a.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.text_a.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_a.ForeColor = System.Drawing.Color.Black
        Me.text_a.Location = New System.Drawing.Point(110, 179)
        Me.text_a.Name = "text_a"
        Me.text_a.Size = New System.Drawing.Size(144, 26)
        Me.text_a.TabIndex = 11
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(638, 373)
        Me.ShapeContainer1.TabIndex = 12
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 323
        Me.LineShape3.X2 = 323
        Me.LineShape3.Y1 = 86
        Me.LineShape3.Y2 = 199
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 263
        Me.LineShape2.X2 = 262
        Me.LineShape2.Y1 = 87
        Me.LineShape2.Y2 = 242
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 192
        Me.LineShape1.X2 = 191
        Me.LineShape1.Y1 = 86
        Me.LineShape1.Y2 = 178
        '
        'text_c
        '
        Me.text_c.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.text_c.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.text_c.Location = New System.Drawing.Point(274, 193)
        Me.text_c.Name = "text_c"
        Me.text_c.Size = New System.Drawing.Size(144, 26)
        Me.text_c.TabIndex = 13
        '
        'text_b
        '
        Me.text_b.BackColor = System.Drawing.Color.MediumTurquoise
        Me.text_b.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.text_b.ForeColor = System.Drawing.Color.Black
        Me.text_b.Location = New System.Drawing.Point(191, 239)
        Me.text_b.Name = "text_b"
        Me.text_b.Size = New System.Drawing.Size(144, 26)
        Me.text_b.TabIndex = 14
        '
        'dynamic_box
        '
        Me.dynamic_box.BackColor = System.Drawing.Color.DarkSlateGray
        Me.dynamic_box.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.dynamic_box.ForeColor = System.Drawing.Color.White
        Me.dynamic_box.Location = New System.Drawing.Point(110, 298)
        Me.dynamic_box.Name = "dynamic_box"
        Me.dynamic_box.ReadOnly = True
        Me.dynamic_box.Size = New System.Drawing.Size(308, 36)
        Me.dynamic_box.TabIndex = 15
        Me.dynamic_box.Text = ""
        '
        'Equate
        '
        Me.Equate.BackColor = System.Drawing.Color.Peru
        Me.Equate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Equate.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equate.ForeColor = System.Drawing.Color.Black
        Me.Equate.Location = New System.Drawing.Point(447, 298)
        Me.Equate.Name = "Equate"
        Me.Equate.Size = New System.Drawing.Size(127, 36)
        Me.Equate.TabIndex = 16
        Me.Equate.Text = "EQUATE"
        Me.Equate.UseVisualStyleBackColor = False
        '
        'quad_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(638, 373)
        Me.Controls.Add(Me.Equate)
        Me.Controls.Add(Me.dynamic_box)
        Me.Controls.Add(Me.text_b)
        Me.Controls.Add(Me.text_c)
        Me.Controls.Add(Me.text_a)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(654, 412)
        Me.Name = "quad_form"
        Me.Text = "quad_form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menufile As ToolStripMenuItem
    Friend WithEvents Fsettings As ToolStripMenuItem
    Friend WithEvents Fexit As ToolStripMenuItem
    Friend WithEvents Mmcalc As ToolStripMenuItem
    Friend WithEvents MMain As ToolStripMenuItem
    Friend WithEvents Mquad As ToolStripMenuItem
    Friend WithEvents Mprime As ToolStripMenuItem
    Friend WithEvents Mhcf As ToolStripMenuItem
    Friend WithEvents menuhistory As ToolStripMenuItem
    Friend WithEvents Mchist As ToolStripMenuItem
    Friend WithEvents Mcdelhist As ToolStripMenuItem
    Friend WithEvents menuhelp As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents text_a As TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents text_c As TextBox
    Friend WithEvents text_b As TextBox
    Friend WithEvents dynamic_box As RichTextBox
    Friend WithEvents Equate As Button
End Class
