Imports System.IO

Public Class FrmArticulos

    Private Sub BuscaImagen(ARTCOD As String, ByRef PT As PictureBox)
        Try
            Dim CProd As New ClsArticulos
            Dim ms As New MemoryStream(CProd.BuscaImagenArticulos(ARTCOD))
            PT.Image = Image.FromStream(ms)
        Catch ex As Exception
            PT.Image = Nothing
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Function GrabarImagen() As Integer
        Dim Retorno As Integer = 0
        Dim ClsProd As New ClsArticulos
        Try
            Dim arrFileName() As String = Split(Text, "\")
            Array.Reverse(arrFileName)
            Dim ms As New MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Retorno = ClsProd.GrabaImagenArticulos(TxtCodigo.Text, ms)
        Catch ex As Exception
            ' MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Retorno
    End Function

    Private Sub Limpiar()
        TxtCodigo.Clear()
        txtDescripcion.Clear()
        CbMarca.Text = ""
        PictureBox1.Image = Nothing
        CbFamilia.Text = ""
        CbSubFamilia.Text = ""
        txtPrecio.Clear()
        TxtStock.Clear()
        txtDescripcion.Focus()
    End Sub

    Private Sub BuscaArticulo(Codigo As String)
        Try
            Dim CArticulos As New ClsArticulos
            Dim DT As New DataTable
            DT = CArticulos.BuscaArticulos(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("ARTCOD").ToString()
                CbFamilia.SelectedValue = DT.Rows(0).Item("FAMCOD").ToString()
                CbSubFamilia.SelectedValue = DT.Rows(0).Item("SUBFAMCOD").ToString()
                CbMarca.SelectedValue = DT.Rows(0).Item("MARCOD").ToString()
                txtDescripcion.Text = DT.Rows(0).Item("ARTDES").ToString()
                txtPrecio.Text = DT.Rows(0).Item("ARTPRECIO").ToString()
                TxtStock.Text = DT.Rows(0).Item("ARTSTOCK").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim FRM As New FrmBuscarArticulos
        Dim ARTCOD As String
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                ARTCOD = .DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
                BuscaArticulo(ARTCOD)
                BuscaImagen(ARTCOD, PictureBox1)
            End If
        End With
    End Sub

    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnNuevo_Click(sender, e)
        OpenFileDialog1.Filter = "Archivos jpg|*.jpg"
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        RellenarFamilias()
        RellenarMarcas()
        RellenarSubFamilias()
        Limpiar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmArticulos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Ingrese Descripcion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Focus()
            Exit Sub
        End If
        If CbFamilia.Text = "" Then
            MessageBox.Show("Seleccione Familia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbFamilia.Focus()
            Exit Sub
        End If
        If CbSubFamilia.Text = "" Then
            MessageBox.Show("Seleccione SubFamilia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbSubFamilia.Focus()
            Exit Sub
        End If
        If CbMarca.Text = "" Then
            MessageBox.Show("Seleccione Marca", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbMarca.Focus()
            Exit Sub
        End If
        If Val(txtPrecio.Text) = 0 Then
            MessageBox.Show("Ingrese el Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CbMarca.Focus()
            Exit Sub
        End If
        Dim Retorno As String = ""
        Dim CArticulos As New ClsArticulos
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = CArticulos.InsertaArticulos(CbFamilia.SelectedValue, CbSubFamilia.SelectedValue, CbMarca.SelectedValue, txtDescripcion.Text.Trim, Val(txtPrecio.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    Call GrabarImagen()
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else
                Retorno = CArticulos.ActualizaArticulos(TxtCodigo.Text, CbFamilia.SelectedValue, CbSubFamilia.SelectedValue, CbMarca.SelectedValue, txtDescripcion.Text.Trim, Val(txtPrecio.Text), USUCOD)
                If Val(Retorno) > 0 Then
                    Call GrabarImagen()
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
        Dim CArticulos As New ClsArticulos
        Try
            Retorno = CArticulos.EliminaArticulos(TxtCodigo.Text)
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

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If SoloMonedas(txtPrecio, Asc(e.KeyChar)) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub BtnAbrirImagen_Click(sender As Object, e As EventArgs) Handles BtnAbrirImagen.Click
        Try
            Dim ruta As String = ""
            OpenFileDialog1.ShowDialog()
            ruta = OpenFileDialog1.FileName.ToString()
            PictureBox1.Image = System.Drawing.Image.FromFile(ruta)
        Catch EX As Exception
            REM
        End Try
    End Sub
End Class