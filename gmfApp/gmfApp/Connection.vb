﻿Imports MySql.Data.MySqlClient

Module Connection
    Public Conn As MySqlConnection
    Public RD, RD2 As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD, CX As MySqlCommand
    Public DS As DataSet
    Public myBindingSource As BindingSource
    Public simpan, ubah, hapus As String

    Public Sub bukaDB()
        Dim SQLConn As String
        SQLConn = "server=localhost;Uid=root;Pwd=;Database=warehouse;Convert Zero Datetime=True"
        Conn = New MySqlConnection(SQLConn)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
