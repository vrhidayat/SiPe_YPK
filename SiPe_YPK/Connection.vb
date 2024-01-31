Imports System.Data.Common
Imports System.Data.Odbc
Imports System.IO
Module Connection
    Public Conn As OdbcConnection
    Public DR As OdbcDataReader
    Public DA As OdbcDataAdapter
    Public DS As DataSet
    Public CMD As OdbcCommand
    Public connStr As String
    Public SQLInsert As String
    Public SQLUpdate As String
    Public SQLDelete As String

    Public Sub openConn()
        connStr = "Dsn=MySQL_sipe_ypk;uid=root"
        Conn = New OdbcConnection(connStr)

        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Public Sub closeConn()
        If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
    End Sub
End Module
