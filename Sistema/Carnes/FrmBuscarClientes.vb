Public Class FrmBuscarClientes
    Public Fila As Integer = -1

    Private Sub Limpiar()
        TxtCodigo.Clear()
        TxtRazonSocial.Clear()
        TxtRuc.Clear()
        TxtCodigo.Focus()
    End Sub

    Private Sub RellenarLista(CLICOD As String, CLIRAZONSOCIAL As String, CLIRUC As String)
        Try
            Dim CClientes As New ClsClientes
            Dim DT As New DataTable
            DT = CClientes.ListaClientes(CLICOD, CLIRAZONSOCIAL, CLIRUC)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 100
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(6).Width = 200
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        RellenarLista(TxtCodigo.Text, TxtRazonSocial.Text, TxtRuc.Text)

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        BtnEnviar_Click(sender, e)
    End Sub

    Private Sub FrmBuscarClientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmBuscarClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarLista("", "", "")
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class