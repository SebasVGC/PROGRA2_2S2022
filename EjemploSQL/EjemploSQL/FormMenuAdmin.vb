﻿Public Class FormMenuAdmin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormAdminRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usrId = ""
        usrNombre = ""
        usrUsername = ""
        usrEdad = ""
        usrTipo = ""
        usrFoto = ""
        usrPass = ""

        Form1.Show()
        Me.Hide()
    End Sub
End Class