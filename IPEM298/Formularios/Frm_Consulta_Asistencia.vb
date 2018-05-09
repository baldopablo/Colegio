Public Class Frm_Consulta_Asistencia_pers
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Dim vble_id_pers As Integer 'Vble que guarda el id de personal
    Dim vble_id_alu As Integer 'vble que guarda el id de alumno

    'LOAD DEL FORM
    Private Sub Frm_Consulta_Asistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_dni_inasis.Select()
        Dg_inasistencia_pers.Enabled = False
        If Frm_principal.quienllamoconsultaasistencia = "alu" Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = True
            Btn_imprimir_consulta_asis_pers.Enabled = False
        Else
            GroupBox4.Visible = False
            Btn_imprimir_consulta_asis_pers.Enabled = True
        End If
    End Sub

    'CARGA GRILLA
    Sub cargargrilla_inasistencia()
        Dg_inasistencia_pers.AutoGenerateColumns = False
        Dg_inasistencia_pers.Columns.Clear()
        If Frm_principal.quienllamoconsultaasistencia = "doc" Then
            Dg_inasistencia_pers.Columns.Add("fecha_asistencia", "Fecha de Inasistencia")
            Dg_inasistencia_pers.Columns.Add("estado_textbox", "Tipo de Inasistencia")
            Dg_inasistencia_pers.Columns.Add("observacion", "Observacion")
            Dg_inasistencia_pers.Columns.Add("DNI_pers", "Dni")
            Dg_inasistencia_pers.Columns.Add("id_asistencia_doc", "Id_Inasistencia")

            Dg_inasistencia_pers.Columns(0).DataPropertyName = "fecha_asistencia"
            Dg_inasistencia_pers.Columns(1).DataPropertyName = "estado_textbox"
            Dg_inasistencia_pers.Columns(2).DataPropertyName = "observacion"
            Dg_inasistencia_pers.Columns(3).DataPropertyName = "DNI_pers"
            Dg_inasistencia_pers.Columns(4).DataPropertyName = "id_asistencia_doc"

            Dg_inasistencia_pers.Columns(3).Visible = False
            Dg_inasistencia_pers.Columns(4).Visible = False


            Dim inasistencia = From i In datacontextvistas.Vista_inasistencia_personal Select i.id_asistencia_doc, i.fecha_asistencia, i.estado_textbox, i.observacion, i.DNI_pers Where DNI_pers = Tb_dni_inasis.Text

            Dim id_persxdni = (From pxd In DataContext.Personal Select pxd.id_personal, pxd.DNI_pers Where DNI_pers = Tb_dni_inasis.Text).ToList()(0)
            vble_id_pers = id_persxdni.id_personal

            Dim contar_inasis = (From ci In datacontextvistas.Vista_inasistencia_personal Select ci.id_asistencia_doc, ci.DNI_pers, ci.estado_textbox Where DNI_pers = Tb_dni_inasis.Text And estado_textbox = "Ausente").Count
            Dim total_horarios = (From th In DataContext.Horario_personal Select th.id_horario, th.id_personal Where id_personal = vble_id_pers).Count
            Dim contar_tarde = (From ci In datacontextvistas.Vista_inasistencia_personal Select ci.id_asistencia_doc, ci.DNI_pers, ci.estado_textbox Where DNI_pers = Tb_dni_inasis.Text And estado_textbox = "Tarde").Count

            Tb_inasis_cat.Text = contar_inasis
            Tb_total_horas.Text = total_horarios
            Tb_tarde.Text = contar_tarde

            Dg_inasistencia_pers.DataSource = inasistencia
        ElseIf Frm_principal.quienllamoconsultaasistencia = "alu" Then
            Dg_inasistencia_pers.Columns.Add("fecha_asistencia_alu", "Fecha de Inasistencia")
            Dg_inasistencia_pers.Columns.Add("estado_asistencia_alu", "Tipo de Inasistencia")
            Dg_inasistencia_pers.Columns.Add("observacion_asis_alu", "Observacion")
            Dg_inasistencia_pers.Columns.Add("DNI_alu", "Dni")
            Dg_inasistencia_pers.Columns.Add("id_asistencia_alu", "Id_Inasistencia")

            Dg_inasistencia_pers.Columns(0).DataPropertyName = "fecha_asistencia_alu"
            Dg_inasistencia_pers.Columns(1).DataPropertyName = "estado_asistencia_alu"
            Dg_inasistencia_pers.Columns(2).DataPropertyName = "observacion_asis_alu"
            Dg_inasistencia_pers.Columns(3).DataPropertyName = "DNI_alu"
            Dg_inasistencia_pers.Columns(4).DataPropertyName = "id_asistencia_alu"

            Dg_inasistencia_pers.Columns(3).Visible = False
            Dg_inasistencia_pers.Columns(4).Visible = False

            Dim contar_inasis_alu = (From ci In datacontextvistas.Vista_inasistencia_alumno Select ci.id_asistencia_alu, ci.DNI_alu, ci.estado_asistencia_alu Where DNI_alu = Tb_dni_inasis.Text And estado_asistencia_alu = "Ausente").Count
            Dim contar_tarde_alu = (From ci In datacontextvistas.Vista_inasistencia_alumno Select ci.id_asistencia_alu, ci.DNI_alu, ci.estado_asistencia_alu Where DNI_alu = Tb_dni_inasis.Text And estado_asistencia_alu = "Tarde").Count

            tb_inasis_alu.Text = contar_inasis_alu
            Tb_tarde_alu.Text = contar_tarde_alu

            Dim inasistenciaalu = From i In datacontextvistas.Vista_inasistencia_alumno Select i.id_asistencia_alu, i.fecha_asistencia_alu, i.estado_asistencia_alu, i.observacion_asis_alu, i.DNI_alu Where DNI_alu = Tb_dni_inasis.Text

            Dim id_aluxdni = (From axd In DataContext.Alumno Select axd.id_alumno, axd.DNI_alu Where DNI_alu = Tb_dni_inasis.Text).ToList()(0)
            vble_id_alu = id_aluxdni.id_alumno
            Dg_inasistencia_pers.DataSource = inasistenciaalu
        End If
        Dg_inasistencia_pers.ClearSelection()
    End Sub

    'SUB QUE CONTIENE EQUIVALENCIA ENTRE HS CATEDRAS Y OBLIGACIONES
    Sub equivalencia_obligaciones(ByVal tomar_de As Integer, ByVal devolver_en As Object)

        Select Case CInt(tomar_de)
            Case 1
                devolver_en.text = 0
            Case 2
                devolver_en.text = 1
            Case 3
                devolver_en.text = 2
            Case 4
                devolver_en.text = 3
            Case 5
                devolver_en.text = 4
            Case 6
                devolver_en.text = 4
            Case 7
                devolver_en.text = 5
            Case 8
                devolver_en.text = 6
            Case 9
                devolver_en.text = 7
            Case 10
                devolver_en.text = 8
            Case 11
                devolver_en.text = 8
            Case 12
                devolver_en.text = 9
            Case 13
                devolver_en.text = 10
            Case 14
                devolver_en.text = 11
            Case 15
                devolver_en.text = 12
            Case 16
                devolver_en.text = 12
            Case 17
                devolver_en.text = 13
            Case 18
                devolver_en.text = 14
            Case 19
                devolver_en.text = 15
            Case 20
                devolver_en.text = 16
            Case 21
                devolver_en.text = 16
            Case 22
                devolver_en.text = 17
            Case 23
                devolver_en.text = 18
            Case 24
                devolver_en.text = 19
            Case 25
                devolver_en.text = 20
            Case 26
                devolver_en.text = 20
            Case 27
                devolver_en.text = 21
            Case 28
                devolver_en.text = 22
            Case 29
                devolver_en.text = 23
            Case 30
                devolver_en.text = 24
            Case 31
                devolver_en.text = 24
        End Select

    End Sub

    'CALCULA LAS OBLIGACIONES 
    Private Sub calcular()

        equivalencia_obligaciones(Tb_total_horas.Text, Tb_obligaciones_cumplir)
        equivalencia_obligaciones(Tb_inasis_cat.Text, Tb_inasis_obligaciones)

        Tb_inasis_permitidas.Text = CInt(Tb_obligaciones_cumplir.Text) * 10 / 100
    End Sub

    'BOTON BUSCAR
    Private Sub Btn_buscar_consulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_buscar_consulta_inasis.Click

        If Frm_principal.quienllamoconsultaasistencia = "doc" Then
            Select Case Rbt_dni_consulta_asis_pers.Checked
                Case True
                    Try
                        Dim BuscaPersonal = (From pers In DataContext.Personal Where pers.DNI_pers = CInt(Tb_dni_inasis.Text)).ToList()(0)
                        Tb_apellidoynombre_inasis.Text = BuscaPersonal.apelliido_pers & ", " & BuscaPersonal.nombre_pers
                        cargargrilla_inasistencia()
                        calcular()
                        Btn_buscar_consulta_inasis.Enabled = False
                        Btn_limpiar_consulta_inasis.Enabled = True
                        Btn_imprimir_consulta_asis_pers.Enabled = True
                        Tb_dni_inasis.Enabled = False
                    Catch ex As Exception
                        MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Busqueda de Registro")
                        Tb_dni_inasis.Clear()
                    End Try
                Case Else
                    Dim valida_fecha = (From v In datacontextvistas.Vista_inasistencia_personal Select v.fecha_asistencia Where fecha_asistencia = DateTP_consulta_asis_pers.Text).Count
                    If valida_fecha = 0 Then
                        MsgBox("No existen inasistencias en esta fecha", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Busqueda de Registro")
                        Exit Sub
                    Else
                        Frm_principal.quienllamaconsultaasispersfecha = "doc"
                        Frm_consulta_asis_pers_fecha.Show()
                    End If
            End Select
        ElseIf Frm_principal.quienllamoconsultaasistencia = "alu" Then
            Select Rbt_dni_consulta_asis_pers.Checked
                Case True
                    Try
                        Dim Buscaalu = (From alu In DataContext.Alumno Where alu.DNI_alu = CInt(Tb_dni_inasis.Text)).ToList()(0)
                        Tb_apellidoynombre_inasis.Text = Buscaalu.apellido_alu & ", " & Buscaalu.nombre_alu
                        cargargrilla_inasistencia()
                        Btn_buscar_consulta_inasis.Enabled = False
                        Btn_limpiar_consulta_inasis.Enabled = True
                        Btn_imprimir_consulta_asis_pers.Enabled = True
                        Tb_dni_inasis.Enabled = False
                    Catch ex As Exception
                        MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Busqueda de Registro")
                        Tb_dni_inasis.Clear()
                    End Try
                Case Else
                    Dim valida_fecha_alu = (From v In datacontextvistas.Vista_inasistencia_alumno Select v.fecha_asistencia_alu Where fecha_asistencia_alu = DateTP_consulta_asis_pers.Text).Count
                    If valida_fecha_alu = 0 Then
                        MsgBox("No existen inasistencias en esta fecha", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Busqueda de Registro")
                        Exit Sub
                    Else
                        Frm_principal.quienllamaconsultaasispersfecha = "alu"
                        Frm_consulta_asis_pers_fecha.Show()
                    End If
            End Select
        End If
        
    End Sub

    'BOTON LIMPIAR
    Private Sub Btn_limpiar_inasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_limpiar_consulta_inasis.Click
        Tb_apellidoynombre_inasis.Clear()
        Tb_dni_inasis.Clear()
        Tb_dni_inasis.Select()
        Tb_inasis_cat.Clear()
        Tb_inasis_obligaciones.Clear()
        Tb_inasis_permitidas.Clear()
        Tb_obligaciones_cumplir.Clear()
        Tb_total_horas.Clear()
        Btn_buscar_consulta_inasis.Enabled = True
        Dg_inasistencia_pers.Columns.Clear()
        Tb_dni_inasis.Enabled = True
        Btn_limpiar_consulta_inasis.Enabled = False
        Btn_imprimir_consulta_asis_pers.Enabled = False
    End Sub

    'BOTON SALIR
    Private Sub Btn_salir_consulta_asis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_consulta_asis.Click
        Me.Close()
    End Sub

    'RADIO BUTTON DNI
    Private Sub Rbt_dni_consulta_asis_pers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_dni_consulta_asis_pers.CheckedChanged
        GroupBox_fecha.Enabled = False
        GroupBox_dni.Enabled = True
        Dg_inasistencia_pers.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
    End Sub

    'RADIO BUTTON FECHA
    Private Sub Rbt_fecha_consulta_asis_pers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rbt_fecha_consulta_asis_pers.CheckedChanged
        GroupBox_fecha.Enabled = True
        GroupBox_dni.Enabled = False
        Dg_inasistencia_pers.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        Btn_limpiar_consulta_inasis.PerformClick()
    End Sub

    'BOTON IMPRIMIR
    Private Sub Btn_imprimir_consulta_asis_pers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_imprimir_consulta_asis_pers.Click
        Dim finas As New Frmreporte_inas_individual
        Dim rptinas_indiv As New Crystal_inas_individual

        'copia los textbox
        Try
            Dim copiatextodni As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_dni"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextodni.Text = Me.Tb_dni_inasis.Text

            Dim copiatextonombre As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_nombre"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextonombre.Text = Me.Tb_apellidoynombre_inasis.Text


            Dim copiatextohs_cat_cumplir As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_hs_a_cumplir"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextohs_cat_cumplir.Text = Me.Tb_total_horas.Text

            Dim copiatexto_obli_cumplir As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_obl_a_cumplir"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatexto_obli_cumplir.Text = Me.Tb_obligaciones_cumplir.Text

            Dim copiatextohs_cat_incumplidas As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_hs_incumplidas"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextohs_cat_incumplidas.Text = Me.Tb_inasis_cat.Text

            Dim copiatexto_obli_incumplidas As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_obli_incumplidas"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatexto_obli_incumplidas.Text = Me.Tb_inasis_obligaciones.Text

            Dim copiatextopermitidas As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptinas_indiv.ReportDefinition.ReportObjects.Item("crtext_permitidas"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextopermitidas.Text = Me.Tb_inasis_permitidas.Text


        Catch ex As Exception


        End Try

        'imprime un datagriedview
        Dim dt As New DataSet1
        For Each dr As DataGridViewRow In Me.Dg_inasistencia_pers.Rows
            dt.DataTable2.AddDataTable2Row(dr.Cells("fecha_asistencia").Value, dr.Cells("estado_textbox").Value, dr.Cells("observacion").Value)
        Next

        'Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptdoc = New Crystal_inas_individual
        rptinas_indiv.SetDataSource(dt)

        Frmreporte_inas_individual.CrystalReportViewer1.ReportSource = rptinas_indiv
        Frmreporte_inas_individual.ShowDialog()
        Frmreporte_inas_individual.Dispose()
    End Sub
End Class
