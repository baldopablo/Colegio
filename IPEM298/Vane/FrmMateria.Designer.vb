<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMateria))
        Me.rbnNuevo = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.datosp = New System.Windows.Forms.GroupBox()
        Me.txtEspecialidad = New System.Windows.Forms.ComboBox()
        Me.txtidMate = New System.Windows.Forms.TextBox()
        Me.rbnActualizar = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_ver_todas_abm_mat = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNombreMa = New System.Windows.Forms.TextBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.drgMateria = New System.Windows.Forms.DataGridView()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.datosp.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.drgMateria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbnNuevo
        '
        Me.rbnNuevo.AutoSize = True
        Me.rbnNuevo.Location = New System.Drawing.Point(340, 7)
        Me.rbnNuevo.Name = "rbnNuevo"
        Me.rbnNuevo.Size = New System.Drawing.Size(81, 17)
        Me.rbnNuevo.TabIndex = 31
        Me.rbnNuevo.TabStop = True
        Me.rbnNuevo.Text = "Alta Materia"
        Me.rbnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Materia"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(6, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(180, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código de Materia"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(6, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Especialidad"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGuardar.Location = New System.Drawing.Point(6, 146)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(82, 33)
        Me.cmdGuardar.TabIndex = 47
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.Location = New System.Drawing.Point(101, 146)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(85, 33)
        Me.cmdCancelar.TabIndex = 48
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'datosp
        '
        Me.datosp.Controls.Add(Me.txtEspecialidad)
        Me.datosp.Controls.Add(Me.txtidMate)
        Me.datosp.Controls.Add(Me.cmdCancelar)
        Me.datosp.Controls.Add(Me.cmdGuardar)
        Me.datosp.Controls.Add(Me.Label6)
        Me.datosp.Controls.Add(Me.txtNombre)
        Me.datosp.Controls.Add(Me.Label2)
        Me.datosp.Controls.Add(Me.txtCodigo)
        Me.datosp.Controls.Add(Me.Label1)
        Me.datosp.Location = New System.Drawing.Point(331, 16)
        Me.datosp.Name = "datosp"
        Me.datosp.Size = New System.Drawing.Size(197, 193)
        Me.datosp.TabIndex = 30
        Me.datosp.TabStop = False
        Me.datosp.Text = "                               "
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEspecialidad.FormattingEnabled = True
        Me.txtEspecialidad.Items.AddRange(New Object() {"Ciclo Básico", "Economía y Administración", "Turismo"})
        Me.txtEspecialidad.Location = New System.Drawing.Point(9, 119)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(177, 21)
        Me.txtEspecialidad.TabIndex = 35
        '
        'txtidMate
        '
        Me.txtidMate.Enabled = False
        Me.txtidMate.Location = New System.Drawing.Point(159, 96)
        Me.txtidMate.Name = "txtidMate"
        Me.txtidMate.Size = New System.Drawing.Size(32, 20)
        Me.txtidMate.TabIndex = 37
        Me.txtidMate.Visible = False
        '
        'rbnActualizar
        '
        Me.rbnActualizar.AutoSize = True
        Me.rbnActualizar.Location = New System.Drawing.Point(22, 7)
        Me.rbnActualizar.Name = "rbnActualizar"
        Me.rbnActualizar.Size = New System.Drawing.Size(73, 17)
        Me.rbnActualizar.TabIndex = 33
        Me.rbnActualizar.TabStop = True
        Me.rbnActualizar.Text = "Búsqueda"
        Me.rbnActualizar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_ver_todas_abm_mat)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNombreMa)
        Me.GroupBox3.Controls.Add(Me.cmdActualizar)
        Me.GroupBox3.Controls.Add(Me.cmdLimpiar)
        Me.GroupBox3.Controls.Add(Me.cmdBuscar)
        Me.GroupBox3.Controls.Add(Me.drgMateria)
        Me.GroupBox3.Controls.Add(Me.cmdEliminar)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 242)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "                        "
        '
        'btn_ver_todas_abm_mat
        '
        Me.btn_ver_todas_abm_mat.Image = CType(resources.GetObject("btn_ver_todas_abm_mat.Image"), System.Drawing.Image)
        Me.btn_ver_todas_abm_mat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ver_todas_abm_mat.Location = New System.Drawing.Point(214, 12)
        Me.btn_ver_todas_abm_mat.Name = "btn_ver_todas_abm_mat"
        Me.btn_ver_todas_abm_mat.Size = New System.Drawing.Size(88, 40)
        Me.btn_ver_todas_abm_mat.TabIndex = 37
        Me.btn_ver_todas_abm_mat.Text = "Ver Listado Materias"
        Me.btn_ver_todas_abm_mat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ver_todas_abm_mat.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Nombre Materia"
        '
        'txtNombreMa
        '
        Me.txtNombreMa.Enabled = False
        Me.txtNombreMa.Location = New System.Drawing.Point(14, 32)
        Me.txtNombreMa.Name = "txtNombreMa"
        Me.txtNombreMa.Size = New System.Drawing.Size(109, 20)
        Me.txtNombreMa.TabIndex = 35
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdActualizar.Location = New System.Drawing.Point(196, 201)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(86, 35)
        Me.cmdActualizar.TabIndex = 25
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActualizar.UseVisualStyleBackColor = True
        Me.cmdActualizar.Visible = False
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Image = CType(resources.GetObject("cmdLimpiar.Image"), System.Drawing.Image)
        Me.cmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLimpiar.Location = New System.Drawing.Point(104, 201)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(86, 35)
        Me.cmdLimpiar.TabIndex = 24
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(143, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(59, 40)
        Me.cmdBuscar.TabIndex = 31
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'drgMateria
        '
        Me.drgMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.drgMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgMateria.Location = New System.Drawing.Point(10, 58)
        Me.drgMateria.Name = "drgMateria"
        Me.drgMateria.RowHeadersVisible = False
        Me.drgMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgMateria.Size = New System.Drawing.Size(292, 135)
        Me.drgMateria.TabIndex = 2
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEliminar.Location = New System.Drawing.Point(10, 201)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(86, 35)
        Me.cmdEliminar.TabIndex = 23
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.Location = New System.Drawing.Point(424, 216)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 33)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FrmMateria
        '
        Me.AcceptButton = Me.cmdBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 258)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.rbnActualizar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.rbnNuevo)
        Me.Controls.Add(Me.datosp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmMateria"
        Me.Text = "Gestión de materias"
        Me.datosp.ResumeLayout(False)
        Me.datosp.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.drgMateria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnNuevo As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents datosp As System.Windows.Forms.GroupBox
    Friend WithEvents rbnActualizar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtidMate As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNombreMa As System.Windows.Forms.TextBox
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents drgMateria As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents btn_ver_todas_abm_mat As System.Windows.Forms.Button
End Class
