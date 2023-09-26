Public Class Biblioteca
    Dim usuario As String
    Public Sub New(ByVal usuario As String)
        InitializeComponent()
        Me.usuario = usuario
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim matricula As String = txtMatricula.Text
        If (matricula = "") Then
            dis()
        End If
    End Sub

    Sub dis()
        txtNombre.Enabled = True
        TextBox1.Enabled = True
        txtApMaterno.Enabled = True
        txtTelf.Enabled = True
        cbxCarrera.Enabled = True
        btnBuscar.Enabled = False
        BtnEntrar.Enabled = True
    End Sub

    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = usuario

    End Sub
End Class
