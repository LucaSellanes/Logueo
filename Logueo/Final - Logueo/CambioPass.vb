Imports System.Windows.Forms.VisualStyles.VisualStyleElement

'Formulario que se usa para el cambio de contraseña. Se permite ingresar una nueva contraseña
'y confirmarla en otro Textbox. Esta nueva Pass se envia junto con el correo electrónico
'del usuario que ingreso al sistema, y se hace la actualizacion de la contraseña.

Public Class CambioPass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cada textbox se aloja en una variable. De cumplir restricciones y ser iguales, 
        'se envían como parámetro de la función 'ModificarPass' junto con el correo electrónico 
        'del usuario, para hacer la modificacion pertinente en la base de datos.

        Dim CambioContra As String = TextBox1.Text
        Dim CambioContra2 As String = TextBox2.Text

        'Validación para evitar campos vacíos.
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("No debe dejar campos vacios.", vbCritical, "Error")
            Exit Sub
        End If

        'Validación de un mínimo de caraceteres para la contraseña.
        If TextBox1.Text.Trim.Length < 7 Or TextBox2.Text.Trim.Length < 7 Then
            MsgBox("La contraseña debe tener más de 7 caracteres.", vbInformation, "Error")
            Exit Sub
        End If

        If CambioContra = CambioContra2 Then
            Dim Correo As String

            If Form1.TextBox1.Text = "" Then
                Correo = Form1.TextBox4.Text
            Else
                Correo = Form1.TextBox1.Text
            End If

            Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
            Dim UsuarioEntidad As New CapaDeEntidades.UsuarioYPassEntidades

            Dim Resultado As Boolean
            Resultado = UsuarioNegocio.ModificarPass(CambioContra, Correo)

            MsgBox("Contraseña cambiada con exito.", vbInformation, "Cambio realizado.")
        Else
            MsgBox("Las contraseñas ingresadas no coinciden. Intente nuevamente.", vbCritical, "Error")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Posibilidad de cerrar el formulario cancelando el cambio de contraseña.
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Segun si esta marcado o no el checkbox, se hara o no visible la contraseña.
        If CheckBox1.Checked Then
            TextBox1.PasswordChar = ""
            TextBox2.PasswordChar = ""
        Else
            TextBox1.PasswordChar = "*"
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub CambioPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'De manera predeterminada se establecen las contraseñas ocultas.
        TextBox1.PasswordChar = "*"
        TextBox2.PasswordChar = "*"
    End Sub
End Class