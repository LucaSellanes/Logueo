Imports System.CodeDom.Compiler
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Sub DesahilitacionParaUsuario()
        'Metodo para deshabilitación de página de formulario. Esto se usa para el ingreso de un usuario
        'o visitante, y que no pueda dar de alta, modificar o borrar datos de la base. Esto solo lo podra hacer
        'quien ingrese con la credencial de Administrador.
        Form2.TextBox5.Enabled = False
        Form2.TextBox1.Enabled = False
        Form2.ComboBox1.Enabled = False
        Form2.TextBox2.Enabled = False
        Form2.TextBox3.Enabled = False
        Form2.TextBox4.Enabled = False
        Form2.Button1.Enabled = False
        Form2.Button2.Enabled = False
        Form2.Button3.Enabled = False
        Form2.Button4.Enabled = False
        Form2.DataGridView1.Enabled = False
    End Sub

    Sub AumentarID(ByVal ListaDetalles As List(Of CapaDeEntidades.UsuarioYPassEntidades))
        'Paso el contenido de la lista creada, al textbox6 para mostrar el ID autoincremental.
        Dim Fila As Integer = 0
        For Each MiDetalle As CapaDeEntidades.UsuarioYPassEntidades In ListaDetalles
            TextBox6.Text = MiDetalle.IdUsuario
        Next
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        'Segun posición de checkbox2 se mostrara o no la contraseña del ingreso como Invitado.
        If CheckBox2.Checked Then
            TextBox5.PasswordChar = ""
        Else
            TextBox5.PasswordChar = "*"
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Evento para evitar espacios al escribir la contraseña para el alta del Invitado.
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permiten espacios.", vbCritical, "Error")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Evento para evitar espacios al escribir el Usuario para el alta del Invitado.
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permiten espacios.", vbCritical, "Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Boton de Ingreso de Usuarios (TabPage1), estableciendo 3 intentos posibles en caso de error en contraseña o usuario.
        'A su vez, en el ingreso se determina el nivel de seguridad con el que cuenta quien ingrese, y segun el nivel,
        'podra ver y tener acceso a ciertas partes del software, o no.

        Dim OUSUARIO As New CapaDeNegocios.UsuarioYPassNegocios
        Dim Ingreso = OUSUARIO.Logeo(TextBox1.Text, TextBox2.Text)

        Static i As Int16 = 1

        If Ingreso = "Usuario" And i > 3 Or Ingreso = "Administrador" And i > 3 Then
            MsgBox("Intentos terminados" & vbCrLf & "El sistema se cerrara", vbCritical, "Aviso")
            Me.Close()
        End If

        If i <= 3 Then
            If Ingreso = "Usuario" Then
                Timer1.Start()
                MsgBox("Bienvenido al sistema", vbInformation, "Ingreso Correcto")
                DesahilitacionParaUsuario()
                Form2.Button8.Enabled = False
                Form2.Show()
                Me.Hide()
            End If

            If Ingreso = "Invitado" Then
                MsgBox("Ingrese por la seccion de Invitados por favor.", vbInformation, "Ingreso como invitado")
                TextBox4.Focus()
                'En lugar de usar el metodo 'DesahilitacionParaUsuario', cambio el formato/estilo del TabControl,
                'evitando que se puedan seleccionar/manipular los elementos del mismo.
                Me.TabControl1.SelectedIndex = 2
                Exit Sub
            End If

            If Ingreso = "Administrador" Then
                Timer1.Start()
                MsgBox("Bienvenido al sistema", vbInformation, "Ingreso Correcto")
                Form2.Show()
                Me.Hide()
            End If

            If Ingreso <> "Administrador" And Ingreso <> "Usuario" And Ingreso <> "Invitado" Then
                MsgBox("Usuario o contraseña incorrecta", vbCritical, "Aviso")
                TextBox1.Focus()
                i = i + 1
            End If
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        'Boton 'Salir' en el Inicio de Sesion.
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        'Si el correo electrónico no esta registrado en la base de datos, el sistema lo verificará
        'y le informará esto al usuario en el momento de querer hacer un recupero de contraseña con un correo inexistente.
        Dim Correo As New CapaDeNegocios.UsuarioYPassNegocios
        Dim CorreoElec = Correo.VerificarCorreoElectronico(TextBox3.Text)

        If CorreoElec = True Then
            Dim Prueba As New CapaDeNegocios.UsuarioYPassNegocios
            Dim Prueba2 = Prueba.EnvioDeCorreo(TextBox3.Text)
        Else
            MsgBox("El correo ingresado no figura como usuario activo.", vbExclamation, "Correo Inexistente")
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        'Boton 'Salir' en la pestaña 'Recuperar contraseña'.
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'Boton de Ingreso de Invitado (TabPage3), estableciendo 3 intentos posibles en caso de error en contraseña o usuario.
        'A su vez, en el ingreso se determina el nivel de seguridad con el que cuenta quien ingrese, y segun el nivel,
        'podra ver y tener acceso a ciertas partes del software, o no.

        Dim OUSUARIO As New CapaDeNegocios.UsuarioYPassNegocios
        Dim Ingreso = OUSUARIO.Logeo(TextBox4.Text, TextBox5.Text)

        Static i As Int16 = 1

        If Ingreso = "Usuario" And i > 3 Or Ingreso = "Administrador" And i > 3 Then
            MsgBox("Intentos terminados" & vbCrLf & "El sistema se cerrara", vbCritical, "Aviso")
            Me.Close()
        End If

        If i <= 3 Then

            If Ingreso = "Usuario" Then
                Timer1.Start()
                MsgBox("Bienveido al sistema", vbInformation, "Ingreso Correcto")
                DesahilitacionParaUsuario()
                Form2.Show()
                Me.Hide()
            End If

            If Ingreso = "Invitado" Then
                Timer1.Start()
                MsgBox("Bienveido al sistema", vbInformation, "Ingreso Correcto")
                DesahilitacionParaUsuario()

                Form2.Show()
                Me.Hide()
            End If

            If Ingreso = "Administrador" Then
                Timer1.Start()
                MsgBox("Bienveido al sistema", vbInformation, "Ingreso Correcto")
                Form2.Show()
                Me.Hide()
            End If

            If Ingreso <> "Administrador" And Ingreso <> "Usuario" And Ingreso <> "Invitado" Then
                MsgBox("Usuario o contraseña incorrecta", vbCritical, "Aviso")
                TextBox1.Focus()
                i = i + 1
            End If
        End If
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        'Boton 'Salir' en la pestaña 'Ingresar Como Invitado'.
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'Creamos variable "ValidacionOkey" y la asignamos como el resultado de la funcion y 'ValidacionTextboxFormatoMail'
        'Si se cumplen las condiciones de la funcion, el proceso continua. Caso contrario, muestra mensaje y sale del proceso.
        'La ValidacionOkey verifica si el correo es válido y si contiene arroba y punto.

        Dim ValidacionNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim ValidacionOkey As Boolean
        ValidacionOkey = ValidacionNegocio.ValidacionTextboxFormatoMail(TextBox4.Text)

        If ValidacionOkey = False Then
            MsgBox("El Usuario ingresado no posee formato de correo electrónico. Intente nuevamente", vbCritical, "Error")
            Exit Sub
        End If

        'Validamos un mínimo de caraceteres para la contraseña.
        If TextBox5.Text.Trim.Length < 7 Then
            MsgBox("La contraseña debe tener mas de 7 caracteres.", vbInformation, "Error")
            Exit Sub
        End If

        Dim Correo As New CapaDeNegocios.UsuarioYPassNegocios
        Dim CorreoElec = Correo.VerificarCorreoElectronico(TextBox4.Text)

        If CorreoElec = True Then
            MsgBox("El usuario ya existe. Ingrese uno distinto por favor.", vbCritical, "Usuario Existente")
        ElseIf CorreoElec = False Then

            Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
            Dim UsuarioEntidad As New CapaDeEntidades.UsuarioYPassEntidades

            UsuarioEntidad.CorreoElectronico = TextBox4.Text
            UsuarioEntidad.Pass = TextBox5.Text
            UsuarioEntidad.Nivel = "Invitado"
            UsuarioEntidad.Legajo = TextBox6.Text


            Dim LegajoNegocios As New CapaDeNegocios.UsuarioYPassNegocios
            Dim LegajoEntidades As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

            LegajoEntidades = LegajoNegocios.VerificacionLegajo(UsuarioEntidad.Legajo)

            If LegajoEntidades.Count = 0 Then
                Dim Resultado As Boolean
                Resultado = UsuarioNegocio.AltaUsuario(UsuarioEntidad)

                If Resultado = True And Resultado = True Then
                    MsgBox("El Invitado se dio de alta correctamente.", vbInformation, "Invitado Activado")
                    TextBox4.Text = ""
                    TextBox5.Text = ""
                End If
            Else
                MsgBox("El Legajo ya existe. Ingrese uno distinto.", vbCritical, "Usuario Existente")
                Exit Sub

            End If

        End If

        Dim Validador As Integer = 0

        If Validador = 0 Then
            Dim IDNegocios2 As New CapaDeNegocios.UsuarioYPassNegocios
            Dim IDEntidades2 As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
            IDEntidades2 = IDNegocios2.ID()
            AumentarID(IDEntidades2)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Muestra o no la contraseña, segun el estado del checkbox1.
        If CheckBox1.Checked Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'De manera predeterminada se establecen las contraseñas ocultas.
        TextBox2.PasswordChar = "*"
        TextBox5.PasswordChar = "*"

        'Se oculta el label "Establecida" que se usara al ingresar al sistema.
        Label11.Visible = False

        'Se genera un aumento automático de ID para el ingreso de Invitados.
        Dim IDNegocios As New CapaDeNegocios.UsuarioYPassNegocios
        Dim IDEntidades As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        IDEntidades = IDNegocios.ID()
        AumentarID(IDEntidades)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Barra de progreso en el inicio con valor porcentual y aumento de  20. Que genera cambios en los
        'label para cambiar el mensaje una vez hecha la conexión y llenada la barra de progreso.
        ProgressBar1.Increment(20)
        Label6.Text = ProgressBar1.Value & (" %")

        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Label7.Text = "Conexión"
            Label11.Visible = True
            Exit Sub
        End If
    End Sub
End Class
