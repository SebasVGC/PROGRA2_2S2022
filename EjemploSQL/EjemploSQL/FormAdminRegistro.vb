Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormAdminRegistro
    Dim rutaFoto As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then
            lbFoto.Text = rutaFoto
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtNombre As String = textboxNombre.Text
        Dim txtUsername As String = textboxUsername.Text
        Dim txtPass1 As String = textboxPass1.Text
        Dim txtPass2 As String = textboxPass2.Text
        Dim txtEdad As String = textboxEdad.Text
        Dim txtTipo As String = textboxTipo.Text

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
                    Dim consulta As String = "INSERT INTO usuario(nombre,edad,username,password,tipo,foto_perfil) VALUES ('" + txtNombre + "'," + txtEdad + ",'" + txtUsername + "','" + passEncrip + "','" + txtTipo + "','" + rutaFoto + "')"
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
        FormMenuAdmin.Show()
        Me.Hide()
    End Sub
End Class