Public Class FrmUsuarios





    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RellenarComboSuperior()
        RellenarComboFrigorifico()
        RellenarModulo()
        RellenarComboJerarquica()

        LblModulo.Text = "Modulos"

        PanelModulo.Visible = False

        Call BtnNuevo_Click(sender, e)

    End Sub


#Region "Rutinas de la Grillas"



    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgUsuarios.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If DgUsuarios.Rows(DgUsuarios.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = DgUsuarios.CurrentRow.Index
            BuscaRegistro(DgUsuarios.Rows(Fila).Cells(0).Value.ToString())

            RellenarModuloAsigados(DgUsuarios.Rows(Fila).Cells(0).Value.ToString())


        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub


#End Region

#Region "Rutinas del Formulario"

    Private Sub Limpiar()
        txtusuario.Clear()
        TxtPassword.Clear()
        TxtCodigo.Clear()
        txtnombres.Clear()
        txtapellidos.Clear()
        txtusuario.Focus()
    End Sub


    Private Sub FrmUsuarios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#End Region


#Region "Rutinas de Carga Datos "

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

                LblModulo.Text = "Modulos para " & txtnombres.Text & " " & txtapellidos.Text

                PanelModulo.Visible = True


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarLista(Valor As Integer)
        Try
            Dim CUsuario As New ClsUsuario
            Dim DT As New DataTable
            DT = CUsuario.EjecutarSp("of_lista", Valor).Tables(0)
            DgUsuarios.DataSource = DT
            DgUsuarios.ReadOnly = True
            DgUsuarios.Columns("idUsuario").Visible = False
            DgUsuarios.Columns("idfrigorifico").Visible = False
            DgUsuarios.Columns("idSuperior").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RellenarModuloAsigados(Codigo As Integer)
        Try
            Dim CUsuario As New ClsGenerica
            Dim DT As New DataTable
            DT = CUsuario.TraerDatos("UL_spC_ModuloXUsuario", Codigo).Tables(0)


            DgModuloAsignado.DataSource = DT

            DgModuloAsignado.Columns("idUsuario").Visible = False
            DgModuloAsignado.Columns("jerarquia").Visible = False






        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
#End Region

#Region "Rutinas de Carga de Combos"


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


    ' traer todos los modulos asignados
    Private Sub RellenarModulo()
        Try
            Dim CUsuario As New ClsGrlModulo
            Dim DT As New DataTable
            DT = CUsuario.ObtenerTodos().Tables(0)
            DgModulo.DataSource = DT

            'Add a CheckBox Column to the DataGridView at the first position.
            Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = ""
            checkBoxColumn.Width = 30
            checkBoxColumn.Name = "ChkCodigoModulo"
            DgModulo.Columns.Insert(0, checkBoxColumn)

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

#End Region

#Region "Botones"


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
        Dim CVendedor As New ClsVendedor
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

    Private Sub BtnModuloAgregar_Click(sender As Object, e As EventArgs) Handles BtnModuloAgregar.Click

        Try

            Dim Omodulo As New ClsGenerica
            Dim ObjModulo(5) As Object


            ObjModulo(1) = ""
            ObjModulo(2) = 0
            ObjModulo(3) = USULOGIN.Trim
            ObjModulo(4) = CmbJerarquia.SelectedValue
            ObjModulo(5) = "A"


            For i As Integer = 0 To Me.DgModulo.Rows.Count - 1
                If DgModulo.Rows(i).Cells("ChkCodigoModulo").Value = True Then
                    ObjModulo(0) = Convert.ToInt32(TxtCodigo.Text)
                    'Agregar Modulos al usuario
                    ObjModulo(1) = Convert.ToInt32(DgModulo.Rows(i).Cells("codigo").Value)

                    Omodulo.EjecutarSP("UL_spIUD_Usuariomodulo", ObjModulo)

                End If
            Next

            RellenarModuloAsigados(TxtCodigo.Text)

            MessageBox.Show("Se Agregó el Modulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub

    Private Sub BtnModuloEliminar_Click(sender As Object, e As EventArgs) Handles BtnModuloEliminar.Click


        Try
            Dim Omodulo As New ClsGenerica
            Dim ObjModulo(5) As Object


            ObjModulo(1) = ""
            ObjModulo(2) = 0
            ObjModulo(3) = USULOGIN.Trim
            ObjModulo(4) = CmbJerarquia.SelectedValue
            ObjModulo(5) = "D"


            For i As Integer = 0 To Me.DgModuloAsignado.Rows.Count - 1

                If DgModuloAsignado.Rows(i).Cells("ChkCodigoModuloAsignado").Value = True Then
                    ObjModulo(0) = Convert.ToInt32(TxtCodigo.Text)
                    'Agregar Modulos al usuario
                    ObjModulo(1) = Convert.ToInt32(DgModuloAsignado.Rows(i).Cells("codigo").Value)
                    Omodulo.EjecutarSP("UL_spIUD_Usuariomodulo", ObjModulo)


                End If
            Next

            RellenarModuloAsigados(TxtCodigo.Text)
            MessageBox.Show("Se Quitó el Modulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try


    End Sub


#End Region

    Private Sub chkDgModulo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDgModulo.CheckedChanged

        If chkDgModulo.Checked Then

            For i As Integer = 0 To Me.DgModulo.Rows.Count - 1
                DgModulo.Rows(i).Cells("ChkCodigoModulo").Value = True
            Next

        Else

            For i As Integer = 0 To Me.DgModulo.Rows.Count - 1
                DgModulo.Rows(i).Cells("ChkCodigoModulo").Value = False
            Next


        End If


    End Sub

    Private Sub ChkDgModuloAsignado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDgModuloAsignado.CheckedChanged


        If ChkDgModuloAsignado.Checked Then


            For i As Integer = 0 To Me.DgModuloAsignado.Rows.Count - 1
                DgModuloAsignado.Rows(i).Cells("ChkCodigoModuloAsignado").Value = True
            Next
        Else

            For i As Integer = 0 To Me.DgModuloAsignado.Rows.Count - 1
                DgModuloAsignado.Rows(i).Cells("ChkCodigoModuloAsignado").Value = False
            Next

        End If


    End Sub

    Private Sub ChkDgModuloAsignado_VisibleChanged(sender As Object, e As EventArgs) Handles ChkDgModuloAsignado.VisibleChanged

        'Add a CheckBox Column to the DataGridView at the first position.
        Dim checkBoxColumn As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        checkBoxColumn.HeaderText = ""
        checkBoxColumn.Width = 30
        checkBoxColumn.Name = "ChkCodigoModuloAsignado"
        DgModuloAsignado.Columns.Insert(0, checkBoxColumn)


    End Sub

    Private Sub CmbIdFrigorifico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIdFrigorifico.SelectedIndexChanged

    End Sub


End Class