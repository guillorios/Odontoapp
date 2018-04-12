Public Class frmProgresoEnvioEmail

    Dim timCount As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        timCount = timCount + 1
        ProgressBar1.Value = ProgressBar1.Value + 1
        ProgressBar1.Text = "PROGRESO : " & ProgressBar1.Value + 1 & " SEG"

        If timCount = 20 Then

            ProgressBar1.Value = ProgressBar1.Maximum
            Timer1.Enabled = False
            timCount = 0
            ProgressBar1.Value = 0
            Me.btnEmailSalir.Enabled = True
            Me.Close()
            MsgBox("Mensajes enviados por favor genere el reporte")

        End If

    End Sub

    Private Sub frmProgresoEnvioEmail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 20
        ProgressBar1.Value = 0
        Timer1.Interval = 1 * 1000 'this = 1 sec
        Timer1.Enabled = True

    End Sub


End Class