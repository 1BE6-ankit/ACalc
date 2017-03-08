<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hcf_lcm_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(hcf_lcm_form))
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.input_box = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hcf_box = New System.Windows.Forms.TextBox()
        Me.lcm_box = New System.Windows.Forms.TextBox()
        Me.loading_text = New System.Windows.Forms.Label()
        Me.factors_box = New System.Windows.Forms.RichTextBox()
        Me.clear_button = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(760, 24)
        Me.MenuStrip1.TabIndex = 3
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
        Me.menuhistory.Enabled = False
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
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(671, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter The Numbers Seperated By Comma(,) in the box below"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(690, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 49)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "??"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'input_box
        '
        Me.input_box.BackColor = System.Drawing.Color.DarkCyan
        Me.input_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input_box.Font = New System.Drawing.Font("Consolas", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_box.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.input_box.Location = New System.Drawing.Point(12, 84)
        Me.input_box.Name = "input_box"
        Me.input_box.Size = New System.Drawing.Size(736, 263)
        Me.input_box.TabIndex = 6
        Me.input_box.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(326, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Find Now!!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(235, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "HCF:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "LCM:"
        '
        'hcf_box
        '
        Me.hcf_box.BackColor = System.Drawing.Color.SteelBlue
        Me.hcf_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hcf_box.Font = New System.Drawing.Font("Trebuchet MS", 14.5!)
        Me.hcf_box.ForeColor = System.Drawing.Color.White
        Me.hcf_box.Location = New System.Drawing.Point(302, 359)
        Me.hcf_box.Name = "hcf_box"
        Me.hcf_box.ReadOnly = True
        Me.hcf_box.Size = New System.Drawing.Size(254, 23)
        Me.hcf_box.TabIndex = 10
        '
        'lcm_box
        '
        Me.lcm_box.BackColor = System.Drawing.Color.SteelBlue
        Me.lcm_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lcm_box.Font = New System.Drawing.Font("Trebuchet MS", 14.5!)
        Me.lcm_box.ForeColor = System.Drawing.Color.White
        Me.lcm_box.Location = New System.Drawing.Point(302, 388)
        Me.lcm_box.Name = "lcm_box"
        Me.lcm_box.ReadOnly = True
        Me.lcm_box.Size = New System.Drawing.Size(254, 23)
        Me.lcm_box.TabIndex = 11
        '
        'loading_text
        '
        Me.loading_text.AutoSize = True
        Me.loading_text.BackColor = System.Drawing.Color.Black
        Me.loading_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loading_text.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loading_text.ForeColor = System.Drawing.Color.Yellow
        Me.loading_text.Location = New System.Drawing.Point(338, 200)
        Me.loading_text.Name = "loading_text"
        Me.loading_text.Size = New System.Drawing.Size(95, 22)
        Me.loading_text.TabIndex = 12
        Me.loading_text.Text = "LOADING..."
        '
        'factors_box
        '
        Me.factors_box.BackColor = System.Drawing.Color.DarkSlateGray
        Me.factors_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.factors_box.Font = New System.Drawing.Font("Comic Sans MS", 12.75!)
        Me.factors_box.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.factors_box.Location = New System.Drawing.Point(12, 84)
        Me.factors_box.Name = "factors_box"
        Me.factors_box.ReadOnly = True
        Me.factors_box.Size = New System.Drawing.Size(736, 263)
        Me.factors_box.TabIndex = 13
        Me.factors_box.Text = ""
        '
        'clear_button
        '
        Me.clear_button.BackColor = System.Drawing.Color.CadetBlue
        Me.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_button.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.clear_button.ForeColor = System.Drawing.Color.Black
        Me.clear_button.Location = New System.Drawing.Point(326, 298)
        Me.clear_button.Name = "clear_button"
        Me.clear_button.Size = New System.Drawing.Size(123, 49)
        Me.clear_button.TabIndex = 14
        Me.clear_button.Text = "Clear!!"
        Me.clear_button.UseVisualStyleBackColor = False
        '
        'hcf_lcm_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(760, 419)
        Me.Controls.Add(Me.lcm_box)
        Me.Controls.Add(Me.hcf_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.loading_text)
        Me.Controls.Add(Me.input_box)
        Me.Controls.Add(Me.clear_button)
        Me.Controls.Add(Me.factors_box)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "hcf_lcm_form"
        Me.Text = "HCF & LCM FINDER"
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
    Friend WithEvents Button2 As Button
    Friend WithEvents input_box As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents hcf_box As TextBox
    Friend WithEvents lcm_box As TextBox
    Friend WithEvents loading_text As Label
    Friend WithEvents factors_box As RichTextBox
    Friend WithEvents clear_button As Button
End Class
