Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("CICLOS Y BUCLES 1")

        Console.WriteLine("Numeros de 1 al 25")
        For indice As Integer = 1 To 25
            Console.WriteLine(indice)
        Next
        Console.WriteLine("")

        Console.WriteLine("Numeros de 1 a n")
        Console.Write("Ingrese un numero: ")
        Dim numeroFinal As Integer = Console.ReadLine()
        For indice As Integer = 1 To numeroFinal
            Console.WriteLine(indice)
        Next

        Console.WriteLine("Numeros de 10 al 0")
        For indice As Integer = 10 To 1 Step -2
            Console.WriteLine(indice)
        Next
        Console.WriteLine("")

        Console.WriteLine("Media piramide de n altura")
        Dim altura As Integer = Console.ReadLine()

        For indice As Integer = 1 To altura Step 1
            For base As Integer = 1 To indice Step 1
                Console.Write("*")
            Next
            Console.WriteLine("") 'Dejar un espacio
        Next

        Console.WriteLine("Numeros pares desde 1 hasta n")
        Dim numeroF As Integer = Console.ReadLine()
        For indice As Integer = 1 To numeroF Step 1
            'Mod 2 =0, lo que hace es validar si es par
            If (indice Mod 2 = 0) Then
                Console.WriteLine(indice)
            End If
        Next

        Console.WriteLine("Problema parcial 1 1Semestre2022")
        Console.Write("Numero A:")
        Dim numeroA As Integer = Console.ReadLine()
        Console.Write("Numero B:")
        Dim numeroB As Integer = Console.ReadLine()

        'Comparar cual es mayor
        If (numeroA > numeroB) Then
            Console.WriteLine("A es mayor")
            'Ascendente numeros desde b hasta a
            For indice As Integer = numeroB To numeroA Step 1
                'Imprimir pares
                If (indice Mod 2 = 0) Then
                    Console.WriteLine(indice)
                End If
            Next
        ElseIf (numeroB > numeroA) Then
            Console.WriteLine("B es mayor")
            'Descendente numeros desde b hasta a
            For indice As Integer = numeroB To numeroA Step -1
                'Imprimir impares
                If Not (indice Mod 2 = 0) Then
                    Console.WriteLine(indice)
                End If
            Next
        Else
            Console.WriteLine("A igual a B")
        End If
        Console.WriteLine("")

        Console.WriteLine("--------For Each-----")
        Dim lista As New List(Of Integer) From {4, 56, 22, 10, 55}
        For Each numero In lista
            Console.WriteLine(numero)
        Next

    End Sub
End Module
