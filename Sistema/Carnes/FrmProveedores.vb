﻿
Imports System.Runtime.InteropServices
Public Class FrmProveedores


    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer


    Dim Modo As String
    Dim OProveedor(47) As Object

    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        'Logger.Nivel = Logger.TipoMensaje.WARNING

    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RellenarLista()
        ComboPais()
        ComboProvincia()
        ComboLocalidad()
        CargarCondIva()
        CargarTipoProveedor()




    End Sub



#Region "Funciones "

    Private Sub OProveedorCargar()


        Try

            '***************************************

            OProveedor(0) = Val(TxtidProveedor.Text) '@idproveedor int = null ,
            OProveedor(1) = Val(TxtProvNro.Text)   '@provNro int = NULL ,
            OProveedor(2) = TxtRazonSocial.Text '@razonSocial varchar (100) = null ,
            OProveedor(3) = TxtCuit.Text  '@CUIT varchar (20) = NULL ,
            OProveedor(4) = Val(CmbcondIva.SelectedValue)  '@condIva int = NULL ,
            OProveedor(5) = TxtCalle.Text '@calle varchar (100) = NULL ,
            OProveedor(6) = TxtNumero.Text '@numero varchar (5) = NULL ,
            OProveedor(7) = Txtpiso.Text '@piso varchar (5) = NULL ,
            OProveedor(8) = Val(CmbLocalidad.SelectedValue) '@idLocalidad int = NULL ,
            OProveedor(9) = Val(CmbProvincia.SelectedValue) '@idprovincia int = NULL ,

            '@idproveedor int = null ,
            '@provNro int = NULL ,
            '@razonSocial varchar (100) = null ,
            '@CUIT varchar (20) = NULL ,
            '@condIva int = NULL ,
            '@calle varchar (100) = NULL ,
            '@numero varchar (5) = NULL ,
            '@piso varchar (5) = NULL ,
            '@idLocalidad int = NULL ,
            '@idprovincia int = NULL ,

            '***************************************

            OProveedor(10) = Val(CmbPais.SelectedValue) '@idPais int = NULL ,
            OProveedor(11) = txtTelPart.Text '@telPart varchar (50) = null ,
            OProveedor(12) = TxtTelFax.Text '@telfax varchar (50) = null ,
            OProveedor(13) = TxtTelCel.Text '@telCel varchar (50) = null ,
            OProveedor(14) = TxtCPostal.Text '@cpostal varchar(12)=null,
            OProveedor(15) = txtRsComercial.Text '@RSComercial varchar(100) = null,
            OProveedor(16) = txtDomicom.Text '@DomiciCom varchar (100) = NULL ,
            OProveedor(17) = Val(cmbIdLocaCom.Text) '@idLocaCom int = NULL ,
            OProveedor(18) = txtTelCom.Text '@TelCom varchar (50) = null ,
            OProveedor(19) = TxtTelFaxCom.Text '@TelFaxCom varchar (50) = null ,

            '@idPais int = NULL ,
            '@telPart varchar (50) = null ,
            '@telfax varchar (50) = null ,
            '@telCel varchar (50) = null ,
            '@cpostal varchar(12)=null,
            '@RSComercial varchar(100) = null,
            '@DomiciCom varchar (100) = NULL ,
            '@idLocaCom int = NULL ,
            '@TelCom varchar (50) = null ,
            '@TelFaxCom varchar (50) = null ,

            '***************************************

            OProveedor(20) = txtCPostalCom.Text '@cPostalCom varchar(12)=null,
            OProveedor(21) = Convert.ToDecimal(TxtComision.Text) '@Comision decimal(15,2)=null,
            OProveedor(22) = Convert.ToDecimal(TxtImpSellos.Text) '@ImpSellos decimal(15,2)=null,
            OProveedor(23) = Convert.ToDecimal(txtDerRegistro.Text) '@DerRegistro decimal(15,2)=null,
            OProveedor(24) = Convert.ToDecimal(TxtMbs.Text) '@mbs decimal(15,2)=null,
            OProveedor(25) = Convert.ToDecimal(TxtRec.Text) '@Rec decimal(15,2)=null,
            OProveedor(26) = Convert.ToDecimal(TxtComision2.Text) '@Comision2 decimal(15,2)=null,
            OProveedor(27) = Convert.ToDecimal(TxtFGarantia.Text) '@FGarantia decimal(15,2)=null,
            OProveedor(28) = Convert.ToDecimal(TxtGastoFrigor.Text) '@GastoFrigor decimal(15,2)=null,
            OProveedor(29) = Convert.ToDecimal(txtGuia.Text) '@Guia decimal(15,2)=null, 

            '@cPostalCom varchar(12)=null,
            '@Comision decimal(15,2)=null,
            '@ImpSellos decimal(15,2)=null,
            '@DerRegistro decimal(15,2)=null,
            '@mbs decimal(15,2)=null,
            '@Rec decimal(15,2)=null,
            '@Comision2 decimal(15,2)=null,
            '@FGarantia decimal(15,2)=null,
            '@GastoFrigor decimal(15,2)=null,
            '@Guia decimal(15,2)=null,

            '***************************************


            OProveedor(30) = Convert.ToDecimal(txtotros.Text) '@Otros decimal(15,2)=null,
            OProveedor(31) = Convert.ToDecimal(txtFlete.Text) '@Flete decimal(15,2)=null,
            OProveedor(32) = If(ChkIngBrutos.Checked, "S", "N")   '@IngBrutos char(1)=null,

            OProveedor(33) = TxtProcedencia.Text '@Procedencia varchar(100)=null,
            OProveedor(34) = If(ChkGanancias.Checked, "S", "N") '@Ganancias char(1)=null,

            OProveedor(35) = Convert.ToDecimal(IIf(TxtIBPorcen.Text = vbNullString, 0, TxtIBPorcen.Text))   '@IBPorcen decimal(9,3)=null,'@IngBrutos char(1)=null,

            OProveedor(36) = TxtObservacion1.Text '@observacion1 nvarchar (50) = NULL ,
            OProveedor(37) = TxtObservacion2.Text '@observacion2 nvarchar (50) = NULL ,
            OProveedor(38) = IIf(TxtEmail1.Text = vbNullString, " ", TxtEmail1.Text) '@email1 varchar (50) = NULL ,
            OProveedor(39) = IIf(TxtEmail2.Text = vbNullString, " ", TxtEmail2.Text) '@email2 varchar (50) = NULL ,


            '@Otros decimal(15,2)=null,
            '@Flete decimal(15,2)=null,
            '@IngBrutos char(1)=null,
            '@Procedencia varchar(100)=null,
            '@Ganancias char(1)=null,
            '@IBPorcen decimal(9,3)=null,
            '@observacion1 nvarchar (50) = NULL ,
            '@observacion2 nvarchar (50) = NULL ,
            '@email1 varchar (50) = NULL ,        
            '@email2 varchar (50) = NULL ,

            ''***************************************
            OProveedor(40) = USULOGIN '@usuario varchar(20) ,
            OProveedor(41) = "" '@Modo char(1),
            OProveedor(42) = Val(If(chktodosReg.Checked, "1", "0")) '@todosReg int=null, 
            OProveedor(43) = Val(If(ChktodosSell.Checked, "1", "0")) '@todosSell int=null,
            OProveedor(44) = TxtRuca.Text '@ruca varchar(50)=null,
            OProveedor(45) = txtRenspa.Text '@renspa varchar(50)=null,
            OProveedor(46) = Val(CmbTipoProveedor.SelectedValue) '@tipoCaracter int=3,
            OProveedor(47) = Val(TxtPuntoVenta.Text)  '@puntoVenta int=16

            ''@usuario varchar(20) ,
            '@Modo char(1),
            '@todosReg int=null,
            '@todosSell int=null,
            '@ruca varchar(50)=null,
            '@renspa varchar(50)=null,
            '@tipoCaracter int=3,
            '@puntoVenta int=16

            '***************************************

        Catch ex As Exception
            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



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

        If TxtidProveedor.Text.Trim = "" Then
            MessageBox.Show("Buscar Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtidProveedor.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Modo = "B"
        Dim Retorno As Integer
        Dim Cproveedor As New ClsGrl_Proveedor
        Dim OProveedor(1) As Object
        OProveedor(0) = TxtidProveedor.Text

        OProveedor(1) = USULOGIN

        Try
            Retorno = Cproveedor.Eliminar(OProveedor)

            If Val(Retorno) > 0 Then
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call BtnNuevo_Click(sender, e)
            Else
                MessageBox.Show("No se pudo Realizar la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            RellenarLista()


        Catch ex As Exception
            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try





    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        If TxtProvNro.Text.Trim = "" Then
            MessageBox.Show("Ingrese Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtProvNro.Focus()
            Exit Sub
        End If

        If TxtRazonSocial.Text.Trim = "" Then
            MessageBox.Show("Ingrese Razon Social", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtRazonSocial.Focus()
            Exit Sub
        End If




        OProveedorCargar()



        Dim Retorno As Integer
        Dim Cproveedor As New ClsGenerica
        Dim CVendedor As New ClsVendedor
        Try
            If TxtidProveedor.Text.Trim = "" Then

                '  OProveedor(47) = "A"

                Retorno = Cproveedor.EjecutarSP("Gen_proveedor_Abm", OProveedor)


                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else
                'OProveedor(47) = "M"
                Retorno = Cproveedor.EjecutarSP("Gen_proveedor_Abm1", OProveedor)

                If Val(Retorno) > 0 Then

                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


                    Call BtnNuevo_Click(sender, e)
                End If
            End If
        Catch ex As Exception

            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Modo = "A"

        RellenarLista()
        BuscarProveedor(OProveedor(0))
    End Sub





    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        Dim OProveedor(2) As Object

        OProveedor(0) = 0

        If RdbRazonSocial.Checked = True Then
            OProveedor(1) = txtBuscarRazonSocial.Text
        Else
            OProveedor(1) = ""
        End If


        If RdbCuit.Checked = True Then

            OProveedor(2) = TxtBuscarCuit.Text
        Else
            OProveedor(2) = ""

        End If

        Try



            Dim CPProveedores As New ClsGenerica
            Dim DT As New DataTable
            DT = CPProveedores.TraerDatos("Gen_Proveedor_Consul", OProveedor).Tables(0)
            DgProveedores.DataSource = DT
            DgProveedores.ReadOnly = True

            LimpiarFormulario()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


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
                TxtProcedencia.Text = DT.Rows(0).Item("procedencia").ToString()
                CmbcondIva.SelectedValue = DT.Rows(0).Item("condIva").ToString()
                CmbTipoProveedor.SelectedValue = DT.Rows(0).Item("tipocaracter").ToString()
                TxtProcedencia.Text = DT.Rows(0).Item("procedencia").ToString()

                ' falta el chequed de ganancias 
                ' falta el chequed de Ingresos Brutos 




                TxtCalle.Text = DT.Rows(0).Item("calle").ToString()
                TxtNumero.Text = DT.Rows(0).Item("numero").ToString()
                Txtpiso.Text = DT.Rows(0).Item("piso").ToString()
                TxtCPostal.Text = DT.Rows(0).Item("CPostal").ToString()
                CmbPais.SelectedValue = DT.Rows(0).Item("idpais").ToString()
                CmbProvincia.SelectedValue = DT.Rows(0).Item("IdProvincia").ToString()
                CmbLocalidad.SelectedValue = DT.Rows(0).Item("idlocalidad").ToString()
                txtTelPart.Text = DT.Rows(0).Item("TelPart").ToString()
                TxtTelFax.Text = DT.Rows(0).Item("Telfax").ToString()
                TxtTelCel.Text = DT.Rows(0).Item("Telcel").ToString()

                ' PARTE COMERCIAL
                txtRsComercial.Text = DT.Rows(0).Item("RsComercial").ToString()
                txtDomicom.Text = DT.Rows(0).Item("Domicicom").ToString()
                cmbIdLocaCom.SelectedValue = DT.Rows(0).Item("IdLocaCom").ToString()

                txtTelCom.Text = DT.Rows(0).Item("TelCom").ToString()
                TxtTelFaxCom.Text = DT.Rows(0).Item("TelFaxCom").ToString()
                txtCPostalCom.Text = DT.Rows(0).Item("CPostalCom").ToString()

                TxtObservacion1.Text = DT.Rows(0).Item("Observacion1").ToString()
                TxtObservacion2.Text = DT.Rows(0).Item("Observacion2").ToString()
                TxtEmail1.Text = DT.Rows(0).Item("Email1").ToString()
                TxtEmail2.Text = DT.Rows(0).Item("Email2").ToString()
                TxtRuca.Text = DT.Rows(0).Item("Ruca").ToString()


                TxtComision.Text = DT.Rows(0).Item("comision").ToString()
                TxtComision2.Text = DT.Rows(0).Item("comision2").ToString()
                TxtImpSellos.Text = DT.Rows(0).Item("ImpSellos").ToString()
                txtDerRegistro.Text = DT.Rows(0).Item("DerRegistro").ToString()
                TxtMbs.Text = DT.Rows(0).Item("Mbs").ToString()
                TxtRec.Text = DT.Rows(0).Item("rec").ToString()
                TxtFGarantia.Text = DT.Rows(0).Item("FGarantia").ToString()
                TxtGastoFrigor.Text = DT.Rows(0).Item("GastoFrigor").ToString()
                txtGuia.Text = DT.Rows(0).Item("guia").ToString()
                txtotros.Text = DT.Rows(0).Item("otros").ToString()
                txtFlete.Text = DT.Rows(0).Item("flete").ToString()
                TxtIBPorcen.Text = DT.Rows(0).Item("IBPorcen").ToString()

                Modo = "M"

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


#Region "CARGAR COMBOS"
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

            With cmbIdLocaCom
                .DataSource = DT
                .DisplayMember = "Nombre"
                .ValueMember = "idlocalidad"
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Localidad", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Cargar Combo Provincia
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


            ' Logger.e("Error con excepción", ex)
            'Logger.d("Debug con traza", New StackFrame(True))
            ' Logger.i("Info sin traza", New StackFrame(True))
            ' Logger.e("Error con excepción y traza", ex, New StackFrame(True))
            'Logger.e(ex.Message, ex)
            'Logger.w(ex.Message,)
            'Logger.e(ex.Message, ex)
            'Logger.e(ex.Message, ex)

            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso- Pais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub CargarCondIva()


        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.TraerDatos("condiva_ot").Tables(0)
            With CmbcondIva
                .DataSource = DT
                .DisplayMember = "Descripcion"
                .ValueMember = "IdcondIva"
            End With
        Catch ex As Exception


            ' Logger.e("Error con excepción", ex)
            'Logger.d("Debug con traza", New StackFrame(True))
            ' Logger.i("Info sin traza", New StackFrame(True))
            ' Logger.e("Error con excepción y traza", ex, New StackFrame(True))
            'Logger.e(ex.Message, ex)
            'Logger.w(ex.Message,)
            'Logger.e(ex.Message, ex)
            'Logger.e(ex.Message, ex)

            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso- Pais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CargarTipoProveedor()


        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.TraerDatos("ProveedorTipo_Ot").Tables(0)
            With CmbTipoProveedor
                .DataSource = DT
                .DisplayMember = "Descripcion"
                .ValueMember = "IdProveedorTipo"
            End With
        Catch ex As Exception


            ' Logger.e("Error con excepción", ex)
            'Logger.d("Debug con traza", New StackFrame(True))
            ' Logger.i("Info sin traza", New StackFrame(True))
            ' Logger.e("Error con excepción y traza", ex, New StackFrame(True))
            'Logger.e(ex.Message, ex)
            'Logger.w(ex.Message,)
            'Logger.e(ex.Message, ex)
            'Logger.e(ex.Message, ex)

            ELog.Grabar(Me, ex)
            MessageBox.Show(ex.Message, "Aviso- Pais", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region


    Private Sub LimpiarFormulario()


        TxtidProveedor.Clear()
        TxtProvNro.Clear()
        TxtRazonSocial.Clear()
        TxtCuit.Clear()
        CmbcondIva.SelectedIndex = 0
        TxtCalle.Clear()
        TxtNumero.Clear()
        Txtpiso.Clear()
        CmbLocalidad.SelectedIndex = 0
        CmbPais.SelectedIndex = 0
        CmbProvincia.SelectedIndex = 0
        txtTelPart.Clear()
        TxtTelFax.Clear()
        TxtTelCel.Clear()
        TxtCPostal.Clear()






        'txtusuario.Clear()
        'TxtPassword.Clear()
        'TxtCodigo.Clear()
        'txtnombres.Clear()
        'txtapellidos.Clear()


        'txtusuario.Focus()
    End Sub

    Private Sub PnlDetalle_Paint(sender As Object, e As PaintEventArgs) Handles PnlDetalle.Paint

    End Sub




    'Dim txt As Object
    '    Dim txtTemporal As TextBox
    '    Dim Cmbtemporal As ComboBox

    '    For Each txt In control.Controls

    '        If TypeOf txt Is TextBox Then

    '            txtTemporal = CType(txt, TextBox)

    '            txtTemporal.Clear()


    '        ElseIf TypeOf txt Is ComboBox Then

    '            Cmbtemporal = CType(txt, ComboBox)
    '            Cmbtemporal.SelectedIndex = 0
    '        End If

    '    Next



    'Dim obj As Control
    '    For Each obj In
    '    control.Controls
    '        If TypeOf (obj) Is TextBox Then
    '            obj.Text = ""
    '            CType(obj, TextBox).ReadOnly = False
    '        End If
    '    Next




    ' End Sub





























#End Region


End Class