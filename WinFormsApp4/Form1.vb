
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 2
            One.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            One.Visible = False

            two.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            two.Visible = False

            Three.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            Three.Visible = False

            Four.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            Four.Visible = False

            Five.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            Five.Visible = False

            Six.Visible = True
            Application.DoEvents()
            Threading.Thread.Sleep(100)
            Six.Visible = False
        Next
        Dim r As New Random()
        Dim num = 0
        num = r.Next(1, 7)
        If num = 1 Then
            One.Visible = True
            two.Visible = False
            Three.Visible = False
            Four.Visible = False
            Five.Visible = False
            Six.Visible = False
        ElseIf num = 2 Then
            two.Visible = True
            One.Visible = False
            Three.Visible = False
            Four.Visible = False
            Five.Visible = False
            Six.Visible = False
        ElseIf num = 3 Then
            two.Visible = False
            One.Visible = False
            Three.Visible = True
            Four.Visible = False
            Five.Visible = False
            Six.Visible = False
        ElseIf num = 4 Then
            two.Visible = False
            One.Visible = False
            Three.Visible = False
            Four.Visible = True
            Five.Visible = False
            Six.Visible = False
        ElseIf num = 5 Then
            two.Visible = False
            One.Visible = False
            Three.Visible = False
            Four.Visible = False
            Five.Visible = True
            Six.Visible = False
        ElseIf num = 6 Then
            Six.Visible = True
            two.Visible = False
            One.Visible = False
            Three.Visible = False
            Four.Visible = False
            Five.Visible = False
        End If

    End Sub
End Class
