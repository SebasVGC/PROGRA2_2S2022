Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Ejemplo procedimientos")
        Problema2()
    End Sub

    Sub Problema1()
        Console.WriteLine("Problema 1")
        'Pedir la cantidad de cursos
        'Ingresar la nota de cada curso
        'Calcular promedio total
        'Indicar si el promedio es bueno, regular, malo

        Console.Write("Ingrese la cant. cursos: ")
        Dim cantidad = Console.ReadLine()

        Dim sumaTotal As Integer = 0
        Dim promedio As Double = 0

        For indice As Integer = 1 To cantidad
            Console.Write("   Ingrese la nota: ")
            Dim notaActual = Console.ReadLine()
            sumaTotal = sumaTotal + notaActual
        Next

        promedio = sumaTotal / cantidad

        Console.WriteLine("El promedio es " + promedio.ToString())

        If (promedio < 61) Then
            Console.WriteLine("Promedio malo")
        ElseIf (promedio >= 61 And promedio <= 80) Then
            Console.WriteLine("Promedio regular")
        Else
            Console.WriteLine("Promedio excelente")
        End If

    End Sub

    Sub Problema2()
        Console.WriteLine("Problema 2")
        'Pedir la cantidad de operaciones
        'Ingresar el monto de cada operacion
        'en cada monto preguntar si desea bono 5%
        'Calcular el total final

        Console.Write("Ingrese la cant. operaciones: ")
        Dim cantidad = Console.ReadLine()

        Dim sumatoriaTotal As Double = 0

        For indice As Integer = 1 To cantidad
            Console.Write("   Ingrese monto: ")
            Dim montoActual = Console.ReadLine()
            Dim bono = 0
            Console.Write("   Agregar bono (s/n): ")
            Dim respuesta = Console.ReadLine()
            If (respuesta = "s" Or respuesta = "S") Then
                bono = montoActual * 0.05
            End If
            sumatoriaTotal = sumatoriaTotal + montoActual + bono
        Next

        Console.Write("Total: Q" + sumatoriaTotal.ToString())


    End Sub








End Module

