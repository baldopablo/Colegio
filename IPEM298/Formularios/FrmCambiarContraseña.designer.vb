<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarContraseña
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambiarContraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassVieja = New System.Windows.Forms.TextBox()
        Me.txtpassNueva = New System.Windows.Forms.TextBox()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.txtnivel = New System.Windows.Forms.Label()
        Me.cmdCambiar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblBaja = New System.Windows.Forms.Label()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.lblAlta = New System.Windows.Forms.Label()
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Anterior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña Nueva:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir Contraseña:"
        '
        'txtpassVieja
        '
        Me.txtpassVieja.Location = New System.Drawing.Point(143, 40)
        Me.txtpassVieja.Name = "txtpassVieja"
        Me.txtpassVieja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassVieja.Size = New System.Drawing.Size(173, 20)
        Me.txtpassVieja.TabIndex = 1
        '
        'txtpassNueva
        '
        Me.txtpassNueva.AccessibleDescription = ""
        Me.txtpassNueva.Location = New System.Drawing.Point(143, 94)
        Me.txtpassNueva.Name = "txtpassNueva"
        Me.txtpassNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassNueva.Size = New System.Drawing.Size(173, 20)
        Me.txtpassNueva.TabIndex = 2
        '
        'txtRepetir
        '
        Me.txtRepetir.Location = New System.Drawing.Point(143, 153)
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepetir.Size = New System.Drawing.Size(173, 20)
        Me.txtRepetir.TabIndex = 3
        '
        'txtnivel
        '
        Me.txtnivel.AutoSize = True
        Me.txtnivel.Location = New System.Drawing.Point(90, 187)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(103, 13)
        Me.txtnivel.TabIndex = 8
        Me.txtnivel.Text = "Nivel de Seguridad: "
        '
        'cmdCambiar
        '
        Me.cmdCambiar.Image = CType(resources.GetObject("cmdCambiar.Image"), System.Drawing.Image)
        Me.cmdCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCambiar.Location = New System.Drawing.Point(47, 256)
        Me.cmdCambiar.Name = "cmdCambiar"
        Me.cmdCambiar.Size = New System.Drawing.Size(83, 33)
        Me.cmdCambiar.TabIndex = 5
        Me.cmdCambiar.Text = "Cambiar"
        Me.cmdCambiar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.Location = New System.Drawing.Point(139, 256)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(93, 33)
        Me.cmdCancelar.TabIndex = 4
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1.TabIndex = 3
        '
        'txtCancelar
        '
        Me.txtCancelar.Location = New System.Drawing.Point(287, 133)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.txtCancelar.TabIndex = 10
        Me.txtCancelar.Text = "Cancelar"
        Me.txtCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(238, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(93, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(93, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 32)
        Me.Button3.TabIndex = 14
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(93, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(192, 32)
        Me.Button4.TabIndex = 15
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'lblBaja
        '
        Me.lblBaja.AutoSize = True
        Me.lblBaja.Location = New System.Drawing.Point(190, 187)
        Me.lblBaja.Name = "lblBaja"
        Me.lblBaja.Size = New System.Drawing.Size(28, 13)
        Me.lblBaja.TabIndex = 16
        Me.lblBaja.Text = "Baja"
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Location = New System.Drawing.Point(190, 187)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(36, 13)
        Me.lblMedia.TabIndex = 17
        Me.lblMedia.Text = "Media"
        Me.lblMedia.Visible = False
        '
        'lblAlta
        '
        Me.lblAlta.AutoSize = True
        Me.lblAlta.Location = New System.Drawing.Point(188, 187)
        Me.lblAlta.Name = "lblAlta"
        Me.lblAlta.Size = New System.Drawing.Size(25, 13)
        Me.lblAlta.TabIndex = 18
        Me.lblAlta.Text = "Alta"
        Me.lblAlta.Visible = False
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.ForeColor = System.Drawing.Color.Blue
        Me.lblmensaje.Location = New System.Drawing.Point(40, 115)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(281, 26)
        Me.lblmensaje.TabIndex = 19
        Me.lblmensaje.Text = "Atención! Para una contraseña robusta, introduzca letras, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "números y más de ocho" & _
            " caracteres." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblmensaje.Visible = False
        '
        'FrmCambiarContraseña
        '
        Me.AcceptButton = Me.cmdCambiar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 301)
        Me.Controls.Add(Me.lblmensaje)
        Me.Controls.Add(Me.lblAlta)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.lblBaja)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdCambiar)
        Me.Controls.Add(Me.txtnivel)
        Me.Controls.Add(Me.txtRepetir)
        Me.Controls.Add(Me.txtpassNueva)
        Me.Controls.Add(Me.txtpassVieja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmCambiarContraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpassVieja As System.Windows.Forms.TextBox
    Friend WithEvents txtpassNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtRepetir As System.Windows.Forms.TextBox
    Friend WithEvents txtnivel As System.Windows.Forms.Label
    Friend WithEvents cmdCambiar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblBaja As System.Windows.Forms.Label
    Friend WithEvents lblMedia As System.Windows.Forms.Label
    Friend WithEvents lblAlta As System.Windows.Forms.Label
    Friend WithEvents lblmensaje As System.Windows.Forms.Label
End Class
