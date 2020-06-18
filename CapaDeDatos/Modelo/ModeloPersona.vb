Public Class ModeloPersona
    Inherits ModeloBD

    Public Id As String
    Public Nombre As String
    Public Apellido As String
    Public Email As String

    Public Sub Insertar()
        Comando.CommandText = "INSERT INTO persona VALUES(" + Me.Id + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Email + "')"
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Cambiar()
        Comando.CommandText = "UPDATE persona SET nombre = '" + Me.Nombre + "', apellido ='" + Me.Apellido + "', email = '" + Me.Email + "' WHERE id = " + Me.Id
        Comando.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar()
        Comando.CommandText = "DELETE FROM persona WHERE id = " + Me.Id
        Comando.ExecuteNonQuery()
    End Sub

    Public Function Contar()
        Me.Comando.CommandText = "SELECT COUNT(*) FROM persona"
        Return Me.Comando.ExecuteScalar().ToString()
    End Function

    Public Function Mostrar()
        Me.Comando.CommandText = "SELECT * FROM persona"
        Lector = Comando.ExecuteReader()
        Return Lector
    End Function

End Class
