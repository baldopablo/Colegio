Imports System.Diagnostics
Imports System.Data
Imports System.IO.Stream
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FrmPersonal
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim idusu As Integer
    'Dim imagen As System.Drawing.Imaging.ImageFormat
    'Dim comando As System.Drawing.Imaging.ImageFormat

    'LOAD DEL FORM
    Private Sub FrmPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ActivarControlesAtualizar()
        'bloquearControlesNuevo()
        'limpiarControles()
        'CargarGrilla()
        

        cmdEliminar.Enabled = False
        '.Enabled = False
        cmdLimpiar.Enabled = False
        cmdActualizar.Enabled = False
        'cmdVer.Enabled = False
        'cmdAsignar.Enabled = False

        txtHsCatedras.Text = "0"
        txtHsCatedrasTot.Text = "0"
        txtHsRelojCol.Text = "0"
        txtHsRelojTot.Text = "0"
    End Sub

    'BOTON BUSCAR
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtApellidoPer.Text = "" Then
            MsgBox("Ingrese un apellido para buscar!")
        Else
            Try
                Frm_principal.quienllamofrmbuscapers = Me
                FrmBuscaPers.Show()
            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                limpiarControles()
            End Try
        End If
    End Sub

    'CARGAR Y MOSTRAR GRILLA
    Public Sub MostrarGrilla()

        Dim consulta = From V In DataContext.Personal Select V.id_personal, V.nombre_pers, V.apelliido_pers, V.DNI_pers, V.domicilio_pers, V.mail_pers, V.telefono_pers, V.titulo_pers, V.fecha_psicofisico_pers, V.fecha_ingreso_pers, V.fecha_escalafon_pers, V.leg_provincial_pers, V.puesto_pers, V.hs_cat_colegio, V.hs_cat_totales, V.hs_reloj_colegio, V.hs_reloj_totales Where id_personal = CInt(txtidPers.Text)

        dgrPersonal.AutoGenerateColumns = False
        dgrPersonal.Columns.Clear()
        dgrPersonal.Columns.Add("nombre_pers", "Nombre Personal")
        dgrPersonal.Columns.Add("apelliido_pers", "Apellido Personal")
        dgrPersonal.Columns.Add("DNI_pers", "DNI")
        dgrPersonal.Columns.Add("domicilio_pers", "Domicilio")
        dgrPersonal.Columns.Add("mail_pers", "E-mail")
        dgrPersonal.Columns.Add("telefono_pers", "Teléfono")
        dgrPersonal.Columns.Add("titulo_pers", "Título")
        dgrPersonal.Columns.Add("fecha_psicofisico_pers", "Fecha Psicofísico")
        dgrPersonal.Columns.Add("fecha_ingreso_pers", "Fecha Ingreso")
        dgrPersonal.Columns.Add("fecha_escalafon_pers", "Fecha Escalafón")
        dgrPersonal.Columns.Add("leg_provincial_pers", "Legajo Provincial")
        dgrPersonal.Columns.Add("puesto_pers", "Puesto Personal")
        dgrPersonal.Columns.Add("hs_cat_colegio", "Horas Cátedras Colegio")
        dgrPersonal.Columns.Add("hs_cat_totales", "Horas Cátedras Totales")
        dgrPersonal.Columns.Add("hs_reloj_colegio", "Horas Reloj Colegio")
        dgrPersonal.Columns.Add("hs_reloj_totales", "Horas Reloj Totales")
        'dgrPersonal.Columns.Add("foto_personal", "Foto Personal")

        dgrPersonal.Columns(0).DataPropertyName = "nombre_pers"
        dgrPersonal.Columns(1).DataPropertyName = "apelliido_pers"
        dgrPersonal.Columns(2).DataPropertyName = "DNI_pers"
        dgrPersonal.Columns(3).DataPropertyName = "domicilio_pers"
        dgrPersonal.Columns(4).DataPropertyName = "mail_pers"
        dgrPersonal.Columns(5).DataPropertyName = "telefono_pers"
        dgrPersonal.Columns(6).DataPropertyName = "titulo_pers"
        dgrPersonal.Columns(7).DataPropertyName = "fecha_psicofisico_pers"
        dgrPersonal.Columns(8).DataPropertyName = "fecha_ingreso_pers"
        dgrPersonal.Columns(9).DataPropertyName = "fecha_escalafon_pers"
        dgrPersonal.Columns(10).DataPropertyName = "leg_provincial_pers"
        dgrPersonal.Columns(11).DataPropertyName = "puesto_pers"
        dgrPersonal.Columns(12).DataPropertyName = "hs_cat_colegio"
        dgrPersonal.Columns(13).DataPropertyName = "hs_cat_totales"
        dgrPersonal.Columns(14).DataPropertyName = "hs_reloj_colegio"
        dgrPersonal.Columns(15).DataPropertyName = "hs_reloj_totales"

        dgrPersonal.DataSource = consulta
    End Sub

    'Public Sub cargarImagen()

    '    Dim imagen As Byte()
    '    '= DirectCast(comando.ExecuteScalar(), Byte())
    '    If Not imagen Is Nothing Then
    '        Using ms As New MemoryStream(imagen, 0, imagen.Length)
    '            ms.Write(imagen, 0, imagen.Length)
    '            PictureBox1.BackgroundImage = Image.FromStream(ms, True)
    '        End Using
    '    End If

    'End Sub

    'BOTON SALIR
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub cmd_examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_examinar.Click
        '    Dim Dialog As New OpenFileDialog
        '    Dim result As New DialogResult
        '    Dialog.InitialDirectory = "Biblioteca\Imágenes"
        '    Dialog.Filter = "Archivos de imagen (*.jpg)|*.png|All files (*.*)|*.*"
        '    Dialog.FilterIndex = 18
        '    Dialog.RestoreDirectory = True
        '    result = Dialog.ShowDialog()
        '    If (result = DialogResult.OK) Then
        '        PictureBox1.Image = Image.FromFile(Dialog.FileName)

        '    End If


    End Sub

    'BOTON GUARDAR
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDNI.Text = "" Or txtDomicilio.Text = "" Or dtFecha_esc.Text = "" Or dtfecha_ingreso.Text = "" Or dtFecha_psico.Text = "" Or cboPuesto.Text = "" Or txtLegajo.Text = "" Or txtTitulo.Text = "" Then
            MsgBox("Debe completar los campos requeridos")
        Else
            'Dim ms As New System.IO.MemoryStream()
            'PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim Pers = New Personal

            Pers.nombre_pers = txtNombre.Text
            Pers.apelliido_pers = txtApellido.Text
            Pers.domicilio_pers = txtDomicilio.Text
            Pers.mail_pers = txtemail.Text
            Pers.telefono_pers = txtTelefono.Text
            Pers.DNI_pers = CInt(txtDNI.Text)
            Pers.titulo_pers = txtTitulo.Text
            Pers.fecha_psicofisico_pers = dtFecha_psico.Text
            Pers.fecha_ingreso_pers = dtfecha_ingreso.Text
            Pers.fecha_escalafon_pers = dtFecha_esc.Text
            Pers.leg_provincial_pers = CInt(txtLegajo.Text)
            Pers.puesto_pers = cboPuesto.Text
            Pers.hs_cat_colegio = CInt(txtHsCatedras.Text)
            Pers.hs_cat_totales = CInt(txtHsCatedrasTot.Text)
            Pers.hs_reloj_colegio = CInt(txtHsRelojCol.Text)
            Pers.hs_reloj_totales = CInt(txtHsRelojTot.Text)

            'Pers.foto_personal = ms.GetBuffer
            DataContext.Personal.InsertOnSubmit(Pers)
            DataContext.SubmitChanges()
            MsgBox("El Personal se ha creado correctamente", vbInformation)

            limpiarControles()
            cmdLimpiar.Enabled = False
        End If
    End Sub


    'BOTON LIMPIAR
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        limpiarControles()
        dgrPersonal.Columns.Clear()
        cmdBuscar.Enabled = True
    End Sub

    'LIMPIAR
    Private Sub limpiarControles()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtidPers.Text = ""
        txtDNI.Text = ""
        txtDomicilio.Text = ""
        txtemail.Text = ""
        txtHsCatedras.Text = "0"
        txtHsCatedrasTot.Text = "0"
        txtHsRelojCol.Text = "0"
        txtHsRelojTot.Text = "0"
        txtLegajo.Text = ""
        txtTelefono.Text = ""
        txtTitulo.Text = ""
        dtFecha_esc.Text = ""
        dtfecha_ingreso.Text = ""
        dtFecha_psico.Text = ""
        cboPuesto.SelectedIndex = -1
        txtApellidoPer.Text = ""
        txtNombrePer.Text = ""
        txtDNIPer.Text = ""
        txtidPers.Text = ""
        PictureBox1.Image = Nothing
        dgrPersonal.Columns.Clear()
    End Sub

    Private Sub bloquearControlesActualizar()

        txtidPers.Enabled = False
        dgrPersonal.Enabled = False
        cmdEliminar.Enabled = False
        cmdLimpiar.Enabled = False
        cmdBuscar.Enabled = False
        cmdActualizar.Enabled = False
    End Sub
    Private Sub bloquearControlesNuevo()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDNI.Enabled = False
        txtDomicilio.Enabled = False
        txtemail.Enabled = False
        txtHsCatedras.Enabled = False
        txtHsCatedrasTot.Enabled = False
        txtHsRelojCol.Enabled = False
        txtHsRelojTot.Enabled = False
        txtLegajo.Enabled = False
        txtTelefono.Enabled = False
        txtTitulo.Enabled = False
        dtFecha_esc.Enabled = False
        dtfecha_ingreso.Enabled = False
        dtFecha_psico.Enabled = False
        cboPuesto.Enabled = False
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
        cmd_examinar.Enabled = False

    End Sub

    Private Sub ActivarControlesAtualizar()
        txtidPers.Enabled = True
        cmdBuscar.Enabled = True
    End Sub
    Private Sub ActivarControlesNuevo()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtidPers.Enabled = True
        txtDNI.Enabled = True
        txtDomicilio.Enabled = True
        txtemail.Enabled = True
        txtLegajo.Enabled = True
        txtTelefono.Enabled = True
        txtTitulo.Enabled = True
        dtFecha_esc.Enabled = True
        dtfecha_ingreso.Enabled = True
        dtFecha_psico.Enabled = True
        cboPuesto.Enabled = True
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        cmd_examinar.Enabled = True
    End Sub

    'CLICK SOBRE GRILLA
    Private Sub dgrPersonal_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrPersonal.CellClick
        Select Case MsgBox("Va a modificar un docente", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de personal")
            Case MsgBoxResult.Ok
                Select Case dgrPersonal.Item("puesto_pers", 0).Value
                    Case "Docente"
                        cmdAsignar.Enabled = True
                        cmd_asig_preceptor.Enabled = False
                    Case "Preceptor"
                        cmdAsignar.Enabled = False
                        cmd_asig_preceptor.Enabled = True
                    Case "Docente y preceptor"
                        cmdAsignar.Enabled = True
                        cmd_asig_preceptor.Enabled = True
                    Case "Docente y directivo"
                        cmdAsignar.Enabled = True
                        cmd_asig_preceptor.Enabled = False
                End Select

                ActualizaDatosgrid()
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select
        TabControl1.SelectedIndex = 0
        cmdEliminar.Enabled = True
        cmdGuardar.Enabled = False
        cmdActualizar.Enabled = True
        cmdLimpiar.Enabled = True
    End Sub

    'SUB ACTUALIZAR
    Private Sub ActualizaDatosgrid()


        txtNombre.Text = dgrPersonal.Item("nombre_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtApellido.Text = dgrPersonal.Item("apelliido_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtDomicilio.Text = dgrPersonal.Item("domicilio_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtemail.Text = dgrPersonal.Item("mail_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtTelefono.Text = dgrPersonal.Item("telefono_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtDNI.Text = dgrPersonal.Item("DNI_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtTitulo.Text = dgrPersonal.Item("titulo_pers", dgrPersonal.SelectedRows(0).Index).Value
        dtFecha_psico.Text = dgrPersonal.Item("fecha_psicofisico_pers", dgrPersonal.SelectedRows(0).Index).Value
        dtfecha_ingreso.Text = dgrPersonal.Item("fecha_ingreso_pers", dgrPersonal.SelectedRows(0).Index).Value
        dtFecha_esc.Text = dgrPersonal.Item("fecha_escalafon_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtLegajo.Text = dgrPersonal.Item("leg_provincial_pers", dgrPersonal.SelectedRows(0).Index).Value
        cboPuesto.Text = dgrPersonal.Item("puesto_pers", dgrPersonal.SelectedRows(0).Index).Value
        txtHsCatedras.Text = dgrPersonal.Item("hs_cat_colegio", dgrPersonal.SelectedRows(0).Index).Value
        txtHsCatedrasTot.Text = dgrPersonal.Item("hs_cat_totales", dgrPersonal.SelectedRows(0).Index).Value
        txtHsRelojCol.Text = dgrPersonal.Item("hs_reloj_colegio", dgrPersonal.SelectedRows(0).Index).Value
        txtHsRelojTot.Text = dgrPersonal.Item("hs_reloj_totales", dgrPersonal.SelectedRows(0).Index).Value

        'traepuesto()
    End Sub

    'BOTON AGREGAR
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'BOTON ACTUALIZAR
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDNI.Text = "" Or txtDomicilio.Text = "" Or dtFecha_esc.Text = "" Or dtfecha_ingreso.Text = "" Or dtFecha_psico.Text = "" Or cboPuesto.Text = "" Or txtLegajo.Text = "" Or txtTitulo.Text = "" Then
            MsgBox("Debe completar los campos requeridos")
            Exit Sub
        End If
        'Dim ms As New System.IO.MemoryStream()
        'PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Try
            Dim Actualizarpers = (From P In DataContext.Personal Where P.id_personal = CInt(txtidPers.Text)).ToList()(0)

            Actualizarpers.DNI_pers = txtDNI.Text
            Actualizarpers.nombre_pers = txtNombre.Text
            Actualizarpers.apelliido_pers = txtApellido.Text
            Actualizarpers.domicilio_pers = txtDomicilio.Text
            Actualizarpers.telefono_pers = txtTelefono.Text
            Actualizarpers.mail_pers = txtemail.Text
            Actualizarpers.titulo_pers = txtTitulo.Text
            Actualizarpers.fecha_ingreso_pers = dtfecha_ingreso.Text
            Actualizarpers.fecha_escalafon_pers = dtFecha_esc.Text
            Actualizarpers.fecha_psicofisico_pers = dtFecha_psico.Text
            Actualizarpers.leg_provincial_pers = txtLegajo.Text
            Actualizarpers.puesto_pers = cboPuesto.Text
            Actualizarpers.hs_cat_colegio = txtHsCatedras.Text
            Actualizarpers.hs_cat_totales = txtHsCatedrasTot.Text
            Actualizarpers.hs_reloj_colegio = txtHsRelojCol.Text
            Actualizarpers.hs_reloj_totales = txtHsRelojTot.Text
            'Actualizarpers.foto_personal = ms.GetBuffer

            DataContext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")
            limpiarControles()
            'CargarGrilla()
            'ActivarControlesAtualizar()
            'bloquearControlesNuevo()
            'dgrPersonal.Enabled = False
            'bloquearControlesNuevo()

            cmdEliminar.Enabled = False
            cmdLimpiar.Enabled = True
            cmdActualizar.Enabled = False
            TabControl1.SelectedIndex = 1
            cmdBuscar.Enabled = True
            cmdGuardar.Enabled = True
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! El usuario tiene datos asociados", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
        End Try

    End Sub


    'VALIDACIONES
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtHsCatedras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHsCatedras.KeyPress

        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True

        End If

        Dim TestString As String
        TestString = txtHsCatedras.Text

        If Len(TestString) > 1 Then
            MsgBox("La cantidad de Hs no puede tener más de dos dígitos")
            txtHsCatedras.Text = ""
        End If

    End Sub
    Private Sub txtHsCatedrasTot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHsCatedrasTot.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Dim TestString As String
        TestString = txtHsCatedrasTot.Text

        If Len(TestString) > 1 Then
            MsgBox("La cantidad de Hs no puede tener más de dos dígitos")
            txtHsCatedrasTot.Text = ""
        End If
    End Sub
    Private Sub txtHsRelojCol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHsRelojCol.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Dim TestString As String
        TestString = txtHsRelojCol.Text

        If Len(TestString) > 1 Then
            MsgBox("La cantidad de Hs no puede tener más de dos dígitos")
            txtHsRelojCol.Text = ""
        End If
    End Sub
    Private Sub txtHsRelojTot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHsRelojTot.KeyPress


        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then

            e.Handled = False

        Else

            e.Handled = True

        End If
        Dim TestString As String
        TestString = txtHsRelojTot.Text

        If Len(TestString) > 1 Then
            MsgBox("La cantidad de Hs no puede tener más de dos dígitos")
            txtHsRelojTot.Text = ""
        End If
    End Sub
    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        'If Char.IsLetter(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        '    e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True

        'End If
    End Sub
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

    'BOTON CANCELAR
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        limpiarControles()
        'CargarGrilla()
        'ActivarControlesAtualizar()
        'bloquearControlesNuevo()
        'cmdLimpiar.Enabled = False
        'dgrPersonal.Enabled = False
        cmdGuardar.Enabled = True
    End Sub

    'BOTON ELIMINAR
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        Dim eliminar = (From C In DataContext.Personal Where C.id_personal = CInt(txtidPers.Text)).ToList()(0)


        Dim comprobrar1 = (From C In DataContext.Profesor_x_Materia Where C.id_personal = CInt(txtidPers.Text)).Any
        Dim comprobrar2 = (From C In DataContext.Horario_personal Where C.id_personal = CInt(txtidPers.Text)).Any
        Dim comprobrar3 = (From C In DataContext.Curso Where C.id_personal = CInt(txtidPers.Text)).Any
        Dim comprobrar4 = (From C In DataContext.Usuario1 Where C.id_personal = CInt(txtidPers.Text)).Any
        Try
            If comprobrar1 = True Or comprobrar2 = True Or comprobrar3 = True Or comprobrar4 = True Then
                MsgBox("El registro no puede ser eliminado, posee datos asociados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Datos asociados")
                limpiarControles()

                cmdEliminar.Enabled = False
                cmdActualizar.Enabled = False
                ' cmdModificar.Enabled = False
                cmdLimpiar.Enabled = False
                cmdVer.Enabled = False
                cmdAsignar.Enabled = False
            Else
                DataContext.Personal.DeleteOnSubmit(eliminar)
                DataContext.SubmitChanges()
                MsgBox("El personal ha sido eliminado")
                limpiarControles()

                cmdGuardar.Enabled = True
                cmdEliminar.Enabled = False
                cmdActualizar.Enabled = False
                'cmdModificar.Enabled = False
                cmdLimpiar.Enabled = False
            End If


        Catch ex As Exception
            MsgBox("El registro no puede ser eliminado, intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
        End Try

        TabControl1.SelectedIndex = 1

    End Sub


    Private Sub ValidarControlesGuardar()
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDNI.Text = "" Or txtDomicilio.Text = "" Or dtFecha_esc.Text = "" Or dtfecha_ingreso.Text = "" Or dtFecha_psico.Text = "" Or cboPuesto.SelectedItem = -1 Or txtLegajo.Text = "" Or txtTitulo.Text = "" Then
            MsgBox("Debe completar los campos requeridos")
        End If
    End Sub

    'SELECCION DE COMBO DE PUESTO
    Private Sub cboPuesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPuesto.SelectedIndexChanged

        If cboPuesto.Text = "Preceptor" Or cboPuesto.Text = "Directivo" Then
            txtHsRelojCol.Enabled = True
            txtHsRelojCol.Text = "0"
            txtHsRelojTot.Enabled = True
            txtHsRelojTot.Text = "0"
            txtHsCatedras.Enabled = False
            'txtHsCatedras.Text = "0"
            txtHsCatedrasTot.Enabled = False
            If cboPuesto.Text = "Preceptor" Then
                cmd_asig_preceptor.Enabled = True
                cmdAsignar.Enabled = False
            End If
            'txtHsCatedrasTot.Text = "0"
        ElseIf cboPuesto.Text = "Docente" Then
            txtHsCatedras.Enabled = True
            'txtHsCatedras.Text = "0"
            txtHsCatedrasTot.Enabled = True
            'txtHsCatedrasTot.Text = "0"
            txtHsRelojCol.Enabled = False
            txtHsRelojCol.Text = "0"
            txtHsRelojTot.Enabled = False
            txtHsRelojTot.Text = "0"
            cmdAsignar.Enabled = True
            cmd_asig_preceptor.Enabled = False
        ElseIf cboPuesto.Text = "Docente y preceptor" Or cboPuesto.Text = "Docente y directivo" Then
            txtHsCatedras.Enabled = True
            'txtHsCatedras.Text = "0"
            txtHsCatedrasTot.Enabled = True
            'txtHsCatedrasTot.Text = "0"
            txtHsRelojCol.Enabled = True
            txtHsRelojCol.Text = "0"
            txtHsRelojTot.Enabled = True
            txtHsRelojCol.Text = "0"
            If cboPuesto.Text = "Docente y preceptor" Then
                cmd_asig_preceptor.Enabled = True
                cmdAsignar.Enabled = True
            ElseIf cboPuesto.Text = "Docente y directivo" Then
                cmdAsignar.Enabled = True
                cmd_asig_preceptor.Enabled = False
            End If
        End If
    End Sub

    'VALIDACION
    Private Sub txtLegajo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLegajo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'BOTON VER
    Private Sub cmdVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVer.Click
        cmdLimpiar.Enabled = True

        Try
            Dim BuscaPersonal = (From pers In DataContext.Personal Where pers.id_personal = CInt(txtidPers.Text)).ToList()(0)
            idusu = BuscaPersonal.id_personal
            MostrarGrilla()
            dgrPersonal.Enabled = True
        Catch ex As Exception
            MsgBox("Error en el sistema, consulte al administrador!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            limpiarControles()
        End Try

    End Sub

    'BOTON ASIGNAR
    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click
        Frm_principal.quienllamofrmasignarmateria = Me
        FrmAsignarMateria.Show()
    End Sub

    'CAMBIA NOMBRE
    Private Sub txtNombre_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.Validated
        If txtNombre.Text <> "" Then
            txtNombre.Text = StrConv(txtNombre.Text, VbStrConv.ProperCase)
        End If
    End Sub

    'CAMBIA APELLIDO
    Private Sub txtApellido_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApellido.Validated
        If txtApellido.Text <> "" Then
            txtApellido.Text = StrConv(txtApellido.Text, VbStrConv.ProperCase)
        End If
    End Sub

    'VALIDA DNI
    Private Sub txtDNI_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.Validated
        If txtDNI.Text <> "" Then
            If txtDNI.TextLength <> 8 Then
                MsgBox("El dni del personal debe tener 8 dígitos")
                txtDNI.Select()
                Exit Sub
            End If
            If txtDNI.Text.Chars(0) = "0" Then
                MsgBox("El dni del personal no puede empezar con cero")
                txtDNI.Select()
                Exit Sub
            End If

        End If
    End Sub

    'VALIDA MAIL
    Private Sub txtemail_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.Validated
        If txtemail.Text <> "" Then
            Try
                Dim mail As New System.Net.Mail.MailAddress(txtemail.Text)

            Catch ex As Exception
                MessageBox.Show("El mail ingresado no es válido")
                txtemail.Select()
                Exit Sub
            End Try
        End If
    End Sub

    'BOTON ASIGNAR PRECEPTOR
    Private Sub cmd_asig_preceptor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_asig_preceptor.Click
        Frm_Asignar_Preceptor.Show()
    End Sub

    'TRAE EL PUESTO DESPUES DE CONSULTAR
    Private Sub traepuesto()
        If cboPuesto.Text = "Preceptor" Or cboPuesto.Text = "Directivo" Then
            txtHsRelojCol.Enabled = True
            txtHsRelojTot.Enabled = True
            txtHsCatedras.Enabled = False
            txtHsCatedrasTot.Enabled = False
            cmdAsignar.Enabled = False
            If cboPuesto.Text = "Preceptor" Then
                cmd_asig_preceptor.Enabled = True
            End If
        ElseIf cboPuesto.Text = "Docente" Then
            txtHsCatedras.Enabled = True
            txtHsCatedrasTot.Enabled = True
            txtHsRelojCol.Enabled = False
            txtHsRelojTot.Enabled = False
            cmd_asig_preceptor.Enabled = False
            cmdAsignar.Enabled = True
        ElseIf cboPuesto.Text = "Docente y preceptor" Or cboPuesto.Text = "Docente y directivo" Then
            txtHsCatedras.Enabled = True
            txtHsCatedrasTot.Enabled = True
            txtHsRelojCol.Enabled = True
            txtHsRelojTot.Enabled = True
            If cboPuesto.Text = "Docente y preceptor" Then
                cmd_asig_preceptor.Enabled = True
                cmdAsignar.Enabled = True
            ElseIf cboPuesto.Text = "Docente y directivo" Then
                cmdAsignar.Enabled = True
                cmd_asig_preceptor.Enabled = False
            End If
        End If
    End Sub

End Class