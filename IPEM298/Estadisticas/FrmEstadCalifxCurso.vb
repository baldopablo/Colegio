﻿Public Class FrmEstadCalifxCurso
    Dim dataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext

    'LOAD DEL FORM
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim combo = From M In dataContext.Curso Select M.id_curso, M.nombre_curso
        Me.cboCurso.DataSource = combo
        Me.cboCurso.DisplayMember = "nombre_curso"
        Me.cboCurso.ValueMember = "id_curso"
        Me.cboCurso.SelectedIndex = -1
    End Sub

    'BOTON CARGAR
    Private Sub cmdCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargar.Click
        Select Case cbotipo.SelectedIndex
            Case 0
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Pie)
            Case 1
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Column)
            Case 2
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Point)
            Case 3
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Bar)
            Case 4
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Polar)
            Case 5
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Range)
            Case Else
                TipoGrafico(DataVisualization.Charting.SeriesChartType.Pyramid)

        End Select
    End Sub

    'ELIGE EL TIPO DE GRAFICO
    Sub TipoGrafico(ByVal grafico As DataVisualization.Charting.SeriesChartType)

        Dim sql = From s In datacontextvistas.VistaCalifxCurso Select s.id_curso, s.nombre_curso, s.calif_definitiva, s.Total Where id_curso = CInt(cboCurso.SelectedValue)
        Chart1.Series(0).Points.Clear()
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(0).ChartType = grafico
        Chart1.Series(0)("PieLabelStyle") = "Inside"
        Chart1.Series(0)("PieDrawingStyle") = "Concave"
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        Chart1.Series(0).Color = Color.RoyalBlue
        Chart1.Series(0).XValueMember = "calif_definitiva"
        Chart1.Series(0).YValueMembers = "Total"
        Chart1.Series(0)("DrawingStyle") = "Wedge"
        Chart1.Series(0)("PointWidth") = "0.6"
        Chart1.BorderSkin.SkinStyle = DataVisualization.Charting.BorderSkinStyle.Emboss
        Chart1.Series(0).IsValueShownAsLabel = True
        'Chart1.Series(0).LabelFormat = "P0"
        Chart1.Series(0)("LabelStyle") = "Bottom"
        Chart1.Series(0).Font = New Font("Times New Roman", 7)
        Chart1.BackColor = Color.White
        Chart1.BackSecondaryColor = Color.SkyBlue
        Chart1.BackGradientStyle = DataVisualization.Charting.GradientStyle.TopBottom

        Chart1.ChartAreas(0).BackColor = Color.White
        Chart1.ChartAreas(0).BackSecondaryColor = Color.SkyBlue
        Chart1.ChartAreas(0).BackGradientStyle = DataVisualization.Charting.GradientStyle.DiagonalLeft
        Chart1.ChartAreas(0).ShadowOffset = 3

        Chart1.ChartAreas(0).AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        Chart1.ChartAreas(0).AxisX.MinorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet

        Chart1.ChartAreas(0).AxisY.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet
        Chart1.ChartAreas(0).AxisY.MinorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.NotSet

        Chart1.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 8)
        Chart1.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 8)
        Chart1.ChartAreas(0).AxisY.LabelStyle.Format = "P0"
        Chart1.DataSource = sql
    End Sub

    'BOTON SALIR
    Private Sub Btn_salir_est_califxcurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_salir_est_califxcurso.Click
        Me.Close()
    End Sub
End Class