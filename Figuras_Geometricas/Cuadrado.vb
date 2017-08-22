Public Class Cuadrado
    Inherits Figura
    Private _Lado As UShort


    Sub New()
        MyBase.New()
        _Lado = Nothing
    End Sub

    Public Property Lado() As UShort
        Get
            Return _Lado
        End Get
        Set(value As UShort)
            _Lado = value
        End Set
    End Property


    Public Overrides Function CalcularArea() As Single
        Return Lado ^ 2
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function
End Class
