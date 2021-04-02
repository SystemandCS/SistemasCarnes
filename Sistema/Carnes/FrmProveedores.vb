
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
        ComboPais()
        ComboProvincia()
        ComboLocalidad()

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


    Private Sub DgProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgProveedores.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If DgProveedores.Rows(DgProveedores.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DgProveedores.CurrentRow.Index
            BuscarProveedor(DgProveedores.Rows(Fila).Cells(0).Value.ToString())




        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

    End Sub



#End Region

#Region "Funciones y Rutinas para el Formulario"

    Private Sub BuscarProveedor(Codigo As Integer)
        Try
            Dim CProveedor As New ClsGenerica
            Dim DT As New DataTable
            DT = CProveedor.TraerDatos("Gen_Proveedor_ou", Codigo).Tables(0)
            If DT.Rows.Count > 0 Then

                TxtidProveedor.Text = DT.Rows(0).Item("idProveedor").ToString()
                TxtProvNro.Text = DT.Rows(0).Item("ProvNro").ToString()
                TxtRazonSocial.Text = DT.Rows(0).Item("RazonSocial").ToString()
                TxtProvNro.Text = DT.Rows(0).Item("ProvNro").ToString()
                TxtCuit.Text = DT.Rows(0).Item("CUIT").ToString()
                CmbcondIva.SelectedValue = DT.Rows(0).Item("condIva").ToString()
                TxtCalle.Text = DT.Rows(0).Item("calle").ToString()
                TxtNumero.Text = DT.Rows(0).Item("numero").ToString()
                Txtpiso.Text = DT.Rows(0).Item("piso").ToString()
                TxtCPostal.Text = DT.Rows(0).Item("CPostal").ToString()

                CmbPais.SelectedValue = DT.Rows(0).Item("idpais").ToString()
                CmbProvincia.SelectedValue = DT.Rows(0).Item("IdProvincia").ToString()

                CmbLocalidad.SelectedValue = DT.Rows(0).Item("idlocalidad").ToString()
                '            isnull(idLocalidad, 0) idLocalidad,
                'isnull(idprovincia, 0) idprovincia,
                'isnull(idPais, 0) idPais,
                'isnull(telPart,' ') telPart ,
                '            isnull(telfax,' ') telfax,
                '            isnull(telCel,' ') telCel,
                '            isnull(cpostal, ' ') cpostal,
                '            isnull(RSComercial,' ' ) RSComercial,
                '            isnull(DomiciCom, ' ' ) DomiciCom,
                '            isnull(idLocaCom, 0) idLocaCom,
                '            isnull(TelCom, ' ') TelCom,
                '            isnull(TelFaxCom, ' ') TelFaxCom,
                '            isnull(cPostalCom, ' ') cPostalCom,
                '            isnull(Comision, 0) Comision,
                '            isnull(ImpSellos, 0) ImpSellos,
                'isnull(DerRegistro, 0) DerRegistro,





            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Cargar Combo Localidad
    Private Sub ComboLocalidad()
        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.EjecutarSql("select idlocalidad, nombre From grl_localidad").Tables(0)
            With CmbLocalidad
                .DataSource = DT
                .DisplayMember = "Nombre"
                .ValueMember = "idlocalidad"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Cargar Combo Localidad
    Private Sub ComboProvincia()
        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.EjecutarSql("select idprovincia, nombre From grl_provincia").Tables(0)
            With CmbProvincia
                .DataSource = DT
                .DisplayMember = "Nombre"
                .ValueMember = "idprovincia"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso- Provincia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    ' Cargar Combo Localidad
    Private Sub ComboPais()
        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.EjecutarSql("select idPais, nombre From grl_pais").Tables(0)
            With CmbPais
                .DataSource = DT
                .DisplayMember = "Nombre"
                .ValueMember = "idPais"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso- Pais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region


End Class