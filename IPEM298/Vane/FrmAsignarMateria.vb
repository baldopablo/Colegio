Public Class FrmAsignarMateria
    Dim DataContext As New DataClassesipem2DataContext
    Dim Datacontextvistas As New DataClassesdevistasDataContext


    'LOAD DEL FORM
    Private Sub FrmAsignarMateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Frm_principal.quienllamofrmasignarmateria.Name = FrmPersonal.Name Then
            txtNombre.Text = FrmPersonal.txtNombrePer.Text
            txtApellido.Text = FrmPersonal.txtApellidoPer.Text
            txtDNI.Text = FrmPersonal.txtDNIPer.Text
            txtIdPers.Text = FrmPersonal.txtidPers.Text
            Btn_limpiar_asig_mat.Enabled = False

        ElseIf Frm_principal.quienllamofrmasignarmateria.Name = Frm_principal.Name Then
            cmdAsignar.Enabled = False
            cmdCancelar2.Enabled = False
            cboCurso.Enabled = False
            cbomateria.Enabled = False
            txtApellido.ReadOnly = False
            txtApellido.Select()
            cmd_buscar_asig_mat.Visible = True
            AcceptButton = cmd_buscar_asig_mat
            'MostrarGrilla()
        End If
        Dim Datos = From C In DataContext.Curso Select C.id_curso, C.nombre_curso

        Me.cboCurso.DataSource = Datos
        Me.cboCurso.DisplayMember = "nombre_curso"
        Me.cboCurso.ValueMember = "id_curso"
        Me.cboCurso.SelectedIndex = -1

        Dim DatosM = From D In DataContext.Materia Select D.id_materia, D.nombre_materia

        Me.cbomateria.DataSource = DatosM
        Me.cbomateria.DisplayMember = "nombre_materia"
        Me.cbomateria.ValueMember = "id_materia"
        Me.cbomateria.SelectedIndex = -1


        ' CargarGrilla()
    End Sub

    'BOTON VOLVER
    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()

        'FrmPersonal.txtNombrePer.Text = ""
        'FrmPersonal.txtApellidoPer.Text = ""
        'FrmPersonal.txtDNIPer.Text = ""

        'FrmPersonal.cmdActualizar.Enabled = False
        'FrmPersonal.cmdEliminar.Enabled = False
        ' FrmPersonal.cmdModificar.Enabled = False
        FrmPersonal.cmdBuscar.Enabled = True
        FrmPersonal.cmdVer.Enabled = False
        FrmPersonal.cmdAsignar.Enabled = False

        'FrmPersonal.dgrPersonal.AutoGenerateColumns = False
        'FrmPersonal.dgrPersonal.Columns.Clear()

        'FrmPersonal.dgrPersonal.Columns.Add("", "Nombre Personal")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Apellido Personal")
        'FrmPersonal.dgrPersonal.Columns.Add("", "DNI")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Domicilio")
        'FrmPersonal.dgrPersonal.Columns.Add("", "E-mail")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Teléfono")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Título")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Fecha Psicofísico")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Fecha Ingreso")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Fecha Escalafón")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Legajo Provincial")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Puesto Personal")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Horas Cátedras Colegio")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Horas Cátedras Totales")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Horas Reloj Colegio")
        'FrmPersonal.dgrPersonal.Columns.Add("", "Horas Reloj Totales")

        'FrmPersonal.dgrPersonal.Columns(0).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(1).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(2).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(3).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(4).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(5).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(6).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(7).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(8).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(9).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(10).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(11).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(12).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(13).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(14).DataPropertyName = ""
        'FrmPersonal.dgrPersonal.Columns(15).DataPropertyName = ""

        'FrmPersonal.cmdVer.Enabled = False
        'FrmPersonal.cmdAsignar.Enabled = False
        FrmPersonal.cmdBuscar.Enabled = False
    End Sub

    'BOTON ASIGNAR
    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click

        Dim BuscaPers = (From per In DataContext.Profesor_x_Materia Where per.id_personal = CInt(txtIdPers.Text) And per.id_curso = CInt(cboCurso.SelectedValue) And per.id_materia = CInt(cbomateria.SelectedValue)).Any

        If cboCurso.Text = "" Or cbomateria.Text = "" Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        Else

            If BuscaPers = True Then
                MsgBox("La materia ya ha sido asignada en ese curso para ese profesor, usted puede modificarlo")
                txtidProfxmat.Text = dgrAsignar.Item(0, 0).Value
                MostrarGrilla2()
                cmdActualizar.Enabled = True
            Else
                Dim Persxmateria = New Profesor_x_Materia

                Persxmateria.id_personal = CInt(txtIdPers.Text)
                Persxmateria.id_materia = CInt(cbomateria.SelectedValue)
                Persxmateria.id_curso = CInt(cboCurso.SelectedValue)
                'Persxmateria.cant_hs_catedra = txtCantHsCat.Text
                Persxmateria.cant_hs_catedra = 0

                DataContext.Profesor_x_Materia.InsertOnSubmit(Persxmateria)
                DataContext.SubmitChanges()
                MsgBox("La materia ha sido agregada al profesor correctamente", vbInformation)

                MostrarGrilla()
                limpiarControles()

                txtidProfxmat.Text = dgrAsignar.Item(0, 0).Value
                cmdAsignar.Enabled = True
                cmdCancelar2.Enabled = True
            End If

        End If
    End Sub

    'LIMPIA CONTROLES
    Private Sub limpiarControles()
        cboCurso.SelectedIndex = -1
        cbomateria.SelectedIndex = -1
        txtCantHsCat.Text = ""
        dgrAsignar.ClearSelection()
        cmd_eliminar_asig_mat.Enabled = False
        cmdActualizar.Enabled = False
        cmdAsignar.Enabled = True
    End Sub

    'MUESTRA LA GRILLA
    Private Sub CargarGrilla()
        dgrAsignar.AutoGenerateColumns = False
        dgrAsignar.Columns.Clear()

        dgrAsignar.Columns.Add("", "ID_ProfMate")
        dgrAsignar.Columns.Add("", "Curso")
        dgrAsignar.Columns.Add("", "Materia")
        dgrAsignar.Columns.Add("", "Cant Hs Cat")

        dgrAsignar.Columns(0).DataPropertyName = ""
        dgrAsignar.Columns(1).DataPropertyName = ""
        dgrAsignar.Columns(2).DataPropertyName = ""
        dgrAsignar.Columns(3).DataPropertyName = ""
    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar2.Click
        limpiarControles()
    End Sub

    'CARGA CON DATOS LA GRILLA
    Public Sub MostrarGrilla()

        Dim consulta1 = (From V In Datacontextvistas.VistaProfxMateria Select V.id_personal, V.id_materia, V.id_curso, V.id_profesor_materia, V.nombre_materia, V.cant_hs_catedra, V.nombre_curso Where id_personal = CInt(txtIdPers.Text)) 'And id_curso = CInt(cboCurso.SelectedValue) And id_materia = CInt(cbomateria.SelectedValue))

        dgrAsignar.AutoGenerateColumns = False
        dgrAsignar.Columns.Clear()

        dgrAsignar.Columns.Add("id_profesor_materia", "ID_ProfMate")
        dgrAsignar.Columns.Add("nombre_curso", "Curso")
        dgrAsignar.Columns.Add("nombre_materia", "Materia")
        dgrAsignar.Columns.Add("cant_hs_catedra", "Cant Hs Cat")

        dgrAsignar.Columns(0).DataPropertyName = "id_profesor_materia"
        dgrAsignar.Columns(1).DataPropertyName = "nombre_curso"
        dgrAsignar.Columns(2).DataPropertyName = "nombre_materia"
        dgrAsignar.Columns(3).DataPropertyName = "cant_hs_catedra"

        dgrAsignar.DataSource = consulta1
        dgrAsignar.ClearSelection()

        cmdAsignar.Enabled = True
        cmdCancelar2.Enabled = True
        cmdActualizar.Enabled = False
        cmd_eliminar_asig_mat.Enabled = False
        cmd_buscar_asig_mat.Enabled = False

    End Sub

    'BOTON ACTUALIZAR
    Public Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        If cboCurso.Text = "" Or txtCantHsCat.Text = "" Or cbomateria.Text = "" Then
            MsgBox("Debe completar todos los campos requeridos")
        Else
            Try
                Dim ActualizaPer = (From P In DataContext.Profesor_x_Materia Where P.id_profesor_materia = CInt(txtidProfxmat.Text)).ToList()(0)

                ActualizaPer.id_curso = CInt(cboCurso.SelectedValue)
                ActualizaPer.id_materia = CInt(cbomateria.SelectedValue)
                ActualizaPer.cant_hs_catedra = CInt(txtCantHsCat.Text)

                DataContext.SubmitChanges()
                MsgBox("Los datos se han modificado correctamente")
                limpiarControles()
                MostrarGrilla()
                cmdAsignar.Enabled = True
                cmdActualizar.Enabled = False
                cmdCancelar2.Enabled = False

            Catch ex As Exception
                MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            End Try
        End If
    End Sub

    'CARGA LA GRILLA CON EL DETALLE DE UN ID_PERS_X_MAT
    Public Sub MostrarGrilla2()

        Dim consulta1 = (From V In Datacontextvistas.VistaProfxMateria Select V.id_personal, V.id_materia, V.id_curso, V.id_profesor_materia, V.nombre_materia, V.cant_hs_catedra, V.nombre_curso Where id_profesor_materia = CInt(txtidProfxmat.Text))

        dgrAsignar.AutoGenerateColumns = False
        dgrAsignar.Columns.Clear()

        dgrAsignar.Columns.Add("id_profesor_materia", "ID_ProfMate")
        dgrAsignar.Columns.Add("nombre_curso", "Curso")
        dgrAsignar.Columns.Add("nombre_materia", "Materia")
        dgrAsignar.Columns.Add("cant_hs_catedra", "Cant Hs Cat")

        dgrAsignar.Columns(0).DataPropertyName = "id_profesor_materia"
        dgrAsignar.Columns(1).DataPropertyName = "nombre_curso"
        dgrAsignar.Columns(2).DataPropertyName = "nombre_materia"
        dgrAsignar.Columns(3).DataPropertyName = "cant_hs_catedra"

        dgrAsignar.DataSource = consulta1

        'If dgrAsignar.Rows.Count > 0 Then
        '    cmdAsignar.Enabled = False
        '    cmdActualizar.Enabled = False
        '    cboCurso.Enabled = False
        '    cmd_eliminar_asig_mat.Enabled = False
        '    txtCantHsCat.Enabled = False

        'Else
        '    cboCurso.Enabled = True
        '    cmdAsignar.Enabled = True
        '    cmdActualizar.Enabled = False
        '    cmd_buscar_asig_mat.Enabled = False
        '    txtCantHsCat.Enabled = True
        'End If


    End Sub

    'VALIDACION
    Private Sub txtCantHsCat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantHsCat.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        TestString = txtCantHsCat.Text

        If Len(TestString) > 1 Then
            MsgBox("La cantidad de Hs no puede tener más de dos dígitos")
            txtCantHsCat.Text = ""
        End If
    End Sub

    'CLICK SOBRE GRILLA
    Public Sub dgrAsignar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrAsignar.CellClick
        Select Case MsgBox("Va a modificar un docente", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de personal")
            Case MsgBoxResult.Ok
                cboCurso.Text = dgrAsignar.Item("nombre_curso", dgrAsignar.SelectedRows(0).Index).Value
                cbomateria.Text = dgrAsignar.Item("nombre_materia", dgrAsignar.SelectedRows(0).Index).Value
                txtCantHsCat.Text = dgrAsignar.Item("cant_hs_catedra", dgrAsignar.SelectedRows(0).Index).Value
                txtidProfxmat.Text = dgrAsignar.Item("id_profesor_materia", dgrAsignar.SelectedRows(0).Index).Value
                cmdCancelar2.Enabled = True
                cmdActualizar.Enabled = True
                cmdAsignar.Enabled = False
                cmd_eliminar_asig_mat.Enabled = True
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select
    End Sub

    'BOTON BUSCAR
    Private Sub cmd_buscar_asig_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_buscar_asig_mat.Click
        Dim consulta1 = (From U In DataContext.Personal Where U.apelliido_pers = txtApellido.Text And U.puesto_pers <> "Preceptor" And U.puesto_pers <> "Directivo").Count
        If consulta1 > 0 Then
            Frm_principal.quienllamofrmbuscapers = Me
            FrmBuscaPers.Show()
        Else
            MsgBox("No existen registros con el apellido ingresado")
            txtApellido.Clear()
            txtApellido.Select()
            Exit Sub
        End If
        
    End Sub

    'BOTON ELIMINAR
    Private Sub cmd_eliminar_asig_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_eliminar_asig_mat.Click
        Try
            Dim eliminar = (From c In DataContext.Profesor_x_Materia Where c.id_profesor_materia = CInt(dgrAsignar.Item("id_profesor_materia", 0).Value)).ToList()(0)
            DataContext.Profesor_x_Materia.DeleteOnSubmit(eliminar)
            DataContext.SubmitChanges()
            MsgBox("El profesor se borro de la materia")
            MostrarGrilla()
            cboCurso.SelectedIndex = -1
            cbomateria.SelectedIndex = -1
            txtCantHsCat.Clear()
        Catch ex As Exception
            MsgBox("El profesor no se borro de la materia, elimine las inasistencias asociadas e intente nuevamente")
        End Try
    End Sub

    'BOTON LIMPIAR
    Private Sub Btn_limpiar_asig_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_limpiar_asig_mat.Click
        limpiarControles()
        txtApellido.Clear()
        txtDNI.Clear()
        txtIdPers.Clear()
        txtNombre.Clear()
        txtApellido.Select()
        dgrAsignar.Columns.Clear()
        AcceptButton = cmd_buscar_asig_mat
        cmd_buscar_asig_mat.Enabled = True
    End Sub

    'VALIDACION SOLO TEXTO EN APELLIDO
    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
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
End Class