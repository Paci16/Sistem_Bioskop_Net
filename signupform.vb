Public Class signupform

    Private Sub signupform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TUserTableAdapter.Fill(Me.BadutCinemaDataSet.TUser)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TUserTableAdapter.Insert(TextBox1.Text, TextBox2.Text)
        Me.TUserTableAdapter.Fill(Me.BadutCinemaDataSet.TUser)
        user = TextBox1.Text
        Dim f2 As New Form2
        f2.Show()
        Me.Close()
    End Sub

End Class