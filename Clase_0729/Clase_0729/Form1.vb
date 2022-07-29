Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Guardar el texto de la caja de texto
        'Variable                  Cuadro texto
        Dim nombre As String = TextBox1.Text

        'Mostrar un mensaje con el saludio
        MsgBox("Hola " + nombre)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Guardar el texto de la caja de texto
        'Variable                  Cuadro texto
        Dim nombre As String = TextBox1.Text

        'Agregar el nombre a la lista
        ListBox1.Items.Add(nombre)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'guardar en una variable el elemento seleccionado de la lista
        Dim nombre As String = ListBox1.SelectedItem

        'Mostrar un mensaje con el saludio
        MsgBox("Hola " + nombre)
    End Sub
End Class
