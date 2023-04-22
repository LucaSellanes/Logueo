Public Class UsuarioYPassEntidades
    'Creamos la Clase UsuarioYPassEntidades, donde se asignan todos los atributos de dicha clase.
    Private vIdUsuario As Integer

    Public Property IdUsuario() As Integer
        Get
            Return vIdUsuario
        End Get
        Set(ByVal value As Integer)
            vIdUsuario = value
        End Set
    End Property

    Private vLegajo As Integer

    Public Property Legajo() As Integer
        Get
            Return vLegajo
        End Get
        Set(ByVal value As Integer)
            vLegajo = value
        End Set
    End Property

    Private vNivel As String

    Public Property Nivel() As String
        Get
            Return vNivel
        End Get
        Set(ByVal value As String)
            vNivel = value
        End Set
    End Property


    Private vCorreoElectronico As String

    Public Property CorreoElectronico() As String
        Get
            Return vCorreoElectronico
        End Get
        Set(ByVal value As String)
            vCorreoElectronico = value
        End Set
    End Property


    Private vPass As String

    Public Property Pass() As String
        Get
            Return vPass
        End Get
        Set(ByVal value As String)
            vPass = value
        End Set
    End Property

    Private vBajaLogica As Boolean

    Public Property BajaLogica() As Boolean
        Get
            Return vBajaLogica
        End Get
        Set(ByVal value As Boolean)
            vBajaLogica = value
        End Set
    End Property

End Class
