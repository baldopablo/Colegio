<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarMateria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarMateria))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_eliminar_asig_mat = New System.Windows.Forms.Button()
        Me.cmd_buscar_asig_mat = New System.Windows.Forms.Button()
        Me.txtidProfxmat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCantHsCat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbomateria = New System.Windows.Forms.ComboBox()
        Me.dgrAsignar = New System.Windows.Forms.DataGridView()
        Me.txtIdPers = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancelar2 = New System.Windows.Forms.Button()
        Me.cmdAsignar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.Btn_limpiar_asig_mat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmd_eliminar_asig_mat)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar_asig_mat)
        Me.GroupBox1.Controls.Add(Me.txtidProfxmat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtCantHsCat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbomateria)
        Me.GroupBox1.Controls.Add(Me.dgrAsignar)
        Me.GroupBox1.Controls.Add(Me.txtIdPers)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar2)
        Me.GroupBox1.Controls.Add(Me.cmdAsignar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboCurso)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 270)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Elija un docente a modificar"
        '
        'cmd_eliminar_asig_mat
        '
        Me.cmd_eliminar_asig_mat.Enabled = False
        Me.cmd_eliminar_asig_mat.Image = CType(resources.GetObject("cmd_eliminar_asig_mat.Image"), System.Drawing.Image)
        Me.cmd_eliminar_asig_mat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_eliminar_asig_mat.Location = New System.Drawing.Point(323, 98)
        Me.cmd_eliminar_asig_mat.Name = "cmd_eliminar_asig_mat"
        Me.cmd_eliminar_asig_mat.Size = New System.Drawing.Size(86, 35)
        Me.cmd_eliminar_asig_mat.TabIndex = 73
        Me.cmd_eliminar_asig_mat.Text = "Eliminar"
        Me.cmd_eliminar_asig_mat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_eliminar_asig_mat.UseVisualStyleBackColor = True
        '
        'cmd_buscar_asig_mat
        '
        Me.cmd_buscar_asig_mat.Image = CType(resources.GetObject("cmd_buscar_asig_mat.Image"), System.Drawing.Image)
        Me.cmd_buscar_asig_mat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar_asig_mat.Location = New System.Drawing.Point(400, 32)
        Me.cmd_buscar_asig_mat.Name = "cmd_buscar_asig_mat"
        Me.cmd_buscar_asig_mat.Size = New System.Drawing.Size(64, 20)
        Me.cmd_buscar_asig_mat.TabIndex = 72
        Me.cmd_buscar_asig_mat.Text = "Buscar"
        Me.cmd_buscar_asig_mat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_buscar_asig_mat.UseVisualStyleBackColor = True
        Me.cmd_buscar_asig_mat.Visible = False
        '
        'txtidProfxmat
        '
        Me.txtidProfxmat.Location = New System.Drawing.Point(447, 96)
        Me.txtidProfxmat.Name = "txtidProfxmat"
        Me.txtidProfxmat.Size = New System.Drawing.Size(33, 20)
        Me.txtidProfxmat.TabIndex = 71
        Me.txtidProfxmat.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(278, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Cant. de Hs Cátedras"
        Me.Label5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nombre "
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(149, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 62
        '
        'txtCantHsCat
        '
        Me.txtCantHsCat.Location = New System.Drawing.Point(304, 72)
        Me.txtCantHsCat.Name = "txtCantHsCat"
        Me.txtCantHsCat.Size = New System.Drawing.Size(52, 20)
        Me.txtCantHsCat.TabIndex = 69
        Me.txtCantHsCat.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Materia"
        '
        'cbomateria
        '
        Me.cbomateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomateria.FormattingEnabled = True
        Me.cbomateria.Location = New System.Drawing.Point(152, 72)
        Me.cbomateria.Name = "cbomateria"
        Me.cbomateria.Size = New System.Drawing.Size(121, 21)
        Me.cbomateria.TabIndex = 67
        '
        'dgrAsignar
        '
        Me.dgrAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrAsignar.Location = New System.Drawing.Point(11, 159)
        Me.dgrAsignar.MultiSelect = False
        Me.dgrAsignar.Name = "dgrAsignar"
        Me.dgrAsignar.RowHeadersVisible = False
        Me.dgrAsignar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrAsignar.Size = New System.Drawing.Size(469, 105)
        Me.dgrAsignar.TabIndex = 66
        '
        'txtIdPers
        '
        Me.txtIdPers.Location = New System.Drawing.Point(408, 13)
        Me.txtIdPers.Name = "txtIdPers"
        Me.txtIdPers.Size = New System.Drawing.Size(56, 20)
        Me.txtIdPers.TabIndex = 65
        Me.txtIdPers.Visible = False
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(304, 32)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.ReadOnly = True
        Me.txtDNI.Size = New System.Drawing.Size(78, 20)
        Me.txtDNI.TabIndex = 64
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(11, 32)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(132, 20)
        Me.txtApellido.TabIndex = 63
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Enabled = False
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdActualizar.Location = New System.Drawing.Point(221, 99)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(86, 35)
        Me.cmdActualizar.TabIndex = 61
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Apellido"
        '
        'cmdCancelar2
        '
        Me.cmdCancelar2.Image = CType(resources.GetObject("cmdCancelar2.Image"), System.Drawing.Image)
        Me.cmdCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar2.Location = New System.Drawing.Point(114, 100)
        Me.cmdCancelar2.Name = "cmdCancelar2"
        Me.cmdCancelar2.Size = New System.Drawing.Size(92, 33)
        Me.cmdCancelar2.TabIndex = 55
        Me.cmdCancelar2.Text = "Cancelar"
        Me.cmdCancelar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar2.UseVisualStyleBackColor = True
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Image = CType(resources.GetObject("cmdAsignar.Image"), System.Drawing.Image)
        Me.cmdAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAsignar.Location = New System.Drawing.Point(11, 100)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(91, 33)
        Me.cmdAsignar.TabIndex = 54
        Me.cmdAsignar.Text = "Asignar"
        Me.cmdAsignar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Curso"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(14, 72)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(107, 21)
        Me.cboCurso.TabIndex = 51
        '
        'cmdVolver
        '
        Me.cmdVolver.Image = CType(resources.GetObject("cmdVolver.Image"), System.Drawing.Image)
        Me.cmdVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdVolver.Location = New System.Drawing.Point(400, 271)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(92, 29)
        Me.cmdVolver.TabIndex = 38
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'Btn_limpiar_asig_mat
        '
        Me.Btn_limpiar_asig_mat.Image = CType(resources.GetObject("Btn_limpiar_asig_mat.Image"), System.Drawing.Image)
        Me.Btn_limpiar_asig_mat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_limpiar_asig_mat.Location = New System.Drawing.Point(325, 271)
        Me.Btn_limpiar_asig_mat.Name = "Btn_limpiar_asig_mat"
        Me.Btn_limpiar_asig_mat.Size = New System.Drawing.Size(69, 29)
        Me.Btn_limpiar_asig_mat.TabIndex = 39
        Me.Btn_limpiar_asig_mat.Text = "Limpiar"
        Me.Btn_limpiar_asig_mat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_limpiar_asig_mat.UseVisualStyleBackColor = True
        '
        'FrmAsignarMateria
        '
        Me.AcceptButton = Me.cmd_buscar_asig_mat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 304)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_limpiar_asig_mat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdVolver)
        Me.Name = "FrmAsignarMateria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAsignarMateria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgrAsignar As System.Windows.Forms.DataGridView
    Friend WithEvents txtIdPers As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar2 As System.Windows.Forms.Button
    Friend WithEvents cmdAsignar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbomateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantHsCat As System.Windows.Forms.TextBox
    Friend WithEvents txtidProfxmat As System.Windows.Forms.TextBox
    Friend WithEvents cmd_buscar_asig_mat As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_asig_mat As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btn_limpiar_asig_mat As System.Windows.Forms.Button
End Class
