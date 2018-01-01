Imports System.Data.Odbc
Module koneksi
    Public conn As Odbc.OdbcConnection
    Public cmd As Odbc.OdbcCommand
    Public dr As OdbcDataReader
    Public ds As New DataSet
    Public da As OdbcDataAdapter
    Sub koneksinya()
        conn = New Odbc.OdbcConnection("Dsn=crud")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
