Imports System.IO

Public Class settings

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.ReadAllText("ACalc_Files/settings.txt").Length <> 0 Then
            Using reader As StreamReader = New StreamReader("ACalc_Files/settings.txt")
                Dim displaytype As String = reader.ReadLine
                If displaytype = 1 Then
                    Setting_1.Text = "Yes"
                    Button_1.Checked = True
                Else
                    Setting_1.Text = "No"
                    Button_2.Checked = True
                End If

                Dim wordtype As String = reader.ReadLine
                If wordtype = 1 Then
                    Setting_2.Text = "International"
                    Button_3.Checked = True
                Else
                    Setting_2.Text = "Nepali"
                    Button_4.Checked = True
                End If
            End Using
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using writer As StreamWriter = New StreamWriter("ACalc_Files/settings.txt")
            If Button_1.Checked Then
                writer.WriteLine("1")
                Setting_1.Text = "Yes"
            ElseIf Button_2.Checked Then
                writer.WriteLine("2")
                Setting_1.Text = "No"
            End If

            If Button_3.Checked Then
                writer.WriteLine("1")
                Setting_2.Text = "International"
            ElseIf Button_4.Checked Then
                writer.WriteLine("2")
                Setting_2.Text = "Nepali"
            End If
        End Using
        MsgBox("Settings Saved")
        Me.Close()
    End Sub

End Class