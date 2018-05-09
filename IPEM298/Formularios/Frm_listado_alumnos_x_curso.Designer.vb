<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_listado_alumnos_x_curso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_listado_alumnos_x_curso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbnsinasignar = New System.Windows.Forms.RadioButton()
        Me.rbntodos = New System.Windows.Forms.RadioButton()
        Me.btn_consultar = New System.Windows.Forms.Button()
        Me.cbocurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbn_noche = New System.Windows.Forms.RadioButton()
        Me.rbn_tde = New System.Windows.Forms.RadioButton()
        Me.rbn_mna = New System.Windows.Forms.RadioButton()
        Me.dg_alumnosxcurso = New System.Windows.Forms.DataGridView()
        Me.cbo_curso = New System.Windows.Forms.ComboBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.rbninactivo = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_alumnosxcurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbninactivo)
        Me.GroupBox1.Controls.Add(Me.rbnsinasignar)
        Me.GroupBox1.Controls.Add(Me.rbntodos)
        Me.GroupBox1.Controls.Add(Me.btn_consultar)
        Me.GroupBox1.Controls.Add(Me.cbocurso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbn_noche)
        Me.GroupBox1.Controls.Add(Me.rbn_tde)
        Me.GroupBox1.Controls.Add(Me.rbn_mna)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turno"
        '
        'rbnsinasignar
        '
        Me.rbnsinasignar.AutoSize = True
        Me.rbnsinasignar.Location = New System.Drawing.Point(6, 109)
        Me.rbnsinasignar.Name = "rbnsinasignar"
        Me.rbnsinasignar.Size = New System.Drawing.Size(78, 17)
        Me.rbnsinasignar.TabIndex = 6
        Me.rbnsinasignar.TabStop = True
        Me.rbnsinasignar.Text = "Sin Asignar"
        Me.rbnsinasignar.UseVisualStyleBackColor = True
        '
        'rbntodos
        '
        Me.rbntodos.AutoSize = True
        Me.rbntodos.Location = New System.Drawing.Point(6, 86)
        Me.rbntodos.Name = "rbntodos"
        Me.rbntodos.Size = New System.Drawing.Size(55, 17)
        Me.rbntodos.TabIndex = 5
        Me.rbntodos.TabStop = True
        Me.rbntodos.Text = "Todos"
        Me.rbntodos.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.Image = CType(resources.GetObject("btn_consultar.Image"), System.Drawing.Image)
        Me.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_consultar.Location = New System.Drawing.Point(98, 61)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(77, 31)
        Me.btn_consultar.TabIndex = 2
        Me.btn_consultar.Text = "Consultar "
        Me.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'cbocurso
        '
        Me.cbocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocurso.FormattingEnabled = True
        Me.cbocurso.Location = New System.Drawing.Point(98, 32)
        Me.cbocurso.Name = "cbocurso"
        Me.cbocurso.Size = New System.Drawing.Size(65, 21)
        Me.cbocurso.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Curso"
        '
        'rbn_noche
        '
        Me.rbn_noche.AutoSize = True
        Me.rbn_noche.Location = New System.Drawing.Point(6, 65)
        Me.rbn_noche.Name = "rbn_noche"
        Me.rbn_noche.Size = New System.Drawing.Size(57, 17)
        Me.rbn_noche.TabIndex = 2
        Me.rbn_noche.TabStop = True
        Me.rbn_noche.Text = "Noche"
        Me.rbn_noche.UseVisualStyleBackColor = True
        '
        'rbn_tde
        '
        Me.rbn_tde.AutoSize = True
        Me.rbn_tde.Location = New System.Drawing.Point(6, 42)
        Me.rbn_tde.Name = "rbn_tde"
        Me.rbn_tde.Size = New System.Drawing.Size(53, 17)
        Me.rbn_tde.TabIndex = 1
        Me.rbn_tde.TabStop = True
        Me.rbn_tde.Text = "Tarde"
        Me.rbn_tde.UseVisualStyleBackColor = True
        '
        'rbn_mna
        '
        Me.rbn_mna.AutoSize = True
        Me.rbn_mna.Location = New System.Drawing.Point(6, 19)
        Me.rbn_mna.Name = "rbn_mna"
        Me.rbn_mna.Size = New System.Drawing.Size(64, 17)
        Me.rbn_mna.TabIndex = 0
        Me.rbn_mna.TabStop = True
        Me.rbn_mna.Text = "Mañana"
        Me.rbn_mna.UseVisualStyleBackColor = True
        '
        'dg_alumnosxcurso
        '
        Me.dg_alumnosxcurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_alumnosxcurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_alumnosxcurso.Location = New System.Drawing.Point(209, 12)
        Me.dg_alumnosxcurso.MultiSelect = False
        Me.dg_alumnosxcurso.Name = "dg_alumnosxcurso"
        Me.dg_alumnosxcurso.RowHeadersVisible = False
        Me.dg_alumnosxcurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_alumnosxcurso.Size = New System.Drawing.Size(512, 184)
        Me.dg_alumnosxcurso.TabIndex = 1
        '
        'cbo_curso
        '
        Me.cbo_curso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_curso.FormattingEnabled = True
        Me.cbo_curso.Location = New System.Drawing.Point(90, 38)
        Me.cbo_curso.Name = "cbo_curso"
        Me.cbo_curso.Size = New System.Drawing.Size(65, 21)
        Me.cbo_curso.TabIndex = 4
        '
        'btn_volver
        '
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_volver.Location = New System.Drawing.Point(126, 165)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(77, 31)
        Me.btn_volver.TabIndex = 5
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'rbninactivo
        '
        Me.rbninactivo.AutoSize = True
        Me.rbninactivo.Location = New System.Drawing.Point(6, 132)
        Me.rbninactivo.Name = "rbninactivo"
        Me.rbninactivo.Size = New System.Drawing.Size(68, 17)
        Me.rbninactivo.TabIndex = 7
        Me.rbninactivo.TabStop = True
        Me.rbninactivo.Text = "Inactivos"
        Me.rbninactivo.UseVisualStyleBackColor = True
        '
        'Frm_listado_alumnos_x_curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 209)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.dg_alumnosxcurso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_listado_alumnos_x_curso"
        Me.Text = "Listado de alumnos por curso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_alumnosxcurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbn_noche As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_tde As System.Windows.Forms.RadioButton
    Friend WithEvents rbn_mna As System.Windows.Forms.RadioButton
    Friend WithEvents dg_alumnosxcurso As System.Windows.Forms.DataGridView
    Friend WithEvents cbo_curso As System.Windows.Forms.ComboBox
    Friend WithEvents btn_consultar As System.Windows.Forms.Button
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents rbntodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbnsinasignar As System.Windows.Forms.RadioButton
    Friend WithEvents rbninactivo As System.Windows.Forms.RadioButton
End Class
