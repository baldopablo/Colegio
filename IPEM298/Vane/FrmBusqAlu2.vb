Public Class FrmBusqAlu2
    Dim DataContext As New DataClassesipem2DataContext

    Private Sub FrmBusqAlu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarGrilla()
    End Sub

    Private Sub MostrarGrilla()

        drgBuscarAlu.AutoGenerateColumns = False
        drgBuscarAlu.Columns.Clear()
        drgBuscarAlu.Rows.Clear()

        drgBuscarAlu.Columns.Add("", "Id Alumno")
        drgBuscarAlu.Columns.Add("", "Nombre")
        drgBuscarAlu.Columns.Add("", "Apellido")
        drgBuscarAlu.Columns.Add("", "DNI")

        drgBuscarAlu.Columns(0).DataPropertyName = ""
        drgBuscarAlu.Columns(1).DataPropertyName = ""
        drgBuscarAlu.Columns(2).DataPropertyName = ""
        drgBuscarAlu.Columns(3).DataPropertyName = ""

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

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If txtApellido.Text = "" Then
            MsgBox("Ingrese un apellido para buscar!")
        Else
            Try
                Dim BuscaAlu = (From alu In DataContext.Alumno Where alu.apellido_alu = (txtApellido.Text)).ToList()(0)
                ActualizaGrilla()
            Catch ex As Exception
                MsgBox("El registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
                LimpiarControles()
            End Try
        End If
    End Sub

    Private Sub ActualizaGrilla()

        Dim consulta = From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu Where apellido_alu = (txtApellido.Text)

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

    End Sub



    Private Sub LimpiarControles()
        txtApellido.Text = ""
        MostrarGrilla()
    End Sub


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        LimpiarControles()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        FrmCalificaciones.Enabled = True
        FrmCalificaciones.Show()
        Me.Close()
    End Sub

    Private Sub PasaDatos()

        If drgBuscarAlu.SelectedRows.Count > 0 Then
            FrmCalificaciones.txtNombre2.Text = drgBuscarAlu.Item("nombre_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones.txtApellido2.Text = drgBuscarAlu.Item("apellido_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones.txtBuscar2.Text = drgBuscarAlu.Item("DNI_alu", drgBuscarAlu.SelectedRows(0).Index).Value
            FrmCalificaciones.txtIdAlu.Text = drgBuscarAlu.Item("id_alumno", drgBuscarAlu.SelectedRows(0).Index).Value
            'ActualizaGrillaCalif()
        End If
    End Sub

    Private Sub drgBuscarAlu_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles drgBuscarAlu.CellClick
        PasaDatos()

        FrmCalificaciones.Enabled = True
        FrmCalificaciones.Show()
        FrmCalificaciones.cmdCancelargr.Enabled = True
        FrmCalificaciones.cmdVer.Enabled = True
        'FrmCalificaciones.cmdBuscar.Enabled = False
        'FrmCalificaciones.cmdLimpiar.Enabled = True
        Me.Close()
    End Sub
End Class