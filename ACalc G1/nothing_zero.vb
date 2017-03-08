Public Class nothing_zero

    Public Shared print_a As Double, print_b As Double, print_c As Double
    Public Shared a As Double, b As Double, c As Double
    Public common_var As Double = 1

    Public Shared hcf_invoke As hcf_lcm_class



    Public Sub New(a_a As Double, b_b As Double, c_c As Double)
        InitializeComponent()
        print_a = a_a : print_b = b_b : print_c = c_c
        a = a_a : b = b_b : c = c_c

        Box1.Text = "" : Box2.Text = "" : Box3.Text = "" : Box4.Text = "" : Box5.Text = ""
        Box6.Text = "" : Box7.Text = "" : Box8.Text = "" : Box9.Text = "" : Box10.Text = ""
        Box11.Text = "" : Box12.Text = "" : Box13.Text = "" : Box14.Text = "" : Box15.Text = ""

    End Sub

    Private Sub nothing_zero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call facttime()
    End Sub

    Public Sub facttime()
        Try
            REM -------------------------------------------------------------------------
            REM Time to check whether there is common between a,b and c
            Dim i As Integer
            Dim common_array(3) As Double
            common_array(1) = a
            common_array(2) = b
            common_array(3) = c

            For i = 1 To 3
                If common_array(i) < 0 Then common_array(i) = -common_array(i)
            Next i

            hcf_invoke = New hcf_lcm_class()
            common_var = hcf_invoke.find_hcf(common_array, 3)

            If a < 0 Then common_var = -common_var
            a = a / common_var
            b = b / common_var
            c = c / common_var
            REM -------------------------------------------------------------------------

            Dim mul As Double = a * c
            Dim flag As String = "plus"
            If mul < 0 Then
                flag = "minus"
                mul = mul * -1
            End If

            Dim count As Integer = 1
            Dim fact(Int(mul)) As Double
            For i = 1 To mul
                If mul Mod i = 0 Then
                    fact(count) = i
                    count = count + 1
                End If
            Next i
            count = count - 1

            Dim t1 As Double, t2 As Double, mulvalue As Double, addvalue As Double
            Dim h1 As Double, h2 As Double
            For i = 1 To count
                t1 = fact(i)
                For j = 1 To count
                    t2 = fact(j)
                    mulvalue = t1 * t2
                    If flag = "plus" Then
                        addvalue = t1 + t2
                    ElseIf flag = "minus" Then
                        addvalue = t1 - t2
                    End If

                    If b < 0 Then addvalue = -addvalue

                    If (mulvalue = mul) And (addvalue = b) Then
                        If flag = "plus" Then
                            If b < 0 Then
                                t1 = t1 * -1
                                t2 = t2 * -1
                            End If
                        ElseIf flag$ = "minus" Then
                            If b < 0 Then
                                If t2 > t1 Then
                                    t2 = t2 * -1
                                Else
                                    t1 = t1 * -1
                                End If
                            ElseIf b > 0 Then
                                t2 = t2 * -1
                            End If
                        End If

                        h1 = hcf_invoke.hcf(t1, a)
                        h2 = hcf_invoke.hcf(c, t2)
                        Call facttime(a, b, c, t1, t2, h1, h2, flag)
                        GoTo last
                    End If
                Next j
            Next i
        Catch
        End Try
        REM ------------------------------------------------------------------------------------------------
        REM this part is carried out when the euation cant be simplified------------
        REM to find the two roots using the quadratic equation formula

        Dim insideroot As Double = (b ^ 2) - 4 * a * c
        If insideroot >= 0 Then

            Dim invoke_imaginary As New imaginaryForm(print_a, print_b, print_c)
            invoke_imaginary.Show()
            Me.Close()

            'Dim answerpos As Double = (-b + (insideroot) ^ 0.5) / (2 * a)
            'Dim answerneg As Double = (-b - (insideroot) ^ 0.5) / (2 * a)

            '' ----------------------------------------------------------------------
            '' this is the <<a11x^2 + b11x + c11>> before taking common which will be printed in the beginning
            '' with given.
            'REM to find a11x^2 + b11x + c11 = 0
            '' for ax^2
            'Dim aa11 As String, bb11 As String, cc11 As String
            'Dim main_var1 As String

            'If print_a = 1 Then
            '    aa11 = " x²"
            'ElseIf print_a = -1 Then
            '    aa11 = " -x²"
            'Else
            '    aa11 = Str(print_a) + "x²"
            'End If

            '' for bx
            'bb11 = eachchar(print_b) + "x"

            ''for c
            'cc11 = eachchar(print_c)

            'main_var1 = "    " + aa11 + bb11 + cc11 + "          =  0"
            '' ------------------------------------------------------------------------------


            '' to find ax^2 + bx + c = 0------------------------------------
            'REM for ax^2
            'Dim aa As String = "", bb As String, cc As String
            'Dim var1 As String

            'If a <> 1 Then
            '    aa = Str(a) + "x²"
            'ElseIf a = 1 Then
            '    aa = " x²"
            'ElseIf a = -1 Then
            '    aa = " -x²"
            'End If

            'REM for bx
            'bb = eachchar(b) + "x"

            'REM for c
            'cc = eachchar(c)

            'REM to print in   ax^2 + bx + c = 0
            'If common_var = 1 Then
            '    var1 = "    " + aa + bb + cc + "          =  0"
            'ElseIf common_var = -1 Then
            '    var1 = "   -(" + aa + bb + cc + ")         =  0"
            'Else
            '    var1 = "    " + LTrim(Str(common_var)) + "(" + aa + bb + cc + ")        =  0"
            'End If
            '' ---------------------------------------------------------------

            'REM to print in value of x in both roots
            'Dim var2 As String = "     x = " + Str(answerpos) + ", " + Str(answerneg)

            'REM Result time------------------------------------------
            'Box1.Text = "Solution:"
            'Box2.Text = "Given,"
            'Box3.Text = main_var1
            'Box4.Text = "Now,"
            'Box5.Text = var1
            'Box6.Text = "Using Quadratic Equation Formula, (-b)±vb²-4ac)/(2a), we get:"
            'Box6.ForeColor = Box4.ForeColor
            'Box7.Text = var2
        Else
            Dim invoke_imaginary As New imaginaryForm(print_a, print_b, print_c)
            invoke_imaginary.Show()
            Me.Close()
        End If
        REM ------------------------------------------------------------------------------------------------
