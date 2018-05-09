Public Class Frm_principal

    Public quienllamofrmasignarcurso As Form
    Public quienllamofrmbuscaalu3 As Form

    Public quienllamoconsultaasistencia As String
    Public quienllamaconsultaasispersfecha As String

    Public quienllamofrmasignarmateria As Form
    Public quienllamofrmbuscapers As Form

    'PERSONAL - GESTION DE HORARIOS
    Private Sub AdminHorariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Personal_AdminHorarios.Click
        FrmHorariosPersonal.Show()
    End Sub

    'PERSONAL - CONSULTA HORARIOS - DOCENTE
    Private Sub DocentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocentesToolStripMenuItem.Click
        FrmConsultaHorarios.Show()
        FrmConsultaHorarios.cmdVolver.Visible = False
    End Sub

    'ARCHIVO - SALIR
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Archivo_salir.Click
        Dim clas As New Log_out
        clas.cerrar()
        'End
        'Me.Close()
    End Sub

    'USUSARIOS - GESTION DE USUARIOS
    Private Sub ABMUsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMUsuariosToolStripMenuItem.Click
        FrmUsuario.Show()
    End Sub

    'PERSONAL - GESTION DE PERSONAL
    Private Sub AdminPersonalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Personal_Gestionpersonal.Click
        FrmPersonal.Show()
    End Sub

    'ALUMNO - CERTIFICADOS
    Private Sub CertificadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alumno_Certificados.Click
        FrmCertificado.Show()
    End Sub

    'PERSONAL - CONSULTA HORARIOS- NO DOCENTE
    Private Sub NoDocentesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' FrmConsultaHorarioNoDocente.Show()
        'FrmConsultaHorarioNoDocente.cmdVolver.Visible = False
    End Sub

    'ALUMNOS - CALIFICACIONES - GESTION DE CALIFICACIONES
    Private Sub GestiónCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónCalificacionesToolStripMenuItem.Click
        FrmCalificaciones2.Show()
    End Sub

    'ALUMNOS - CALIFICACIONES - CONSULTA CALIFICACIONES
    Private Sub ConsultarCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarCalificacionesToolStripMenuItem.Click
        FrmConsultaCalificaciones.Show()
        FrmConsultaCalificaciones.cmdVolver.Visible = False
    End Sub

    'ALUMNOS- GESTION DE ALUMNOS
    Private Sub GestiónAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alumnos_GestiónAlumnos.Click
        FrmAlumno.Show()
    End Sub

    'PERSONAL -ASISTENCIA PERSONAL - GESTION DE ASISTENCIA 
    Private Sub GestiónDeAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónDeAsistenciaToolStripMenuItem.Click
        Frm_Asistencia_Personal.Show()
    End Sub

    'PERSONAL - ASISTENCIA PERSONAL - CONSULTA ASISTENCIA
    Private Sub ConsultaDeAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAsistenciaToolStripMenuItem.Click
        quienllamoconsultaasistencia = "doc"
        Frm_Consulta_Asistencia_pers.Show()
    End Sub

    'PERSONAL - ASISTENCIA PERSONAL - GENERAR PLANILLA INASISTENCIA
    Private Sub GenerarPlanillaDeInasistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarPlanillaDeInasistenciasToolStripMenuItem.Click
        Frm_Generar_Planilla_Inasistencia.Show()
    End Sub

    'ALUMNOS-ASISTENCIA-GESTION DE ASISTENCIA
    Private Sub GestiónAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónAsistenciaToolStripMenuItem.Click
        Frm_Asistencia_Alumno.Show()
    End Sub

    'ALUMNOS-ASISTENCIA-CONSULTA DE ASISTENCIA
    Private Sub ConsultarAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarAsistenciaToolStripMenuItem.Click
        quienllamoconsultaasistencia = "alu"
        Frm_Consulta_Asistencia_pers.Show()
    End Sub

    'USUARIO - CONSULTA DE USUSARIOS
    Private Sub GestiónPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónPermisosToolStripMenuItem.Click
        Frm_consultar_usuarios.Show()
    End Sub

    'CERRAR SESION
    Private Sub CerrarSesiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Archivo_CerrarSesión.Click
        End
        Me.Close()

        'Dim clas As New Log_out
        'clas.cerrar()
    End Sub

    'REPORTES - ESTADISTICAS
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'Shell("C:\Users\Usuario\Desktop\Estadisticas.appref-ms", AppWinStyle.MaximizedFocus)
        System.Diagnostics.Process.Start("C:\Users\Usuario\Desktop\Estadisticas.appref-ms")
        'System.Diagnostics.Process.Start("C:\Users\Usuario\Documents\Visual Studio 2010\Estadisticas.appref-ms")
    End Sub

    'ALUMNOS - CALIFICACIONES - EMISION DE ELIBRETAS
    Private Sub EmisiónDeLibretasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmisiónDeLibretasToolStripMenuItem.Click
        Frm_emision_libretas.Show()
    End Sub

    'ALUMNOS - ASIGNAR CURSO
    Private Sub AsignarCursoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alumno_AsignarCurso.Click
        quienllamofrmasignarcurso = Me
        FrmAsignarCurso.Show()
    End Sub

    Private Sub Frm_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    'PERSONAL - ASIGNAR MATERIA
    Private Sub AsignarMateriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Personal_AsignarMateria.Click
        quienllamofrmasignarmateria = Me
        FrmAsignarMateria.Show()
    End Sub

    'ADMINISTRACION - GEST DE MATERIAS
    Private Sub GestiónDeMateriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestiónDeMateriasToolStripMenuItem.Click
        FrmMateria.Show()
    End Sub

    'REPORTES - LISTADO DE ALUMNOS
    Private Sub NóminaDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NóminaDeAlumnosToolStripMenuItem.Click
        Frm_listado_alumnos_x_curso.Show()
    End Sub

    'REPORTES - LISTADO DE PERSONAL
    Private Sub NóminaDePersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NóminaDePersonalToolStripMenuItem.Click
        Frm_listado_de_personal.Show()
    End Sub

    'AYUDA
    Private Sub AyudaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Frm_acerca_de.Show()
    End Sub
End Class