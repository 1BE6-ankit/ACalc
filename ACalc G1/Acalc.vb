REM by ankit koirala
REM started on 30th march 2015

Imports System.IO

Public Class acalc
    ' to write & read in the file

    Public universalinput As String

    Dim invoke_maincalc As main_calc




    Private Sub ACalcG1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REM ---------------------------------------------------------------
        REM THIS block: 1) Check's whether user settings exist    
        REM             2) IF not creates new file to store settings

        If (Not Directory.Exists("ACalc_Files")) Then
            Directory.CreateDirectory("ACalc_Files")
        End If


        Using reader As StreamWriter = File.AppendText("ACalc_Files/settings.txt")
        End Using
        If File.ReadAllText("ACalc_Files/settings.txt").Length = 0 Then
            Using writer As StreamWriter = New StreamWriter("ACalc_Files/settings.txt")
                writer.WriteLine("1")
                writer.WriteLine("1")
            End Using
        End If


        REM -- to store history of love calculator and main calculator
        Using reader As StreamWriter = File.AppendText("ACalc_Files/history.txt")
        End Using
        If File.Exists("ACalc_Files/temphistory.txt") Then File.Delete("ACalc_Files/temphistory.txt")
        Using reader As StreamWriter = File.AppendText("ACalc_Files/temphistory.txt")
        End Using
        REM ---------------------------
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "1"
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "2"
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "3"
    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "4"
    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "5"
    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "6"
    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "7"
    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "8"
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles B9.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "9"
    End Sub

    Private Sub B0_Click(sender As Object, e As EventArgs) Handles B0.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "0"
    End Sub

    Private Sub Bdot_Click(sender As Object, e As EventArgs) Handles Bdot.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "."
    End Sub

    Private Sub BLb_Click(sender As Object, e As EventArgs) Handles BLb.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "("
    End Sub

    Private Sub BRb_Click(sender As Object, e As EventArgs) Handles BRb.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + ")"
    End Sub

    Private Sub BAdd_Click(sender As Object, e As EventArgs) Handles BAdd.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "+"
    End Sub

    Private Sub BMinus_Click(sender As Object, e As EventArgs) Handles BMinus.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "-"
    End Sub

    Private Sub Bmul1_Click(sender As Object, e As EventArgs) Handles Bmul1.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "*"
    End Sub

    Private Sub Bmul2_Click(sender As Object, e As EventArgs) Handles Bmul2.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "x"
    End Sub

    Private Sub BKar_Click(sender As Object, e As EventArgs) Handles Bkar.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "^"
    End Sub

    Private Sub BDiv_Click(sender As Object, e As EventArgs) Handles BDiv.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "/"
    End Sub

    Private Sub BPer_Click(sender As Object, e As EventArgs) Handles BPer.Click
        Call valuecheck()
        inputbox.Text = inputbox.Text + "%"
    End Sub


    Private Sub BDel_Click(sender As Object, e As EventArgs)
        Call valuecheck()
        If inputbox.Text <> "" Then
            inputbox.Text = Mid(inputbox.Text, 1, Len(inputbox.Text) - 1)
        End If
    End Sub

    Private Sub BAc_Click(sender As Object, e As EventArgs) Handles BAc.Click
        inputbox.Clear()
        answerbox.Clear()
        answerboxword.Clear()

        ' change colors of answerbox to default
        answerbox.BackColor = Color.Black
        answerbox.ForeColor = Color.Maroon
    End Sub

    Private Sub BEnter_Click(sender As Object, e As EventArgs) Handles BEnter.Click
        take_to_initial()
    End Sub

    Private Sub valuecheck()
        If inputbox.Text = "enter your expression here" Then
            inputbox.ForeColor = Color.MintCream
            inputbox.Text = ""
        End If
    End Sub

    Private Sub inputbox_GotFocus(sender As Object, e As EventArgs) Handles inputbox.GotFocus
        If inputbox.Text = "enter your expression here" Then
            inputbox.ForeColor = Color.MintCream
            inputbox.Text = ""
        End If
    End Sub
    Private Sub inputbox_LostFocus(sender As Object, e As EventArgs) Handles inputbox.LostFocus
        If inputbox.Text = Nothing Then
            inputbox.ForeColor = Color.Gray
            inputbox.Text = "enter your expression here"
        End If
    End Sub



    Private Sub inputbox_KeyDown(sender As Object, e As KeyEventArgs) Handles inputbox.KeyDown
        If e.KeyCode = Keys.Escape Then
            inputbox.Text = ""
            answerbox.Text = ""
            ' change colors of answerbox to default
            answerbox.BackColor = Color.Black
            answerbox.ForeColor = Color.Chartreuse
        End If
        If e.KeyCode = Keys.Enter Then
            take_to_initial()
        End If
    End Sub

    Private Sub take_to_initial()
        invoke_maincalc = New main_calc()
        invoke_maincalc.initial(inputbox.Text)
    End Sub

    Private Sub Fsettings_Click(sender As Object, e As EventArgs) Handles Fsettings.Click
        settings.ShowDialog()
    End Sub

    Private Sub Fexit_Click(sender As Object, e As EventArgs) Handles Fexit.Click
        Me.Close()
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


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.autosoft.890m.com")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