last:
    End Sub







    Sub facttime(a As Double, b As Double, c As Double, t1 As Double, t2 As Double, h1 As Double, h2 As Double, flag As String)

        REM -----------------------------------------------------------------------------------------------
        ' this is the <<a11x^2 + b11x + c11>> before taking common which will be printed in the beginning
        ' with given.
        Dim aa11 As String, bb11 As String, cc11 As String

        REM to find a11x^2 + b11x + c11 = 0
        ' for ax^2
        If print_a = 1 Then
            aa11 = " x²"
        ElseIf print_a = -1 Then
            aa11 = " -x²"
        Else
            aa11 = Str(print_a) + "x²"
        End If

        ' for bx
        bb11 = eachchar(print_b) + "x"

        'for c
        cc11 = eachchar(print_c)
        Dim main_var1 As String = aa11 + bb11 + cc11 + "          =  0"
        REM ---------------------------------------------------------------------------------------------



        REM ---------------------------------------------------------------------------------------------
        REM to find ax^2 + bx + c = 0
        REM for ax^2

        Dim aa As String = "", bb As String, cc As String
        Dim var1 As String

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

        If common_var = 1 Then
            var1 = aa + bb + cc + "          =  0"
        ElseIf common_var = -1 Then
            var1 = "-(" + aa + bb + cc + ")         =  0"
        Else
            var1 = LTrim(Str(common_var)) + "(" + aa + bb + cc + ")      =  0"
        End If
        REM ------------------------------------------------------------------------------------------

        REM ------------------------------------------------------------------------------------------
        REM for ax^2 + t11x + t22x + c = 0
        REM for t11x

        Dim var2 As String, t11 As String = "", t22 As String = ""

        If t1 <> 1 Then
            t11 = eachchar$(t1) + "x"
        ElseIf t1 = 1 Then
            t11 = " + x"
        ElseIf t1 = -1 Then
            t11 = " - x"
        End If

        REM for t22x
        If t2 <> 1 Then
            t22 = eachchar$(t2) + "x"
        ElseIf t2 = 1 Then
            t22 = " + x"
        ElseIf t2 = -1 Then
            t22 = " - x"
        End If

        var2 = "or, " + aa + t11 + t22 + cc + "       =  0"
        REM -------------------------------------------------------------------------------------------


        REM ------------------------------------------------------------------------------
        REM for h11x(c11x+c22)+h22(c33x+c44)  =   0

        Dim var3 As String
        Dim c1 As Double, c2 As Double, c3 As Double, c4 As Double
        Dim h11 As String = "", c11 As String = "", c22 As String, h22 As String, c33 As String = "", c44 As String


        REM for h11x
        If h1 <> 1 Then
            h11 = Str(h1) + "x"
        ElseIf h1 = 1 Then
            h11 = " x"
        ElseIf h1 = -1 Then
            h11 = "-x"
        End If


        REM for h22
        h22 = eachchar(h2)
        REM i had to redefine h2 because it would become positive even it was negative and it's
        REM string value was correct so i used h22$ to turn it into actual value
        h2 = Val(h22)

        REM for c11x
        c1 = a / h1
        If c1 <> 1 Then
            c11 = LTrim(Str((c1))) + "x"
        ElseIf c1 = 1 Then
            c11 = "x"
        ElseIf c1 = -1 Then
            c11 = "-x"
        End If

        REM for c22
        c2 = t1 / h1
        c22 = eachchar(c2)

        REM for c33x
        c3 = t2 / h2
        If c3 <> 1 Then
            c33 = LTrim$(Str((c3))) + "x"
        ElseIf c3 = 1 Then
            c33 = "x"
        ElseIf c3 = -1 Then
            c33 = "- x"
        End If


        REM for c44
        c4 = c / h2
        Dim c444 As Double = c4 ' this was necessary because value of c2 was lost on the way
        c44 = eachchar(c444)

        var3 = "or, " + h11 + "(" + c11 + c22 + ")" + h22 + "(" + c33 + c44 + ")" + "   =  0"
        REM -------------------------------------------------------------------------------------

        REM -------------------------------------------------------------------------------------
        REM for (h11x+h22)(c11x+c22)   =   0
        Dim var4 As String
        var4 = "or, " + "(" + c11 + c22 + ")" + "(" + h11 + h22 + ")" + "        =  0"
        REM ----------------------------------------------------------------------------------



        REM -----------------------------------------------------------------------------
        REM for EITHER, OR

        Dim var5 As String, var6 As String, var7 As String, var8 As String, var9 As String, var10 As String

        REM for EITHER
        var5 = "Either," 'either
        var6 = c11 + c22 + "  =   0"
        'var7 = "or," + " x " + "     =  " + Str$((-1 * (c222)) / c1)
        var7 = "or," + " x " + "     =  " + Str((-1 * (c2)) / c1)
        Dim ans1 As Double = (-1 * (c2)) / c1


        REM for OR
        var8 = "Or," 'or
        var9 = h11 + h22 + "  =   0"
        var10 = "or," + "  x " + "     =   " + LTrim(Str((-1 * (h2)) / h1))
        Dim ans2 As Double = (-1 * (h2)) / h1
        REM -----------------------------------------------------------------------------


        REM -----------------------------------------------------------------------------
        ' final therefore
        Dim var11 As String = "Therefore, x = " + Str(ans1) + ", " + Str(ans2)
        REM -----------------------------------------------------------------------------

        REM -----------------------------------------------------------------------------
        ' Printing time
        Box1.Text = "Solution:"
        Box2.Text = "Given,"
        Box3.Text = main_var1
        Box4.Text = "Now,"
        Box5.Text = var1
        Box6.Text = var2
        Box7.Text = var3
        Box8.Text = var4
        Box9.Text = var5
        Box10.Text = var6
        Box11.Text = var7
        Box12.Text = var8
        Box13.Text = var9
        Box14.Text = var10
        Box15.Text = var11
        REM -----------------------------------------------------------------------------

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