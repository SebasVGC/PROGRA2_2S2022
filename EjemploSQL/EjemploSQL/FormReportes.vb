Imports System.Data.SqlClient
Public Class FormReportes

    Dim MiCmd As SqlCommand
    Dim adaptador As SqlDataAdapter
    Dim setDatos As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta_rep1 As String = "
            SELECT USUARIO.USERNAME AS 'NOMBRE DE USUARIO',COUNT(ID_ALBUM) AS 'CANTIDAD'
            FROM ALBUM
            INNER JOIN USUARIO
            ON USUARIO.ID_USUARIO=ALBUM.USUARIO_ID_USUARIO
            GROUP BY USUARIO.USERNAME
            ORDER BY USUARIO.USERNAME ASC
            ;
        "
        MostrarReporte(consulta_rep1)
    End Sub

    Sub MostrarReporte(entrada_ As String)
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = entrada_

            MiCmd.CommandText = consulta
            MiCmd.CommandType = CommandType.Text
            MiCmd.Connection = conexion
            adaptador = New SqlDataAdapter(MiCmd)
            setDatos = New DataSet()
            adaptador.Fill(setDatos)
            DataGridView1.DataSource = setDatos.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error al buscar datos")
            conexion.Close()
        End Try



        conexion.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta_rep1 As String = "
            SELECT AVG(EDAD) AS 'EDAD PROMEDIO'
            FROM USUARIO
            ;
        "
        MostrarReporte(consulta_rep1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim consulta_rep1 As String = "
            SELECT TOP 3 ETIQUETA.ETIQUETA,COUNT(ETIQUETA.ID_ETIQUETA) AS 'CANTIDAD'
            FROM FOTO
            INNER JOIN ETIQUETA
            ON ETIQUETA.ID_ETIQUETA=FOTO.ETIQUETA_ID_ETIQUETA
            GROUP BY ETIQUETA.ETIQUETA
            ORDER BY 'CANTIDAD' DESC
            ;
        "
        MostrarReporte(consulta_rep1)
    End Sub
End Class