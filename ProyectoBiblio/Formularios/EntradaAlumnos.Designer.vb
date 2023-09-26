<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biblioteca
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApPaterno = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApMaterno = New System.Windows.Forms.TextBox()
        Me.txtTelf = New System.Windows.Forms.TextBox()
        Me.cbxCarrera = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre(s)"
        '
        'txtApPaterno
        '
        Me.txtApPaterno.AutoSize = True
        Me.txtApPaterno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApPaterno.Location = New System.Drawing.Point(187, 109)
        Me.txtApPaterno.Name = "txtApPaterno"
        Me.txtApPaterno.Size = New System.Drawing.Size(115, 18)
        Me.txtApPaterno.TabIndex = 2
        Me.txtApPaterno.Text = "Apellido Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Carrera"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(24, 40)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(26, 145)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtApMaterno
        '
        Me.txtApMaterno.Enabled = False
        Me.txtApMaterno.Location = New System.Drawing.Point(369, 145)
        Me.txtApMaterno.Name = "txtApMaterno"
        Me.txtApMaterno.Size = New System.Drawing.Size(121, 20)
        Me.txtApMaterno.TabIndex = 9
        '
        'txtTelf
        '
        Me.txtTelf.Enabled = False
        Me.txtTelf.Location = New System.Drawing.Point(26, 230)
        Me.txtTelf.Name = "txtTelf"
        Me.txtTelf.Size = New System.Drawing.Size(100, 20)
        Me.txtTelf.TabIndex = 10
        '
        'cbxCarrera
        '
        Me.cbxCarrera.Enabled = False
        Me.cbxCarrera.FormattingEnabled = True
        Me.cbxCarrera.Items.AddRange(New Object() {"Ing. Sistemas Computacionales", "Ing. Biomedico", "Ing. Electronica", "Ing. Mecánica"})
        Me.cbxCarrera.Location = New System.Drawing.Point(190, 229)
        Me.cbxCarrera.Name = "cbxCarrera"
        Me.cbxCarrera.Size = New System.Drawing.Size(168, 21)
        Me.cbxCarrera.TabIndex = 11
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(142, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEntrar
        '
        Me.BtnEntrar.Enabled = False
        Me.BtnEntrar.Location = New System.Drawing.Point(227, 37)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEntrar.TabIndex = 13
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(190, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 20)
        Me.TextBox1.TabIndex = 14
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(437, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 15
        '
        'Biblioteca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 274)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cbxCarrera)
        Me.Controls.Add(Me.txtTelf)
        Me.Controls.Add(Me.txtApMaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApPaterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Biblioteca"
        Me.Text = "Biblioteca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApPaterno As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApMaterno As TextBox
    Friend WithEvents txtTelf As TextBox
    Friend WithEvents cbxCarrera As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtUsuario As TextBox
End Class
