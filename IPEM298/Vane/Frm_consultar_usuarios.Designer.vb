<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_consultar_usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_consultar_usuarios))
        Me.Btn_volver_listusuarios = New System.Windows.Forms.Button()
        Me.Dg_todosusuarios = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dg_todosusuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_volver_listusuarios
        '
        Me.Btn_volver_listusuarios.Image = CType(resources.GetObject("Btn_volver_listusuarios.Image"), System.Drawing.Image)
        Me.Btn_volver_listusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_volver_listusuarios.Location = New System.Drawing.Point(248, 183)
        Me.Btn_volver_listusuarios.Name = "Btn_volver_listusuarios"
        Me.Btn_volver_listusuarios.Size = New System.Drawing.Size(69, 28)
        Me.Btn_volver_listusuarios.TabIndex = 5
        Me.Btn_volver_listusuarios.Text = "Volver"
        Me.Btn_volver_listusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_volver_listusuarios.UseVisualStyleBackColor = True
        '
        'Dg_todosusuarios
        '
        Me.Dg_todosusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_todosusuarios.Location = New System.Drawing.Point(12, 25)
        Me.Dg_todosusuarios.Name = "Dg_todosusuarios"
        Me.Dg_todosusuarios.RowHeadersVisible = False
        Me.Dg_todosusuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Dg_todosusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_todosusuarios.Size = New System.Drawing.Size(305, 152)
        Me.Dg_todosusuarios.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado de usuarios"
        '
        'Frm_consultar_usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 219)
        Me.Controls.Add(Me.Btn_volver_listusuarios)
        Me.Controls.Add(Me.Dg_todosusuarios)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frm_consultar_usuarios"
        Me.Text = "Frm_consultar_usuarios"
        CType(Me.Dg_todosusuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_volver_listusuarios As System.Windows.Forms.Button
    Friend WithEvents Dg_todosusuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
