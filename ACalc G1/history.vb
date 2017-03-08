Imports System.IO

Public Class history

    Private Sub history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim que As String, ans As String
        If File.Exists("ACalc_Files/history.txt") Then
            If File.ReadAllText("ACalc_Files/history.txt").Length = 0 Then
                MsgBox("History not found")
                Close()
            Else
                Dim i As Integer = 1
                Using reader As StreamReader = New StreamReader("ACalc_Files/history.txt")
                    Do While Not reader.Peek
                        que = reader.ReadLine
                        ans = reader.ReadLine
                        display_box.AppendText(i & ") " & que & " = " & ans & Environment.NewLine)
                        i = i + 1
                    Loop
                End Using
            End If
        Else
            MsgBox("History not found")
            Close()
        End If
    End Sub
End Class