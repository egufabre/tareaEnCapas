Imports System.Data.Odbc

Public MustInherit Class ModeloBD
    Public Driver As String = ""
    Public Usuario As String = ""
    Public Password As String = ""
    Public Puerto As String = ""
    Public NombreDeBD As String = ""
    Public Servidor As String = ""


    Public Conexion As New OdbcConnection
    '("DRIVER=" + Me.Driver + ";UID=" + Me.Usuario + ";PWD=" + Me.Password + ";PORT=" + Me.Puerto + ";DATABASE=" + Me.NombreDeBD + ";SERVER=" + Me.Servidor)
    ("
        DRIVER=" + Me.Driver +
        ";UID=" + Me.Usuario +
        ";PWD=" + Me.Password +
        ";PORT=" + Me.Puerto +
        ";DATABASE=" + Me.NombreDeBD +
        ";SERVER=" + Me.Servidor
    )

    Public Comando As New OdbcCommand
    Public Lector As OdbcDataReader


End Class
