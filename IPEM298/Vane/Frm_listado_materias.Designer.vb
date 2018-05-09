<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_listado_materias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_listado_materias))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_todasmaterias = New System.Windows.Forms.DataGridView()
        Me.Btn_volver_listmat = New System.Windows.Forms.Button()
        CType(Me.Dg_todasmaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de materias"
        '
        'Dg_todasmaterias
        '
        Me.Dg_todasmaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_todasmaterias.Location = New System.Drawing.Point(12, 25)
        Me.Dg_todasmaterias.Name = "Dg_todasmaterias"
        Me.Dg_todasmaterias.RowHeadersVisible = False
        Me.Dg_todasmaterias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_todasmaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_todasmaterias.Size = New System.Drawing.Size(305, 152)
        Me.Dg_todasmaterias.TabIndex = 1
        '
        'Btn_volver_listmat
        '
        Me.Btn_volver_listmat.Image = CType(resources.GetObject("Btn_volver_listmat.Image"), System.Drawing.Image)
        Me.Btn_volver_listmat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_listmat.Location = New System.Drawing.Point(248, 181)
        Me.Btn_volver_listmat.Name = "Btn_volver_listmat"
        Me.Btn_volver_listmat.Size = New System.Drawing.Size(69, 28)
        Me.Btn_volver_listmat.TabIndex = 2
        Me.Btn_volver_listmat.Text = "Volver"
        Me.Btn_volver_listmat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_listmat.UseVisualStyleBackColor = True
        '
        'Frm_listado_materias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 208)
        Me.Controls.Add(Me.Btn_volver_listmat)
        Me.Controls.Add(Me.Dg_todasmaterias)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_listado_materias"
        Me.Text = "Listado de materias"
        CType(Me.Dg_todasmaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dg_todasmaterias As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_volver_listmat As System.Windows.Forms.Button
End Class
