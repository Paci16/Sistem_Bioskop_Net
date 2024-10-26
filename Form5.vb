Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BadutCinemaDataSet3.TPemesanan' table. You can move, or remove it, as needed.
        Me.TPemesananTableAdapter.Fill(Me.BadutCinemaDataSet3.TPemesanan)
        Label6.Text = tempatduduk.Pilm
        Label3.Text = tempatduduk.count
        Label4.Text = totalHarga * count
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim random As New Random
        Label9.Text = (random.Next(100000))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim br As New barcode
        br.Show()
        Me.Close()
    End Sub

End Class