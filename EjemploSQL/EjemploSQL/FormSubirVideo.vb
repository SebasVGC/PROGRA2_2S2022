Imports System.Data.SqlClient

Public Class FormSubirVideo
    Dim rutaVideo As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenuCliente.Show()
        Me.Hide()
    End Sub

    Sub ActualizarAlbums()
        ComboBoxAlbums.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM ALBUM WHERE USUARIO_ID_USUARIO=" + usrId + " AND TIPO_ALBUM = 'Videos'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;...
                Dim nombreAlbum As String = MiLector.GetString(1)
                ComboBoxAlbums.Items.Add(nombreAlbum)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar albums")
        End Try

        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        rutaVideo = OpenFileDialog1.FileName()
        If Not (rutaVideo = "") Then
            lbRutaVideo.Text = rutaVideo
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Nombre = txtNombre.Text
        Dim Duracion = txtDuracion.Text
        Dim NuevoAlbum = txtAlbum.Text

        If (NuevoAlbum = "") Then
            ' No es un album nuevo, sino que debemos elegirlo
            Dim AlbumSeleccionado = ComboBoxAlbums.SelectedItem.ToString()
            Dim AlbumId = ObtenerIdAlbum(AlbumSeleccionado, "Videos", usrId)

            CrearVideo(Nombre, rutaVideo, Duracion, AlbumId)

        Else
            ' Si es un album nuevo, hay que crearlo
            CrearAlbumVideo(NuevoAlbum, usrId)
            Dim AlbumId = ObtenerIdAlbum(NuevoAlbum, "Videos", usrId)
            CrearVideo(Nombre, rutaVideo, Duracion, AlbumId)
        End If

    End Sub

    Function ObtenerIdAlbum(nombreBuscado As String, tipo As String, idUsuario As String) As String
        Dim resultado As String = ""
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM album WHERE nombre= '" + nombreBuscado + "' AND tipo_album='" + tipo + "' AND USUARIO_ID_USUARIO=" + idUsuario + ""
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre...
                resultado = MiLector.GetInt32(0).ToString()
            Loop
        Catch ex As Exception
            MsgBox("Error al buscar etiqueta")
            conexion.Close()
        End Try

        conexion.Close()

        Return resultado
    End Function

    Sub CrearVideo(nombre As String, ruta As String, duracion As String, idAlbum As String)
        'INSERTAR VIDEO EN LA DB
        conexion.Open()
        Try
            Dim consulta4 As String = "INSERT INTO VIDEO(NOMBRE,FECHA,RUTA,DURACION,ALBUM_ID_ALBUM) VALUES ('" + nombre + "',GETDATE(),'" + ruta + "'," + duracion + "," + idAlbum + ")"
            Dim comando4 As SqlCommand
            comando4 = New SqlCommand(consulta4, conexion)
            comando4.ExecuteNonQuery()
            MessageBox.Show("Los datos del video se guardaron correctamente")
        Catch ex As Exception
            MsgBox("Error al ingresar datos de foto a la DB")
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Sub CrearAlbumVideo(nombre As String, usuario As String)
        'INSERTAR album EN LA DB
        conexion.Open()
        Try
            Dim consulta3 As String = "INSERT INTO ALBUM(nombre,tipo_album,usuario_id_usuario) VALUES ('" + nombre + "','Videos'," + usuario + ")"
            Dim comando3 As SqlCommand
            comando3 = New SqlCommand(consulta3, conexion)
            comando3.ExecuteNonQuery()
            MessageBox.Show("Los datos del album de videos se guardaron correctamente")
        Catch ex As Exception
            MsgBox("Error al ingresar datos de album a la DB")
            conexion.Close()
        End Try
        conexion.Close()

        ActualizarAlbums()
    End Sub


End Class