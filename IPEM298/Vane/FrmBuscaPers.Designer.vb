<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscaPers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscaPers))
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.drgBuscaPers = New System.Windows.Forms.DataGridView()
        Me.Btn_aceptar_buscapers = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.drgBuscaPers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSalir
        '
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.Location = New System.Drawing.Point(387, 165)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(53, 37)
        Me.cmdSalir.TabIndex = 11
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'drgBuscaPers
        '
        Me.drgBuscaPers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drgBuscaPers.Location = New System.Drawing.Point(8, 25)
        Me.drgBuscaPers.MultiSelect = False
        Me.drgBuscaPers.Name = "drgBuscaPers"
        Me.drgBuscaPers.ReadOnly = True
        Me.drgBuscaPers.RowHeadersVisible = False
        Me.drgBuscaPers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.drgBuscaPers.Size = New System.Drawing.Size(435, 134)
        Me.drgBuscaPers.TabIndex = 8
        '
        'Btn_aceptar_buscapers
        '
        Me.Btn_aceptar_buscapers.Image = CType(resources.GetObject("Btn_aceptar_buscapers.Image"), System.Drawing.Image)
        Me.Btn_aceptar_buscapers.Location = New System.Drawing.Point(332, 165)
        Me.Btn_aceptar_buscapers.Name = "Btn_aceptar_buscapers"
        Me.Btn_aceptar_buscapers.Size = New System.Drawing.Size(49, 37)
        Me.Btn_aceptar_buscapers.TabIndex = 13
        Me.Btn_aceptar_buscapers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Elija un docente"
        '
        'FrmBuscaPers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_aceptar_buscapers)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.drgBuscaPers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmBuscaPers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Personal"
        CType(Me.drgBuscaPers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents drgBuscaPers As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_aceptar_buscapers As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
