Imports Figuras_Geometricas
Module CirculoTest
    Dim circulo As New Circulo

    Sub main()
        circulo.Nombre = "Cuadrado"
        Console.WriteLine("El nombre es: " & circulo.Nombre)
        circulo.Radio = 10
        Console.WriteLine("Altura: " & circulo.Radio)
        Console.WriteLine("Area: " & circulo.CalcularArea())
        Console.WriteLine("ToString: " & circulo.ToString)
        Console.ReadKey()

    End Sub


End Module
