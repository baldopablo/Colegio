<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ver_Inasistencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ver_Inasistencia))
        Me.Dg_ver_inasis = New System.Windows.Forms.DataGridView()
        Me.Btn_eliminar_hs_personal = New System.Windows.Forms.Button()
        Me.Btn_volver_inasis_personal = New System.Windows.Forms.Button()
        Me.Tb_nombreyapellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg_ver_inasis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_ver_inasis
        '
        Me.Dg_ver_inasis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_ver_inasis.Location = New System.Drawing.Point(12, 37)
        Me.Dg_ver_inasis.MultiSelect = False
        Me.Dg_ver_inasis.Name = "Dg_ver_inasis"
        Me.Dg_ver_inasis.ReadOnly = True
        Me.Dg_ver_inasis.RowHeadersVisible = False
        Me.Dg_ver_inasis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_ver_inasis.Size = New System.Drawing.Size(370, 150)
        Me.Dg_ver_inasis.TabIndex = 0
        '
        'Btn_eliminar_hs_personal
        '
        Me.Btn_eliminar_hs_personal.Image = CType(resources.GetObject("Btn_eliminar_hs_personal.Image"), System.Drawing.Image)
        Me.Btn_eliminar_hs_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_eliminar_hs_personal.Location = New System.Drawing.Point(388, 37)
        Me.Btn_eliminar_hs_personal.Name = "Btn_eliminar_hs_personal"
        Me.Btn_eliminar_hs_personal.Size = New System.Drawing.Size(76, 32)
        Me.Btn_eliminar_hs_personal.TabIndex = 17
        Me.Btn_eliminar_hs_personal.Text = "Eliminar"
        Me.Btn_eliminar_hs_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_eliminar_hs_personal.UseVisualStyleBackColor = True
        '
        'Btn_volver_inasis_personal
        '
        Me.Btn_volver_inasis_personal.Image = CType(resources.GetObject("Btn_volver_inasis_personal.Image"), System.Drawing.Image)
        Me.Btn_volver_inasis_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_inasis_personal.Location = New System.Drawing.Point(388, 75)
        Me.Btn_volver_inasis_personal.Name = "Btn_volver_inasis_personal"
        Me.Btn_volver_inasis_personal.Size = New System.Drawing.Size(76, 32)
        Me.Btn_volver_inasis_personal.TabIndex = 28
        Me.Btn_volver_inasis_personal.Text = "Volver"
        Me.Btn_volver_inasis_personal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_inasis_personal.UseVisualStyleBackColor = True
        '
        'Tb_nombreyapellido
        '
        Me.Tb_nombreyapellido.Enabled = False
        Me.Tb_nombreyapellido.Location = New System.Drawing.Point(69, 6)
        Me.Tb_nombreyapellido.Name = "Tb_nombreyapellido"
        Me.Tb_nombreyapellido.Size = New System.Drawing.Size(143, 20)
        Me.Tb_nombreyapellido.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Docente"
        '
        'Frm_Ver_Inasistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 195)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_nombreyapellido)
        Me.Controls.Add(Me.Btn_volver_inasis_personal)
        Me.Controls.Add(Me.Btn_eliminar_hs_personal)
        Me.Controls.Add(Me.Dg_ver_inasis)
        Me.Name = "Frm_Ver_Inasistencia"
        Me.Text = "Eliminar ausencias"
        CType(Me.Dg_ver_inasis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dg_ver_inasis As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_eliminar_hs_personal As System.Windows.Forms.Button
    Friend WithEvents Btn_volver_inasis_personal As System.Windows.Forms.Button
    Friend WithEvents Tb_nombreyapellido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
