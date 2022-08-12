Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = CInt(TextBox1.Text)
        Dim resultado As String = ""

        For indice As Integer = 1 To numero
            resultado = resultado + indice.ToString() + ","
        Next
        TextBox2.Text = resultado

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim entrada As String = TextBox3.Text
        ListBox1.Items.Add(entrada)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resultado As String = ""
        For Each item In ListBox1.Items
            resultado = resultado + " [" + item + "]   "
        Next
        RichTextBox1.Text = resultado
    End Sub
End Class
