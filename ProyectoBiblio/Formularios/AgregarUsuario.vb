Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AgregarUsuario
    Dim server As String = "Data Source = DESKTOP-DDN13PI\SQLEXPRESS; Initial Catalog= Biblioteca; Integrated Security = True "
    Dim conectar As New SqlConnection
    Dim usuario As String
    Public Function HashPassword(ByVal password As String) As String
        Using sha256Hash As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()

            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next

            Return builder.ToString()
        End Using
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim password As String = txtContrasenia.Text
        Dim hashedpass = HashPassword(password)
        conectar.ConnectionString = server
        conectar.Open()
        Dim cmd As New SqlCommand("AgregarUsuario", conectar)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_Usuario", txtId.Text)
        cmd.Parameters.AddWithValue("@Nombre_Usuario", txtUsuario.Text)
        cmd.Parameters.AddWithValue("@Contrasenia", hashedpass.ToString())
        Try
            MessageBox.Show("Usuario agregado correctamente")
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.ToString())
            Throw
        End Try
        conectar.Close()
    End Sub
End Class