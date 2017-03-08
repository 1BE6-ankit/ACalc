Public Class Prime_Com

    Private Sub Prime_Com_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading_text.Hide()
    End Sub

    Private Sub input_box_KeyUp(sender As Object, e As KeyEventArgs) Handles input_box.KeyUp
        Dim invoke_maincalc As New main_calc
        If e.KeyCode = Keys.Enter Then
            Try
                input_box.Text = Val(invoke_maincalc.finalpart(input_box.Text))
            Catch ex As Exception
                input_box.Text = "0"
            End Try
            Call find_result(Int(Val(input_box.Text)))
        End If

    End Sub



    Sub find_result(numb As Long)
        answerbox.Clear()
        loading_text.Show()
        Me.Update()
        Try
            If numb <= 0 Then
                answerbox.AppendText("Only natural numbers are allowed")
            ElseIf numb = 1 Then
                answerbox.AppendText("1 is neither prime nor composite")
            Else
                answerbox.AppendText("Entered Number: " + Str(numb) + Environment.NewLine)

                Dim counter As Integer = 0, i As Integer
                For i = 1 To numb
                    If numb Mod i = 0 Then
                        counter = counter + 1
                    End If
                Next i

                Dim factors(counter) As Integer
                Dim c As Integer = 1
                For i = 1 To numb
                    If numb Mod i = 0 Then
                        factors(c) = i
                        c = c + 1
                    End If
                Next i


                If counter = 2 Then
                    answerbox.AppendText(Str(numb) + " is prime and has two factors. THEY are:" + Environment.NewLine)
                    answerbox.SelectionColor = Color.DarkKhaki
                    answerbox.AppendText("1, " + Str(numb))
                Else
                    answerbox.AppendText(Str(numb) + " is composite and has " + Str(counter) + " factors" + Environment.NewLine)
                    answerbox.SelectionColor = Color.Aqua
                    answerbox.AppendText("THEY are:" + Environment.NewLine)
                    Dim factor_string As String = ""
                    For i = 1 To counter - 1
                        factor_string = factor_string + Str(factors(i)) + ", "
                    Next i
                    answerbox.AppendText(factor_string + Str(numb))
                End If
            End If
        Catch
            MsgBox("Data OverFlow")
        End Try
        loading_text.Hide()
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

    Private Sub Mhcf_Click(sender As Object, e As EventArgs) Handles Mhcf.Click
        hcf_lcm_form.Show()
        hcf_lcm_form.Focus()
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