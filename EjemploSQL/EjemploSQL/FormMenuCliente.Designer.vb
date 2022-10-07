<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuCliente
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnEditProfile = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Subir foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(249, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Subir video"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(249, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(233, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Ver fotos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(249, 295)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(233, 36)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Ver videos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnEditProfile
        '
        Me.btnEditProfile.Location = New System.Drawing.Point(249, 80)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.Size = New System.Drawing.Size(233, 36)
        Me.btnEditProfile.TabIndex = 4
        Me.btnEditProfile.Text = "Editar perfil"
        Me.btnEditProfile.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(249, 345)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(233, 36)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Cerrar sesion"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'FormMenuCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnEditProfile)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormMenuCliente"
        Me.Text = "FormMenuCliente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents Button6 As Button
End Class
