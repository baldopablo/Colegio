Public Class FrmAsignarCurso
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    'LOAD DEL FORM
    Public Sub FrmAsignarCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Frm_principal.quienllamofrmasignarcurso.Name = FrmAlumno.Name Then
            txtNombre.Text = FrmAlumno.txtNombreAlu.Text
            txtApellido.Text = FrmAlumno.txtApellidoAlu.Text
            txtDNI.Text = FrmAlumno.txtDNI_alu.Text
            txtIdAlu.Text = FrmAlumno.txtidAlu.Text
            'cmdImprimir.Enabled = False
            Button1.Visible = False
            MostrarGrilla()
        ElseIf Frm_principal.quienllamofrmasignarcurso.Name = Frm_principal.Name Then
            Button1.Visible = True
            txtApellido.ReadOnly = False
            txtApellido.Select()
            AcceptButton = Button1
            cboCurso.Enabled = False
            txtEspecialidad.Enabled = False
            dgrAsignar.Enabled = False
            cmdActualizar.Enabled = False
            cmdAsignar.Enabled = False
            cmdCancelar2.Enabled = False
            cmdeliminar_asig_curso.Enabled = False
        End If

        Dim Datos = From C In DataContext.Curso Select C.id_curso, C.nombre_curso
        Me.cboCurso.DataSource = Datos
        Me.cboCurso.DisplayMember = "nombre_curso"
        Me.cboCurso.ValueMember = "id_curso"
        Me.cboCurso.SelectedIndex = -1
    End Sub

    'BOTON VOLVER
    Private Sub cmdVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVolver.Click
        Me.Close()
        'FrmAlumno.Show()
        'FrmAlumno.Enabled = True

        'FrmAlumno.txtidAlu.Text = ""
        'FrmAlumno.txtNombreAlu.Text = ""
        'FrmAlumno.txtApellidoAlu.Text = ""
        'FrmAlumno.txtDNI_alu.Text = ""

        ' FrmAlumno.cmdActualizar.Enabled = False
        'FrmAlumno.cmdEliminar.Enabled = False
        'FrmAlumno.cmdModificar.Enabled = False
        FrmAlumno.cmdBuscar.Enabled = True
        'FrmAlumno.cmdVer.Enabled = False
        'FrmAlumno.cmdAsignar.Enabled = False

        FrmAlumno.drgAlumno.AutoGenerateColumns = False
        FrmAlumno.drgAlumno.Columns.Clear()

        FrmAlumno.drgAlumno.Columns.Add("", "Nombre Alumno")
        FrmAlumno.drgAlumno.Columns.Add("", "Apellido Alumno")
        FrmAlumno.drgAlumno.Columns.Add("", "Domicilio")
        FrmAlumno.drgAlumno.Columns.Add("", "DNI")
        FrmAlumno.drgAlumno.Columns.Add("", "Fecha de nacimiento")
        FrmAlumno.drgAlumno.Columns.Add("", "e-mail")
        FrmAlumno.drgAlumno.Columns.Add("", "Nombre y apellido tutor")
        FrmAlumno.drgAlumno.Columns.Add("", "DNI tutor")
        FrmAlumno.drgAlumno.Columns.Add("", "Telefono Tutor")

        FrmAlumno.drgAlumno.Columns(0).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(1).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(2).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(3).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(4).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(5).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(6).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(7).DataPropertyName = ""
        FrmAlumno.drgAlumno.Columns(8).DataPropertyName = ""


    End Sub

    'BOTON ASIGNAR
    Private Sub cmdAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAsignar.Click

        Try
            Dim BuscaAlu = (From alu In datacontextvistas.Vista_Alumno2 Where alu.id_alumno = (txtIdAlu.Text)).ToList()(0)
            MsgBox("El alumno ya tiene asignado un curso, usted puede modificarlo")
            MostrarGrilla()
            cmdAsignar.Enabled = False
            cmdActualizar.Enabled = True
            cboCurso.SelectedIndex = -1
            txtEspecialidad.Text = ""

        Catch ex As Exception
            If cboCurso.Text = "" Or txtEspecialidad.Text = "" Then
                MsgBox("Debe completar todos los campos requeridos")
            Else

                Dim AluxCurso = New Alumno_x_curso

                AluxCurso.id_alumno = txtIdAlu.Text
                AluxCurso.especialidad = txtEspecialidad.Text
                AluxCurso.id_curso = cboCurso.SelectedValue

                DataContext.Alumno_x_curso.InsertOnSubmit(AluxCurso)
                DataContext.SubmitChanges()
                MsgBox("El curso ha sido asignado al alumno correctamente", vbInformation)
                Select Case MsgBox("Imprimir comprobante de inscripción?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Imprimir")
                    Case MsgBoxResult.Ok
                        Dim comp As New Frmreporte_compr_inscrip
                        Dim rptcomp_insc As New Crystal_Compr_Inscrip

                        Try
                            Dim copiatextodni As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_dni"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextodni.Text = Me.txtDNI.Text

                            Dim copiatextonombre As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_nombre"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextonombre.Text = Me.txtNombre.Text

                            Dim copiatextoapellido As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_apellido"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextoapellido.Text = Me.txtApellido.Text

                            Dim copiatextoespecialidad As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_especialidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextoespecialidad.Text = Me.txtEspecialidad.Text

                            Dim copiatextocurso As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_curso"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextocurso.Text = Me.cboCurso.Text

                            Dim copiatextofecha As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_fecha"), CrystalDecisions.CrystalReports.Engine.TextObject)
                            copiatextofecha.Text = Me.Txt_fecha_ins.Text
                        Catch ex1 As Exception
                            MsgBox("Consulta inválida, intente nuevamente")
                        End Try

                        Dim rptcert As CrystalDecisions.CrystalReports.Engine.ReportDocument
                        rptcert = New Crystal_cert_alum_reg
                        'rptalum_reg.SetDataSource(dt)

                        Frmreporte_compr_inscrip.CrystalReportViewer1.ReportSource = rptcomp_insc
                        Frmreporte_compr_inscrip.ShowDialog()
                        Frmreporte_compr_inscrip.Dispose()
                        limpiarControles()
                        dgrAsignar.Enabled = True
                        txtApellido.Clear()
                        txtDNI.Clear()
                        txtNombre.Clear()
                        txtEspecialidad.SelectedItem = -1
                        cboCurso.SelectedIndex = -1
                        'MostrarGrilla()
                        cmdAsignar.Enabled = True
                        cmdCancelar2.Enabled = True
                    Case MsgBoxResult.Cancel
                        limpiarControles()
                        dgrAsignar.Enabled = True
                        txtApellido.Clear()
                        txtDNI.Clear()
                        txtNombre.Clear()
                        txtEspecialidad.SelectedItem = -1
                        cboCurso.SelectedIndex = -1
                        'MostrarGrilla()
                        cmdAsignar.Enabled = True
                        cmdCancelar2.Enabled = True
                        'cmdImprimir.Enabled = True

                        Exit Sub
                End Select
                '
            End If

        End Try
    End Sub

    'LIMPIAR CONTROLES
    Private Sub limpiarControles()
        cboCurso.SelectedIndex = -1
        txtEspecialidad.Text = ""
        btn_imprimir.Enabled = False
        'cmdVolver.PerformClick()
    End Sub

    'CARGA GRILLA
    Public Sub CargarGrilla()
        dgrAsignar.AutoGenerateColumns = False
        dgrAsignar.Columns.Clear()

        dgrAsignar.Columns.Add("", "Nombre")
        dgrAsignar.Columns.Add("", "Apellido")
        dgrAsignar.Columns.Add("", "DNI")
        dgrAsignar.Columns.Add("", "Curso")
        dgrAsignar.Columns.Add("", "Especialidad")

        dgrAsignar.Columns(0).DataPropertyName = ""
        dgrAsignar.Columns(1).DataPropertyName = ""
        dgrAsignar.Columns(2).DataPropertyName = ""
        dgrAsignar.Columns(3).DataPropertyName = ""

    End Sub

    'BOTON CANCELAR
    Private Sub cmdCancelar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar2.Click
        limpiarControles()
        dgrAsignar.Columns.Clear()
        cmdActualizar.Enabled = False
        cmdeliminar_asig_curso.Enabled = False
        btn_imprimir.Enabled = False
        ' cmdVolver.PerformClick()
    End Sub

    'MUESTRA GRILLA
    Public Sub MostrarGrilla()

        Dim consulta = From V In datacontextvistas.Vista_Alumno2 Select V.id_alumno_x_curso, V.id_alumno, V.id_curso, V.nombre_curso, V.nombre_alu, V.apellido_alu, V.especialidad, V.DNI_alu, V.fecha_inscripcion_alu Where id_alumno = CInt(txtIdAlu.Text)

        dgrAsignar.AutoGenerateColumns = False
        dgrAsignar.Columns.Clear()

        dgrAsignar.Columns.Add("nombre_alu", "Nombre")
        dgrAsignar.Columns.Add("apellido_alu", "Apellido")
        dgrAsignar.Columns.Add("DNI_alu", "DNI")
        dgrAsignar.Columns.Add("nombre_curso", "Curso")
        dgrAsignar.Columns.Add("especialidad", "Especialidad")
        dgrAsignar.Columns.Add("id_alumno_x_curso", "Id")
        dgrAsignar.Columns.Add("fecha_inscripcion_alu", "Incripción")


        dgrAsignar.Columns(0).DataPropertyName = "nombre_alu"
        dgrAsignar.Columns(1).DataPropertyName = "apellido_alu"
        dgrAsignar.Columns(2).DataPropertyName = "DNI_alu"
        dgrAsignar.Columns(3).DataPropertyName = "nombre_curso"
        dgrAsignar.Columns(4).DataPropertyName = "especialidad"
        dgrAsignar.Columns(5).DataPropertyName = "id_alumno_x_curso"
        dgrAsignar.Columns(5).Visible = False
        dgrAsignar.Columns(6).DataPropertyName = "fecha_inscripcion_alu"


        dgrAsignar.DataSource = consulta
        dgrAsignar.Enabled = True
        If dgrAsignar.Rows.Count > 0 Then
            cmdAsignar.Enabled = False
            cmdActualizar.Enabled = False
            cboCurso.Enabled = False
            cmdeliminar_asig_curso.Enabled = False
            txtEspecialidad.Enabled = False
        Else
            cboCurso.Enabled = True
            txtEspecialidad.Enabled = True
            cmdAsignar.Enabled = True
            cmdActualizar.Enabled = False
            cmdeliminar_asig_curso.Enabled = False
        End If

    End Sub

    'BOTON ACTUALIZAR
    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.Click

        If cboCurso.Text = "" Or txtEspecialidad.Text = "" Then
            MsgBox("Debe completar todos los campos requeridos")
        Else
            Try
                Dim ActualizaAlu = (From P In DataContext.Alumno_x_curso Where P.id_alumno = (txtIdAlu.Text)).ToList()(0)

                ActualizaAlu.id_curso = cboCurso.SelectedValue
                ActualizaAlu.especialidad = txtEspecialidad.Text

                DataContext.SubmitChanges()
                MsgBox("Los datos se han modificado correctamente")
                limpiarControles()
                MostrarGrilla()
                'dgrAsignar.Enabled = False
                'cmdActualizar.Enabled = True
                cmdCancelar2.Enabled = True
                'cmdImprimir.Enabled = True
                btn_imprimir.Enabled = False
            Catch ex As Exception
                MsgBox("Los datos no se han modificado! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")

            End Try
        End If
    End Sub

    'BOTON BUSCAR
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtApellido.Text = "" Then
            MsgBox("Ingrese un apellido", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            txtApellido.Clear()
            txtApellido.Select()
            Exit Sub
        End If
        Dim consultaasigna = (From U In DataContext.Alumno Select U.id_alumno, U.nombre_alu, U.apellido_alu, U.DNI_alu Where apellido_alu = txtApellido.Text).Any
        If consultaasigna = False Then
            MsgBox("Registro inexistente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")
            txtApellido.Clear()
            txtApellido.Select()
            Exit Sub
        Else
            Frm_principal.quienllamofrmbuscaalu3 = Me
            FrmBuscAlu3.Show()
        End If
    End Sub

    'CLICK SOBRE GRILLA
    Private Sub dgrAsignar_CelLClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgrAsignar.CellClick
        Select Case MsgBox("Va a modificar un curso", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Modificaciòn de curso")
            Case MsgBoxResult.Ok
                cmdActualizar.Enabled = True
                cboCurso.Enabled = True
                cmdeliminar_asig_curso.Enabled = True
                txtEspecialidad.Enabled = True
                cboCurso.Text = dgrAsignar.Item("nombre_curso", 0).Value
                txtEspecialidad.Text = dgrAsignar.Item("especialidad", 0).Value
                Txt_fecha_ins.Text = dgrAsignar.Item("fecha_inscripcion_alu", 0).Value
                cmdCancelar2.Enabled = True
                btn_imprimir.Enabled = True
            Case MsgBoxResult.Cancel
                cboCurso.Enabled = False
                txtEspecialidad.Enabled = False
                cboCurso.Text = dgrAsignar.Item("nombre_curso", 0).Value
                txtEspecialidad.Text = dgrAsignar.Item("especialidad", 0).Value
                Exit Sub
        End Select
        btn_imprimir.Enabled = True
    End Sub

    'BOTON ELIMINAR
    Private Sub cmdeliminar_asig_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdeliminar_asig_curso.Click
        Try
            Dim eliminar = (From c In DataContext.Alumno_x_curso Where c.id_alumno_x_curso = CInt(dgrAsignar.Item("id_alumno_x_curso", 0).Value)).ToList()(0)
            DataContext.Alumno_x_curso.DeleteOnSubmit(eliminar)
            DataContext.SubmitChanges()
            MsgBox("El alumno se borro del curso")
            MostrarGrilla()
            cboCurso.SelectedIndex = -1
            txtEspecialidad.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("El alumno no se borro del curso, elimine las inasistencias asociadas e intente nuevamente")
        End Try
        
    End Sub

    'BOTON IMPRIMIR
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.Click

        Dim comp As New Frmreporte_compr_inscrip
        Dim rptcomp_insc As New Crystal_Compr_Inscrip

        Try
            Dim copiatextodni As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_dni"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextodni.Text = Me.txtDNI.Text

            Dim copiatextonombre As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_nombre"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextonombre.Text = Me.txtNombre.Text

            Dim copiatextoapellido As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_apellido"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextoapellido.Text = Me.txtApellido.Text

            Dim copiatextoespecialidad As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_especialidad"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextoespecialidad.Text = Me.txtEspecialidad.Text

            Dim copiatextocurso As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_curso"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextocurso.Text = Me.cboCurso.Text

            Dim copiatextofecha As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptcomp_insc.ReportDefinition.ReportObjects.Item("crtext_fecha"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextofecha.Text = Me.Txt_fecha_ins.Text
        Catch ex As Exception
            MsgBox("Consulta inválida, intente nuevamente")
        End Try

        Dim rptcert As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptcert = New Crystal_cert_alum_reg
        'rptalum_reg.SetDataSource(dt)

        Frmreporte_compr_inscrip.CrystalReportViewer1.ReportSource = rptcomp_insc
        Frmreporte_compr_inscrip.ShowDialog()
        Frmreporte_compr_inscrip.Dispose()
    End Sub
End Class