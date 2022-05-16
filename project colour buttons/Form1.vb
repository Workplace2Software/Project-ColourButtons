Public Class Form1

    Dim clickcount As Integer = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Red
        Label1.Text = "Red"
        Label1.BackColor = Color.Red
        clickcount = clickcount + 1
        Label2.Text = "You Clicked " & clickcount & " times"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.BackColor = Color.Blue
        Label1.Text = "Blue"
        Label1.BackColor = Color.Blue
        clickcount = clickcount + 1
        Label2.Text = "You Clicked " & clickcount & " times"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.BackColor = Color.Green
        Label1.Text = "Green"
        Label1.BackColor = Color.Green
        clickcount = clickcount + 1
        Label2.Text = "You Clicked " & clickcount & " times"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.bgm, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
