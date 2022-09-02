Module Module1

    Sub Main()
        banco()
        Dim entrada = Console.Read()
    End Sub

    Sub ejemplo1()
        Dim index As Integer = 0
        While (index <= 10)
            Console.WriteLine(index)
            index = index + 1
        End While
        Dim entrada = Console.Read()
    End Sub

    Sub ejemplo2()
        Dim indice As Integer = 0

        While (indice <= 300000)
            indice = indice + 1
            If (indice = 5) Then
                'No queremos que imprima el 5
                Continue While
            End If

            If (indice > 10) Then
                'Queremos salir despues del 10
                Exit While
            End If
            Console.WriteLine(indice)
        End While

        Dim entrada = Console.Read()
    End Sub

    Sub ejemplo3()
        Dim index As Integer = 50
        Console.WriteLine("Antes del cilo")
        While (index <= 10)
        Console.WriteLine(index)
            index = index + 1
        End While
        Console.WriteLine("Afuera del cilo")
        Dim entrada = Console.Read()
    End Sub

    Sub ejemplo4()
        Dim indice As Integer = 0
        Do
            Console.WriteLine(indice)
            indice = indice + 1
        Loop While (indice <= 10)
        Dim entrada = Console.Read()
    End Sub

    Sub ejemplo5()
        Dim indice As Integer = 10000
        Do
            Console.WriteLine(indice)
            indice = indice + 1
        Loop While (indice <= 10)
        Dim entrada = Console.Read()
    End Sub
    Sub ejemplo6()
        Dim indice As Integer = 0
        Do While indice <= 10
            Console.WriteLine(indice)
            indice = indice + 1
        Loop
        Dim entrada = Console.Read()
    End Sub
    Sub ejemplo7()
        Dim indice As Integer = 0
        Do While indice < 10000
            indice = indice + 1

            If (indice = 10) Then
                Continue Do
            End If

            If (indice > 15) Then
                Exit Do
            End If

            Console.WriteLine(indice)

        Loop
        Dim entrada = Console.Read()
    End Sub

    'Diabujar media piramide
    Sub piramide()
        Console.Write("Ingrese altura: ")
        Dim altura As Integer = Console.ReadLine()

        Dim index As Integer = 1
        While (index <= altura)

            Dim index2 As Integer = 0
            While (index2 < index)
                Console.Write("*")
                index2 = index2 + 1
            End While
            Console.WriteLine("")
            index = index + 1
        End While
        Dim entrada = Console.Read()
    End Sub

    Sub rombo()
        Console.Write("Ingrese altura: ")
        Dim altura As Integer = Console.ReadLine()

        Dim index As Integer = 1
        While (index <= altura)

            Dim index2 As Integer = 0
            While (index2 < index)
                Console.Write("*")
                index2 = index2 + 1
            End While
            Console.WriteLine("")
            index = index + 1
        End While

        Dim index3 = altura
        While (index3 > 0)
            index3 = index3 - 1
            Dim index4 As Integer = 0
            While (index4 < index3)
                Console.Write("*")
                index4 = index4 + 1
            End While
            Console.WriteLine("")
        End While

        Dim entrada = Console.Read()
    End Sub

    'Numeros desde 1 hasta n, omitiendo los multiplos de 3
    Sub ejemploMultiplos()
        Console.Write("Ingrese n: ")
        Dim numero As Integer = Console.ReadLine()
        Dim indice As Integer = 0

        While (indice <= numero)
            indice = indice + 1
            If Not (indice Mod 3 = 0) Then
                Continue While
            End If
            Console.WriteLine(indice)
        End While
    End Sub

    Sub promedios()
        Console.Write("Ingrese cant. cursos: ")
        Dim numero As Integer = Console.ReadLine()
        Dim indice As Integer = 0

        Dim sumaTotal As Integer = 0

        While (indice < numero)
            Console.Write("Ingrese nota: ")
            Dim nota As Integer = Console.ReadLine()

            If (nota > 100 Or nota < 0) Then
                Console.Write("Nota No Valida")
                Continue While
            End If
            sumaTotal = sumaTotal + nota
            indice = indice + 1
        End While

        Dim promedio As Double = sumaTotal / numero
        Console.Write("Promedio: ")
        Console.Write(promedio)
        Console.WriteLine("")

        If (promedio < 61) Then
            Console.WriteLine("Promedio malo")
        ElseIf (promedio < 80) Then
            Console.WriteLine("Promedio regular")
        Else
            Console.WriteLine("Promedio bueno")
        End If
    End Sub

    Sub banco()
        Console.Write("Ingrese cant. operaciones: ")
        Dim numero As Integer = Console.ReadLine()
        If (numero < 1) Then
            Console.WriteLine("   Ingrese numero valido!!!")
        End If


        Dim indice As Integer = 0

        Dim sumaTotal As Double = 0

        While (indice < numero)
            Console.Write("   Ingrese monto: ")
            Dim monto As Double = Console.ReadLine()
            If (monto <= 0) Then
                Console.WriteLine("   Ingrese monto valido!!!")
                Continue While
            End If


            Console.Write("   Agregar bono 5%: S/N  ")
            Dim respuesta As String = Console.ReadLine()

            Dim bono As Double = 0
            If (respuesta = "S" Or respuesta = "s") Then
                bono = monto * 0.05
            End If

            sumaTotal = sumaTotal + monto + bono
            indice = indice + 1
        End While

        Console.Write("Total a pagar: ")
        Console.Write(sumaTotal)
        Console.WriteLine("")

    End Sub


End Module


'Factorial es 24
' 0,4,8,12,16,20,24
'Cantidad de multiplos de 4 son 7