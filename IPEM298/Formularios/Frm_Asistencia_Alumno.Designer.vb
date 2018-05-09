<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Asistencia_Alumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Asistencia_Alumno))
        Me.Btn_buscar_asis_alu = New System.Windows.Forms.Button()
        Me.Rb_dni_asis_alu = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tb_dni_asis_alu = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_apellidoynombre_asis_alu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rb_curso_asis_alu = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmb_turno_asis_alu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_curso_asis_alu = New System.Windows.Forms.ComboBox()
        Me.Btn_limpiar_asis_personal = New System.Windows.Forms.Button()
        Me.Dg_asis_alumno = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_salir_asis_alumno = New System.Windows.Forms.Button()
        Me.Btn_cancelar_asis_alu = New System.Windows.Forms.Button()
        Me.Btn_editar_inasis_alu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTP_asis_alu = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cb_estado_alu = New System.Windows.Forms.ComboBox()
        Me.Btn_guardar_asis_alu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_observaciones_alu = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_asis_alumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_buscar_asis_alu
        '
        Me.Btn_buscar_asis_alu.Image = CType(resources.GetObject("Btn_buscar_asis_alu.Image"), System.Drawing.Image)
        Me.Btn_buscar_asis_alu.Location = New System.Drawing.Point(284, 19)
        Me.Btn_buscar_asis_alu.Name = "Btn_buscar_asis_alu"
        Me.Btn_buscar_asis_alu.Size = New System.Drawing.Size(51, 35)
        Me.Btn_buscar_asis_alu.TabIndex = 22
        Me.Btn_buscar_asis_alu.UseVisualStyleBackColor = True
        '
        'Rb_dni_asis_alu
        '
        Me.Rb_dni_asis_alu.AutoSize = True
        Me.Rb_dni_asis_alu.Checked = True
        Me.Rb_dni_asis_alu.Location = New System.Drawing.Point(12, 12)
        Me.Rb_dni_asis_alu.Name = "Rb_dni_asis_alu"
        Me.Rb_dni_asis_alu.Size = New System.Drawing.Size(14, 13)
        Me.Rb_dni_asis_alu.TabIndex = 23
        Me.Rb_dni_asis_alu.TabStop = True
        Me.Rb_dni_asis_alu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Tb_dni_asis_alu)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Tb_apellidoynombre_asis_alu)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 42)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por DNI"
        '
        'Tb_dni_asis_alu
        '
        Me.Tb_dni_asis_alu.Location = New System.Drawing.Point(29, 17)
        Me.Tb_dni_asis_alu.Name = "Tb_dni_asis_alu"
        Me.Tb_dni_asis_alu.Size = New System.Drawing.Size(72, 20)
        Me.Tb_dni_asis_alu.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(103, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nombre"
        '
        'Tb_apellidoynombre_asis_alu
        '
        Me.Tb_apellidoynombre_asis_alu.Enabled = False
        Me.Tb_apellidoynombre_asis_alu.Location = New System.Drawing.Point(147, 16)
        Me.Tb_apellidoynombre_asis_alu.Name = "Tb_apellidoynombre_asis_alu"
        Me.Tb_apellidoynombre_asis_alu.Size = New System.Drawing.Size(109, 20)
        Me.Tb_apellidoynombre_asis_alu.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Dni"
        '
        'Rb_curso_asis_alu
        '
        Me.Rb_curso_asis_alu.AutoSize = True
        Me.Rb_curso_asis_alu.Location = New System.Drawing.Point(12, 60)
        Me.Rb_curso_asis_alu.Name = "Rb_curso_asis_alu"
        Me.Rb_curso_asis_alu.Size = New System.Drawing.Size(14, 13)
        Me.Rb_curso_asis_alu.TabIndex = 25
        Me.Rb_curso_asis_alu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_turno_asis_alu)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cmb_curso_asis_alu)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 198)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por curso"
        '
        'Cmb_turno_asis_alu
        '
        Me.Cmb_turno_asis_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_turno_asis_alu.FormattingEnabled = True
        Me.Cmb_turno_asis_alu.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        Me.Cmb_turno_asis_alu.Location = New System.Drawing.Point(41, 15)
        Me.Cmb_turno_asis_alu.Name = "Cmb_turno_asis_alu"
        Me.Cmb_turno_asis_alu.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_turno_asis_alu.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Curso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turno"
        '
        'Cmb_curso_asis_alu
        '
        Me.Cmb_curso_asis_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_curso_asis_alu.FormattingEnabled = True
        Me.Cmb_curso_asis_alu.Location = New System.Drawing.Point(157, 13)
        Me.Cmb_curso_asis_alu.Name = "Cmb_curso_asis_alu"
        Me.Cmb_curso_asis_alu.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_curso_asis_alu.TabIndex = 16
        '
        'Btn_limpiar_asis_personal
        '
        Me.Btn_limpiar_asis_personal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_limpiar_asis_personal.Enabled = False
        Me.Btn_limpiar_asis_personal.Image = CType(resources.GetObject("Btn_limpiar_asis_personal.Image"), System.Drawing.Image)
        Me.Btn_limpiar_asis_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_limpiar_asis_personal.Location = New System.Drawing.Point(268, 67)
        Me.Btn_limpiar_asis_personal.Name = "Btn_limpiar_asis_personal"
        Me.Btn_limpiar_asis_personal.Size = New System.Drawing.Size(65, 35)
        Me.Btn_limpiar_asis_personal.TabIndex = 27
        Me.Btn_limpiar_asis_personal.Text = "Limpiar"
        Me.Btn_limpiar_asis_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_limpiar_asis_personal.UseVisualStyleBackColor = True
        '
        'Dg_asis_alumno
        '
        Me.Dg_asis_alumno.AllowUserToOrderColumns = True
        Me.Dg_asis_alumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_asis_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_asis_alumno.Location = New System.Drawing.Point(29, 102)
        Me.Dg_asis_alumno.MultiSelect = False
        Me.Dg_asis_alumno.Name = "Dg_asis_alumno"
        Me.Dg_asis_alumno.RowHeadersVisible = False
        Me.Dg_asis_alumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_asis_alumno.Size = New System.Drawing.Size(227, 150)
        Me.Dg_asis_alumno.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_salir_asis_alumno)
        Me.GroupBox3.Controls.Add(Me.Btn_cancelar_asis_alu)
        Me.GroupBox3.Controls.Add(Me.Btn_editar_inasis_alu)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTP_asis_alu)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Cb_estado_alu)
        Me.GroupBox3.Controls.Add(Me.Btn_guardar_asis_alu)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Tb_observaciones_alu)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 113)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inasistencia"
        '
        'Btn_salir_asis_alumno
        '
        Me.Btn_salir_asis_alumno.Image = CType(resources.GetObject("Btn_salir_asis_alumno.Image"), System.Drawing.Image)
        Me.Btn_salir_asis_alumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_salir_asis_alumno.Location = New System.Drawing.Point(261, 68)
        Me.Btn_salir_asis_alumno.Name = "Btn_salir_asis_alumno"
        Me.Btn_salir_asis_alumno.Size = New System.Drawing.Size(61, 37)
        Me.Btn_salir_asis_alumno.TabIndex = 27
        Me.Btn_salir_asis_alumno.Text = "Salir"
        Me.Btn_salir_asis_alumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_salir_asis_alumno.UseVisualStyleBackColor = True
        '
        'Btn_cancelar_asis_alu
        '
        Me.Btn_cancelar_asis_alu.Enabled = False
        Me.Btn_cancelar_asis_alu.Image = CType(resources.GetObject("Btn_cancelar_asis_alu.Image"), System.Drawing.Image)
        Me.Btn_cancelar_asis_alu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cancelar_asis_alu.Location = New System.Drawing.Point(94, 67)
        Me.Btn_cancelar_asis_alu.Name = "Btn_cancelar_asis_alu"
        Me.Btn_cancelar_asis_alu.Size = New System.Drawing.Size(74, 38)
        Me.Btn_cancelar_asis_alu.TabIndex = 15
        Me.Btn_cancelar_asis_alu.Text = "Cancelar"
        Me.Btn_cancelar_asis_alu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cancelar_asis_alu.UseVisualStyleBackColor = True
        '
        'Btn_editar_inasis_alu
        '
        Me.Btn_editar_inasis_alu.Enabled = False
        Me.Btn_editar_inasis_alu.Image = CType(resources.GetObject("Btn_editar_inasis_alu.Image"), System.Drawing.Image)
        Me.Btn_editar_inasis_alu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_editar_inasis_alu.Location = New System.Drawing.Point(169, 68)
        Me.Btn_editar_inasis_alu.Name = "Btn_editar_inasis_alu"
        Me.Btn_editar_inasis_alu.Size = New System.Drawing.Size(89, 37)
        Me.Btn_editar_inasis_alu.TabIndex = 28
        Me.Btn_editar_inasis_alu.Text = "Ver Inasistencia"
        Me.Btn_editar_inasis_alu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_editar_inasis_alu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha"
        '
        'DateTP_asis_alu
        '
        Me.DateTP_asis_alu.CustomFormat = ""
        Me.DateTP_asis_alu.Enabled = False
        Me.DateTP_asis_alu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTP_asis_alu.Location = New System.Drawing.Point(49, 15)
        Me.DateTP_asis_alu.Name = "DateTP_asis_alu"
        Me.DateTP_asis_alu.Size = New System.Drawing.Size(79, 20)
        Me.DateTP_asis_alu.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Estado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cb_estado_alu
        '
        Me.Cb_estado_alu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_estado_alu.Enabled = False
        Me.Cb_estado_alu.FormattingEnabled = True
        Me.Cb_estado_alu.Items.AddRange(New Object() {"Ausente", "Tarde"})
        Me.Cb_estado_alu.Location = New System.Drawing.Point(193, 15)
        Me.Cb_estado_alu.Name = "Cb_estado_alu"
        Me.Cb_estado_alu.Size = New System.Drawing.Size(127, 21)
        Me.Cb_estado_alu.TabIndex = 14
        '
        'Btn_guardar_asis_alu
        '
        Me.Btn_guardar_asis_alu.Enabled = False
        Me.Btn_guardar_asis_alu.Image = CType(resources.GetObject("Btn_guardar_asis_alu.Image"), System.Drawing.Image)
        Me.Btn_guardar_asis_alu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_guardar_asis_alu.Location = New System.Drawing.Point(4, 68)
        Me.Btn_guardar_asis_alu.Name = "Btn_guardar_asis_alu"
        Me.Btn_guardar_asis_alu.Size = New System.Drawing.Size(88, 37)
        Me.Btn_guardar_asis_alu.TabIndex = 7
        Me.Btn_guardar_asis_alu.Text = "Registrar Inasistencia"
        Me.Btn_guardar_asis_alu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_guardar_asis_alu.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Observaciones"
        '
        'Tb_observaciones_alu
        '
        Me.Tb_observaciones_alu.Enabled = False
        Me.Tb_observaciones_alu.Location = New System.Drawing.Point(87, 41)
        Me.Tb_observaciones_alu.Name = "Tb_observaciones_alu"
        Me.Tb_observaciones_alu.Size = New System.Drawing.Size(233, 20)
        Me.Tb_observaciones_alu.TabIndex = 13
        '
        'Frm_Asistencia_Alumno
        '
        Me.AcceptButton = Me.Btn_buscar_asis_alu
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btn_limpiar_asis_personal
        Me.ClientSize = New System.Drawing.Size(368, 413)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Dg_asis_alumno)
        Me.Controls.Add(Me.Btn_limpiar_asis_personal)
        Me.Controls.Add(Me.Rb_curso_asis_alu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_buscar_asis_alu)
        Me.Controls.Add(Me.Rb_dni_asis_alu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Asistencia_Alumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de inasistencias de alumno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_asis_alumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_buscar_asis_alu As System.Windows.Forms.Button
    Friend WithEvents Rb_dni_asis_alu As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Tb_apellidoynombre_asis_alu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Rb_curso_asis_alu As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmb_turno_asis_alu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_curso_asis_alu As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_limpiar_asis_personal As System.Windows.Forms.Button
    Friend WithEvents Dg_asis_alumno As System.Windows.Forms.DataGridView
    Friend WithEvents Tb_dni_asis_alu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_salir_asis_alumno As System.Windows.Forms.Button
    Friend WithEvents Btn_cancelar_asis_alu As System.Windows.Forms.Button
    Friend WithEvents Btn_editar_inasis_alu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTP_asis_alu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cb_estado_alu As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_guardar_asis_alu As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tb_observaciones_alu As System.Windows.Forms.TextBox
End Class
