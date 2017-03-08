<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class acalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(acalc))
        Me.menufile = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fsettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Mmcalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mquad = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mprime = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mhcf = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mchist = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mcdelhist = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputbox = New System.Windows.Forms.TextBox()
        Me.answerbox = New System.Windows.Forms.TextBox()
        Me.answerboxword = New System.Windows.Forms.TextBox()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.BLb = New System.Windows.Forms.Button()
        Me.Bkar = New System.Windows.Forms.Button()
        Me.Bmul1 = New System.Windows.Forms.Button()
        Me.BRb = New System.Windows.Forms.Button()
        Me.Bmul2 = New System.Windows.Forms.Button()
        Me.BDiv = New System.Windows.Forms.Button()
        Me.B0 = New System.Windows.Forms.Button()
        Me.Bdot = New System.Windows.Forms.Button()
        Me.BMinus = New System.Windows.Forms.Button()
        Me.BAdd = New System.Windows.Forms.Button()
        Me.BAc = New System.Windows.Forms.Button()
        Me.BPer = New System.Windows.Forms.Button()
        Me.BEnter = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menufile, Me.Mmcalc, Me.menuhistory, Me.menuhelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 1, 1, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(646, 402)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.ForestGreen
        Me.RectangleShape1.BorderWidth = 20
        Me.RectangleShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Silver
        Me.RectangleShape1.Location = New System.Drawing.Point(23, 47)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(601, 303)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(286, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ACalc G1"
        '
        'inputbox
        '
        Me.inputbox.AcceptsReturn = True
        Me.inputbox.BackColor = System.Drawing.Color.Black
        Me.inputbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputbox.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputbox.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.inputbox.Location = New System.Drawing.Point(52, 67)
        Me.inputbox.MaxLength = 32767000
        Me.inputbox.Name = "inputbox"
        Me.inputbox.Size = New System.Drawing.Size(540, 25)
        Me.inputbox.TabIndex = 4
        '
        'answerbox
        '
        Me.answerbox.BackColor = System.Drawing.Color.Black
        Me.answerbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerbox.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.answerbox.Location = New System.Drawing.Point(52, 90)
        Me.answerbox.MaxLength = 32767000
        Me.answerbox.Name = "answerbox"
        Me.answerbox.ReadOnly = True
        Me.answerbox.Size = New System.Drawing.Size(540, 27)
        Me.answerbox.TabIndex = 37
        '
        'answerboxword
        '
        Me.answerboxword.BackColor = System.Drawing.Color.Black
        Me.answerboxword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.answerboxword.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!)
        Me.answerboxword.ForeColor = System.Drawing.Color.Yellow
        Me.answerboxword.Location = New System.Drawing.Point(52, 115)
        Me.answerboxword.MaxLength = 32767000
        Me.answerboxword.Multiline = True
        Me.answerboxword.Name = "answerboxword"
        Me.answerboxword.ReadOnly = True
        Me.answerboxword.Size = New System.Drawing.Size(540, 52)
        Me.answerboxword.TabIndex = 38
        '
        'B7
        '
        Me.B7.BackColor = System.Drawing.Color.SaddleBrown
        Me.B7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B7.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B7.ForeColor = System.Drawing.Color.LightCyan
        Me.B7.Location = New System.Drawing.Point(75, 173)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(65, 34)
        Me.B7.TabIndex = 6
        Me.B7.Text = "7"
        Me.B7.UseVisualStyleBackColor = False
        '
        'B8
        '
        Me.B8.BackColor = System.Drawing.Color.SaddleBrown
        Me.B8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B8.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B8.ForeColor = System.Drawing.Color.LightCyan
        Me.B8.Location = New System.Drawing.Point(155, 173)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(65, 34)
        Me.B8.TabIndex = 39
        Me.B8.Text = "8"
        Me.B8.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.SaddleBrown
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B2.ForeColor = System.Drawing.Color.LightCyan
        Me.B2.Location = New System.Drawing.Point(155, 253)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(65, 34)
        Me.B2.TabIndex = 41
        Me.B2.Text = "2"
        Me.B2.UseVisualStyleBackColor = False
        '
        'B5
        '
        Me.B5.BackColor = System.Drawing.Color.SaddleBrown
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B5.ForeColor = System.Drawing.Color.LightCyan
        Me.B5.Location = New System.Drawing.Point(155, 213)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(65, 34)
        Me.B5.TabIndex = 42
        Me.B5.Text = "5"
        Me.B5.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.SaddleBrown
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B1.ForeColor = System.Drawing.Color.LightCyan
        Me.B1.Location = New System.Drawing.Point(75, 253)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(65, 34)
        Me.B1.TabIndex = 43
        Me.B1.Text = "1"
        Me.B1.UseVisualStyleBackColor = False
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.Color.SaddleBrown
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B4.ForeColor = System.Drawing.Color.LightCyan
        Me.B4.Location = New System.Drawing.Point(75, 213)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(65, 34)
        Me.B4.TabIndex = 44
        Me.B4.Text = "4"
        Me.B4.UseVisualStyleBackColor = False
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.Color.SaddleBrown
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B6.ForeColor = System.Drawing.Color.LightCyan
        Me.B6.Location = New System.Drawing.Point(235, 213)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(65, 34)
        Me.B6.TabIndex = 50
        Me.B6.Text = "6"
        Me.B6.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.SaddleBrown
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B3.ForeColor = System.Drawing.Color.LightCyan
        Me.B3.Location = New System.Drawing.Point(235, 253)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(65, 34)
        Me.B3.TabIndex = 49
        Me.B3.Text = "3"
        Me.B3.UseVisualStyleBackColor = False
        '
        'B9
        '
        Me.B9.BackColor = System.Drawing.Color.SaddleBrown
        Me.B9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B9.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B9.ForeColor = System.Drawing.Color.LightCyan
        Me.B9.Location = New System.Drawing.Point(235, 173)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(65, 34)
        Me.B9.TabIndex = 45
        Me.B9.Text = "9"
        Me.B9.UseVisualStyleBackColor = False
        '
        'BLb
        '
        Me.BLb.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BLb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BLb.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BLb.ForeColor = System.Drawing.Color.LightCyan
        Me.BLb.Location = New System.Drawing.Point(315, 173)
        Me.BLb.Name = "BLb"
        Me.BLb.Size = New System.Drawing.Size(65, 34)
        Me.BLb.TabIndex = 51
        Me.BLb.Text = "("
        Me.BLb.UseVisualStyleBackColor = False
        '
        'Bkar
        '
        Me.Bkar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Bkar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bkar.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Bkar.ForeColor = System.Drawing.Color.LightCyan
        Me.Bkar.Location = New System.Drawing.Point(315, 213)
        Me.Bkar.Name = "Bkar"
        Me.Bkar.Size = New System.Drawing.Size(65, 34)
        Me.Bkar.TabIndex = 52
        Me.Bkar.Text = "^"
        Me.Bkar.UseVisualStyleBackColor = False
        '
        'Bmul1
        '
        Me.Bmul1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Bmul1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bmul1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Bmul1.ForeColor = System.Drawing.Color.LightCyan
        Me.Bmul1.Location = New System.Drawing.Point(315, 253)
        Me.Bmul1.Name = "Bmul1"
        Me.Bmul1.Size = New System.Drawing.Size(65, 34)
        Me.Bmul1.TabIndex = 53
        Me.Bmul1.Text = "x"
        Me.Bmul1.UseVisualStyleBackColor = False
        '
        'BRb
        '
        Me.BRb.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BRb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BRb.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BRb.ForeColor = System.Drawing.Color.LightCyan
        Me.BRb.Location = New System.Drawing.Point(395, 173)
        Me.BRb.Name = "BRb"
        Me.BRb.Size = New System.Drawing.Size(65, 34)
        Me.BRb.TabIndex = 54
        Me.BRb.Text = ")"
        Me.BRb.UseVisualStyleBackColor = False
        '
        'Bmul2
        '
        Me.Bmul2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Bmul2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bmul2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Bmul2.ForeColor = System.Drawing.Color.LightCyan
        Me.Bmul2.Location = New System.Drawing.Point(395, 253)
        Me.Bmul2.Name = "Bmul2"
        Me.Bmul2.Size = New System.Drawing.Size(65, 34)
        Me.Bmul2.TabIndex = 55
        Me.Bmul2.Text = "*"
        Me.Bmul2.UseVisualStyleBackColor = False
        '
        'BDiv
        '
        Me.BDiv.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BDiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BDiv.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BDiv.ForeColor = System.Drawing.Color.LightCyan
        Me.BDiv.Location = New System.Drawing.Point(395, 213)
        Me.BDiv.Name = "BDiv"
        Me.BDiv.Size = New System.Drawing.Size(65, 34)
        Me.BDiv.TabIndex = 56
        Me.BDiv.Text = "/"
        Me.BDiv.UseVisualStyleBackColor = False
        '
        'B0
        '
        Me.B0.BackColor = System.Drawing.Color.SaddleBrown
        Me.B0.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B0.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.B0.ForeColor = System.Drawing.Color.LightCyan
        Me.B0.Location = New System.Drawing.Point(75, 293)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(145, 34)
        Me.B0.TabIndex = 57
        Me.B0.Text = "0"
        Me.B0.UseVisualStyleBackColor = False
        '
        'Bdot
        '
        Me.Bdot.BackColor = System.Drawing.Color.SaddleBrown
        Me.Bdot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bdot.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Bdot.ForeColor = System.Drawing.Color.LightCyan
        Me.Bdot.Location = New System.Drawing.Point(235, 293)
        Me.Bdot.Name = "Bdot"
        Me.Bdot.Size = New System.Drawing.Size(65, 34)
        Me.Bdot.TabIndex = 58
        Me.Bdot.Text = "."
        Me.Bdot.UseVisualStyleBackColor = False
        '
        'BMinus
        '
        Me.BMinus.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BMinus.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BMinus.ForeColor = System.Drawing.Color.LightCyan
        Me.BMinus.Location = New System.Drawing.Point(395, 293)
        Me.BMinus.Name = "BMinus"
        Me.BMinus.Size = New System.Drawing.Size(65, 34)
        Me.BMinus.TabIndex = 59
        Me.BMinus.Text = "-"
        Me.BMinus.UseVisualStyleBackColor = False
        '
        'BAdd
        '
        Me.BAdd.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAdd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BAdd.ForeColor = System.Drawing.Color.LightCyan
        Me.BAdd.Location = New System.Drawing.Point(315, 293)
        Me.BAdd.Name = "BAdd"
        Me.BAdd.Size = New System.Drawing.Size(65, 34)
        Me.BAdd.TabIndex = 60
        Me.BAdd.Text = "+"
        Me.BAdd.UseVisualStyleBackColor = False
        '
        'BAc
        '
        Me.BAc.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BAc.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BAc.ForeColor = System.Drawing.Color.LightCyan
        Me.BAc.Location = New System.Drawing.Point(475, 173)
        Me.BAc.Name = "BAc"
        Me.BAc.Size = New System.Drawing.Size(95, 34)
        Me.BAc.TabIndex = 61
        Me.BAc.Text = "CLEAR"
        Me.BAc.UseVisualStyleBackColor = False
        '
        'BPer
        '
        Me.BPer.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BPer.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BPer.ForeColor = System.Drawing.Color.LightCyan
        Me.BPer.Location = New System.Drawing.Point(475, 213)
        Me.BPer.Name = "BPer"
        Me.BPer.Size = New System.Drawing.Size(95, 34)
        Me.BPer.TabIndex = 62
        Me.BPer.Text = "Percent(%)"
        Me.BPer.UseVisualStyleBackColor = False
        '
        'BEnter
        '
        Me.BEnter.BackColor = System.Drawing.Color.SeaGreen
        Me.BEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BEnter.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.BEnter.ForeColor = System.Drawing.Color.LightCyan
        Me.BEnter.Location = New System.Drawing.Point(475, 253)
        Me.BEnter.Name = "BEnter"
        Me.BEnter.Size = New System.Drawing.Size(95, 74)
        Me.BEnter.TabIndex = 63
        Me.BEnter.Text = "Enter"
        Me.BEnter.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DarkRed
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(-7, 371)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(661, 29)
        Me.RichTextBox1.TabIndex = 64
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(214, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "VISIT:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.DarkRed
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.LightSeaGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(272, 374)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(188, 19)
        Me.LinkLabel1.TabIndex = 66
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.autosoft.890m.com"
        '
        'acalc
        '
        Me.AccessibleDescription = "The Best Calculator"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(646, 402)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BEnter)
        Me.Controls.Add(Me.BPer)
        Me.Controls.Add(Me.BAc)
        Me.Controls.Add(Me.BAdd)
        Me.Controls.Add(Me.BMinus)
        Me.Controls.Add(Me.Bdot)
        Me.Controls.Add(Me.B0)
        Me.Controls.Add(Me.BDiv)
        Me.Controls.Add(Me.Bmul2)
        Me.Controls.Add(Me.BRb)
        Me.Controls.Add(Me.Bmul1)
        Me.Controls.Add(Me.Bkar)
        Me.Controls.Add(Me.BLb)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.answerboxword)
        Me.Controls.Add(Me.answerbox)
        Me.Controls.Add(Me.inputbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(662, 451)
        Me.MinimizeBox = False
        Me.Name = "acalc"
        Me.Text = "ACalc G1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menufile As ToolStripMenuItem
    Friend WithEvents Fsettings As ToolStripMenuItem
    Friend WithEvents Fexit As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Mmcalc As ToolStripMenuItem
    Friend WithEvents MMain As ToolStripMenuItem
    Friend WithEvents Mhcf As ToolStripMenuItem
    Friend WithEvents Mquad As ToolStripMenuItem
    Friend WithEvents Mprime As ToolStripMenuItem
    Friend WithEvents menuhistory As ToolStripMenuItem
    Friend WithEvents Mchist As ToolStripMenuItem
    Friend WithEvents Mcdelhist As ToolStripMenuItem
    Friend WithEvents menuhelp As ToolStripMenuItem
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents inputbox As TextBox
    Friend WithEvents answerbox As TextBox
    Friend WithEvents answerboxword As TextBox
    Friend WithEvents B7 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents BLb As Button
    Friend WithEvents Bkar As Button
    Friend WithEvents Bmul1 As Button
    Friend WithEvents BRb As Button
    Friend WithEvents Bmul2 As Button
    Friend WithEvents BDiv As Button
    Friend WithEvents B0 As Button
    Friend WithEvents Bdot As Button
    Friend WithEvents BMinus As Button
    Friend WithEvents BAdd As Button
    Friend WithEvents BAc As Button
    Friend WithEvents BPer As Button
    Friend WithEvents BEnter As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents RectangleShape1 As PowerPacks.RectangleShape
End Class
