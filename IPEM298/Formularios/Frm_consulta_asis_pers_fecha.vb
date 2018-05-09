Public Class Frm_consulta_asis_pers_fecha
    Dim datacontextvistas As New DataClassesdevistasDataContext

    'LOAD DEL FORM
    Private Sub Frm_consulta_asis_pers_fecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Frm_principal.quienllamaconsultaasispersfecha = "doc" Then
            Label1.Text = "Inasistencias de docentes del día " & Frm_Consulta_Asistencia_pers.DateTP_consulta_asis_pers.Text
        Else
            Label1.Text = "Inasistencias de alumnos del día " & Frm_Consulta_Asistencia_pers.DateTP_consulta_asis_pers.Text
        End If

        cargargrilla(Frm_Consulta_Asistencia_pers.DateTP_consulta_asis_pers.Text)
    End Sub

    'CARGA GRILLA
    Sub cargargrilla(ByVal fecha As Date)
        Dg_asis_pers_fecha.AutoGenerateColumns = False
        Dg_asis_pers_fecha.Columns.Clear()

       
        
        If Frm_principal.quienllamaconsultaasispersfecha = "doc" Then
            Dim inasis_fecha = From f In datacontextvistas.Vista_inasistencia_personal Select f.apelliido_pers, f.nombre_pers, f.DNI_pers, f.nombre_curso, f.numero, f.turno_textbox, f.fecha_asistencia Where fecha_asistencia = CDate(fecha)
            Dg_asis_pers_fecha.Columns.Add("apelliido_pers", "Apellido")
            Dg_asis_pers_fecha.Columns.Add("nombre_pers", "Nombre")
            Dg_asis_pers_fecha.Columns.Add("DNI_pers", "Dni")
            Dg_asis_pers_fecha.Columns.Add("nombre_curso", "Curso")
            Dg_asis_pers_fecha.Columns.Add("numero", "Modulo")
            Dg_asis_pers_fecha.Columns.Add("turno_textbox", "Turno")

            Dg_asis_pers_fecha.Columns(0).DataPropertyName = "apelliido_pers"
            Dg_asis_pers_fecha.Columns(1).DataPropertyName = "nombre_pers"
            Dg_asis_pers_fecha.Columns(2).DataPropertyName = "DNI_pers"
            Dg_asis_pers_fecha.Columns(3).DataPropertyName = "nombre_curso"
            Dg_asis_pers_fecha.Columns(4).DataPropertyName = "numero"
            Dg_asis_pers_fecha.Columns(5).DataPropertyName = "turno_textbox"

            Dg_asis_pers_fecha.DataSource = inasis_fecha
        Else
            Dim inasis_fecha_alu = From f In datacontextvistas.Vista_inasistencia_alumno Select f.apellido_alu, f.nombre_alu, f.DNI_alu, f.estado_asistencia_alu, f.fecha_asistencia_alu Where fecha_asistencia_alu = CDate(fecha)
            Dg_asis_pers_fecha.Columns.Add("apellido_alu", "Apellido")
            Dg_asis_pers_fecha.Columns.Add("nombre_alu", "Nombre")
            Dg_asis_pers_fecha.Columns.Add("DNI_alu", "Dni")
            Dg_asis_pers_fecha.Columns.Add("estado_asistencia_alu", "Estado")

            Dg_asis_pers_fecha.Columns(0).DataPropertyName = "apellido_alu"
            Dg_asis_pers_fecha.Columns(1).DataPropertyName = "nombre_alu"
            Dg_asis_pers_fecha.Columns(2).DataPropertyName = "DNI_alu"
            Dg_asis_pers_fecha.Columns(3).DataPropertyName = "estado_asistencia_alu"

            Dg_asis_pers_fecha.DataSource = inasis_fecha_alu
        End If

        Dg_asis_pers_fecha.ClearSelection()
    End Sub

    'BOTON VOLVER
    Private Sub Btn_cons_asis_pers_fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cons_asis_pers_fecha.Click
        Me.Close()
    End Sub

    'BOTON IMPRIMIR
    Private Sub Btn_imprimir_asis_pers_fecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_imprimir_asis_pers_fecha.Click

    End Sub
End Class