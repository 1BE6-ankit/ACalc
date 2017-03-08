Public Class quad_handle

    Public Sub New()
    End Sub

    Public Sub quad(a As Double, b As Double, c As Double)
        If a <> 0 Then
            If c <> 0 Then
                If b <> 0 Then
                    Dim invoke_nothing_zero As New nothing_zero(a, b, c)
                    invoke_nothing_zero.Show()
                Else
                    Dim invoke_b_iszero As New b_iszero(a, c)
                    invoke_b_iszero.Show()
                End If
            Else
                Dim invoke_c_iszero As New c_iszero(a, b)
                invoke_c_iszero.Show()
            End If
        Else
            MsgBox("Not a quadratic Equation")
        End If

    End Sub

End Class
