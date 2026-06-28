Public Class Form1
    Private currentRipple As Ripple

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Hola")

        currentRipple = New Ripple()
        currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        currentRipple.Radius = 100

        Invalidate() 'triggers repaint'

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        If (currentRipple Is Nothing) Then
            Return
        End If

        Dim diameter As Integer = currentRipple.Radius * 2
        Dim x As Integer = currentRipple.Center.X - currentRipple.Radius
        Dim y As Integer = currentRipple.Center.Y - currentRipple.Radius

        'x, y, width, height'
        'e.Graphics.DrawEllipse(Pens.Blue, 100, 100, 200, 200)
        e.Graphics.DrawEllipse(Pens.Blue, x, y, diameter, diameter)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        If (currentRipple IsNot Nothing) Then
            currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        End If

        Invalidate()
    End Sub
End Class
