Public Class FrmProveedores
    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RellenarLista()

    End Sub



#Region "Funciones "



    Private Sub RellenarLista()
        Try

            Dim OProveedor(3) As Object
            OProveedor(0) = ""


            Dim CPProveedores As New ClsGenerica
            Dim DT As New DataTable
            DT = CPProveedores.TraerDatos("Gen_Proveedor_Consul", OProveedor).Tables(0)
            DgProveedores.DataSource = DT
            DgProveedores.ReadOnly = True
            DgProveedores.Columns("idUsuario").Visible = False
            DgProveedores.Columns("idfrigorifico").Visible = False
            DgProveedores.Columns("idSuperior").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region
End Class