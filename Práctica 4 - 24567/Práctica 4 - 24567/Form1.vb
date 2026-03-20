Public Class Form1
    Dim formato As Boolean = True
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim day_o = DateTime.Now.ToString("dddd")
        Dim time_o As String = ""

        ' este es el formato de 24h
        If formato = True Then
            time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim time_mod = time_o.Split(":")
        horas.Text = time_mod(0)
        minutos.Text = time_mod(1)
        segundos.Text = time_mod(2)
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim colortexto As String = ComboBox1.SelectedItem.ToString()
        If colortexto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            dias.ForeColor = Color.White
            fecha.ForeColor = Color.White
        ElseIf colortexto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            dias.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
        ElseIf colortexto = "Azul" Then
            horas.ForeColor = Color.Aqua
            minutos.ForeColor = Color.Aqua
            Label1.ForeColor = Color.Aqua
            dias.ForeColor = Color.Aqua
            fecha.ForeColor = Color.Aqua
        ElseIf colortexto = "Verde" Then
            horas.ForeColor = Color.LimeGreen
            minutos.ForeColor = Color.LimeGreen
            Label1.ForeColor = Color.LimeGreen
            dias.ForeColor = Color.LimeGreen
            fecha.ForeColor = Color.LimeGreen
        ElseIf colortexto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            dias.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub
End Class
