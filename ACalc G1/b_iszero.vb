Public Class b_iszero

    Public Shared a As Double, c As Double

    Public Sub New(a_a As Double, c_c As Double)

        a = a_a : c = c_c

        InitializeComponent()
        Box1.Text = "" : Box2.Text = "" : Box3.Text = "" : Box4.Text = ""
        Box5.Text = "" : Box6.Text = "" : Box7.Text = ""

    End Sub

    Private Sub b_iszero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call facttime()
    End Sub

    Public Sub facttime()

        If a * c < 0 Then
            REM ----------------------------------------------------------------------------------
            REM when b=0 , ie ax^2 + c = 0 

            REM to find ax^2 + c = 0----------------------------
            REM for ax^2
            Dim a11 As String = "", c11 As String
            Dim c1 As Double
            Dim var1 As String

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

            REM for ax^2 = -c ------------------------------------
            Dim var2 As String = "or, " + a11 + "      =" + Str(-c1)

            REM for x = (answer) ------------------------------------------
            Dim var3 As String = "or, " + " x²" + "       =" + Str((-c1) / a)

            Dim answer As Double = ((-c1) / a) ^ (1 / 2)
            Dim var4 As String = "or, " + " x        = " + "± " + LTrim(Str(answer))

            Dim var5 As String = "Therefore, x = " + "± " + LTrim(Str(answer))

            REM printing time --------------------------------------------
            Box1.Text = "Solution:"
            Box2.Text = "Given,"
            Box3.Text = var1
            Box4.Text = var2
            Box5.Text = var3
            Box6.Text = var4
            Box7.Text = var5
            REM ----------------------------------------------------------------------------------
        Else
            Dim invoke_imaginary As New imaginaryForm(a, 0, c)
            invoke_imaginary.Show()
            Me.Close()
            ' MsgBox("x doesnot have real value")
            ' Me.Close()
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