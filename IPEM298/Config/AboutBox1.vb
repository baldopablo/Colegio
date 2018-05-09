Imports System.Threading.Thread
Imports System.Windows.Forms.Timer
Public NotInheritable Class AboutBox1
    Private oTiempo As Timer

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CheckForIllegalCrossThreadCalls = False

        Me.Timer1.Start()
        Label4.Text = "Cargando..."

        'Dim hilo1 As New Threading.Thread(AddressOf Corredor)
        'If Not hilo1.ThreadState = Threading.ThreadState.Running Then
        '    Me.PictureBox1.Location = New Point(22, Me.PictureBox1.Location.Y)
        '    hilo1.Start()
        '    'Corredor()

        'End If

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        oTiempo = New Timer()
        oTiempo.Interval = 900000000

        oTiempo.Stop()

        oTiempo = Nothing


        'Frm_Inicio.Show()


        Me.Close()


    End Sub


    Private Sub ProgressBar1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ProgressBar1.DragOver

    End Sub


    'Sub Corredor()
    '    Dim i, k As Integer
    '    For i = 22 To 37
    '        Randomize()
    '        k = CInt(Int(1 * Rnd()) + i)
    '        Me.PictureBox1.Location = New Point(Me.PictureBox1.Location.X + k, Me.PictureBox1.Location.Y)
    '        Threading.Thread.Sleep(1 + Rnd() * 123)


    '    Next
    '    If i = 38 And Len(Label4.Text) = 0 Then
    '        Me.PictureBox1.Location = New Point(Me.PictureBox1.Location.X, Me.PictureBox1.Location.Y)
    '        Me.PictureBox1.Location = New Point(280, 167)
    'Label4.Text = "Cargando..."
    '    End If
    'End Sub

End Class
