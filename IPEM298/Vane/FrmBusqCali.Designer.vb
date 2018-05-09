<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqCali
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqCali))
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.drgBuscarAlu = New System.Windows.Forms.DataGridView()
        Me.Btn_aceptar_buscacalif = New System.Windows.Forms.Button()
        CType(Me.drgBuscarAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(388, 162)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(53, 37)
        Me.cmdSalir.TabIndex = 17
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Elija el alumno a consultar"
        '
        'drgBuscarAlu
        '
        Me.drgBuscarAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgBuscarAlu.Location = New System.Drawing.Point(6, 22)
        Me.drgBuscarAlu.MultiSelect = False
        Me.drgBuscarAlu.Name = "drgBuscarAlu"
        Me.drgBuscarAlu.ReadOnly = True
        Me.drgBuscarAlu.RowHeadersVisible = False
        Me.drgBuscarAlu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgBuscarAlu.Size = New System.Drawing.Size(435, 134)
        Me.drgBuscarAlu.TabIndex = 14
        '
        'Btn_aceptar_buscacalif
        '
        Me.Btn_aceptar_buscacalif.Image = CType(resources.GetObject("Btn_aceptar_buscacalif.Image"), System.Drawing.Image)
        Me.Btn_aceptar_buscacalif.Location = New System.Drawing.Point(333, 162)
        Me.Btn_aceptar_buscacalif.Name = "Btn_aceptar_buscacalif"
        Me.Btn_aceptar_buscacalif.Size = New System.Drawing.Size(49, 37)
        Me.Btn_aceptar_buscacalif.TabIndex = 18
        Me.Btn_aceptar_buscacalif.UseVisualStyleBackColor = True
        '
        'FrmBusqCali
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_aceptar_buscacalif)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.drgBuscarAlu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqCali"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Alumno"
        CType(Me.drgBuscarAlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents drgBuscarAlu As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_aceptar_buscacalif As System.Windows.Forms.Button
End Class
