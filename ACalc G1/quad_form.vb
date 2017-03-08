Public Class quad_form

    Public invoke_maincalc As New main_calc


    Private Sub text_a_KeyUp(sender As Object, e As KeyEventArgs) Handles text_a.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call for_a_value()
        End If
    End Sub
    Private Sub text_a_Leave(sender As Object, e As EventArgs) Handles text_a.Leave
        Call for_a_value()
    End Sub

    Private Sub text_b_KeyUp(sender As Object, e As KeyEventArgs) Handles text_b.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call for_b_value()
        End If
    End Sub
    Private Sub text_b_Leave(sender As Object, e As EventArgs) Handles text_b.Leave
        Call for_b_value()
    End Sub

    Private Sub text_c_KeyUp(sender As Object, e As KeyEventArgs) Handles text_c.KeyUp
        If e.KeyCode = Keys.Enter Then
            Call for_c_value()
        End If
    End Sub
    Private Sub text_c_MouseEnter(sender As Object, e As EventArgs) Handles text_c.MouseEnter
        Call for_c_value()
    End Sub


    Private Sub for_a_value()
        Try
            text_a.Text = Val(invoke_maincalc.finalpart(text_a.Text))
        Catch ex As Exception
            text_a.Text = "0"
        End Try
        text_b.Focus()
        Call dynamic_text()
    End Sub
    Private Sub for_b_value()
        Try
            text_b.Text = Val(invoke_maincalc.finalpart(text_b.Text))
        Catch ex As Exception
            text_b.Text = "0"
        End Try
        text_c.Focus()
        Call dynamic_text()
    End Sub
    Private Sub for_c_value()
        Try
            text_c.Text = Val(invoke_maincalc.finalpart(text_c.Text))
        Catch ex As Exception
            text_c.Text = "0"
        End Try
        Equate.Focus()
        Call dynamic_text()
    End Sub

    Sub dynamic_text()
        Dim aa As String = Str(Val(text_a.Text)) + "x²"

        Dim bb As String
        If Val(text_b.Text) < 0 Then
            bb = " - " + Str(Val(text_b.Text) * -1) + "x"
        Else
            bb = " + " + Str(Val(text_b.Text)) + "x"
        End If

        Dim cc As String
        If Val(text_c.Text) < 0 Then
            cc = " - " + Str(Val(text_c.Text) * -1)
        Else
            cc = " + " + Str(Val(text_c.Text))
        End If

        dynamic_box.Text = aa + bb + cc + " = 0"
    End Sub

    Private Sub Equate_Click(sender As Object, e As EventArgs) Handles Equate.Click
        Dim invoke_quad As quad_handle
        invoke_quad = New quad_handle
        invoke_quad.quad(Val(text_a.Text), Val(text_b.Text), Val(text_c.Text))
    End Sub


    Private Sub Fexit_Click(sender As Object, e As EventArgs) Handles Fexit.Click
        Me.Close()
    End Sub

    Private Sub MMain_Click(sender As Object, e As EventArgs) Handles MMain.Click
        acalc.Show()
        acalc.Focus()
    End Sub

    Private Sub Mprime_Click(sender As Object, e As EventArgs) Handles Mprime.Click
        Prime_Com.Show()
        Prime_Com.Focus()
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

    Private Sub quad_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        text_a.Focus()
    End Sub
End Class