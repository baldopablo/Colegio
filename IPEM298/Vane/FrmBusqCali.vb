Public Class FrmBusqCali
    Dim DataContext As New DataClassesipem2DataContext

    'LOAD DEL FORM
    Private Sub FrmBusqCali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
            Try
                Dim BuscaAlu = (From alu In DataContext.Alumno Where alu.apellido_alu = (FrmConsultaCalificaciones.txtApellido.Text)).ToList()(0)
                ActualizaGrilla()
            Catch ex As Exception
                MsgBox("El registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
        End Try
    End Sub

    'CARGA LA GRILLA
    Private Sub ActualizaGrilla()

        Dim consulta = From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu Where apellido_alu = (FrmConsultaCalificaciones.txtApellido.Text)

        drgBuscarAlu.Enabled = True
        drgBuscarAlu.AutoGenerateColumns = False
        drgBuscarAlu.Columns.Clear()

        drgBuscarAlu.Columns.Add("id_alumno", "Id Alumno")
        drgBuscarAlu.Columns.Add("nombre_alu", "Nombre")
        drgBuscarAlu.Columns.Add("apellido_alu", "Apellido")
        drgBuscarAlu.Columns.Add("DNI_alu", "DNI")


        drgBuscarAlu.Columns(0).DataPropertyName = "id_alumno"
        drgBuscarAlu.Columns(1).DataPropertyName = "nombre_alu"
        drgBuscarAlu.Columns(2).DataPropertyName = "apellido_alu"
        drgBuscarAlu.Columns(3).DataPropertyName = "DNI_alu"

        drgBuscarAlu.DataSource = consulta
        drgBuscarAlu.ClearSelection()

    End Sub

    'BOTON SALIR
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        FrmConsultaCalificaciones.Enabled = True
        FrmConsultaCalificaciones.Show()
        Me.Close()
    End Sub

    'PASA LOS DATOS AL FRM
    Private Sub PasaDatos()
        If drgBuscarAlu.SelectedRows.Count > 0 Then
            FrmConsultaCalificaciones.txtNombre.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmConsultaCalificaciones.txtApellido.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmConsultaCalificaciones.txtDNI.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmConsultaCalificaciones.txtIdAlu.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
        End If
    End Sub

    'BOTON ACEPTAR
    Private Sub Btn_aceptar_buscacalif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_aceptar_buscacalif.Click
        PasaDatos()

        FrmConsultaCalificaciones.Enabled = True
        FrmConsultaCalificaciones.Show()
        FrmConsultaCalificaciones.rbnMateria.Enabled = True
        FrmConsultaCalificaciones.rbnCondición.Enabled = True
        FrmConsultaCalificaciones.rbnTodos.Enabled = True
        Me.Close()
    End Sub
End Class