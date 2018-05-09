Public Class FrmBuscaPers
    Dim DataContext As New DataClassesipem2DataContext
    Dim Datacontxtvistas As New DataClassesdevistasDataContext

    Dim id As Integer

    'LOAD DEL FORM
    Private Sub FrmBuscaPers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ActualizaGrilla()

    End Sub

    'VALIDACIONES
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

    'CARGA LA GRILLA CON EL NOMBRE BUSCADO
    Private Sub ActualizaGrilla()
        drgBuscaPers.Enabled = True
        drgBuscaPers.AutoGenerateColumns = False
        drgBuscaPers.Columns.Clear()

        drgBuscaPers.Columns.Add("id_personal", "Id Personal")
        drgBuscaPers.Columns.Add("nombre_pers", "Nombre")
        drgBuscaPers.Columns.Add("apelliido_pers", "Apellido")
        drgBuscaPers.Columns.Add("DNI_pers", "DNI")

        drgBuscaPers.Columns(0).DataPropertyName = "id_personal"
        drgBuscaPers.Columns(1).DataPropertyName = "nombre_pers"
        drgBuscaPers.Columns(2).DataPropertyName = "apelliido_pers"
        drgBuscaPers.Columns(3).DataPropertyName = "DNI_pers"

        If Frm_principal.quienllamofrmbuscapers.Name = FrmPersonal.Name Then
            Dim consulta = From U In DataContext.Personal Select U.id_personal, U.nombre_pers, U.apelliido_pers, U.DNI_pers, U.puesto_pers Where apelliido_pers = (FrmPersonal.txtApellidoPer.Text)
            drgBuscaPers.DataSource = consulta
        ElseIf Frm_principal.quienllamofrmbuscapers.Name = FrmAsignarMateria.Name Then
            Dim consulta1 = From U In DataContext.Personal Select U.id_personal, U.nombre_pers, U.apelliido_pers, U.DNI_pers, U.puesto_pers Where apelliido_pers = (FrmAsignarMateria.txtApellido.Text) And puesto_pers <> "Preceptor" And puesto_pers <> "Directivo"
            drgBuscaPers.DataSource = consulta1
        End If
        drgBuscaPers.ClearSelection()

    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'LimpiarControles()
    End Sub

    'BOTON SALIR
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        'FrmPersonal.Enabled = True
        'FrmPersonal.Show()
        Me.Close()
    End Sub

    'BOTON ACEPTAR
    Private Sub Btn_aceptar_buscapers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_aceptar_buscapers.Click
        If Frm_principal.quienllamofrmbuscapers.Name = FrmPersonal.Name Then
            If drgBuscaPers.SelectedRows.Count > 0 Then
                FrmPersonal.txtNombrePer.Text = drgBuscaPers.Item("nombre_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmPersonal.txtApellidoPer.Text = drgBuscaPers.Item("apelliido_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmPersonal.txtDNIPer.Text = drgBuscaPers.Item("DNI_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmPersonal.txtidPers.Text = drgBuscaPers.Item("id_personal", drgBuscaPers.SelectedRows(0).Index).Value
            End If
            FrmPersonal.MostrarGrilla()
            Me.Close()
        ElseIf Frm_principal.quienllamofrmbuscapers.Name = FrmAsignarMateria.Name Then
            If drgBuscaPers.SelectedRows.Count > 0 Then
                FrmAsignarMateria.txtApellido.Text = drgBuscaPers.Item("apelliido_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmAsignarMateria.txtNombre.Text = drgBuscaPers.Item("nombre_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmAsignarMateria.txtDNI.Text = drgBuscaPers.Item("DNI_pers", drgBuscaPers.SelectedRows(0).Index).Value
                FrmAsignarMateria.txtIdPers.Text = drgBuscaPers.Item("id_personal", drgBuscaPers.SelectedRows(0).Index).Value
                FrmAsignarMateria.MostrarGrilla()
                FrmAsignarMateria.cmdAsignar.Enabled = True
                FrmAsignarMateria.cmdCancelar2.Enabled = True
                FrmAsignarMateria.cboCurso.Enabled = True
                FrmAsignarMateria.cbomateria.Enabled = True
                Me.Close()
            End If
        End If
        
    End Sub
End Class