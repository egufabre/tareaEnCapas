Imports CapaDeDatos

Module ControladorDePersona

    Public Sub InsertarPersona(id As String, nombre As String, apellido As String, email As String)
        Dim p As New ModeloPersona
        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Email = email

        p.Insertar()

    End Sub

    Public Sub CambiarPersona(id As String, nombre As String, apellido As String, email As String)
        Dim p As New ModeloPersona
        p.Id = id
        p.Nombre = nombre
        p.Apellido = apellido
        p.Email = email
        p.Cambiar()
    End Sub

End Module
