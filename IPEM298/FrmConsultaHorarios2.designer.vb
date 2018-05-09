<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaHorarios2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaHorarios2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId_personal = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.dgrHorario = New System.Windows.Forms.DataGridView()
        Me.Horario = New System.Windows.Forms.GroupBox()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbnTodos = New System.Windows.Forms.RadioButton()
        Me.rbnMateria = New System.Windows.Forms.RadioButton()
        Me.rbnCurso = New System.Windows.Forms.RadioButton()
        Me.rbnDía = New System.Windows.Forms.RadioButton()
        Me.cbobusqueda = New System.Windows.Forms.ComboBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrHorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Horario.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id_Personal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI"
        '
        'txtId_personal
        '
        Me.txtId_personal.AccessibleName = "txtId_personal"
        Me.txtId_personal.Enabled = False
        Me.txtId_personal.Location = New System.Drawing.Point(28, 61)
        Me.txtId_personal.Name = "txtId_personal"
        Me.txtId_personal.Size = New System.Drawing.Size(104, 20)
        Me.txtId_personal.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(149, 61)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(315, 61)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(181, 20)
        Me.txtApellido.TabIndex = 7
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(28, 113)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(148, 20)
        Me.txtDNI.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtId_personal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 158)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Docente"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(302, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBuscar.Location = New System.Drawing.Point(208, 109)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(88, 26)
        Me.cmdBuscar.TabIndex = 10
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dgrHorario
        '
        Me.dgrHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrHorario.Location = New System.Drawing.Point(16, 48)
        Me.dgrHorario.Name = "dgrHorario"
        Me.dgrHorario.Size = New System.Drawing.Size(847, 277)
        Me.dgrHorario.TabIndex = 10
        '
        'Horario
        '
        Me.Horario.Controls.Add(Me.cmdImprimir)
        Me.Horario.Controls.Add(Me.dgrHorario)
        Me.Horario.Location = New System.Drawing.Point(14, 181)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(877, 367)
        Me.Horario.TabIndex = 11
        Me.Horario.TabStop = False
        Me.Horario.Text = "Horario"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(376, 331)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(88, 30)
        Me.cmdImprimir.TabIndex = 11
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(804, 582)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(91, 30)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbnTodos)
        Me.GroupBox2.Controls.Add(Me.rbnMateria)
        Me.GroupBox2.Controls.Add(Me.rbnCurso)
        Me.GroupBox2.Controls.Add(Me.rbnDía)
        Me.GroupBox2.Controls.Add(Me.cbobusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 157)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por:"
        '
        'rbnTodos
        '
        Me.rbnTodos.AutoSize = True
        Me.rbnTodos.Location = New System.Drawing.Point(26, 117)
        Me.rbnTodos.Name = "rbnTodos"
        Me.rbnTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbnTodos.TabIndex = 19
        Me.rbnTodos.TabStop = True
        Me.rbnTodos.Text = "Todos"
        Me.rbnTodos.UseVisualStyleBackColor = True
        '
        'rbnMateria
        '
        Me.rbnMateria.AutoSize = True
        Me.rbnMateria.Location = New System.Drawing.Point(26, 88)
        Me.rbnMateria.Name = "rbnMateria"
        Me.rbnMateria.Size = New System.Drawing.Size(60, 17)
        Me.rbnMateria.TabIndex = 18
        Me.rbnMateria.TabStop = True
        Me.rbnMateria.Text = "Materia"
        Me.rbnMateria.UseVisualStyleBackColor = True
        '
        'rbnCurso
        '
        Me.rbnCurso.AutoSize = True
        Me.rbnCurso.Location = New System.Drawing.Point(26, 60)
        Me.rbnCurso.Name = "rbnCurso"
        Me.rbnCurso.Size = New System.Drawing.Size(52, 17)
        Me.rbnCurso.TabIndex = 16
        Me.rbnCurso.TabStop = True
        Me.rbnCurso.Text = "Curso"
        Me.rbnCurso.UseVisualStyleBackColor = True
        '
        'rbnDía
        '
        Me.rbnDía.AutoSize = True
        Me.rbnDía.Location = New System.Drawing.Point(26, 31)
        Me.rbnDía.Name = "rbnDía"
        Me.rbnDía.Size = New System.Drawing.Size(85, 17)
        Me.rbnDía.TabIndex = 15
        Me.rbnDía.TabStop = True
        Me.rbnDía.Text = "Día Semana"
        Me.rbnDía.UseVisualStyleBackColor = True
        '
        'cbobusqueda
        '
        Me.cbobusqueda.FormattingEnabled = True
        Me.cbobusqueda.Location = New System.Drawing.Point(167, 68)
        Me.cbobusqueda.Name = "cbobusqueda"
        Me.cbobusqueda.Size = New System.Drawing.Size(142, 21)
        Me.cbobusqueda.TabIndex = 13
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(710, 581)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(88, 30)
        Me.cmdVolver.TabIndex = 14
        Me.cmdVolver.Text = "Adm Horarios"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'FrmConsultaHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 624)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Horario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmConsultaHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Horario Personal Docente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrHorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Horario.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtId_personal As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents dgrHorario As System.Windows.Forms.DataGridView
    Friend WithEvents Horario As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnCurso As System.Windows.Forms.RadioButton
    Friend WithEvents rbnDía As System.Windows.Forms.RadioButton
    Friend WithEvents cbobusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbnMateria As System.Windows.Forms.RadioButton
    Friend WithEvents rbnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
End Class
