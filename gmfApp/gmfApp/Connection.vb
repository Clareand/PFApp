Imports System.Data.OleDb

Module Connection
    Public Conn As OleDbConnection
    Public RD As OleDbDataReader
    Public DA As OleDbDataAdapter
    Public CMD As OleDbCommand
    Public DS As DataSet
    Public simpan, ubah, hapus As String

    Public Sub bukaDB()
        Dim SQLConn As String
        SQLConn = "server=localhost;Uid=root;Pwd=;Database=pf;Convert Zero Datetime=True"
        Conn = New OleDbConnection(SQLConn)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
