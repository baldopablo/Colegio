Public Class Frmreporte_compr_inscrip
    'Dim datacontextvistas As New DataClassesdevistasDataContext
    'Public cr As New Crystal_Compr_Inscrip
    Private Sub Frmreporte_compr_inscrip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    'TODO: esta línea de código carga datos en la tabla 'DSetVistas.vista_alum_xcurso' Puede moverla o quitarla según sea necesario.


        'Dim alu = From d In datacontextvistas.vista_alum_xcurso Select d.apellido_alu, d.DNI_alu, d.especialidad, d.fecha_inscripcion_alu, d.id_alumno, d.nombre_alu, d.nombre_curso, d.turno_textbox Where id_alumno = 1
        'Dim alu1 = alu
        ''    'cr.SetDataSource(alu1)
        ''    'Me.Vista_alum_xcursoTableAdapter.Fill(alu1)

        Me.Vista_alum_xcursoTableAdapter.Fill(Me.DSetVistas.vista_alum_xcurso)

        'Dim rpt As New Crystal_Compr_Inscrip
        'rpt.SetDataSource(alu1)

        'CrystalReportViewer1.ReportSource = rpt

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class