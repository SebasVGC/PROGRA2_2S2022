Imports System

Module Program
    Sub Main(args As String())
        'Dim edad As Integer = 20
        'If (edad >= 15) Then
        '    'Entra aqui si es verdadero
        '    Console.WriteLine("Puede competir")
        'Else
        '    'Entra aqui si es falso
        '    Console.WriteLine("No puede competir")
        'End If

        'IF ELSE IF
        'Dim nota As Decimal = 7.5
        'Dim calificacion As String

        'If (nota >= 9.0) Then
        '    calificacion = "sobresaliente"
        'ElseIf nota >= 7.0 Then
        '    calificacion = "notable"
        'ElseIf nota >= 5.0 Then
        '    calificacion = "aprobado"
        'Else
        '    calificacion = "reprobado"
        'End If
        'Console.WriteLine(calificacion)


        'SELECT - CASE
        'Dim opcion As Integer = 2 + 1 + 10

        'Select Case opcion
        '    Case 1
        '        Console.WriteLine("Elegio opcion 1")
        '    Case 2
        '        Console.WriteLine("Elegio opcion 2")
        '    Case 3
        '        Console.WriteLine("Elegio opcion 3")
        '    Case Else
        '        Console.WriteLine("Ninguna opcion")
        'End Select


        'PROBLEMA EXAMEN
        Dim altura As String
        Console.WriteLine("Ingrese su altura mts")
        altura = Console.ReadLine()

        Dim peso As String
        Console.WriteLine("Ingrese su peso kg")
        peso = Console.ReadLine()

        'Evaluar las alturas

        If (altura < 1.5) Then
            If (peso < 40) Then
                Console.WriteLine("Delgado")
            ElseIf (peso >= 40 And peso <= 55) Then
                Console.WriteLine("Normal")
            ElseIf (peso > 55) Then
                Console.WriteLine("Obeso")
            End If
        ElseIf (altura >= 1.5 And altura <= 1.7) Then
            If (peso < 45) Then
                Console.WriteLine("Delgado")
            ElseIf (peso >= 45 And peso <= 65) Then
                Console.WriteLine("Normal")
            ElseIf (peso > 65) Then
                Console.WriteLine("Obeso")
            End If
        ElseIf (altura > 1.7) Then
            If (peso < 60) Then
                Console.WriteLine("Delgado")
            ElseIf (peso >= 60 And peso <= 80) Then
                Console.WriteLine("Normal")
            ElseIf (peso > 80) Then
                Console.WriteLine("Obeso")
            End If
        End If


    End Sub
End Module
