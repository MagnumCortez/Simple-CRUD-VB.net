Public Class SQLConnMgr
    Private a_Con As SqlClient.SqlConnection
    Private a_User As String
    Private a_Password As String
    Private a_Server As String
    Private a_Database As String



#Region "Property"
    Public Property Con() As SqlClient.SqlConnection
        Get
            If a_Con Is Nothing Then
                Conectar()
            Else
                If (a_Con.State = ConnectionState.Closed) Or (a_Con.State = ConnectionState.Broken) Then
                    If (a_Con.State <> ConnectionState.Connecting) And ((a_Con.State <> ConnectionState.Executing)) Then
                        Conectar()
                    End If
                End If
            End If
            Con = a_Con
        End Get
        Set(ByVal value As SqlClient.SqlConnection)
            a_Con = value
        End Set
    End Property

    Public Property User() As String
        Get
            Return a_User
        End Get
        Set(ByVal value As String)
            a_User = value
        End Set
    End Property

    Public Property Pwd() As String
        Get
            Return a_Password
        End Get
        Set(ByVal value As String)
            a_Password = value
        End Set
    End Property

    Public Property Server() As String
        Get
            Server = a_Server
        End Get
        Set(ByVal value As String)
            a_Server = value
        End Set
    End Property

    Public Property DataBase() As String
        Get
            DataBase = a_Database
        End Get
        Set(ByVal value As String)
            a_Database = value
        End Set
    End Property

#End Region

#Region "Construct"
    Public Sub New()
        a_Server = My.Settings.ConServer
        a_Database = My.Settings.ConDatabase
        a_User = My.Settings.ConUser
        a_Password = My.Settings.ConPassword

        a_Con = New SqlClient.SqlConnection
    End Sub

#End Region

#Region "Funcionalidades da classe"
    Public Sub Conectar(Optional ByVal timeout As Integer = -1)
        Dim parametrosOk As Boolean

        parametrosOk = True

        'caso seja nula, inicializa
        If a_Con Is Nothing Then
            a_Con = New SqlClient.SqlConnection
        End If

        'se estiver aberta, fecha
        If a_Con.State = ConnectionState.Open Then
            a_Con.Close()
        End If

        'tenta abrir a conexao
        Try
            a_Con.ConnectionString = "Data Source=" & a_Server & "; Database=" & a_Database & "; User ID=" & a_User & "; Password=" & a_Password & ";"

            a_Con.Open()

            If a_Con.State <> ConnectionState.Open Then
                Throw New Exception("Verifique os parametros informados.")
            End If

        Catch ex As Exception
            Throw New Exception("Não foi possivel estabelecer a conexão." & Chr(13) & ex.ToString)
        End Try

    End Sub
#End Region



End Class
