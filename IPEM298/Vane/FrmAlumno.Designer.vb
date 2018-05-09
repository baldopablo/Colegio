<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlumno))
        Me.txtidAlu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApellidoAlu = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombreAlu = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDNI_alu = New System.Windows.Forms.TextBox()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.drgAlumno = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dgrPersonal = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage_alta = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpfechainsc = New System.Windows.Forms.DateTimePicker()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdAsignar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDniTutor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomApeTutor = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.dtpfechanac = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefonoTutor = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage_consulta = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.drgAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgrPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage_alta.SuspendLayout()
        Me.TabPage_consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtidAlu
        '
        Me.txtidAlu.Enabled = False
        Me.txtidAlu.Location = New System.Drawing.Point(77, 203)
        Me.txtidAlu.Name = "txtidAlu"
        Me.txtidAlu.Size = New System.Drawing.Size(78, 20)
        Me.txtidAlu.TabIndex = 37
        Me.txtidAlu.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Apellido"
        '
        'txtApellidoAlu
        '
        Me.txtApellidoAlu.Location = New System.Drawing.Point(9, 23)
        Me.txtApellidoAlu.Name = "txtApellidoAlu"
        Me.txtApellidoAlu.Size = New System.Drawing.Size(109, 20)
        Me.txtApellidoAlu.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(125, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nombre"
        '
        'txtNombreAlu
        '
        Me.txtNombreAlu.Location = New System.Drawing.Point(128, 23)
        Me.txtNombreAlu.Name = "txtNombreAlu"
        Me.txtNombreAlu.ReadOnly = True
        Me.txtNombreAlu.Size = New System.Drawing.Size(128, 20)
        Me.txtNombreAlu.TabIndex = 33
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(260, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "DNI"
        '
        'txtDNI_alu
        '
        Me.txtDNI_alu.Location = New System.Drawing.Point(263, 23)
        Me.txtDNI_alu.Name = "txtDNI_alu"
        Me.txtDNI_alu.ReadOnly = True
        Me.txtDNI_alu.Size = New System.Drawing.Size(95, 20)
        Me.txtDNI_alu.TabIndex = 17
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Image = CType(resources.GetObject("cmdLimpiar.Image"), System.Drawing.Image)
        Me.cmdLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLimpiar.Location = New System.Drawing.Point(442, 12)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(78, 36)
        Me.cmdLimpiar.TabIndex = 24
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.Location = New System.Drawing.Point(362, 12)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(78, 36)
        Me.cmdBuscar.TabIndex = 31
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'drgAlumno
        '
        Me.drgAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.drgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgAlumno.Location = New System.Drawing.Point(9, 66)
        Me.drgAlumno.MultiSelect = False
        Me.drgAlumno.Name = "drgAlumno"
        Me.drgAlumno.RowHeadersVisible = False
        Me.drgAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgAlumno.Size = New System.Drawing.Size(507, 135)
        Me.drgAlumno.TabIndex = 2
        '
        'Button7
        '
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.Location = New System.Drawing.Point(428, 259)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 33)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Salir"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dgrPersonal
        '
        Me.dgrPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrPersonal.Location = New System.Drawing.Point(37, 75)
        Me.dgrPersonal.Name = "dgrPersonal"
        Me.dgrPersonal.Size = New System.Drawing.Size(821, 135)
        Me.dgrPersonal.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(223, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 43
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage_alta)
        Me.TabControl1.Controls.Add(Me.TabPage_consulta)
        Me.TabControl1.Location = New System.Drawing.Point(2, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(530, 250)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage_alta
        '
        Me.TabPage_alta.BackColor = System.Drawing.Color.Silver
        Me.TabPage_alta.Controls.Add(Me.Label16)
        Me.TabPage_alta.Controls.Add(Me.Label14)
        Me.TabPage_alta.Controls.Add(Me.Label12)
        Me.TabPage_alta.Controls.Add(Me.dtpfechainsc)
        Me.TabPage_alta.Controls.Add(Me.cmdActualizar)
        Me.TabPage_alta.Controls.Add(Me.cmdEliminar)
        Me.TabPage_alta.Controls.Add(Me.cmdAsignar)
        Me.TabPage_alta.Controls.Add(Me.cmdCancelar)
        Me.TabPage_alta.Controls.Add(Me.Label8)
        Me.TabPage_alta.Controls.Add(Me.Label1)
        Me.TabPage_alta.Controls.Add(Me.cmdGuardar)
        Me.TabPage_alta.Controls.Add(Me.txtNombre)
        Me.TabPage_alta.Controls.Add(Me.txtDniTutor)
        Me.TabPage_alta.Controls.Add(Me.Label2)
        Me.TabPage_alta.Controls.Add(Me.txtNomApeTutor)
        Me.TabPage_alta.Controls.Add(Me.txtApellido)
        Me.TabPage_alta.Controls.Add(Me.dtpfechanac)
        Me.TabPage_alta.Controls.Add(Me.Label3)
        Me.TabPage_alta.Controls.Add(Me.Label13)
        Me.TabPage_alta.Controls.Add(Me.txtDomicilio)
        Me.TabPage_alta.Controls.Add(Me.Label28)
        Me.TabPage_alta.Controls.Add(Me.Label4)
        Me.TabPage_alta.Controls.Add(Me.txtemail)
        Me.TabPage_alta.Controls.Add(Me.Label23)
        Me.TabPage_alta.Controls.Add(Me.Label5)
        Me.TabPage_alta.Controls.Add(Me.txtTelefonoTutor)
        Me.TabPage_alta.Controls.Add(Me.Label21)
        Me.TabPage_alta.Controls.Add(Me.Label7)
        Me.TabPage_alta.Controls.Add(Me.Label20)
        Me.TabPage_alta.Controls.Add(Me.Label6)
        Me.TabPage_alta.Controls.Add(Me.Label19)
        Me.TabPage_alta.Controls.Add(Me.txtDNI)
        Me.TabPage_alta.Controls.Add(Me.Label18)
        Me.TabPage_alta.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_alta.Name = "TabPage_alta"
        Me.TabPage_alta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_alta.Size = New System.Drawing.Size(522, 224)
        Me.TabPage_alta.TabIndex = 0
        Me.TabPage_alta.Text = "Alta de alumnos"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(511, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 17)
        Me.Label16.TabIndex = 92
        Me.Label16.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(294, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(194, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 13)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Fecha de inscripción"
        '
        'dtpfechainsc
        '
        Me.dtpfechainsc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechainsc.Location = New System.Drawing.Point(194, 72)
        Me.dtpfechainsc.Name = "dtpfechainsc"
        Me.dtpfechainsc.Size = New System.Drawing.Size(106, 20)
        Me.dtpfechainsc.TabIndex = 89
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdActualizar.Location = New System.Drawing.Point(237, 157)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(86, 33)
        Me.cmdActualizar.TabIndex = 50
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEliminar.Location = New System.Drawing.Point(330, 157)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(86, 33)
        Me.cmdEliminar.TabIndex = 49
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Enabled = False
        Me.cmdAsignar.Image = CType(resources.GetObject("cmdAsignar.Image"), System.Drawing.Image)
        Me.cmdAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAsignar.Location = New System.Drawing.Point(422, 157)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(86, 35)
        Me.cmdAsignar.TabIndex = 88
        Me.cmdAsignar.Text = "Asignar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Curso"
        Me.cmdAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAsignar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCancelar.Location = New System.Drawing.Point(119, 157)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(104, 33)
        Me.cmdCancelar.TabIndex = 48
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(215, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "DNI Tutor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGuardar.Location = New System.Drawing.Point(9, 157)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(104, 33)
        Me.cmdGuardar.TabIndex = 47
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(9, 29)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(180, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtDniTutor
        '
        Me.txtDniTutor.Location = New System.Drawing.Point(218, 115)
        Me.txtDniTutor.Name = "txtDniTutor"
        Me.txtDniTutor.Size = New System.Drawing.Size(158, 20)
        Me.txtDniTutor.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'txtNomApeTutor
        '
        Me.txtNomApeTutor.Location = New System.Drawing.Point(9, 115)
        Me.txtNomApeTutor.Name = "txtNomApeTutor"
        Me.txtNomApeTutor.Size = New System.Drawing.Size(195, 20)
        Me.txtNomApeTutor.TabIndex = 44
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(194, 29)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(144, 20)
        Me.txtApellido.TabIndex = 2
        '
        'dtpfechanac
        '
        Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechanac.Location = New System.Drawing.Point(411, 29)
        Me.dtpfechanac.Name = "dtpfechanac"
        Me.dtpfechanac.Size = New System.Drawing.Size(107, 20)
        Me.dtpfechanac.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Domicilio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(407, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Fecha de nacimiento"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(9, 72)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(176, 20)
        Me.txtDomicilio.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(14, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 13)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "* Campos requeridos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "E-mail"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(329, 72)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(169, 20)
        Me.txtemail.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(212, 102)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 17)
        Me.Label23.TabIndex = 36
        Me.Label23.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(382, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teléfono Tutor "
        '
        'txtTelefonoTutor
        '
        Me.txtTelefonoTutor.Location = New System.Drawing.Point(385, 115)
        Me.txtTelefonoTutor.Name = "txtTelefonoTutor"
        Me.txtTelefonoTutor.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefonoTutor.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(55, 54)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 17)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre y Apellido del tutor "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(370, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 17)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "DNI"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(234, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "*"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(344, 29)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(64, 20)
        Me.txtDNI.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(50, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 17)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "*"
        '
        'TabPage_consulta
        '
        Me.TabPage_consulta.BackColor = System.Drawing.Color.Silver
        Me.TabPage_consulta.Controls.Add(Me.Label15)
        Me.TabPage_consulta.Controls.Add(Me.cmdBuscar)
        Me.TabPage_consulta.Controls.Add(Me.Label11)
        Me.TabPage_consulta.Controls.Add(Me.txtidAlu)
        Me.TabPage_consulta.Controls.Add(Me.cmdLimpiar)
        Me.TabPage_consulta.Controls.Add(Me.Label10)
        Me.TabPage_consulta.Controls.Add(Me.drgAlumno)
        Me.TabPage_consulta.Controls.Add(Me.txtApellidoAlu)
        Me.TabPage_consulta.Controls.Add(Me.Label9)
        Me.TabPage_consulta.Controls.Add(Me.txtNombreAlu)
        Me.TabPage_consulta.Controls.Add(Me.txtDNI_alu)
        Me.TabPage_consulta.Controls.Add(Me.Label17)
        Me.TabPage_consulta.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_consulta.Name = "TabPage_consulta"
        Me.TabPage_consulta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_consulta.Size = New System.Drawing.Size(522, 224)
        Me.TabPage_consulta.TabIndex = 1
        Me.TabPage_consulta.Text = "Consultar y modificar alumnos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(223, 13)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Haga click sobre la grilla para editar el alumno"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Id alu oculto"
        Me.Label11.Visible = False
        '
        'FrmAlumno
        '
        Me.AcceptButton = Me.cmdGuardar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 295)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button7)
        Me.Name = "FrmAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de alumnos"
        CType(Me.drgAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgrPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage_alta.ResumeLayout(False)
        Me.TabPage_alta.PerformLayout()
        Me.TabPage_consulta.ResumeLayout(False)
        Me.TabPage_consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDNI_alu As System.Windows.Forms.TextBox
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents drgAlumno As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents dgrPersonal As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApellidoAlu As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombreAlu As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtidAlu As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_alta As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_consulta As System.Windows.Forms.TabPage
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDniTutor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomApeTutor As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents dtpfechanac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoTutor As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdActualizar As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdAsignar As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpfechainsc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
