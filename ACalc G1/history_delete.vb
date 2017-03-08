Imports System.IO

Public Class history_delete
    Public Sub delete_history()
        If File.Exists("ACalc_Files/history.txt") Then
            If File.ReadAllText("ACalc_Files/history.txt").Length <> 0 Then
                File.Delete("ACalc_Files/history.txt")
                Using reader As StreamWriter = File.AppendText("ACalc_Files/history.txt")
                End Using
                MsgBox("History Successfully deleted")
            Else
                MsgBox("History Not found")
            End If
        Else
            MsgBox("History Not found")
        End If
    End Sub
End Class