Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim time_o = DateTime.Now.ToString("HH:mm")

        Dim time_mod = time_o.Split(":")

        horas.Text = time_mod(0)
        minutos.Text = time_mod(1)
        dias.Text = day_o
        fecha.Text = date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If config.Visible = False Then
            config.Visible = True
        ElseIf config.Visible = True Then
            config.Visible = False
        End If
    End Sub
End Class
