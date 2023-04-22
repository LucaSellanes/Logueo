Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.SqlServer.Server

'Imports para Correo Electronico
Imports System.Net.Mail
Imports System.Net

Public Class Datos
    'Creamos conexion y elementos para la misma.
    Dim MiStringDeConexion = “Data Source=.\;Initial Catalog= Loggin;Integrated Security=TRUE”
    Dim MiConexion As SqlConnection
    Dim MiDataSet As DataSet
    Dim MiSQLComand As SqlCommand
    Dim MiSQLAdapter As SqlDataAdapter
    Dim MiDataTable As DataTable

    Public Sub Ejecutar(ByVal Miconsulta As String)
        'Ejecucion de consulta asignada mediante función.
        MiConexion = New SqlConnection(MiStringDeConexion)
        MiSQLComand = New SqlCommand(Miconsulta)
        MiSQLComand.Connection = MiConexion
        MiConexion.Open()
        MiSQLComand.ExecuteNonQuery()
        MiConexion.Close()
    End Sub

    Public Function Consultas(ByVal MiConsulta As String) As DataTable
        'Consulta que devuelve un DataTable con los datos obtenidos segun la consulta ("MiConsulta") asignada.
        MiConexion = New SqlConnection(MiStringDeConexion)
        MiSQLComand = New SqlCommand(MiConsulta)
        MiSQLComand.Connection = MiConexion
        MiConexion.Open()
        MiDataSet = New DataSet
        MiDataTable = New DataTable
        MiSQLAdapter = New SqlDataAdapter
        MiSQLAdapter.SelectCommand = MiSQLComand
        MiSQLAdapter.Fill(MiDataSet)
        MiDataTable = MiDataSet.Tables(0)
        MiConexion.Close()
        Return MiDataTable
    End Function

    Public Function Loggin(ByVal CorreoElectronico As String, ByVal Contraseña As String)
        'Segun el los valores pasados a la función, nos trae el Nivel de ese Usuario. Para ello, si hay mas de una fila en el DataTable,
        'y esa fila se iguala a uno de los Niveles, entonces nos retorna el "Verificador" que tomara el valor del "Nivel" encontrado.

        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos
        MiDt = MisDatos.Consultas("Select Nivel from Usuarios where CorreoElectronico = '“ & CorreoElectronico & “' and Pass = '“ & Contraseña & “' and BajaLogica = 'False'")
        Dim Nivel As String
        Dim Verificador As String

        If MiDt.Rows.Count < 1 Then
            Verificador = ""
        End If

        If MiDt.Rows.Count > 0 Then

            Nivel = MiDt.Rows(0)("Nivel")

            If Nivel = "Usuario" Then
                Verificador = "Usuario"
                Return Verificador

            ElseIf Nivel = "Administrador" Then
                Verificador = "Administrador"
                Return Verificador

            ElseIf Nivel = "Invitado" Then
                Verificador = "Invitado"
                Return Verificador
            End If
        End If
    End Function

    Public Function VerificarCorreo(ByVal Correo As String) As Boolean
        'Segun el Correo que le pasemos, verifica si existe en SQL y de ser asi, nos retorna el Verificador en True.
        'Caso contrario lo devuelve en False ya que no se encontro coincidencia alguna.

        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos
        MiDt = MisDatos.Consultas("Select CorreoElectronico from Usuarios where CorreoElectronico = '“ & Correo & “' and BajaLogica = 'False'")
        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim Verificador As Boolean

        If MiDt.Rows.Count > 0 Then
            Verificador = True
            Return Verificador
        Else
            Verificador = False
            Return Verificador
        End If
    End Function

    Public Function EnvioDeCorreo(ByVal Direccion As String)
        'Envío de correo electrónico para recuperar la contraseña a la dirección que le pasemos mediante función.

        'Creacion de numero aleatorio como nueva contraseña
        Dim NumeroAleatorio As New Random()
        Dim ValorAleatorio As Integer = NumeroAleatorio.Next(100000, 999999)

        'Instanciamos el correo y el servidor.
        Dim Correo As New MailMessage
        Dim smtp As New SmtpClient

        'Designamos las credenciales por default en False.
        smtp.UseDefaultCredentials = False
        'Determinamos de donde saldra el correo e indicamos el código de seguridad del correo electrónico.
        smtp.Credentials = New Net.NetworkCredential("Proyectologgin@gmail.com", "grfjtfujlwbouaer")
        smtp.Port = 587
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"

        'Asignamos a la variable "Correo" del tipo MailMessage los atributos necesarios, donde se establece de donde sale el correo,
        'hacia donde ("Direccion"), el asunto y el cuerpo. En el correo, se envía el "ValorAleatorio" que sera la nueva contraseña.
        Correo = New MailMessage
        Correo.From = New MailAddress("ProyectoLoggin@gmail.com")
        Correo.To.Add(Direccion)
        Correo.Subject = "Recupero de Contraseña"
        Correo.Body = "Su nueva contraseña es: " & ValorAleatorio
        Dim NuevaPass As Integer = ValorAleatorio

        Correo.IsBodyHtml = False
        smtp.Send(Correo)
        MsgBox("Correo Enviado. Ya puede ingresar con su nueva contraseña", vbInformation, "Envio Correcto")

        'Generamos la modificación en SQL para que el ValorAleaotorio enviado, tome el lugar de contraseña ("NuevaPass")
        'segun la direccion de correo donde se envio ("Direccion" la cual es el Usuario de esa persona).
        Dim MiConsulta As String = (“UPDATE Usuarios SET Pass = '“ & NuevaPass & “' Where CorreoElectronico = '“ & Direccion & “' and BajaLogica = 'False'")
        Dim MisDatos As New CapaDeDatos.Datos
        MisDatos.Ejecutar(MiConsulta)
    End Function
End Class

