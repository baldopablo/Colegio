
Public Class FrmHorariosPersonal
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim vble_id_pers As Integer
    Dim vble_id_horario As Integer
    
    'HABILITA Y DESHABILITA LOS BOTONES POR PARAMETROS
    Public Sub botones(ByVal btnguardar As String, ByVal btncancelar As String, ByVal btnmodificar As String, ByVal btneliminar As String, ByVal btnagregar As String, ByVal btnbuscar As String, ByVal datagrid As String, ByVal txtdni As String, ByVal btnlimpiar As String)
        Btn_guardar_hs_personal.Enabled = btnguardar
        Btn_Cancelar_hs_personal.Enabled = btncancelar
        Btn_modificar_hs_personal.Enabled = btnmodificar
        Btn_eliminar_hs_personal.Enabled = btneliminar
        Btn_agregar_hs_personal.Enabled = btnagregar
        Btn_buscar_hs_personal.Enabled = btnbuscar
        DataGridView1.Enabled = datagrid
        txt_DNI.Enabled = txtdni
        Btn_limpiar_hs_personal.Enabled = btnlimpiar
    End Sub

    'BOTON SALIR
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_hs_personal.Click
        Me.Close()
    End Sub

    'LOAD DEL FORM
    Private Sub FrmHorariosPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_DNI.Select()
        MostrarGrilla()
    End Sub

    'BOTON BUSCAR
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_hs_personal.Click
        Try
            Dim BuscaPersonal = (From pers In DataContext.Personal Where pers.DNI_pers = CInt(txt_DNI.Text)).ToList()(0)
            If BuscaPersonal.puesto_pers = "Preceptor" Or BuscaPersonal.puesto_pers = "Directivo" Then
                MsgBox("El dni ingresado no corresponde a  un profesor, ingrese nuevamente")
                txt_DNI.Clear()
                txt_DNI.Select()
                Exit Sub
            End If
            txt_nombre.Text = BuscaPersonal.nombre_pers
            txt_apellido.Text = BuscaPersonal.apelliido_pers
            txtleg_prov.Text = BuscaPersonal.leg_provincial_pers
            vble_id_pers = CInt(BuscaPersonal.id_personal)
            cargar_materias()
            MostrarGrilla()
            botones(False, False, False, False, True, False, True, False, True)


        Catch ex As Exception
            MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            LimpiarControles()
            botones(False, False, False, False, False, True, True, True, False)
            txt_DNI.Select()
        End Try
    End Sub

    'CARGA LA LISTA DE MATERIAS SEGUN EL DOCENTE ELEGIDO
    Sub cargar_materias()

        Dim mat = From m In datacontextvistas.VistaProfxMateria Select m.id_materia, m.nombre_materia, m.id_personal Where id_personal = vble_id_pers
        ''Carga el combo de materias independientemente del turno
        Me.cbomateria.DataSource = mat
        Me.cbomateria.DisplayMember = "nombre_materia"
        Me.cbomateria.ValueMember = "id_materia"
        Me.cbomateria.SelectedIndex = -1
    End Sub

    'MUESTRA Y CARGA LA GRILLA
    Private Sub MostrarGrilla()

        Dim datagridhorario = From d In datacontextvistas.vista_horario_personal Select d.dia_semana, d.nombre_curso, d.nombre_materia, d.numero, d.hora_inicio, d.hora_fin, d.id_horario, d.id_personal, d.turno_textbox Where id_personal = vble_id_pers
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add("dia_semana", "Día")
        DataGridView1.Columns.Add("nombre_curso", "Curso")
        DataGridView1.Columns.Add("nombre_materia", "Materia")
        DataGridView1.Columns.Add("numero", "Módulo")
        DataGridView1.Columns.Add("hora_inicio", "Hora Inicio")
        DataGridView1.Columns.Add("hora_fin", "Hora Fin")
        DataGridView1.Columns.Add("id_horario", "Id_Horario")
        DataGridView1.Columns.Add("turno_textbox", "Turno")

        DataGridView1.Columns(0).DataPropertyName = "dia_semana"
        DataGridView1.Columns(1).DataPropertyName = "nombre_curso"
        DataGridView1.Columns(2).DataPropertyName = "nombre_materia"
        DataGridView1.Columns(3).DataPropertyName = "numero"
        DataGridView1.Columns(4).DataPropertyName = "hora_inicio"
        DataGridView1.Columns(5).DataPropertyName = "hora_fin"
        DataGridView1.Columns(6).DataPropertyName = "id_horario"
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).DataPropertyName = "turno_textbox"

        DataGridView1.DataSource = datagridhorario
    End Sub

    'LIMPIA LOS TEXTBOX Y LA GRILLA
    Private Sub LimpiarControles()
        txt_apellido.Text = ""
        txt_DNI.Text = ""
        txt_nombre.Text = ""
        txtleg_prov.Text = ""
        LimpiarCombos()
        DataGridView1.Columns.Clear()


    End Sub

    'LIMPIA Y DESHABILITA LOS COMBOS
    Private Sub LimpiarCombos()
        cbocurso.SelectedIndex = -1
        cbodiasemana.SelectedIndex = -1
        cbomateria.SelectedIndex = -1
        cbomodulo.SelectedIndex = -1
        cbocurso.Enabled = False
        cbomateria.Enabled = False
        cbodiasemana.Enabled = False
        cbomodulo.Enabled = False
        Grpb_turno.Enabled = False
        Rbt_mna.Checked = True
    End Sub

    'BOTON GUARDAR
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_guardar_hs_personal.Click

        Dim horario = New Horario_personal
        horario.id_personal = vble_id_pers

        If cbodiasemana.Text = "" Then
            MsgBox("Debe elegir dia de semana", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Dia inexistente")
            Exit Sub
        Else
            horario.dia_semana = cbodiasemana.Text
        End If

        Try
            Dim consulta = (From r In datacontextvistas.vista_modulocurso Select r.id_modulo_x_curso, r.nombre_curso, r.numero Where numero = cbomodulo.Text And nombre_curso = cbocurso.Text).ToList()(0)

            'Envia como parametro el id de modulo por curso para saber si ese horario tiene ya una materia asignada
            If valida_existencia_horario(CInt(consulta.id_modulo_x_curso)) = "ocupado" Then
                Exit Sub
            End If



            horario.id_modulo_x_curso = CInt(consulta.id_modulo_x_curso)
        Catch ex As Exception
            MsgBox("El curso no tiene ese modulo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modulo inexistente")
        End Try

        If cbomateria.Text = "" Then
            MsgBox("Debe elegir una materia", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Materia inexistente")
            Exit Sub
        Else
            horario.id_materia = cbomateria.SelectedValue
        End If

        DataContext.Horario_personal.InsertOnSubmit(horario)
        DataContext.SubmitChanges()

        Dim vble_modifica_hscat As Integer
        Dim actualizahscat = (From h In DataContext.Personal Where h.id_personal = CInt(vble_id_pers)).ToList()(0)
        vble_modifica_hscat = actualizahscat.hs_cat_colegio + 1
        actualizahscat.hs_cat_colegio = vble_modifica_hscat

        DataContext.SubmitChanges()
        MostrarGrilla()
        botones(False, False, False, False, True, False, True, False, True)
        LimpiarCombos()


    End Sub

    'HABILITA LOS COMBOS
    Private Sub habilitarCombos()
        cbocurso.Enabled = True
        cbomateria.Enabled = True
        cbomodulo.Enabled = True
        cbodiasemana.Enabled = True
        Grpb_turno.Enabled = True
    End Sub

    'CARGA LOS COMBOS DE CURSO Y MODULO SEGUN TURNO
    Private Sub CargarCombos(ByVal turno As String)
        Dim datos_curso = (From c In datacontextvistas.VistaProfxMateria Join d In datacontextvistas.vista_modulocurso On c.id_curso Equals d.id_curso Select c.id_curso, c.nombre_curso, c.id_personal, d.turno_textbox Where id_personal = vble_id_pers And turno_textbox = turno.ToString).Distinct

        'Dim datosc = (From c In datacontextvistas.vista_modulocurso Select c.id_curso, c.nombre_curso, c.turno_textbox Where turno_textbox = turno.ToString).Distinct
        Me.cbocurso.DataSource = datos_curso
        Me.cbocurso.DisplayMember = "nombre_curso"
        Me.cbocurso.ValueMember = "id_curso"
        Me.cbocurso.SelectedIndex = -1

        Dim DatosMod = (From o In datacontextvistas.vista_modulocurso Select o.id_modulo, o.numero, o.turno_textbox Where turno_textbox = turno.ToString).Distinct
        Me.cbomodulo.DataSource = DatosMod
        Me.cbomodulo.DisplayMember = "numero"
        Me.cbomodulo.ValueMember = "id_modulo"
        Me.cbomodulo.SelectedIndex = -1
    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancelar_hs_personal.Click
        LimpiarCombos()
        botones(False, False, False, False, True, False, True, False, True)
    End Sub

    'BOTON MODIFICAR
    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_modificar_hs_personal.Click


        Dim actualizaH = (From C In DataContext.Horario_personal Where C.id_horario = CInt(vble_id_horario) Select C).Single
        Dim consulta = (From r In datacontextvistas.vista_modulocurso Select r.id_modulo_x_curso, r.nombre_curso, r.numero Where numero = cbomodulo.Text And nombre_curso = cbocurso.Text).ToList()(0)

        If valida_existencia_horario(CInt(consulta.id_modulo_x_curso)) = "ocupado" Then
            Exit Sub
        End If

        actualizaH.id_materia = cbomateria.SelectedValue
        actualizaH.dia_semana = cbodiasemana.Text
        actualizaH.id_modulo_x_curso = CInt(consulta.id_modulo_x_curso)
        DataContext.SubmitChanges()

        LimpiarCombos()
        MostrarGrilla()
        botones(False, False, False, False, True, False, True, False, True)
    End Sub

    'BOTON ELIMINAR
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_eliminar_hs_personal.Click
        Try
            Dim eliminar = (From C In DataContext.Horario_personal Where C.id_horario = CInt(vble_id_horario)).ToList()(0)
            DataContext.Horario_personal.DeleteOnSubmit(eliminar)
            DataContext.SubmitChanges()
            LimpiarCombos()
            MostrarGrilla()
            botones(False, False, False, False, True, False, True, False, True)
        Catch ex As Exception
            MsgBox("No se puede borrar el registro porque, borre las insistencias asociadas y reintente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Borrar de Registro")
        End Try

    End Sub

    'BOTON AGREGAR
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_agregar_hs_personal.Click
        habilitarCombos()
        botones(True, True, False, False, False, False, False, False, False)
        cbodiasemana.Select()


    End Sub

    'VUELCA LOS DATOS DE LA FILA SELECCIONADA A LOS COMBOS
    Private Sub ActualizaDatosgrid()

        If DataGridView1.SelectedRows.Count > 0 Then
            vble_id_horario = DataGridView1.Item("id_horario", DataGridView1.SelectedRows(0).Index).Value
        End If

        If DataGridView1.Item("turno_textbox", DataGridView1.SelectedRows(0).Index).Value = "Mañana" Then
            Rbt_mna.Checked = True
        ElseIf DataGridView1.Item("turno_textbox", DataGridView1.SelectedRows(0).Index).Value = "Tarde" Then
            Rbt_tde.Checked = True
        Else
            Rbt_noche.Checked = True
        End If

        cbocurso.Text = DataGridView1.Item("nombre_curso", DataGridView1.SelectedRows(0).Index).Value
        cbomateria.Text = DataGridView1.Item("nombre_materia", DataGridView1.SelectedRows(0).Index).Value
        cbodiasemana.Text = DataGridView1.Item("dia_semana", DataGridView1.SelectedRows(0).Index).Value
        cbomodulo.Text = DataGridView1.Item("numero", DataGridView1.SelectedRows(0).Index).Value



    End Sub

    'CLICK SOBRE GRILLA
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Select Case MsgBox("Va a modificar un horario", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de horario")
            Case MsgBoxResult.Ok
                habilitarCombos()
                ActualizaDatosgrid()
                botones(False, True, True, True, False, False, False, False, False)

            Case MsgBoxResult.Cancel
                Exit Sub
        End Select

    End Sub

    'RADIO BUTTON MAÑANA
    Private Sub Rbt_mna_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_mna.CheckedChanged
        Dim vble_turno As String
        If Rbt_mna.Checked = True Then
            vble_turno = Rbt_mna.Text
            CargarCombos(vble_turno)
        End If

    End Sub

    'RADIO BUTTON TARDE
    Private Sub Rbt_tde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_tde.CheckedChanged
        Dim vble_turno As String
        If Rbt_tde.Checked = True Then
            vble_turno = Rbt_tde.Text
            CargarCombos(vble_turno)
        End If
    End Sub

    'RADIO BUTTON NOCHE
    Private Sub Rbt_noche_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_noche.CheckedChanged
        Dim vble_turno As String
        If Rbt_noche.Checked = True Then
            vble_turno = Rbt_noche.Text
            CargarCombos(vble_turno)
        End If
    End Sub

    'FUNCION QUE VALIDA SI EL ID DE MODULO POR CURSO YA ESTA OCUPADO
    Private Function valida_existencia_horario(ByVal idmxc As Integer)

        Dim busca = (From b In DataContext.Horario_personal Select b.id_modulo_x_curso Where id_modulo_x_curso = idmxc).Any
        If busca = True Then
            MsgBox("El mòdulo ya esta ocupado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Mòdulo utilizado")
            Return "ocupado"
        Else
            Return "libre"
        End If
    End Function

    'BOTON LIMPIAR 
    Private Sub Btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_limpiar_hs_personal.Click
        LimpiarControles()
        botones(False, False, False, False, False, True, False, True, False)
        txt_DNI.Select()
    End Sub

    'VALIDA SOLO NUMEROS EN DNI
    Private Sub txt_DNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
