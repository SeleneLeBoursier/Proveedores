Public Class Proveedores

    Dim id_ As Integer
    Dim nombre_ As String
    Dim direccion_ As String
    Dim telefono_ As String
    Dim email_ As String
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value

        End Set
    End Property
    Public Property nombre() As Integer
        Get
            Return nombre_
        End Get
        Set(ByVal value As Integer)
            nombre_ = value

        End Set
    End Property
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value

        End Set
    End Property
    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value

        End Set
    End Property
    Public Property email() As Integer
        Get
            Return email_
        End Get
        Set(ByVal value As Integer)
            email_ = value

        End Set
    End Property
    Public Sub ConsultarTodos(ByVal tabla As DataGridView)
        Dim strconexion As String = "Server= CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        Dim strcomando As String = "SELECT * FROM proveedor"
        Dim objcomando As New SqlCommand(strcomando, objconexion)
        Dim objdatatable As New Data.DataTable
        Dim objdataadapter As New SqlDataAdapter(objcomando)

        objconexion.Open()
        objdataadapter.Fill(objdatatable)
        tabla.DataSource = objdatatable
        objconexion.Close()

    End Sub

    Public Sub insertar(ByVal proveedor As Proveedores)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection= True;"
        Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "INSERT INTO proveedor (Nombre,Direccion,Catalogo,Email,Telefono) VALUES (@Nombre,@Direccion,@Catalogo,@Email,@Telefono)"
        Dim objcomando As New SqlCommand("InsertarProveedor", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)


        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)
        objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
        objcomando.Parameters.AddWithValue("@Telefono", proveedor.telefono)
        objcomando.Parameters.AddWithValue("@Email", proveedor.Email)

        'objcomando.Parameters("@Nombre").Value = proveedor.Nombre
        'objcomando.Parameters("@Direccion").Value = proveedor.Direccion
        'objcomando.Parameters("@Catalogo").Value = proveedor.Catalogo
        'objcomando.Parameters("@Email").Value = proveedor.Email
        'objcomando.Parameters("@Telefono").Value = proveedor.Telefono

        objconexion.Open()
        objcomando.ExecuteNonQuery()
        objconexion.Close()



    End Sub
    Public Sub modificar(ByVal proveedor As Proveedores)
        Dim strconexion As String = "Server =CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection = True;"
        Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "UPDATE proveedor SET Nombre=@Nombre,Direccion=@Direccion,Catalogo=@Catalogo,Email=@Email,Telefono=@Telefono WHERE Id =@Id"
        Dim objcomando As New SqlCommand("ModificarProveedor", objconexion)

        objcomando.CommandType = CommandType.StoredProcedure
        objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)

        'objcomando.Parameters.Add("@Id", SqlDbType.Int)
        'objcomando.Parameters.Add("@Nombre", SqlDbType.VarChar)

        objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)

        objcomando.Parameters.AddWithValue("@Email", proveedor.Email)
        objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
        objcomando.Parameters.AddWithValue("@Id", proveedor.Id)
        'objcomando.Parameters("@Id").Value = proveedor.Id
        'objcomando.Parameters("@Nombre").Value = proveedor.Nombre
        'objcomando.Parameters("@Direccion").Value = proveedor.Direccion
        'objcomando.Parameters("@Catalogo").Value = proveedor.Catalogo
        'objcomando.Parameters("@Email").Value = proveedor.Email
        'objcomando.Parameters("@Telefono").Value = proveedor.Telefono

        objconexion.Open()
        objcomando.ExecuteNonQuery()
        objconexion.Close()

    End Sub

    Public Sub borrar(ByVal Idproveedor As Integer)
        Dim strconexion As String = "Server=CI7427EA91ADCA\SQLEXPRESS;Database=DistribuidoraHerass;Trusted_Connection =True;"
        Dim objconexion As New SqlConnection(strconexion)
        'Dim strcomando As String = "DELETE proveedor WHERE Id =@Id"

        Dim objcomando As New SqlCommand("EliminarProveedor", objconexion)
        objcomando.CommandType = CommandType.StoredProcedure

        objcomando.Parameters.AddWithValue("@Id", SqlDbType.Int)
        objcomando.Parameters("@Id").Value = Idproveedor
        objconexion.Open()
        objcomando.ExecuteNonQuery()

        objconexion.Close()
    End Sub
End Class


End Class
