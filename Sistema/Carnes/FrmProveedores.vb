
Imports System.Runtime.InteropServices
Public Class FrmProveedores


    Private currentButton As Button
    Private random As Random
    Private tempIndex As Integer


    Dim Modo As String

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

        Dim OProveedor(48) As Object

        '         @idproveedor int = null ,
        '@provNro int = NULL ,
        '@razonSocial varchar (100) = null ,
        '@CUIT varchar (20) = NULL ,
        '@condIva int = NULL ,
        '@calle varchar (100) = NULL ,
        '@numero varchar (5) = NULL ,
        '@piso varchar (5) = NULL ,
        '@idLocalidad int = NULL ,
        '@idprovincia int = NULL ,
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
        '@usuario varchar(20) ,
        '@Modo char(1),
        '@todosReg int=null,
        '@todosSell int=null,
        '@ruca varchar(50)=null,
        '@renspa varchar(50)=null,
        '@tipoCaracter int=3,
        '@puntoVenta int=16




        Dim Retorno As Integer
        Dim Cproveedor As New ClsGenerica
        Dim CVendedor As New ClsVendedor
        Try
            If TxtidProveedor.Text.Trim = "" Then

                Retorno = Cproveedor.EjecutarSP("Gen_proveedor_Abm", OProveedor)




                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else

                Retorno = Cproveedor.EjecutarSP("Gen_proveedor_Abm", OProveedor)

                If Val(Retorno) > 0 Then

                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Modo = "A"

        RellenarLista()
        LimpiarFormulario()
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
                TxtIngBrutos.Text = DT.Rows(0).Item("IngBrutos").ToString()

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