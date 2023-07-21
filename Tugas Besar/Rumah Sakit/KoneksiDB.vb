Imports System.Data.OleDb
Module KoneksiDB
    Public conn As New OleDbConnection
    Dim strConn As String
    Public Sub bukaKoneksi()
        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                        "Data Source=" & _
                        Application.StartupPath & _
                        "\DB.mdb;"

        conn = New OleDbConnection(strConn)
        If conn.State <> ConnectionState.Closed Then
            conn.Close()
        Else
            conn.Open()
        End If
    End Sub
End Module
