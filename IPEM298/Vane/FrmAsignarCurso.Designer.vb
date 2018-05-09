<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsignarCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsignarCurso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_fecha_ins = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdeliminar_asig_curso = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEspecialidad = New System.Windows.Forms.ComboBox()
        Me.dgrAsignar = New System.Windows.Forms.DataGridView()
        Me.txtIdAlu = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelar2 = New System.Windows.Forms.Button()
        Me.cmdAsignar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.btn_imprimir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_fecha_ins)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdeliminar_asig_curso)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtEspecialidad)
        Me.GroupBox1.Controls.Add(Me.dgrAsignar)
        Me.GroupBox1.Controls.Add(Me.txtIdAlu)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.cmdActualizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdCancelar2)
        Me.GroupBox1.Controls.Add(Me.cmdAsignar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboCurso)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 255)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'Txt_fecha_ins
        '
        Me.Txt_fecha_ins.Location = New System.Drawing.Point(303, 73)
        Me.Txt_fecha_ins.Name = "Txt_fecha_ins"
        Me.Txt_fecha_ins.ReadOnly = True
        Me.Txt_fecha_ins.Size = New System.Drawing.Size(111, 20)
        Me.Txt_fecha_ins.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Seleccione el alumno para modificar o imprimir comprobante"
        '
        'cmdeliminar_asig_curso
        '
        Me.cmdeliminar_asig_curso.Image = CType(resources.GetObject("cmdeliminar_asig_curso.Image"), System.Drawing.Image)
        Me.cmdeliminar_asig_curso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdeliminar_asig_curso.Location = New System.Drawing.Point(329, 109)
        Me.cmdeliminar_asig_curso.Name = "cmdeliminar_asig_curso"
        Me.cmdeliminar_asig_curso.Size = New System.Drawing.Size(86, 33)
        Me.cmdeliminar_asig_curso.TabIndex = 70
        Me.cmdeliminar_asig_curso.Text = "Eliminar"
        Me.cmdeliminar_asig_curso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdeliminar_asig_curso.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(385, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 24)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Buscar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtEspecialidad
        '
        Me.txtEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtEspecialidad.FormattingEnabled = True
        Me.txtEspecialidad.Items.AddRange(New Object() {"Ciclo Básico", "Economía y Administración ", "Turismo"})
        Me.txtEspecialidad.Location = New System.Drawing.Point(151, 74)
        Me.txtEspecialidad.Name = "txtEspecialidad"
        Me.txtEspecialidad.Size = New System.Drawing.Size(126, 21)
        Me.txtEspecialidad.TabIndex = 67
        '
        'dgrAsignar
        '
        Me.dgrAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrAsignar.Location = New System.Drawing.Point(13, 168)
        Me.dgrAsignar.MultiSelect = False
        Me.dgrAsignar.Name = "dgrAsignar"
        Me.dgrAsignar.RowHeadersVisible = False
        Me.dgrAsignar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgrAsignar.Size = New System.Drawing.Size(438, 79)
        Me.dgrAsignar.TabIndex = 66
        '
        'txtIdAlu
        '
        Me.txtIdAlu.Location = New System.Drawing.Point(406, 12)
        Me.txtIdAlu.Name = "txtIdAlu"
        Me.txtIdAlu.Size = New System.Drawing.Size(56, 20)
        Me.txtIdAlu.TabIndex = 65
        Me.txtIdAlu.Visible = False
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(318, 34)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.ReadOnly = True
        Me.txtDNI.Size = New System.Drawing.Size(59, 20)
        Me.txtDNI.TabIndex = 64
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(13, 35)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.ReadOnly = True
        Me.txtApellido.Size = New System.Drawing.Size(132, 20)
        Me.txtApellido.TabIndex = 63
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(155, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 62
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdActualizar.Location = New System.Drawing.Point(225, 108)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(86, 35)
        Me.cmdActualizar.TabIndex = 61
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "DNI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Nombre "
        '
        'cmdCancelar2
        '
        Me.cmdCancelar2.Image = CType(resources.GetObject("cmdCancelar2.Image"), System.Drawing.Image)
        Me.cmdCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar2.Location = New System.Drawing.Point(118, 109)
        Me.cmdCancelar2.Name = "cmdCancelar2"
        Me.cmdCancelar2.Size = New System.Drawing.Size(92, 33)
        Me.cmdCancelar2.TabIndex = 55
        Me.cmdCancelar2.Text = "Cancelar"
        Me.cmdCancelar2.UseVisualStyleBackColor = True
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Image = CType(resources.GetObject("cmdAsignar.Image"), System.Drawing.Image)
        Me.cmdAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAsignar.Location = New System.Drawing.Point(13, 109)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(91, 33)
        Me.cmdAsignar.TabIndex = 54
        Me.cmdAsignar.Text = "Asignar"
        Me.cmdAsignar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Especialidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Curso"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(13, 73)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(107, 21)
        Me.cboCurso.TabIndex = 51
        '
        'cmdVolver
        '
        Me.cmdVolver.Image = CType(resources.GetObject("cmdVolver.Image"), System.Drawing.Image)
        Me.cmdVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdVolver.Location = New System.Drawing.Point(385, 252)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(92, 36)
        Me.cmdVolver.TabIndex = 36
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'btn_imprimir
        '
        Me.btn_imprimir.Enabled = False
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_imprimir.Location = New System.Drawing.Point(275, 252)
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(104, 36)
        Me.btn_imprimir.TabIndex = 37
        Me.btn_imprimir.Text = "Generar comprobante"
        Me.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_imprimir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Inscripción"
        '
        'FrmAsignarCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 289)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_imprimir)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsignarCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Curso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrAsignar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCancelar2 As System.Windows.Forms.Button
    Friend WithEvents cmdAsignar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgrAsignar As System.Windows.Forms.DataGridView
    Friend WithEvents txtIdAlu As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents txtEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar_asig_curso As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_imprimir As System.Windows.Forms.Button
    Friend WithEvents Txt_fecha_ins As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
