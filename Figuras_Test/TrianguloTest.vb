Imports Figuras_Geometricas
Module TrianguloTest
    Dim triangulo As New Triangulo
    Sub main()
        triangulo.Nombre = "Trinagulin"
        Console.WriteLine("El nombre es: " & triangulo.Nombre)
        triangulo.Base = 6
        triangulo.Altura = 10
        Console.WriteLine("Altura: " & triangulo.Altura)
        Console.WriteLine("Base: " & triangulo.Base)
        Console.WriteLine("Area: " & triangulo.CalcularArea())
        Console.ReadKey()

    End Sub

End Module
