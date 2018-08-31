Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.IO
Public Class clsConnection
    Public sqlConnect As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlReader As MySqlDataReader
    Public sqlAdapter As New MySqlDataAdapter
    Public adaptCustomer As MySqlDataAdapter
    Public adaptPayment As MySqlDataAdapter
    Public sqlTrans As MySqlTransaction
    Public dtTable As New DataTable
    Public Sub connectString()
        sqlConnect.ConnectionString = "server=localhost;user id=root;database=project_2018_db"
    End Sub

    Public Sub getDatabyID(ByVal sqlID As Integer, ByVal qry As String, ByVal prmtr As String)
        Try
            connectString()
            sqlConnect.Open()
            sqlCommand.Parameters.Clear()
            sqlCommand.CommandText = qry
            sqlCommand.CommandType = CommandType.StoredProcedure
            sqlCommand.Parameters.AddWithValue(prmtr, sqlID)
            sqlCommand.Connection = sqlConnect
            sqlReader = sqlCommand.ExecuteReader
            sqlReader.Read()

        Catch ex As MySqlException
            Throw New ArgumentException("There's a problem with the database please contact your administrator")
        End Try
    End Sub
    Public Sub getAccess(ByVal username As String, ByVal password As String, ByVal access As String)
        Try
            connectString()
            sqlConnect.Open()
            sqlCommand.Parameters.Clear()
            sqlCommand.CommandText = "SELECT * FROM users WHERE uuname = @accountUsername AND upass = @accountPassword AND uaccess = @accountAccess"
            sqlCommand.CommandType = CommandType.Text
            sqlCommand.Parameters.AddWithValue("@accountUsername", username)
            sqlCommand.Parameters.AddWithValue("@accountPassword", password)
            sqlCommand.Parameters.AddWithValue("@accountAccess", access)
            sqlCommand.Connection = sqlConnect
            sqlReader = sqlCommand.ExecuteReader
            sqlReader.Read()
            If (sqlReader.HasRows) Then
                logID = CInt(sqlReader.Item("uid").ToString)
                logLevel = sqlReader.Item("uaccess").ToString
                sqlConnect.Close()
            Else
                sqlConnect.Close()
                Throw New ArgumentException("Invalid Username/Password this doesn't exists")
            End If

        Catch ex As MySqlException
            sqlConnect.Close()
            Throw New ArgumentException("There's a problem with the database please contact your administrator")
        End Try
    End Sub
End Class
