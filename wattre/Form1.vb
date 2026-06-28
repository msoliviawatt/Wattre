Public Class Form1
    'Private currentRipple As Ripple
    'Private ripples = New List(Of Ripple) 'this should be like a c++ vector'

    Private simulation As New Simulation()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show("Hola")

        simulation.AddRipple(New Point(ClientSize.Width \ 2, ClientSize.Height \ 2))

        'Dim currentRipple As New Ripple()

        'currentRipple = New Ripple()
        'currentRipple.Center = New Point(ClientSize.Width \ 2, ClientSize.Height \ 2)
        'currentRipple.Radius = 50

        'ripples.Add(currentRipple)

        Invalidate() 'triggers repaint'

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        'For Each currentRipple As Ripple In ripples

        '    Dim diameter As Integer = currentRipple.Radius * 2
        '    Dim x As Integer = currentRipple.Center.X - currentRipple.Radius
        '    Dim y As Integer = currentRipple.Center.Y - currentRipple.Radius

        '    'x, y, width, height'
        '    e.Graphics.DrawEllipse(Pens.BlueViolet, x, y, diameter, diameter)

        'Next
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        For Each ripple As Ripple In simulation.Ripples
            Dim diameter As Integer = ripple.Radius * 2
            Dim x As Integer = ripple.Center.X - ripple.Radius
            Dim y As Integer = ripple.Center.Y - ripple.Radius

            e.Graphics.DrawEllipse(Pens.Aqua, x, y, diameter, diameter)
        Next
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        simulation.MoveRipplesTo(New Point(ClientSize.Width \ 2, ClientSize.Height \ 2))

        Invalidate()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles simulationTimer.Tick
        simulation.Update(20)
        Invalidate()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        simulationTimer.Start()
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        simulation.AddRipple(e.Location)
        Invalidate()
    End Sub
End Class
