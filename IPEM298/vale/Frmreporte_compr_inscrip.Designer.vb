<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmreporte_compr_inscrip
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmreporte_compr_inscrip))
        Me.DSetVistas = New IPEM298.DSetVistas()
        Me.Vista_alum_xcursoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vista_alum_xcursoTableAdapter = New IPEM298.DSetVistasTableAdapters.vista_alum_xcursoTableAdapter()
        Me.TableAdapterManager = New IPEM298.DSetVistasTableAdapters.TableAdapterManager()
        Me.Vista_alum_xcursoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Vista_alum_xcursoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DSetVistas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista_alum_xcursoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vista_alum_xcursoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vista_alum_xcursoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSetVistas
        '
        Me.DSetVistas.DataSetName = "DSetVistas"
        Me.DSetVistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vista_alum_xcursoBindingSource
        '
        Me.Vista_alum_xcursoBindingSource.DataMember = "vista_alum_xcurso"
        Me.Vista_alum_xcursoBindingSource.DataSource = Me.DSetVistas
        '
        'Vista_alum_xcursoTableAdapter
        '
        Me.Vista_alum_xcursoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = IPEM298.DSetVistasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Vista_alum_xcursoBindingNavigator
        '
        Me.Vista_alum_xcursoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vista_alum_xcursoBindingNavigator.BindingSource = Me.Vista_alum_xcursoBindingSource
        Me.Vista_alum_xcursoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vista_alum_xcursoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Vista_alum_xcursoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Vista_alum_xcursoBindingNavigatorSaveItem})
        Me.Vista_alum_xcursoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vista_alum_xcursoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vista_alum_xcursoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vista_alum_xcursoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vista_alum_xcursoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vista_alum_xcursoBindingNavigator.Name = "Vista_alum_xcursoBindingNavigator"
        Me.Vista_alum_xcursoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vista_alum_xcursoBindingNavigator.Size = New System.Drawing.Size(384, 25)
        Me.Vista_alum_xcursoBindingNavigator.TabIndex = 0
        Me.Vista_alum_xcursoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Vista_alum_xcursoBindingNavigatorSaveItem
        '
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.Enabled = False
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vista_alum_xcursoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.Name = "Vista_alum_xcursoBindingNavigatorSaveItem"
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Vista_alum_xcursoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 25)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(384, 265)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Frmreporte_compr_inscrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 290)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Vista_alum_xcursoBindingNavigator)
        Me.Name = "Frmreporte_compr_inscrip"
        Me.Text = "Frmreporte_compr_inscrip"
        CType(Me.DSetVistas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista_alum_xcursoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vista_alum_xcursoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vista_alum_xcursoBindingNavigator.ResumeLayout(False)
        Me.Vista_alum_xcursoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DSetVistas As IPEM298.DSetVistas
    Friend WithEvents Vista_alum_xcursoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vista_alum_xcursoTableAdapter As IPEM298.DSetVistasTableAdapters.vista_alum_xcursoTableAdapter
    Friend WithEvents TableAdapterManager As IPEM298.DSetVistasTableAdapters.TableAdapterManager
    Friend WithEvents Vista_alum_xcursoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Vista_alum_xcursoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
