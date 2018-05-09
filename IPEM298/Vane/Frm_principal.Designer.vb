<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Archivo_salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Archivo_CerrarSesión = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alumnos_GestiónAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alumnos_AsistenciaDeAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alumnos_Calificaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmisiónDeLibretasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alumno_Certificados = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alumno_AsignarCurso = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Personal_Gestionpersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.Personal_AdminHorarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.Personal_ConsultaHorarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocentesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Personal_AsistenciaPersonal = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPlanillaDeInasistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Personal_AsignarMateria = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeMateriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminaDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminaDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuArchivo, Me.MenuAlumnos, Me.MenuPersonal, Me.UsuariosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1376, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuArchivo
        '
        Me.MenuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Archivo_salir, Me.Archivo_CerrarSesión})
        Me.MenuArchivo.Name = "MenuArchivo"
        Me.MenuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.MenuArchivo.Text = "Archivo"
        '
        'Archivo_salir
        '
        Me.Archivo_salir.Name = "Archivo_salir"
        Me.Archivo_salir.Size = New System.Drawing.Size(142, 22)
        Me.Archivo_salir.Text = "Cerrar sesión"
        '
        'Archivo_CerrarSesión
        '
        Me.Archivo_CerrarSesión.Name = "Archivo_CerrarSesión"
        Me.Archivo_CerrarSesión.Size = New System.Drawing.Size(142, 22)
        Me.Archivo_CerrarSesión.Text = "Salir"
        '
        'MenuAlumnos
        '
        Me.MenuAlumnos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Alumnos_GestiónAlumnos, Me.Alumnos_AsistenciaDeAlumnos, Me.Alumnos_Calificaciones, Me.Alumno_Certificados, Me.Alumno_AsignarCurso})
        Me.MenuAlumnos.Name = "MenuAlumnos"
        Me.MenuAlumnos.Size = New System.Drawing.Size(67, 20)
        Me.MenuAlumnos.Text = "Alumnos"
        '
        'Alumnos_GestiónAlumnos
        '
        Me.Alumnos_GestiónAlumnos.Name = "Alumnos_GestiónAlumnos"
        Me.Alumnos_GestiónAlumnos.Size = New System.Drawing.Size(194, 22)
        Me.Alumnos_GestiónAlumnos.Text = "Gestión de Alumnos"
        '
        'Alumnos_AsistenciaDeAlumnos
        '
        Me.Alumnos_AsistenciaDeAlumnos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónAsistenciaToolStripMenuItem, Me.ConsultarAsistenciaToolStripMenuItem})
        Me.Alumnos_AsistenciaDeAlumnos.Name = "Alumnos_AsistenciaDeAlumnos"
        Me.Alumnos_AsistenciaDeAlumnos.Size = New System.Drawing.Size(194, 22)
        Me.Alumnos_AsistenciaDeAlumnos.Text = "Asistencia de Alumnos"
        '
        'GestiónAsistenciaToolStripMenuItem
        '
        Me.GestiónAsistenciaToolStripMenuItem.Name = "GestiónAsistenciaToolStripMenuItem"
        Me.GestiónAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestiónAsistenciaToolStripMenuItem.Text = "Gestión Asistencia"
        '
        'ConsultarAsistenciaToolStripMenuItem
        '
        Me.ConsultarAsistenciaToolStripMenuItem.Name = "ConsultarAsistenciaToolStripMenuItem"
        Me.ConsultarAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConsultarAsistenciaToolStripMenuItem.Text = "Consultar Asistencia"
        '
        'Alumnos_Calificaciones
        '
        Me.Alumnos_Calificaciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónCalificacionesToolStripMenuItem, Me.ConsultarCalificacionesToolStripMenuItem, Me.EmisiónDeLibretasToolStripMenuItem})
        Me.Alumnos_Calificaciones.Name = "Alumnos_Calificaciones"
        Me.Alumnos_Calificaciones.Size = New System.Drawing.Size(194, 22)
        Me.Alumnos_Calificaciones.Text = "Calificaciones"
        '
        'GestiónCalificacionesToolStripMenuItem
        '
        Me.GestiónCalificacionesToolStripMenuItem.Name = "GestiónCalificacionesToolStripMenuItem"
        Me.GestiónCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.GestiónCalificacionesToolStripMenuItem.Text = "Gestión Calificaciones"
        '
        'ConsultarCalificacionesToolStripMenuItem
        '
        Me.ConsultarCalificacionesToolStripMenuItem.Name = "ConsultarCalificacionesToolStripMenuItem"
        Me.ConsultarCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ConsultarCalificacionesToolStripMenuItem.Text = "Consultar Calificaciones"
        '
        'EmisiónDeLibretasToolStripMenuItem
        '
        Me.EmisiónDeLibretasToolStripMenuItem.Name = "EmisiónDeLibretasToolStripMenuItem"
        Me.EmisiónDeLibretasToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EmisiónDeLibretasToolStripMenuItem.Text = "Emisión de libretas"
        '
        'Alumno_Certificados
        '
        Me.Alumno_Certificados.Name = "Alumno_Certificados"
        Me.Alumno_Certificados.Size = New System.Drawing.Size(194, 22)
        Me.Alumno_Certificados.Text = "Certificados"
        '
        'Alumno_AsignarCurso
        '
        Me.Alumno_AsignarCurso.Name = "Alumno_AsignarCurso"
        Me.Alumno_AsignarCurso.Size = New System.Drawing.Size(194, 22)
        Me.Alumno_AsignarCurso.Text = "Asignar Curso"
        '
        'MenuPersonal
        '
        Me.MenuPersonal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Personal_Gestionpersonal, Me.Personal_AdminHorarios, Me.Personal_ConsultaHorarios, Me.Personal_AsistenciaPersonal, Me.Personal_AsignarMateria})
        Me.MenuPersonal.Name = "MenuPersonal"
        Me.MenuPersonal.Size = New System.Drawing.Size(64, 20)
        Me.MenuPersonal.Text = "Personal"
        '
        'Personal_Gestionpersonal
        '
        Me.Personal_Gestionpersonal.Name = "Personal_Gestionpersonal"
        Me.Personal_Gestionpersonal.Size = New System.Drawing.Size(178, 22)
        Me.Personal_Gestionpersonal.Text = "Gestión de Personal"
        '
        'Personal_AdminHorarios
        '
        Me.Personal_AdminHorarios.Name = "Personal_AdminHorarios"
        Me.Personal_AdminHorarios.Size = New System.Drawing.Size(178, 22)
        Me.Personal_AdminHorarios.Text = "Gestión de Horarios"
        '
        'Personal_ConsultaHorarios
        '
        Me.Personal_ConsultaHorarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocentesToolStripMenuItem})
        Me.Personal_ConsultaHorarios.Name = "Personal_ConsultaHorarios"
        Me.Personal_ConsultaHorarios.Size = New System.Drawing.Size(178, 22)
        Me.Personal_ConsultaHorarios.Text = "Consulta Horarios"
        '
        'DocentesToolStripMenuItem
        '
        Me.DocentesToolStripMenuItem.Name = "DocentesToolStripMenuItem"
        Me.DocentesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DocentesToolStripMenuItem.Text = "Docentes"
        '
        'Personal_AsistenciaPersonal
        '
        Me.Personal_AsistenciaPersonal.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónDeAsistenciaToolStripMenuItem, Me.ConsultaDeAsistenciaToolStripMenuItem, Me.GenerarPlanillaDeInasistenciasToolStripMenuItem})
        Me.Personal_AsistenciaPersonal.Name = "Personal_AsistenciaPersonal"
        Me.Personal_AsistenciaPersonal.Size = New System.Drawing.Size(178, 22)
        Me.Personal_AsistenciaPersonal.Text = "Asistencia Personal"
        '
        'GestiónDeAsistenciaToolStripMenuItem
        '
        Me.GestiónDeAsistenciaToolStripMenuItem.Name = "GestiónDeAsistenciaToolStripMenuItem"
        Me.GestiónDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.GestiónDeAsistenciaToolStripMenuItem.Text = "Gestión de Asistencia"
        '
        'ConsultaDeAsistenciaToolStripMenuItem
        '
        Me.ConsultaDeAsistenciaToolStripMenuItem.Name = "ConsultaDeAsistenciaToolStripMenuItem"
        Me.ConsultaDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ConsultaDeAsistenciaToolStripMenuItem.Text = "Consulta de Asistencia"
        '
        'GenerarPlanillaDeInasistenciasToolStripMenuItem
        '
        Me.GenerarPlanillaDeInasistenciasToolStripMenuItem.Name = "GenerarPlanillaDeInasistenciasToolStripMenuItem"
        Me.GenerarPlanillaDeInasistenciasToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.GenerarPlanillaDeInasistenciasToolStripMenuItem.Text = "Generar Planilla de Inasistencias"
        '
        'Personal_AsignarMateria
        '
        Me.Personal_AsignarMateria.Name = "Personal_AsignarMateria"
        Me.Personal_AsignarMateria.Size = New System.Drawing.Size(178, 22)
        Me.Personal_AsignarMateria.Text = "Asignar Materia"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMUsuariosToolStripMenuItem, Me.GestiónPermisosToolStripMenuItem, Me.GestiónDeMateriasToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.UsuariosToolStripMenuItem.Text = "Administración"
        '
        'ABMUsuariosToolStripMenuItem
        '
        Me.ABMUsuariosToolStripMenuItem.Name = "ABMUsuariosToolStripMenuItem"
        Me.ABMUsuariosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ABMUsuariosToolStripMenuItem.Text = "Gestión de Usuarios"
        '
        'GestiónPermisosToolStripMenuItem
        '
        Me.GestiónPermisosToolStripMenuItem.Name = "GestiónPermisosToolStripMenuItem"
        Me.GestiónPermisosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GestiónPermisosToolStripMenuItem.Text = "Consultar Usuarios"
        '
        'GestiónDeMateriasToolStripMenuItem
        '
        Me.GestiónDeMateriasToolStripMenuItem.Name = "GestiónDeMateriasToolStripMenuItem"
        Me.GestiónDeMateriasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GestiónDeMateriasToolStripMenuItem.Text = "Gestión de Materias"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.NóminaDeAlumnosToolStripMenuItem, Me.NóminaDePersonalToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem2.Text = "Estadísticas"
        '
        'NóminaDeAlumnosToolStripMenuItem
        '
        Me.NóminaDeAlumnosToolStripMenuItem.Name = "NóminaDeAlumnosToolStripMenuItem"
        Me.NóminaDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NóminaDeAlumnosToolStripMenuItem.Text = "Nómina de alumnos"
        '
        'NóminaDePersonalToolStripMenuItem
        '
        Me.NóminaDePersonalToolStripMenuItem.Name = "NóminaDePersonalToolStripMenuItem"
        Me.NóminaDePersonalToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.NóminaDePersonalToolStripMenuItem.Text = "Nómina de Personal"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AyudaToolStripMenuItem.Text = "Acerca de"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SalirToolStripMenuItem.Text = "Sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1386, 706)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Frm_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1376, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_principal"
        Me.Text = "IPEM 298"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuAlumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Personal_Gestionpersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Personal_AdminHorarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Personal_ConsultaHorarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Personal_AsistenciaPersonal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocentesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Archivo_salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alumnos_GestiónAlumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alumnos_AsistenciaDeAlumnos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alumnos_Calificaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alumno_Certificados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPlanillaDeInasistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Archivo_CerrarSesión As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmisiónDeLibretasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alumno_AsignarCurso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Personal_AsignarMateria As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestiónDeMateriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NóminaDeAlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NóminaDePersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
