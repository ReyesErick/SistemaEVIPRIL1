Imports System.Data.SqlClient

Module Conexion
    Public sele As New Integer
    Public cn As New SqlConnection(My.Settings.ConexionTemporal)
End Module
