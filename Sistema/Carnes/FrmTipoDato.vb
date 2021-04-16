Public Class FrmTipo

    Dim Modo As String = ""

    Dim Otipo(9) As Object

    Dim VarIdTipoDato As Integer


    Private Sub FrmTipoDato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarGrillaTipoDatos()
        '  CargarGrillaTipo()

        PnlTipo.Visible = False

    End Sub


#Region "Rutinas de Grillas"

    ' Grilla GdvTipoDato

    Private Sub GdvTipoDato_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GdvTipoDato.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If GdvTipoDato.Rows(GdvTipoDato.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = GdvTipoDato.CurrentRow.Index
            BuscarTipoDato(GdvTipoDato.Rows(Fila).Cells(0).Value.ToString())

            CargarGrillaTipo(GdvTipoDato.Rows(Fila).Cells(0).Value.ToString())



        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub


    ' Grilla GdvTipo

    Private Sub GdvTipo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GdvTipo.CellDoubleClick
        On Error GoTo ErrLinea
        Dim Fila As Integer
        If GdvTipo.Rows(GdvTipo.CurrentRow.Index).Cells(0).Value.ToString <> "" Then
            Fila = GdvTipo.CurrentRow.Index
            BuscarTipo(GdvTipo.Rows(Fila).Cells(0).Value.ToString())



        End If
        Return
ErrLinea:
        MessageBox.Show("No hay registros en la lista de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

#End Region

#Region "Rutinas"

    Private Sub BuscarTipoDato(Codigo As Integer)
        Try

            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.TraerDatos("Gen_Tipodatos_Consul", Codigo).Tables(0)

            Modo = "M"

            If DT.Rows.Count > 0 Then

                TxtIdTipoDato.Text = DT.Rows(0).Item("IdTipodato").ToString()
                TxtTipoDato.Text = DT.Rows(0).Item("tipoDato").ToString()
                txtCodigo.Text = DT.Rows(0).Item("codigo").ToString()

                TxtDescripcion.Text = DT.Rows(0).Item("descripcion").ToString()






            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub BuscarTipo(Codigo As Integer)
        Try

            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.TraerDatos("Gen_Tipos_ou", Codigo).Tables(0)

            Modo = "M"

            If DT.Rows.Count > 0 Then

                TxtIdTipo.Text = DT.Rows(0).Item("IdTipo").ToString()
                TxtCodigoTipo.Text = DT.Rows(0).Item("Codigo").ToString()
                TxtNombre.Text = DT.Rows(0).Item("Nombre").ToString()
                TxtAtributo.Text = DT.Rows(0).Item("Atributo").ToString()
                TxtDefault.Text = DT.Rows(0).Item("DefaultTipo").ToString()
                TxtCodigoAfip.Text = DT.Rows(0).Item("CodigoAfip").ToString()
                TxtDescrAfip.Text = DT.Rows(0).Item("DescrAfip").ToString()






            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


#End Region

#Region "Rellenar Grilla"

    ' Grilla Tipo De Datos
    Private Sub CargarGrillaTipoDatos()



        Try
            Dim CLocalidad As New ClsGenerica
            Dim DT As New DataTable
            DT = CLocalidad.TraerDatos("Gen_Tipodatos_Consul", 0).Tables(0)
            GdvTipoDato.DataSource = DT
            GdvTipoDato.ReadOnly = True
            ' DgLocalidades.Columns("idprovincia").Visible = False
            ' DgLocalidades.Columns("idpais").Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    ' Grilla Tipo 

    Private Sub CargarGrillaTipo(Codigo As Integer)
        Try
            VarIdTipoDato = Codigo

            PnlTipo.Visible = True

            Dim CUsuario As New ClsGenerica
            Dim DT As New DataTable
            DT = CUsuario.TraerDatos("Gen_Tipos_Consul", Codigo).Tables(0)

            GdvTipo.DataSource = DT

            GdvTipo.Columns("idTipodato").Visible = False
            GdvTipo.Columns("fechaModificacion").Visible = False
            GdvTipo.Columns("fechaCreacion").Visible = False
            GdvTipo.Columns("UsuarioCreacion").Visible = False
            GdvTipo.Columns("UsuarioModificacion").Visible = False


            'DgModuloAsignado.Columns("idUsuario").Visible = False
            ' DgModuloAsignado.Columns("jerarquia").Visible = False






        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#Region "Rutinas Botones"


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'Limpiar()
        CargarGrillaTipo(VarIdTipoDato)
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click

        If TxtNombre.Text.Trim = "" Then
            MessageBox.Show("Ingrese Nombre Localidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtNombre.Focus()
            Exit Sub
        End If

        '@idTipo                 int = null,
        '@idTipodato     int = null,
        '@codigo                 varchar(20) = null,
        '@nombre                 varchar(50) = null,
        '@atributo               varchar(100) = null,
        '@defaultTipo    char(2) = null,
        '@usuario                varchar(20) = null,
        '@Modo                   char(1),
        '@codigoAfip             varchar(50)='',
        '@descrAfip              varchar(50)=''


        Otipo(0) = TxtIdTipo.Text
        Otipo(1) = TxtIdTipoDato.Text
        Otipo(2) = TxtCodigoTipo.Text
        Otipo(3) = TxtNombre.Text
        Otipo(4) = TxtAtributo.Text
        Otipo(5) = TxtDefault.Text
        Otipo(6) = USULOGIN
        Otipo(7) = Modo
        Otipo(8) = TxtCodigoAfip.Text
        Otipo(9) = TxtDescrAfip.Text





        Dim Retorno As Integer



        Dim Ctipo As New ClsGenerica
        Dim DT As New DataTable

        Try
            If TxtIdTipo.Text.Trim = "" Then

                Otipo(0) = 0
                Otipo(7) = "A"

                Retorno = Ctipo.EjecutarSP("Gen_Tipos_Abm", Otipo)


                If Val(Retorno) > 0 Then
                    MessageBox.Show("Registro Agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BtnNuevo_Click(sender, e)
                End If
            Else

                Otipo(7) = "M"
                Retorno = Ctipo.EjecutarSP("Gen_Tipos_Abm", Otipo)

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

        Otipo(0) = TxtIdTipo.Text
        Otipo(1) = TxtIdTipoDato.Text
        Otipo(2) = TxtCodigoTipo.Text
        Otipo(3) = TxtNombre.Text
        Otipo(4) = TxtAtributo.Text
        Otipo(5) = TxtDefault.Text
        Otipo(6) = USULOGIN
        Otipo(7) = "B"
        Otipo(8) = TxtCodigoAfip.Text
        Otipo(9) = TxtDescrAfip.Text



        If TxtIdTipo.Text.Trim = "" Then
            MessageBox.Show("Buscar Registro de Tipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtIdTipo.Focus()
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim Retorno As Integer
        Dim CLocalidad As New ClsGenerica

        Try
            Retorno = CLocalidad.EjecutarSP("Gen_Tipos_Abm", Otipo)
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
#End Region




#End Region

End Class