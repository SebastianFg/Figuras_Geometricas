Imports Figuras_Geometricas
Module FiguraTest
    Dim figura As New Figura
    Sub Main()
        figura.Nombre = "Soy una figura"
        Console.WriteLine("Nombre de 'Figura': " & figura.Nombre)
        figura.Nombre = "Nuevo Nick"
        Console.WriteLine("Nuevo Nombre:(tostring) " & figura.ToString())
        Console.WriteLine("calcular area: " & figura.CalcularArea())

        Console.ReadKey()
    End Sub

End Module
