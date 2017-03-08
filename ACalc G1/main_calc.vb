Imports System.IO

Public Class main_calc

    Public code As String
    Public temp As String
    Public error_is As String

    ' variables needed to join first num, second num together with the 
    ' operator to replace the main string
    Public Shared rn1 As String, rn2 As String
    Public Shared bracstep As String
    Public Shared left_of_bracket As String, right_of_bracket As String

    ' object to invoke word generation class
    Dim invoke_word As word_generation

    Public Sub New()
    End Sub

    Sub initial(code)

        REM THIS SUB: 1) IS responsible for taking userinput from the main class
        REM           2) TO send user to other modules if he has entered any in-line commands

        ' if error in found in the input string
        error_is = "false" 'initialize that error is not found 
        If File.Exists("ACalc_Files/temphistory.txt") Then File.Delete("ACalc_Files/temphistory.txt")
        Using reader As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
        End Using
        'code = LCase(code)

        If code = "" Then
            error_is = "true"
            acalc.answerbox.Text = "Error: Value is empty"
            GoTo last
        ElseIf code = "exit" Or code = "off" Then
            End
        ElseIf code = "settings" Then
            settings.Show()
            settings.Focus()
        ElseIf code = "quad" Then
            quad_form.Show()
            quad_form.Focus()
        ElseIf code = "primeorcom" Then
            Prime_Com.Show()
            Prime_Com.Focus()
        ElseIf code = "hcf_lcm" Then
            hcf_lcm_form.Show()
            hcf_lcm_form.Focus()
        ElseIf code = "history" Then
            history.Show()
            history.Focus()
        ElseIf code = "delhistory" Then
            Dim delhistory As history_delete
            delhistory = New history_delete
            delhistory.delete_history()
        ElseIf code = "manual" Or code = "help" Then
            user_manual.Show()
            user_manual.Focus()
        Else
            bracstep = "false"

            Dim towrite As String = code ' towrite showld be written in history since value of code is changed during process
            Using writer As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
                writer.WriteLine(towrite)
            End Using

            code = fstep(code)
            If code = "error" Then GoTo last
            code = bracerr(code)
            If code = "error" Then GoTo last
            code = err(code)
            If code = "error" Then GoTo last
            code = code + "+0"
            code = dotok(code)
            If code = "error" Then GoTo last
            code = bokhand(code)
            If code = "error" Then GoTo last
            code = okhand(code)

            ' get the answer
            Dim ans As String, a As String
            ans = finalpart(code)
            If ans = "error" Then GoTo last
            If Val(ans) >= 0 Then ans = Mid(ans, 2, Len(ans))
            a = ans


            If error_is <> "true" Then ' case when error is not found
                ' print the answer
                acalc.answerbox.Text = " = " + ans

                acalc.answerbox.BackColor = Color.Black
                acalc.answerbox.ForeColor = Color.Chartreuse

                'invoke word generator
                invoke_word = New word_generation()
                Dim answerword As String = invoke_word.handleword(ans)
                acalc.answerboxword.Text = answerword


                Dim displaytype As String = ""
                If File.ReadAllText("ACalc_Files/settings.txt").Length <> 0 Then
                    Using reader As StreamReader = New StreamReader("ACalc_Files/settings.txt")
                        displaytype = reader.ReadLine
                    End Using
                End If

                If displaytype = "1" Then ' this display type shows whether to show process or not
                    Dim process_display As New process_window
                    process_display.Show()
                End If
                Using writer As StreamWriter = File.AppendText("ACalc_Files/suffle_history.txt")
                    writer.WriteLine(towrite)
                    writer.WriteLine(a)
                    Using reader As StreamReader = New StreamReader("ACalc_Files/history.txt")
                        Do While Not reader.Peek
                            towrite = reader.ReadLine
                            a = reader.ReadLine
                            writer.WriteLine(towrite)
                            writer.WriteLine(a)
                        Loop
                    End Using
                End Using
                File.Delete("ACalc_Files/history.txt")
                Rename("ACalc_Files/suffle_history.txt", "ACalc_Files/history.txt")
            End If
        End If
