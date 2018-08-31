
Public MustInherit Class cUser

    'Inherits cConnection

    Public _fname As String
    Public _lname As String
    Public _address As String
    Public _age As Integer
    Public _gender As String
    Public _uname As String
    Public _pass As String

    Public Property FirstName As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _uname
        End Get
        Set(value As String)
            _uname = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public MustOverride Sub RegisterNewUser()

    Public MustOverride Sub LogIn()

    Public MustOverride Sub UpdateInfo()



End Class
