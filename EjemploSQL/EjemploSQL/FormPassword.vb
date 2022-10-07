Public Class FormPassword
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtPass = txtPassword.Text
        Dim passwordDesencript = Desencriptar(usrPass)

        If (passwordDesencript = txtPass) Then
            MsgBox("Login Exitoso")

            'Verificar el tipo usuario para mostrar el menu admin, o el menu cliente
            If (usrTipo = "Cliente") Then
                'MsgBox("Cliente")
                FormMenuCliente.Show()
                Me.Hide()
            Else
                'MsgBox("Admin")
                FormMenuAdmin.Show()
                Me.Hide()
            End If
        Else
                MsgBox("Login Fallido")
        End If

        txtPassword.Text = ""
        Form1.txtUsername.Text = ""
    End Sub
End Class