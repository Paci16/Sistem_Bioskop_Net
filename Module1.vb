'buat link code
Imports System.Data.SqlClient

Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Cmd As SqlCommand
    Public Ds As DataSet

    Public MyDB As String
    'buat manggil database disini
    Public Sub Koneksi()
        MyDB = "Data Source=LAPTOP-J53KKSF1;initial catalog=BadutCinema;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
End Module
