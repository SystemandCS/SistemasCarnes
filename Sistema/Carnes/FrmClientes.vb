Public Class FrmClientes

    Private Sub LIMPIAR()
        TxtCodigo.Clear()
        txtRazonSocial.Clear()
        TxtRuc.Clear()
        txtDireccion.Clear()
        TxtCelular.Clear()
        TxtTelefono.Clear()
        TXTEMAIL.Clear()
        TxtRuc.Focus()
    End Sub

    Private Sub BuscaCliente(Codigo As String)
        Try
            Dim CCliente As New ClsClientes
            Dim DT As New DataTable
            DT = CCliente.BuscaClientes(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("CLICOD").ToString()
                txtRazonSocial.Text = DT.Rows(0).Item("CLIRAZONSOCIAL").ToString()
                TxtRuc.Text = DT.Rows(0).Item("CLIRUC").ToString()
                txtDireccion.Text = DT.Rows(0).Item("CLIDIRECCION").ToString()
                TxtTelefono.Text = DT.Rows(0).Item("CLITELEFONO").ToString()
                TxtCelular.Text = DT.Rows(0).Item("CLICELULAR").ToString()
                TXTEMAIL.Text = DT.Rows(0).Item("CLIEMAIL").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FrmClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmClientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
    End Sub

    Private Sub TxtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRuc.KeyPress
        If SoloNumeros(Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LIMPIAR()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If TxtRuc.Text.Trim = "" Then
            MessageBox.Show("Ingrese RUC", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtRuc.Focus()
            Exit Sub
        End If
        If txtRazonSocial.Text.Trim = "" Then
            MessageBox.Show("Seleccione Razon Social", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRazonSocial.Focus()
            Exit Sub
        End If
        If txtDireccion.Text.Trim = "" Then
            MessageBox.Show("Seleccione Direccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDireccion.Focus()
            Exit Sub
        End If
        Dim Retorno As String = ""
        Dim CClientes As New ClsClientes
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = CClientes.InsertaClientes(txtRazonSocial.Text.Trim, TxtRuc.Text, txtDireccion.Text.Trim, TxtTelefono.Text.Trim, TxtCelular.Text.Trim, TXTEMAIL.Text.Trim, USUCOD)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else
                Retorno = CClientes.ActualizaClientes(TxtCodigo.Text, txtRazonSocial.Text.Trim, TxtRuc.Text, txtDireccion.Text.Trim, TxtTelefono.Text.Trim, TxtCelular.Text.Trim, TXTEMAIL.Text.Trim, USUCOD)
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
        Dim CClientes As New ClsClientes
        Try
            Retorno = CClientes.EliminaClientes(TxtCodigo.Text)
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
        Dim FRM As New FrmBuscarClientes
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                BuscaCliente(.DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString)
            End If
        End With
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class