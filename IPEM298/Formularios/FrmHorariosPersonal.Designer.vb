<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHorariosPersonal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHorariosPersonal))
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_limpiar_hs_personal = New System.Windows.Forms.Button()
        Me.Grpb_turno = New System.Windows.Forms.GroupBox()
        Me.Rbt_noche = New System.Windows.Forms.RadioButton()
        Me.Rbt_tde = New System.Windows.Forms.RadioButton()
        Me.Rbt_mna = New System.Windows.Forms.RadioButton()
        Me.Btn_agregar_hs_personal = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbomodulo = New System.Windows.Forms.ComboBox()
        Me.cbomateria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbodiasemana = New System.Windows.Forms.ComboBox()
        Me.cbocurso = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Btn_buscar_hs_personal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_DNI = New System.Windows.Forms.TextBox()
        Me.txtleg_prov = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_salir_hs_personal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_guardar_hs_personal = New System.Windows.Forms.Button()
        Me.Btn_Cancelar_hs_personal = New System.Windows.Forms.Button()
        Me.Btn_modificar_hs_personal = New System.Windows.Forms.Button()
        Me.Btn_eliminar_hs_personal = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Grpb_turno.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(505, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gestion de Horarios de Docentes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_limpiar_hs_personal)
        Me.GroupBox2.Controls.Add(Me.Grpb_turno)
        Me.GroupBox2.Controls.Add(Me.Btn_agregar_hs_personal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbomodulo)
        Me.GroupBox2.Controls.Add(Me.cbomateria)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbodiasemana)
        Me.GroupBox2.Controls.Add(Me.cbocurso)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Btn_buscar_hs_personal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_DNI)
        Me.GroupBox2.Controls.Add(Me.txtleg_prov)
        Me.GroupBox2.Controls.Add(Me.txt_apellido)
        Me.GroupBox2.Controls.Add(Me.txt_nombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 185)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'Btn_limpiar_hs_personal
        '
        Me.Btn_limpiar_hs_personal.Enabled = False
        Me.Btn_limpiar_hs_personal.Image = CType(resources.GetObject("Btn_limpiar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_limpiar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_limpiar_hs_personal.Location = New System.Drawing.Point(246, 16)
        Me.Btn_limpiar_hs_personal.Name = "Btn_limpiar_hs_personal"
        Me.Btn_limpiar_hs_personal.Size = New System.Drawing.Size(65, 35)
        Me.Btn_limpiar_hs_personal.TabIndex = 25
        Me.Btn_limpiar_hs_personal.Text = "Limpiar"
        Me.Btn_limpiar_hs_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_limpiar_hs_personal.UseVisualStyleBackColor = True
        '
        'Grpb_turno
        '
        Me.Grpb_turno.Controls.Add(Me.Rbt_noche)
        Me.Grpb_turno.Controls.Add(Me.Rbt_tde)
        Me.Grpb_turno.Controls.Add(Me.Rbt_mna)
        Me.Grpb_turno.Enabled = False
        Me.Grpb_turno.Location = New System.Drawing.Point(172, 102)
        Me.Grpb_turno.Name = "Grpb_turno"
        Me.Grpb_turno.Size = New System.Drawing.Size(279, 35)
        Me.Grpb_turno.TabIndex = 24
        Me.Grpb_turno.TabStop = False
        Me.Grpb_turno.Text = "Turno"
        '
        'Rbt_noche
        '
        Me.Rbt_noche.AutoSize = True
        Me.Rbt_noche.Location = New System.Drawing.Point(196, 11)
        Me.Rbt_noche.Name = "Rbt_noche"
        Me.Rbt_noche.Size = New System.Drawing.Size(57, 17)
        Me.Rbt_noche.TabIndex = 26
        Me.Rbt_noche.Text = "Noche"
        Me.Rbt_noche.UseVisualStyleBackColor = True
        '
        'Rbt_tde
        '
        Me.Rbt_tde.AutoSize = True
        Me.Rbt_tde.Location = New System.Drawing.Point(107, 12)
        Me.Rbt_tde.Name = "Rbt_tde"
        Me.Rbt_tde.Size = New System.Drawing.Size(53, 17)
        Me.Rbt_tde.TabIndex = 26
        Me.Rbt_tde.Text = "Tarde"
        Me.Rbt_tde.UseVisualStyleBackColor = True
        '
        'Rbt_mna
        '
        Me.Rbt_mna.AutoSize = True
        Me.Rbt_mna.Location = New System.Drawing.Point(12, 12)
        Me.Rbt_mna.Name = "Rbt_mna"
        Me.Rbt_mna.Size = New System.Drawing.Size(64, 17)
        Me.Rbt_mna.TabIndex = 25
        Me.Rbt_mna.Text = "Mañana"
        Me.Rbt_mna.UseVisualStyleBackColor = True
        '
        'Btn_agregar_hs_personal
        '
        Me.Btn_agregar_hs_personal.Enabled = False
        Me.Btn_agregar_hs_personal.Image = CType(resources.GetObject("Btn_agregar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_agregar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_agregar_hs_personal.Location = New System.Drawing.Point(9, 104)
        Me.Btn_agregar_hs_personal.Name = "Btn_agregar_hs_personal"
        Me.Btn_agregar_hs_personal.Size = New System.Drawing.Size(135, 33)
        Me.Btn_agregar_hs_personal.TabIndex = 22
        Me.Btn_agregar_hs_personal.Text = "Agregar Horario"
        Me.Btn_agregar_hs_personal.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(395, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Módulo"
        '
        'cbomodulo
        '
        Me.cbomodulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomodulo.Enabled = False
        Me.cbomodulo.FormattingEnabled = True
        Me.cbomodulo.Location = New System.Drawing.Point(398, 154)
        Me.cbomodulo.Name = "cbomodulo"
        Me.cbomodulo.Size = New System.Drawing.Size(53, 21)
        Me.cbomodulo.TabIndex = 4
        '
        'cbomateria
        '
        Me.cbomateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomateria.Enabled = False
        Me.cbomateria.FormattingEnabled = True
        Me.cbomateria.Location = New System.Drawing.Point(132, 156)
        Me.cbomateria.Name = "cbomateria"
        Me.cbomateria.Size = New System.Drawing.Size(179, 21)
        Me.cbomateria.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(129, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Materia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Día Semana"
        '
        'cbodiasemana
        '
        Me.cbodiasemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodiasemana.Enabled = False
        Me.cbodiasemana.FormattingEnabled = True
        Me.cbodiasemana.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves ", "Viernes", "Sábados"})
        Me.cbodiasemana.Location = New System.Drawing.Point(13, 156)
        Me.cbodiasemana.Name = "cbodiasemana"
        Me.cbodiasemana.Size = New System.Drawing.Size(103, 21)
        Me.cbodiasemana.TabIndex = 1
        '
        'cbocurso
        '
        Me.cbocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocurso.Enabled = False
        Me.cbocurso.FormattingEnabled = True
        Me.cbocurso.Location = New System.Drawing.Point(329, 155)
        Me.cbocurso.Name = "cbocurso"
        Me.cbocurso.Size = New System.Drawing.Size(53, 21)
        Me.cbocurso.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Curso"
        '
        'Btn_buscar_hs_personal
        '
        Me.Btn_buscar_hs_personal.Image = CType(resources.GetObject("Btn_buscar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_buscar_hs_personal.Location = New System.Drawing.Point(189, 16)
        Me.Btn_buscar_hs_personal.Name = "Btn_buscar_hs_personal"
        Me.Btn_buscar_hs_personal.Size = New System.Drawing.Size(51, 35)
        Me.Btn_buscar_hs_personal.TabIndex = 8
        Me.Btn_buscar_hs_personal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DNI"
        '
        'txt_DNI
        '
        Me.txt_DNI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_DNI.Location = New System.Drawing.Point(13, 30)
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.Size = New System.Drawing.Size(155, 20)
        Me.txt_DNI.TabIndex = 0
        '
        'txtleg_prov
        '
        Me.txtleg_prov.Enabled = False
        Me.txtleg_prov.Location = New System.Drawing.Point(325, 72)
        Me.txtleg_prov.Name = "txtleg_prov"
        Me.txtleg_prov.Size = New System.Drawing.Size(100, 20)
        Me.txtleg_prov.TabIndex = 4
        '
        'txt_apellido
        '
        Me.txt_apellido.Enabled = False
        Me.txt_apellido.Location = New System.Drawing.Point(172, 72)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(134, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Enabled = False
        Me.txt_nombre.Location = New System.Drawing.Point(13, 72)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(135, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Legajo Docente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(464, 166)
        Me.ShapeContainer1.TabIndex = 23
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 464
        Me.LineShape1.Y1 = 81
        Me.LineShape1.Y2 = 81
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_salir_hs_personal)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.Btn_guardar_hs_personal)
        Me.GroupBox3.Controls.Add(Me.Btn_Cancelar_hs_personal)
        Me.GroupBox3.Controls.Add(Me.Btn_modificar_hs_personal)
        Me.GroupBox3.Controls.Add(Me.Btn_eliminar_hs_personal)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 188)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(470, 232)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'Btn_salir_hs_personal
        '
        Me.Btn_salir_hs_personal.Image = CType(resources.GetObject("Btn_salir_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_salir_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_salir_hs_personal.Location = New System.Drawing.Point(352, 199)
        Me.Btn_salir_hs_personal.Name = "Btn_salir_hs_personal"
        Me.Btn_salir_hs_personal.Size = New System.Drawing.Size(104, 27)
        Me.Btn_salir_hs_personal.TabIndex = 22
        Me.Btn_salir_hs_personal.Text = "Salir"
        Me.Btn_salir_hs_personal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 57)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(446, 136)
        Me.DataGridView1.TabIndex = 7
        '
        'Btn_guardar_hs_personal
        '
        Me.Btn_guardar_hs_personal.Enabled = False
        Me.Btn_guardar_hs_personal.Image = CType(resources.GetObject("Btn_guardar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_guardar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_guardar_hs_personal.Location = New System.Drawing.Point(10, 19)
        Me.Btn_guardar_hs_personal.Name = "Btn_guardar_hs_personal"
        Me.Btn_guardar_hs_personal.Size = New System.Drawing.Size(116, 32)
        Me.Btn_guardar_hs_personal.TabIndex = 5
        Me.Btn_guardar_hs_personal.Text = "Guardar"
        Me.Btn_guardar_hs_personal.UseVisualStyleBackColor = True
        '
        'Btn_Cancelar_hs_personal
        '
        Me.Btn_Cancelar_hs_personal.Enabled = False
        Me.Btn_Cancelar_hs_personal.Image = CType(resources.GetObject("Btn_Cancelar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_Cancelar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cancelar_hs_personal.Location = New System.Drawing.Point(132, 19)
        Me.Btn_Cancelar_hs_personal.Name = "Btn_Cancelar_hs_personal"
        Me.Btn_Cancelar_hs_personal.Size = New System.Drawing.Size(109, 32)
        Me.Btn_Cancelar_hs_personal.TabIndex = 6
        Me.Btn_Cancelar_hs_personal.Text = "Cancelar"
        Me.Btn_Cancelar_hs_personal.UseVisualStyleBackColor = True
        '
        'Btn_modificar_hs_personal
        '
        Me.Btn_modificar_hs_personal.Enabled = False
        Me.Btn_modificar_hs_personal.Image = CType(resources.GetObject("Btn_modificar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_modificar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_modificar_hs_personal.Location = New System.Drawing.Point(247, 19)
        Me.Btn_modificar_hs_personal.Name = "Btn_modificar_hs_personal"
        Me.Btn_modificar_hs_personal.Size = New System.Drawing.Size(101, 32)
        Me.Btn_modificar_hs_personal.TabIndex = 8
        Me.Btn_modificar_hs_personal.Text = "Modificar"
        Me.Btn_modificar_hs_personal.UseVisualStyleBackColor = True
        '
        'Btn_eliminar_hs_personal
        '
        Me.Btn_eliminar_hs_personal.Enabled = False
        Me.Btn_eliminar_hs_personal.Image = CType(resources.GetObject("Btn_eliminar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_eliminar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_eliminar_hs_personal.Location = New System.Drawing.Point(356, 19)
        Me.Btn_eliminar_hs_personal.Name = "Btn_eliminar_hs_personal"
        Me.Btn_eliminar_hs_personal.Size = New System.Drawing.Size(100, 32)
        Me.Btn_eliminar_hs_personal.TabIndex = 9
        Me.Btn_eliminar_hs_personal.Text = "Eliminar"
        Me.Btn_eliminar_hs_personal.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 463)
        Me.TabControl1.TabIndex = 0
        '
        'CursoBindingSource
        '
        Me.CursoBindingSource.DataMember = "Curso"
        '
        'FrmHorariosPersonal
        '
        Me.AcceptButton = Me.Btn_buscar_hs_personal
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(514, 469)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(100, 0)
        Me.Name = "FrmHorariosPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horario de profesores"
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Grpb_turno.ResumeLayout(False)
        Me.Grpb_turno.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.CursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Btn_salir_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_eliminar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_modificar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_Cancelar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_guardar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbocurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_buscar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_DNI As System.Windows.Forms.TextBox
    Friend WithEvents txtleg_prov As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl

    Friend WithEvents CursoBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbomateria As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbodiasemana As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbomodulo As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_agregar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Grpb_turno As System.Windows.Forms.GroupBox
    Friend WithEvents Rbt_noche As System.Windows.Forms.RadioButton
    Friend WithEvents Rbt_tde As System.Windows.Forms.RadioButton
    Friend WithEvents Rbt_mna As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Btn_limpiar_hs_personal As System.Windows.Forms.Button

End Class
