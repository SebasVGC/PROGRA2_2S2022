Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Abrir la variable "conexion"
            conexion.Open()
            MsgBox("Conexion con la BD exitosa")
            txtUsername.Enabled = True
            btnLogin.Enabled = True
            btnRegistro.Enabled = True
            lbEstado.Text = "Estado: Conectado"
            conexion.Close()
        Catch ex As Exception
            'Codigo que se ejecuta si falla
            MsgBox("Error al conectar con la BD")
        End Try
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        FormRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        Dim txtNombreUsr As String = txtUsername.Text

        If Not (txtNombreUsr = "") Then
            'Si no esta vacio, podemos proceder, sino no
            Try
                MiCmd = conexion.CreateCommand
                Dim consulta As String = "SELECT * FROM usuario WHERE username= '" + txtNombreUsr + "'"
                MiCmd.CommandText = consulta

                conexion.Open()
                MiLector = MiCmd.ExecuteReader()

                Do While MiLector.Read()
                    '0-id;  1= nombre;  2= edad;  3=username; 4=pass; 5=tipo; 6=foto
                    usrId = MiLector.GetInt32(0).ToString()
                    usrNombre = MiLector.GetString(1)
                    usrEdad = MiLector.GetInt32(2).ToString()
                    usrUsername = MiLector.GetString(3)
                    usrPass = MiLector.GetString(4)
                    usrTipo = MiLector.GetString(5)
                    usrFoto = MiLector.GetString(6)
                Loop
                conexion.Close()

                If Not (usrNombre = "") Then
                    'Si no es una cadena vacio, funciono, sino no

                    'Actualizar el formulario de password
                    FormPassword.PictureBox1.Image = Image.FromFile(usrFoto)
                    FormPassword.lbUsername.Text = usrUsername

                    'Mostrar el form de password
                    FormPassword.Show()
                    Me.Hide()
                Else
                    MsgBox("Usuario no encontrado")
                End If

            Catch ex As Exception
                MsgBox("Error al buscar usuario")
            End Try

        Else
            MsgBox("Ingrese el nombre usuario")
        End If


    End Sub
End Class
