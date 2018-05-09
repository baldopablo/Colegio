Imports System.Text.RegularExpressions

Public Class FrmCambiarContraseña
    Dim DataContext As New DataClassesipem2DataContext





    Private Sub FrmCambiarContraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtpassVieja.Text = Frm_Inicio.txtpass.Text
        lblmensaje.Visible = False
        'If txtpassNueva.Text <> "" Then
        '    lblmensaje.Visible = True
        'Else
        '    lblmensaje.Visible = False
        'End If
    End Sub

    Private Sub LimpiarControles()
        txtpassVieja.Text = ""
        txtpassNueva.Text = ""
        txtRepetir.Text = ""
    End Sub

    Private Sub cmdcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        LimpiarControles()
    End Sub


    Private Sub cmdCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCambiar.Click

        If txtpassNueva.Text <> txtRepetir.Text Then
            MsgBox("Repita la contraseña")
            txtpassNueva.Text = ""
            txtRepetir.Text = ""
            Exit Sub
        End If
        Try
            Dim Buscausuario = (From I In DataContext.Usuario1 Where I.nombre_usuario = (Frm_Inicio.txtnombre.Text) And I.contraseña = (txtpassVieja.Text)).ToList()(0)

            Buscausuario.contraseña = txtpassNueva.Text
            DataContext.SubmitChanges()
            MsgBox("La contraseña se ha modificado correctamente")
            Frm_Inicio.txtpass.Clear()
            Me.Close()
            'LimpiarControles()
        Catch ex As Exception
            MsgBox("No se ha cambiado la contraseña correctamente! intente nuevamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Inicio de sesión")
            '    LimpiarControles()
        End Try

        'MsgBox("Repita la contraseña")
        'txtRepetir.Text = ""

    End Sub


    Private Sub cmdCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        LimpiarControles()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Frm_Inicio.Enabled = True
        Me.Finalize()
        Me.Close()

    End Sub

    Private Sub txtpassNueva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassNueva.KeyPress
        lblmensaje.Visible = True
        Dim TestString As String
        TestString = txtpassNueva.Text

        Dim rgx As New System.Text.RegularExpressions.Regex("[A-Za-z].*[0-9]|[0-9].*[A-Za-z]")

        If Len(TestString) > 8 And (rgx.IsMatch(TestString)) Then
            Button4.Visible = True
            Button2.Visible = False
            Button3.Visible = False
            lblBaja.Visible = False
            lblMedia.Visible = False
            lblAlta.Visible = True
            lblmensaje.Visible = False
        Else
            If Len(TestString) > 5 < 9 And (rgx.IsMatch(TestString)) Then
                Button4.Visible = False
                Button2.Visible = False
                Button3.Visible = True
                lblBaja.Visible = False
                lblMedia.Visible = True
                lblAlta.Visible = False
            Else
                If Len(TestString) > 1 < 6 Then
                    Button4.Visible = False
                    Button2.Visible = True
                    Button3.Visible = False
                    lblBaja.Visible = True
                    lblMedia.Visible = False
                    lblAlta.Visible = False
                End If
            End If
        End If

    End Sub


End Class