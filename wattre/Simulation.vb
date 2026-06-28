'Imports System.Drawing

Public Class Simulation
    Public Property Ripples As New List(Of Ripple)

    Public Sub AddRipple(center As Point, radius As Integer)
        Dim newRipple As New Ripple()
        newRipple.Center = center
        newRipple.Radius = radius
        Ripples.Add(newRipple)
    End Sub

    Public Sub MoveRipplesTo(center As Point)
        For Each ripple As Ripple In Ripples
            ripple.Center = center
        Next
    End Sub
End Class
