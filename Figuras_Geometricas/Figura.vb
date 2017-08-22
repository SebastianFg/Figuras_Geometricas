Public Class Figura
    Private _Nombre As String

    Sub New()
        _Nombre = Nothing
    End Sub

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Overridable Function CalcularArea() As Single
        Return 0
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    
End Class
