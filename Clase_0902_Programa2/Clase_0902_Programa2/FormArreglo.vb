Public Class FormArreglo

    Dim numeros = New Integer() {1, 2, 4, 8}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim posicion = CInt(TextBox1.Text)
        lbResultado.Text = numeros(posicion)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim posicion = CInt(TextBox1.Text)
        Dim valor = CInt(TextBox2.Text)
        numeros(posicion) = valor
        Dim textoElementos = ""
        For Each elemento In numeros
            textoElementos = textoElementos + elemento.ToString + ","
        Next
        lbElementos.Text = textoElementos

    End Sub

    Private Sub FormArreglo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textoElementos = ""
        For Each elemento In numeros
            textoElementos = textoElementos + elemento.ToString + ","
        Next
        lbElementos.Text = textoElementos

    End Sub
End Class