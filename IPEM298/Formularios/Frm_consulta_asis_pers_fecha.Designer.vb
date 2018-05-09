<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consulta_asis_pers_fecha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consulta_asis_pers_fecha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_asis_pers_fecha = New System.Windows.Forms.DataGridView()
        Me.Btn_cons_asis_pers_fecha = New System.Windows.Forms.Button()
        Me.Btn_imprimir_asis_pers_fecha = New System.Windows.Forms.Button()
        CType(Me.Dg_asis_pers_fecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Dg_asis_pers_fecha
        '
        Me.Dg_asis_pers_fecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_asis_pers_fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_asis_pers_fecha.Enabled = False
        Me.Dg_asis_pers_fecha.Location = New System.Drawing.Point(12, 42)
        Me.Dg_asis_pers_fecha.MultiSelect = False
        Me.Dg_asis_pers_fecha.Name = "Dg_asis_pers_fecha"
        Me.Dg_asis_pers_fecha.RowHeadersVisible = False
        Me.Dg_asis_pers_fecha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_asis_pers_fecha.Size = New System.Drawing.Size(434, 130)
        Me.Dg_asis_pers_fecha.TabIndex = 1
        '
        'Btn_cons_asis_pers_fecha
        '
        Me.Btn_cons_asis_pers_fecha.Image = CType(resources.GetObject("Btn_cons_asis_pers_fecha.Image"), System.Drawing.Image)
        Me.Btn_cons_asis_pers_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_cons_asis_pers_fecha.Location = New System.Drawing.Point(370, 178)
        Me.Btn_cons_asis_pers_fecha.Name = "Btn_cons_asis_pers_fecha"
        Me.Btn_cons_asis_pers_fecha.Size = New System.Drawing.Size(76, 32)
        Me.Btn_cons_asis_pers_fecha.TabIndex = 29
        Me.Btn_cons_asis_pers_fecha.Text = "Volver"
        Me.Btn_cons_asis_pers_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_cons_asis_pers_fecha.UseVisualStyleBackColor = True
        '
        'Btn_imprimir_asis_pers_fecha
        '
        Me.Btn_imprimir_asis_pers_fecha.Enabled = False
        Me.Btn_imprimir_asis_pers_fecha.Image = CType(resources.GetObject("Btn_imprimir_asis_pers_fecha.Image"), System.Drawing.Image)
        Me.Btn_imprimir_asis_pers_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_imprimir_asis_pers_fecha.Location = New System.Drawing.Point(279, 178)
        Me.Btn_imprimir_asis_pers_fecha.Name = "Btn_imprimir_asis_pers_fecha"
        Me.Btn_imprimir_asis_pers_fecha.Size = New System.Drawing.Size(85, 32)
        Me.Btn_imprimir_asis_pers_fecha.TabIndex = 30
        Me.Btn_imprimir_asis_pers_fecha.Text = "Imprimir"
        Me.Btn_imprimir_asis_pers_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_imprimir_asis_pers_fecha.UseVisualStyleBackColor = True
        Me.Btn_imprimir_asis_pers_fecha.Visible = False
        '
        'Frm_consulta_asis_pers_fecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 218)
        Me.Controls.Add(Me.Btn_imprimir_asis_pers_fecha)
        Me.Controls.Add(Me.Btn_cons_asis_pers_fecha)
        Me.Controls.Add(Me.Dg_asis_pers_fecha)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_consulta_asis_pers_fecha"
        Me.Text = "Frm_consulta_asis_pers_fecha"
        CType(Me.Dg_asis_pers_fecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg_asis_pers_fecha As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_cons_asis_pers_fecha As System.Windows.Forms.Button
    Friend WithEvents Btn_imprimir_asis_pers_fecha As System.Windows.Forms.Button
End Class
