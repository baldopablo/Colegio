Imports System.IO
Imports System.Text.RegularExpressions
Public Class FrmMateria
    Dim DataContext As New DataClassesipem2DataContext
    Dim dataco
    Dim idmate As Integer

    'LOAD DEL FORM
    Private Sub FrmMateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNombreMa.Select()
        ActivarControlesAtualizar()
        bloquearControlesNuevo()
        LimpiarControles()
        rbnNuevo.Checked = False
        rbnActualizar.Checked = True
        drgMateria.Enabled = False
        cmdEliminar.Enabled = False
        '.Enabled = False
        cmdLimpiar.Enabled = False
        cmdActualizar.Enabled = False
        If rbnNuevo.Checked = True Then
            txtCodigo.Select()
            AcceptButton = cmdGuardar
            rbnActualizar.Checked = False
            ActivarControlesNuevo()
            bloquearControlesActualizar()
        End If
    End Sub

    'BOTON BUSCAR
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
     
        If txtNombreMa.Text = "" Then
            MsgBox("Ingrese un nombre de materia para buscar!")
        Else
            Try
                Dim BusaMate = (From mate In DataContext.Materia Where mate.nombre_materia = (txtNombreMa.Text)).ToList()(0)
                txtidMate.Text = BusaMate.id_materia
                MostrarGrilla()
                drgMateria.Enabled = True
            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                LimpiarControles()
            End Try
        End If
    End Sub

    'CARGA GRILLA VACIA
    Private Sub CargarGrilla()
        drgMateria.AutoGenerateColumns = False
        drgMateria.Columns.Clear()

        drgMateria.Columns.Add("", "Código Materia")
        drgMateria.Columns.Add("", "Nombre Materia")
        drgMateria.Columns.Add("", "Especialidad")
      

        drgMateria.Columns(0).DataPropertyName = ""
        drgMateria.Columns(1).DataPropertyName = ""
        drgMateria.Columns(2).DataPropertyName = ""
    End Sub

    'CARGA LA GRILLLA CON DATOS
    Private Sub MostrarGrilla()

        Dim consulta = From V In DataContext.Materia Select V.id_materia, V.nombre_materia, V.codigo_materia, V.especialidad_textbox Where nombre_materia = (txtNombreMa.Text)

        drgMateria.AutoGenerateColumns = False
        drgMateria.Columns.Clear()
        drgMateria.Columns.Add("codigo_materia", "Código Materia")
        drgMateria.Columns.Add("nombre_materia", "Nombre Materia")
        drgMateria.Columns.Add("especialidad_textbox", "Especialidad")
        

        drgMateria.Columns(0).DataPropertyName = "codigo_materia"
        drgMateria.Columns(1).DataPropertyName = "nombre_materia"
        drgMateria.Columns(2).DataPropertyName = "especialidad_textbox"
       
        drgMateria.DataSource = consulta
        drgMateria.ClearSelection()


    End Sub

    'BOTON SALIR
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    'BOTON LIMPIAR
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        limpiarControles()
        CargarGrilla()
        ActivarControlesAtualizar()
        bloquearControlesNuevo()
        cmdLimpiar.Enabled = False
        drgMateria.Enabled = False
    End Sub

    'LIMPIAR CONTROLESS
    Private Sub LimpiarControles()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtEspecialidad.Text = ""
        txtidMate.Text = ""
        'txtNombreMa.Text = ""

    End Sub

    Private Sub bloquearControlesNuevo()
        txtNombre.Enabled = False
        txtCodigo.Enabled = False
        txtEspecialidad.Enabled = False
        cmdGuardar.Enabled = False
        cmdCancelar.Enabled = False
    End Sub

    Private Sub ActivarControlesAtualizar()
        'txtidMate.Enabled = True
        txtNombreMa.Enabled = True
        cmdBuscar.Enabled = True
        drgMateria.Enabled = True
    End Sub

    Private Sub ActivarControlesNuevo()
        txtNombre.Enabled = True
        txtCodigo.Enabled = True
        txtEspecialidad.Enabled = True
        cmdGuardar.Enabled = True
        cmdCancelar.Enabled = True
        'cmd_examinar.Enabled = True

    End Sub

    'PASA LOS DATOS DEL GRID A LOS CAMPOS
    Private Sub ActualizaDatosgrid()

        If drgMateria.SelectedRows.Count > 0 Then
            txtCodigo.Text = drgMateria.Item("codigo_materia", drgMateria.SelectedRows(0).Index).Value
            txtNombre.Text = drgMateria.Item("nombre_materia", drgMateria.SelectedRows(0).Index).Value
            txtEspecialidad.Text = drgMateria.Item("especialidad_textbox", drgMateria.SelectedRows(0).Index).Value
        End If
    End Sub

    'RBT NUEVO
    Private Sub rbnNuevo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnNuevo.CheckedChanged
        ActivarControlesNuevo()
        bloquearControlesActualizar()
        limpiarControles()
        CargarGrilla()
        drgMateria.Enabled = False
    End Sub

    'RBT ACTUALIZA
    Private Sub rbnActualizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnActualizar.CheckedChanged
        ActivarControlesAtualizar()
        bloquearControlesNuevo()
        limpiarControles()
        CargarGrilla()
        drgMateria.Enabled = False
    End Sub

    Private Sub bloquearControlesActualizar()

        'txtidMate.Enabled = False
        drgMateria.Enabled = False
        cmdEliminar.Enabled = False
        'cmdModificar.Enabled = False
        cmdLimpiar.Enabled = False
        cmdBuscar.Enabled = False
        cmdActualizar.Enabled = False
        txtNombreMa.Enabled = False
    End Sub

    'BOTON ACTUALIZAR
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click
        'If txtNombre.Text = "" Or txtNombre.Text = "" Or txtEspecialidad.Text = "" Then
        '    MsgBox("Debe completar todos los campos requeridos")
        '    Exit Sub
        'Else
        '    Dim validanombremat = (From vc In DataContext.Materia Select vc.nombre_materia Where nombre_materia = txtNombre.Text).Any
        '    If validanombremat = True Then
        '        MsgBox("El nómbre de materia ya existe")
        '        txtNombre.Select()
        '        Exit Sub
        '    End If
        'End If
        'Try
        '    Dim ActualizaMate = (From P In DataContext.Materia Where P.codigo_materia = (txtCodigo.Text)).ToList()(0)

        '    ActualizaMate.codigo_materia = txtCodigo.Text
        '    ActualizaMate.nombre_materia = txtNombre.Text
        '    ActualizaMate.especialidad_textbox = txtEspecialidad.Text

        '    DataContext.SubmitChanges()
        '    MsgBox("Los datos se han modificado correctamente")
        '    LimpiarControles()
        '    MostrarGrilla()
        '    ActivarControlesAtualizar()
        '    bloquearControlesNuevo()
        '    drgMateria.Enabled = False
        '    bloquearControlesNuevo()

        '    cmdEliminar.Enabled = False
        '    cmdLimpiar.Enabled = False
        '    cmdActualizar.Enabled = False
        'Catch ex As Exception
        '    MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
        'End Try

    End Sub

    'VALIDACIONES
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
    Private Sub txtEspecialidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        LimpiarControles()
        CargarGrilla()
        ActivarControlesAtualizar()
        bloquearControlesNuevo()
        cmdLimpiar.Enabled = False
        drgMateria.Enabled = False
    End Sub

    'BOTON ELIMINAR
    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim eliminar = (From C In DataContext.Materia Where C.id_materia = CInt(txtidMate.Text)).ToList()(0)


        Dim comprobrar1 = (From C In DataContext.Profesor_x_Materia Where C.id_materia = CInt(txtidMate.Text)).Any
        Dim comprobrar2 = (From C In DataContext.Alumno_x_materia Where C.id_materia = CInt(txtidMate.Text)).Any
        If comprobrar1 = True Or comprobrar2 = True Then
            MsgBox("Los datos No pueden ser eliminados, borre los registros asociados a esta materia! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            LimpiarControles()
        Else
            DataContext.Materia.DeleteOnSubmit(eliminar)
            DataContext.SubmitChanges()
            MsgBox("La materia ha sido eliminada")
            LimpiarControles()
            CargarGrilla()
            ActivarControlesAtualizar()
            bloquearControlesNuevo()
            cmdEliminar.Enabled = False
            cmdActualizar.Enabled = False
            'cmdModificar.Enabled = False
            cmdLimpiar.Enabled = False
        End If

           


            'CargarGrilla()



    End Sub

    'BOTON GUARDAR
    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If txtNombre.Text = "" Or txtNombre.Text = "" Or txtEspecialidad.Text = "" Then
            MsgBox("Debe completar todos los campos requeridos")
            Exit Sub
        Else
            Dim validacodigomat = (From vc In DataContext.Materia Select vc.codigo_materia Where codigo_materia = txtCodigo.Text).Any
            If validacodigomat = True Then
                MsgBox("El código ya existe")
                txtCodigo.Select()
                Exit Sub
            End If

            Dim validanombremat = (From vc In DataContext.Materia Select vc.nombre_materia Where nombre_materia = txtNombre.Text).Any
            If validanombremat = True Then
                MsgBox("El nómbre de materia ya existe")
                txtNombre.Select()
                Exit Sub
            End If
        End If
        Try
            Dim M = New Materia
            M.codigo_materia = txtCodigo.Text
            M.nombre_materia = txtNombre.Text
            M.especialidad_textbox = txtEspecialidad.Text

            DataContext.Materia.InsertOnSubmit(M)
            DataContext.SubmitChanges()
            MsgBox("La Materia se ha creado correctamente", vbInformation)

            LimpiarControles()
            CargarGrilla()
            'ActivarControlesAtualizar()
            'bloquearControlesNuevo()
            cmdLimpiar.Enabled = False
            drgMateria.Enabled = False

        Catch ex As Exception
            MsgBox("La materia NO se creo, intente nuevamente")
        End Try

            

    End Sub

    'VALIDACIONES
    Private Sub txtNombreMa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreMa.KeyPress
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
    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If (Asc(e.KeyChar)) >= 48 And (Asc(e.KeyChar)) <= 57 Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'CLICK SOBRE GRILLA
    Private Sub drgMateria_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles drgMateria.CellClick
        Select Case MsgBox("Atencion! Puede eliminar una materia!", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de materia")
            Case MsgBoxResult.Ok
                'PasaDatos()
                cmdEliminar.Enabled = True
                cmdActualizar.Enabled = True
                cmdLimpiar.Enabled = True
                'txtCodigo.Enabled = True
                'txtNombre.Enabled = True
                'txtEspecialidad.Enabled = True
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select

    End Sub

    'PASA DATOS
    Private Sub PasaDatos()

        If drgMateria.SelectedRows.Count > 0 Then
            txtCodigo.Text = drgMateria.Item("codigo_materia", drgMateria.SelectedRows(0).Index).Value
            txtNombre.Text = drgMateria.Item("nombre_materia", drgMateria.SelectedRows(0).Index).Value
            txtEspecialidad.Text = drgMateria.Item("especialidad_textbox", drgMateria.SelectedRows(0).Index).Value
        End If
    End Sub

    'BOTON VER LISTADO DE MATERIAS
    Private Sub btn_ver_todas_abm_mat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ver_todas_abm_mat.Click
        Frm_listado_materias.Show()
    End Sub
End Class