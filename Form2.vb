Public Class Form2

    Private NamaPilm As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BadutCinemaDataSet1.TJadwal' table. You can move, or remove it, as needed.
        Me.TJadwalTableAdapter.Fill(Me.BadutCinemaDataSet1.TJadwal)
        Label10.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label2.Hide()
        Label11.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        Label1.Hide()
        DateTimePicker1.Hide()
        Button1.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Format(DateTimePicker1.Value, "MMMM:d-yyyy ")
        Label10.Show()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label2.Show()
    End Sub

    Private Sub Label11_hover1(sender As Object, e As EventArgs) Handles Label11.MouseEnter
        Label11.ForeColor = Color.White
        Label11.BackColor = Color.Black
    End Sub

    Private Sub Label11_hover2(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.ForeColor = Color.Black
        Label11.BackColor = Color.White
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.Black
        duduk.ForeColor = Color.White
        Label11.Show()
        waktu = Label10.Text
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.Black
        duduk.ForeColor = Color.White
        Label11.Show()
        waktu = Label9.Text
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.Black
        duduk.ForeColor = Color.White
        Label11.Show()
        waktu = Label8.Text
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.Black
        duduk.ForeColor = Color.White
        Label11.Show()
        waktu = Label7.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.LightYellow
        PictureBox4.BackColor = Color.LightYellow
        NamaPilm = Label3.Text
    End Sub

    Private Sub pic4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim poster = DirectCast(sender, PictureBox)
        poster.BackColor = Color.LightYellow
        Label3.BackColor = Color.LightYellow
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.LightYellow
        PictureBox1.BackColor = Color.LightYellow
        NamaPilm = Label4.Text
    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim poster = DirectCast(sender, PictureBox)
        poster.BackColor = Color.LightYellow
        Label4.BackColor = Color.LightYellow
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.LightYellow
        PictureBox3.BackColor = Color.LightYellow
        NamaPilm = Label5.Text
    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim poster = DirectCast(sender, PictureBox)
        poster.BackColor = Color.LightYellow
        Label5.BackColor = Color.LightYellow
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim duduk = DirectCast(sender, Label)
        duduk.BackColor = Color.LightYellow
        PictureBox2.BackColor = Color.LightYellow
        NamaPilm = Label6.Text
    End Sub

    Private Sub pic6_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim poster = DirectCast(sender, PictureBox)
        poster.BackColor = Color.LightYellow
        Label6.BackColor = Color.LightYellow
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Show()
        PictureBox4.Show()
        Label1.Show()
        DateTimePicker1.Show()
        Button1.Show()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        'masukkin ke dalam database data nya
        Pilm = NamaPilm
        TJadwalTableAdapter.Insert(ComboBox1.SelectedItem, NamaPilm, DateTimePicker1.Value, waktu)

        Dim frm4 As New Form4
        Pilm = NamaPilm
        frm4.Show()
        Me.Close()
    End Sub

    Private Sub Label13_Click_2(sender As Object, e As EventArgs) Handles Label13.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Close()
    End Sub
End Class