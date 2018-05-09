<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstadisticaNotasxMateria
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstadisticaNotasxMateria))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMateria = New System.Windows.Forms.ComboBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.Btn_salir_est_notasxmateria = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(143, 9)
        Me.Chart1.Name = "Chart1"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(387, 319)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
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
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Materia"
        '
        'cboMateria
        '
        Me.cboMateria.FormattingEnabled = True
        Me.cboMateria.Items.AddRange(New Object() {"lengua", "matematica", "geografia"})
        Me.cboMateria.Location = New System.Drawing.Point(15, 28)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Size = New System.Drawing.Size(100, 21)
        Me.cboMateria.TabIndex = 25
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
        'Btn_salir_est_notasxmateria
        '
        Me.Btn_salir_est_notasxmateria.Image = CType(resources.GetObject("Btn_salir_est_notasxmateria.Image"), System.Drawing.Image)
        Me.Btn_salir_est_notasxmateria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_salir_est_notasxmateria.Location = New System.Drawing.Point(15, 162)
        Me.Btn_salir_est_notasxmateria.Name = "Btn_salir_est_notasxmateria"
        Me.Btn_salir_est_notasxmateria.Size = New System.Drawing.Size(100, 40)
        Me.Btn_salir_est_notasxmateria.TabIndex = 34
        Me.Btn_salir_est_notasxmateria.Text = "Salir"
        Me.Btn_salir_est_notasxmateria.UseVisualStyleBackColor = True
        '
        'FrmEstadisticaNotasxMateria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 343)
        Me.Controls.Add(Me.Btn_salir_est_notasxmateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboMateria)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FrmEstadisticaNotasxMateria"
        Me.Text = "FrmEstadisticaNotasxMateria"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboMateria As System.Windows.Forms.ComboBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCargar As System.Windows.Forms.Button
    Friend WithEvents Btn_salir_est_notasxmateria As System.Windows.Forms.Button
End Class
