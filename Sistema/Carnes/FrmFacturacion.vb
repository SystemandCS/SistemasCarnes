Imports Microsoft.Reporting.WinForms

Public Class FrmFacturacion

    Private Sub RellenarComboFormadePago()
        Try
            Dim CFacCab As New ClsFormadePago
            Dim DT As New DataTable
            DT = CFacCab.FormadePagoCombo()
            With CmbFormadePago
                .DataSource = DT
                .DisplayMember = "FORMADEPAGO"
                .ValueMember = "CODFORMA"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Function CotizacionYaEstaFacturado(COTCOD As String) As Integer
        Dim Retorno As Integer = 0
        Try
            Dim CprodDet As New ClsCotizacionCab
            Dim DT As New DataTable
            DT = CprodDet.CotizacionFacturado(COTCOD)
            If DT.Rows.Count > 0 Then
                Retorno = Val(DT.Rows(0).Item("Retorno").ToString())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function


    Private Function CuentaDetalles(FACCOD As String) As Integer
        Dim Retorno As Integer = 0
        Try
            Dim CprodDet As New ClsFacturacionDet
            Dim DT As New DataTable
            DT = CprodDet.ListaFacturacionDet(FACCOD)
            Retorno = DT.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function


    Private Sub RellenarComboDocumentos()
        Try
            Dim CFacCab As New ClsFacturacionCab
            Dim DT As New DataTable
            DT = CFacCab.DocumentosParaFacturacion()
            With CbDocumento
                .DataSource = DT
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "SERCOD"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaCotizacion(Codigo As String)
        Try
            Dim CCotizacionCab As New ClsCotizacionCab
            Dim DT As New DataTable
            DT = CCotizacionCab.BuscaCotizacionCab( Codigo)
            If DT.Rows.Count > 0 Then
                If DT.Rows(0).Item("ESTADO").ToString().ToUpper() = "CERRADO" Then
                    TxtCodCotizacion.Text = DT.Rows(0).Item("COTCOD").ToString()
                    txtSerieCotizacion.Text = DT.Rows(0).Item("SERIE").ToString()
                    TxtCorrelativoCotizacion.Text = DT.Rows(0).Item("CORRELATIVO").ToString()
                    TxtCodigoCliente.Text = DT.Rows(0).Item("CLICOD").ToString()
                    txtRazonSocial.Text = DT.Rows(0).Item("CLIRAZONSOCIAL").ToString()

                Else
                    MessageBox.Show("Para la Facturacion necesita una Cotizacion en estado CERRADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub BuscaFacturacionDET(Codigo As String)
        Try
            Dim cPROD As New ClsFacturacionDet
            Dim DT As New DataTable
            DT = cPROD.ListaFacturacionDet2(Codigo)
            If DT.Rows.Count > 0 Then
                TxtFACCODDET.Text = DT.Rows(0).Item("FACCODDET").ToString()
                TxtCodigoArticulo.Text = DT.Rows(0).Item("ARTCOD").ToString()
                TxtDescripcionArticulo.Text = DT.Rows(0).Item("ARTDES").ToString()
                TxtCantidad.Text = DT.Rows(0).Item("CANTIDAD").ToString()
                TxtPrecio.Text = DT.Rows(0).Item("PRECIO").ToString()
                TxtTotal.Text = DT.Rows(0).Item("TOTAL").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub BuscaFacturacion(Codigo As String)
        Try
            Dim CFacCab As New ClsFacturacionCab
            Dim DT As New DataTable
            DT = CFacCab.BuscaFacturacionCab(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("FACCOD").ToString()
                txtEstado.Text = DT.Rows(0).Item("ESTADO").ToString()
                CbDocumento.SelectedValue = DT.Rows(0).Item("SERCOD").ToString()
                txtSerie.Text = DT.Rows(0).Item("SERIE").ToString()
                TxtCorrelativo.Text = DT.Rows(0).Item("CORRELATIVO").ToString()
                txtFecha.Text = DT.Rows(0).Item("FECHA").ToString()
                TxtCodigoCliente.Text = DT.Rows(0).Item("CLICOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("CLIRAZONSOCIAL").ToString()
                TxtImpuesto.Text = DT.Rows(0).Item("IMPUESTO").ToString()
                txtObservacion.Text = DT.Rows(0).Item("OBSERVACION").ToString()
                TxtCodCotizacion.Text = DT.Rows(0).Item("COTCOD").ToString()
                txtSerieCotizacion.Text = DT.Rows(0).Item("SerieCotizacion").ToString()
                TxtCorrelativoCotizacion.Text = DT.Rows(0).Item("CorrelativoCotizacion").ToString()
                TxtSubTotal.Text = DT.Rows(0).Item("SUBTOTAL").ToString()
                txtSubTotalImpuesto.Text = DT.Rows(0).Item("SUBTOTALIMPUESTO").ToString()
                TxtTotalGeneral.Text = DT.Rows(0).Item("TOTALGENERAL").ToString()
                LBLTotalLetras.Text = DT.Rows(0).Item("TOTALLETRAS").ToString()
                CmbFormadePago.SelectedValue = DT.Rows(0).Item("CODFORMA").ToString()

                If TxtCodCotizacion.Text <> "" Then
                    BtnBuscarCliente.Enabled = False
                    BtnBuscarCotizacion.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function DetallesCotizacionParaFacturacion(COTCOD As String, FACCOD As String) As String
        Dim Retorno As String = ""
        Dim CFacCab As New ClsFacturacionCab
        Try
            Retorno = CFacCab.DetallesCotizacionParaFacturacion(COTCOD, FACCOD)
            If Val(Retorno) > 0 Then
                RellenarListaDet(FACCOD)
                BtnBuscarCliente.Enabled = False
                BtnBuscarCotizacion.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function

    Private Function ActualizarTotales(FACCOD As String, SUBTOTAL As Double, SUBTOTALIMPUESTO As Double, TOTALGENERAL As Double, TOTALLETRAS As String) As String
        Dim Retorno As String = ""
        Dim CFacCab As New ClsFacturacionCab
        Try
            Retorno = CFacCab.ActualizarTotales(FACCOD, SUBTOTAL, SUBTOTALIMPUESTO, TOTALGENERAL, TOTALLETRAS)
            If Val(Retorno) > 0 Then
                BuscaFacturacion(Retorno)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function

    Private Sub ListaFacturacionDetTotales(FACCOD As String)
        Try
            Dim CFacDet As New ClsFacturacionDet
            Dim cProdMoneda As New ClsMonedaALetras
            Dim DT As New DataTable
            DT = CFacDet.ListaFacturacionDetTotales(FACCOD)
            If DT.Rows.Count > 0 Then
                TxtSubTotal.Text = DT.Rows(0).Item("SUBTOTAL").ToString()
                txtSubTotalImpuesto.Text = DT.Rows(0).Item("SUBTOTALIMPUESTO").ToString()
                TxtTotalGeneral.Text = DT.Rows(0).Item("TOTALGENERAL").ToString()
                LBLTotalLetras.Text = cProdMoneda.olpol(TxtTotalGeneral.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function BuscarImpuesto() As Double
        Dim Retorno As Double = 0
        Try
            Dim CImpuestos As New ClsImpuestos
            Dim DT As New DataTable
            DT = CImpuestos.BuscaImpuestos()
            If DT.Rows.Count > 0 Then
                Retorno = Val(DT.Rows(0).Item("VALOR").ToString())
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function

    Private Sub GeneraSerieCorrelativo(SERCOD As String)
        Try
            Dim CFacCab As New ClsFacturacionCab
            Dim DT As New DataTable
            DT = CFacCab.SerieFacturacionCab(SERCOD)
            If DT.Rows.Count > 0 Then
                txtSerie.Text = DT.Rows(0).Item("SERIE").ToString()
                TxtCorrelativo.Text = DT.Rows(0).Item("CORRELATIVO").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LimpiarCabecera()
        TxtCodigo.Clear()
        BtnBuscarCliente.Enabled = True
        BtnBuscarCotizacion.Enabled = True
        txtFecha.Text = Now
        LBLTotalLetras.Text = ""
        txtEstado.Text = "ABIERTO"
        TxtImpuesto.Text = CStr(BuscarImpuesto())
        txtSerie.Clear()
        TxtCorrelativo.Clear()
        TxtCodigoCliente.Clear()
        txtRazonSocial.Clear()
        TxtCodCotizacion.Clear()
        txtSerieCotizacion.Clear()
        TxtCorrelativoCotizacion.Clear()
        txtObservacion.Clear()
        TxtTotalGeneral.Clear()
        TxtSubTotal.Clear()
        txtSubTotalImpuesto.Clear()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub LimpiarDetalle()
        TxtFACCODDET.Clear()
        TxtCodigoArticulo.Clear()
        TxtDescripcionArticulo.Clear()
        TxtCantidad.Clear()
        TxtPrecio.Clear()
        TxtTotal.Clear()
    End Sub

    Private Sub BuscaArticulo(Codigo As String)
        Try
            Dim CArticulos As New ClsArticulos
            Dim DT As New DataTable
            DT = CArticulos.BuscaArticulos(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigoArticulo.Text = DT.Rows(0).Item("ARTCOD").ToString()
                TxtDescripcionArticulo.Text = DT.Rows(0).Item("ARTDES").ToString()
                TxtPrecio.Text = DT.Rows(0).Item("ARTPRECIO").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaCliente(Codigo As String)
        Try
            Dim CCliente As New ClsClientes
            Dim DT As New DataTable
            DT = CCliente.BuscaClientes(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigoCliente.Text = DT.Rows(0).Item("CLICOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("CLIRAZONSOCIAL").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarListaDet(FACCOD As String)
        Try
            Dim CprodDet As New ClsFacturacionDet
            Dim DT As New DataTable
            DT = CprodDet.ListaFacturacionDet(FACCOD)
            With DataGridView1
                .DataSource = DT
                .ReadOnly = True
                .Columns(0).Visible = False 'FACCODDET
                .Columns(1).Visible = False 'COTCOD
                .Columns(2).Width = 45 'Item
                .Columns(3).Width = 100 'Codigo_Articulo
                .Columns(4).Width = 220 'Descripcion
                .Columns(5).Width = 80 'Cantidad
                .Columns(6).Width = 80 'Precio
                .Columns(7).Width = 80 'Total
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub FrmFacturacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmFacturacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
        TxtFACCODDET.Visible = False
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCabecera()
        LimpiarDetalle()
        RellenarComboDocumentos()
        RellenarComboFormadePago()
        GeneraSerieCorrelativo(CbDocumento.SelectedValue)
        BtnBuscarCliente.Focus()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        If txtFecha.Text.Trim = "" Then
            MessageBox.Show("Haga Click en Nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnNuevo.Focus()
            Exit Sub
        End If

        If TxtCodigoCliente.Text.Trim = "" Then
            MessageBox.Show("Falta Ingresar Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscarCliente.Focus()
            Exit Sub
        End If

        If txtEstado.Text.ToUpper.Trim = "CERRADO" Then
            MessageBox.Show("En estado CERRADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtEstado.Text.ToUpper.Trim = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If CbDocumento.Text = "" Then
            MessageBox.Show("Seleccione Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbDocumento.Focus()
            Exit Sub
        End If
        If CmbFormadePago.Text = "" Then
            MessageBox.Show("Seleccione Forma de Pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CmbFormadePago.Focus()
            Exit Sub
        End If

        If TxtCodCotizacion.Text.Trim <> "" And CotizacionYaEstaFacturado(TxtCodCotizacion.Text) > 0 Then
            MessageBox.Show("La Cotizacion ya esta Facturado verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If TxtCodCotizacion.Text.Trim <> "" And TxtCodCotizacion.Text.Trim <> "" Then
            If CuentaDetalles(TxtCodigo.Text) > 0 Then
                MessageBox.Show("La Cotizacion No puedes Agregarla a esta operacion porque ya tiene Items agregados en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        Dim Retorno As String = ""
        Dim CProcedimiento As New ClsFacturacionCab
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = CProcedimiento.InsertaFacturacionCab(CbDocumento.SelectedValue, txtSerie.Text, TxtCodigoCliente.Text, Val(TxtImpuesto.Text), txtObservacion.Text, TxtCodCotizacion.Text, USUCOD, CmbFormadePago.SelectedValue)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BuscaFacturacion(Retorno)
                    If TxtCodCotizacion.Text <> "" Then
                        DetallesCotizacionParaFacturacion(TxtCodCotizacion.Text, Retorno)
                        ListaFacturacionDetTotales(TxtCodigo.Text)
                        ActualizarTotales(TxtCodigo.Text, Val(TxtSubTotal.Text), Val(txtSubTotalImpuesto.Text), Val(TxtTotalGeneral.Text), LBLTotalLetras.Text)
                    End If
                End If
            Else
                Retorno = CProcedimiento.ActualizaFacturacionCab(TxtCodigo.Text, TxtCodigoCliente.Text, txtObservacion.Text, TxtCodCotizacion.Text, USUCOD, CmbFormadePago.SelectedValue)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If txtEstado.Text.ToUpper.Trim = "CERRADO" Then
            MessageBox.Show("En estado CERRADO no se puede Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtEstado.Text.ToUpper.Trim = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede Eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscar.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim Retorno As String
        Dim CProcedimiento As New ClsFacturacionCab
        Try
            Retorno = CProcedimiento.EliminaFacturacionCab(TxtCodigo.Text)
            If Val(Retorno) = 0 Then
                MessageBox.Show("Registro Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call BtnNuevo_Click(sender, e)
            Else
                MessageBox.Show("No se pudo Realizar la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim FRM As New FrmBuscarFacturacion
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaFacturacion(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
                RellenarListaDet(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscar.Focus()
            Exit Sub
        End If

        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsPROD As New ClsFacturacionCab

        Try
            FRM.MdiParent = Me.MdiParent
            FRM.Text = "FACTURACION"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptFacturacion.rdlc"
            DT = ClsPROD.RPTFacturacion(TxtCodigo.Text)
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscar.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Anular el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If txtEstado.Text.ToUpper.Trim = "ANULADO" Then
            MessageBox.Show("El Registro ya se encuentra en estado ANULADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtEstado.Text.ToUpper.Trim = "ABIERTO" Then
            MessageBox.Show("En estado ABIERTO no se puede ANULAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BtnBuscar.Focus()
            Exit Sub
        End If

        Dim Retorno As String = ""
        Dim CPROD As New ClsFacturacionCab
        Try
            Retorno = CPROD.AnularFacturacionCab(TxtCodigo.Text, USUCOD)
            If Retorno = "ANULADO" Then
                MessageBox.Show("Registro ANULADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscaFacturacion(TxtCodigo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnCerrarEstado_Click(sender As Object, e As EventArgs) Handles BtnCerrarEstado.Click
        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscar.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Cerrar la Facturacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If txtEstado.Text.ToUpper.Trim = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede CERRAR", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtEstado.Text.ToUpper.Trim = "CERRADO" Then
            MessageBox.Show("El Registro ya se encuentra en estado CERRADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If CuentaDetalles(TxtCodigo.Text) = 0 Then
            MessageBox.Show("No puedes realizar esta operacion porque no tiene Items agregados en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim Retorno As String = ""
        Dim CPROD As New ClsFacturacionCab
        Try
            Retorno = CPROD.CerrarFacturacionCab(TxtCodigo.Text, USUCOD)
            If Retorno = "CERRADO" Then
                MessageBox.Show("Registro CERRADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscaFacturacion(TxtCodigo.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnNuevoDetalle_Click(sender As Object, e As EventArgs) Handles BtnNuevoDetalle.Click
        If txtEstado.Text.ToUpper = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEstado.Text.ToUpper = "CERRADO" Then
            MessageBox.Show("En estado CERRADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        LimpiarDetalle()
        BtnBuscarArticulo.Focus()
    End Sub

    Private Sub BtnGrabarDetalle_Click(sender As Object, e As EventArgs) Handles BtnGrabarDetalle.Click
        If txtEstado.Text.ToUpper = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEstado.Text.ToUpper = "CERRADO" Then
            MessageBox.Show("En estado CERRADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtCodigoArticulo.Text.Trim = "" Then
            MessageBox.Show("Falta el campo Articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BtnBuscarArticulo.Focus()
            Exit Sub
        End If

        If Val(TxtCantidad.Text) <= 0 Then
            MessageBox.Show("FIngrese Cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtCantidad.Focus()
            Exit Sub
        End If

        If Val(TxtPrecio.Text) < 0 Then
            MessageBox.Show("FIngrese Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPrecio.Focus()
            Exit Sub
        End If

        Dim Retorno As String = ""
        Dim CPROD As New ClsFacturacionDet
        Try
            If TxtFACCODDET.Text.Trim = "" Then
                Retorno = CPROD.InsertaFacturacionDet(TxtCodigo.Text, TxtCodigoArticulo.Text, Val(TxtCantidad.Text), Val(TxtPrecio.Text), Val(TxtTotal.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Articulo Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnNuevoDetalle_Click(sender, e)
                End If
            Else
                Retorno = CPROD.ActualizaFacturacionDet(Val(TxtFACCODDET.Text), TxtCodigoArticulo.Text, Val(TxtCantidad.Text), Val(TxtPrecio.Text), Val(TxtTotal.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Articulo Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnNuevoDetalle_Click(sender, e)
                End If
            End If
            ListaFacturacionDetTotales(TxtCodigo.Text)
            ActualizarTotales(TxtCodigo.Text, Val(TxtSubTotal.Text), Val(txtSubTotalImpuesto.Text), Val(TxtTotalGeneral.Text), LBLTotalLetras.Text)
            RellenarListaDet(TxtCodigo.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnEliminarDetalle_Click(sender As Object, e As EventArgs) Handles BtnEliminarDetalle.Click
        If txtEstado.Text.ToUpper = "ANULADO" Then
            MessageBox.Show("En estado ANULADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEstado.Text.ToUpper = "CERRADO" Then
            MessageBox.Show("En estado CERRADO no se puede hacer cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtFACCODDET.Text.Trim = "" Then
            MessageBox.Show("Seleccione Articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Item Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Dim Retorno As String
        Dim CPROD As New ClsFacturacionDet
        Try
            Retorno = CPROD.EliminaFacturacionDet(Val(TxtFACCODDET.Text))
            If Val(Retorno) = 0 Then
                MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call BtnNuevoDetalle_Click(sender, e)
            Else
                MessageBox.Show("No se pudo Realizar la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


        ListaFacturacionDetTotales(TxtCodigo.Text)
        ActualizarTotales(TxtCodigo.Text, Val(TxtSubTotal.Text), Val(txtSubTotalImpuesto.Text), Val(TxtTotalGeneral.Text), LBLTotalLetras.Text)
        RellenarListaDet(TxtCodigo.Text)
    End Sub

    Private Sub BtnBuscarArticulo_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulo.Click
        Dim FRM As New FrmBuscarArticulos
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaArticulo(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        Dim FRM As New FrmBuscarClientes
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaCliente(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        TxtTotal.Text = Format(Val(TxtCantidad.Text) * Val(TxtPrecio.Text), "###0.#0")
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        TxtCantidad_TextChanged(sender, e)
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If SoloMonedas(TxtPrecio, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPrecio.KeyPress
        If SoloMonedas(TxtPrecio, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBuscarCotizacion_Click(sender As Object, e As EventArgs) Handles BtnBuscarCotizacion.Click
        Dim CodigoCotizacion As String = ""

        If txtEstado.Text.ToUpper() = "ABIERTO" Then
            Dim FRM As New FrmBuscarCotizacion
            With FRM
                .ShowDialog()
                If .DataGridView1.CurrentRow Is Nothing Then
                    Exit Sub
                End If

                CodigoCotizacion = .DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString

                If .Fila >= 0 Then
                    If CotizacionYaEstaFacturado(CodigoCotizacion) > 0 Then
                        MessageBox.Show("La Cotizacion ya esta Facturado verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    If CodigoCotizacion <> "" Then
                        If CuentaDetalles(TxtCodigo.Text) > 0 Then
                            MessageBox.Show("La Cotizacion No puedes Agregarla a esta operacion porque ya tiene Items agregados en la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                    BuscaCotizacion(CodigoCotizacion)
                End If
            End With
        End If
    End Sub

    Private Sub CbDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbDocumento.SelectedIndexChanged

        GeneraSerieCorrelativo(CbDocumento.SelectedValue.ToString)

    End Sub

    Private Sub TxtCantidad_Leave(sender As Object, e As EventArgs) Handles TxtCantidad.Leave
        TxtCantidad.Text = Format(Val(TxtCantidad.Text), "###0.#0")
    End Sub

    Private Sub TxtPrecio_Leave(sender As Object, e As EventArgs) Handles TxtPrecio.Leave
        TxtPrecio.Text = Format(Val(TxtPrecio.Text), "###0.#0")
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DataGridView1.CurrentRow.Index
            BuscaFacturacionDET(DataGridView1.Rows(Fila).Cells(0).Value.ToString())
        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub
End Class