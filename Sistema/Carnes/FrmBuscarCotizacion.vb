Public Class FrmBuscarCotizacion
    Public Fila As Integer = -1

    Private Sub BuscaCliente(Codigo As String)
        Try
            Dim CCliente As New ClsClientes
            Dim DT As New DataTable
            DT = CCliente.BuscaClientes(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodCliente.Text = DT.Rows(0).Item("CLICOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("CLIRAZONSOCIAL").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarLista(COTCOD As String, SERIE As String, CORRELATIVO As String, CLICOD As String, DESDE As Date, HASTA As Date)
        Try
            Dim CCotizacionCab As New ClsCotizacionCab
            Dim DT As New DataTable
            DT = CCotizacionCab.ListaCotizacionCab(COTCOD, SERIE, CORRELATIVO, CLICOD, DESDE, HASTA)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 60
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 120
            DataGridView1.Columns(4).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Limpiar()
        DtpDesde.Value = CDate("01/" + Format(Month(Now), "00") + "/" + Format(Year(Now), "0000"))
        DtpDesde.Value = Now
        TxtCodigo.Clear()
        TxtCodCliente.Clear()
        txtRazonSocial.Clear()
        TxtSerie.Clear()
        TxtCorrelativo.Clear()
        TxtCodigo.Focus()
    End Sub


    Private Sub FrmBuscarCotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmBuscarCotizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmBuscarCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLimpiar_Click(sender, e)
        BtnAceptar_Click(sender, e)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        RellenarLista(TxtCodigo.Text, TxtSerie.Text, TxtCorrelativo.Text, TxtCodCliente.Text, DtpDesde.Value, DtpHasta.Value)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        On Error GoTo ErrLinea
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DataGridView1.CurrentRow.Index
            Me.Close()
        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodigo.KeyPress
        If SoloNumeros(Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerie.KeyPress
        If SoloNumeros(Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCorrelativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorrelativo.KeyPress
        If SoloNumeros(Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        BtnEnviar_Click(sender, e)
    End Sub
End Class