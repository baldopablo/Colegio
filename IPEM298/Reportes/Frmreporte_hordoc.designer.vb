<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmreporte_hordoc
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Cr_hordoc1 = New IPEM298.Cr_hordoc()
        Me.SuspendLayout()
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = 0
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.ReportSource = Me.Cr_hordoc1
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(972, 536)
        Me.CrystalReportViewer3.TabIndex = 0
        Me.CrystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frmreporte_hordoc
        '
        Me.ClientSize = New System.Drawing.Size(972, 536)
        Me.Controls.Add(Me.CrystalReportViewer3)
        Me.Name = "Frmreporte_hordoc"
        Me.Text = "Impresión de horario de personal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataSet1 As IPEM298.DataSet1
    Friend WithEvents Vista_horario_personal2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vista_horario_personalTableAdapter As IPEM298.DataSet1.vista_horario_personalDataTable
    Friend WithEvents TableAdapterManager As IPEM298.DataSet1
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Cr_hordoc1 As IPEM298.Cr_hordoc
End Class