last:
        If error_is = "true" Then
            ' change color of answerbox in the special case when error is found
            acalc.answerbox.BackColor = Color.Red
            acalc.answerbox.ForeColor = Color.White

            File.Delete("ACalc_Files/temphistory.txt")
            acalc.answerboxword.Text = ""
        End If
    End Sub

    Private Function fstep(clear As String) As String

        Dim i As Integer

        REM this procedure changes 1) percentage into /100
        REM                        2) Removing spaces
        REM                        3) Changing of and x to *
        REM                        3) and finding whether other symbols exist

        clear = LTrim(clear)
        Dim t As String

        REM to check error in percentage eg: 5%5
        For i = 1 To Len(clear) - 1
            t = Mid(clear, i, 1)
            If t = "%" Then
                Select Case Mid(clear, i + 1, 1)
                    Case "0" To "9", "."
                        acalc.answerbox.Text = "Error: in |%|"
                        error_is = "true"
                        Return "error"
                End Select
            End If
        Next i

        REM to change % to /100
        temp = ""
        For i = 1 To Len(clear)
            t = Mid(clear, i, 1)
            If t <> "%" Then
                temp = temp + t
            Else
                temp = temp + "/100"
            End If
        Next i
        clear = temp


        REM  remove spaces
        Dim a As String = ""
        For i = 1 To Len(clear)
            t = Mid(clear, i, 1)
            If t <> " " Then
                a = a + t
            End If
        Next i
        clear = a

        REM to check whether any other symbols exist
        Dim tru As String = "true"
        For i = 1 To Len(clear)
            temp = Mid(clear, i, 1)
            Select Case temp
                Case "0" To "9", "%", "^", "/", "*", "x", "+", "-", ".", "(", ")"
                Case Else
                    tru = "false"
            End Select
        Next i

        If tru = "false" Then
            acalc.answerbox.Text = "Error: Syntax Error"
            error_is = "true"
            Return "error"
        Else
            REM to replace "x" wiht "*"
            temp = ""
            For i = 1 To Len(clear)
                t = Mid(a, i, 1)
                If t <> "x" Then
                    temp = temp + t
                Else
                    temp = temp + "*"
                End If
            Next i
        End If
        Return temp
    End Function

    Private Function bracerr(bcheck As String)
        Dim i As Integer
        Try
            REM TO check whether no of brackets are equal or not
            Dim lbrac As Integer = 0
            Dim rbrac As Integer = 0
            For i = 1 To Len(bcheck)
                temp = Mid(bcheck, i, 1)
                Select Case temp
                    Case "("
                        lbrac = lbrac + 1 'Count number of ( brackets
                    Case ")"
                        rbrac = rbrac + 1 'Count number of ) brackets
                End Select
            Next i
            If lbrac <> rbrac Then
                acalc.answerbox.Text = "Error: No of brackets not equal"
                error_is = "true"
                Return "error"
            End If


            REM -----------------------------------------------------
            REM to Checks for all bracket errors

            REM for error something like : () - empty brackets
            For i = 1 To (Len(bcheck) - 1)
                Dim t1 As String = Mid(bcheck, i, 1)
                Dim t2 As String = Mid(bcheck, i + 1, 1)
                If t1 = "(" And t2 = ")" Then
                    acalc.answerbox.Text = "Error: ()"
                    error_is = "true"
                    Return "error"
                End If
            Next i

            REM for error something like : (/56) - when ( follows ^,*,/)
            Dim temp1 As String
            For i = 1 To Len(bcheck)
                temp = Mid(bcheck, i, 1)
                If temp = "(" Then
                    temp1 = Mid(bcheck, i + 1, 1)
                    If temp1 = "*" Or temp1 = "/" Or temp1 = "^" Then
                        acalc.answerbox.Text = "ERROR: *,/,^ cant go after |(|"
                        error_is = "true"
                        Return "error"
                    End If
                End If
            Next i

            REM for error something like : (56+4/) - when  follows ^,*,/ follows )
            For i = 1 To Len(bcheck)
                temp = Mid(bcheck, i, 1)
                If temp = ")" Then
                    temp1 = Mid(bcheck, i - 1, 1)
                    Select Case temp1
                        Case "^", "/", "*", "%", "+", "-"
                            acalc.answerbox.Text = "ERROR: Arithmetic symbols cant go before |)| "
                            error_is = "true"
                            Return "error"
                    End Select
                End If
            Next i
        Catch
            acalc.answerbox.Text = "Error: Bracket Use Mishandled"
            error_is = "true"
            Return "error"
        End Try
        Return bcheck
    End Function


    Function dotok(check As String) As String

        Try
            REM
            REM This PROCEDURE: 1) FInds for all places where .'s should be corrected
            REM

            Dim i As Integer

            REM to put 0 in the beggining for the input string if {.} comes first
            If Mid(check, 1, 1) = "." Then
                Select Case Mid(check, 2, 1)
                    Case "0" To "9"
                        check = "0" + check
                End Select
            End If
            REM to put 0 in the last
            If Mid(check, Len(check), 1) = "." Then
                Select Case Mid(check, Len(check) - 1, 1)
                    Case "0" To "9"
                        check = check + "0"
                End Select
            End If

            REM this part: 1) puts 0 on one side of the . where it lacks
            REM            2) checks for this type of dot errors: 4+.+5
            REM---------------------------------------------------------------------------------------------------
            i = 1
            Do
                Dim t1 As String = Mid(check, i, 1)
                Dim t2 As String = Mid(check, i + 1, 1)
                Dim t3 As String = Mid(check, i + 2, 1)
                Dim flag1 As String = "false", flag2 As String = "false"

                If t2 = "." Then
                    Select Case t1
                        Case "0" To "9", "."
                        Case Else
                            flag1 = "true"
                    End Select
                    Select Case t3
                        Case "0" To "9", "."
                        Case Else
                            flag2 = "true"
                    End Select

                    Dim j As Integer = Len(check) - i
                    If flag1 = "true" And flag2 = "false" Then
                        temp = Left(check, i) + "0" + Right(check, j)
                        check = temp
                    ElseIf flag2 = "true" And flag1 = "false" Then
                        temp = Left(check, i + 1) + "0" + Right(check, j - 1)
                        check = temp
                    ElseIf flag1 = "true" And flag2 = "true" Then
                        acalc.answerbox.Text = "Error: Both sides of |.| dont have any numbers"
                        error_is = "true"
                        Return "error"
                    End If
                End If
                i = i + 1
            Loop While i <= (Len(check) - 2)
        Catch
            acalc.answerbox.Text = "Error: Syntax error"
            error_is = "true"
            Return "error"
        End Try
        Return check
    End Function


    Private Function err(check As String)

        Try

            Dim i As Integer

            REM
            REM THIS SUB: 1) finds all the errors that exist in the user input except bracket errors
            REM

            REM---------------------------------------------------------------------------------------------------
            REM for checking error when (*),(/),(^) cant goes after (+), (-), (*), (/), (^)
            Dim error_string As String = ""
            For i = 1 To (Len(check) - 1)
                temp = Mid(check, i, 1)
                Dim temp2 As String = Mid(check, i + 1, 1)
                If temp = "+" Or temp = "-" Or temp = "*" Or temp = "/" Or temp = "^" Then
                    If temp2 = "*" Or temp2 = "/" Or temp2 = "^" Then
                        error_string = "success"
                    End If
                End If
            Next i
            If error_string = "success" Then
                acalc.answerbox.Text = "ERROR: (*),(/),(^) cant go after (+), (-), (*), (/), (^)"
                error_is = "true"
                Return "error"
            End If
            REM---------------------------------------------------------------------------------------------------

            REM---------------------------------------------------------------------------------------------------
            REM  to find erros when ther are no arithmetic symbols between to consecutive |.|s
            For i = 1 To Len(check)
                Dim t As String = Mid(check, i, 1)
                If t = "." Then
                    Dim j As Integer = i
                    Dim a As String = ""
                    temp = Mid(check, j, 1)
                    a = a + temp
                    Do
                        j = j + 1
                        temp = Mid(check, j, 1)
                        a = a + temp
                    Loop While temp <> "." And (j <= Len(check))

                    Dim no As Integer = 0
                    For j = 1 To Len(a)
                        Dim buff As String = Mid(a, j, 1)
                        If buff = "." Then no = no + 1
                    Next j

                    If no >= 2 Then
                        Dim count As Integer = 0
                        For j = 1 To Len(a)
                            Dim ch As String = Mid(a, j, 1)
                            Select Case ch
                                Case "0" To "9", "."
                                Case Else
                                    count = count + 1
                            End Select
                        Next j
                        If count = 0 Then
                            acalc.answerbox.Text = "ERROR: No arithmetic symbols between to consecutive |.|s"
                            error_is = "true"
                            Return "error"
                        End If
                    End If
                End If
            Next i
            REM---------------------------------------------------------------------------------------------------


            REM---------------------------------------------------------------------------------------------------
            REM ehen nothing goes before or after *,/,^ at the 1st position or last position of string
            Dim fchar As String = Mid(check, 1, 1)
            Dim lchar As String = Mid(check, Len(check), 1)
            If fchar = "*" Or fchar = "/" Or fchar = "^" Then
                acalc.answerbox.Text = " Error: Something should go before |*|, |/|, |^| "
                error_is = "true"
                Return "error"
            ElseIf lchar = "*" Or lchar = "/" Or lchar = "^" Or lchar = "+" Or lchar = "-" Then
                acalc.answerbox.Text = "ERROR: Something should go after |*|, |/|, |^|, |+|, |-|"
                error_is = "true"
                Return "error"
            End If
            REM---------------------------------------------------------------------------------------------------

            REM---------------------------------------------------------------------------------------------------
            REM for error when (.)'s left and right side dont have numbers
            check = dotok(check)
            For i = 1 To (Len(check) - 2)
                Dim t1 As String = Mid(check, i, 1)
                Dim t2 As String = Mid(check, i + 1, 1)
                Dim t3 As String = Mid(check, i + 2, 1)

                If t1 = "(" Or t1 = ")" Or t1 = "^" Or t1 = "/" Or t1 = "*" Or t1 = "+" Or t1 = "-" Then
                    If t2 = "." Then
                        If t3 = "(" Or t3 = ")" Or t3 = "^" Or t3 = "/" Or t3 = "*" Or t3 = "+" Or t3 = "-" Then
                            acalc.answerbox.Text = "ERROR: (.)'s left and right side dont have numbers"
                            error_is = "true"
                            Return "error"
                        End If
                    End If
                End If
            Next i
        Catch
            acalc.answerbox.Text = "ERROR: Syntax Error"
            error_is = "true"
            Return "error"
        End Try
        Return check
        REM---------------------------------------------------------------------------------------------------
    End Function



    Function bokhand(bocheck) As String
        REM
        REM THIS FUNCTION: 1) Corrects all bracket issues for correct calculation
        REM

        REM---------------------------------------------------------------------------------------------------
        REM this part makes eg: (9+6*5)8 as (9+6*5)*8
        Dim i As Integer
        Dim L As Integer
        Dim j As Integer
        Dim t1 As String, t2 As String

        i = 1
        temp = ""
        Do
            t1 = Mid(bocheck, i, 1)
            t2 = Mid(bocheck, i + 1, 1)
            L = Len(bocheck)
            j = L - i
            If t1 = ")" Then
                Select Case t2
                    Case "0" To "9", "("
                        temp = Left(bocheck, i) + "*" + Right(bocheck, j)
                        bocheck = temp
                End Select
            End If
            i = i + 1
        Loop While i <= (Len(bocheck) - 1)
        REM---------------------------------------------------------------------------------------------------

        REM---------------------------------------------------------------------------------------------------
        REM this part makes eg: 8(9+6*5) as 8*(9+6*5)
        i = 1 : temp = ""
        Do
            t1 = Mid(bocheck, i, 1)
            t2 = Mid(bocheck, i + 1, 1)
            L = Len(bocheck)
            j = L - i
            If t2 = "(" Then
                Select Case t1
                    Case "0" To "9"
                        temp = Left(bocheck, i) + "*" + Right(bocheck, j)
                        bocheck = temp
                End Select
            End If
            i = i + 1
        Loop While i <= (Len(bocheck) - 1)
        REM---------------------------------------------------------------------------------------------------
        Return bocheck
    End Function


    Public Function okhand(ocheck As String) As String
        REM
        REM THIS FUNCITON : 1) solves for issues like 5++++-6

        REM---------------------------------------------------------------------------------------------------
        Dim i As Integer

        i = 1

        Do
            Dim t1 As String = Mid(ocheck, i, 1)
            Dim t2 As String = Mid(ocheck, i + 1, 1)
            Dim flag As String = "false"
            Dim L As Integer = Len(ocheck)
            Dim j As Integer = L - (i + 1)
            If (t1 = "+" Or t1 = "-") And (t2 = "+" Or t2 = "-") Then
                flag = "true"
                Select Case t1
                    Case "+"
                        If t2 = "+" Then
                            temp = Left(ocheck, i - 1) + "+" + Right(ocheck, j)
                        ElseIf t2 = "-" Then
                            temp = Left(ocheck, i - 1) + "-" + Right(ocheck, j)
                        End If
                    Case "-"
                        If t2 = "+" Then
                            temp = Left(ocheck, i - 1) + "-" + Right(ocheck, j)
                        ElseIf t2 = "-" Then
                            temp = Left(ocheck, i - 1) + "+" + Right(ocheck, j)
                        End If
                End Select
            End If
            If flag = "true" Then
                i = i
                ocheck = temp
            Else
                i = i + 1
            End If
        Loop While i <= (Len(ocheck) - 1)
        REM---------------------------------------------------------------------------------------------------
        Return ocheck
    End Function

    Function finum(position As Integer, a As String) As Double
        REM
        REM THis funciton: 1) Takes out first variable to calculate
        REM                   using the position from where the left
        REM                   side numbers are takenn out
        REM
        REM---------------------------------------------------------------------------------------------------
        Dim n1 As String = ""
        Try
            Dim i As Integer
            Dim tru As String = "true"
            i = 1
            Dim t As String = Mid(a, position - 1, i) ' get the first character from the left side
            Do
                n1 = t + n1 'add to the main string
                i = i + 1
                t = Mid(a, position - i, 1) ' keep extracting number from the left side
                If t = "+" Or t = "-" Then
                    n1 = t + n1
                End If
                Select Case t
                    Case "0" To "9", "."
                    Case Else
                        tru = "false" 'give a flag when other characters are found
                End Select
            Loop While tru = "true"
        Catch
        End Try
        REM---------------------------------------------------------------------------------------------------
        rn1 = n1 ' assign the extracted number to rn1-which is a global variable
        finum = Val(n1)
    End Function

    Function senum(position As Integer, a As String) As Double
        REM
        REM THis funciton: 1) Takes out second variable to calculate
        REM                   using the position from where the right
        REM                   side numbers are taken out
        REM

        REM---------------------------------------------------------------------------------------------------
        REM to take out second variable to calculate
        Dim i As Integer
        Dim n2 As String = ""
        Try
            Dim tru As String = "true"
            i = 1
            Dim t As String = Mid(a, position + 1, i) ' get the first character from the right side
            Do
                n2 = n2 + t 'add to the main string
                i = i + 1
                t = Mid(a, position + i, 1) ' keep extracting number from the left side
                Select Case t
                    Case "0" To "9", "."
                    Case Else
                        tru = "false" 'give a flag when other characters are found
                End Select
            Loop While tru = "true"
        Catch
        End Try
        REM---------------------------------------------------------------------------------------------------
        rn2 = n2 ' assign the extracted number to rn1-which is a global variable
        senum = Val(n2)
    End Function


    Function finalpart(calc As String) As String

        REM --------------------------------------
        ' this was needed to make sure calculation is correct when finalpart was directly invoked
        'from the quadratic equation
        calc = fstep(calc)
        If calc = "error" Then Return "0"
        'calc = calc + "+0"
        calc = dotok(calc)
        If calc = "error" Then Return "0"
        calc = bokhand(calc)
        If calc = "error" Then Return "0"
        REM -------------------------------------

        REM
        REM THIS FUNCITON: 1) It is the procedure which is responsible for managing
        REM                   brackets by sending data within the brackets to calcpart
        REM                   for calculation
        REM                2) Also it checks the fault when bracket numbers are equal but
        REM                   there are faults, eg: 3456) + 546+(56
        REM
        Dim i As Integer
        Dim t As String

        Dim leftbrac As Integer, rightbrac As Integer

        bracstep = "false"
        REM---------------------------------------------------------------------------------------------------
        Do
            Dim lb As Integer = 0, rb As Integer = 0
            Dim tos As Integer = 0
            For i = 1 To Len(calc)
                t = Mid(calc, i, 1)
                Select Case t
                    Case "("
                        lb = lb + 1 'Count no of ( brackets
                    Case ")"
                        rb = rb + 1 'Count no of ) brackets
                End Select
            Next i
            If lb > 0 And rb > 0 And lb = rb Then
                Dim l As Integer = Len(calc)
                Dim los As Integer = 0, ros As Integer = 0
                Do
                    t = Mid(calc, l, 1)
                    If t = "(" Then
                        los = l ' find position of ( bracket from the rightmost side
                    End If
                    l = l - 1
                Loop While l >= 1 And los = 0
                tos = los
                ros = 0

                Do
                    t = Mid(calc, tos, 1)
                    If t = ")" Then
                        ros = tos ' find position of ) bracket starting from the postion where we found ( bracket
                    End If
                    tos = tos + 1
                Loop While tos <= Len(calc) And ros = 0


                If los > 0 And ros > 0 Then
                    Dim bybrac As String = ""
                    For i = (los + 1) To (ros - 1)
                        bybrac = bybrac + Mid(calc, i, 1) 'get the data inside the brackets
                    Next i
                    bracstep = "true"
                    REM this string is needed to replace it with the answer in the main string
                    Dim mainbrac As String = "(" + bybrac + ")"


                    REM these two strings are universal and are needed in calcpart to join each calculation
                    REM with the obtaining result in calcpart
                    left_of_bracket = Left(calc, los) 'extract all string from left of ( bracket
                    right_of_bracket = Right(calc, Len(calc) - (ros - 1)) ' extract all string from right of ) bracket

                    Dim ans As String = calcpart(bybrac) ' find the answer of the problem within the brackets
                    If ans = "error" Then Return "error"

                    los = InStr(calc, mainbrac) ' find the position of the required text with brackets which we got the answer
                    ros = Len(calc) - (los - 1) - Len(mainbrac) ' get ending postion of the string to be replaced from the right side
                    calc = tempmain(calc, mainbrac, ans, los, ros) ' get the replaced string


                    Using writer As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
                        writer.WriteLine(okhand(calc))
                    End Using

                Else
                    acalc.answerbox.Text = "ERROR: Bracket pairs unmanaged" ' if one of them is not greater than 0 it means error condition is satisfied
                    error_is = "true"
                    Return "error"
                End If
            ElseIf lb <> rb Then
                acalc.answerbox.Text = "ERROR: '(' & ')' not equal"
                error_is = "true"
                Return "error"
            End If
            leftbrac = InStr(calc, "(")
            rightbrac = InStr(calc, ")")
        Loop While leftbrac <> 0 Or rightbrac <> 0
        REM---------------------------------------------------------------------------------------------------
        bracstep = "false"
        Return calcpart(calc)
    End Function

    Function calcpart(x As String) As String
        REM---------------------------------------------------------------------------------------------------
        'x = "0+" + x
        x = okhand(x)
        Using writer As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
        End Using

        Dim i As Integer
        Dim ca As String = ""

        For recap As Integer = 1 To 2 ' this is needed so that addition would carried out efficiently
            For i = 1 To 5
                REM going according to hierchy
                Select Case i
                    Case 1
                        ca = "^"
                    Case 2
                        ca = "/"
                    Case 3
                        ca = "*"
                    Case 4
                        ca = "+"
                    Case 5
                        ca = "-"
                End Select

                Dim c As Integer
                c = 0
                For j As Integer = 1 To Len(x)
                    If Mid(x, j, 1) = ca Then
                        c = c + 1 ' count number of required arithmetic symbol
                    End If
                Next j

                Dim for_plus_minus As Integer
                Dim symbol_position As Integer
                for_plus_minus = 1 'a seperate counter to count position of plus and minus from the beginning
                For j = 1 To c
                    x = okhand(x)
                    If ca <> "-" And ca <> "+" Then
                        symbol_position = InStr(x, ca)
                    Else
                        REM this block is a special case for addition and subtraction
                        Dim position_found As String
                        position_found = "not_found" 'initialize flag
                        Do While position_found = "not_found"
                            If Mid(x, for_plus_minus, 1) = ca Then ' if + or - is found
                                symbol_position = for_plus_minus ' we got the position now
                                position_found = "found" ' change flag
                                for_plus_minus = 2 ' if any other symbol exist then they should start from
                                REM                   second postion because first position may be ocuupied
                            Else
                                for_plus_minus = for_plus_minus + 1
                            End If
                        Loop
                    End If

                    Dim num1 As Double, num2 As Double
                    Dim an As Double
                    num1 = finum(symbol_position, x) ' extract the first number from left side of the symbol
                    num2 = senum(symbol_position, x) ' extract the second number from right side of the symbol
                    If ca = "^" Then
                        Dim powerminus As String = "false" ' special case for ^ because - needs to done seperately
                        If num1 < 0 Then
                            num1 = -num1
                            powerminus = "true"
                        End If

                        'If num2 < 0 Then
                        '    ACalcG1.answerbox.Text = "Undefined"
                        '    error_is = "true"
                        '    Me.initial("")
                        'End If
                        an = num1 ^ num2
                        'If powerminus = "true" Then an = -an
                    ElseIf ca = "/" Then
                        If num2 <> 0 Then
                            an = num1 / num2
                        Else
                            acalc.answerbox.Text = "Error: Division by 0"
                            error_is = "true"
                            Return "error"
                        End If
                    ElseIf ca = "*" Then
                        an = num1 * num2
                    ElseIf ca = "+" Then
                        an = num1 + num2
                    ElseIf ca = "-" Then
                        an = num1 - num2
                    End If

                    Dim value As String, small As String
                    Dim lmainpos As Integer, rmainpos As Integer
                    value = Str(an)
                    value = LTrim(RTrim(value))
                    value = "+" + value
                    value = okhand(value)
                    value = dotok(value)
                    small = rn1 + ca + rn2 ' concatenate symbol with the string changed in finum and senum
                    small = okhand(small)

                    lmainpos = InStr(x, small) ' find position of the string we got answer from the left side
                    rmainpos = (lmainpos - 1) + Len(small)
                    rmainpos = Len(x) - rmainpos ' find ending position of the string we got answer from the right side

                    x = tempmain(x, small, value, lmainpos, rmainpos) ' get the required replaced string
                    x = okhand(x)
                    If bracstep = "false" Then
                        Using writer As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
                            writer.WriteLine(okhand(x))
                        End Using
                    Else
                        REM when this module was called for doing calculation of brackets then
                        REM answer together with the bracket result should also be written which is done by this
                        Dim bracket_answer As String
                        bracket_answer = left_of_bracket + x + right_of_bracket
                        bracket_answer = okhand(bracket_answer)
                        Using writer As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
                            writer.WriteLine(okhand(bracket_answer))
                        End Using
                    End If
                Next j
            Next i
        Next recap
        Return x
    End Function




    Function tempmain(big As String, small As String, ans As String, l As Integer, r As Integer) As String
        REM this module takes the main string, string to replace with ans
        REM and the position where from to replace
        REM since this calculator follows step by step procedure for calulation,
        REM one calculation takes place and value is replaced afterwards
        REM eg:
        REM 4+5*6, here 5*6 is done first and it is replaced by 30, ie the
        REM string will now be 4+30.
        REM here 4+5*6 is the big$, 5*6 is the small$, 30 is ans$ and lf is position
        REM where small$ starts and r is the position where it ends

        REM---------------------------------------------------------------------------------------------------
        Dim a As String = ""
        If l <> 1 And Len(big) <> Len(small) Then
            a = Left(big, l - 1) + ans + Right(big, r)
        ElseIf Len(small) = Len(big) Then
            a = ans
        ElseIf l = 1 Then
            a = ans + Right(big, r)
        End If
        REM---------------------------------------------------------------------------------------------------
        Return a
    End Function
End Class

Class word_generation

    REM global variables for generating words
    Public Shared dotzero As String
    'COMMON SHARED bracstep$
    Public Shared universaltenszero, universal_eng_zero As String

    Function handleword(v As Double) As String

        Dim word As String

        dotzero = "false"
        Dim minusvalue As String = ""

        If v < 0 Then
            minusvalue = "-"
            v = v * -1
        End If
        word = LTrim(Str(v))

        Dim after As String = "", before As String = ""
        Dim posofdot As Integer = InStr(word, ".")
        Dim beforedec As String
        Dim afterdec As String
        If posofdot > 0 Then
            dotzero = "true"
            beforedec = Left(word, posofdot - 1)
            afterdec = Right(word, Len(word) - posofdot)
            For i = 1 To Len(afterdec)
                after = after + generateword(Mid(afterdec, i, 1))
            Next i
        Else
            beforedec = word
        End If

        Dim wordtype As String = ""
        If File.ReadAllText("ACalc_Files/settings.txt").Length <> 0 Then
            Using reader As StreamReader = New StreamReader("ACalc_Files/settings.txt")
                Dim dipslaytype As String = reader.ReadLine
                wordtype = reader.ReadLine
            End Using
        End If

        Dim value_type As String = ""

        Dim t1 As String, t2 As String
        Dim temp As String


        If wordtype = "2" Then
            REM to generate nepali word ----------------------------------------------

            'make sure the string is odd because the modules take the odd data to generate
            ' equivalent word so there may be problem.
            If (Len(beforedec) Mod 2 = 0) Or (Len(beforedec) = 1) Then
                beforedec = "0" + beforedec
            End If

            word = beforedec
            Do Until Len(word) = 0
                Select Case Len(word)
                    Case 15 : value_type = " nil"
                    Case 13 : value_type = " kharba"
                    Case 11 : value_type = " arba"
                    Case 9 : value_type = " crore"
                    Case 7 : value_type = " lakh"
                    Case 5 : value_type = " thousand"
                    Case 3 : value_type = " hundred"
                    Case 2 : value_type = ""
                End Select
                ' start generating word for each length
                t1 = Mid(word, 1, 1)
                t2 = Mid(word, 2, 1)

                If Len(word) = 3 Then
                    temp = generateword(t1)
                    If t1 = "0" Then
                        before = before + temp
                    Else
                        before = before$ + temp + value_type
                    End If
                    word = Right(word, Len(word) - 1)
                Else
                    temp = generateword(t1 + t2)
                    If temp = "" Then
                        before = before + temp
                    Else
                        before = before + temp + value_type
                    End If
                    word = Right(word, Len(word) - 2)
                End If
            Loop
        Else
            REM to generate english word ----------------------------------------------

            If Len(beforedec) Mod 3 = 1 Then
                beforedec = "00" + beforedec
            ElseIf Len(beforedec) Mod 3 = 2 Then
                beforedec = "0" + beforedec
            End If
            word = beforedec
            Dim temp_t1 As String, temp_t2 As String
            Do Until Len(word) = 0
                Select Case Len(word)
                    Case 15 : value_type = " Trillion"
                    Case 12 : value_type = " Billion"
                    Case 9 : value_type = " Million"
                    Case 6 : value_type = " Thousand"
                    Case 3 : value_type = ""
                End Select

                t1 = Mid(word, 1, 1)
                t2 = Mid$(word, 2, 2)

                temp_t1 = generateword(t1)
                temp_t2 = generateword(t2)

                If temp_t1 = "" And temp_t2 = "" Then
                    before = before
                ElseIf temp_t1 = "" Then
                    before = before + temp_t2 + value_type
                Else
                    before = before + temp_t1 + " hundred" + temp_t2 + value_type
                End If
                word = Right(word, Len(word) - 3)
            Loop
        End If
        If before = Nothing Then before = "Zero"

        Dim word_return As String ' variable to return word value
        If posofdot > 0 Then
            word_return = "= " + minusvalue + LTrim(before) + "." + LTrim(after)
        Else
            word_return = "= " + minusvalue + LTrim(before)
        End If
        Return LTrim(word_return)
    End Function



    Function generateword(a) As String
        Dim nu As Double = Val(a)
        Dim word_value As String = ""
        Select Case nu
            Case 0
                If dotzero = "true" Then
                    word_value = " Zero"
                Else
                    word_value = ""
                End If
            Case 1 : word_value = " One"
            Case 2 : word_value = " Two"
            Case 3 : word_value = " Three"
            Case 4 : word_value = " Four"
            Case 5 : word_value = " Five"
            Case 6 : word_value = " Six"
            Case 7 : word_value = " Seven"
            Case 8 : word_value = " Eight"
            Case 9 : word_value = " Nine"
            Case 10 : word_value = " Ten"
            Case 11 : word_value = " Eleven"
            Case 12 : word_value = " Twelve"
            Case 13 : word_value = " Thirteen"
            Case 14 : word_value = " Fourteen"
            Case 15 : word_value = " Fifteen"
            Case 16 : word_value = " Sixteen"
            Case 17 : word_value = " Seventeen"
            Case 18 : word_value = " Eighteen"
            Case 19 : word_value = " Nineteen"
            Case 20 : word_value = " Twenty"
            Case 21 : word_value = " TwentyOne"
            Case 22 : word_value = " Twentytwo"
            Case 23 : word_value = " TwentyThree"
            Case 24 : word_value = " TwentyFour"
            Case 25 : word_value = " TwentyFive"
            Case 26 : word_value = " TwentySix"
            Case 27 : word_value = " TwentySeven"
            Case 28 : word_value = " TwentyEight"
            Case 29 : word_value = " TwentyNine"
            Case 30 : word_value = " Thirty"
            Case 31 : word_value = " ThirtyOne"
            Case 32 : word_value = " ThirtyTwo"
            Case 33 : word_value = " ThirtyThree"
            Case 34 : word_value = " ThirtyFour"
            Case 35 : word_value = " ThirtyFive"
            Case 36 : word_value = " ThirtySix"
            Case 37 : word_value = " ThirtySeven"
            Case 38 : word_value = " ThirtyEight"
            Case 39 : word_value = " ThirtyNine"
            Case 40 : word_value = " Forty"
            Case 41 : word_value = " FortyOne"
            Case 42 : word_value = " FortyTwo"
            Case 43 : word_value = " FortyThree"
            Case 44 : word_value = " FortyFour"
            Case 45 : word_value = " FortyFive"
            Case 46 : word_value = " FortySix"
            Case 47 : word_value = " FortySeven"
            Case 48 : word_value = " FortyEight"
            Case 49 : word_value = " FortyNine"
            Case 50 : word_value = " Fifty"
            Case 51 : word_value = " FiftyOne"
            Case 52 : word_value = " FiftyTwo"
            Case 53 : word_value = " FiftyThree"
            Case 54 : word_value = " FiftyFour"
            Case 55 : word_value = " FiftyFive"
            Case 56 : word_value = " FiftySix"
            Case 57 : word_value = " FiftySeven"
            Case 58 : word_value = " FiftyEight"
            Case 59 : word_value = " FiftyNine"
            Case 60 : word_value = " Sixty"
            Case 61 : word_value = " SixtyOne"
            Case 62 : word_value = " SixtyTwo"
            Case 63 : word_value = " SixtyThree"
            Case 64 : word_value = " SixtyFour"
            Case 65 : word_value = " SixtyFive"
            Case 66 : word_value = " SixtySix"
            Case 67 : word_value = " SixtySeven"
            Case 68 : word_value = " SixtyEight"
            Case 69 : word_value = " SixtyNine"
            Case 70 : word_value = " Seventy"
            Case 71 : word_value = " SeventyOne"
            Case 72 : word_value = " SeventyTwo"
            Case 73 : word_value = " SeventyThree"
            Case 74 : word_value = " SeventyFour"
            Case 75 : word_value = " SeventyFive"
            Case 76 : word_value = " SeventySix"
            Case 77 : word_value = " SeventySeven"
            Case 78 : word_value = " SeventyEight"
            Case 79 : word_value = " SeventyNine"
            Case 80 : word_value = " Eighty"
            Case 81 : word_value = " EightyOne"
            Case 82 : word_value = " EightyTwo"
            Case 83 : word_value = " EightyThree"
            Case 84 : word_value = " EightyFour"
            Case 85 : word_value = " EightyFive"
            Case 86 : word_value = " EightySix"
            Case 87 : word_value = " EightySeven"
            Case 88 : word_value = " EightyEight"
            Case 89 : word_value = " EightyNine"
            Case 90 : word_value = " Ninety"
            Case 91 : word_value = " NinetyOne"
            Case 92 : word_value = " NinetyTwo"
            Case 93 : word_value = " NinetyThree"
            Case 94 : word_value = " NinetyFour"
            Case 95 : word_value = " NinetyFive"
            Case 96 : word_value = " NinetySix"
            Case 97 : word_value = " NinetySeven"
            Case 98 : word_value = " NinetyEight"
            Case 99 : word_value = " NinetyNine"
        End Select
        Return word_value
    End Function

End Class
