<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqAlu1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqAlu1))
        Me.drgBuscarAlu = New System.Windows.Forms.DataGridView()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Btn_aceptar_buscaalu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.drgBuscarAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'drgBuscarAlu
        '
        Me.drgBuscarAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgBuscarAlu.Location = New System.Drawing.Point(12, 25)
        Me.drgBuscarAlu.MultiSelect = False
        Me.drgBuscarAlu.Name = "drgBuscarAlu"
        Me.drgBuscarAlu.ReadOnly = True
        Me.drgBuscarAlu.RowHeadersVisible = False
        Me.drgBuscarAlu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgBuscarAlu.Size = New System.Drawing.Size(435, 134)
        Me.drgBuscarAlu.TabIndex = 2
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(396, 165)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(53, 37)
        Me.cmdSalir.TabIndex = 5
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Btn_aceptar_buscaalu
        '
        Me.Btn_aceptar_buscaalu.Image = CType(resources.GetObject("Btn_aceptar_buscaalu.Image"), System.Drawing.Image)
        Me.Btn_aceptar_buscaalu.Location = New System.Drawing.Point(341, 165)
        Me.Btn_aceptar_buscaalu.Name = "Btn_aceptar_buscaalu"
        Me.Btn_aceptar_buscaalu.Size = New System.Drawing.Size(49, 37)
        Me.Btn_aceptar_buscaalu.TabIndex = 14
        Me.Btn_aceptar_buscaalu.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Elija un alumno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmBusqAlu1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_aceptar_buscaalu)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.drgBuscarAlu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqAlu1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Alumno"
        CType(Me.drgBuscarAlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents drgBuscarAlu As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Btn_aceptar_buscaalu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
