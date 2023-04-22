Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Text
Imports CapaDeNegocios
Imports System.Windows.Forms
Imports System.DirectoryServices.ActiveDirectory
Imports System.Runtime.CompilerServices
Imports Azure.Core.HttpHeader

Public Class Form2

    Sub LimpiarTextbox()
        'Metodo para limpiar Textbox y establecer el cursor en el Txt1 (Legajo).
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Sub LlenarGrilla(ByVal ListaDetalles As List(Of CapaDeEntidades.UsuarioYPassEntidades))
        'Llenamos la grilla del DataGrid1 del ABM-Usuarios con las propiedades del objeto.
        Dim Fila As Integer = 0

        For Each MiDetalle As CapaDeEntidades.UsuarioYPassEntidades In ListaDetalles
            Me.DataGridView1.Rows.Add()
            Me.DataGridView1.Rows(Fila).Cells(0).Value = MiDetalle.IdUsuario
            Me.DataGridView1.Rows(Fila).Cells(1).Value = MiDetalle.Legajo
            Me.DataGridView1.Rows(Fila).Cells(2).Value = MiDetalle.Nivel
            Me.DataGridView1.Rows(Fila).Cells(3).Value = MiDetalle.CorreoElectronico
            Me.DataGridView1.Rows(Fila).Cells(4).Value = MiDetalle.Pass
            Fila += 1
        Next
    End Sub

    Sub LlenarGrilla2(ByVal ListaDetalles As List(Of CapaDeEntidades.UsuarioYPassEntidades))
        'Llenamos la grilla del DataGrid2 del Listado Usuarios con las propiedades del objeto.
        Dim Fila As Integer = 0

        For Each MiDetalle As CapaDeEntidades.UsuarioYPassEntidades In ListaDetalles
            Me.DataGridView2.Rows.Add()
            Me.DataGridView2.Rows(Fila).Cells(0).Value = MiDetalle.IdUsuario
            Me.DataGridView2.Rows(Fila).Cells(1).Value = MiDetalle.Legajo
            Me.DataGridView2.Rows(Fila).Cells(2).Value = MiDetalle.Nivel
            Me.DataGridView2.Rows(Fila).Cells(3).Value = MiDetalle.CorreoElectronico
            Me.DataGridView2.Rows(Fila).Cells(4).Value = MiDetalle.Pass
            Fila += 1
        Next
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)
        'Si se ingresa como usuario o invitado, se ejecuta un mensaje informando la falta de acceso a la TagPage1 al darle click a esta.

        Dim OUSUARIO As New CapaDeNegocios.UsuarioYPassNegocios
        Dim OUSUARIO2 As New CapaDeNegocios.UsuarioYPassNegocios

        Dim Ingreso = OUSUARIO.Logeo(Form1.TextBox1.Text, Form1.TextBox2.Text)

        If Ingreso = "Administrador" Then
            Exit Sub
        End If

        Dim Ingreso2 As String

        If TextBox4.Text <> "" Or TextBox5.Text <> "" Then
            Ingreso2 = OUSUARIO2.Logeo(Form1.TextBox4.Text, Form1.TextBox5.Text)
        End If

        If Ingreso = "Usuario" Then
            MsgBox("No cuenta con permisos para utilizar esta sección. Comuníquese con el Administrador", vbExclamation, "Importante")
            Exit Sub
        End If

        If Ingreso2 = "Invitado" Then
            MsgBox("No cuenta con permisos para utilizar esta sección. Comuníquese con el Administrador", vbExclamation, "Importante")
            Exit Sub
        End If

    End Sub

    Private Sub TabControl1_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Evitar espacios en toda la pagina de ABM-Usuarios.
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permiten espacios.", vbCritical, "Error")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Evitar letras en el Legajo del ABM-Usuarios.
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permiten letras.", vbCritical, "Error")
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'Evento mediante el cual al darle click a una fila del Datagrid2, tomaremos el 
        'numero de dicha fila en una variable. Tambien este evento contiene restricciones para 
        'evitar errores en tiempo de ejecución, al seleccionar una fila sin datos o cuando el DataGrid no se haya cargado.

        Dim NumeroDeFilaSeleccionada As Integer
        Dim ValidacionCeldaVacia As String
        Dim Row As DataGridViewRow = DataGridView1.CurrentRow

        If Row Is Nothing Then
            Exit Sub
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        If DataGridView1.RowCount = 0 Then
            Exit Sub
        End If

        NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index
        ValidacionCeldaVacia = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(0).Value

        If ValidacionCeldaVacia = Nothing Then
            MsgBox("La fila seleccionada no contiene datos.", vbCritical, "Error")
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Creamos variable "ValidacionOkey" y la asignamos como el resultado de la funcion y 'ValidacionTextboxFormatoMail'
        'Si se cumplen las condiciones de la funcion, el proceso continua. Caso contrario, muestra mensaje y sale del proceso.
        'La ValidacionOkey verifica si el correo es válido y si contiene arroba y punto.

        Dim ValidacionNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim ValidacionOkey As Boolean
        ValidacionOkey = ValidacionNegocio.ValidacionTextboxFormatoMail(TextBox2.Text)

        If ValidacionOkey = False Then
            MsgBox("El Usuario ingresado no corresponde a un correo electrónico. Intente nuevamente", vbCritical, "Error")
            Exit Sub
        End If

        'Validación para evitar numeros negativos.
        If Val(TextBox1.Text) < 0 Then
            MsgBox("El 'Legajo' y debe ser un numero positivo.", vbCritical, "Error")
            Exit Sub
        End If

        'Validación para evitar campos vacíos.
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("No debe dejar campos vacios.", vbCritical, "Error")
            Exit Sub
        End If

        'Validación de un mínimo de caraceteres para la contraseña.
        If TextBox3.Text.Trim.Length < 7 Then
            MsgBox("La contraseña debe tener mas de 7 caracteres.", vbInformation, "Error")
            Exit Sub
        End If

        'Validación para evitar datos no numericos.
        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("El 'Legajo' debe ser numerico.", vbCritical, "Error")
            Exit Sub
        End If

        'Creamos los objetos de las distintas capas y les asignamos los valores de los textbox.
        Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim UsuarioEntidad As New CapaDeEntidades.UsuarioYPassEntidades

        UsuarioEntidad.Legajo = TextBox1.Text
        UsuarioEntidad.CorreoElectronico = TextBox2.Text
        UsuarioEntidad.Pass = TextBox3.Text
        UsuarioEntidad.Nivel = ComboBox1.Text

        Dim LegajoNegocios As New CapaDeNegocios.UsuarioYPassNegocios
        Dim LegajoEntidades As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

        'Mediante la funcion "VerificacionLegajo" chequeamos que no se dupliquen datos.
        LegajoEntidades = LegajoNegocios.VerificacionLegajo(TextBox1.Text)

        If LegajoEntidades.Count = 0 Then
            Dim Resultado As Boolean
            Resultado = UsuarioNegocio.AltaUsuario(UsuarioEntidad)

            If Resultado = True And Resultado = True Then
                MsgBox("El usuario se dio de alta correctamente.", vbInformation, "Alta exitosa")
                LimpiarTextbox()
                IDAutoincremental()
            End If
        Else
            MsgBox("El Legajo ya existe. Ingrese uno distinto.", vbCritical, "Error")
            LimpiarTextbox()
            IDAutoincremental()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        'Creamos variable "ValidacionOkey" y la asignamos como el resultado de la funcion y 'ValidacionTextboxFormatoMail'
        'Si se cumplen las condiciones de la funcion, el proceso continua. Caso contrario, muestra mensaje y sale del proceso.
        'La ValidacionOkey verifica si el correo es válido y si contiene arroba y punto.

        'Evitamos problemas al seleccionar un boton y que no este cargado el Datagrid. En caso de pasar esto, se cerrara el proceso con un mensajer alertando lo ocurrido.
        Dim Row As DataGridViewRow = DataGridView1.CurrentRow

        If Row Is Nothing Then
            MsgBox("Debe cargar la lista y seleccionar un item para llevar a cabo la acción.", vbCritical, "Error")
            Exit Sub
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un item de la lista para llevar a cabo la acción pulsando la flecha a la izquierda del comienzo cada fila", vbCritical, "Error")
            Exit Sub
        End If

        Dim ValidacionNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim ValidacionOkey As Boolean
        ValidacionOkey = ValidacionNegocio.ValidacionTextboxFormatoMail(TextBox2.Text)

        If ValidacionOkey = False Then
            MsgBox("El Usuario ingresado no corresponde a un correo electrónico. Intente nuevamente", vbCritical, "Error")
            Exit Sub
        End If

        'Validación para evitar numeros negativos.
        If Val(TextBox1.Text) < 0 Then
            MsgBox("El 'Legajo' y debe ser un numero positivo.", vbCritical, "Error")
            Exit Sub
        End If

        'Validación para evitar campos vacíos.
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("No debe dejar campos vacios.", vbCritical, "Error")
            Exit Sub
        End If

        'Validación para evitar datos no numericos.
        If IsNumeric(TextBox1.Text) = False Then
            Exit Sub
        End If

        Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim UsuarioEntidad As New CapaDeEntidades.UsuarioYPassEntidades

        UsuarioEntidad.Legajo = TextBox1.Text
        UsuarioEntidad.CorreoElectronico = TextBox2.Text
        UsuarioEntidad.Pass = TextBox3.Text
        UsuarioEntidad.IdUsuario = TextBox5.Text
        UsuarioEntidad.Nivel = ComboBox1.Text

        Dim Resultado As Boolean

        Resultado = UsuarioNegocio.ModificarUsuario(UsuarioEntidad)

        If Resultado = True And Resultado = True Then
            MsgBox("El usuario fue modificado correctamente.", vbInformation, "Modificación exitosa")
            LimpiarTextbox()
            IDAutoincremental()
        Else
            MsgBox("Ocurrio un error, contactese con Soporte por favor", vbCritical, "Error")
            LimpiarTextbox()
            IDAutoincremental()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        'Boton de Baja que iguala la variable "Seleccionado" a la seleccion del Datagrid. Luego iguala eso
        'al ID y lo pasa mediante la funcion "BajaUsuario" para que se efectue la baja lógica en SQL, cambiando
        'el campo "BajaLógica" de False a True.

        'Boton para baja de un Compra.
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Debe seleccionar un item de la lista para llevar a cabo la acción.", vbCritical, "Error")
            Exit Sub
        End If

        Dim RespuestaBaja As DialogResult
        RespuestaBaja = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (RespuestaBaja = DialogResult.No) Then
            Exit Sub
        End If

        'Evitamos problemas al seleccionar un boton y que no este cargado el Datagrid. En caso de pasar esto, se cerrara el proceso con un mensajer alertando lo ocurrido.
        Dim Row As DataGridViewRow = DataGridView1.CurrentRow

        If Row Is Nothing Then
            MsgBox("Debe cargar la lista y seleccionar un item para llevar a cabo la acción.", vbCritical, "Error")
            Exit Sub
        End If

        Dim Seleccionado As Integer = 0

        Seleccionado = DataGridView1.SelectedRows(0).Cells(0).Value()

        Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim UsuarioEntidad As New CapaDeEntidades.UsuarioYPassEntidades

        UsuarioEntidad.IdUsuario = Seleccionado
        UsuarioNegocio.BajaUsuario(UsuarioEntidad)

        Dim Resultado As Boolean

        Resultado = UsuarioNegocio.BajaUsuario(UsuarioEntidad)

        If Resultado = True Then
            MsgBox("El usuario fue eliminado correctamente.", vbInformation, "Eliminación exitosa")
            LimpiarTextbox()
            IDAutoincremental()
        Else
            MsgBox("Ocurrio un error, contactese con Soporte por favor", vbCritical, "Error")
            LimpiarTextbox()
            IDAutoincremental()
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        'Boton "Salir" del ABM-Usuarios, reestablece la barra de progreso y los label a su estado por defecto cerrando el Form2 y abriendo el 1.
        Form1.ProgressBar1.Value = 0
        Form1.Label7.Text = "Conectando"
        Form1.Label6.Text = "0%"
        Form1.Timer1.Stop()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        'Cambio de contraseña para Invitados. Primero se pregunta al usuario si desea cambiar la Pass. De ser afirmativo
        'Se abre el Form 'CambioPass' con la estructura necesaria para llevar a cabo esta tarea.
        Dim Respuesta As DialogResult
        Respuesta = MessageBox.Show("¿Desea cambiar su contraseña?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (Respuesta = DialogResult.No) Then
            Exit Sub
        End If
        CambioPass.Show()
    End Sub

    Sub Nivel(ByVal ListaDetalles As List(Of CapaDeEntidades.UsuarioYPassEntidades))
        'Metodo para asignar al Combo el Nivel del usuario.
        Dim Fila As Integer = 0
        For Each MiDetalle As CapaDeEntidades.UsuarioYPassEntidades In ListaDetalles
            ComboBox1.Text = MiDetalle.Nivel
        Next
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        'Boton "Salir" del Listado Usuarios, reestablece la barra de progreso y los label a su valor por defecto, cerrando el Form2 y abriendo el 1.
        Form1.ProgressBar1.Value = 0
        Form1.Label7.Text = "Conectando"
        Form1.Label6.Text = "0%"
        Form1.Timer1.Stop()
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub IDAutoincremental()
        'Creamos los objetos para poder aplicar la funcion IDUsuario que nos trae el ID del Usuario al Txt5 (ID).
        Dim IDNegocios As New CapaDeNegocios.UsuarioYPassNegocios
        Dim IDEntidades As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

        IDEntidades = IDNegocios.IDUsuario()
        IDAUsuario(IDEntidades)
    End Sub

    Sub IDAUsuario(ByVal ListaDetalles As List(Of CapaDeEntidades.UsuarioYPassEntidades))
        'Creamos una lista para poder asignale el ID de la Materia Prima, el cual luego pasar al Txt1 (ID).
        Dim Fila As Integer = 0
        For Each MiDetalle As CapaDeEntidades.UsuarioYPassEntidades In ListaDetalles
            TextBox5.Text = MiDetalle.IdUsuario
        Next
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Evitar espacios y/o letras en el Buscador por Legajo del ABM.
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se permiten números. (Para borrar use 'DEL')", vbCritical, "Error")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        'Buscador por Legajo del ABM-Usuarios que permite actuar en tiempo de ejecucion. Al 
        'escribir un legajo, se buscará en el momento filtrando segun los numeros ingresados.

        Me.DataGridView1.Rows.Clear()

        If TextBox4.Text <> "" Then

            Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
            Dim UsuarioEntidad As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

            UsuarioEntidad = UsuarioNegocio.BuscarUsuariosFiltrados(TextBox4.Text)

            LlenarGrilla(UsuarioEntidad)
        End If
    End Sub

    Private Sub TextBox8_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        'Restricción a solo números del TxT usado para filtrar usuarios por Legajo, en la pestaña Listado Usuarios.
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se permiten números. (Para borrar use 'DEL')", vbCritical, "Error")
        End If
    End Sub

    Private Sub TextBox8_TextChanged_1(sender As Object, e As EventArgs)
        'Buscador por Legajo de Listado Usuarios que permite actuar en tiempo de ejecucion. Al 
        'escribir un legajo, se buscara en el momento filtrando segun los numeros ingresados.
        Me.DataGridView2.Rows.Clear()

        If TextBox8.Text <> "" Then

            Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
            Dim UsuarioEntidad As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

            UsuarioEntidad = UsuarioNegocio.BuscarUsuariosFiltrados(TextBox8.Text)
            LlenarGrilla2(UsuarioEntidad)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        'Con el evento CellClick lleno los textbox y genero los objetos para traer el ID
        If DataGridView1.RowCount = 0 Then
            Exit Sub
        End If

        Dim NumeroDeFilaSeleccionada As Integer
        Dim ValidacionCeldaVacia As String

        NumeroDeFilaSeleccionada = DataGridView1.CurrentRow.Index

        ValidacionCeldaVacia = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(0).Value

        If ValidacionCeldaVacia = Nothing Then
            MsgBox("La fila seleccionada no contiene datos.", vbCritical, "Error")
            Exit Sub
        End If

        TextBox5.Text = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(0).Value
        TextBox1.Text = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(1).Value
        ComboBox1.Text = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(2).Value
        TextBox2.Text = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(3).Value
        TextBox3.Text = DataGridView1.Rows(NumeroDeFilaSeleccionada).Cells(4).Value
    End Sub


    Private Sub Form2_Load_1(sender As Object, e As EventArgs)
        IDAutoincremental()

        'Carga de columnas y nombres del DataGrid del ABM-Usuarios y Listado Usuarios
        Me.DataGridView1.Columns.Add("0", "ID")
        Me.DataGridView1.Columns.Add("1", "Legajo")
        Me.DataGridView1.Columns.Add("2", "Nivel")
        Me.DataGridView1.Columns.Add("3", "Correo")
        Me.DataGridView1.Columns.Add("4", "Contraseña")

        Me.DataGridView2.Columns.Add("0", "ID")
        Me.DataGridView2.Columns.Add("1", "Legajo")
        Me.DataGridView2.Columns.Add("2", "Nivel")
        Me.DataGridView2.Columns.Add("3", "Correo")
        Me.DataGridView2.Columns.Add("4", "Contraseña")

        'Bloqueo del ID en el ABM-Usuarios.
        TextBox5.ReadOnly = True

        'Seleccionamos el estilo para el Combo1.
        ComboBox1.DropDownStyle = 2
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        'Botón "Mostrar Todos" correspondiente al Listado de Usuarios.

        'Limpiamos la grilla.
        Me.DataGridView2.Rows.Clear()

        'Creamos los objetos de cada capa, le asignamos la funcion para buscar los usuarios.
        'Y Luego llenamos la grilla con lo encontrado mediante la funcion BuscarTodosLosUsuarios.
        Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim UsuarioEntidad As New List(Of CapaDeEntidades.UsuarioYPassEntidades)

        UsuarioEntidad = UsuarioNegocio.BuscarTodosLosUsuarios()
        LlenarGrilla2(UsuarioEntidad)

        'Evitamos que se autoseleccione una fila al cargar el Datagrid. Y en caso de que este vacio, esta accion no se activa, ya que tira error en ese caso.
        Dim Row As DataGridViewRow = DataGridView2.CurrentRow
        If Row Is Nothing Then
            MsgBox("No hay datos cargados para mostrar.", vbCritical, "Error")
            Exit Sub
        Else
            Me.DataGridView2.Rows(0).Selected = False
        End If
    End Sub

    Private Sub DataGridView2_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs)
        'Si el ingreso se hace como invitado, no se podrán ver las contraseñas ni correos electronicós de los usuarios.

        Dim OUSUARIO As New CapaDeNegocios.UsuarioYPassNegocios
        Dim Ingreso = OUSUARIO.Logeo(Form1.TextBox4.Text, Form1.TextBox5.Text)

        If Ingreso <> "Invitado" Then
            Exit Sub
        End If

        If Ingreso = "Invitado" Then
            If e.ColumnIndex = 4 Then
                e.Value = New String("*"c, Convert.ToString(e.Value).Length)
            End If

            If e.ColumnIndex = 3 Then
                e.Value = New String("*"c, Convert.ToString(e.Value).Length)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Limpio la grilla e introduzco la función para traer todos los usuarios.
        Me.DataGridView1.Rows.Clear()

        Dim UsuarioNegocio As New CapaDeNegocios.UsuarioYPassNegocios
        Dim UsuarioEntidad As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        UsuarioEntidad = UsuarioNegocio.BuscarTodosLosUsuarios()
        LlenarGrilla(UsuarioEntidad)
        LimpiarTextbox()
        IDAutoincremental()

        'Evitamos que se autoseleccione una fila al cargar el Datagrid. Y en caso de que este vacio, esta accion no se activa, ya que figura un error en ese caso.
        Dim Row As DataGridViewRow = DataGridView1.CurrentRow
        If Row Is Nothing Then
            MsgBox("No hay datos cargados para mostrar.", vbCritical, "Error")
            Exit Sub
        Else
            Me.DataGridView1.Rows(0).Selected = False
        End If
    End Sub
End Class
