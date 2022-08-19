Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Sub limpiar()
        'Todo lo que escribamos dentro se ejecutara cuando llamemos al metodo
        TextBox1.Text = ""
        TextBox2.Clear()
        Label3.Text = "Resultado"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Llamar a la funcion calcular
        Dim alturaTxt = CDbl(TextBox1.Text)
        Dim baseTxt = CDbl(TextBox2.Text)

        Dim tipoOperacion = ""

        If (RadioButton1.Checked) Then
            tipoOperacion = "rectangulo"
        ElseIf (RadioButton2.Checked) Then
            tipoOperacion = "triangulo"
        End If

        Label3.Text = "El area es " + Calcular(alturaTxt, baseTxt, tipoOperacion).ToString()
    End Sub

    Function Calcular2(base As Double, altura As Double) As Double
        'Calcular base x altura
        Dim resultado As Double = base * altura
        Return resultado
    End Function

    Function Calcular(base As Double, altura As Double, tipo As String) As Double
        'Calcular base x altura
        Dim resultado As Double = 0

        If (tipo = "triangulo") Then
            resultado = (base * altura) / 2
        ElseIf (tipo = "rectangulo") Then
            resultado = (base * altura)
        Else
            resultado = 0
        End If

        Return resultado
    End Function


End Class
