Public Class FrmBusqAlu1
    Dim DataContext As New DataClassesipem2DataContext
    Dim id As Integer

    'LOAD DEL FORM
    Private Sub FrmBusqAlu1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FrmCalificaciones2.txtapellido.Text = "" Then
            MsgBox("Ingrese un apellido para buscar!")
            Me.Close()
        Else
            Try
                Dim BuscaAlu = (From alu In DataContext.Alumno Where alu.apellido_alu = (FrmCalificaciones2.txtapellido.Text)).ToList()(0)
                ActualizaGrilla()
            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            End Try
        End If
    End Sub

    'CARGA LA GRILLA
    Private Sub ActualizaGrilla()

        Dim consulta = From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu Where apellido_alu = (FrmCalificaciones2.txtapellido.Text)

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

        'FrmCalificaciones.Enabled = True
        'FrmCalificaciones.Show()
        Me.Close()
    End Sub

    'PASA LOS DATOS AL FM CALIFICACIONES
    Private Sub PasaDatos()
        ''calificaciones
        'If drgBuscarAlu.SelectedRows.Count > 0 Then
        '    FrmCalificaciones.txtnombre.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    FrmCalificaciones.txtapellido.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    FrmCalificaciones.txtDNI.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    FrmCalificaciones.txtIdAlu1.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
        'End If

        'calificaciones 2
        If drgBuscarAlu.SelectedRows.Count > 0 Then
            FrmCalificaciones2.txtnombre.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones2.txtapellido.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones2.txtDNI.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones2.vble_idalu = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones2.cargar_materias()
        End If
    End Sub

    'BOTON ACEPTAR
    Private Sub Btn_aceptar_buscapers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_aceptar_buscaalu.Click
        PasaDatos()
        FrmCalificaciones2.GroupBox_materia.Enabled = True
        Me.Close()
    End Sub
End Class