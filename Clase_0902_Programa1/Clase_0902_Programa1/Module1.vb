Module Module1

    Sub Main()
        Ejemplo5()
        Dim entrada = Console.ReadLine()
    End Sub

    Sub Ejemplo1()
        'Crear arreglo de 8 elementos, pedir que elemento quiere ver
        Dim edades(7) As Integer
        edades(0) = 4
        edades(1) = 6
        edades(2) = 5
        edades(3) = 20
        edades(4) = 44
        edades(5) = 99
        edades(6) = 1
        edades(7) = -7

        Console.WriteLine("Ingrese posicion 0-7: ")
        Dim posicion As Integer = CInt(Console.ReadLine())
        Console.WriteLine(edades(posicion))
    End Sub

    Sub Ejemplo2()
        Dim numeros = New Integer() {1, 2, 4, 8}
        Console.WriteLine("Ingrese posicion 0-3: ")
        Dim posicion As Integer = CInt(Console.ReadLine())
        Console.WriteLine(numeros(posicion))
    End Sub

    Sub Ejemplo3()
        Dim numeros = New Integer() {1, 2, 4, 8}
        ReDim Preserve numeros(7)
        numeros(4) = 77
        numeros(5) = 10
        numeros(6) = -4
        numeros(7) = 99

        Console.WriteLine("Ingrese posicion 0-7: ")
        Dim posicion As Integer = CInt(Console.ReadLine())
        Console.WriteLine(numeros(posicion))
    End Sub

    Sub Ejemplo4()
        'Imprimir todos los elementos de la lista
        Dim numeros = New Integer() {1, 2, 4, 8, 7, 9, 11, -7, 100}

        For Each elemento In numeros
            Console.WriteLine(elemento)
        Next
        Console.WriteLine("------------")
        For indice As Integer = 0 To 8
            Console.WriteLine(numeros(indice))
        Next
    End Sub

    Sub Ejemplo5()
        Dim matrix1(2, 2) As Integer
        matrix1(0, 0) = 7
        matrix1(0, 1) = 77
        matrix1(0, 2) = 11
        matrix1(1, 0) = -8
        matrix1(1, 1) = 100
        matrix1(1, 2) = 9
        matrix1(2, 0) = 99
        matrix1(2, 1) = 5
        matrix1(2, 2) = 25

        For filas As Integer = 0 To 2
            For columnas As Integer = 0 To 2
                Console.Write(matrix1(filas, columnas).ToString + " ")
            Next
            Console.WriteLine("")
        Next

    End Sub

End Module
