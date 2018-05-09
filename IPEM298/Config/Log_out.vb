
Public Class Log_out
    Public formularios As New List(Of Form)
    Sub cerrar()
        Dim fr As Form
        For Each fr In Application.OpenForms
            formularios.Add(fr)
        Next
        Dim frinicio As New Frm_Inicio
        frinicio.Show()
        For Each frm As Form In formularios
            frm.Close()
        Next
    End Sub


End Class
