Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'Para ocultar la contraseña se utilizó la propiedad "UseSystemPasswordChar"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Aqui definiremos los usuarios que pueden acceder al programa sin necesidad de conectar con una BD
        If (TextBox1.Text = "Carolina Morales") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Paola") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Nisham") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Luis") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Cris") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Alexis") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()
        ElseIf (TextBox1.Text = "Invitado_ITTLA") And (TextBox2.Text = "12345") Then
            Form3.Show()
            Me.Hide()

        Else
            MsgBox("Lo sentimos, el usuario ingresado no está registrado en la beta del programa", vbExclamation, "Error con los datos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class