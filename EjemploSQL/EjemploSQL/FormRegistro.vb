Imports System.Data.SqlClient

Public Class FormRegistro
    'Variable de la foto
    Dim rutaFoto As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtNombre As String = TextBox1.Text
        Dim txtUsername As String = TextBox2.Text
        Dim txtPass1 As String = TextBox3.Text
        Dim txtPass2 As String = TextBox4.Text
        Dim txtEdad As String = TextBox5.Text

        If (txtPass1 = txtPass2) Then
            'Si ambas son iguales, procedemos, sino no

            If Not (rutaFoto = "") Then
                'Si la ruta de la foto no es una cadena vacio, procedemos, sino no
                MsgBox("Datos aceptados")

                'Una vez validamos todos los datos, procedemos a la insercion
                Dim passEncrip As String = Encriptar(txtPass1)

                'Abrir la conexion
                conexion.Open()
                Try
                    Dim consulta As String = "INSERT INTO usuario(nombre,edad,username,password,tipo,foto_perfil) VALUES ('" + txtNombre + "'," + txtEdad + ",'" + txtUsername + "','" + passEncrip + "','Cliente','" + rutaFoto + "')"
                    Dim comando As SqlCommand
                    comando = New SqlCommand(consulta, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Los datos se guardaron correctamente")
                Catch ex As Exception
                    MsgBox("Error al ingresar datos a la DB")
                End Try
                conexion.Close()

            Else
                MsgBox("Seleccione una foto")
            End If
        Else
            MsgBox("Contrasenas no coinciden")
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then
            lbFoto.Text = rutaFoto
        End If
    End Sub
End Class