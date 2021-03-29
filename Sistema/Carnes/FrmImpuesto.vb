Public Class FrmImpuesto

    Private Sub BuscarImpuesto()
        Try
            Dim CImpuestos As New ClsImpuestos
            Dim DT As New DataTable
            DT = CImpuestos.BuscaImpuestos()
            If DT.Rows.Count > 0 Then
                txtValor.Text = DT.Rows(0).Item("VALOR").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmImpuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmImpuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If Val(txtValor.Text) = 0 Then
            MessageBox.Show("Ingrese el Valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtValor.Focus()
            Exit Sub
        End If
        Dim Retorno As String = ""
        Dim CImpuestos As New ClsImpuestos
        Try
            If txtValor.Text.Trim <> "" Then
                Retorno = CImpuestos.ActualizaImpuestos(Val(txtValor.Text))
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor.KeyPress
        If SoloMonedas(txtValor, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarImpuesto()
    End Sub
End Class