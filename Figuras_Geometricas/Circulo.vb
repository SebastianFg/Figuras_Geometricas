Public Class Circulo
    Inherits Figura
    Private _Radio As UShort


    Sub New()
        MyBase.New()
        _Radio = Nothing
    End Sub

    Public Property Radio() As UShort
        Get
            Return _Radio
        End Get
        Set(value As UShort)
            _Radio = value
        End Set
    End Property


    Public Overrides Function CalcularArea() As Single
        Return Math.PI * Radio ^ 2
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString
    End Function

End Class
