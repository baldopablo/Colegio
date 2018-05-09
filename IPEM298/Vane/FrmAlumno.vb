Imports System.Diagnostics
Imports System.Data
Imports System.IO.Stream
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Text.RegularExpressions
Public Class FrmAlumno
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Dim idusu As Integer
    'Dim imagen As System.Drawing.Imaging.ImageFormat
    'Dim comando As System.Drawing.Imaging.ImageFormat

    'LOAD DEL FORM
    Private Sub FrmAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombre.Select()
        ActivarControlesAtualizar()
        limpiarControles()
        cmdEliminar.Enabled = False
        cmdActualizar.Enabled = False
        cmdAsignar.Enabled = False
        If TabControl1.SelectedIndex = 1 Then
            txtApellidoAlu.Select()
            AcceptButton = cmdBuscar
        End If
    End Sub

    'CARGA LA GRILLA CON LOS DATOS DEL ALUMNO
    Public Sub MostrarGrilla()

        Dim consulta = From V In DataContext.Alumno Select V.id_alumno, V.nombre_alu, V.apellido_alu, V.domicilio, V.DNI_alu, V.fecha_nac_alu, V.mail_alu, V.nomb_ape_tutor, V.dni_tutor, V.telefono_tutor Where DNI_alu = CInt(txtDNI_alu.Text)

        drgAlumno.AutoGenerateColumns = False
        drgAlumno.Columns.Clear()
        drgAlumno.Columns.Add("nombre_alu", "Nombre Alumno")
        drgAlumno.Columns.Add("apellido_alu", "Apellido Alumno")
        drgAlumno.Columns.Add("domicilio", "Domicilio")
        drgAlumno.Columns.Add("DNI_alu", "DNI")
        drgAlumno.Columns.Add("fecha_nac_alu", "Fecha de nacimiento")
        drgAlumno.Columns.Add("mail_alu", "e-mail Alumno")
        drgAlumno.Columns.Add("nomb_ape_tutor", "Nombre y apellido tutor")
        drgAlumno.Columns.Add("dni_tutor", "DNI tutor")
        drgAlumno.Columns.Add("telefono_tutor", "Telefono Tutor")
        'dgrPersonal.Columns.Add("foto_personal", "Foto Personal")

        drgAlumno.Columns(0).DataPropertyName = "nombre_alu"
        drgAlumno.Columns(1).DataPropertyName = "apellido_alu"
        drgAlumno.Columns(2).DataPropertyName = "domicilio"
        drgAlumno.Columns(3).DataPropertyName = "DNI_alu"
        drgAlumno.Columns(4).DataPropertyName = "fecha_nac_alu"
        drgAlumno.Columns(5).DataPropertyName = "mail_alu"
        drgAlumno.Columns(6).DataPropertyName = "nomb_ape_tutor"
        drgAlumno.Columns(7).DataPropertyName = "dni_tutor"
        drgAlumno.Columns(8).DataPropertyName = "telefono_tutor"

        drgAlumno.DataSource = consulta
        drgAlumno.ClearSelection()
    End Sub

    'COMENTADO IMAGEN
    Public Sub cargarImagen()

        '    Dim imagen As Byte()
        '    '= DirectCast(comando.ExecuteScalar(), Byte())
        '    If Not imagen Is Nothing Then
        '        Using ms As New MemoryStream(imagen, 0, imagen.Length)
        '            ms.Write(imagen, 0, imagen.Length)
        '            PictureBox1.BackgroundImage = Image.FromStream(ms, True)
        '        End Using
        '    End If

    End Sub

    'BOTON SALIR
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    'COMENTADO EXAMINAR IMAGEN
    Private Sub cmd_examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Dim Dialog As New OpenFileDialog
        '    Dim result As New DialogResult
        '    Dialog.InitialDirectory = "Biblioteca\Imágenes"
        '    Dialog.Filter = "Archivos de imagen (*.jpg)|*.png|All files (*.*)|*.*"
        '    Dialog.FilterIndex = 18
        '    Dialog.RestoreDirectory = True
        '    result = Dialog.ShowDialog()
        '    If (result = DialogResult.OK) Then
        '        PictureBox1.Image = Image.FromFile(Dialog.FileName)

        ''    End If


    End Sub

    'BOTON LIMPIAR
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        limpiarControles()
        ActivarControlesAtualizar()
        cmdLimpiar.Enabled = False
        cmdAsignar.Enabled = False
        drgAlumno.Columns.Clear()
        cmdGuardar.Enabled = True
    End Sub

    'LIMPIA LOS CAMPOS
    Private Sub limpiarControles()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtDomicilio.Text = ""
        dtpfechanac.Text = ""
        txtemail.Text = ""
        txtDNI_alu.Text = ""
        txtDNI.Text = ""
        txtNomApeTutor.Text = ""
        txtDniTutor.Text = ""
        txtTelefonoTutor.Text = ""
        txtNombreAlu.Text = ""
        txtApellidoAlu.Text = ""
        txtDNI_alu.Text = ""
        txtidAlu.Text = ""
        'CargarGrilla()

        'PictureBox1.Image = Nothing


    End Sub

    'DESHABILITA CONTROLES CUANDO ACTUALIZA
    Private Sub bloquearControlesActualizar()

        txtDNI_alu.Enabled = False
        drgAlumno.Enabled = False
        cmdEliminar.Enabled = False
        'cmdModificar.Enabled = False
        cmdLimpiar.Enabled = False
        cmdBuscar.Enabled = False
        cmdActualizar.Enabled = False
        drgAlumno.Enabled = False
    End Sub

    'DESHABILITA CONSTROLES CUANDO CARGA NUEVO
    Private Sub bloquearControlesNuevo()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDomicilio.Enabled = False
        dtpfechanac.Enabled = False
        txtemail.Enabled = False
        txtDNI_alu.Enabled = False
        txtDNI.Enabled = False
        txtNomApeTutor.Enabled = False
        txtDniTutor.Enabled = False
        txtTelefonoTutor.Enabled = False
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False


        'cmd_examinar.Enabled = False
    End Sub

    'HABILITA CONTTROLES CUANDO ACTUALIZA
    Private Sub ActivarControlesAtualizar()
        txtDNI_alu.Enabled = True
        cmdBuscar.Enabled = True
        drgAlumno.Enabled = True
    End Sub

    'HABILITA CONTROLES CUANDO CARGA NUEVO
    Private Sub ActivarControlesNuevo()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDomicilio.Enabled = True
        dtpfechanac.Enabled = True
        txtemail.Enabled = True
        txtDNI_alu.Enabled = True
        txtDNI.Enabled = True
        txtNomApeTutor.Enabled = True
        txtDniTutor.Enabled = True
        txtTelefonoTutor.Enabled = True
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        'cmd_examinar.Enabled = True
    End Sub

    'PASA LOS DATOS DE LA GRILLA A LOS TEXTBOX
    Private Sub ActualizaDatosgrid()
        txtNombre.Text = drgAlumno.Item("nombre_alu", drgAlumno.SelectedRows(0).Index).Value
        txtApellido.Text = drgAlumno.Item("apellido_alu", drgAlumno.SelectedRows(0).Index).Value
        txtDomicilio.Text = drgAlumno.Item("domicilio", drgAlumno.SelectedRows(0).Index).Value
        txtDNI.Text = drgAlumno.Item("DNI_alu", drgAlumno.SelectedRows(0).Index).Value
        dtpfechanac.Text = drgAlumno.Item("fecha_nac_alu", drgAlumno.SelectedRows(0).Index).Value()
        txtemail.Text = drgAlumno.Item("mail_alu", drgAlumno.SelectedRows(0).Index).Value
        txtNomApeTutor.Text = drgAlumno.Item("nomb_ape_tutor", drgAlumno.SelectedRows(0).Index).Value
        txtDniTutor.Text = drgAlumno.Item("dni_tutor", drgAlumno.SelectedRows(0).Index).Value
        txtTelefonoTutor.Text = drgAlumno.Item("telefono_tutor", drgAlumno.SelectedRows(0).Index).Value

        TabControl1.SelectedIndex = 0
        ActivarControlesNuevo()
        cmdActualizar.Enabled = True
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = True
        cmdEliminar.Enabled = True
    End Sub

    'VALIDACIONES
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI_alu.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtDniTutor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDniTutor.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtTelefonoTutor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonoTutor.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
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
    Private Sub txtDomicilio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDomicilio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
    Private Sub txtNomApeTutor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNomApeTutor.KeyPress
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
        TabPage_consulta.Show()
        drgAlumno.ClearSelection()
        cmdGuardar.Enabled = True
       
    End Sub

    'BOTON GUARDAR
    Private Sub cmdGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            'Dim BuscaAlu = (From alu In DataContext.Alumno Where alu.DNI_alu = (txtDNI.Text)).ToList()(0)
            'MsgBox("El DNI ingresado ya pertence a un alumno")

            Dim buscaalu = (From al In DataContext.Alumno Select al.DNI_alu Where DNI_alu = txtDNI.Text).Any
            If buscaalu = True Then
                MsgBox("El DNI ingresado ya pertence a un alumno")
                Exit Sub
            End If

            If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDomicilio.Text = "" Or txtDNI.Text = "" Or dtpfechanac.Text = "" Or dtpfechainsc.Text = "" Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            Else
                Dim I As Integer
                Dim Alu = New Alumno

                Alu.nombre_alu = txtNombre.Text
                Alu.apellido_alu = txtApellido.Text
                Alu.domicilio = txtDomicilio.Text
                Alu.DNI_alu = CInt(txtDNI.Text)
                Alu.fecha_nac_alu = dtpfechanac.Text
                Alu.fecha_inscripcion_alu = dtpfechainsc.Text
                Alu.mail_alu = txtemail.Text
                Alu.nomb_ape_tutor = txtNomApeTutor.Text
                Alu.dni_tutor = CInt(txtDniTutor.Text)
                Alu.telefono_tutor = txtTelefonoTutor.Text
                I = Alu.id_alumno

                'Pers.foto_personal = ms.GetBuffer
                DataContext.Alumno.InsertOnSubmit(Alu)
                DataContext.SubmitChanges()
                MsgBox("El Alumno se ha creado correctamente", vbInformation)

                limpiarControles()
                ActivarControlesAtualizar()
                cmdLimpiar.Enabled = False
            End If
        Catch ex As Exception
            If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDomicilio.Text = "" Or txtDNI.Text = "" Or dtpfechanac.Text = "" Or dtpfechainsc.Text = "" Then
                MsgBox("Debe completar todos los campos requeridos")
                Exit Sub
            End If
        End Try
    End Sub

    'BOTON BUSCAR
    Private Sub cmdBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtApellidoAlu.Text = "" Then
            MsgBox("Ingrese un apellido para buscar!")
        Else
            Try
                Frm_principal.quienllamofrmbuscaalu3 = Me
                FrmBuscAlu3.Show()
                cmdLimpiar.Enabled = True
                Exit Sub
            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                limpiarControles()
            End Try
        End If

    End Sub

    'BOTON SALIR
    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    'BOTON ASIGNAR
    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click
        Frm_principal.quienllamofrmasignarcurso = Me
        FrmAsignarCurso.Show()
        'Me.Enabled = False
    End Sub

    'CLICK SOBRE GRILLA DE ALUMNO
    Private Sub drgAlumno_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles drgAlumno.CellClick
        Select Case MsgBox("Va a modificar un alumno", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de alumno")
            Case MsgBoxResult.Ok
                cmdAsignar.Enabled = True
                ActualizaDatosgrid()
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select
    End Sub

    'BOTON ACTUALIZAR
    Private Sub cmdActualizar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        'Dim ms As New System.IO.MemoryStream()
        'PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        If txtNombre.Text = "" Or txtApellido.Text = "" Or txtDomicilio.Text = "" Or txtDNI.Text = "" Or dtpfechanac.Text = "" Or dtpfechainsc.Text = "" Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        End If
        Try
            Dim Actualizarpers = (From P In DataContext.Alumno Where P.DNI_alu = (txtDNI_alu.Text)).ToList()(0)

            Actualizarpers.nombre_alu = txtNombre.Text
            Actualizarpers.apellido_alu = txtApellido.Text
            Actualizarpers.domicilio = txtDomicilio.Text
            Actualizarpers.DNI_alu = txtDNI.Text
            Actualizarpers.fecha_nac_alu = dtpfechanac.Text
            Actualizarpers.fecha_inscripcion_alu = dtpfechainsc.Text
            Actualizarpers.mail_alu = txtemail.Text
            Actualizarpers.nomb_ape_tutor = txtNomApeTutor.Text
            Actualizarpers.dni_tutor = txtDniTutor.Text
            Actualizarpers.telefono_tutor = txtTelefonoTutor.Text

            DataContext.SubmitChanges()
            MsgBox("Los datos se han modificado correctamente")

            'MostrarGrilla()
            limpiarControles()
            drgAlumno.Columns.Clear()
            TabControl1.SelectedIndex = 1
            txtApellidoAlu.Select()
            'ActivarControlesAtualizar()
            'bloquearControlesNuevo()
            'drgAlumno.Enabled = False
            'bloquearControlesNuevo()

            cmdEliminar.Enabled = False
            cmdLimpiar.Enabled = False
            cmdActualizar.Enabled = False
            '.Enabled = False
            cmdAsignar.Enabled = False
            cmdGuardar.Enabled = True
        Catch ex As Exception
            MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Modificar alumno")
        End Try
    End Sub

    'BOTON ELIMINAR
    Private Sub cmdEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim eliminar = (From C In DataContext.Alumno Where C.id_alumno = CInt(txtidAlu.Text)).ToList()(0)

        Dim comprobrar1 = (From C In DataContext.Alumno_x_curso Where C.id_alumno = CInt(txtidAlu.Text)).Any
        Dim comprobrar2 = (From C In DataContext.Alumno_x_materia Where C.id_alumno = CInt(txtidAlu.Text)).Any

        If comprobrar1 = True Or comprobrar2 = True Then
            MsgBox("El registro no puede ser eliminado, posee inasistencia,notas y curso asociados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            limpiarControles()
            cmdEliminar.Enabled = False
            cmdActualizar.Enabled = False
            cmdLimpiar.Enabled = False
            cmdAsignar.Enabled = False
        Else
            DataContext.Alumno.DeleteOnSubmit(eliminar)
            DataContext.SubmitChanges()
            MsgBox("El alumno ha sido eliminado")
            limpiarControles()
            drgAlumno.Columns.Clear()
            TabControl1.SelectedIndex = 1

            ActivarControlesAtualizar()
            cmdEliminar.Enabled = False
            cmdActualizar.Enabled = False
            cmdLimpiar.Enabled = False
            cmdAsignar.Enabled = False
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

    'VALIDA DNI
    Private Sub txtDNI_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDNI.Validated
        If txtDNI.Text <> "" Then
            If txtDNI.TextLength <> 8 Then
                MsgBox("El dni del alumno debe tener 8 dígitos")
                txtDNI.Select()
                Exit Sub
            End If
            If txtDNI.Text.Chars(0) = "0" Then
                MsgBox("El dni del alumno no puede empezar con cero")
                txtDNI.Select()
                Exit Sub
            End If
        End If
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

    'VALIDA DNI TUTOR
    Private Sub txtDniTutor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDniTutor.Validated
        If txtDniTutor.Text <> "" Then
            If txtDniTutor.TextLength <> 8 Then
                MsgBox("El dni del tutor debe tener 8 dígitos")
                txtDniTutor.Select()
                Exit Sub
            End If
        End If
        
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            txtNombre.Select()
            AcceptButton = cmdGuardar
        Else
            txtApellidoAlu.Select()
            AcceptButton = cmdBuscar
        End If
    End Sub

End Class
