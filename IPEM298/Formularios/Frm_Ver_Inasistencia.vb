Public Class Frm_Ver_Inasistencia
    Dim Datacontext As New DataClassesipem2DataContext
    Dim Datacontextvistas As New DataClassesdevistasDataContext

    Dim vble_id_asis As Integer

    'MUESTRA LA GRILLA DE INASISTENCIA DEL DOCENTE SELECCIONADO EN EL FORM DE ASISTENCIA
    Sub carga_grilla_inasistencias()
        Dg_ver_inasis.AutoGenerateColumns = False
        Dg_ver_inasis.Columns.Clear()

        Dg_ver_inasis.Columns.Add("id_asistencia_doc", "Id")
        Dg_ver_inasis.Columns.Add("fecha_asistencia", "Fecha")
        Dg_ver_inasis.Columns.Add("estado_textbox", "Estado")
        Dg_ver_inasis.Columns.Add("observacion", "Observación")
        Dg_ver_inasis.Columns.Add("id_personal", "Id_personal")
        Dg_ver_inasis.Columns.Add("nombre_materia", "Materia")
        Dg_ver_inasis.Columns.Add("nombre_curso", "Curso")
        Dg_ver_inasis.Columns.Add("numero", "Módulo")
        Dg_ver_inasis.Columns.Add("turno_tetbox", "Turno")

        Dg_ver_inasis.Columns(0).DataPropertyName = "id_asistencia_doc"
        Dg_ver_inasis.Columns(1).DataPropertyName = "fecha_asistencia"
        Dg_ver_inasis.Columns(2).DataPropertyName = "estado_textbox"
        Dg_ver_inasis.Columns(3).DataPropertyName = "observacion"
        Dg_ver_inasis.Columns(4).DataPropertyName = "id_personal"
        Dg_ver_inasis.Columns(5).DataPropertyName = "nombre_materia"
        Dg_ver_inasis.Columns(6).DataPropertyName = "nombre_curso"
        Dg_ver_inasis.Columns(7).DataPropertyName = "numero"
        Dg_ver_inasis.Columns(8).DataPropertyName = "turno_textbox"

        Dg_ver_inasis.Columns(0).Visible = False
        Dg_ver_inasis.Columns(4).Visible = False

        Dim inasistencia = From i In Datacontextvistas.Vista_inasistencia_personal Select i.id_asistencia_doc, i.fecha_asistencia, i.estado_textbox, i.observacion, i.id_personal, i.nombre_materia, i.numero, i.nombre_curso, i.turno_textbox Where id_personal = Frm_Asistencia_Personal.vble_id_pers_asis
        Dg_ver_inasis.DataSource = inasistencia

        Dg_ver_inasis.ClearSelection()
    End Sub

    'LOAD DEL FORM
    Private Sub Frm_Ver_Inasistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_grilla_inasistencias()
        Dim nya = (From n In Datacontextvistas.Vista_inasistencia_personal Select n.id_personal, n.nombre_pers, n.apelliido_pers Where id_personal = Frm_Asistencia_Personal.vble_id_pers_asis).ToList()(0)
        Tb_nombreyapellido.Text = nya.apelliido_pers & ", " & nya.nombre_pers
    End Sub

    'BOTON ELIMINAR
    Private Sub Btn_eliminar_hs_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_eliminar_hs_personal.Click
        Try
            Dim eliminar = (From a In Datacontext.Asistencia_docentes Where a.id_asistencia_doc = CInt(vble_id_asis)).ToList()(0)
            If MsgBox("Esta por eliminar una ausencia, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Datacontext.Asistencia_docentes.DeleteOnSubmit(eliminar)
                Datacontext.SubmitChanges()
                carga_grilla_inasistencias()
                MsgBox("La ausencia fue borrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ausencia borrada")
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un item", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Elija un Registro")
        End Try
    End Sub

    'CLICK SOBRE GRILLA
    Private Sub Dg_ver_inasis_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ver_inasis.CellClick
        If Dg_ver_inasis.SelectedRows.Count > 0 Then
            vble_id_asis = Dg_ver_inasis.Item("id_asistencia_doc", Dg_ver_inasis.SelectedRows(0).Index).Value
        End If
    End Sub

    'BOTON VOLVER
    Private Sub Btn_volver_inasis_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_inasis_personal.Click
        Me.Close()
    End Sub

   
End Class