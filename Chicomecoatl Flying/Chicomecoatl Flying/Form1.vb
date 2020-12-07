Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
            Label1.Text = "Cargando interfaz al " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Programacion de los botones para alternar entre modo oscuro y claro de la app
        Me.BackColor = Color.DimGray
        Form2.BackColor = Color.DimGray
    End Sub
End Class
