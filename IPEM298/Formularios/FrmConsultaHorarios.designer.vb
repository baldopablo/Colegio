<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaHorarios))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1 = New System.Windows.Forms.Label()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(9, 76)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(175, 76)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(181, 20)
        Me.txtApellido.TabIndex = 7
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(9, 32)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(148, 20)
        Me.txtDNI.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 105)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Docente"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(261, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 27)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBuscar.Location = New System.Drawing.Point(163, 25)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(92, 27)
        Me.cmdBuscar.TabIndex = 10
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dgrHorario
        '
        Me.dgrHorario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrHorario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgrHorario.Location = New System.Drawing.Point(13, 19)
        Me.dgrHorario.Name = "dgrHorario"
        Me.dgrHorario.RowHeadersVisible = False
        Me.dgrHorario.Size = New System.Drawing.Size(620, 277)
        Me.dgrHorario.TabIndex = 10
        '
        'Horario
        '
        Me.Horario.Controls.Add(Me.dgrHorario)
        Me.Horario.Location = New System.Drawing.Point(12, 123)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(646, 308)
        Me.Horario.TabIndex = 11
        Me.Horario.TabStop = False
        Me.Horario.Text = "Horario"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(379, 437)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(88, 30)
        Me.cmdImprimir.TabIndex = 11
        Me.cmdImprimir.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(567, 437)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(91, 30)
        Me.cmdSalir.TabIndex = 12
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rbnTodos)
        Me.GroupBox2.Controls.Add(Me.rbnMateria)
        Me.GroupBox2.Controls.Add(Me.rbnCurso)
        Me.GroupBox2.Controls.Add(Me.rbnDía)
        Me.GroupBox2.Controls.Add(Me.cbobusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 105)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Elija un item"
        '
        'rbnTodos
        '
        Me.rbnTodos.AutoSize = True
        Me.rbnTodos.Location = New System.Drawing.Point(13, 80)
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
        Me.rbnMateria.Location = New System.Drawing.Point(13, 57)
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
        Me.rbnCurso.Location = New System.Drawing.Point(13, 34)
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
        Me.rbnDía.Location = New System.Drawing.Point(13, 11)
        Me.rbnDía.Name = "rbnDía"
        Me.rbnDía.Size = New System.Drawing.Size(85, 17)
        Me.rbnDía.TabIndex = 15
        Me.rbnDía.TabStop = True
        Me.rbnDía.Text = "Día Semana"
        Me.rbnDía.UseVisualStyleBackColor = True
        '
        'cbobusqueda
        '
        Me.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobusqueda.FormattingEnabled = True
        Me.cbobusqueda.Location = New System.Drawing.Point(111, 49)
        Me.cbobusqueda.Name = "cbobusqueda"
        Me.cbobusqueda.Size = New System.Drawing.Size(142, 21)
        Me.cbobusqueda.TabIndex = 13
        '
        'cmdVolver
        '
        Me.cmdVolver.Image = CType(resources.GetObject("cmdVolver.Image"), System.Drawing.Image)
        Me.cmdVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdVolver.Location = New System.Drawing.Point(473, 437)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(88, 37)
        Me.cmdVolver.TabIndex = 14
        Me.cmdVolver.Text = "Gestión de horarios"
        Me.cmdVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'FrmConsultaHorarios
        '
        Me.AcceptButton = Me.cmdBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(672, 478)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Horario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
