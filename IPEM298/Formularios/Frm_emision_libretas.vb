Public Class Frm_emision_libretas
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim datacontext As New DataClassesipem2DataContext

    'CARGAR GRILLA
    Sub cargargrilla()
        Dim libreta = From l In datacontextvistas.Vista_libreta Select l.parcial1, l.parcial2, l.parcial3, l.parcial4, l.integrador1, l.promedioetapa1, l.parcial6, l.parcial7, l.parcial8, l.integrador2, l.promedioetapa2, l.parcial9, l.parcial10, l.parcial11, l.parcial12, l.integrador3, l.promedioetapa3, l.promedio_anual, l.coloquio, l.examen, l.calif_definitiva, l.condicion_textbox, l.nombre_materia, l.nombre_alu, l.apellido_alu, l.DNI_alu, l.nombre_curso, l.turno_textbox, l.id_alumno, l.especialidad Where nombre_curso = CStr(Cmb_curso_asis_alu.Text)

        Dg_libreta.Columns.Clear()
        Dg_libreta.AutoGenerateColumns = False

        Dg_libreta.Columns.Add("parcial1", "P1")
        Dg_libreta.Columns.Add("parcial2", "P2")
        Dg_libreta.Columns.Add("parcial3", "P3")
        Dg_libreta.Columns.Add("parcial4", "P4")
        Dg_libreta.Columns.Add("integrador1", "I1")
        Dg_libreta.Columns.Add("promedioetapa1", "E1")
        Dg_libreta.Columns.Add("parcial5", "P5")
        Dg_libreta.Columns.Add("parcial6", "P6")
        Dg_libreta.Columns.Add("parcial7", "P7")
        Dg_libreta.Columns.Add("parcial8", "P8")
        Dg_libreta.Columns.Add("integrador2", "I2")
        Dg_libreta.Columns.Add("promedioetapa2", "E2")
        Dg_libreta.Columns.Add("parcial9", "P9")
        Dg_libreta.Columns.Add("parcial10", "P10")
        Dg_libreta.Columns.Add("parcial11", "P11")
        Dg_libreta.Columns.Add("parcial12", "P12")
        Dg_libreta.Columns.Add("integrador3", "I3")
        Dg_libreta.Columns.Add("promedioetapa3", "E3")
        Dg_libreta.Columns.Add("promedio_anual", "P.A.")
        Dg_libreta.Columns.Add("coloquio", "C")
        Dg_libreta.Columns.Add("examen", "EX")
        Dg_libreta.Columns.Add("calif_definitiva", "Definitiva")
        Dg_libreta.Columns.Add("condicion_textbox", "Condicion")
        Dg_libreta.Columns.Add("nombre_materia", "Materia")
        Dg_libreta.Columns.Add("nombre_alu", "Nombre")
        Dg_libreta.Columns.Add("apellido_alu", "Apellido")
        Dg_libreta.Columns.Add("DNI_alu", "Dni")
        Dg_libreta.Columns.Add("id_alumno", "ID")
        Dg_libreta.Columns.Add("nombre_curso", "Curso")
        Dg_libreta.Columns.Add("turno_textbox", "Turno")
        Dg_libreta.Columns.Add("especialidad", "Especialidad")



        Dg_libreta.Columns(0).DataPropertyName = "parcial1"
        Dg_libreta.Columns(1).DataPropertyName = "parcial2"
        Dg_libreta.Columns(2).DataPropertyName = "parcial3"
        Dg_libreta.Columns(3).DataPropertyName = "parcial4"
        Dg_libreta.Columns(4).DataPropertyName = "integrador1"
        Dg_libreta.Columns(5).DataPropertyName = "promedioetapa1"
        Dg_libreta.Columns(6).DataPropertyName = "parcial5"
        Dg_libreta.Columns(7).DataPropertyName = "parcial6"
        Dg_libreta.Columns(8).DataPropertyName = "parcial7"
        Dg_libreta.Columns(9).DataPropertyName = "parcial8"
        Dg_libreta.Columns(10).DataPropertyName = "integrador2"
        Dg_libreta.Columns(11).DataPropertyName = "promedioetapa2"
        Dg_libreta.Columns(12).DataPropertyName = "parcial9"
        Dg_libreta.Columns(13).DataPropertyName = "parcial10"
        Dg_libreta.Columns(14).DataPropertyName = "parcial11"
        Dg_libreta.Columns(15).DataPropertyName = "parcial12"
        Dg_libreta.Columns(16).DataPropertyName = "integrador3"
        Dg_libreta.Columns(17).DataPropertyName = "promedioetapa3"
        Dg_libreta.Columns(18).DataPropertyName = "promedio_anual"
        Dg_libreta.Columns(19).DataPropertyName = "coloquio"
        Dg_libreta.Columns(20).DataPropertyName = "examen"
        Dg_libreta.Columns(21).DataPropertyName = "calif_definitiva"
        Dg_libreta.Columns(22).DataPropertyName = "condicion_textbox"
        Dg_libreta.Columns(23).DataPropertyName = "nombre_materia"
        Dg_libreta.Columns(24).DataPropertyName = "nombre_alu"
        Dg_libreta.Columns(25).DataPropertyName = "apellido_alu"
        Dg_libreta.Columns(26).DataPropertyName = "DNI_alu"
        Dg_libreta.Columns(27).DataPropertyName = "id_alumno"
        Dg_libreta.Columns(28).DataPropertyName = "nombre_curso"
        Dg_libreta.Columns(29).DataPropertyName = "turno_textbox"
        Dg_libreta.Columns(30).DataPropertyName = "especialidad"



        Dg_libreta.DataSource = libreta
    End Sub


    Private Sub Cmb_curso_asis_alu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_curso_asis_alu.SelectedIndexChanged
        cargargrilla()
    End Sub

    Private Sub Cmb_turno_asis_alu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_turno_asis_alu.SelectedIndexChanged
        Dim cbocurso = (From c In datacontextvistas.vista_modulocurso Select c.id_curso, c.nombre_curso, c.turno_textbox Where turno_textbox = CStr(Cmb_turno_asis_alu.SelectedItem)).Distinct
        Cmb_curso_asis_alu.DataSource = cbocurso
        Cmb_curso_asis_alu.DisplayMember = "nombre_curso"
        Cmb_curso_asis_alu.ValueMember = "id_curso"
        Cmb_curso_asis_alu.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_generar_emision_lib.Click

        Dim dt As New DataSet1
        For Each dr As DataGridViewRow In Me.Dg_libreta.Rows
            dt.DataTableLibreta.AddDataTableLibretaRow(dr.Cells("parcial1").Value, dr.Cells("parcial2").Value, dr.Cells("parcial3").Value, dr.Cells("parcial4").Value, dr.Cells("integrador1").Value, dr.Cells("promedioetapa1").Value, dr.Cells("parcial5").Value, dr.Cells("parcial6").Value, dr.Cells("parcial7").Value, dr.Cells("parcial8").Value, dr.Cells("integrador2").Value, dr.Cells("promedioetapa2").Value, dr.Cells("parcial9").Value, dr.Cells("parcial10").Value, dr.Cells("parcial11").Value, dr.Cells("parcial12").Value, dr.Cells("integrador3").Value, dr.Cells("promedioetapa3").Value, dr.Cells("promedio_anual").Value, dr.Cells("coloquio").Value, dr.Cells("examen").Value, dr.Cells("calif_definitiva").Value, dr.Cells("condicion_textbox").Value, dr.Cells("nombre_materia").Value, dr.Cells("nombre_alu").Value, dr.Cells("apellido_alu").Value, dr.Cells("DNI_alu").Value, dr.Cells("id_alumno").Value, dr.Cells("nombre_curso").Value, dr.Cells("turno_textbox").Value, dr.Cells("especialidad").Value)
        Next
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'rptdoc = New Crystal_libreta
        'rptdoc.SetDataSource(dt)

        ''Frmreporte_libreta.ShowDialog()
        ''Frmreporte_libreta.Dispose()

        Select Case Cbo_etapas.Text

            Case "Etapa1"
                rptdoc = New CrystaL_Informe_1etapa
                rptdoc.SetDataSource(dt)
                Frmreporte_Informe_etapa1.CrystalReportViewer1.ReportSource = rptdoc
                Frmreporte_Informe_etapa1.Show()
                'Frmreporte_Informe_etapa1.Dispose()

            Case "Etapa2"
                rptdoc = New Crystal_Informe_2etapa
                rptdoc.SetDataSource(dt)
                Frmreporte_Informe_etapa2.CrystalReportViewer1.ReportSource = rptdoc
                Frmreporte_Informe_etapa2.Show()
                'Frmreporte_Informe_etapa2.Dispose()

            Case "Etapa3"

                rptdoc = New Crystal_Informe_3etapa
                rptdoc.SetDataSource(dt)
                Frmreporte_Informe_etapa3.CrystalReportViewer1.ReportSource = rptdoc
                Frmreporte_Informe_etapa3.Show()
                'Frmreporte_Informe_etapa3.Dispose()


            Case "Libreta"

                rptdoc = New Crystal_libreta
                rptdoc.SetDataSource(dt)
                Frmreporte_libreta.CrystalReportViewer1.ReportSource = rptdoc
                Frmreporte_libreta.Show()

            Case Else
                MsgBox("debe seleccionar un Informe")
        End Select



    End Sub

    Private Sub btn_salir_emision_lib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_emision_lib.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Select Case Cbo_etapas.SelectedText
            Case Is = "Etapa 1°"

                Frmreporte_Informe_etapa1.Show()
            Case Is = "Etapa 2°"
                Frmreporte_Informe_etapa2.Show()

            Case Is = "Etapa 3°"
                Frmreporte_Informe_etapa2.Show()

            Case Is = "Libreta"
                Frmreporte_libreta.Show()

            Case Else
                MsgBox("debe seleccionar un Informe")


        End Select
    End Sub
End Class