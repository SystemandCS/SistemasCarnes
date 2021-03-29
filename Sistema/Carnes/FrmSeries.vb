Public Class FrmSeries

    Private Sub RellenarLista()
        Try
            Dim CSeries As New ClsSeries
            Dim DT As New DataTable
            DT = CSeries.ListaSeries()
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns(0).Width = 80
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 60
            DataGridView1.Columns(3).Width = 80
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaRegistro(Codigo As String)
        Try
            Dim CSeries As New ClsSeries
            Dim DT As New DataTable
            DT = CSeries.BuscaSeries(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("SERCOD").ToString()
                txtSerie.Text = DT.Rows(0).Item("SERIE").ToString()
                TxtCorrelativo.Text = DT.Rows(0).Item("CORRELATIVO").ToString()
                CbDocumento.Text = DT.Rows(0).Item("DOCUMENTO").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarComboSeries()
        Try
            Dim CSeries As New ClsSeries
            Dim DT As New DataTable
            DT = CSeries.ComboSeries()
            If DT.Rows.Count > 0 Then
                With CbDocumento
                    .DataSource = DT
                    .DisplayMember = "DOCUMENTO"
                    .ValueMember = "SERCOD"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FrmSeries_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmSeries_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarLista()
        RellenarComboSeries()
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If SoloMonedas(txtSerie, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCorrelativo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCorrelativo.KeyPress
        If SoloMonedas(TxtCorrelativo, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If txtSerie.Text.Length <> 3 Then
            MessageBox.Show("Ingrese Serie (3 numeros)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSerie.Focus()
            Exit Sub
        End If
        If TxtCorrelativo.Text.Length <> 7 Then
            MessageBox.Show("Ingrese Correlativo (7 numeros)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCorrelativo.Focus()
            Exit Sub
        End If
        If CbDocumento.Text.Trim = "" Then
            MessageBox.Show("Ingrese Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCorrelativo.Focus()
            Exit Sub
        End If
        Dim Retorno As String = ""
        Dim CSeries As New ClsSeries
        Try
            If TxtCodigo.Text.Trim = "" Then
            Else
                Retorno = CSeries.ActualizaSeries(TxtCodigo.Text, CbDocumento.Text, txtSerie.Text, TxtCorrelativo.Text, USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call RellenarLista()
                End If
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs)
        REM  RellenarLista(TxtBuscar.Text)
    End Sub
End Class