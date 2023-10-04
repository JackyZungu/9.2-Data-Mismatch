Public Class Form1
    Private Sub btnShow_Click(ByVal sender As Object, e As EventArgs) Handles btnShow.Click
        Dim text1, text3 As String
        Dim text2 As Integer
        text1 = "Visual"
        text2 = 22
        'text3 = text1 + text2 ' InvalidCastexception 

        'MsgBox(text3)

        text3 = text1 & " " & text2 'ratify 
        MsgBox(text3)





    End Sub
End Class
