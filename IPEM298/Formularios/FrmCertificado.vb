Public Class FrmCertificado
    Dim DataContext As New DataClassesipem2DataContext
    Dim datacontextvistas As New DataClassesdevistasDataContext
    Dim id As Integer

    Private Sub FrmCertificado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TxtApellido.Enabled = False
        'TxtDivisión.Enabled = False
        'TextBox1.Enabled = False
        'TxtNombre.Enabled = False
        txtDNI.Select()


    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        If txtDNI.Text = "" Then

            MsgBox("Ingrese un DNI para la búqueda")
        Else

            Try
                Dim BuscaAlumno = (From H In datacontextvistas.vista_alum_xcurso Where H.DNI_alu = CInt(txtDNI.Text)).ToList()(0)
                If BuscaAlumno.nombre_curso = "IN" Then
                    MsgBox("El alumno ingresado no posee condiciòn de regular")
                    txtDNI.Clear()
                    txtDNI.Select()
                    Exit Sub
                End If
                Dim consulta = From H In datacontextvistas.vista_alum_xcurso Select H.apellido_alu, H.DNI_alu Where DNI_alu = CInt(txtDNI.Text)
                TxtNombre.Text = BuscaAlumno.nombre_alu
                TxtApellido.Text = BuscaAlumno.apellido_alu
                TxtDivisión.Text = BuscaAlumno.nombre_curso
                id = BuscaAlumno.id_alumno
                'txtId_personal.Text = BuscaHorario.id_personal


            Catch ex As Exception
                MsgBox("Registro Inexistente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Búsqueda de Registro")


            End Try
            'pasoconsulta(consulta)
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cbotipo.SelectedIndex = 1 Then
        '    TextBox1.Enabled = False
        'Else
        '    TextBox1.Enabled = True
        'End If
    End Sub

    Public cr As New Crystal_cert_alum_reg
    Public Sub pasoconsulta(ByVal consulta As System.Linq.IOrderedQueryable)
        Dim consulta1 = consulta
        cr.SetDataSource(consulta1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Frm_reporte_cert_alum.Show()
        Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub cmdImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        
        Dim finas As New Frm_reporte_cert_alum
        Dim rptalum_reg As New Crystal_cert_alum_reg

        'copia los textbox
        Try
            Dim copiatextodni As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptalum_reg.ReportDefinition.ReportObjects.Item("crtext_dni"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextodni.Text = Me.txtDNI.Text

            Dim copiatextonombre As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptalum_reg.ReportDefinition.ReportObjects.Item("crtext_nombre"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextonombre.Text = Me.TxtNombre.Text

            Dim copiatextoapellido As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptalum_reg.ReportDefinition.ReportObjects.Item("crtext_apellido"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextoapellido.Text = Me.TxtApellido.Text

            Dim copiatextodivision As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptalum_reg.ReportDefinition.ReportObjects.Item("crtext_division"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextodivision.Text = Me.TxtDivisión.Text

            Dim copiatextoescrito As CrystalDecisions.CrystalReports.Engine.TextObject = CType(rptalum_reg.ReportDefinition.ReportObjects.Item("crtext_empresa"), CrystalDecisions.CrystalReports.Engine.TextObject)
            copiatextoescrito.Text = TextBox1.Text


        Catch ex As Exception

            If TextBox1.Text = "" Then

                'MsgBox("debe ingresar una empresa")
                MsgBox("Debe ingresar un destinatario!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Advertencia")
                Exit Sub
            End If

        End Try


        'Dim dt As New DSetVistas

        Dim rptdoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        rptdoc = New Crystal_cert_alum_reg
        'rptalum_reg.SetDataSource(dt)

        Frm_reporte_cert_alum.CrystalReportViewer1.ReportSource = rptalum_reg
        Frm_reporte_cert_alum.ShowDialog()
        Frm_reporte_cert_alum.Dispose()


    End Sub


End Class