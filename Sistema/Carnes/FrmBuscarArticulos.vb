Public Class FrmBuscarArticulos
    Public Fila As Integer = -1

    Private Sub RellenarSubFamilias()
        Try
            Dim CSubFamilia As New ClsSubFamilias
            Dim DT As New DataTable
            DT = CSubFamilia.ComboSubFamilias()
            CbSubFamilia.DataSource = DT
            CbSubFamilia.DisplayMember = "SUBFAMDES"
            CbSubFamilia.ValueMember = "SUBFAMCOD"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarFamilias()
        Try
            Dim CFamilias As New ClsFamilias
            Dim DT As New DataTable
            DT = CFamilias.ComboFamilias()
            CbFamilia.DataSource = DT
            CbFamilia.DisplayMember = "FAMDES"
            CbFamilia.ValueMember = "FAMCOD"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarMarcas()
        Try
            Dim CMarcas As New ClsMarcas
            Dim DT As New DataTable
            DT = CMarcas.ComboMarcas()
            CbMarca.DataSource = DT
            CbMarca.DisplayMember = "MARDES"
            CbMarca.ValueMember = "MARCOD"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Limpiar()
        TxtCodigo.Clear()
        TxtDescripcion.Clear()
        CbFamilia.Text = ""
        CbMarca.Text = ""
        CbSubFamilia.Text = ""
        TxtCodigo.Focus()
    End Sub

    Private Sub RellenarLista(ARTCOD As String, ARTDES As String, FAMDES As String, SUBFAMDES As String, MARDES As String)
        Try
            Dim CArticulos As New ClsArticulos
            Dim DT As New DataTable
            DT = CArticulos.ListaArticulos(ARTCOD, ARTDES, FAMDES, SUBFAMDES, MARDES)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 140
            DataGridView1.Columns(2).Width = 130
            DataGridView1.Columns(3).Width = 130
            DataGridView1.Columns(4).Width = 130
            DataGridView1.Columns(5).Width = 60
            DataGridView1.Columns(6).Width = 60
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FrmBuscarArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmBuscarArticulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmBuscarArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarLista("", "", "", "", "")
        RellenarSubFamilias()
        RellenarFamilias()
        RellenarMarcas()
        Limpiar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        RellenarLista(TxtCodigo.Text, TxtDescripcion.Text, CbFamilia.Text, CbSubFamilia.Text, CbMarca.Text)
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class