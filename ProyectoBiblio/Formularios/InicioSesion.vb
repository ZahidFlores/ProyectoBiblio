Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text

Public Class InicioSesion

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

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        conectar.Close()
        Dim password As String = txtContrasenia.Text
        conectar.ConnectionString = server
        conectar.Open()
        Dim query As String = "select Contrasenia from Usuario where Nombre_Usuario=@usuario"
        Dim cmd As New SqlCommand(query, conectar)
        cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text)
        Dim resultado
        resultado = cmd.ExecuteScalar()
        Dim hashedpassword As String = HashPassword(password)
        Dim soniguales As Boolean = String.Equals(resultado, hashedpassword)
        If (soniguales) Then
            usuario = txtUsuario.Text
            MessageBox.Show("Login Exitoso")
            Dim formprincipal As New Biblioteca(usuario)
            formprincipal.Show()
            Me.Hide()
            conectar.Close()

        Else
            MessageBox.Show("Usuario o contraseña incorrecto")
        End If

    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        Dim agregarUsuario As New AgregarUsuario
        Me.Hide()
        agregarUsuario.Show()

    End Sub
End Class