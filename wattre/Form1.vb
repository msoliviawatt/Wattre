Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Hola")

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim diameter As Integer = 100
        Dim x As Integer = (ClientSize.Width - diameter) / 2
        Dim y As Integer = (ClientSize.Height - diameter) / 2

        'x, y, width, height'
        'e.Graphics.DrawEllipse(Pens.Blue, 100, 100, 200, 200)
        e.Graphics.DrawEllipse(Pens.Blue, x, y, diameter, diameter)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Invalidate()
    End Sub
End Class
