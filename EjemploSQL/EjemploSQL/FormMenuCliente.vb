﻿Public Class FormMenuCliente
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        FormEditarPerfil.textBoxNombre.Text = usrNombre
        FormEditarPerfil.textBoxEdad.Text = usrEdad
        FormEditarPerfil.lbRuta.Text = usrFoto

        FormEditarPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormSubirFoto.ActualizarAlbums()
        FormSubirFoto.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormSubirVideo.ActualizarAlbums()
        FormSubirVideo.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormVerVideo.ActualizarAlbums()
        FormVerVideo.Show()
        Me.Hide()
    End Sub
End Class