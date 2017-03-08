Imports System.IO

Public Class hcf_lcm_class


    Public Sub New()
    End Sub

    Function find_hcf(hcf_list_nums() As Double, upto_where As Integer) As Double

        Dim factors_hcf(upto_where) As String ' this is a arrray which holds the factors of all the numbers in as string each

        Using writer As StreamWriter = File.AppendText("ACalc_Files/hcf_lcm.txt")
            For i = 1 To upto_where ' go till the user's input range
                For j = 1 To hcf_list_nums(i) ' to go from 1 to the number itself to find the factors
                    If hcf_list_nums(i) Mod j = 0 Then
                        factors_hcf(i) = factors_hcf(i) + LTrim(Str(j)) + "," ' join all the factors
                    End If
                Next j
                ' since the ending of the string will have a <<,>> , it should be removed
                ' so the string is extracted to the second last position
                factors_hcf(i) = Left(factors_hcf(i), Len(factors_hcf(i)) - 1)
                writer.WriteLine(hcf_list_nums(i) & " = " & factors_hcf(i))
            Next i
        End Using

        ' <<hcf$>> holds the hcf value
        ' <<found$>> is the case when we take the user's input first numbers last factor and
        ' to checking it with the factors of other numbers. If the factor we took from the
        ' user's first input matches with the precedding term's factor then <<found$>> will have
        ' value as >>true<< since the factor matches and it will be checked with the other
        ' preceeding terms
        Dim hcf_value As String = "", found As String = "false"

        ' this is the first input's factor's string whoose factors will be taken
        ' one by one from the last and checked with other numbers
        Dim main_finder As String = factors_hcf(1)
        Dim len_of_finder As Integer = Len(main_finder) ' length of the factor's string
        Dim temp_1 As String, for_temp_1 As String
        Dim index As Integer
        Dim temp_2 As String, for_temp_2 As String
        Dim L As Integer
        Do
            ' this temp_1 holds the factors of the first input one by one which will be checked with
            ' the factors of other numbers
            temp_1 = ""

            ' temporarily hold the value from the value from the factors string to concatenate
            ' with <<temp_1>>
            for_temp_1 = Mid(main_finder, len_of_finder, 1)
            ' since the string which contains the factors of the numbers also contains comas(,) which
            ' seperate them, it should not be taken while concatenating so the loop has a condition
            ' to skip the comas
            Try
                Do While for_temp_1 <> "," And len_of_finder >= 1
                    len_of_finder = len_of_finder - 1
                    temp_1 = for_temp_1 + temp_1
                    for_temp_1 = Mid(main_finder, len_of_finder, 1)
                Loop
            Catch
            End Try

            ' since each of the user entered numbers factors are contained in a string, this index
            ' determines the factors which we will be working with
            index = 1

            Do
                ' if the index meets upto_where then it means that the program has found the hcf
                ' so the hcf should be returned to the function
                If index = upto_where Then GoTo last '...... this should be change with the module name
                index = index + 1 : found = "false"

                L = Len(factors_hcf(index))
                Do
                    temp_2 = "" ' this is the string in which our other factors will be stored
                    for_temp_2 = Mid(factors_hcf(index), L, 1) ' <<same as for_temmp_2$>>
                    Try
                        Do While for_temp_2 <> "," And L >= 1
                            L = L - 1
                            temp_2 = for_temp_2 + temp_2
                            for_temp_2 = Mid(factors_hcf(index), L, 1)
                        Loop
                    Catch
                    End Try
                    If temp_1 = temp_2 Then
                        found = "true"
                        hcf_value = temp_1
                    End If
                    L = L - 1
                Loop While L >= 1 And found = "false"
            Loop While found = "true" And L >= 1
            len_of_finder = len_of_finder - 1
        Loop While len_of_finder >= 1
last:
        Return Val(temp_1)
    End Function

    Function find_lcm(lcm_list_nums() As Double, upto_where As Integer) As Double

        Dim lcm As Double = 1

        Dim greatest As Double = lcm_list_nums(1)
        Dim i As Integer
        For i = 2 To upto_where
            If lcm_list_nums(i) > greatest Then greatest = lcm_list_nums(i)
        Next i

        ' this holds the value when a <<user entered>> number is divided by the range
        ' between 1 and the greatest entered number
        ' quotient holds the value with decimal and quotient1 holds the value without decimal
        ' these two values need to be compared and if equal then only the entered value will be divided
        ' by the number between the range
        Dim quotient As Double
        Dim quotient1 As Integer

        Dim have_to_multiply As Boolean

        ' this recap loop is neeeded to get correct result
        ' for eg: if the entered nubmers are 1,50,50 then here is the result in each run:
        ' --> 1st run   1|1,50,50
        ' --> 2nd run   2|1,50,50 
        ' --> 3rd run   3|1,25,25
        ' --> 4th run   4|1,25,25
        ' --> 5th run   5|1,25,25
        ' --> 2nd run   6|1,5,5
        ' ** So the 5 and 5 will not be divied by any other numbers which will give wrong LCM 
        ' so it is better to recap all the runs about 4 times since it is useful for larger numbers
        ' so that the mistake wont be repeated

        For recap As Integer = 1 To 20
            For i = 2 To greatest
                Do
                    have_to_multiply = False
                    For j As Integer = 1 To upto_where
                        quotient = lcm_list_nums(j) / i
                        quotient1 = lcm_list_nums(j) \ i

                        If quotient = quotient1 Then
                            have_to_multiply = True
                            lcm_list_nums(j) = lcm_list_nums(j) / i
                        End If
                    Next j
                    If have_to_multiply = True Then lcm = lcm * i
                Loop Until have_to_multiply = False
            Next i
        Next recap

        For i = 1 To upto_where
            lcm = lcm * lcm_list_nums(i)
        Next i
        Return lcm
    End Function

    Function hcf(p As Double, q As Double) As Double
top:
        Dim r As Double = p Mod q
        Do While r <> 0
            p = q
            q = r
            GoTo top
        Loop
        Return q
    End Function


End Class
