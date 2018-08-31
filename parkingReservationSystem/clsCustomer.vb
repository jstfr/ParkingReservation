Public Class clsCustomer
    Inherits clsUserAbstract
    Public Sub New()
        _id = 0
        _age = 0
        _name = ""
        _gender = ""
        _address = ""
        _uname = ""
        _pass = ""

    End Sub
    Public Overrides Sub RegisterNewUser()
        processData("INSERT INTO users(uname, ugender, uaddress, uage, uuname, upass, uaccess) VALUES ('" + _name + "', '" + _gender + "', '" + _address + "', " + _age.ToString() + ",'" + _uname + "', '" + _pass + "', 'Customer')")
    End Sub

    Public Overrides Sub UpdateInfo()

    End Sub
End Class
