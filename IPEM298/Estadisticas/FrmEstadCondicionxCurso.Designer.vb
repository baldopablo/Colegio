<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadCondicionxCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadCondicionxCurso))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCurso = New System.Windows.Forms.ComboBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Btn_salir_est_condicionxcurso = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tipo de Grafico"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Curso"
        '
        'cboCurso
        '
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Items.AddRange(New Object() {"lengua", "matematica", "geografia"})
        Me.cboCurso.Location = New System.Drawing.Point(15, 28)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(100, 21)
        Me.cboCurso.TabIndex = 25
        '
        'cbotipo
        '
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Pie", "Column", "Point", "Bar", "Polar", "Range", "Pyramid"})
        Me.cbotipo.Location = New System.Drawing.Point(15, 74)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(100, 21)
        Me.cbotipo.TabIndex = 24
        '
        'cmdCargar
        '
        Me.cmdCargar.Image = CType(resources.GetObject("cmdCargar.Image"), System.Drawing.Image)
        Me.cmdCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCargar.Location = New System.Drawing.Point(15, 116)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(100, 40)
        Me.cmdCargar.TabIndex = 23
        Me.cmdCargar.Text = "Cargar "
        Me.cmdCargar.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(143, 9)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(387, 319)
        Me.Chart1.TabIndex = 28
        Me.Chart1.Text = "Chart1"
        '
        'Btn_salir_est_condicionxcurso
        '
        Me.Btn_salir_est_condicionxcurso.Image = CType(resources.GetObject("Btn_salir_est_condicionxcurso.Image"), System.Drawing.Image)
        Me.Btn_salir_est_condicionxcurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_salir_est_condicionxcurso.Location = New System.Drawing.Point(15, 162)
        Me.Btn_salir_est_condicionxcurso.Name = "Btn_salir_est_condicionxcurso"
        Me.Btn_salir_est_condicionxcurso.Size = New System.Drawing.Size(100, 40)
        Me.Btn_salir_est_condicionxcurso.TabIndex = 34
        Me.Btn_salir_est_condicionxcurso.Text = "Salir"
        Me.Btn_salir_est_condicionxcurso.UseVisualStyleBackColor = True
        '
        'FrmEstadCondicionxCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 343)
        Me.Controls.Add(Me.Btn_salir_est_condicionxcurso)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCurso)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.cmdCargar)
        Me.Name = "FrmEstadCondicionxCurso"
        Me.Text = "FrmEstadCondicionxCurso"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCargar As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Btn_salir_est_condicionxcurso As System.Windows.Forms.Button
End Class
