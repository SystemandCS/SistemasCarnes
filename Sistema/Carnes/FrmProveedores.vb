
Imports System.Runtime.InteropServices
Public Class FrmProveedores


    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer



    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RellenarLista()

    End Sub



#Region "Funciones "



    Private Sub RellenarLista()
        Try

            Dim OProveedor(0) As Object
            OProveedor(0) = ""
            ' OProveedor(1) = ""
            ' OProveedor(2) = ""


            Dim CPProveedores As New ClsGenerica
            Dim DT As New DataTable
            DT = CPProveedores.TraerDatos("Gen_Proveedor_Consul", 0, "", "").Tables(0)
            DgProveedores.DataSource = DT
            DgProveedores.ReadOnly = True
            'DgProveedores.Columns("idUsuario").Visible = False
            'DgProveedores.Columns("idfrigorifico").Visible = False
            'DgProveedores.Columns("idSuperior").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region
End Class