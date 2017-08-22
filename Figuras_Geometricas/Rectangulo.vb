Public Class Rectangulo
    Inherits Figura

    Private _Base As UShort
    Private _altura As UShort

    Sub New()
        MyBase.New()
        _Base = Nothing
        _altura = Nothing
    End Sub

    Public Property Altura() As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
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
        Return (_Base * _altura)
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function

End Class
