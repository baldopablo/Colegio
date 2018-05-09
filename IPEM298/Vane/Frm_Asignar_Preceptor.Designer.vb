<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Asignar_Preceptor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Asignar_Preceptor))
        Me.Dg_cursos_asignados_a_precep = New System.Windows.Forms.DataGridView()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.cbo_curso = New System.Windows.Forms.ComboBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.Txt_nombre_asig_precep = New System.Windows.Forms.TextBox()
        Me.Txt_apellido_asig_precep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_quitar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Dg_cursos_asignados_a_precep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg_cursos_asignados_a_precep
        '
        Me.Dg_cursos_asignados_a_precep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_cursos_asignados_a_precep.Location = New System.Drawing.Point(16, 38)
        Me.Dg_cursos_asignados_a_precep.MultiSelect = False
        Me.Dg_cursos_asignados_a_precep.Name = "Dg_cursos_asignados_a_precep"
        Me.Dg_cursos_asignados_a_precep.RowHeadersVisible = False
        Me.Dg_cursos_asignados_a_precep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_cursos_asignados_a_precep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_cursos_asignados_a_precep.Size = New System.Drawing.Size(87, 149)
        Me.Dg_cursos_asignados_a_precep.TabIndex = 0
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_actualizar.Location = New System.Drawing.Point(149, 58)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(81, 35)
        Me.btn_actualizar.TabIndex = 1
        Me.btn_actualizar.Text = "Asignar"
        Me.btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'cbo_curso
        '
        Me.cbo_curso.FormattingEnabled = True
        Me.cbo_curso.Location = New System.Drawing.Point(125, 31)
        Me.cbo_curso.Name = "cbo_curso"
        Me.cbo_curso.Size = New System.Drawing.Size(121, 21)
        Me.cbo_curso.TabIndex = 2
        '
        'btn_volver
        '
        Me.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_volver.Location = New System.Drawing.Point(186, 125)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(81, 35)
        Me.btn_volver.TabIndex = 3
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Txt_nombre_asig_precep
        '
        Me.Txt_nombre_asig_precep.Location = New System.Drawing.Point(19, 71)
        Me.Txt_nombre_asig_precep.Name = "Txt_nombre_asig_precep"
        Me.Txt_nombre_asig_precep.ReadOnly = True
        Me.Txt_nombre_asig_precep.Size = New System.Drawing.Size(100, 20)
        Me.Txt_nombre_asig_precep.TabIndex = 4
        '
        'Txt_apellido_asig_precep
        '
        Me.Txt_apellido_asig_precep.Location = New System.Drawing.Point(19, 32)
        Me.Txt_apellido_asig_precep.Name = "Txt_apellido_asig_precep"
        Me.Txt_apellido_asig_precep.ReadOnly = True
        Me.Txt_apellido_asig_precep.Size = New System.Drawing.Size(100, 20)
        Me.Txt_apellido_asig_precep.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Elija uno para quitarlo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_quitar
        '
        Me.btn_quitar.Enabled = False
        Me.btn_quitar.Image = CType(resources.GetObject("btn_quitar.Image"), System.Drawing.Image)
        Me.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_quitar.Location = New System.Drawing.Point(16, 193)
        Me.btn_quitar.Name = "btn_quitar"
        Me.btn_quitar.Size = New System.Drawing.Size(87, 23)
        Me.btn_quitar.TabIndex = 9
        Me.btn_quitar.Text = "Quitar"
        Me.btn_quitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_quitar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(99, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dg_cursos_asignados_a_precep)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_quitar)
        Me.GroupBox1.Location = New System.Drawing.Point(278, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 224)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cursos Asignados"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cbo_curso)
        Me.GroupBox2.Controls.Add(Me.Txt_nombre_asig_precep)
        Me.GroupBox2.Controls.Add(Me.Txt_apellido_asig_precep)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 107)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(12, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 35)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Ver cursos libres"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Frm_Asignar_Preceptor
        '
        Me.AcceptButton = Me.btn_actualizar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_volver
        Me.ClientSize = New System.Drawing.Size(419, 240)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_volver)
        Me.Name = "Frm_Asignar_Preceptor"
        Me.Text = "Asignar cursos a preceptor"
        CType(Me.Dg_cursos_asignados_a_precep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dg_cursos_asignados_a_precep As System.Windows.Forms.DataGridView
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents cbo_curso As System.Windows.Forms.ComboBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents Txt_nombre_asig_precep As System.Windows.Forms.TextBox
    Friend WithEvents Txt_apellido_asig_precep As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_quitar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
