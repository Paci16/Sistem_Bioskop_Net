Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Silahkan isi Email dan Password")
        Else
            Try
                Call Koneksi()
                Cmd = New SqlClient.SqlCommand("Select * From TUser WHERE Email = '" & TextBox1.Text & "' and Pass = '" & TextBox2.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Not Rd.HasRows Then
                    MsgBox("Email atau Password salah")
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                Else
                    user = TextBox1.Text
                    Dim f2 As New Form2
                    f2.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                ' Pastikan untuk selalu menutup data reader dan koneksi setelah digunakan
                If Rd IsNot Nothing Then Rd.Close()
                If Conn.State = ConnectionState.Open Then Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim su As New signupform
        su.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
