Public Class imaginaryForm

    Public Shared a As Double, b As Double, c As Double
    Public Shared isImaginary As Boolean = True


    Public Sub New(a_a As Double, b_b As Double, c_c As Double)

        InitializeComponent()
        a = a_a : b = b_b : c = c_c

    End Sub

    Private Sub imaginaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        Call imagineTime()
    End Sub

    Private Sub imagineTime()

        ' check whether the given equation has imaginary roots or real roots
        If ((b * b) - 4 * a * c) > 0 Then isImaginary = False
        ' if the equation is complex then all the i box should be removed
        If isImaginary = False Then
            iBox1.Visible = False
            iBox2.Visible = False
            iBox3.Visible = False
            iBox4.Visible = False
            iBox5.Visible = False
        End If

        REM -------------------------------------------------------------------------
        REM Time to check whether there is common between a,b and c
        Dim common_var As Double
        Dim hcf_invoke = New hcf_lcm_class()
        If (b <> 0) Then
            Dim i As Integer
            Dim common_array(3) As Double
            common_array(1) = a
            common_array(2) = b
            common_array(3) = c

            For i = 1 To 3
                If common_array(i) < 0 Then common_array(i) = -common_array(i)
            Next i

            common_var = hcf_invoke.find_hcf(common_array, 3)
        Else
            ' if b is 0 then hcf_lcm_class cannot process the hcf value so when b is 0 hcf and lcm between only 2 
            ' numbers a and c is to be found 
            common_var = hcf_invoke.hcf(a, c)
        End If



        If a < 0 Then common_var = -common_var
        a = a / common_var
        b = b / common_var
        c = c / common_var
        REM -------------------------------------------------------------------------


        Dim var1 As String ' text for first box
        If b <> 0 Then
            ' to find ax^2 + bx + c = 0------------------------------------
            REM for ax^2
            Dim aa As String = "", bb As String, cc As String

            If a <> 1 Then
                aa = Str(a) + "x²"
            ElseIf a = 1 Then
                aa = " x²"
            ElseIf a = -1 Then
                aa = " -x²"
            End If

            REM for bx
            bb = eachchar(b) + "x"

            REM for c
            cc = eachchar(c)

            REM to print in   ax^2 + bx + c = 0
            If common_var = 1 Then
                var1 = "    " + aa + bb + cc + "          =  0"
            ElseIf common_var = -1 Then
                var1 = "   -(" + aa + bb + cc + ")         =  0"
            Else
                var1 = "    " + LTrim(Str(common_var)) + "(" + aa + bb + cc + ")        =  0"
            End If
            ' ---------------------------------------------------------------
        Else
            REM ----------------------------------------------------------------------------------
            REM when b=0 , ie ax^2 + c = 0 

            REM to find ax^2 + c = 0----------------------------
            REM for ax^2
            Dim a11 As String = "", c11 As String
            Dim c1 As Double

            If a <> 1 Then
                a11 = Str(a) + "x²"
            ElseIf a = 1 Then
                a11 = " x²"
            ElseIf a = -1 Then
                a11 = " -x²"
            End If

            REM for c
            c1 = c
            c11 = eachchar(c)

            var1 = a11 + c11 + " = " + "0"
            REM --------------------------------------------------
        End If

        Box1.Text = var1
        REM ---------------------------------------------------------------------------------
        ' for printing -b ± √(b²-4ac)
        Box2.Text = "(" + LTrim(Str(b)) + ")"
        Box3.Text = "( (" + LTrim(Str(b)) + ")²-4 x " + LTrim(Str(a)) + " x " + LTrim(Str(c)) + ")"
        REM ---------------------------------------------------------------------------------

        'for printing 2a
        Box4.Text = "2x" + LTrim(Str(a))

        Dim twisA = 2 * a
        Dim var2 As Double = -(b)

        Box6.Text = var2
        Box8.Text = twisA

        Dim var3 As Double = ((b * b) - 4 * a * c) * -1
        ' if roots are real then var3 should be multiplied by -1 again otherwise real roots cant be obtained
        If isImaginary = False Then var3 = var3 * -1
        Box7.Text = "(" + LTrim(Str(var3)) + ")"
        Box9.Text = twisA
        MsgBox(var3)
        REM ------------------------------------------------------------------
        'for printing factorized value of -b/2a
        Dim fact_b As Double
        Dim fact_2a As Double
        If (b <> 0) Then
            common_var = hcf_invoke.hcf(twisA, var2)

            'divide the variables -b and 2a by common_var
            fact_b = (var2) / common_var
            fact_2a = (twisA) / common_var

            'finally print values of fact_b and fact_2a whereever required
            Box10.Text = LTrim(Str(fact_b))
            Box14.Text = LTrim(Str(fact_b))

            Box12.Text = LTrim(Str(fact_2a))
            Box16.Text = LTrim(Str(fact_2a))
        End If

        'printing root values
        Box11.Text = Box7.Text
        Box15.Text = Box7.Text

        'printing denominator of root
        Box13.Text = twisA
        Box17.Text = twisA

        REM printing final answers
        If b <> 0 Then
            Box18.Text = LTrim(Str(fact_b / fact_2a))
            Box20.Text = Box18.Text
        End If
        If (isImaginary = True) Then
            Box19.Text = ((var3) ^ (1 / 2)) / twisA
        Else
            Box19.Text = (var3 ^ (1 / 2)) / twisA
        End If

        Box21.Text = Box19.Text

        ' if value of b is 0 then all the boxex that contains -b/2a should be removed because they have no value
        If b = 0 Then
            minus1.Visible = False
            Box2.Text = 0
            Box6.Text = 0
            line1.Visible = False
            Box8.Visible = False
            Box10.Visible = False
            line2.Visible = False
            Box12.Visible = False
            Box14.Visible = False
            line3.Visible = False
            Box16.Visible = False
            Box18.Visible = False
            Box20.Visible = False


        End If



    End Sub

    Function eachchar(number As Double) As String
        If number > 0 Then
            Return " + " + LTrim(Str(number))
        Else
            number = -1 * number
            Return " - " + LTrim((Str(number)))
        End If
    End Function

End Class