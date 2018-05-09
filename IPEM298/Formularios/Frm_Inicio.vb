Public Class Frm_Inicio
    Dim DataContext As New DataClassesipem2DataContext
    Dim Datacontexvistas As New DataClassesdevistasDataContext

    Private Sub Frm_Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnombre.Select()
    End Sub

    Private Sub LimpiarControles()
        txtnombre.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        LimpiarControles()
        Me.Close()
    End Sub

    Private Sub cmdaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaceptar.Click
        Try
            Dim Buscausuario = (From I In DataContext.Usuario1 Where I.nombre_usuario = (txtnombre.Text) And I.contraseña = (txtpass.Text)).ToList()(0)


            If Buscausuario.perfil = "Docente" Then
                'Frm_principal.MenuPersonal.Visible = False
                Frm_principal.MenuPersonal.DropDownItems(0).Visible = False
                Frm_principal.MenuPersonal.DropDownItems(1).Visible = False
                Frm_principal.MenuPersonal.DropDownItems(3).Visible = False
                Frm_principal.MenuPersonal.DropDownItems(4).Visible = False
                Frm_principal.UsuariosToolStripMenuItem.Visible = False
                Frm_principal.MenuAlumnos.DropDownItems(0).Visible = False
                Frm_principal.MenuAlumnos.DropDownItems(3).Visible = False
                Frm_principal.MenuAlumnos.DropDownItems(4).Visible = False
                'Frm_principal.MenuAlumnos.Visible = True
            ElseIf Buscausuario.perfil = "Secretario" Then
                Frm_principal.MenuPersonal.Visible = True
                Frm_principal.UsuariosToolStripMenuItem.Visible = False
                Frm_principal.MenuAlumnos.Visible = True
            ElseIf Buscausuario.perfil = "Administrador" Then
                Frm_principal.MenuPersonal.Visible = True
                Frm_principal.UsuariosToolStripMenuItem.Visible = True
                Frm_principal.MenuAlumnos.Visible = True
            End If

            Me.Finalize()
            Me.Close()
            Frm_principal.Show()
        Catch ex As Exception
            MsgBox("Verifique Usuario y contraseña!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            txtnombre.Select()
            LimpiarControles()


        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim Buscausuario = (From I In DataContext.Usuario1 Where I.nombre_usuario = (txtnombre.Text) And I.contraseña = (txtpass.Text)).ToList()(0)
            FrmCambiarContraseña.Show()
            'Me.Enabled = False
        Catch ex As Exception
            MsgBox("El nombre de usuario o contraseña no son correctos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            LimpiarControles()
        End Try
    End Sub

End Class