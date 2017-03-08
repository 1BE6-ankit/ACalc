<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prime_Com
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prime_Com))
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
        Me.input_box = New System.Windows.Forms.TextBox()
        Me.answerbox = New System.Windows.Forms.RichTextBox()
        Me.result_box = New System.Windows.Forms.Label()
        Me.loading_text = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a Number:"
        '
        'input_box
        '
        Me.input_box.BackColor = System.Drawing.Color.DarkSlateGray
        Me.input_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input_box.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_box.ForeColor = System.Drawing.Color.White
        Me.input_box.Location = New System.Drawing.Point(202, 42)
        Me.input_box.Name = "input_box"
        Me.input_box.Size = New System.Drawing.Size(428, 23)
        Me.input_box.TabIndex = 4
        '
        'answerbox
        '
        Me.answerbox.BackColor = System.Drawing.Color.DarkCyan
        Me.answerbox.Font = New System.Drawing.Font("Comic Sans MS", 12.75!)
        Me.answerbox.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.answerbox.Location = New System.Drawing.Point(12, 94)
        Me.answerbox.Name = "answerbox"
        Me.answerbox.ReadOnly = True
        Me.answerbox.Size = New System.Drawing.Size(614, 295)
        Me.answerbox.TabIndex = 5
        Me.answerbox.Text = ""
        '
        'result_box
        '
        Me.result_box.AutoSize = True
        Me.result_box.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.result_box.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.result_box.Location = New System.Drawing.Point(264, 83)
        Me.result_box.Name = "result_box"
        Me.result_box.Size = New System.Drawing.Size(101, 22)
        Me.result_box.TabIndex = 6
        Me.result_box.Text = "Your Result:"
        '
        'loading_text
        '
        Me.loading_text.AutoSize = True
        Me.loading_text.BackColor = System.Drawing.Color.Black
        Me.loading_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loading_text.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loading_text.ForeColor = System.Drawing.Color.Yellow
        Me.loading_text.Location = New System.Drawing.Point(264, 209)
        Me.loading_text.Name = "loading_text"
        Me.loading_text.Size = New System.Drawing.Size(95, 22)
        Me.loading_text.TabIndex = 7
        Me.loading_text.Text = "LOADING..."
        '
        'Prime_Com
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(638, 408)
        Me.Controls.Add(Me.loading_text)
        Me.Controls.Add(Me.result_box)
        Me.Controls.Add(Me.answerbox)
        Me.Controls.Add(Me.input_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(654, 447)
        Me.Name = "Prime_Com"
        Me.Text = "Prime or Composite Finder"
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
    Friend WithEvents input_box As TextBox
    Friend WithEvents answerbox As RichTextBox
    Friend WithEvents result_box As Label
    Friend WithEvents loading_text As Label
End Class
