Public Class FrmFamilias
    Private Sub Limpiar()
        TxtCodigo.Clear()
        txtDescripcion.Clear()
        txtDescripcion.Focus()
    End Sub

    Private Sub RellenarLista(Valor As String)
        Try
            Dim CFamilia As New ClsFamilias
            Dim DT As New DataTable
            DT = CFamilia.ListaFamilias(Valor)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 300
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaRegistro(Codigo As String)
        Try
            Dim CFamilia As New ClsFamilias
            Dim DT As New DataTable
            DT = CFamilia.BuscaFamilias(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("FAMCOD").ToString()
                txtDescripcion.Text = DT.Rows(0).Item("FAMDES").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DataGridView1.CurrentRow.Index
            BuscaRegistro(DataGridView1.Rows(Fila).Cells(0).Value.ToString())
        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        RellenarLista(TxtBuscar.Text)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
        RellenarLista("")
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Ingrese Descripcion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Exit Sub
        End If

        Dim Retorno As String = ""
        Dim CFamilia As New ClsFamilias
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = CFamilia.InsertaFamilias(txtDescripcion.Text.Trim, USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else
                Retorno = CFamilia.ActualizaFamilias(TxtCodigo.Text, txtDescripcion.Text.Trim, USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtCodigo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCodigo.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim Retorno As String
        Dim CFamilia As New ClsFamilias
        Try
            Retorno = CFamilia.EliminaFamilias(TxtCodigo.Text)
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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call BtnNuevo_Click(sender, e)
    End Sub

    Private Sub FrmFamilias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmFamilias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class