'Imports System.Drawing

Public Class Simulation
    Public Property Ripples As New List(Of Ripple)

    Public Sub AddRipple(center As Point)
        Dim newRipple As New Ripple()
        newRipple.Center = center
        'newRipple.Radius = radius
        newRipple.Speed = 0.1
        newRipple.elapsedTime = 0
        Ripples.Add(newRipple)
    End Sub

    Public Sub MoveRipplesTo(center As Point)
        For Each ripple As Ripple In Ripples
            ripple.Center = center
        Next
    End Sub

    Public Sub Update(deltaTime As Double)
        For Each ripple In Ripples
            ripple.Update(deltaTime)
        Next
    End Sub
End Class
