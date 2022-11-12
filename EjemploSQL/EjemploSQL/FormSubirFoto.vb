Imports System.Data.SqlClient
Imports System.Net

Public Class FormSubirFoto
    Dim rutaFoto As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenuCliente.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then
            lbRuta.Text = rutaFoto
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txtNombre = TextBoxNombre.Text
        Dim txtEtiqueta = TextBoxEtiqueta.Text
        Dim txtAlbum = TextBoxAlbum.Text

        If (txtAlbum = "") Then
            'Significa que no es un album nuevo
            Dim AlbumSeleccionado = ComboBoxAlbums.SelectedItem.ToString()
            Dim AlbumId = ObtenerIdAlbum(AlbumSeleccionado, "Fotos", usrId)

            Dim TagId = ObtenerIdTag(txtEtiqueta)
            If Not (TagId = "") Then
                'Si No es vacio, significa que la etiqueta existe
                CrearFoto(txtNombre, rutaFoto, TagId, AlbumId)
            Else
                'Si es vacio, significa que la etiqueta no existe y hay que crearla
                CrearEtiqueta(txtEtiqueta)
                'Ahora si, volver a pedir el id de la etiqueta
                TagId = ObtenerIdTag(txtEtiqueta)
                CrearFoto(txtNombre, rutaFoto, TagId, AlbumId)
            End If
        Else
            'Si no es una cadena vacia, se debe crear el album
            CrearAlbumFoto(txtAlbum, usrId)
            Dim AlbumId = ObtenerIdAlbum(txtAlbum, "Fotos", usrId)

            Dim TagId = ObtenerIdTag(txtEtiqueta)
            If Not (TagId = "") Then
                'Si No es vacio, significa que la etiqueta existe
                CrearFoto(txtNombre, rutaFoto, TagId, AlbumId)
            Else
                'Si es vacio, significa que la etiqueta no existe y hay que crearla
                CrearEtiqueta(txtEtiqueta)
                'Ahora si, volver a pedir el id de la etiqueta
                TagId = ObtenerIdTag(txtEtiqueta)
                CrearFoto(txtNombre, rutaFoto, TagId, AlbumId)
            End If

        End If
    End Sub

    Function ObtenerIdTag(nombreBuscado As String) As String
        Dim resultado As String = ""
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM etiqueta WHERE etiqueta= '" + nombreBuscado + "'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()
            Do While MiLector.Read()
                '0-id;  1= etiqueta;
                resultado = MiLector.GetInt32(0).ToString()
            Loop
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al buscar etiqueta")
            conexion.Close()
        End Try

        Return resultado
    End Function

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

    Sub CrearAlbumFoto(nombre As String, usuario As String)
        'INSERTAR album EN LA DB
        conexion.Open()
        Try
            Dim consulta3 As String = "INSERT INTO ALBUM(nombre,tipo_album,usuario_id_usuario) VALUES ('" + nombre + "','Fotos'," + usuario + ")"
            Dim comando3 As SqlCommand
            comando3 = New SqlCommand(consulta3, conexion)
            comando3.ExecuteNonQuery()
            MessageBox.Show("Los datos del album se guardaron correctamente")
        Catch ex As Exception
            MsgBox("Error al ingresar datos de album a la DB")
            conexion.Close()
        End Try
        conexion.Close()

        ActualizarAlbums()
    End Sub

    Sub CrearEtiqueta(nombre As String)
        'INSERTAR etiqueta EN LA DB
        conexion.Open()
        Try
            Dim consulta2 As String = "INSERT INTO ETIQUETA(ETIQUETA) VALUES ('" + nombre + "')"
            Console.WriteLine(consulta2)
            Dim comando2 As SqlCommand
            comando2 = New SqlCommand(consulta2, conexion)
            comando2.ExecuteNonQuery()
            MessageBox.Show("Los datos de la etiqueta se guardaron correctamente")
        Catch ex As Exception
            MsgBox("Error al ingresar datos de tag a la DB")
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Sub CrearFoto(nombre As String, ruta As String, idEtiqueta As String,idAlbum As String)
        'INSERTAR foto EN LA DB
        conexion.Open()
        Try
            Dim consulta4 As String = "INSERT INTO FOTO(NOMBRE,FECHA,RUTA,ETIQUETA_ID_ETIQUETA,ALBUM_ID_ALBUM) VALUES ('" + nombre + "',GETDATE(),'" + ruta + "'," + idEtiqueta + "," + idAlbum + ")"
            Dim comando4 As SqlCommand
            comando4 = New SqlCommand(consulta4, conexion)
            comando4.ExecuteNonQuery()
            MessageBox.Show("Los datos de la foto se guardaron correctamente")
        Catch ex As Exception
            MsgBox("Error al ingresar datos de foto a la DB")
            conexion.Close()
        End Try
        conexion.Close()
    End Sub

    Sub ActualizarAlbums()
        ComboBoxAlbums.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM ALBUM WHERE USUARIO_ID_USUARIO=" + usrId + "  AND TIPO_ALBUM = 'Fotos'"
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

End Class