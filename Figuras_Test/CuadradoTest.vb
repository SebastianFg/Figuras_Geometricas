Imports Figuras_Geometricas
Module CuadradoTest

    Dim cuadrado As New Cuadrado
    Sub main()
        cuadrado.Nombre = "Cuadrado"
        Console.WriteLine("El nombre es: " & cuadrado.Nombre)
        cuadrado.Lado = 10
        Console.WriteLine("Altura: " & cuadrado.Lado)
        Console.WriteLine("Area: " & cuadrado.CalcularArea())
        Console.WriteLine("ToString: " & cuadrado.ToString)
        Console.ReadKey()

    End Sub

End Module
