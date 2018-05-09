Public Class Frm_ver_inasistencia_alu
    Dim datacontext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim vble_idalu

    'LOAD DEL FORM
    Private Sub Frm_ver_inasistencia_alu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim nya = (From n In datacontextvistas.Vista_inasistencia_alumno Select n.id_alumno, n.nombre_alu, n.apellido_alu Where id_alumno = CInt(Frm_Asistencia_Alumno.vble_id_alu_asis)).ToList()(0)
        Tb_nombreyapellido_inasis_alu.Text = nya.apellido_alu & ", " & nya.nombre_alu
        cargargrilla()
    End Sub

    'ARMA Y CARGA LA GRILLA DE LAS INASISTENCIAS DE UN ALUMNO
    Sub cargargrilla()
        Dim inasisalu = From i In datacontext.Asistencia_alumnos Select i.id_asistencia_alu, i.fecha_asistencia_alu, i.estado_asistencia_alu, i.observacion_asis_alu, i.id_alumno Where id_alumno = CInt(Frm_Asistencia_Alumno.vble_id_alu_asis)

        Dg_ver_inasis_alu.AutoGenerateColumns = False
        Dg_ver_inasis_alu.Columns.Clear()

        Dg_ver_inasis_alu.Columns.Add("id_asistencia_alu", "Id Asistencia")
        Dg_ver_inasis_alu.Columns.Add("fecha_asistencia_alu", "Fecha de Inasistencia")
        Dg_ver_inasis_alu.Columns.Add("estado_asistencia_alu", "Estado")
        Dg_ver_inasis_alu.Columns.Add("observacion_asis_alu", "Observación")
        Dg_ver_inasis_alu.Columns.Add("id_alumno", "Id Alumno")

        Dg_ver_inasis_alu.Columns(0).DataPropertyName = "id_asistencia_alu"
        Dg_ver_inasis_alu.Columns(1).DataPropertyName = "fecha_asistencia_alu"
        Dg_ver_inasis_alu.Columns(2).DataPropertyName = "estado_asistencia_alu"
        Dg_ver_inasis_alu.Columns(3).DataPropertyName = "observacion_asis_alu"
        Dg_ver_inasis_alu.Columns(4).DataPropertyName = "id_alumno"

        Dg_ver_inasis_alu.Columns(0).Visible = False
        Dg_ver_inasis_alu.Columns(4).Visible = False

        Dg_ver_inasis_alu.DataSource = inasisalu
        Dg_ver_inasis_alu.ClearSelection()
    End Sub

    'CLICK SOBRE GRILLA
    Private Sub Dg_ver_inasis_alu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_ver_inasis_alu.CellClick
        If Dg_ver_inasis_alu.SelectedRows.Count > 0 Then
            vble_idalu = Dg_ver_inasis_alu.Item("id_asistencia_alu", Dg_ver_inasis_alu.SelectedRows(0).Index).Value
        End If
    End Sub

    'BOTON ELIMINAR
    Private Sub Btn_eliminar_inasis_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_eliminar_inasis_alu.Click
        Try
            Dim eliminar = (From a In datacontext.Asistencia_alumnos Where a.id_asistencia_alu = CInt(vble_idalu)).ToList()(0)
            If MsgBox("Esta por eliminar una ausencia, desea continuar?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                datacontext.Asistencia_alumnos.DeleteOnSubmit(eliminar)
                datacontext.SubmitChanges()
                cargargrilla()
                MsgBox("La ausencia fue borrada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ausencia borrada")
                Frm_Asistencia_Alumno.limpia_campos("inasis")
            End If
            If Frm_Asistencia_Alumno.Rb_curso_asis_alu.Checked = True Then
                Frm_Asistencia_Alumno.habilita_campos(False, False, False)
                Frm_Asistencia_Alumno.habilita_botones(False, True, False, False, False, True, True)
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar un item", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Elija un Registro")
        End Try
    End Sub

    'BOTON VOLVER
    Private Sub Btn_volver_inasis_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_inasis_alu.Click
        Me.Close()
    End Sub
End Class