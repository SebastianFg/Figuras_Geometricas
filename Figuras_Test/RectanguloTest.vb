Imports Figuras_Geometricas
Module RectanguloTest
    Dim rectangulo As New Rectangulo
    Sub main()
        rectangulo.Nombre = "Rectangulo oe"
        Console.WriteLine("El nombre es: " & rectangulo.Nombre)
        rectangulo.Base = 120
        rectangulo.Altura = 120
        Console.WriteLine("Altura: " & rectangulo.Altura)
        Console.WriteLine("Base: " & rectangulo.Base)
        Console.WriteLine("Area: " & rectangulo.CalcularArea())
        Console.ReadKey()

    End Sub
End Module
