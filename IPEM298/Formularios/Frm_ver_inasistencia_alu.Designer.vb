<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ver_inasistencia_alu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ver_inasistencia_alu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_nombreyapellido_inasis_alu = New System.Windows.Forms.TextBox()
        Me.Btn_volver_inasis_alu = New System.Windows.Forms.Button()
        Me.Btn_eliminar_inasis_alu = New System.Windows.Forms.Button()
        Me.Dg_ver_inasis_alu = New System.Windows.Forms.DataGridView()
        CType(Me.Dg_ver_inasis_alu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Alumno"
        '
        'Tb_nombreyapellido_inasis_alu
        '
        Me.Tb_nombreyapellido_inasis_alu.Enabled = False
        Me.Tb_nombreyapellido_inasis_alu.Location = New System.Drawing.Point(69, 8)
        Me.Tb_nombreyapellido_inasis_alu.Name = "Tb_nombreyapellido_inasis_alu"
        Me.Tb_nombreyapellido_inasis_alu.Size = New System.Drawing.Size(143, 20)
        Me.Tb_nombreyapellido_inasis_alu.TabIndex = 34
        '
        'Btn_volver_inasis_alu
        '
        Me.Btn_volver_inasis_alu.Image = CType(resources.GetObject("Btn_volver_inasis_alu.Image"), System.Drawing.Image)
        Me.Btn_volver_inasis_alu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_inasis_alu.Location = New System.Drawing.Point(300, 1)
        Me.Btn_volver_inasis_alu.Name = "Btn_volver_inasis_alu"
        Me.Btn_volver_inasis_alu.Size = New System.Drawing.Size(76, 32)
        Me.Btn_volver_inasis_alu.TabIndex = 33
        Me.Btn_volver_inasis_alu.Text = "Volver"
        Me.Btn_volver_inasis_alu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_inasis_alu.UseVisualStyleBackColor = True
        '
        'Btn_eliminar_inasis_alu
        '
        Me.Btn_eliminar_inasis_alu.Image = CType(resources.GetObject("Btn_eliminar_inasis_alu.Image"), System.Drawing.Image)
        Me.Btn_eliminar_inasis_alu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_eliminar_inasis_alu.Location = New System.Drawing.Point(218, 1)
        Me.Btn_eliminar_inasis_alu.Name = "Btn_eliminar_inasis_alu"
        Me.Btn_eliminar_inasis_alu.Size = New System.Drawing.Size(76, 32)
        Me.Btn_eliminar_inasis_alu.TabIndex = 32
        Me.Btn_eliminar_inasis_alu.Text = "Eliminar"
        Me.Btn_eliminar_inasis_alu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_eliminar_inasis_alu.UseVisualStyleBackColor = True
        '
        'Dg_ver_inasis_alu
        '
        Me.Dg_ver_inasis_alu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_ver_inasis_alu.Location = New System.Drawing.Point(12, 41)
        Me.Dg_ver_inasis_alu.MultiSelect = False
        Me.Dg_ver_inasis_alu.Name = "Dg_ver_inasis_alu"
        Me.Dg_ver_inasis_alu.ReadOnly = True
        Me.Dg_ver_inasis_alu.RowHeadersVisible = False
        Me.Dg_ver_inasis_alu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_ver_inasis_alu.Size = New System.Drawing.Size(370, 150)
        Me.Dg_ver_inasis_alu.TabIndex = 31
        '
        'Frm_ver_inasistencia_alu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_nombreyapellido_inasis_alu)
        Me.Controls.Add(Me.Btn_volver_inasis_alu)
        Me.Controls.Add(Me.Btn_eliminar_inasis_alu)
        Me.Controls.Add(Me.Dg_ver_inasis_alu)
        Me.Name = "Frm_ver_inasistencia_alu"
        Me.Text = "Editar inasistencias del alumno"
        CType(Me.Dg_ver_inasis_alu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tb_nombreyapellido_inasis_alu As System.Windows.Forms.TextBox
    Friend WithEvents Btn_volver_inasis_alu As System.Windows.Forms.Button
    Friend WithEvents Btn_eliminar_inasis_alu As System.Windows.Forms.Button
    Friend WithEvents Dg_ver_inasis_alu As System.Windows.Forms.DataGridView
End Class
