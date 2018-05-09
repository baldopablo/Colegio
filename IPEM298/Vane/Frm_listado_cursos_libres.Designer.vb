<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_listado_cursos_libres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_listado_cursos_libres))
        Me.Btn_volver_cursoslibres = New System.Windows.Forms.Button()
        Me.Dg_cursoslibres = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg_cursoslibres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_volver_cursoslibres
        '
        Me.Btn_volver_cursoslibres.Image = CType(resources.GetObject("Btn_volver_cursoslibres.Image"), System.Drawing.Image)
        Me.Btn_volver_cursoslibres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_cursoslibres.Location = New System.Drawing.Point(95, 320)
        Me.Btn_volver_cursoslibres.Name = "Btn_volver_cursoslibres"
        Me.Btn_volver_cursoslibres.Size = New System.Drawing.Size(69, 28)
        Me.Btn_volver_cursoslibres.TabIndex = 5
        Me.Btn_volver_cursoslibres.Text = "Volver"
        Me.Btn_volver_cursoslibres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_cursoslibres.UseVisualStyleBackColor = True
        '
        'Dg_cursoslibres
        '
        Me.Dg_cursoslibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_cursoslibres.Location = New System.Drawing.Point(47, 25)
        Me.Dg_cursoslibres.MultiSelect = False
        Me.Dg_cursoslibres.Name = "Dg_cursoslibres"
        Me.Dg_cursoslibres.ReadOnly = True
        Me.Dg_cursoslibres.RowHeadersVisible = False
        Me.Dg_cursoslibres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_cursoslibres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_cursoslibres.Size = New System.Drawing.Size(117, 289)
        Me.Dg_cursoslibres.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado de cursos libres"
        '
        'Frm_listado_cursos_libres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 351)
        Me.Controls.Add(Me.Btn_volver_cursoslibres)
        Me.Controls.Add(Me.Dg_cursoslibres)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_listado_cursos_libres"
        Me.Text = "Cursos libres"
        CType(Me.Dg_cursoslibres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_volver_cursoslibres As System.Windows.Forms.Button
    Friend WithEvents Dg_cursoslibres As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
