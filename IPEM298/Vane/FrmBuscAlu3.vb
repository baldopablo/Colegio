Public Class FrmBuscAlu3
    Dim DataContext As New DataClassesipem2DataContext
    Dim id As Integer

    'LOAD DEL FORM 
    Private Sub FrmBuscAlu3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizaGrilla()
        'MostrarGrilla()
    End Sub


    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub


    'COMENTADO BOTON BUSCAR
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If txtApellido.Text = "" Then
        '    MsgBox("Ingrese un apellido para buscar!")
        'Else
        '    Try
        '        Dim BuscaAlu = (From alu In DataContext.Alumno Where alu.apellido_alu = (txtApellido.Text)).ToList()(0)
        '        ActualizaGrilla()
        '    Catch ex As Exception
        '        MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
        '        LimpiarControles()
        '    End Try
        'End If
    End Sub


    'CARGA LA GRILLA CON TODOS LOS ALUMNOS DE IGUAL APELLIDO
    Private Sub ActualizaGrilla()

        If Frm_principal.quienllamofrmbuscaalu3.Name = FrmAlumno.Name Then
            drgBuscarAlu.Enabled = True
            drgBuscarAlu.AutoGenerateColumns = False
            drgBuscarAlu.Columns.Clear()

            drgBuscarAlu.Columns.Add("id_alumno", "Id Alumno")
            drgBuscarAlu.Columns.Add("nombre_alu", "Nombre")
            drgBuscarAlu.Columns.Add("apellido_alu", "Apellido")
            drgBuscarAlu.Columns.Add("DNI_alu", "DNI")
            drgBuscarAlu.Columns.Add("fecha_inscripcion_alu", "Inscripción")

            drgBuscarAlu.Columns(0).DataPropertyName = "id_alumno"
            drgBuscarAlu.Columns(1).DataPropertyName = "nombre_alu"
            drgBuscarAlu.Columns(2).DataPropertyName = "apellido_alu"
            drgBuscarAlu.Columns(3).DataPropertyName = "DNI_alu"
            drgBuscarAlu.Columns(4).DataPropertyName = "fecha_inscripcion_alu"


            Dim consultaalu = From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu, U.fecha_inscripcion_alu Where apellido_alu = (FrmAlumno.txtApellidoAlu.Text)
            drgBuscarAlu.DataSource = consultaalu

        ElseIf Frm_principal.quienllamofrmbuscaalu3.Name = FrmAsignarCurso.Name Then
            drgBuscarAlu.Enabled = True
            drgBuscarAlu.AutoGenerateColumns = False
            drgBuscarAlu.Columns.Clear()

            drgBuscarAlu.Columns.Add("id_alumno", "Id Alumno")
            drgBuscarAlu.Columns.Add("nombre_alu", "Nombre")
            drgBuscarAlu.Columns.Add("apellido_alu", "Apellido")
            drgBuscarAlu.Columns.Add("DNI_alu", "DNI")
            drgBuscarAlu.Columns.Add("fecha_inscripcion_alu", "Inscripción")

            drgBuscarAlu.Columns(0).DataPropertyName = "id_alumno"
            drgBuscarAlu.Columns(1).DataPropertyName = "nombre_alu"
            drgBuscarAlu.Columns(2).DataPropertyName = "apellido_alu"
            drgBuscarAlu.Columns(3).DataPropertyName = "DNI_alu"
            drgBuscarAlu.Columns(4).DataPropertyName = "fecha_inscripcion_alu"
            Dim consultaasigna = From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu, U.fecha_inscripcion_alu Where apellido_alu = (FrmAsignarCurso.txtApellido.Text)
            drgBuscarAlu.DataSource = consultaasigna
        End If

        drgBuscarAlu.ClearSelection()
    End Sub


    Private Sub LimpiarControles()
        ' txtApellido.Text = ""
        '  MostrarGrilla()
    End Sub

    'COMENTADO BOTON CANCELAR
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'LimpiarControles()
    End Sub

    'BOTON SALIR
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        'FrmAlumno.Enabled = True
        Me.Close()
        'FrmAlumno.Show()
    End Sub

    'COMENTADO PASA LOS DATOS DEL GRID A LOS CAMPOS
    Private Sub PasaDatos()

        'If drgBuscarAlu.SelectedRows.Count > 0 Then
        '    FrmAlumno.txtNombreAlu.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    FrmAlumno.txtApellidoAlu.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    FrmAlumno.txtBuscar.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
        '    'FrmAlumno.txtidAlu.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
        'End If
    End Sub

    'COMENTADO CLICK SOBRE LA GRILLA
    Private Sub drgBuscarAlu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles drgBuscarAlu.CellClick
        'PasaDatos()

        'FrmAlumno.Enabled = True
        'FrmAlumno.Show()
        'FrmAlumno.cmdBuscar.Enabled = False
        'FrmAlumno.cmdLimpiar.Enabled = True
        'Me.Close()
    End Sub

    'BOTON ACEPTAR
    Private Sub Btn_aceptar_buscalu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_aceptar_buscalu3.Click
        If Frm_principal.quienllamofrmbuscaalu3.Name = FrmAlumno.Name Then
            If drgBuscarAlu.SelectedRows.Count > 0 Then
                FrmAlumno.txtNombreAlu.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAlumno.txtApellidoAlu.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAlumno.txtDNI_alu.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAlumno.txtidAlu.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAlumno.MostrarGrilla()

                Me.Close()
            End If
        ElseIf Frm_principal.quienllamofrmbuscaalu3.Name = FrmAsignarCurso.Name Then
            If drgBuscarAlu.SelectedRows.Count > 0 Then
                FrmAsignarCurso.txtApellido.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAsignarCurso.txtDNI.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAsignarCurso.txtNombre.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAsignarCurso.txtIdAlu.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAsignarCurso.Txt_fecha_ins.Text = drgBuscarAlu.Item("fecha_inscripcion_alu", drgBuscarAlu.SelectedRows(0).Index).Value
                FrmAsignarCurso.MostrarGrilla()

                Me.Close()
            End If
        End If
    End Sub
End Class