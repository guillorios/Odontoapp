Public Class frmReminderCitas

    Private Sub btnPacSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub frmReminderCitas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RemStartTime.Value = New Date(2000, 1, 1, 7, 0, 0, 0)
        Me.RemEndTime.Value = New Date(2000, 1, 1, 7, 5, 0, 0)
    End Sub
End Class