Public Class Triangulo
    Inherits Figura
    Private _Base As UShort
    Private _Altura As UShort

    Sub New()
        MyBase.New()
        _Altura = Nothing
        _Base = Nothing
    End Sub

    Public Property Altura() As UShort
        Get
            Return _Altura
        End Get
        Set(value As UShort)
            _Altura = value
        End Set
    End Property

    Public Property Base() As UShort
        Get
            Return _Base
        End Get
        Set(value As UShort)
            _Base = value
        End Set
    End Property


    Public Overrides Function CalcularArea() As Single
        Return (_Base * _Altura) / 2
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function
End Class
