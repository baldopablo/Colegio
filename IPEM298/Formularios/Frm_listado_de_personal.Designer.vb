<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_listado_de_personal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_listado_de_personal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbobusqueda = New System.Windows.Forms.ComboBox()
        Me.rbnpuesto = New System.Windows.Forms.RadioButton()
        Me.rbncurso = New System.Windows.Forms.RadioButton()
        Me.rbnmateria = New System.Windows.Forms.RadioButton()
        Me.dg_personal = New System.Windows.Forms.DataGridView()
        Me.rbntodos = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_personal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbntodos)
        Me.GroupBox1.Controls.Add(Me.rbnpuesto)
        Me.GroupBox1.Controls.Add(Me.rbncurso)
        Me.GroupBox1.Controls.Add(Me.rbnmateria)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elija item"
        '
        'cbobusqueda
        '
        Me.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobusqueda.FormattingEnabled = True
        Me.cbobusqueda.Location = New System.Drawing.Point(67, 18)
        Me.cbobusqueda.Name = "cbobusqueda"
        Me.cbobusqueda.Size = New System.Drawing.Size(110, 21)
        Me.cbobusqueda.TabIndex = 3
        '
        'rbnpuesto
        '
        Me.rbnpuesto.AutoSize = True
        Me.rbnpuesto.Location = New System.Drawing.Point(84, 19)
        Me.rbnpuesto.Name = "rbnpuesto"
        Me.rbnpuesto.Size = New System.Drawing.Size(58, 17)
        Me.rbnpuesto.TabIndex = 2
        Me.rbnpuesto.TabStop = True
        Me.rbnpuesto.Text = "Puesto"
        Me.rbnpuesto.UseVisualStyleBackColor = True
        '
        'rbncurso
        '
        Me.rbncurso.AutoSize = True
        Me.rbncurso.Location = New System.Drawing.Point(154, 19)
        Me.rbncurso.Name = "rbncurso"
        Me.rbncurso.Size = New System.Drawing.Size(52, 17)
        Me.rbncurso.TabIndex = 1
        Me.rbncurso.TabStop = True
        Me.rbncurso.Text = "Curso"
        Me.rbncurso.UseVisualStyleBackColor = True
        '
        'rbnmateria
        '
        Me.rbnmateria.AutoSize = True
        Me.rbnmateria.Location = New System.Drawing.Point(11, 19)
        Me.rbnmateria.Name = "rbnmateria"
        Me.rbnmateria.Size = New System.Drawing.Size(65, 17)
        Me.rbnmateria.TabIndex = 0
        Me.rbnmateria.TabStop = True
        Me.rbnmateria.Text = "Materias"
        Me.rbnmateria.UseVisualStyleBackColor = True
        '
        'dg_personal
        '
        Me.dg_personal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_personal.Location = New System.Drawing.Point(3, 56)
        Me.dg_personal.MultiSelect = False
        Me.dg_personal.Name = "dg_personal"
        Me.dg_personal.RowHeadersVisible = False
        Me.dg_personal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_personal.Size = New System.Drawing.Size(493, 218)
        Me.dg_personal.TabIndex = 1
        '
        'rbntodos
        '
        Me.rbntodos.AutoSize = True
        Me.rbntodos.Location = New System.Drawing.Point(220, 19)
        Me.rbntodos.Name = "rbntodos"
        Me.rbntodos.Size = New System.Drawing.Size(55, 17)
        Me.rbntodos.TabIndex = 5
        Me.rbntodos.TabStop = True
        Me.rbntodos.Text = "Todos"
        Me.rbntodos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbobusqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(195, 47)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.Location = New System.Drawing.Point(429, 285)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(66, 37)
        Me.btn_salir.TabIndex = 6
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Frm_listado_de_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 326)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dg_personal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_listado_de_personal"
        Me.Text = "Listado de personal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_personal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnpuesto As System.Windows.Forms.RadioButton
    Friend WithEvents rbncurso As System.Windows.Forms.RadioButton
    Friend WithEvents rbnmateria As System.Windows.Forms.RadioButton
    Friend WithEvents dg_personal As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbobusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents rbntodos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
