Public Class Form1
    'Private currentRipple As Ripple
    Private ripples = New List(Of Ripple) 'this should be like a c++ vector'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Hola")

        Dim currentRipple As New Ripple()

        currentRipple = New Ripple()
        currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        currentRipple.Radius = 50

        ripples.Add(currentRipple)

        Invalidate() 'triggers repaint'

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        For Each currentRipple As Ripple In ripples

            Dim diameter As Integer = currentRipple.Radius * 2
            Dim x As Integer = currentRipple.Center.X - currentRipple.Radius
            Dim y As Integer = currentRipple.Center.Y - currentRipple.Radius

            'x, y, width, height'
            e.Graphics.DrawEllipse(Pens.BlueViolet, x, y, diameter, diameter)

        Next
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        'If (currentRipple IsNot Nothing) Then
        '    currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        'End If

        For Each currentRipple As Ripple In ripples
            currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        Next

        Invalidate()
    End Sub
End Class
