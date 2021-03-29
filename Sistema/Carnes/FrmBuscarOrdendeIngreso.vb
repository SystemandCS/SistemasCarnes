Public Class FrmBuscarOrdendeIngreso
    Public Fila As Integer = -1

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

    Private Sub RellenarLista(ORDINGCOD As String, ORDSERIE As String, ORDCORRELATIVO As String, PROCOD As String, DESDE As Date, HASTA As Date)
        Try
            Dim ClsOrdIng As New ClsOrdendeIngreso
            Dim DT As New DataTable
            DT = ClsOrdIng.ListaOrdendeIngreso(ORDINGCOD, ORDSERIE, ORDCORRELATIVO, PROCOD, DESDE, HASTA)
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
        TxtCodProveedor.Clear()
        txtRazonSocial.Clear()
        TxtSerie.Clear()
        TxtCorrelativo.Clear()
        TxtCodigo.Focus()
    End Sub

    Private Sub FrmBuscarOrdendeIngreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmBuscarOrdendeIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmBuscarOrdendeIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLimpiar_Click(sender, e)
        BtnAceptar_Click(sender, e)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        RellenarLista(TxtCodigo.Text, TxtSerie.Text, TxtCorrelativo.Text, TxtCodProveedor.Text, DtpDesde.Value, DtpHasta.Value)
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

    Private Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click
        Dim FRM As New FrmBuscarProveedores
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaProveedor(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        BtnEnviar_Click(sender, e)
    End Sub
End Class