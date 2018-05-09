<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Asistencia_Personal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Asistencia_Personal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_dia = New System.Windows.Forms.ComboBox()
        Me.Dg_Docente_x_dia = New System.Windows.Forms.DataGridView()
        Me.DateTP_asis_pers = New System.Windows.Forms.DateTimePicker()
        Me.Btn_guardar_asis_pers = New System.Windows.Forms.Button()
        Me.Dg_Obligaciones_docente = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_observaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cb_estado = New System.Windows.Forms.ComboBox()
        Me.Cmb_turno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tb_dni = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_apellidoynombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_limpiar_asis_personal = New System.Windows.Forms.Button()
        Me.Btn_buscar_asis_personal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_salir_asis_personal = New System.Windows.Forms.Button()
        Me.Btn_cancelar_asis_pers = New System.Windows.Forms.Button()
        Me.Btn_editar_inasis_pers = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Rb_dia = New System.Windows.Forms.RadioButton()
        Me.Rb_dni = New System.Windows.Forms.RadioButton()
        Me.Label_seleccione_doc = New System.Windows.Forms.Label()
        Me.Label_seleccione_dia = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Dg_Docente_x_dia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dg_Obligaciones_docente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Día"
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
        'Cmb_dia
        '
        Me.Cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_dia.FormattingEnabled = True
        Me.Cmb_dia.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"})
        Me.Cmb_dia.Location = New System.Drawing.Point(32, 15)
        Me.Cmb_dia.Name = "Cmb_dia"
        Me.Cmb_dia.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_dia.TabIndex = 4
        '
        'Dg_Docente_x_dia
        '
        Me.Dg_Docente_x_dia.AllowUserToOrderColumns = True
        Me.Dg_Docente_x_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Docente_x_dia.Location = New System.Drawing.Point(23, 122)
        Me.Dg_Docente_x_dia.MultiSelect = False
        Me.Dg_Docente_x_dia.Name = "Dg_Docente_x_dia"
        Me.Dg_Docente_x_dia.RowHeadersVisible = False
        Me.Dg_Docente_x_dia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Docente_x_dia.Size = New System.Drawing.Size(313, 150)
        Me.Dg_Docente_x_dia.TabIndex = 5
        '
        'DateTP_asis_pers
        '
        Me.DateTP_asis_pers.CustomFormat = ""
        Me.DateTP_asis_pers.Enabled = False
        Me.DateTP_asis_pers.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTP_asis_pers.Location = New System.Drawing.Point(49, 15)
        Me.DateTP_asis_pers.Name = "DateTP_asis_pers"
        Me.DateTP_asis_pers.Size = New System.Drawing.Size(79, 20)
        Me.DateTP_asis_pers.TabIndex = 6
        '
        'Btn_guardar_asis_pers
        '
        Me.Btn_guardar_asis_pers.Enabled = False
        Me.Btn_guardar_asis_pers.Image = CType(resources.GetObject("Btn_guardar_asis_pers.Image"), System.Drawing.Image)
        Me.Btn_guardar_asis_pers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_guardar_asis_pers.Location = New System.Drawing.Point(4, 68)
        Me.Btn_guardar_asis_pers.Name = "Btn_guardar_asis_pers"
        Me.Btn_guardar_asis_pers.Size = New System.Drawing.Size(88, 37)
        Me.Btn_guardar_asis_pers.TabIndex = 7
        Me.Btn_guardar_asis_pers.Text = "Registrar Inasistencia"
        Me.Btn_guardar_asis_pers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_guardar_asis_pers.UseVisualStyleBackColor = True
        '
        'Dg_Obligaciones_docente
        '
        Me.Dg_Obligaciones_docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Obligaciones_docente.Location = New System.Drawing.Point(355, 17)
        Me.Dg_Obligaciones_docente.MultiSelect = False
        Me.Dg_Obligaciones_docente.Name = "Dg_Obligaciones_docente"
        Me.Dg_Obligaciones_docente.ReadOnly = True
        Me.Dg_Obligaciones_docente.RowHeadersVisible = False
        Me.Dg_Obligaciones_docente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Obligaciones_docente.Size = New System.Drawing.Size(326, 141)
        Me.Dg_Obligaciones_docente.TabIndex = 8
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
        'Tb_observaciones
        '
        Me.Tb_observaciones.Enabled = False
        Me.Tb_observaciones.Location = New System.Drawing.Point(87, 41)
        Me.Tb_observaciones.Name = "Tb_observaciones"
        Me.Tb_observaciones.Size = New System.Drawing.Size(233, 20)
        Me.Tb_observaciones.TabIndex = 13
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
        'Cb_estado
        '
        Me.Cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_estado.Enabled = False
        Me.Cb_estado.FormattingEnabled = True
        Me.Cb_estado.Items.AddRange(New Object() {"Ausente", "Tarde", "Licencia", "C. de Act"})
        Me.Cb_estado.Location = New System.Drawing.Point(193, 15)
        Me.Cb_estado.Name = "Cb_estado"
        Me.Cb_estado.Size = New System.Drawing.Size(127, 21)
        Me.Cb_estado.TabIndex = 14
        '
        'Cmb_turno
        '
        Me.Cmb_turno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_turno.FormattingEnabled = True
        Me.Cmb_turno.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        Me.Cmb_turno.Location = New System.Drawing.Point(157, 13)
        Me.Cmb_turno.Name = "Cmb_turno"
        Me.Cmb_turno.Size = New System.Drawing.Size(70, 21)
        Me.Cmb_turno.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Turno"
        '
        'Tb_dni
        '
        Me.Tb_dni.Location = New System.Drawing.Point(32, 16)
        Me.Tb_dni.Name = "Tb_dni"
        Me.Tb_dni.Size = New System.Drawing.Size(67, 20)
        Me.Tb_dni.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_dia)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cmb_turno)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 42)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por día"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Tb_apellidoynombre)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Tb_dni)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 42)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por DNI"
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
        'Tb_apellidoynombre
        '
        Me.Tb_apellidoynombre.Enabled = False
        Me.Tb_apellidoynombre.Location = New System.Drawing.Point(147, 16)
        Me.Tb_apellidoynombre.Name = "Tb_apellidoynombre"
        Me.Tb_apellidoynombre.Size = New System.Drawing.Size(109, 20)
        Me.Tb_apellidoynombre.TabIndex = 18
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
        'Btn_limpiar_asis_personal
        '
        Me.Btn_limpiar_asis_personal.Enabled = False
        Me.Btn_limpiar_asis_personal.Image = CType(resources.GetObject("Btn_limpiar_asis_personal.Image"), System.Drawing.Image)
        Me.Btn_limpiar_asis_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_limpiar_asis_personal.Location = New System.Drawing.Point(271, 67)
        Me.Btn_limpiar_asis_personal.Name = "Btn_limpiar_asis_personal"
        Me.Btn_limpiar_asis_personal.Size = New System.Drawing.Size(65, 35)
        Me.Btn_limpiar_asis_personal.TabIndex = 26
        Me.Btn_limpiar_asis_personal.Text = "Limpiar"
        Me.Btn_limpiar_asis_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_limpiar_asis_personal.UseVisualStyleBackColor = True
        '
        'Btn_buscar_asis_personal
        '
        Me.Btn_buscar_asis_personal.Image = CType(resources.GetObject("Btn_buscar_asis_personal.Image"), System.Drawing.Image)
        Me.Btn_buscar_asis_personal.Location = New System.Drawing.Point(285, 20)
        Me.Btn_buscar_asis_personal.Name = "Btn_buscar_asis_personal"
        Me.Btn_buscar_asis_personal.Size = New System.Drawing.Size(51, 35)
        Me.Btn_buscar_asis_personal.TabIndex = 18
        Me.Btn_buscar_asis_personal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_salir_asis_personal)
        Me.GroupBox3.Controls.Add(Me.Btn_cancelar_asis_pers)
        Me.GroupBox3.Controls.Add(Me.Btn_editar_inasis_pers)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DateTP_asis_pers)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Cb_estado)
        Me.GroupBox3.Controls.Add(Me.Btn_guardar_asis_pers)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Tb_observaciones)
        Me.GroupBox3.Location = New System.Drawing.Point(355, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 113)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inasistencia"
        '
        'Btn_salir_asis_personal
        '
        Me.Btn_salir_asis_personal.Image = CType(resources.GetObject("Btn_salir_asis_personal.Image"), System.Drawing.Image)
        Me.Btn_salir_asis_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_salir_asis_personal.Location = New System.Drawing.Point(261, 68)
        Me.Btn_salir_asis_personal.Name = "Btn_salir_asis_personal"
        Me.Btn_salir_asis_personal.Size = New System.Drawing.Size(61, 37)
        Me.Btn_salir_asis_personal.TabIndex = 27
        Me.Btn_salir_asis_personal.Text = "Salir"
        Me.Btn_salir_asis_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_salir_asis_personal.UseVisualStyleBackColor = True
        '
        'Btn_cancelar_asis_pers
        '
        Me.Btn_cancelar_asis_pers.Enabled = False
        Me.Btn_cancelar_asis_pers.Image = CType(resources.GetObject("Btn_cancelar_asis_pers.Image"), System.Drawing.Image)
        Me.Btn_cancelar_asis_pers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cancelar_asis_pers.Location = New System.Drawing.Point(94, 67)
        Me.Btn_cancelar_asis_pers.Name = "Btn_cancelar_asis_pers"
        Me.Btn_cancelar_asis_pers.Size = New System.Drawing.Size(74, 38)
        Me.Btn_cancelar_asis_pers.TabIndex = 15
        Me.Btn_cancelar_asis_pers.Text = "Cancelar"
        Me.Btn_cancelar_asis_pers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cancelar_asis_pers.UseVisualStyleBackColor = True
        '
        'Btn_editar_inasis_pers
        '
        Me.Btn_editar_inasis_pers.Enabled = False
        Me.Btn_editar_inasis_pers.Image = CType(resources.GetObject("Btn_editar_inasis_pers.Image"), System.Drawing.Image)
        Me.Btn_editar_inasis_pers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_editar_inasis_pers.Location = New System.Drawing.Point(169, 68)
        Me.Btn_editar_inasis_pers.Name = "Btn_editar_inasis_pers"
        Me.Btn_editar_inasis_pers.Size = New System.Drawing.Size(89, 37)
        Me.Btn_editar_inasis_pers.TabIndex = 28
        Me.Btn_editar_inasis_pers.Text = "Ver Inasistencia"
        Me.Btn_editar_inasis_pers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_editar_inasis_pers.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(709, 280)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 345
        Me.LineShape1.X2 = 345
        Me.LineShape1.Y1 = 12
        Me.LineShape1.Y2 = 271
        '
        'Rb_dia
        '
        Me.Rb_dia.AutoSize = True
        Me.Rb_dia.Location = New System.Drawing.Point(12, 60)
        Me.Rb_dia.Name = "Rb_dia"
        Me.Rb_dia.Size = New System.Drawing.Size(14, 13)
        Me.Rb_dia.TabIndex = 18
        Me.Rb_dia.UseVisualStyleBackColor = True
        '
        'Rb_dni
        '
        Me.Rb_dni.AutoSize = True
        Me.Rb_dni.Checked = True
        Me.Rb_dni.Location = New System.Drawing.Point(12, 12)
        Me.Rb_dni.Name = "Rb_dni"
        Me.Rb_dni.Size = New System.Drawing.Size(14, 13)
        Me.Rb_dni.TabIndex = 19
        Me.Rb_dni.TabStop = True
        Me.Rb_dni.UseVisualStyleBackColor = True
        '
        'Label_seleccione_doc
        '
        Me.Label_seleccione_doc.AutoSize = True
        Me.Label_seleccione_doc.Location = New System.Drawing.Point(29, 109)
        Me.Label_seleccione_doc.Name = "Label_seleccione_doc"
        Me.Label_seleccione_doc.Size = New System.Drawing.Size(117, 13)
        Me.Label_seleccione_doc.TabIndex = 24
        Me.Label_seleccione_doc.Text = "Seleccione un docente"
        Me.Label_seleccione_doc.Visible = False
        '
        'Label_seleccione_dia
        '
        Me.Label_seleccione_dia.AutoSize = True
        Me.Label_seleccione_dia.Location = New System.Drawing.Point(29, 109)
        Me.Label_seleccione_dia.Name = "Label_seleccione_dia"
        Me.Label_seleccione_dia.Size = New System.Drawing.Size(94, 13)
        Me.Label_seleccione_dia.TabIndex = 25
        Me.Label_seleccione_dia.Text = "Seleccione un día"
        Me.Label_seleccione_dia.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Obligaciones del docente"
        Me.Label8.Visible = False
        '
        'Frm_Asistencia_Personal
        '
        Me.AcceptButton = Me.Btn_buscar_asis_personal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 280)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_limpiar_asis_personal)
        Me.Controls.Add(Me.Btn_buscar_asis_personal)
        Me.Controls.Add(Me.Label_seleccione_dia)
        Me.Controls.Add(Me.Label_seleccione_doc)
        Me.Controls.Add(Me.Rb_dni)
        Me.Controls.Add(Me.Rb_dia)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dg_Obligaciones_docente)
        Me.Controls.Add(Me.Dg_Docente_x_dia)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Frm_Asistencia_Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de inasistencias de Personal"
        CType(Me.Dg_Docente_x_dia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dg_Obligaciones_docente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmb_dia As System.Windows.Forms.ComboBox
    Friend WithEvents Dg_Docente_x_dia As System.Windows.Forms.DataGridView
    Friend WithEvents DateTP_asis_pers As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_guardar_asis_pers As System.Windows.Forms.Button
    Friend WithEvents Dg_Obligaciones_docente As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tb_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_turno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Tb_dni As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_cancelar_asis_pers As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Rb_dia As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_dni As System.Windows.Forms.RadioButton
    Friend WithEvents Label_seleccione_doc As System.Windows.Forms.Label
    Friend WithEvents Label_seleccione_dia As System.Windows.Forms.Label
    Friend WithEvents Btn_buscar_asis_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_limpiar_asis_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_salir_asis_personal As System.Windows.Forms.Button
    Friend WithEvents Tb_apellidoynombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_editar_inasis_pers As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
