Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim altura As Double = CDbl(TextBox1.Text)
        Dim peso As Double = CDbl(TextBox2.Text)
        Dim resultado As String

        If (altura < 1.5) Then
            If (peso < 40) Then
                resultado = "Delgado"
            ElseIf (peso >= 40 And peso <= 55) Then
                resultado = "normal"
            ElseIf (peso > 55) Then
                resultado = "Obeso"
            End If
        ElseIf (altura >= 1.5 And altura <= 1.7) Then
            If (peso < 45) Then
                resultado = "Delgado"
            ElseIf (peso >= 45 And peso <= 65) Then
                resultado = "Normal"
            ElseIf (peso > 65) Then
                resultado = "Obeso"
            End If
        ElseIf (altura > 1.7) Then
            If (peso < 60) Then
                resultado = "Delgado"
            ElseIf (peso >= 60 And peso <= 80) Then
                resultado = "Normal"
            ElseIf (peso > 80) Then
                resultado = "Obeso"
            End If
        End If

        'Imprimir el resultado
        Label3.Text = resultado

        'Saber cual radioButton esta seleccionado
        Dim resultadoEdad As String
        If (RadioButton1.Checked) Then
            resultadoEdad = "Joven"
        ElseIf (RadioButton2.Checked) Then
            resultadoEdad = "Adulto"
        ElseIf (RadioButton3.Checked) Then
            resultadoEdad = "Anciano"
        End If

        Label5.Text = resultadoEdad

    End Sub
End Class
