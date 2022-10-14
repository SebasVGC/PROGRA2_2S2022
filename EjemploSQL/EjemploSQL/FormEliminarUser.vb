Imports System.Data.SqlClient

Public Class FormEliminarUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombreBorrar As String = ComboBoxUsuarios.SelectedItem.ToString()
        'ELIMINAR USUARIO DE LA DB
        conexion.Open()
        Try
            Dim consulta2 As String = "DELETE FROM USUARIO WHERE USERNAME='" + nombreBorrar + "'"
            Console.WriteLine(consulta2)
            Dim comando2 As SqlCommand
            comando2 = New SqlCommand(consulta2, conexion)
            comando2.ExecuteNonQuery()
            MessageBox.Show("Los datos del usuario se borraron correctamente")
        Catch ex As Exception
            MsgBox("Error al borrar datos de la DB")
            conexion.Close()
        End Try
        conexion.Close()

        ActualizarUsuarios()

    End Sub

    Sub ActualizarUsuarios()
        ComboBoxUsuarios.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM USUARIO WHERE NOT (ID_USUARIO=" + usrId + ");"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;2=edad,3=username...
                Dim nombre_ As String = MiLector.GetString(3)
                ComboBoxUsuarios.Items.Add(nombre_)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar albums")
        End Try

        conexion.Close()
    End Sub

End Class