Imports System.Data.SqlClient
Imports System.Net

Public Class Form1
    Dim datosConexion As String = "Data Source=DESKTOP-HH0VCVP\SQLEXPRESS;Initial Catalog=ejemplo1;Integrated Security=True"
    Dim conexion As New SqlConnection(datosConexion)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion.Open()
            MsgBox("Conexion con la BD exitosa")
            Label1.Text = "Estado: Conectado"
            Button2.Enabled = True
            Button3.Enabled = True

            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al conectar la DB")
        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MiCmd As SqlCommand
        Dim adaptador As SqlDataAdapter
        Dim setDatos As DataSet

        Dim consulta1 As String = "
            SELECT * FROM alumnos
            ;
        "
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = consulta1
            MiCmd.CommandText = consulta
            MiCmd.CommandType = CommandType.Text
            MiCmd.Connection = conexion
            adaptador = New SqlDataAdapter(MiCmd)
            setDatos = New DataSet()
            adaptador.Fill(setDatos)
            DataGridView1.DataSource = setDatos.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error al realizar consulta")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MiCmd As SqlCommand
        Dim adaptador As SqlDataAdapter
        Dim setDatos As DataSet

        Dim consulta1 As String = "
            SELECT * FROM alumnos
            WHERE edad > 14
            ;
        "
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()


        conexion.Open()
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = consulta1
            MiCmd.CommandText = consulta
            MiCmd.CommandType = CommandType.Text
            MiCmd.Connection = conexion
            adaptador = New SqlDataAdapter(MiCmd)
            setDatos = New DataSet()
            adaptador.Fill(setDatos)
            DataGridView1.DataSource = setDatos.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error al realizar consulta")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM alumnos WHERE nombre='Luis'"
            MiCmd.CommandText = consulta

            conexion.Open()
            MiLector = MiCmd.ExecuteReader()

            Dim carnet As String = ""
            Dim nombre As String = ""



            Do While MiLector.Read()
                '0-carnet;  1= nombre...
                carnet = MiLector.GetInt32(0).ToString()
                nombre = MiLector.GetString(1)

            Loop

            'If (nombre = textbox2.text) Then
            '    MsgBox("Se llama luis")
            'End If

            conexion.Close()

        Catch ex As Exception
            MsgBox("Error al buscar usuario")
        End Try
    End Sub
End Class
