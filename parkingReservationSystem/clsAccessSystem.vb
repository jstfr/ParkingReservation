Public Class clsAccessSystem
    Inherits clsConnection
    Private _username As String
    Private _password As String
    Private _access As String

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property Access() As String
        Get
            Return _access
        End Get
        Set(ByVal value As String)
            _access = value
        End Set
    End Property

    Public Function UserLogin() As Boolean
        Dim accessme As Boolean
        Try
            getAccess(Username, Password, Access)
            accessme = True
        Catch ex As ArgumentException
            accessme = False
            MessageBox.Show(ex.Message)
        End Try
        Return accessme
    End Function
End Class
