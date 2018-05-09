<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_emision_libretas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_emision_libretas))
        Me.Dg_libreta = New System.Windows.Forms.DataGridView()
        Me.Cmb_turno_asis_alu = New System.Windows.Forms.ComboBox()
        Me.Cmb_curso_asis_alu = New System.Windows.Forms.ComboBox()
        Me.Btn_generar_emision_lib = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_salir_emision_lib = New System.Windows.Forms.Button()
        Me.Cbo_etapas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Dg_libreta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_libreta
        '
        Me.Dg_libreta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_libreta.Location = New System.Drawing.Point(24, 52)
        Me.Dg_libreta.Name = "Dg_libreta"
        Me.Dg_libreta.Size = New System.Drawing.Size(536, 22)
        Me.Dg_libreta.TabIndex = 0
        Me.Dg_libreta.Visible = False
        '
        'Cmb_turno_asis_alu
        '
        Me.Cmb_turno_asis_alu.FormattingEnabled = True
        Me.Cmb_turno_asis_alu.Items.AddRange(New Object() {"Mañana", "Tarde", "Noche"})
        Me.Cmb_turno_asis_alu.Location = New System.Drawing.Point(24, 25)
        Me.Cmb_turno_asis_alu.Name = "Cmb_turno_asis_alu"
        Me.Cmb_turno_asis_alu.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_turno_asis_alu.TabIndex = 1
        '
        'Cmb_curso_asis_alu
        '
        Me.Cmb_curso_asis_alu.FormattingEnabled = True
        Me.Cmb_curso_asis_alu.Location = New System.Drawing.Point(151, 25)
        Me.Cmb_curso_asis_alu.Name = "Cmb_curso_asis_alu"
        Me.Cmb_curso_asis_alu.Size = New System.Drawing.Size(121, 21)
        Me.Cmb_curso_asis_alu.TabIndex = 2
        '
        'Btn_generar_emision_lib
        '
        Me.Btn_generar_emision_lib.Image = CType(resources.GetObject("Btn_generar_emision_lib.Image"), System.Drawing.Image)
        Me.Btn_generar_emision_lib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_generar_emision_lib.Location = New System.Drawing.Point(405, 9)
        Me.Btn_generar_emision_lib.Name = "Btn_generar_emision_lib"
        Me.Btn_generar_emision_lib.Size = New System.Drawing.Size(84, 37)
        Me.Btn_generar_emision_lib.TabIndex = 3
        Me.Btn_generar_emision_lib.Text = "Generar"
        Me.Btn_generar_emision_lib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_generar_emision_lib.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 149)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(488, 207)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Elija turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(148, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Elija curso"
        '
        'btn_salir_emision_lib
        '
        Me.btn_salir_emision_lib.Image = CType(resources.GetObject("btn_salir_emision_lib.Image"), System.Drawing.Image)
        Me.btn_salir_emision_lib.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_emision_lib.Location = New System.Drawing.Point(495, 9)
        Me.btn_salir_emision_lib.Name = "btn_salir_emision_lib"
        Me.btn_salir_emision_lib.Size = New System.Drawing.Size(65, 37)
        Me.btn_salir_emision_lib.TabIndex = 6
        Me.btn_salir_emision_lib.Text = "Salir"
        Me.btn_salir_emision_lib.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_emision_lib.UseVisualStyleBackColor = True
        '
        'Cbo_etapas
        '
        Me.Cbo_etapas.FormattingEnabled = True
        Me.Cbo_etapas.Items.AddRange(New Object() {"Etapa1", "Etapa2", "Etapa3", "Libreta"})
        Me.Cbo_etapas.Location = New System.Drawing.Point(278, 25)
        Me.Cbo_etapas.Name = "Cbo_etapas"
        Me.Cbo_etapas.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_etapas.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Elija Etapa"
        '
        'Frm_emision_libretas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 57)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cbo_etapas)
        Me.Controls.Add(Me.btn_salir_emision_lib)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_generar_emision_lib)
        Me.Controls.Add(Me.Cmb_curso_asis_alu)
        Me.Controls.Add(Me.Cmb_turno_asis_alu)
        Me.Controls.Add(Me.Dg_libreta)
        Me.Name = "Frm_emision_libretas"
        Me.Text = "Emisión de libretas"
        CType(Me.Dg_libreta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dg_libreta As System.Windows.Forms.DataGridView
    Friend WithEvents Cmb_turno_asis_alu As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_curso_asis_alu As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_generar_emision_lib As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_salir_emision_lib As System.Windows.Forms.Button
    Friend WithEvents Cbo_etapas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
