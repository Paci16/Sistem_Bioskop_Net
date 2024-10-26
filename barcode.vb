Imports Sistem_Bioskop_Net.BadutCinemaDataSet3TableAdapters
Imports System.Reflection.Emit

Public Class barcode
    Private Sub barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BadutCinemaDataSet3.TPemesanan' table. You can move, or remove it, as needed.
        Me.TPemesananTableAdapter.Fill(Me.BadutCinemaDataSet3.TPemesanan)
        TPemesananTableAdapter.Insert(Label4.Text, user)
        Dim random As New Random
        Label4.Text = (random.Next(1000000, 1000000000))
    End Sub
End Class