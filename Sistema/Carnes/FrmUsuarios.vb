Public Class FrmUsuarios

    Private Sub Limpiar()
        txtusuario.Clear()
        TxtPassword.Clear()
        TxtCodigo.Clear()
        txtnombres.Clear()
        txtapellidos.Clear()


        txtusuario.Focus()
    End Sub

    Private Sub RellenarLista(Valor As Integer)
        Try
            Dim CUsuario As New ClsUsuario
            Dim DT As New DataTable
            DT = CUsuario.EjecutarSp("of_lista", Valor).Tables(0)
            DataGridView1.DataSource = DT
            DataGridView1.ReadOnly = True
            DataGridView1.Columns("idUsuario").Visible = False
            DataGridView1.Columns("idfrigorifico").Visible = False
            DataGridView1.Columns("idSuperior").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaRegistro(Codigo As Integer)
        Try
            Dim CUsuario As New ClsUsuario
            Dim DT As New DataTable
            DT = CUsuario.ObtenerUno(Codigo).Tables(0)
            If DT.Rows.Count > 0 Then
                TxtCodigo.Text = DT.Rows(0).Item("idUsuario").ToString()
                txtusuario.Text = DT.Rows(0).Item("Usuario").ToString()
                txtapellidos.Text = DT.Rows(0).Item("Apellido").ToString()
                txtnombres.Text = DT.Rows(0).Item("Nombre").ToString()
                TxtPassword.Text = DT.Rows(0).Item("Password").ToString()
                CmbIdSuperior.SelectedValue = DT.Rows(0).Item("idsuperior").ToString()
                CmbIdFrigorifico.SelectedValue = DT.Rows(0).Item("idfrigorifico").ToString()
                '  txtdireccion.Text = DT.Rows(0).Item("USUDIRECCION").ToString()
                'txttelefono.Text = DT.Rows(0).Item("USUTELEFONO").ToString()
                'txtcelular.Text = DT.Rows(0).Item("USUCELULAR").ToString()
                ' txtemail.Text = DT.Rows(0).Item("USUEMAIL").ToString()
                ' txtdocidentidad.Text = DT.Rows(0).Item("USUDOCIDEN").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
        RellenarLista(USUCOD)
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        If txtusuario.Text.Trim = "" Then
            MessageBox.Show("Ingrese Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusuario.Focus()
            Exit Sub
        End If

        If TxtPassword.Text.Trim = "" Then
            MessageBox.Show("Ingrese Password", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtusuario.Focus()
            Exit Sub
        End If



        Dim Retorno As Integer
        Dim CUsuarios As New ClsUsuario
        Try
            If TxtCodigo.Text.Trim = "" Then
                Retorno = CUsuarios.Insertar(0, txtnombres.Text, txtapellidos.Text, txtusuario.Text, TxtPassword.Text.Trim, 0,
                                     CmbIdSuperior.SelectedValue, 0, USULOGIN.Trim, CmbIdFrigorifico.SelectedValue)
                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else


                Retorno = CUsuarios.Actualizar(TxtCodigo.Text, txtnombres.Text, txtapellidos.Text, txtusuario.Text, TxtPassword.Text.Trim, 0,
                                     CmbIdSuperior.SelectedValue, USULOGIN.Trim, 0, CmbIdFrigorifico.SelectedValue)
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

        Dim Retorno As Integer
        Dim CUsuarios As New ClsUsuario
        Try
            Retorno = CUsuarios.Eliminar(TxtCodigo.Text, USULOGIN)
            If Val(Retorno) > 0 Then
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

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarComboSuperior()
        RellenarComboFrigorifico()
        RellenarModulo()
        RellenarComboJerarquica()

        Call BtnNuevo_Click(sender, e)

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

    Private Sub FrmUsuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub RellenarComboSuperior()
        Try
            Dim CFacCab As New ClsUsuario
            Dim DT As New DataTable
            DT = CFacCab.ObtenerTodos.Tables(0)
            With CmbIdSuperior
                .DataSource = DT
                .DisplayMember = "Usuario"
                .ValueMember = "idUsuario"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarModulo()
        Try
            Dim CUsuario As New ClsGrlModulo
            Dim DT As New DataTable
            DT = CUsuario.ObtenerTodos().Tables(0)
            DgModulo.DataSource = DT
            DgModulo.ReadOnly = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarComboFrigorifico()
        Try
            Dim CFacCab As New ClsGenerica
            Dim DT As New DataTable
            DT = CFacCab.TraerDatos("GRL_TIPO_OF_TIPO", 1).Tables(0)
            With CmbIdFrigorifico
                .DataSource = DT
                .DisplayMember = "Nombre"
                .ValueMember = "idtipo"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub RellenarModuloAgregado()
        Try
            Dim CUsuario As New ClsGrlModulo
            Dim DT As New DataTable
            DT = CUsuario.ObtenerUno().Tables(0)
            DgModulo.DataSource = DT
            DgModulo.ReadOnly = True


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarComboJerarquica()
        Try
            Dim CFacCab As New ClsGenerica
            Dim DT As New DataTable
            DT = CFacCab.TraerDatos("GRL_TIPODATO_OF_CODIGO", "jera").Tables(0)
            With CmbJerarquia
                .DataSource = DT
                .DisplayMember = "descripcion"
                .ValueMember = "idtipoDato"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


End Class