Imports System.IO
Imports System.Drawing

Public Class process_window

    Private Sub process_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim invove_maincalc As New main_calc

        Dim stepprint As String, toskip As String = ""

        ' rem print the main string at the beginning
        Using reader As StreamReader = New StreamReader("ACalc_Files/temphistory.txt")
            stepprint = reader.ReadLine
            display_box.AppendText("   " & stepprint & Environment.NewLine)
        End Using

        Dim l As Integer
        Using reader As StreamReader = New StreamReader("ACalc_Files/temphistory.txt")
            stepprint = reader.ReadLine ' skip the first line because it is already printed

            Dim counter As Integer = 1
            Do While Not reader.Peek
                stepprint = reader.ReadLine


                l = Len(stepprint)
                If l - 1 = 0 Then l = 1 Else l = l - 1
                If Mid(stepprint, l, 2) = "+0" Then
                    stepprint = Mid(stepprint, 1, Len(stepprint) - 2)
                End If

                If Mid(stepprint, 1, 1) = "+" Then
                    stepprint = Mid(stepprint, 2, Len(stepprint) - 1)
                End If

                If Mid(stepprint, 1, 2) = "0+" Then
                    stepprint = Mid(stepprint, 3, Len(stepprint) - 2)
                End If


                REM this part removes plus from something like this(6*+4)
                Dim position_read As Integer = 1
                Dim to_change As String
                Dim left_value As String, right_value As String
                Do
                    to_change = Mid(stepprint, position_read, 1) 'to get postion of *,/,^
                    Select Case to_change
                        Case "^", "/", "*", "(" ' when we get then:
                            If Mid(stepprint, position_read + 1, 1) = "+" Then
                                left_value = Mid(stepprint, 1, position_read)
                                right_value = Mid(stepprint, position_read + 2, Len(stepprint) - (position_read + 1))
                                stepprint = left_value + right_value
                            End If
                    End Select
                    position_read = position_read + 1
                Loop While position_read < (Len(stepprint))

                position_read = 1
                Do
                    to_change = Mid(stepprint, position_read, 1) 'to get postion of *
                    Select Case to_change 'to remove * from : 4*(4)
                        Case "*"
                            If Mid(stepprint, position_read + 1, 1) = "(" Then
                                left_value = Mid(stepprint, 1, position_read - 1)
                                right_value = Mid(stepprint, position_read + 1, Len(stepprint) - position_read)
                                stepprint = left_value + right_value
                            End If
                    End Select
                    position_read = position_read + 1
                Loop While position_read < (Len(stepprint))
                If stepprint = toskip Or stepprint = "" Then GoTo Skip
                If counter Mod 2 = 1 Then
                    display_box.SelectionColor = Color.Goldenrod
                Else
                    display_box.SelectionColor = Color.Orange
                End If
                display_box.AppendText(" = " & stepprint & Environment.NewLine)
                counter += 1
Skip:
                toskip = stepprint
            Loop
        End Using
        File.Delete("ACalc_Files/temphistory.txt")
    End Sub
End Class