Public Class lstProveedor
    Dim proveedor As New Proveedores

    Private Sub proveedorgrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstProveedor.ConsultarTodos(dgvProveedor)

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        frmProveedor.accion = "insertar"
        frmProveedor.ShowDialog()

    End Sub


    Private Sub dgvProveedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedor.CellContentClick
        proveedor.id = dgvProveedor.Item("Id", dgvProveedor.CurrentRow.Index).Value
        proveedor.nombre = dgvProveedor.Item("Nombre", dgvProveedor.CurrentRow.Index).Value
        proveedor.direccion = dgvProveedor.Item("Direccion", dgvProveedor.CurrentRow.Index).Value
        proveedor.telefono = dgvProveedor.Item("Telefono", dgvProveedor.CurrentRow.Index).Value
        proveedor.email = dgvProveedor.Item("Email", dgvProveedor.CurrentRow.Index).Value
        frmProveedor.accion = "modificar"
        frmProveedor.proveedorgrid = proveedorgrid
        frmProveedor.ShowDialog()

    End Sub

    Private Sub Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Borrar.Click
        Dim mensaje As DialogResult = MessageBox.Show("¿Desea borrar?")
        If mensaje = Windows.Forms.DialogResult.OK Then
            proveedorgrid.borrar(dgvProveedor.Item("id", dgvProveedor.CurrentRow.Index).Value)
            proveedorgrid.ConsultarTodos(dgvProveedor)
        End If
    End Sub
End Class