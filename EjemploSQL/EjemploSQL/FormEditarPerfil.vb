Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormEditarPerfil
    Dim rutaFoto As String = ""
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormMenuCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtNombre As String = textBoxNombre.Text
        Dim txtEdad As String = textBoxEdad.Text


        If Not (rutaFoto = "") Then
            'Si la ruta de la foto no es una cadena vacio, procedemos, sino no
            MsgBox("Datos aceptados")

            'Abrir la conexion
            conexion.Open()
            Try
                Dim consulta As String = "UPDATE usuario SET nombre='" + txtNombre + "', edad=" + txtEdad + ",foto_perfil='" + rutaFoto + "' WHERE username='" + usrUsername + "'"
                Dim comando As SqlCommand
                comando = New SqlCommand(consulta, conexion)
                comando.ExecuteNonQuery()
                MessageBox.Show("Los datos se actualizaron correctamente")
            Catch ex As Exception
                MsgBox("Error al ingresar datos a la DB")
            End Try
            conexion.Close()

        Else
            MsgBox("Seleccione una foto")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then
            lbRuta.Text = rutaFoto
        End If
    End Sub
End Class