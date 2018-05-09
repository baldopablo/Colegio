Public Class Frm_Generar_Planilla_Inasistencia
    Dim datacontext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    Dim vble_mes As Integer
    Dim vble_dni As Integer

    'LOAD DEL FORM
    Private Sub Frm_Generar_Planilla_Inasistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    'FUNCION QUE CONTIENE LAS EQUIVALENCIAS ENTRE HS CAT Y OBLIGACIONES
    Function equivalencia_obligaciones(ByVal tomar_de As Integer)

        Select Case CInt(tomar_de)
            Case 0
                Return 0
            Case 1
                Return 0
            Case 2
                Return 1
            Case 3
                Return 2
            Case 4
                Return 3
            Case 5
                Return 4
            Case 6
                Return 4
            Case 7
                Return 5
            Case 8
                Return 6
            Case 9
                Return 7
            Case 10
                Return 8
            Case 11
                Return 8
            Case 12
                Return 9
            Case 13
                Return 10
            Case 14
                Return 11
            Case 15
                Return 12
            Case 16
                Return 12
            Case 17
                Return 13
            Case 18
                Return 14
            Case 19
                Return 15
            Case 20
                Return 16
            Case 21
                Return 16
            Case 22
                Return 17
            Case 23
                Return 18
            Case 24
                Return 19
            Case 25
                Return 20
            Case 26
                Return 20
            Case 27
                Return 21
            Case 28
                Return 22
            Case 29
                Return 23
            Case 30
                Return 24
            Case 31
                Return 24
            Case Else
                Return 99
        End Select
    End Function

    'ARMA Y CARGA LA PLANILLA DE TODOS LOS DOCENTES
    Public Sub cargargrilla()
        'Craga las columnas de datos
        Dg_generar_planilla.Columns.Clear()
        Dg_generar_planilla.AutoGenerateColumns = False

        Dg_generar_planilla.Columns.Add("DNI_pers", "DNI")
        Dg_generar_planilla.Columns(0).DataPropertyName = "DNI_pers"

        Dg_generar_planilla.Columns.Add("apelliido_pers", "Apellido")
        Dg_generar_planilla.Columns(1).DataPropertyName = "apelliido_pers"

        Dg_generar_planilla.Columns.Add("nombre_pers", "Nombre")
        Dg_generar_planilla.Columns(2).DataPropertyName = "nombre_pers"

        Dim datos = (From d In datacontext.Personal Select d.DNI_pers, d.apelliido_pers, d.nombre_pers, d.id_personal, d.puesto_pers Where puesto_pers <> "Preceptor" And puesto_pers <> "Directivo").ToList
        Dg_generar_planilla.DataSource = datos


        'Carga las columnas calculadas
        Dim contador = (From c In datacontext.Personal Select c.id_personal, c.puesto_pers Where puesto_pers <> "Preceptor" And puesto_pers <> "Directivo").Count
        Dim i As Integer
        Dim vbletemp_id_pers As Integer

        Dim vble_text As Integer

        Dg_generar_planilla.Columns.Add("hs_cat", "Hs a cumplir")
        Dg_generar_planilla.Columns(3).DataPropertyName = "hs_cat"

        Dg_generar_planilla.Columns.Add("obl", "Obligaciones")
        Dg_generar_planilla.Columns(4).DataPropertyName = "obl"

        Dg_generar_planilla.Columns.Add("inasis_cat", "Hs incumplidas")
        Dg_generar_planilla.Columns(5).DataPropertyName = "inasis_cat"

        Dg_generar_planilla.Columns.Add("inasis_oblig", "Oblig. incumplidas")
        Dg_generar_planilla.Columns(6).DataPropertyName = "inasis_oblig"

        Dg_generar_planilla.Columns.Add("inasis_permitidas", "Faltas permitidas(oblig)")
        Dg_generar_planilla.Columns(7).DataPropertyName = "inasis_permitidas"


        For i = 0 To contador - 1
            'Carga las horas catedras a cumplir
            vble_dni = Dg_generar_planilla.Item(0, i).Value
            Dim igual = (From a In datacontext.Personal Select a.id_personal, a.DNI_pers Where DNI_pers = vble_dni).ToList()(0)
            vbletemp_id_pers = igual.id_personal
            Dg_generar_planilla.Item(3, i).Value = (From j In datacontext.Horario_personal Select j.id_personal Where id_personal = vbletemp_id_pers).Count

            'Carga las obligaciones a cumplir, llama a la funcion para convertir de hs cat a oblig
            vble_text = (equivalencia_obligaciones(Dg_generar_planilla.Item(3, i).Value))
            Dg_generar_planilla.Item(4, i).Value = vble_text

            'Carga las inasistencias en hs catedra
            Dg_generar_planilla.Item(5, i).Value = (From x In datacontextvistas.Vista_inasistencia_personal Select x.DNI_pers, x.fecha_asistencia Where DNI_pers = vble_dni And fecha_asistencia.Month = vble_mes).Count

            'Carga las inasistencias en obligaciones
            vble_text = equivalencia_obligaciones(Dg_generar_planilla.Item(5, i).Value)
            Dg_generar_planilla.Item(6, i).Value = vble_text

            'Carga las inasistencias permitidas expresada en obligaciones
            Dg_generar_planilla.Item(7, i).Value = Dg_generar_planilla.Item(4, i).Value * 10 / 100
        Next

    End Sub

    'BOTON IMPRIMIR
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_imprimir_generar_planilla.Click

        Dim dt As New DataSet1
        For Each dr As DataGridViewRow In Me.Dg_generar_planilla.Rows
            dt.DataTableInasisGrupal.AddDataTableInasisGrupalRow(dr.Cells("DNI_pers").Value, dr.Cells("apelliido_pers").Value, dr.Cells("nombre_pers").Value, dr.Cells("hs_cat").Value, dr.Cells("obl").Value, dr.Cells("inasis_cat").Value, dr.Cells("inasis_oblig").Value, dr.Cells("inasis_permitidas").Value)
        Next
        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New Crystal_inas_grupal
        rptdoc.SetDataSource(dt)
        Frmreporte_inas_grupal.CrystalReportViewer1.ReportSource = rptdoc
        Frmreporte_inas_grupal.ShowDialog()
        Frmreporte_inas_grupal.Dispose()
    End Sub


    'CLICK SOBRE ITEM DEL COMBO
    Private Sub Cbo_mes_planilla_inasistencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_mes_planilla_inasistencia.SelectedIndexChanged
        Select Case Cbo_mes_planilla_inasistencia.Text
            Case "Enero"
                vble_mes = 1
            Case "Febrero"
                vble_mes = 2
            Case "Marzo"
                vble_mes = 3
            Case "Abril"
                vble_mes = 4
            Case "Mayo"
                vble_mes = 5
            Case "Junio"
                vble_mes = 6
            Case "julio"
                vble_mes = 7
            Case "Agosto"
                vble_mes = 8
            Case "Septiembre"
                vble_mes = 9
            Case "Octubre"
                vble_mes = 10
            Case "Noviembre"
                vble_mes = 11
            Case "Diciembre"
                vble_mes = 12
        End Select
        cargargrilla()
        Btn_imprimir_generar_planilla.Enabled = True
    End Sub

    'BOTON VOLVER
    Private Sub Btn_volver_generar_planilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_volver_generar_planilla.Click
        Me.Close()
    End Sub
End Class