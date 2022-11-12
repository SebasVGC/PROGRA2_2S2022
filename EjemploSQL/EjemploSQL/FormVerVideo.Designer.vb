<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVerVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVerVideo))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxAlbums = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVideos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.reproductorMP4 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbNombreVideo = New System.Windows.Forms.Label()
        Me.lbDuracionVideo = New System.Windows.Forms.Label()
        Me.lbFechaVideo = New System.Windows.Forms.Label()
        CType(Me.reproductorMP4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxAlbums
        '
        Me.ComboBoxAlbums.FormattingEnabled = True
        Me.ComboBoxAlbums.Location = New System.Drawing.Point(172, 87)
        Me.ComboBoxAlbums.Name = "ComboBoxAlbums"
        Me.ComboBoxAlbums.Size = New System.Drawing.Size(310, 24)
        Me.ComboBoxAlbums.TabIndex = 1
        '
        'ComboBoxVideos
        '
        Me.ComboBoxVideos.FormattingEnabled = True
        Me.ComboBoxVideos.Location = New System.Drawing.Point(172, 155)
        Me.ComboBoxVideos.Name = "ComboBoxVideos"
        Me.ComboBoxVideos.Size = New System.Drawing.Size(310, 24)
        Me.ComboBoxVideos.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ver videos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Album"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Video"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Ver videos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(507, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Play"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'reproductorMP4
        '
        Me.reproductorMP4.Enabled = True
        Me.reproductorMP4.Location = New System.Drawing.Point(57, 185)
        Me.reproductorMP4.Name = "reproductorMP4"
        Me.reproductorMP4.OcxState = CType(resources.GetObject("reproductorMP4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.reproductorMP4.Size = New System.Drawing.Size(389, 358)
        Me.reproductorMP4.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(780, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(780, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Duracion minutos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(780, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha:"
        '
        'lbNombreVideo
        '
        Me.lbNombreVideo.AutoSize = True
        Me.lbNombreVideo.Location = New System.Drawing.Point(783, 310)
        Me.lbNombreVideo.Name = "lbNombreVideo"
        Me.lbNombreVideo.Size = New System.Drawing.Size(89, 16)
        Me.lbNombreVideo.TabIndex = 12
        Me.lbNombreVideo.Text = "nombreVideo"
        '
        'lbDuracionVideo
        '
        Me.lbDuracionVideo.AutoSize = True
        Me.lbDuracionVideo.Location = New System.Drawing.Point(783, 379)
        Me.lbDuracionVideo.Name = "lbDuracionVideo"
        Me.lbDuracionVideo.Size = New System.Drawing.Size(38, 16)
        Me.lbDuracionVideo.TabIndex = 13
        Me.lbDuracionVideo.Text = "00:00"
        '
        'lbFechaVideo
        '
        Me.lbFechaVideo.AutoSize = True
        Me.lbFechaVideo.Location = New System.Drawing.Point(783, 440)
        Me.lbFechaVideo.Name = "lbFechaVideo"
        Me.lbFechaVideo.Size = New System.Drawing.Size(57, 16)
        Me.lbFechaVideo.TabIndex = 14
        Me.lbFechaVideo.Text = "00/00/00"
        '
        'FormVerVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 705)
        Me.Controls.Add(Me.lbFechaVideo)
        Me.Controls.Add(Me.lbDuracionVideo)
        Me.Controls.Add(Me.lbNombreVideo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.reproductorMP4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxVideos)
        Me.Controls.Add(Me.ComboBoxAlbums)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormVerVideo"
        Me.Text = "FormVerVideo"
        CType(Me.reproductorMP4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxAlbums As ComboBox
    Friend WithEvents ComboBoxVideos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents reproductorMP4 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbNombreVideo As Label
    Friend WithEvents lbDuracionVideo As Label
    Friend WithEvents lbFechaVideo As Label
End Class
