<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Generar_Planilla_Inasistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Generar_Planilla_Inasistencia))
        Me.Dg_generar_planilla = New System.Windows.Forms.DataGridView()
        Me.Btn_imprimir_generar_planilla = New System.Windows.Forms.Button()
        Me.Btn_volver_generar_planilla = New System.Windows.Forms.Button()
        Me.Cbo_mes_planilla_inasistencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg_generar_planilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_generar_planilla
        '
        Me.Dg_generar_planilla.AllowUserToAddRows = False
        Me.Dg_generar_planilla.AllowUserToDeleteRows = False
        Me.Dg_generar_planilla.AllowUserToOrderColumns = True
        Me.Dg_generar_planilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_generar_planilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_generar_planilla.Location = New System.Drawing.Point(12, 46)
        Me.Dg_generar_planilla.Name = "Dg_generar_planilla"
        Me.Dg_generar_planilla.RowHeadersVisible = False
        Me.Dg_generar_planilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_generar_planilla.Size = New System.Drawing.Size(721, 220)
        Me.Dg_generar_planilla.TabIndex = 0
        '
        'Btn_imprimir_generar_planilla
        '
        Me.Btn_imprimir_generar_planilla.Enabled = False
        Me.Btn_imprimir_generar_planilla.Image = CType(resources.GetObject("Btn_imprimir_generar_planilla.Image"), System.Drawing.Image)
        Me.Btn_imprimir_generar_planilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_imprimir_generar_planilla.Location = New System.Drawing.Point(415, 2)
        Me.Btn_imprimir_generar_planilla.Name = "Btn_imprimir_generar_planilla"
        Me.Btn_imprimir_generar_planilla.Size = New System.Drawing.Size(85, 37)
        Me.Btn_imprimir_generar_planilla.TabIndex = 1
        Me.Btn_imprimir_generar_planilla.Text = "Imprimir"
        Me.Btn_imprimir_generar_planilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_imprimir_generar_planilla.UseVisualStyleBackColor = True
        '
        'Btn_volver_generar_planilla
        '
        Me.Btn_volver_generar_planilla.Image = CType(resources.GetObject("Btn_volver_generar_planilla.Image"), System.Drawing.Image)
        Me.Btn_volver_generar_planilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_generar_planilla.Location = New System.Drawing.Point(506, 2)
        Me.Btn_volver_generar_planilla.Name = "Btn_volver_generar_planilla"
        Me.Btn_volver_generar_planilla.Size = New System.Drawing.Size(85, 37)
        Me.Btn_volver_generar_planilla.TabIndex = 2
        Me.Btn_volver_generar_planilla.Text = "Salir"
        Me.Btn_volver_generar_planilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_generar_planilla.UseVisualStyleBackColor = True
        '
        'Cbo_mes_planilla_inasistencia
        '
        Me.Cbo_mes_planilla_inasistencia.FormattingEnabled = True
        Me.Cbo_mes_planilla_inasistencia.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.Cbo_mes_planilla_inasistencia.Location = New System.Drawing.Point(288, 11)
        Me.Cbo_mes_planilla_inasistencia.Name = "Cbo_mes_planilla_inasistencia"
        Me.Cbo_mes_planilla_inasistencia.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_mes_planilla_inasistencia.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione el mes de inasistencias que quiere consultar"
        '
        'Frm_Generar_Planilla_Inasistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbo_mes_planilla_inasistencia)
        Me.Controls.Add(Me.Btn_volver_generar_planilla)
        Me.Controls.Add(Me.Btn_imprimir_generar_planilla)
        Me.Controls.Add(Me.Dg_generar_planilla)
        Me.Name = "Frm_Generar_Planilla_Inasistencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar planilla de inasistencia de docentes"
        CType(Me.Dg_generar_planilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dg_generar_planilla As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_imprimir_generar_planilla As System.Windows.Forms.Button
    Friend WithEvents Btn_volver_generar_planilla As System.Windows.Forms.Button
    Friend WithEvents Cbo_mes_planilla_inasistencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
