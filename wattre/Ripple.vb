Imports System.Drawing

Public Class Ripple
    Public Property Center As Point
    'Public Property Radius As Integer
    Public Property Speed As Double
    Public Property elapsedTime As Double

    Public ReadOnly Property Radius As Double
        Get
            Return 5 + elapsedTime * Speed
        End Get
    End Property

    Public Sub Update(deltaTime As Double)
        elapsedTime += deltaTime
    End Sub
End Class
