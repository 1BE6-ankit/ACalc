Public Class hcf_lcm_help

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub hcf_lcm_help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        content_box.Text = "   Things to Know before Using The HCF & LCM Finder:  " & Environment.NewLine & Environment.NewLine &
                           "1) Enter the numbers seperated by coma(,) in the input box." & Environment.NewLine &
                           "2) Only Enter whole numbers in the input box." & Environment.NewLine &
                           "3) If you enter a decimal number then the value after" & Environment.NewLine &
                           "   decimal place will be removed." & Environment.NewLine &
                           "4) If values other than numbers are entered they will be" & Environment.NewLine &
                           "   will be treated as 1." & Environment.NewLine &
                           "5) If 0 is entered then it will be treated as 1 and if a" & Environment.NewLine &
                           "   negative number is entered it's positive value is used." & Environment.NewLine

    End Sub
End Class