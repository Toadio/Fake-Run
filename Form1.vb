Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Start()
    End Sub

    Dim RandomCrap As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DesktopLocation = New Point(RandomCrap.Next(1, 1000), RandomCrap.Next(1, 500)) Then
            DesktopLocation = New Point(RandomCrap.Next(1, 1000), RandomCrap.Next(1, 500))
        End If
        DesktopLocation = New Point(RandomCrap.Next(1, 1000), RandomCrap.Next(1, 500))
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        MsgBox("Hah hah try harder you dumb scammer!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
End Class
