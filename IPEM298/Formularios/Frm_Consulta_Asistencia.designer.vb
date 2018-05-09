<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consulta_Asistencia_pers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Consulta_Asistencia_pers))
        Me.Dg_inasistencia_pers = New System.Windows.Forms.DataGridView()
        Me.Tb_dni_inasis = New System.Windows.Forms.TextBox()
        Me.Tb_obligaciones_cumplir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_inasis_cat = New System.Windows.Forms.TextBox()
        Me.Tb_total_horas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tb_inasis_permitidas = New System.Windows.Forms.TextBox()
        Me.Tb_inasis_obligaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_buscar_consulta_inasis = New System.Windows.Forms.Button()
        Me.Tb_apellidoynombre_inasis = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_limpiar_consulta_inasis = New System.Windows.Forms.Button()
        Me.Btn_salir_consulta_asis = New System.Windows.Forms.Button()
        Me.GroupBox_dni = New System.Windows.Forms.GroupBox()
        Me.Rbt_dni_consulta_asis_pers = New System.Windows.Forms.RadioButton()
        Me.Rbt_fecha_consulta_asis_pers = New System.Windows.Forms.RadioButton()
        Me.GroupBox_fecha = New System.Windows.Forms.GroupBox()
        Me.DateTP_consulta_asis_pers = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_imprimir_consulta_asis_pers = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tb_tarde = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Tb_tarde_alu = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_inasis_alu = New System.Windows.Forms.TextBox()
        CType(Me.Dg_inasistencia_pers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox_dni.SuspendLayout()
        Me.GroupBox_fecha.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg_inasistencia_pers
        '
        Me.Dg_inasistencia_pers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_inasistencia_pers.Enabled = False
        Me.Dg_inasistencia_pers.Location = New System.Drawing.Point(13, 123)
        Me.Dg_inasistencia_pers.Name = "Dg_inasistencia_pers"
        Me.Dg_inasistencia_pers.RowHeadersVisible = False
        Me.Dg_inasistencia_pers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_inasistencia_pers.Size = New System.Drawing.Size(350, 132)
        Me.Dg_inasistencia_pers.TabIndex = 0
        '
        'Tb_dni_inasis
        '
        Me.Tb_dni_inasis.Location = New System.Drawing.Point(24, 19)
        Me.Tb_dni_inasis.Name = "Tb_dni_inasis"
        Me.Tb_dni_inasis.Size = New System.Drawing.Size(63, 20)
        Me.Tb_dni_inasis.TabIndex = 1
        '
        'Tb_obligaciones_cumplir
        '
        Me.Tb_obligaciones_cumplir.Enabled = False
        Me.Tb_obligaciones_cumplir.Location = New System.Drawing.Point(85, 37)
        Me.Tb_obligaciones_cumplir.Name = "Tb_obligaciones_cumplir"
        Me.Tb_obligaciones_cumplir.Size = New System.Drawing.Size(25, 20)
        Me.Tb_obligaciones_cumplir.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dni"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Obligaciones"
        '
        'Tb_inasis_cat
        '
        Me.Tb_inasis_cat.Enabled = False
        Me.Tb_inasis_cat.Location = New System.Drawing.Point(84, 12)
        Me.Tb_inasis_cat.Name = "Tb_inasis_cat"
        Me.Tb_inasis_cat.Size = New System.Drawing.Size(25, 20)
        Me.Tb_inasis_cat.TabIndex = 5
        '
        'Tb_total_horas
        '
        Me.Tb_total_horas.Enabled = False
        Me.Tb_total_horas.Location = New System.Drawing.Point(85, 14)
        Me.Tb_total_horas.Name = "Tb_total_horas"
        Me.Tb_total_horas.Size = New System.Drawing.Size(25, 20)
        Me.Tb_total_horas.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Horas Cátedra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tb_total_horas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Tb_obligaciones_cumplir)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 62)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asistencia a Cumplir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Tb_inasis_permitidas)
        Me.GroupBox2.Controls.Add(Me.Tb_inasis_obligaciones)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Tb_inasis_cat)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 80)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inasistencias"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Permitidas"
        '
        'Tb_inasis_permitidas
        '
        Me.Tb_inasis_permitidas.Enabled = False
        Me.Tb_inasis_permitidas.Location = New System.Drawing.Point(84, 56)
        Me.Tb_inasis_permitidas.Name = "Tb_inasis_permitidas"
        Me.Tb_inasis_permitidas.Size = New System.Drawing.Size(25, 20)
        Me.Tb_inasis_permitidas.TabIndex = 11
        '
        'Tb_inasis_obligaciones
        '
        Me.Tb_inasis_obligaciones.Enabled = False
        Me.Tb_inasis_obligaciones.Location = New System.Drawing.Point(84, 34)
        Me.Tb_inasis_obligaciones.Name = "Tb_inasis_obligaciones"
        Me.Tb_inasis_obligaciones.Size = New System.Drawing.Size(25, 20)
        Me.Tb_inasis_obligaciones.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Obligaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Horas Cátedra"
        '
        'Btn_buscar_consulta_inasis
        '
        Me.Btn_buscar_consulta_inasis.Image = CType(resources.GetObject("Btn_buscar_consulta_inasis.Image"), System.Drawing.Image)
        Me.Btn_buscar_consulta_inasis.Location = New System.Drawing.Point(297, 13)
        Me.Btn_buscar_consulta_inasis.Name = "Btn_buscar_consulta_inasis"
        Me.Btn_buscar_consulta_inasis.Size = New System.Drawing.Size(67, 35)
        Me.Btn_buscar_consulta_inasis.TabIndex = 11
        Me.Btn_buscar_consulta_inasis.UseVisualStyleBackColor = True
        '
        'Tb_apellidoynombre_inasis
        '
        Me.Tb_apellidoynombre_inasis.Enabled = False
        Me.Tb_apellidoynombre_inasis.Location = New System.Drawing.Point(140, 19)
        Me.Tb_apellidoynombre_inasis.Name = "Tb_apellidoynombre_inasis"
        Me.Tb_apellidoynombre_inasis.Size = New System.Drawing.Size(125, 20)
        Me.Tb_apellidoynombre_inasis.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Detalle"
        '
        'Btn_limpiar_consulta_inasis
        '
        Me.Btn_limpiar_consulta_inasis.Enabled = False
        Me.Btn_limpiar_consulta_inasis.Image = CType(resources.GetObject("Btn_limpiar_consulta_inasis.Image"), System.Drawing.Image)
        Me.Btn_limpiar_consulta_inasis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_limpiar_consulta_inasis.Location = New System.Drawing.Point(297, 50)
        Me.Btn_limpiar_consulta_inasis.Name = "Btn_limpiar_consulta_inasis"
        Me.Btn_limpiar_consulta_inasis.Size = New System.Drawing.Size(67, 35)
        Me.Btn_limpiar_consulta_inasis.TabIndex = 27
        Me.Btn_limpiar_consulta_inasis.Text = "Limpiar"
        Me.Btn_limpiar_consulta_inasis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_limpiar_consulta_inasis.UseVisualStyleBackColor = True
        '
        'Btn_salir_consulta_asis
        '
        Me.Btn_salir_consulta_asis.Image = CType(resources.GetObject("Btn_salir_consulta_asis.Image"), System.Drawing.Image)
        Me.Btn_salir_consulta_asis.Location = New System.Drawing.Point(287, 341)
        Me.Btn_salir_consulta_asis.Name = "Btn_salir_consulta_asis"
        Me.Btn_salir_consulta_asis.Size = New System.Drawing.Size(77, 27)
        Me.Btn_salir_consulta_asis.TabIndex = 28
        Me.Btn_salir_consulta_asis.Text = "Salir"
        Me.Btn_salir_consulta_asis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_salir_consulta_asis.UseVisualStyleBackColor = True
        '
        'GroupBox_dni
        '
        Me.GroupBox_dni.Controls.Add(Me.Tb_apellidoynombre_inasis)
        Me.GroupBox_dni.Controls.Add(Me.Label1)
        Me.GroupBox_dni.Controls.Add(Me.Tb_dni_inasis)
        Me.GroupBox_dni.Controls.Add(Me.Label7)
        Me.GroupBox_dni.Location = New System.Drawing.Point(20, 7)
        Me.GroupBox_dni.Name = "GroupBox_dni"
        Me.GroupBox_dni.Size = New System.Drawing.Size(271, 45)
        Me.GroupBox_dni.TabIndex = 29
        Me.GroupBox_dni.TabStop = False
        Me.GroupBox_dni.Text = "Buscar por dni"
        '
        'Rbt_dni_consulta_asis_pers
        '
        Me.Rbt_dni_consulta_asis_pers.AutoSize = True
        Me.Rbt_dni_consulta_asis_pers.Checked = True
        Me.Rbt_dni_consulta_asis_pers.Location = New System.Drawing.Point(13, 7)
        Me.Rbt_dni_consulta_asis_pers.Name = "Rbt_dni_consulta_asis_pers"
        Me.Rbt_dni_consulta_asis_pers.Size = New System.Drawing.Size(14, 13)
        Me.Rbt_dni_consulta_asis_pers.TabIndex = 14
        Me.Rbt_dni_consulta_asis_pers.TabStop = True
        Me.Rbt_dni_consulta_asis_pers.UseVisualStyleBackColor = True
        '
        'Rbt_fecha_consulta_asis_pers
        '
        Me.Rbt_fecha_consulta_asis_pers.AutoSize = True
        Me.Rbt_fecha_consulta_asis_pers.Location = New System.Drawing.Point(13, 58)
        Me.Rbt_fecha_consulta_asis_pers.Name = "Rbt_fecha_consulta_asis_pers"
        Me.Rbt_fecha_consulta_asis_pers.Size = New System.Drawing.Size(14, 13)
        Me.Rbt_fecha_consulta_asis_pers.TabIndex = 30
        Me.Rbt_fecha_consulta_asis_pers.UseVisualStyleBackColor = True
        '
        'GroupBox_fecha
        '
        Me.GroupBox_fecha.Controls.Add(Me.DateTP_consulta_asis_pers)
        Me.GroupBox_fecha.Controls.Add(Me.Label9)
        Me.GroupBox_fecha.Location = New System.Drawing.Point(20, 58)
        Me.GroupBox_fecha.Name = "GroupBox_fecha"
        Me.GroupBox_fecha.Size = New System.Drawing.Size(271, 45)
        Me.GroupBox_fecha.TabIndex = 31
        Me.GroupBox_fecha.TabStop = False
        Me.GroupBox_fecha.Text = "Buscar por fecha"
        '
        'DateTP_consulta_asis_pers
        '
        Me.DateTP_consulta_asis_pers.Location = New System.Drawing.Point(47, 19)
        Me.DateTP_consulta_asis_pers.Name = "DateTP_consulta_asis_pers"
        Me.DateTP_consulta_asis_pers.Size = New System.Drawing.Size(217, 20)
        Me.DateTP_consulta_asis_pers.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fecha"
        '
        'Btn_imprimir_consulta_asis_pers
        '
        Me.Btn_imprimir_consulta_asis_pers.Enabled = False
        Me.Btn_imprimir_consulta_asis_pers.Image = CType(resources.GetObject("Btn_imprimir_consulta_asis_pers.Image"), System.Drawing.Image)
        Me.Btn_imprimir_consulta_asis_pers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_imprimir_consulta_asis_pers.Location = New System.Drawing.Point(204, 342)
        Me.Btn_imprimir_consulta_asis_pers.Name = "Btn_imprimir_consulta_asis_pers"
        Me.Btn_imprimir_consulta_asis_pers.Size = New System.Drawing.Size(77, 26)
        Me.Btn_imprimir_consulta_asis_pers.TabIndex = 32
        Me.Btn_imprimir_consulta_asis_pers.Text = "Imprimir"
        Me.Btn_imprimir_consulta_asis_pers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_imprimir_consulta_asis_pers.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tb_tarde)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(127, 39)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Llegadas tarde"
        '
        'Tb_tarde
        '
        Me.Tb_tarde.Enabled = False
        Me.Tb_tarde.Location = New System.Drawing.Point(85, 13)
        Me.Tb_tarde.Name = "Tb_tarde"
        Me.Tb_tarde.Size = New System.Drawing.Size(25, 20)
        Me.Tb_tarde.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(44, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Tarde"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Tb_tarde_alu)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.tb_inasis_alu)
        Me.GroupBox4.Location = New System.Drawing.Point(255, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(90, 64)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inasistencias"
        '
        'Tb_tarde_alu
        '
        Me.Tb_tarde_alu.Enabled = False
        Me.Tb_tarde_alu.Location = New System.Drawing.Point(58, 39)
        Me.Tb_tarde_alu.Name = "Tb_tarde_alu"
        Me.Tb_tarde_alu.Size = New System.Drawing.Size(25, 20)
        Me.Tb_tarde_alu.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Tarde"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Ausente"
        '
        'tb_inasis_alu
        '
        Me.tb_inasis_alu.Enabled = False
        Me.tb_inasis_alu.Location = New System.Drawing.Point(58, 13)
        Me.tb_inasis_alu.Name = "tb_inasis_alu"
        Me.tb_inasis_alu.Size = New System.Drawing.Size(25, 20)
        Me.tb_inasis_alu.TabIndex = 5
        '
        'Frm_Consulta_Asistencia_pers
        '
        Me.AcceptButton = Me.Btn_buscar_consulta_inasis
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 369)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Btn_imprimir_consulta_asis_pers)
        Me.Controls.Add(Me.Rbt_fecha_consulta_asis_pers)
        Me.Controls.Add(Me.Rbt_dni_consulta_asis_pers)
        Me.Controls.Add(Me.GroupBox_fecha)
        Me.Controls.Add(Me.GroupBox_dni)
        Me.Controls.Add(Me.Btn_salir_consulta_asis)
        Me.Controls.Add(Me.Btn_limpiar_consulta_inasis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_buscar_consulta_inasis)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dg_inasistencia_pers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_Consulta_Asistencia_pers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de inasistencia"
        CType(Me.Dg_inasistencia_pers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox_dni.ResumeLayout(False)
        Me.GroupBox_dni.PerformLayout()
        Me.GroupBox_fecha.ResumeLayout(False)
        Me.GroupBox_fecha.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dg_inasistencia_pers As System.Windows.Forms.DataGridView
    Friend WithEvents Tb_dni_inasis As System.Windows.Forms.TextBox
    Friend WithEvents Tb_obligaciones_cumplir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Tb_inasis_cat As System.Windows.Forms.TextBox
    Friend WithEvents Tb_total_horas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_inasis_obligaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tb_inasis_permitidas As System.Windows.Forms.TextBox
    Friend WithEvents Btn_buscar_consulta_inasis As System.Windows.Forms.Button
    Friend WithEvents Tb_apellidoynombre_inasis As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_limpiar_consulta_inasis As System.Windows.Forms.Button
    Friend WithEvents Btn_salir_consulta_asis As System.Windows.Forms.Button
    Friend WithEvents GroupBox_dni As System.Windows.Forms.GroupBox
    Friend WithEvents Rbt_dni_consulta_asis_pers As System.Windows.Forms.RadioButton
    Friend WithEvents Rbt_fecha_consulta_asis_pers As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_fecha As System.Windows.Forms.GroupBox
    Friend WithEvents DateTP_consulta_asis_pers As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_imprimir_consulta_asis_pers As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_tarde As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Tb_tarde_alu As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_inasis_alu As System.Windows.Forms.TextBox
End Class
