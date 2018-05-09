Public Class FrmUsuario
    Dim DataContext As New DataClassesipem2DataContext
    Dim idusu As Integer

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        cmdLimpiar.Enabled = True
        Try
            Dim BuscaPersonal = (From pers In DataContext.Personal Where pers.DNI_pers = CInt(txtDNI.Text)).ToList()(0)


            txtNombre.Text = BuscaPersonal.nombre_pers
            txtApellido.Text = BuscaPersonal.apelliido_pers
            idusu = BuscaPersonal.id_personal
            'txtId_personal.Text = BuscaPersonal.id_personal
            txtPuesto.Text = BuscaPersonal.puesto_pers
            MostrarGrilla()

            If dgrHorario.RowCount = 0 Then
                MsgBox("La persona no tiene asociado ningún usuario, puede crearlo", vbInformation)

                If Len(txtNombre.Text) > 2 Then
                    txtNombre.Focus()
                    txtNombre.SelectionStart = 0
                    txtNombre.SelectionLength = 2
                    Clipboard.SetText(txtNombre.SelectedText)
                    TxtNombreUsu.Text = LCase(Clipboard.GetText() & txtApellido.Text)
                    txtNombre.SelectionStart = 0
                    cboPerfil.Focus()
                End If

                cmdAgregar.Enabled = True
            Else
                MsgBox("La persona tiene asociado un usuario, puede editar sus datos", vbInformation)
                TxtNombreUsu.Text = ""
            End If



        Catch ex As Exception
            MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            LimpiarControles()


        End Try
    End Sub

    Private Sub LimpiarControles()
        txtApellido.Text = ""
        txtDNI.Text = ""
        txtNombre.Text = ""
        txtPuesto.Text = ""
        'txtId_personal.Text = ""
        TxtNombreUsu.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Enabled = False
        txtDNI.Enabled = True
        TxtContraseña.Text = ""
        cboPerfil.SelectedIndex = -1
        cmdBuscar.Enabled = True
        CargarGrilla()
    End Sub


    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        LimpiarControles()
        inhabilitarControles()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        validarAlias()

    End Sub

    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDNI.Select()
        inhabilitarControles()
        CargarGrilla()


    End Sub

    Private Sub inhabilitarControles()

        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmdModificar.Enabled = False
        cmdEliminar.Enabled = False
        cmdLimpiar.Enabled = False
        cboPerfil.Enabled = False
        TxtNombreUsu.Enabled = False
        TxtContraseña.Enabled = False
        cmdAgregar.Enabled = False
    End Sub

    Private Sub HabilitarControles()

        TxtContraseña.Enabled = True
        cboPerfil.Enabled = True
        cmdGuardar.Enabled = True
        cmdAgregar.Enabled = True
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Dim Usuario = New Usuario1
        Usuario.id_personal = idusu
        Usuario.nombre_usuario = TxtNombreUsu.Text
        Usuario.contraseña = TxtContraseña.Text
        Usuario.perfil = cboPerfil.Text

        DataContext.Usuario1.InsertOnSubmit(Usuario)
        DataContext.SubmitChanges()
        MsgBox("El usuario se ha creado correctamente", vbInformation)

        MostrarGrilla()
        inhabilitarControles()

        cmdCancelar.Enabled = False
        cmdAgregar.Enabled = True
        'LimpiarControles()
        cmdLimpiar.Enabled = True
        cmdAgregar.Enabled = False
        cmdBuscar.Enabled = False

    End Sub

    Private Sub validarAlias()
        Try
            Dim buscaalias = (From al In DataContext.Usuario1 Where al.nombre_usuario = (TxtNombreUsu.Text)).ToList()(0)
            MsgBox("El nombre de usuario ya existe, seleccione el checkbox y modifique el nombre de usuario manualmente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Alias")
            CheckBox1.Enabled = True

        Catch ex As Exception
            MsgBox("El nombre de usuario se encuentra disponible")
            CheckBox1.Checked = False
            TxtNombreUsu.Enabled = False
            HabilitarControles()
            cboPerfil.Focus()
        End Try


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TxtNombreUsu.Enabled = True
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        LimpiarControles()
        inhabilitarControles()
        'txtDNI.Enabled = True
        'cmdBuscar.Enabled = True
    End Sub

    Private Sub CargarGrilla()
        dgrHorario.Enabled = False
        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()
        dgrHorario.Rows.Clear()
        dgrHorario.Columns.Add("", "Nombre Personal")
        dgrHorario.Columns.Add("", "Apellido Personal")
        dgrHorario.Columns.Add("", "Nombre Usuario")
        dgrHorario.Columns.Add("", "Contraseña")
        dgrHorario.Columns.Add("", "Perfil")

        dgrHorario.Columns(0).DataPropertyName = ""
        dgrHorario.Columns(1).DataPropertyName = ""
        dgrHorario.Columns(2).DataPropertyName = ""
        dgrHorario.Columns(3).DataPropertyName = ""
        dgrHorario.Columns(4).DataPropertyName = ""

    End Sub


    Private Sub MostrarGrilla()

        Dim consulta = From U In DataContext.Usuario1 Select U.id_usuario, U.id_personal, U.nombre_usuario, U.contraseña, U.perfil, U.Personal.nombre_pers, U.Personal.apelliido_pers Where id_personal = idusu

        dgrHorario.Enabled = True
        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("nombre_pers", "Nombre Personal")
        dgrHorario.Columns.Add("apelliido_pers", "Apellido Personal")
        dgrHorario.Columns.Add("nombre_usuario", "Nombre Usuario")
        dgrHorario.Columns.Add("contraseña", "Contraseña")
        dgrHorario.Columns.Add("perfil", "Perfil")
        
        dgrHorario.Columns(0).DataPropertyName = "nombre_pers"
        dgrHorario.Columns(1).DataPropertyName = "apelliido_pers"
        dgrHorario.Columns(2).DataPropertyName = "nombre_usuario"
        dgrHorario.Columns(3).DataPropertyName = "contraseña"
        dgrHorario.Columns(4).DataPropertyName = "perfil"
        

        dgrHorario.DataSource = consulta


    End Sub

    Private Sub ActualizaDatosgrid()

        If dgrHorario.SelectedRows.Count > 0 Then
            TxtContraseña.Text = dgrHorario.Item("contraseña", dgrHorario.SelectedRows(0).Index).Value
            cboPerfil.Text = dgrHorario.Item("perfil", dgrHorario.SelectedRows(0).Index).Value
        End If
    End Sub

    Private Sub dgrHorario_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrHorario.CellClick
        ActualizaDatosgrid()
        cmdEliminar.Enabled = True
        cmdModificar.Enabled = True
        cmdCancelar.Enabled = True
        TxtContraseña.Enabled = True
        cboPerfil.Enabled = True
        txtDNI.Enabled = False
        cmdBuscar.Enabled = False
        cmdLimpiar.Enabled = False
    End Sub

    Private Sub cmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Dim actualizaU = (From C In DataContext.Usuario1 Where C.id_personal = CInt(idusu) Select C).Single

        actualizaU.contraseña = TxtContraseña.Text
        actualizaU.perfil = cboPerfil.Text
        DataContext.SubmitChanges()
        MsgBox("Los datos del usuario se han modificado correctamente!")
        inhabilitarControles()
        LimpiarControles()
        'ActualizaGrilla()
    End Sub

    Private Sub ActualizaGrilla()

        Dim consulta = From V In DataContext.Usuario1 Select V.id_usuario, V.id_personal, V.nombre_usuario, V.contraseña, V.perfil Where id_personal = idusu

        dgrHorario.AutoGenerateColumns = False
        dgrHorario.Columns.Clear()

        dgrHorario.Columns.Add("nombre_pers", "Nombre Personal")
        dgrHorario.Columns.Add("apelliido_pers", "Apellido Personal")
        dgrHorario.Columns.Add("nombre_usuario", "Nombre Usuario")
        dgrHorario.Columns.Add("contraseña", "Contraseña")
        dgrHorario.Columns.Add("perfil", "Perfil")

        dgrHorario.Columns(0).DataPropertyName = "nombre_pers"
        dgrHorario.Columns(1).DataPropertyName = "apelliido_pers"
        dgrHorario.Columns(2).DataPropertyName = "nombre_usuario"
        dgrHorario.Columns(3).DataPropertyName = "contraseña"
        dgrHorario.Columns(4).DataPropertyName = "perfil"


        dgrHorario.DataSource = consulta
        dgrHorario.Refresh()

    End Sub



    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim eliminar = (From C In DataContext.Usuario1 Where C.id_personal = CInt(idusu)).ToList()(0)
        DataContext.Usuario1.DeleteOnSubmit(eliminar)
        DataContext.SubmitChanges()
        MsgBox("El usuario ha sido eliminado")
        inhabilitarControles()
        LimpiarControles()
        CargarGrilla()
        cmdEliminar.Enabled = False
    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContraseña.KeyPress
        lblmensaje.Visible = True
        Dim TestString As String
        TestString = TxtContraseña.Text

        Dim rgx As New System.Text.RegularExpressions.Regex("[A-Za-z].*[0-9]|[0-9].*[A-Za-z]")

        If Len(TestString) > 8 And (rgx.IsMatch(TestString)) Then
            lblmensaje.Visible = False
        Else
            If Len(TestString) > 5 < 9 And (rgx.IsMatch(TestString)) Then
            Else
                If Len(TestString) > 1 < 6 Then
                   
                End If
            End If
        End If

    End Sub
End Class