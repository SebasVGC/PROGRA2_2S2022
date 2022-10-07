<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbFoto = New System.Windows.Forms.Label()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.textboxUsername = New System.Windows.Forms.TextBox()
        Me.textboxPass1 = New System.Windows.Forms.TextBox()
        Me.textboxPass2 = New System.Windows.Forms.TextBox()
        Me.textboxEdad = New System.Windows.Forms.TextBox()
        Me.textboxTipo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password confirmar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Foto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo de usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Registro de usuario"
        '
        'lbFoto
        '
        Me.lbFoto.AutoSize = True
        Me.lbFoto.Location = New System.Drawing.Point(318, 320)
        Me.lbFoto.Name = "lbFoto"
        Me.lbFoto.Size = New System.Drawing.Size(58, 16)
        Me.lbFoto.TabIndex = 8
        Me.lbFoto.Text = "ruta_foto"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(222, 105)
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(246, 22)
        Me.textboxNombre.TabIndex = 9
        '
        'textboxUsername
        '
        Me.textboxUsername.Location = New System.Drawing.Point(222, 144)
        Me.textboxUsername.Name = "textboxUsername"
        Me.textboxUsername.Size = New System.Drawing.Size(246, 22)
        Me.textboxUsername.TabIndex = 10
        '
        'textboxPass1
        '
        Me.textboxPass1.Location = New System.Drawing.Point(222, 186)
        Me.textboxPass1.Name = "textboxPass1"
        Me.textboxPass1.Size = New System.Drawing.Size(246, 22)
        Me.textboxPass1.TabIndex = 11
        '
        'textboxPass2
        '
        Me.textboxPass2.Location = New System.Drawing.Point(222, 227)
        Me.textboxPass2.Name = "textboxPass2"
        Me.textboxPass2.Size = New System.Drawing.Size(246, 22)
        Me.textboxPass2.TabIndex = 12
        '
        'textboxEdad
        '
        Me.textboxEdad.Location = New System.Drawing.Point(222, 266)
        Me.textboxEdad.Name = "textboxEdad"
        Me.textboxEdad.Size = New System.Drawing.Size(246, 22)
        Me.textboxEdad.TabIndex = 13
        '
        'textboxTipo
        '
        Me.textboxTipo.Location = New System.Drawing.Point(222, 350)
        Me.textboxTipo.Name = "textboxTipo"
        Me.textboxTipo.Size = New System.Drawing.Size(246, 22)
        Me.textboxTipo.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Examinar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(333, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormAdminRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 536)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textboxTipo)
        Me.Controls.Add(Me.textboxEdad)
        Me.Controls.Add(Me.textboxPass2)
        Me.Controls.Add(Me.textboxPass1)
        Me.Controls.Add(Me.textboxUsername)
        Me.Controls.Add(Me.textboxNombre)
        Me.Controls.Add(Me.lbFoto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAdminRegistro"
        Me.Text = "FormAdminRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbFoto As Label
    Friend WithEvents textboxNombre As TextBox
    Friend WithEvents textboxUsername As TextBox
    Friend WithEvents textboxPass1 As TextBox
    Friend WithEvents textboxPass2 As TextBox
    Friend WithEvents textboxEdad As TextBox
    Friend WithEvents textboxTipo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
