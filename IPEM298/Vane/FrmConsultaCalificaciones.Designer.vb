<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCalificaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultaCalificaciones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdAlu = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnTodos = New System.Windows.Forms.RadioButton()
        Me.rbnCondición = New System.Windows.Forms.RadioButton()
        Me.rbnMateria = New System.Windows.Forms.RadioButton()
        Me.cbobusqueda = New System.Windows.Forms.ComboBox()
        Me.Horario = New System.Windows.Forms.GroupBox()
        Me.dgrCalif = New System.Windows.Forms.DataGridView()
        Me.cmdImprimir = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Horario.SuspendLayout()
        CType(Me.dgrCalif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdAlu)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 99)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alumno"
        '
        'txtIdAlu
        '
        Me.txtIdAlu.Enabled = False
        Me.txtIdAlu.Location = New System.Drawing.Point(88, 9)
        Me.txtIdAlu.Name = "txtIdAlu"
        Me.txtIdAlu.Size = New System.Drawing.Size(56, 20)
        Me.txtIdAlu.TabIndex = 12
        Me.txtIdAlu.Visible = False
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(280, 65)
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
        Me.cmdBuscar.Location = New System.Drawing.Point(182, 65)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(92, 27)
        Me.cmdBuscar.TabIndex = 10
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(17, 32)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(181, 20)
        Me.txtApellido.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(203, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(166, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.Location = New System.Drawing.Point(17, 71)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(148, 20)
        Me.txtDNI.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DNI"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rbnTodos)
        Me.GroupBox2.Controls.Add(Me.rbnCondición)
        Me.GroupBox2.Controls.Add(Me.rbnMateria)
        Me.GroupBox2.Controls.Add(Me.cbobusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 98)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Elija un item"
        '
        'rbnTodos
        '
        Me.rbnTodos.AutoSize = True
        Me.rbnTodos.Location = New System.Drawing.Point(11, 77)
        Me.rbnTodos.Name = "rbnTodos"
        Me.rbnTodos.Size = New System.Drawing.Size(55, 17)
        Me.rbnTodos.TabIndex = 19
        Me.rbnTodos.TabStop = True
        Me.rbnTodos.Text = "Todos"
        Me.rbnTodos.UseVisualStyleBackColor = True
        '
        'rbnCondición
        '
        Me.rbnCondición.AutoSize = True
        Me.rbnCondición.Location = New System.Drawing.Point(11, 45)
        Me.rbnCondición.Name = "rbnCondición"
        Me.rbnCondición.Size = New System.Drawing.Size(72, 17)
        Me.rbnCondición.TabIndex = 16
        Me.rbnCondición.TabStop = True
        Me.rbnCondición.Text = "Condición"
        Me.rbnCondición.UseVisualStyleBackColor = True
        '
        'rbnMateria
        '
        Me.rbnMateria.AutoSize = True
        Me.rbnMateria.Location = New System.Drawing.Point(11, 16)
        Me.rbnMateria.Name = "rbnMateria"
        Me.rbnMateria.Size = New System.Drawing.Size(60, 17)
        Me.rbnMateria.TabIndex = 15
        Me.rbnMateria.TabStop = True
        Me.rbnMateria.Text = "Materia"
        Me.rbnMateria.UseVisualStyleBackColor = True
        '
        'cbobusqueda
        '
        Me.cbobusqueda.FormattingEnabled = True
        Me.cbobusqueda.Location = New System.Drawing.Point(114, 44)
        Me.cbobusqueda.Name = "cbobusqueda"
        Me.cbobusqueda.Size = New System.Drawing.Size(142, 21)
        Me.cbobusqueda.TabIndex = 13
        '
        'Horario
        '
        Me.Horario.Controls.Add(Me.dgrCalif)
        Me.Horario.Location = New System.Drawing.Point(12, 117)
        Me.Horario.Name = "Horario"
        Me.Horario.Size = New System.Drawing.Size(658, 304)
        Me.Horario.TabIndex = 16
        Me.Horario.TabStop = False
        Me.Horario.Text = "Calificaciones"
        '
        'dgrCalif
        '
        Me.dgrCalif.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgrCalif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrCalif.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgrCalif.Location = New System.Drawing.Point(6, 19)
        Me.dgrCalif.Name = "dgrCalif"
        Me.dgrCalif.RowHeadersVisible = False
        Me.dgrCalif.Size = New System.Drawing.Size(646, 277)
        Me.dgrCalif.TabIndex = 10
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.Location = New System.Drawing.Point(392, 428)
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(88, 30)
        Me.cmdImprimir.TabIndex = 11
        Me.cmdImprimir.UseVisualStyleBackColor = True
        Me.cmdImprimir.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSalir.Location = New System.Drawing.Point(578, 428)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(91, 30)
        Me.cmdSalir.TabIndex = 17
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.Image = CType(resources.GetObject("cmdVolver.Image"), System.Drawing.Image)
        Me.cmdVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdVolver.Location = New System.Drawing.Point(486, 427)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(88, 34)
        Me.cmdVolver.TabIndex = 18
        Me.cmdVolver.Text = "Gestión de notas"
        Me.cmdVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVolver.UseVisualStyleBackColor = True
        Me.cmdVolver.Visible = False
        '
        'FrmConsultaCalificaciones
        '
        Me.AcceptButton = Me.cmdBuscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(673, 461)
        Me.Controls.Add(Me.cmdImprimir)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Horario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmConsultaCalificaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Calificaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Horario.ResumeLayout(False)
        CType(Me.dgrCalif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCondición As System.Windows.Forms.RadioButton
    Friend WithEvents rbnMateria As System.Windows.Forms.RadioButton
    Friend WithEvents cbobusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Horario As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImprimir As System.Windows.Forms.Button
    Friend WithEvents dgrCalif As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdVolver As System.Windows.Forms.Button
    Friend WithEvents txtIdAlu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
