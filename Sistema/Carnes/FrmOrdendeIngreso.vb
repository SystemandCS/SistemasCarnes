Imports Microsoft.Reporting.WinForms

Public Class FrmOrdendeIngreso

    Private Function CuentaDetalles(COTCOD As String) As Integer
        Dim Retorno As Integer = 0
        Try
            Dim CprodDet As New ClsOrdendeIngresoDet
            Dim DT As New DataTable
            DT = CprodDet.ListaOrdIngDet(COTCOD)
            Retorno = DT.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function


    Private Sub BuscaOrdIngDET(Codigo As String)
        Try
            Dim COrdIngDet As New ClsOrdendeIngresoDet
            Dim DT As New DataTable
            DT = COrdIngDet.ListaOrdIngDet2(Codigo)
            If DT.Rows.Count > 0 Then
                TxtORDINGDETCOD.Text = DT.Rows(0).Item("ORDINGDETCOD").ToString()
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

    Private Function ActualizarTotales(ORDINGCOD As String, SUBTOTAL As Double, SUBTOTALIMPUESTO As Double, TOTALGENERAL As Double, TOTALLETRAS As String) As String
        Dim Retorno As String = ""
        Dim COrdIng As New ClsOrdendeIngreso
        Try

            Retorno = COrdIng.ActualizarTotales(ORDINGCOD, SUBTOTAL, SUBTOTALIMPUESTO, TOTALGENERAL, TOTALLETRAS)
            If Val(Retorno) > 0 Then
                BuscaOrdendeIngreso(Retorno)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function

    Private Sub ListaOrdIngDetTotales(Codigo As String)
        Try
            Dim COrdIngDet As New ClsOrdendeIngresoDet
            Dim cProdMoneda As New ClsMonedaALetras
            Dim DT As New DataTable
            DT = COrdIngDet.ListaOrIngDetTotales(Codigo)
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

    Private Sub BuscaOrdendeIngreso(Codigo As String)
        Try
            Dim COrdIng As New ClsOrdendeIngreso
            Dim DT As New DataTable
            DT = COrdIng.BuscaOrdendeIngreso(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("ORDINGCOD").ToString()
                txtEstado.Text = DT.Rows(0).Item("ESTADO").ToString()
                txtSerie.Text = DT.Rows(0).Item("ORDSERIE").ToString()
                TxtCorrelativo.Text = DT.Rows(0).Item("ORDCORRELATIVO").ToString()
                txtFecha.Text = DT.Rows(0).Item("ORDFECHA").ToString()
                TxtCodProveedor.Text = DT.Rows(0).Item("PROCOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("PRORAZONSOCIAL").ToString()
                TxtImpuesto.Text = DT.Rows(0).Item("IMPUESTO").ToString()
                txtObservacion.Text = DT.Rows(0).Item("OBSERVACION").ToString()
                TxtCotizacion.Text = DT.Rows(0).Item("NROCOTIZACION").ToString()
                TxtSubTotal.Text = DT.Rows(0).Item("SUBTOTAL").ToString()
                txtSubTotalImpuesto.Text = DT.Rows(0).Item("SUBTOTALIMPUESTO").ToString()
                TxtTotalGeneral.Text = DT.Rows(0).Item("TOTALGENERAL").ToString()
                LBLTotalLetras.Text = DT.Rows(0).Item("TOTALLETRAS").ToString()
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

    Private Sub GeneraSerieCorrelativo()
        Try
            Dim CIngOrd As New ClsOrdendeIngreso
            Dim DT As New DataTable
            DT = CIngOrd.SerieOrdendeIngreso()
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
        txtFecha.Text = Now
        LBLTotalLetras.Text = ""
        txtEstado.Text = "ABIERTO"
        TxtImpuesto.Text = CStr(BuscarImpuesto())
        txtSerie.Clear()
        TxtCorrelativo.Clear()
        TxtCodProveedor.Clear()
        txtRazonSocial.Clear()
        TxtCotizacion.Clear()
        txtObservacion.Clear()
        TxtTotalGeneral.Clear()
        TxtSubTotal.Clear()
        txtSubTotalImpuesto.Clear()
        Call GeneraSerieCorrelativo()
        DataGridView1.DataSource = Nothing
    End Sub

    Private Sub LimpiarDetalle()
        TxtORDINGDETCOD.Clear()
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

    Private Sub BuscaProveedor(Codigo As String)
        Try
            Dim CProveedores As New ClsProveedores
            Dim DT As New DataTable
            DT = CProveedores.BuscaProveedores(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodProveedor.Text = DT.Rows(0).Item("PROCOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("PRORAZONSOCIAL").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarListaDet(ORDINGCOD As String)
        Try
            Dim CprodDet As New ClsOrdendeIngresoDet
            Dim DT As New DataTable
            DT = CprodDet.ListaOrdIngDet(ORDINGCOD)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Visible = False 'ORDINGDETCOD
            DataGridView1.Columns(1).Visible = False 'ORDINGCOD
            DataGridView1.Columns(2).Width = 45 'Item
            DataGridView1.Columns(3).Width = 100 'Codigo_Articulo
            DataGridView1.Columns(4).Width = 220 'Descripcion
            DataGridView1.Columns(5).Width = 80 'Cantidad
            DataGridView1.Columns(6).Width = 80 'Precio
            DataGridView1.Columns(7).Width = 80 'Total
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LimpiarCabecera()
        LimpiarDetalle()
        BtnBuscarProveedor.Focus()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If txtFecha.Text.Trim = "" Then
            MessageBox.Show("Haga Click en Nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnNuevo.Focus()
            Exit Sub
        End If

        If TxtCodProveedor.Text.Trim = "" Then
            MessageBox.Show("Falta Ingresar Proveedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscarProveedor.Focus()
            Exit Sub
        End If

        If txtSerie.Text.Trim = "" Then
            MessageBox.Show("Falta Serie", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If TxtCorrelativo.Text.Trim = "" Then
            MessageBox.Show("Falta Correlativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If TxtImpuesto.Text.Trim = "" Then
            MessageBox.Show("Falta Impuesto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        Dim Retorno As String = ""
        Dim COrdIng As New ClsOrdendeIngreso
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = COrdIng.InsertaOrdendeIngreso(txtSerie.Text, TxtCodProveedor.Text, Val(TxtImpuesto.Text), txtObservacion.Text, TxtCotizacion.Text, USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BuscaOrdendeIngreso(Retorno)
                End If
            Else
                Retorno = COrdIng.ActualizaOrdendeIngreso(TxtCodigo.Text, TxtCodProveedor.Text, txtObservacion.Text, TxtCotizacion.Text, USUCOD)
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
        Dim COrdIng As New ClsOrdendeIngreso
        Try
            Retorno = COrdIng.EliminaOrdendeIngreso(TxtCodigo.Text)
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
        Dim FRM As New FrmBuscarOrdendeIngreso
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaOrdendeIngreso(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
                RellenarListaDet(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
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
        Dim ClsProc As New ClsOrdendeIngreso

        Try
            FRM.MdiParent = Me.MdiParent
            FRM.Text = "ORDEN DE INGRESO"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptOrdendeIngreso.rdlc"
            DT = ClsProc.RPTOrdIng(TxtCodigo.Text)
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

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        TxtTotal.Text = Format(Val(TxtCantidad.Text) * Val(TxtPrecio.Text), "###0.#0")
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecio.TextChanged
        TxtCantidad_TextChanged(sender, e)
    End Sub

    Private Sub FrmOrdendeIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmOrdendeIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmOrdendeIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
        TxtORDINGDETCOD.Visible = False
    End Sub

    Private Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click
        Dim FRM As New FrmBuscarProveedores
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaProveedor(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
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

    Private Sub TxtCotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCotizacion.KeyPress
        If SoloNumeros(Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTotalGeneral_TextChanged(sender As Object, e As EventArgs) Handles TxtTotalGeneral.TextChanged
        ' Dim CProd As New ClsMonedaALetras
        ' LBLTotalLetras.Text = CProd.olpol(Val(TxtTotalGeneral.Text))
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnBuscar.Focus()
            Exit Sub
        End If


        If MessageBox.Show("¿Desea Anular la Orden de Ingreso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
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
        Dim COrdIng As New ClsOrdendeIngreso
        Try

            Retorno = COrdIng.AnularOrdendeIngreso(TxtCodigo.Text, USUCOD)
            If Retorno = "ANULADO" Then
                MessageBox.Show("Registro ANULADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscaOrdendeIngreso(TxtCodigo.Text)
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

        If MessageBox.Show("¿Desea Cerrar la Orden de Ingreso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
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
        Dim COrdIng As New ClsOrdendeIngreso
        Try
            Retorno = COrdIng.CerrarOrdendeIngreso(TxtCodigo.Text, USUCOD)
            If Retorno = "CERRADO" Then
                MessageBox.Show("Registro CERRADO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BuscaOrdendeIngreso(TxtCodigo.Text)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
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
        Dim CIngOrdDet As New ClsOrdendeIngresoDet
        Try
            If TxtORDINGDETCOD.Text.Trim = "" Then
                Retorno = CIngOrdDet.InsertaOrdIngDet(TxtCodigo.Text, TxtCodigoArticulo.Text, Val(TxtCantidad.Text), Val(TxtPrecio.Text), Val(TxtTotal.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Articulo Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnNuevoDetalle_Click(sender, e)
                End If
            Else
                Retorno = CIngOrdDet.ActualizaOrdIngDet(Val(TxtORDINGDETCOD.Text), TxtCodigoArticulo.Text, Val(TxtCantidad.Text), Val(TxtPrecio.Text), Val(TxtTotal.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Articulo Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BtnNuevoDetalle_Click(sender, e)
                End If
            End If
            ListaOrdIngDetTotales(TxtCodigo.Text)
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

        If TxtORDINGDETCOD.Text.Trim = "" Then
            MessageBox.Show("Seleccione Articulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Item Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Dim Retorno As String
        Dim CprodDET As New ClsOrdendeIngresoDet
        Try
            Retorno = CprodDET.EliminaOrdIngDet(Val(TxtORDINGDETCOD.Text))
            If Val(Retorno) = 0 Then
                MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call BtnNuevoDetalle_Click(sender, e)
            Else
                MessageBox.Show("No se pudo Realizar la Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


        ListaOrdIngDetTotales(TxtCodigo.Text)
        ActualizarTotales(TxtCodigo.Text, Val(TxtSubTotal.Text), Val(txtSubTotalImpuesto.Text), Val(TxtTotalGeneral.Text), LBLTotalLetras.Text)
        RellenarListaDet(TxtCodigo.Text)
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DataGridView1.CurrentRow.Index
            BuscaOrdIngDET(DataGridView1.Rows(Fila).Cells(0).Value.ToString())
        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub TxtCantidad_Leave(sender As Object, e As EventArgs) Handles TxtCantidad.Leave
        TxtCantidad.Text = Format(Val(TxtCantidad.Text), "###0.#0")
    End Sub

    Private Sub TxtPrecio_Leave(sender As Object, e As EventArgs) Handles TxtPrecio.Leave
        TxtPrecio.Text = Format(Val(TxtPrecio.Text), "###0.#0")
    End Sub
End Class