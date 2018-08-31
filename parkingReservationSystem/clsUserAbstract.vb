
Public MustInherit Class clsUserAbstract

    Inherits clsConnection
    Public _id As Integer
    Public _name As String
    Public _address As String
    Public _age As Integer
    Public _gender As String
    Public _uname As String
    Public _pass As String



    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property


    Public Property Address As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _uname
        End Get
        Set(ByVal value As String)
            _uname = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property

    Public MustOverride Sub RegisterNewUser()

    Public MustOverride Sub UpdateInfo()



End Class
