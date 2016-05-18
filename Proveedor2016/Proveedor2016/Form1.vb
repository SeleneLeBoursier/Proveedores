Public Class frmProveedor
    Private accion_ As String
    Private proveedor_ As New Proveedores
    Public Property accion() As String
        Get
            Return accion_

        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property proveedor() As Proveedores
        Get
            Return proveedor_
        End Get
        Set(ByVal value As Proveedores)
            proveedor_ = value
        End Set
    End Property

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        proveedor.id = id.Text
        proveedor.nombre = nombre.Text
        proveedor.direccion = direccion.Text
        proveedor.telefono = telefono.Text
        proveedor.email = email.Text
        If accion_ = "insertar" Then
            proveedor.insertar(proveedor)




        End If



    End Sub

  

End Class

