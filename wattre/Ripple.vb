Imports System.Drawing

Public Class Ripple
    Public Property Center As Point
    Public Property Radius As Integer

    Public Sub Update()
        Radius += 1
    End Sub
End Class
