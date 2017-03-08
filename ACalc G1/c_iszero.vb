Public Class c_iszero

    Public Shared a As Double, b As Double

    Public Sub New(a_a As Double, b_b As Double)
        a = a_a : b = b_b

        ' This call is required by the designer.
        InitializeComponent()
        Box1.Text = "" : Box2.Text = "" : Box3.Text = "" : Box4.Text = ""
        Box5.Text = "" : Box6.Text = "" : Box7.Text = "" : Box8.Text = ""
        Box9.Text = "" : Box10.Text = "" : Box11.Text = ""
    End Sub


    Private Sub c_iszero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call factime()
    End Sub


    Public Sub factime()

        If b <> 0 Then
            REM -------------------------------------------------------------------
            REM to find ax^2 + bx = 0----------------------------
            Dim aa As String = "", bb As String = ""

            REM for ax^2
            If a <> 1 Then
                aa = Str(a) + "x²"
            ElseIf a = 1 Then
                aa = " x²"
            ElseIf a = -1 Then
                aa = " -x²"
            End If

            REM for bx
            If b <> 1 Then
                bb = eachchar(b) + "x"
            ElseIf a = 1 Then
                bb = "+ x"
            ElseIf a = -1 Then
                bb = " - x"
            End If
            Dim var1 As String = aa + bb + "   =  " + "0"
            REM --------------------------------------------------


            REM for h11x(c11x+c22) = 0 --------------------------------
            Dim hcf_invoke As hcf_lcm_class
            hcf_invoke = New hcf_lcm_class()
            Dim h1 As Double = hcf_invoke.hcf(a, b)

            REM for h11x
            Dim h11 As String = ""
            If h1 <> 1 Then
                h11 = Str(h1) + "x"
            ElseIf h1 = 1 Then
                h11 = " x"
            ElseIf h1 = -1 Then
                h11 = "-x"
            End If


            REM for c11x
            Dim c11 As String = ""
            Dim c1 As Double = a / h1
            If c1 <> 1 Then
                c11 = LTrim(Str((c1))) + "x"
            ElseIf c1 = 1 Then
                c11 = "x"
            ElseIf c1 = -1 Then
                c11 = "-x"
            End If

            REM for c22
            Dim c22 As String
            Dim c2 As Double = b / h1
            c22 = eachchar(c2)

            Dim var2 As String = "or, " + h11 + "(" + c11 + c22 + ")" + "  =  " + "0"
            REM ------------------------------------------------------------

            REM ---------------------------------------------------------------
            REM for EITHER, OR
            REM for EITHER
            Dim var3 As String = "Either," 'either
            Dim var4 As String = h11 + "  =  0"
            Dim var5 As String = "or," + "  x " + " =  0"
            Dim ans1 As Double = 0


            REM for OR
            Dim var6 As String = "Or," 'or
            Dim var7 As String = c11 + c22 + "  =  0"
            Dim var8 As String = "or," + " x " + "     =  " + Str((-1 * (c2)) / c1)
            Dim ans2 As Double = (-1 * (c2)) / c1
            REM ----------------------------------------------------------------
            Dim var9 As String = "Therefore, x = " + Str(ans1) + ", " + Str(ans2)

            REM printing time ---------------------------------------------------------------
            Box1.Text = "Solution:"
            Box2.Text = "Given,"
            Box3.Text = var1
            Box4.Text = var2
            Box5.Text = var3
            Box6.Text = var4
            Box7.Text = var5
            Box8.Text = var6
            Box9.Text = var7
            Box10.Text = var8
            Box11.Text = var9
        Else
            REM when b and c both are 0 --------------------------------------------------------
            Dim aa As String = ""
            REM for ax^2
            If a <> 1 Then
                aa = Str(a) + "x²"
            ElseIf a = 1 Then
                aa = " x²"
            ElseIf a = -1 Then
                aa = " -x²"
            End If

            REM printing time -----------------------------------------------------------
            Box1.Text = "Solution:"
            Box2.Text = "Now,"
            Box3.Text = aa + "  =  0"
            Box4.Text = "or,   x  =  0"
            Box5.Text = "Therefore, x = 0"
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