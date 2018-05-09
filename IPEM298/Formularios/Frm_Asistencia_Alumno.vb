Public Class Frm_Asistencia_Alumno
    Dim datacontext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Public vble_id_alu_asis

    'LOAD DEL FORM
    Private Sub Frm_Asistencia_Alumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_dni_asis_alu.Select()
    End Sub

    'CARGA EL COMDO DE CURSO SEGUN EL TURNO
    Private Sub Cmb_turno_asis_alu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_turno_asis_alu.SelectedIndexChanged
        Dim cbocurso = (From c In datacontextvistas.vista_modulocurso Select c.id_curso, c.nombre_curso, c.turno_textbox Where turno_textbox = CStr(Cmb_turno_asis_alu.SelectedItem)).Distinct
        Cmb_curso_asis_alu.DataSource = cbocurso
        Cmb_curso_asis_alu.DisplayMember = "nombre_curso"
        Cmb_curso_asis_alu.ValueMember = "id_curso"
        Cmb_curso_asis_alu.SelectedIndex = -1
    End Sub

    'ARMA Y CARGA LA GRILLA DE ALUMNOS POR CURSO
    Sub carga_grilla_alumnos()
        Dim alu = From a In datacontextvistas.vista_alum_xcurso Select a.nombre_alu, a.apellido_alu, a.nombre_curso, a.id_alumno Where nombre_curso = CStr(Cmb_curso_asis_alu.Text)

        Dg_asis_alumno.AutoGenerateColumns = False
        Dg_asis_alumno.Columns.Clear()
        Dg_asis_alumno.ClearSelection()

        Dg_asis_alumno.Columns.Add("nombre_alu", "Nombre")
        Dg_asis_alumno.Columns.Add("apellido_alu", "Apellido")
        Dg_asis_alumno.Columns.Add("id_alumno", "Id")

        Dg_asis_alumno.Columns(0).DataPropertyName = "nombre_alu"
        Dg_asis_alumno.Columns(1).DataPropertyName = "apellido_alu"
        Dg_asis_alumno.Columns(2).DataPropertyName = "id_alumno"
        Dg_asis_alumno.Columns(2).Visible = False


        Dg_asis_alumno.DataSource = alu
        Dg_asis_alumno.ClearSelection()
    End Sub

    'BOTON BUSCAR
    Private Sub Btn_buscar_asis_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_asis_alu.Click
        Select Case Rb_dni_asis_alu.Checked
            Case True
                Try
                    Dim BuscaAlumno = (From pers In datacontext.Alumno Where pers.DNI_alu = CInt(Tb_dni_asis_alu.Text)).ToList()(0)
                    vble_id_alu_asis = CInt(BuscaAlumno.id_alumno)

                    Tb_apellidoynombre_asis_alu.Text = BuscaAlumno.apellido_alu & ", " & BuscaAlumno.nombre_alu
                    habilita_campos(True, True, True)
                    habilita_botones(False, True, False, False, True, True, False)
                Catch ex As Exception
                    MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                    limpia_campos("todos")
                    Exit Sub
                End Try

            Case Else
                Try
                    habilita_botones(False, True, False, False, False, True, True)
                    Cmb_curso_asis_alu.Enabled = False
                    Cmb_turno_asis_alu.Enabled = False
                    carga_grilla_alumnos()

                Catch ex As Exception
                    MsgBox("Seleccione curso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                    Exit Sub
                End Try

        End Select
    End Sub

    'RBT DNI
    Private Sub Rb_dni_asis_alu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_dni_asis_alu.CheckedChanged
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False
        Cmb_curso_asis_alu.SelectedIndex = -1
        Cmb_turno_asis_alu.SelectedIndex = -1
        Tb_dni_asis_alu.Enabled = True
        Dg_asis_alumno.Columns.Clear()
        habilita_botones(True, False, False, False, False, False, True)
        limpia_campos("todos")
        habilita_campos(False, False, False)

    End Sub

    'RBT CURSO
    Private Sub Rb_curso_asis_alu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb_curso_asis_alu.CheckedChanged
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        Cmb_curso_asis_alu.SelectedIndex = -1
        Cmb_turno_asis_alu.SelectedIndex = -1
        Tb_dni_asis_alu.Clear()
        Tb_apellidoynombre_asis_alu.Clear()
        Me.Btn_buscar_asis_alu.Enabled = True
        habilita_campos(False, False, False)
        habilita_botones(True, False, False, False, False, False, True)
        limpia_campos("todos")
    End Sub

    'CLICK SOBRE LA GRILLA DE ALUMNOS POR CURSO
    Private Sub Dg_asis_alumno_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_asis_alumno.CellClick
        If Dg_asis_alumno.SelectedRows.Count > 0 Then
            vble_id_alu_asis = Dg_asis_alumno.Item("id_alumno", Dg_asis_alumno.SelectedRows(0).Index).Value
            habilita_botones(False, True, False, False, True, True, False)
            habilita_campos(True, True, True)
        End If

    End Sub

    ' BOTON GUARDAR
    Private Sub Btn_guardar_asis_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar_asis_alu.Click
        If validar_inasistencia(vble_id_alu_asis) = "ocupado" Then
            limpia_campos("inasis")
            Select Case Rb_curso_asis_alu.Checked
                Case True
                    habilita_campos(False, False, False)
                    habilita_botones(False, True, False, False, False, True, True)
            End Select
            Exit Sub
        End If

        Dim inasistencia As New Asistencia_alumnos
        Try
            If Cb_estado_alu.SelectedIndex = -1 Then
                MsgBox("Elija un estado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Campo en blanco")
                Exit Sub
            Else
                inasistencia.estado_asistencia_alu = Cb_estado_alu.Text
            End If
            inasistencia.id_alumno = vble_id_alu_asis
            inasistencia.fecha_asistencia_alu = DateTP_asis_alu.Text

        Catch ex As Exception
            MsgBox("Complete todos los datos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Campo en blanco")
        End Try
        inasistencia.observacion_asis_alu = Tb_observaciones_alu.Text
        datacontext.Asistencia_alumnos.InsertOnSubmit(inasistencia)
        datacontext.SubmitChanges()
        MsgBox("La ausencia fue guardada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Registrar inasistencia")
        limpia_campos("inasis")
        Select Case Rb_curso_asis_alu.Checked
            Case True
                habilita_campos(False, False, False)
                habilita_botones(False, True, False, False, False, True, True)
                Cmb_curso_asis_alu.Enabled = True
                Cmb_turno_asis_alu.Enabled = True
            Case Else
                habilita_botones(False, True, False, False, True, False, True)
        End Select

    End Sub

    'VALIDA SI EL ALUMNO YA TIENE LA FALTA EN EL DIA
    Private Function validar_inasistencia(ByVal idalumno As Integer)
        Dim valida_inasis = (From i In datacontext.Asistencia_alumnos Select i.id_alumno, i.fecha_asistencia_alu Where id_alumno = idalumno And fecha_asistencia_alu = DateTP_asis_alu.Text).Any
        If valida_inasis = True Then
            MsgBox("El alumno ya tiene una inasistencia registrada en esa fecha", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ausencia registrada")
            Return "ocupado"
        Else
            Return ("libre")
        End If
    End Function

    'BOTON EDITAR INASISTENCIA
    Private Sub Btn_editar_inasis_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_editar_inasis_alu.Click
        Dim frm = New Frm_ver_inasistencia_alu
        frm.Show()
    End Sub

    'BOTON SALIR
    Private Sub Btn_salir_asis_alumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_asis_alumno.Click
        Me.Close()
    End Sub

    'HABILITA Y DESHABILITA CAMPOS
    Sub habilita_campos(ByVal fecha As Boolean, ByVal estado As Boolean, ByVal obs As Boolean)
        Me.DateTP_asis_alu.Enabled = fecha
        Me.Cb_estado_alu.Enabled = estado
        Me.Tb_observaciones_alu.Enabled = obs
    End Sub

    'HABILITA Y DESHABILITA BOTONES
    Sub habilita_botones(ByVal btnbuscar As Boolean, ByVal btnlimpiar As Boolean, ByVal btnguardar As Boolean, ByVal btncancelar As Boolean, ByVal btneditar As Boolean, ByVal dgalumno As Boolean, ByVal btnsalir As Boolean)
        Me.Btn_buscar_asis_alu.Enabled = btnbuscar
        Me.Btn_limpiar_asis_personal.Enabled = btnlimpiar
        Me.Btn_guardar_asis_alu.Enabled = btnguardar
        Me.Btn_cancelar_asis_alu.Enabled = btncancelar
        Me.Btn_editar_inasis_alu.Enabled = btneditar
        Me.Dg_asis_alumno.Enabled = dgalumno
        Me.Btn_salir_asis_alumno.Enabled = btnsalir
    End Sub

    'LIMPIA CAMPOS
    Sub limpia_campos(ByVal campos As String)
        Select Case campos
            Case "todos"
                Me.Tb_dni_asis_alu.Clear()
                Me.Tb_apellidoynombre_asis_alu.Clear()
                Me.Cmb_turno_asis_alu.SelectedIndex = -1
                Me.Cmb_curso_asis_alu.SelectedIndex = -1
                Me.Cb_estado_alu.SelectedIndex = -1
                Me.Tb_observaciones_alu.Clear()
                Dg_asis_alumno.ClearSelection()
            Case "inasis"
                Me.Cb_estado_alu.SelectedIndex = -1
                Me.Tb_observaciones_alu.Clear()
                Dg_asis_alumno.ClearSelection()
        End Select
        
    End Sub

    'BOTON CANCELAR
    Private Sub Btn_cancelar_asis_alu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancelar_asis_alu.Click
        limpia_campos("inasis")
        habilita_campos(True, True, True)
        If Rb_dni_asis_alu.Checked = True Then
            habilita_botones(False, True, False, False, True, False, True)
        Else
            habilita_botones(False, True, False, False, False, True, True)
        End If
    End Sub

    'BOTON LIMPIAR
    Private Sub Btn_limpiar_asis_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_limpiar_asis_personal.Click
        If Rb_curso_asis_alu.Checked = True Then
            Cmb_curso_asis_alu.SelectedIndex = -1
            Cmb_turno_asis_alu.SelectedIndex = -1
            Dg_asis_alumno.Columns.Clear()
            Cmb_curso_asis_alu.Enabled = True
            Cmb_turno_asis_alu.Enabled = True
        End If
        habilita_botones(True, False, False, False, False, False, True)
        limpia_campos("todos")
        habilita_campos(False, False, False)
        Tb_dni_asis_alu.Select()
    End Sub

    'SELECCION SOBRE COMBO DE ESTADO
    Private Sub Cb_estado_alu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cb_estado_alu.SelectedIndexChanged
        habilita_botones(False, True, True, True, False, False, False)
        If Rb_curso_asis_alu.Checked = True Then
            Dg_asis_alumno.Enabled = False
        End If
    End Sub
End Class