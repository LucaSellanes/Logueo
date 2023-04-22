Imports System.Windows.Controls
Imports System.Windows.Forms
Imports Microsoft.SqlServer.Server
Imports Serilog
Imports Serilog.Core

'Esta es la Capa de Negocios, donde se establece toda la lógica del negocio.

Public Class UsuarioYPassNegocios

    Public Function Logeo(ByVal Nombre As String, ByVal Contraseña As String)
        Dim OUSUARIO As New CapaDeDatos.Datos
        Return OUSUARIO.Loggin(Nombre, Contraseña)
    End Function

    Public Function AltaUsuario(ByVal UnUsuario As CapaDeEntidades.UsuarioYPassEntidades) As Boolean
        'Alta de usuario generando un INSERT en SQL, donde se pasan los distintos atributos correspondientes a la clase UsuarioYPassEntidades.
        Dim MiConsulta As String = (“INSERT INTO Usuarios VALUES('“ & UnUsuario.Legajo & “' , '“ & UnUsuario.Nivel & “' , '“ & UnUsuario.CorreoElectronico & “' , '“ & UnUsuario.Pass & “' , 'False')")
        Dim MisDatos As New CapaDeDatos.Datos
        MisDatos.Ejecutar(MiConsulta)
        Return True
    End Function

    Public Function BajaUsuario(ByVal UnUsuario As CapaDeEntidades.UsuarioYPassEntidades) As Boolean
        'Baja de usuario mediante un UPDATE del campo BajaLogica. Pasandolo de False, a True. Esto lo logramos, 
        'determinando el usuario a dar de baja, a traves del ID de ese usuario, segun el parámetro asignado.
        Dim MiConsulta As String = (“UPDATE Usuarios Set BajaLogica = 'True' Where IdUsuario = ' “ & UnUsuario.IdUsuario & “'")
        Dim MisDatos As New CapaDeDatos.Datos
        MisDatos.Ejecutar(MiConsulta)
        Return True
    End Function

    Public Function BuscarTodosLosUsuarios() As List(Of CapaDeEntidades.UsuarioYPassEntidades)
        'Se buscan todos los usuarios guardados en la base de datos, que no esten dados de baja y ordenados por el ID.
        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos

        MiDt = MisDatos.Consultas("Select * from Usuarios where BajaLogica = 'False' order by IdUsuario")
        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiUsuario As CapaDeEntidades.UsuarioYPassEntidades

        For Each miFila As DataRow In MiDt.Rows
            MiUsuario = New CapaDeEntidades.UsuarioYPassEntidades
            MiUsuario.IdUsuario = miFila.Item(0)
            MiUsuario.Legajo = miFila.Item(1)
            MiUsuario.Nivel = miFila.Item(2)
            MiUsuario.CorreoElectronico = miFila.Item(3)
            MiUsuario.Pass = miFila.Item(4)
            MiLista.Add(MiUsuario)
        Next
        Return MiLista
    End Function

    Public Function BuscarUsuariosFiltrados(ByVal Legajo As Integer) As List(Of CapaDeEntidades.UsuarioYPassEntidades)
        'Busqueda de usuarios que no esten dados de baja y segun el Legajo que ingresemos. 
        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos
        MiDt = MisDatos.Consultas("Select * from Usuarios where BajaLogica = 'False' and Legajo like '" & Legajo & "%' order by IdUsuario")
        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiUsuario As CapaDeEntidades.UsuarioYPassEntidades

        For Each miFila As DataRow In MiDt.Rows
            MiUsuario = New CapaDeEntidades.UsuarioYPassEntidades
            MiUsuario.IdUsuario = miFila.Item(0)
            MiUsuario.Legajo = miFila.Item(1)
            MiUsuario.Nivel = miFila.Item(2)
            MiUsuario.CorreoElectronico = miFila.Item(3)
            MiUsuario.Pass = miFila.Item(4)
            MiLista.Add(MiUsuario)
        Next
        Return MiLista
    End Function

    Public Function ModificarUsuario(ByVal UnUsuario As CapaDeEntidades.UsuarioYPassEntidades) As Boolean
        'Modificacion del usuario, generando un UPDATE de los campos a modificar.
        Dim MiConsulta As String = (“UPDATE Usuarios SET Legajo = '“ & UnUsuario.Legajo & “' ,  Nivel = '“ & UnUsuario.Nivel & “', CorreoElectronico = '“ & UnUsuario.CorreoElectronico & “' , Pass = '“ & UnUsuario.Pass & “' , BajaLogica = 'False' where IdUsuario = '“ & UnUsuario.IdUsuario & “'")
        Dim MisDatos As New CapaDeDatos.Datos
        MisDatos.Ejecutar(MiConsulta)
        Return True
    End Function

    Public Function VerificacionLegajo(ByVal legajo As Integer) As List(Of CapaDeEntidades.UsuarioYPassEntidades)
        'Se trae de la base de datos el Legajo del Usuario segun el parametro Legajo que le asignemos y que no este dado de baja.
        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos
        MiDt = MisDatos.Consultas("Select Legajo from Usuarios where Legajo = '“ & legajo & “' and BajaLogica = 'False'")
        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiLegajo As CapaDeEntidades.UsuarioYPassEntidades

        For Each miFila As DataRow In MiDt.Rows
            MiLegajo = New CapaDeEntidades.UsuarioYPassEntidades
            MiLegajo.Legajo = miFila.Item(0)
            MiLista.Add(MiLegajo)
        Next
        Return MiLista
    End Function

    Public Function VerificarCorreoElectronico(ByVal Correo As String) As Boolean
        Dim VerificadorCorreo As New CapaDeDatos.Datos
        Return VerificadorCorreo.VerificarCorreo(Correo)
    End Function

    Public Function EnvioDeCorreo(ByVal Direccion As String)
        Dim EnviarCorreo As New CapaDeDatos.Datos
        Return EnviarCorreo.EnvioDeCorreo(Direccion)
    End Function

    Public Function ID() As List(Of CapaDeEntidades.UsuarioYPassEntidades)
        'Traemos el máximo ID que no este dado de baja y le sumamos uno. Para poder usar el ID autoincremental
        'y de esta manera dar de alta usuarios sin sobre poner un ID de usuario con otro.
        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos

        MiDt = MisDatos.Consultas("Select MAX(IdUsuario) +1 from Usuarios where BajaLogica = 'False'")
        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiUsuario As CapaDeEntidades.UsuarioYPassEntidades

        For Each miFila As DataRow In MiDt.Rows
            MiUsuario = New CapaDeEntidades.UsuarioYPassEntidades
            MiUsuario.IdUsuario = miFila.Item(0)
            MiLista.Add(MiUsuario)
        Next
        Return MiLista
    End Function

    Public Function ValidacionTextboxFormatoMail(Cadena As String) As Boolean
        'Creamos funcion con 3 variables. Una de ellas la asignamos para "@", otra a "." y la ultima a determinar si el correo es válido o no.
        'Luego con un If, si el contenido de "Cadena" (valor que pasamos a la funcion) no contiene arroba ni punto
        'Entonces devolvera False. Caso contrario, True.

        Dim Arroba As Long
        Dim Puntocom As Long
        Dim CorreoValido As Boolean = False

        'Asignamos la variable a la funcion InStr la cual indica la cantidad de veces (1 en este caso)
        'que el caracter (@ y/o punto) estara en el texto (Cadena).
        Arroba = InStr(1, Cadena, "@")
        Puntocom = InStr(1, Cadena, ".com")

        If (Arroba > 0) And (Puntocom > 0) Then
            CorreoValido = True
            Return CorreoValido
        Else
            CorreoValido = False
            Return CorreoValido
        End If
    End Function
    Public Function IDUsuario() As List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiDt As New DataTable
        Dim MisDatos As New CapaDeDatos.Datos

        MiDt = MisDatos.Consultas("Select MAX(IdUsuario) +1 from Usuarios")

        'Si inicia esta funcion, y no hay ningun ID con BajaLogica en False, el valor va a ser Null (porque esta vacío). En ese caso, toma el mayor ID con BajaLogica = True y le suma 1.
        If IsDBNull(MiDt.Rows.Item(0)(0)) Then

            MiDt = MisDatos.Consultas("Select MAX(IdUsuario) +1 from Usuarios")

            'Si es la primera vez que se inicia esta funcion, el valor va a ser Null (porque esta vacío). En ese caso, se completa con "1" el ID.
            If IsDBNull(MiDt.Rows.Item(0)(0)) Then
                Dim MiLista3 As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
                Dim MiUsuario3 As CapaDeEntidades.UsuarioYPassEntidades

                For Each miFila As DataRow In MiDt.Rows
                    MiUsuario3 = New CapaDeEntidades.UsuarioYPassEntidades
                    MiUsuario3.IdUsuario = 1
                    MiLista3.Add(MiUsuario3)
                Next
                Return MiLista3
                Exit Function
            End If

            Dim MiLista2 As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
            Dim MiUsuario2 As CapaDeEntidades.UsuarioYPassEntidades

            For Each miFila As DataRow In MiDt.Rows
                MiUsuario2 = New CapaDeEntidades.UsuarioYPassEntidades
                MiUsuario2.IdUsuario = miFila.Item(0)
                MiLista2.Add(MiUsuario2)
            Next
            Return MiLista2
            Exit Function
        End If

        Dim MiLista As New List(Of CapaDeEntidades.UsuarioYPassEntidades)
        Dim MiUsuario As CapaDeEntidades.UsuarioYPassEntidades

        For Each miFila As DataRow In MiDt.Rows
            MiUsuario = New CapaDeEntidades.UsuarioYPassEntidades
            MiUsuario.IdUsuario = miFila.Item(0)
            MiLista.Add(MiUsuario)
        Next
        Return MiLista
    End Function

    Public Function ModificarPass(ByVal CambioContra As String, ByVal Correo As String) As Boolean
        'Modificación de contraseña mediante un UPDATE en SQL. Segun el correo electrónico y la nueva contraseña 
        'que asignemos a los parámetros, se va a hacer la modificación para ese usuario.
        Dim MiConsulta As String = (“UPDATE Usuarios SET Pass = '“ & CambioContra & “' Where CorreoElectronico = '“ & Correo & “' and BajaLogica = 'False'")
        Dim MisDatos As New CapaDeDatos.Datos
        MisDatos.Ejecutar(MiConsulta)
        Return True
    End Function
End Class

