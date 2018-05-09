Public Class Frm_Asistencia_Personal
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Public vble_id_pers_asis As Integer 'Guarda el id de un personal

    Dim vble_id_horario_pers As Integer 'Guarda el id de un horario
    Dim vble_dia, vble_turno As String

    'LOAD DEL FORM
    Private Sub Frm_Asistencia_Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mostrargrilladia("", "")
        Tb_dni.Select()
    End Sub

    'ARMA LA ESTRUCURA DE LA GRILLA DE HORARIOS DE DOCENTE RECIBIENDO COMO PARAMETRO UN SELECT
    Public Sub armargrilladia(ByVal datasource As System.Linq.IQueryable, ByVal verap As String, ByVal vernom As String, ByVal verdni As String, ByVal verturno As String, ByVal verdia As String)
        Dg_Docente_x_dia.AutoGenerateColumns = False
        Dg_Docente_x_dia.Columns.Clear()


        Dg_Docente_x_dia.Columns.Add("apelliido_pers", "Apellido")
        Dg_Docente_x_dia.Columns.Add("nombre_pers", "Nombre")
        Dg_Docente_x_dia.Columns.Add("DNI_pers", "Dni")
        Dg_Docente_x_dia.Columns.Add("dia_semana", "Día")
        Dg_Docente_x_dia.Columns.Add("turno_textbox", "Turno")
        Dg_Docente_x_dia.Columns.Add("id_personal", "Docente")

        Dg_Docente_x_dia.Columns(0).DataPropertyName = "apelliido_pers"
        Dg_Docente_x_dia.Columns(1).DataPropertyName = "nombre_pers"
        Dg_Docente_x_dia.Columns(2).DataPropertyName = "DNI_pers"
        Dg_Docente_x_dia.Columns(3).DataPropertyName = "dia_semana"
        Dg_Docente_x_dia.Columns(4).DataPropertyName = "turno_textbox"
        Dg_Docente_x_dia.Columns(5).DataPropertyName = "id_personal"
        Dg_Docente_x_dia.Columns(0).Visible = verap
        Dg_Docente_x_dia.Columns(1).Visible = vernom
        Dg_Docente_x_dia.Columns(2).Visible = verdni
        Dg_Docente_x_dia.Columns(3).Visible = verdia
        Dg_Docente_x_dia.Columns(4).Visible = verturno
        Dg_Docente_x_dia.Columns(5).Visible = False

        Dg_Docente_x_dia.DataSource = datasource
        Dg_Docente_x_dia.ClearSelection()
    End Sub

    'CLICK SOBRE GRILLA DE HORARIO DE DOCENTES
    Private Sub DataGridDocente_x_dia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Docente_x_dia.CellClick
        Select Case Rb_dni.Checked
            Case True
                vble_dia = Dg_Docente_x_dia.Item("dia_semana", Dg_Docente_x_dia.SelectedRows(0).Index).Value
                vble_turno = Dg_Docente_x_dia.Item("turno_textbox", Dg_Docente_x_dia.SelectedRows(0).Index).Value
                vble_id_horario_pers = -1

                Dim datagridobligaciones = From o In datacontextvistas.vista_horario_personal Select o.nombre_materia, o.nombre_curso, o.numero, o.hora_inicio, o.hora_fin, o.id_horario, o.id_personal, o.dia_semana, o.turno_textbox Where dia_semana = vble_dia And turno_textbox = vble_turno And id_personal = vble_id_pers_asis
                mostrargrillaobligaciones(datagridobligaciones)
            Case False
                If Dg_Docente_x_dia.SelectedRows.Count > 0 Then
                    vble_id_pers_asis = Dg_Docente_x_dia.Item("id_personal", Dg_Docente_x_dia.SelectedRows(0).Index).Value
                End If
                Dim datagridobligaciones = From o In datacontextvistas.vista_horario_personal Select o.nombre_materia, o.nombre_curso, o.numero, o.hora_inicio, o.hora_fin, o.id_horario, o.id_personal, o.dia_semana, o.turno_textbox Where dia_semana = Cmb_dia.Text And turno_textbox = Cmb_turno.Text And id_personal = vble_id_pers_asis
                mostrargrillaobligaciones(datagridobligaciones)
                Btn_editar_inasis_pers.Enabled = True

        End Select
    End Sub

    'CARGA LA GRILLA OBLIGACINES CON LOS HORARIOS CORRESPONDIENTES AL DOCENTE SELECCIONADO EL LA GRILLA DE HORARIOS DE DOCENTES RECIBIENDO UN SELECT COMO PARAMETRO
    Private Sub mostrargrillaobligaciones(ByVal datasource As System.Linq.IQueryable)
        Dg_Obligaciones_docente.AutoGenerateColumns = False
        Dg_Obligaciones_docente.Columns.Clear()

        Dg_Obligaciones_docente.Columns.Add("nombre_materia", "Materia")
        Dg_Obligaciones_docente.Columns.Add("nombre_curso", "Curso")
        Dg_Obligaciones_docente.Columns.Add("numero", "Modulo")
        Dg_Obligaciones_docente.Columns.Add("hora_inicio", "Hora de Inicio")
        Dg_Obligaciones_docente.Columns.Add("hora_fin", "Hora de Fin")
        Dg_Obligaciones_docente.Columns.Add("id_personal", "docente")
        Dg_Obligaciones_docente.Columns.Add("id_horario", "id_horario")

        Dg_Obligaciones_docente.Columns(0).DataPropertyName = "nombre_materia"
        Dg_Obligaciones_docente.Columns(1).DataPropertyName = "nombre_curso"
        Dg_Obligaciones_docente.Columns(2).DataPropertyName = "numero"
        Dg_Obligaciones_docente.Columns(3).DataPropertyName = "hora_inicio"
        Dg_Obligaciones_docente.Columns(4).DataPropertyName = "hora_fin"
        Dg_Obligaciones_docente.Columns(5).DataPropertyName = "id_personal"
        Dg_Obligaciones_docente.Columns(6).DataPropertyName = "id_horario"

        Dg_Obligaciones_docente.Columns(5).Visible = False
        Dg_Obligaciones_docente.Columns(6).Visible = False

        Dg_Obligaciones_docente.DataSource = datasource
        Dg_Obligaciones_docente.ClearSelection()

    End Sub

    'BOTON GUARDAR INASISTENCIA
    Private Sub Btn_guardar_asis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar_asis_pers.Click
        If valida_existencia_inasistencia(vble_id_horario_pers, DateTP_asis_pers.Text) = "ocupado" Then
            Exit Sub
        End If

        Dim inasistencia As New Asistencia_docente
        If Cb_estado.Text = "" Then
            MsgBox("Elija un estado de inasistencia", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Estado en blanco")
            Exit Sub
        Else
            inasistencia.estado_textbox = Cb_estado.Text
        End If
        Try
            inasistencia.id_horario = vble_id_horario_pers
            inasistencia.fecha_asistencia = DateTP_asis_pers.Text
            inasistencia.observacion = Tb_observaciones.Text
        Catch ex As Exception
            MsgBox("Complete todos los datos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Campo en blanco")
        End Try
        inasistencia.observacion = Tb_observaciones.Text
        DataContext.Asistencia_docentes.InsertOnSubmit(inasistencia)
        DataContext.SubmitChanges()
        MsgBox("La ausencia fue guardada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Registrar inasistencia")
        Cb_estado.SelectedIndex = -1
        Cb_estado.Enabled = False
        Tb_observaciones.Clear()
        Tb_observaciones.Enabled = False
        habilita_botones(False, True, False, False, True, True, True)
    End Sub

    'CLICK SOBRE GRILLA DE OBLIGACIONES
    Private Sub Dg_Obligaciones_docente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_Obligaciones_docente.CellClick
        If Dg_Obligaciones_docente.SelectedRows.Count > 0 Then
            vble_id_horario_pers = Dg_Obligaciones_docente.Item("id_horario", Dg_Obligaciones_docente.SelectedRows(0).Index).Value
            DateTP_asis_pers.Enabled = True
            Cb_estado.Enabled = True
            Tb_observaciones.Enabled = True
            
            habilita_botones(False, False, True, True, False, False, False)
        End If
    End Sub

    'RADIO BUTTTON DIA
    Private Sub Rb_dia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_dia.CheckedChanged
        Tb_dni.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        Tb_dni.Text = ""
        Tb_apellidoynombre.Text = ""
        Dg_Docente_x_dia.Columns.Clear()
        Dg_Obligaciones_docente.Columns.Clear()
        Label_seleccione_dia.Visible = False
        
        habilita_botones(True, False, False, False, False, False, False)
    End Sub

    'RADIO BUTTON DNI
    Private Sub Rb_dni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_dni.CheckedChanged

        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        Cmb_dia.SelectedIndex = -1
        Cmb_turno.SelectedIndex = -1
        Label_seleccione_doc.Visible = False
        Dg_Docente_x_dia.Columns.Clear()
        Dg_Obligaciones_docente.Columns.Clear()

        habilita_botones(True, False, False, False, False, False, False)
    End Sub

    'BOTON CANCELAR
    Private Sub Btn_cancelar_asis_pers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelar_asis_pers.Click
        DateTP_asis_pers.Enabled = False
        Cb_estado.Enabled = False
        Tb_observaciones.Enabled = False
        Cb_estado.SelectedIndex = -1
        Tb_observaciones.Clear()
       
        habilita_botones(False, True, False, False, True, True, True)
    End Sub

    'LIMPIA EL COMBO DE TURNO CUANDO SE CAMBIA DE DIA
    Private Sub Cmb_dia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_dia.SelectedIndexChanged
        Cmb_turno.SelectedIndex = -1
    End Sub

    'BOTON BUSCAR, MUESTRA LA GRILLA DE HORARIOS DE DOCENTES FILTRADO EL DNI DE UN DOCENTE O UN DIA Y TURNO
    Private Sub Btn_buscar_hs_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_asis_personal.Click

        Dg_Docente_x_dia.Enabled = True
        Dg_Obligaciones_docente.Enabled = True
        Select Case Rb_dia.Checked
            Case False
                Try
                    Dim BuscaPersonal = (From pers In DataContext.Personal Where pers.DNI_pers = CInt(Tb_dni.Text)).ToList()(0)
                    If BuscaPersonal.puesto_pers = "Preceptor" Or BuscaPersonal.puesto_pers = "Directivo" Then
                        MsgBox("El dni ingresado no corresponde a  un profesor, ingrese nuevamente")
                        Tb_dni.Clear()
                        Tb_dni.Select()
                        Exit Sub
                    End If
                    vble_id_pers_asis = BuscaPersonal.id_personal
                    Tb_apellidoynombre.Text = BuscaPersonal.apelliido_pers & ", " & BuscaPersonal.nombre_pers
                    Btn_editar_inasis_pers.Enabled = True
                    Tb_dni.Enabled = False
                Catch ex As Exception
                    MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                    Btn_limpiar_asis_personal.Enabled = False
                    Btn_buscar_asis_personal.Enabled = True
                    Tb_dni.Clear()
                    Exit Sub
                    'Tb_dni.Text = ""

                End Try

                Dim datagriddiapordni = From d In datacontextvistas.Vista_Docente_x_dia Select d.apelliido_pers, d.nombre_pers, d.DNI_pers, d.turno_textbox, d.dia_semana, d.id_personal Where DNI_pers = Tb_dni.Text
                armargrilladia(datagriddiapordni, False, False, False, True, True)

                Label_seleccione_dia.Visible = True
                Label_seleccione_doc.Visible = False

            Case True
                Dim datagriddiaporturno = From d In datacontextvistas.Vista_Docente_x_dia Select d.apelliido_pers, d.nombre_pers, d.DNI_pers, d.turno_textbox, d.dia_semana, d.id_personal Where dia_semana = Cmb_dia.Text And turno_textbox = Cmb_turno.Text
                armargrilladia(datagriddiaporturno, True, True, True, False, False)
                Label_seleccione_doc.Visible = True
                Label_seleccione_dia.Visible = False
        End Select
        Btn_limpiar_asis_personal.Enabled = True
        Btn_buscar_asis_personal.Enabled = False

    End Sub

    'BOTON LIMPIAR
    Private Sub Btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_limpiar_asis_personal.Click
        Tb_dni.Enabled = True
        Tb_dni.Clear()
        Tb_dni.Select()
        Tb_apellidoynombre.Clear()
        Dg_Docente_x_dia.Columns.Clear()
        Dg_Obligaciones_docente.Columns.Clear()
        Label_seleccione_dia.Visible = False
        Label_seleccione_doc.Visible = False
        Cmb_dia.SelectedIndex = -1
        Cmb_turno.SelectedIndex = -1
        Cb_estado.SelectedIndex = -1
        Tb_observaciones.Enabled = False
        Cb_estado.Enabled = False
        DateTP_asis_pers.Enabled = False
        Tb_observaciones.Clear()

        habilita_botones(True, False, False, False, False, False, False)
    End Sub

    'FUNCION QUE VALIDA SI UN HORARIO YA POSEE UNA INSISTENCIA
    Private Function valida_existencia_inasistencia(ByVal idhorario As Integer, ByVal fecha As Date)
        Dim busca_inasistencia = (From i In DataContext.Asistencia_docentes Select i.id_horario, i.fecha_asistencia Where id_horario = idhorario And fecha_asistencia = fecha).Any
        If busca_inasistencia = True Then
            MsgBox("El horario ya tiene una inasistencia registrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ausencia registrada")
            habilita_botones(False, True, False, False, True, True, True)
            Cb_estado.SelectedIndex = -1
            Tb_observaciones.Enabled = False
            Cb_estado.Enabled = False
            DateTP_asis_pers.Enabled = False


            Return "ocupado"
        Else
            Return "libre"
        End If
    End Function

    'BOTON SALIR
    Private Sub Btn_salir_asis_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_asis_personal.Click
        Me.Close()
    End Sub

    'ABRE EL FORM DE AUSENCIAS DEL DOCENTE SELECCIONADO
    Private Sub Btn_editar_inasis_pers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_editar_inasis_pers.Click
        Dim frm = New Frm_Ver_Inasistencia
        frm.Show()

    End Sub

    'HABILITA Y DESHABILITA BOTONES
    Sub habilita_botones(ByVal btnbuscar As Boolean, ByVal btnlimpiar As Boolean, ByVal btnguardar As Boolean, ByVal btncancelar As Boolean, ByVal btneditar As Boolean, ByVal dgdocente As Boolean, ByVal dgobligaciones As Boolean)
        Btn_buscar_asis_personal.Enabled = btnbuscar
        Btn_limpiar_asis_personal.Enabled = btnlimpiar
        Btn_guardar_asis_pers.Enabled = btnguardar
        Btn_cancelar_asis_pers.Enabled = btncancelar
        Btn_editar_inasis_pers.Enabled = btneditar
        Dg_Docente_x_dia.Enabled = dgdocente
        Dg_Obligaciones_docente.Enabled = dgobligaciones
    End Sub

    
    
End Class
