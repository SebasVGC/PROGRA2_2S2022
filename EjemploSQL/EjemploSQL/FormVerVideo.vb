Imports System.Data.SqlClient

Public Class FormVerVideo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reproductorMP4.close()
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

    Sub ActualizarVideos(idRecibido As String)
        ComboBoxVideos.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM VIDEO WHERE ALBUM_ID_ALBUM=" + idRecibido + ""
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;...
                Dim nombreVideos As String = MiLector.GetString(1)
                ComboBoxVideos.Items.Add(nombreVideos)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar videos")
        End Try

        conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AlbumSeleccionado = ComboBoxAlbums.SelectedItem.ToString()
        Dim AlbumId = ObtenerIdAlbum(AlbumSeleccionado, "Videos", usrId)
        ActualizarVideos(AlbumId)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim VideoSeleccionado = ComboBoxVideos.SelectedItem.ToString()
        Dim VideoURL = ObtenerURLVideo(VideoSeleccionado)
        reproductorMP4.URL = VideoURL
        actualizarLabels(VideoSeleccionado)
    End Sub

    Function ObtenerURLVideo(nombreBuscado As String) As String
        Dim resultado As String = ""
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM video WHERE nombre= '" + nombreBuscado + "'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre; 2=fecha;3=ruta...
                resultado = MiLector.GetString(3)
            Loop
        Catch ex As Exception
            MsgBox("Error al buscar etiqueta")
            conexion.Close()
        End Try

        conexion.Close()
        Return resultado
    End Function

    Sub actualizarLabels(nombreBuscado As String)
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM video WHERE nombre= '" + nombreBuscado + "'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre; 2=fecha;3=ruta...
                lbNombreVideo.Text = MiLector.GetString(1)
                lbDuracionVideo.Text = MiLector.GetInt32(4).ToString()
                lbFechaVideo.Text = MiLector.GetDateTime(2).ToString()
            Loop
        Catch ex As Exception
            MsgBox("Error al buscar etiqueta")
            conexion.Close()
        End Try

        conexion.Close()
    End Sub


End Class