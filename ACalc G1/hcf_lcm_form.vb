Imports System.IO

Public Class hcf_lcm_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LTrim(input_box.Text) <> Nothing Then
            Call do_initial()
        Else
            MsgBox("The Box is Empty")
        End If
    End Sub

    Private Sub hcf_lcm_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading_text.Hide()
        If File.Exists("ACalc_Files/hcf_lcm.txt") Then File.Delete("ACalc_Files/hcf_lcm.txt")
        factors_box.Hide()
        clear_button.Hide()
    End Sub


    Public Sub do_initial()

        loading_text.Show()
        Me.Update()

        Dim entered_value As String = input_box.Text
        Dim invoke_hcf_lcm_class As New hcf_lcm_class
        Dim i As Integer

        ' 1st array stores the user entered numbers
        ' 2nd array stores the factors of those numbers in a string
        Dim hcf_list_nums(Len(entered_value) + 1) As Integer ', print_list_nums(upto_where)

        Dim len_of_finder As Integer = Len(entered_value) ' length of the factor's string
        Dim temp_1 As String = "", for_temp_1 As String = ""
        Dim counter As Integer = 1
        Try
            Do
                temp_1 = ""
                for_temp_1 = Mid(entered_value, len_of_finder, 1)
                Try
                    Do While for_temp_1 <> "," And len_of_finder >= 1
                        len_of_finder = len_of_finder - 1
                        temp_1 = for_temp_1 + temp_1
                        for_temp_1 = Mid(entered_value, len_of_finder, 1)
                    Loop
                    hcf_list_nums(counter) = Val(temp_1)
                    counter = counter + 1
                Catch e As Exception
                    hcf_list_nums(counter) = Val(temp_1)
                End Try
                len_of_finder = len_of_finder - 1
            Loop While len_of_finder >= 1


            For i = 1 To counter
                If hcf_list_nums(i) = 0 Then hcf_list_nums(i) = 1 ' TO change 0 to 1 since 0 is invalid
                If hcf_list_nums(i) < 0 Then hcf_list_nums(i) = -hcf_list_nums(i) ' change negative value to positive
            Next i

            Dim hcf_list_nums2(counter) As Double ' this array holds the double value of the numbers the user entered 
            For i = 1 To counter
                hcf_list_nums2(i) = hcf_list_nums(i)
            Next

            'Array.Reverse(hcf_list_nums2)
            Dim hcf_value As Double = invoke_hcf_lcm_class.find_hcf(hcf_list_nums2, counter)
            Dim lcm_value As Double = invoke_hcf_lcm_class.find_lcm(hcf_list_nums2, counter)

            REM --------- Resut Time ----------------------------------------
            Label1.Text = "Factors of the numbers you Entered are:"

            hcf_box.Text = hcf_value
            lcm_box.Text = lcm_value

            ' now it's time to hide input_box and the find now button
            input_box.Hide()
            Button1.Hide()

            factors_box.Show()
            clear_button.Show()

            Dim factors_array(counter) As String
            i = counter
            Using reader As StreamReader = New StreamReader("ACalc_Files/hcf_lcm.txt")
                Dim factor_string As String
                Do While Not reader.Peek
                    factor_string = reader.ReadLine
                    'factors_box.AppendText(factor_string + Environment.NewLine)
                    factors_array(i) = factor_string
                    i = i - 1
                Loop
            End Using

            For i = 1 To counter
                factors_box.AppendText(factors_array(i) + Environment.NewLine + Environment.NewLine)
            Next i
        Catch ee As Exception
            MsgBox(ee.Message)
        End Try
        loading_text.Hide()
    End Sub



    Private Sub clear_button_Click(sender As Object, e As EventArgs) Handles clear_button.Click

        Label1.Text = "Enter The Numbers Seperated By Comma(,) in the box below"

        factors_box.Text = Nothing
        factors_box.Hide()
        clear_button.Hide()

        input_box.Show()
        Button1.Show()

        File.Delete("ACalc_Files/hcf_lcm.txt")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim invoke_hcf_lcf_help As New hcf_lcm_help
        invoke_hcf_lcf_help.ShowDialog()
    End Sub

    Private Sub Fexit_Click(sender As Object, e As EventArgs) Handles Fexit.Click
        Me.Close()
    End Sub

    Private Sub MMain_Click(sender As Object, e As EventArgs) Handles MMain.Click
        acalc.Show()
        acalc.Focus()
    End Sub

    Private Sub Mquad_Click(sender As Object, e As EventArgs) Handles Mquad.Click
        quad_form.Show()
        quad_form.Focus()
    End Sub

    Private Sub Mprime_Click(sender As Object, e As EventArgs) Handles Mprime.Click
        Prime_Com.Show()
        Prime_Com.Focus()
    End Sub

    Private Sub Mhcf_Click(sender As Object, e As EventArgs) Handles Mhcf.Click
        Dim invoke_hcf_lcm As New hcf_lcm_form
        invoke_hcf_lcm.Show()
    End Sub

    Private Sub Mchist_Click(sender As Object, e As EventArgs) Handles Mchist.Click
        Dim display_history As New history
        display_history.ShowDialog()
    End Sub

    Private Sub Mcdelhist_Click(sender As Object, e As EventArgs) Handles Mcdelhist.Click
        Dim delhistory As history_delete
        delhistory = New history_delete
        delhistory.delete_history()
    End Sub

    Private Sub menuhelp_Click(sender As Object, e As EventArgs) Handles menuhelp.Click
        user_manual.Show()
        user_manual.Focus()
    End Sub

End Class