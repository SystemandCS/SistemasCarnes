<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCotizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotizacion))
        Me.TxtCOTCODDET = New System.Windows.Forms.TextBox()
        Me.LBLTotalLetras = New System.Windows.Forms.Label()
        Me.TxtTotalGeneral = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSubTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnEliminarDetalle = New System.Windows.Forms.Button()
        Me.BtnGrabarDetalle = New System.Windows.Forms.Button()
        Me.BtnNuevoDetalle = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.TxtDescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.TxtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtOrdendeCompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnCerrarEstado = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCOTCODDET
        '
        Me.TxtCOTCODDET.BackColor = System.Drawing.Color.Bisque
        Me.TxtCOTCODDET.Location = New System.Drawing.Point(519, 223)
        Me.TxtCOTCODDET.Name = "TxtCOTCODDET"
        Me.TxtCOTCODDET.ReadOnly = True
        Me.TxtCOTCODDET.Size = New System.Drawing.Size(100, 20)
        Me.TxtCOTCODDET.TabIndex = 191
        '
        'LBLTotalLetras
        '
        Me.LBLTotalLetras.Location = New System.Drawing.Point(9, 434)
        Me.LBLTotalLetras.Name = "LBLTotalLetras"
        Me.LBLTotalLetras.Size = New System.Drawing.Size(516, 65)
        Me.LBLTotalLetras.TabIndex = 188
        '
        'TxtTotalGeneral
        '
        Me.TxtTotalGeneral.BackColor = System.Drawing.Color.Bisque
        Me.TxtTotalGeneral.Location = New System.Drawing.Point(591, 479)
        Me.TxtTotalGeneral.MaxLength = 15
        Me.TxtTotalGeneral.Name = "TxtTotalGeneral"
        Me.TxtTotalGeneral.ReadOnly = True
        Me.TxtTotalGeneral.Size = New System.Drawing.Size(75, 20)
        Me.TxtTotalGeneral.TabIndex = 186
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(534, 479)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 187
        Me.Label16.Text = "Total"
        '
        'txtSubTotalImpuesto
        '
        Me.txtSubTotalImpuesto.BackColor = System.Drawing.Color.Bisque
        Me.txtSubTotalImpuesto.Location = New System.Drawing.Point(592, 453)
        Me.txtSubTotalImpuesto.MaxLength = 15
        Me.txtSubTotalImpuesto.Name = "txtSubTotalImpuesto"
        Me.txtSubTotalImpuesto.ReadOnly = True
        Me.txtSubTotalImpuesto.Size = New System.Drawing.Size(75, 20)
        Me.txtSubTotalImpuesto.TabIndex = 184
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(535, 453)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 185
        Me.Label15.Text = "Impuesto"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BackColor = System.Drawing.Color.Bisque
        Me.TxtSubTotal.Location = New System.Drawing.Point(592, 427)
        Me.TxtSubTotal.MaxLength = 15
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(75, 20)
        Me.TxtSubTotal.TabIndex = 182
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(532, 427)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 183
        Me.Label14.Text = "SubTotal"
        '
        'BtnEliminarDetalle
        '
        Me.BtnEliminarDetalle.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.BtnEliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarDetalle.Location = New System.Drawing.Point(170, 190)
        Me.BtnEliminarDetalle.Name = "BtnEliminarDetalle"
        Me.BtnEliminarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarDetalle.TabIndex = 181
        Me.BtnEliminarDetalle.Text = "&Eliminar"
        Me.BtnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'BtnGrabarDetalle
        '
        Me.BtnGrabarDetalle.Image = Global.Carnes.My.Resources.Resources.grabar
        Me.BtnGrabarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabarDetalle.Location = New System.Drawing.Point(89, 190)
        Me.BtnGrabarDetalle.Name = "BtnGrabarDetalle"
        Me.BtnGrabarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabarDetalle.TabIndex = 180
        Me.BtnGrabarDetalle.Text = "&Grabar"
        Me.BtnGrabarDetalle.UseVisualStyleBackColor = True
        '
        'BtnNuevoDetalle
        '
        Me.BtnNuevoDetalle.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnNuevoDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoDetalle.Location = New System.Drawing.Point(8, 190)
        Me.BtnNuevoDetalle.Name = "BtnNuevoDetalle"
        Me.BtnNuevoDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoDetalle.TabIndex = 179
        Me.BtnNuevoDetalle.Text = "&Nuevo"
        Me.BtnNuevoDetalle.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 249)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 178
        Me.Label13.Text = "Total"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Bisque
        Me.TxtTotal.Location = New System.Drawing.Point(324, 246)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(75, 20)
        Me.TxtTotal.TabIndex = 177
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(195, 246)
        Me.TxtPrecio.MaxLength = 15
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(75, 20)
        Me.TxtPrecio.TabIndex = 147
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(152, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "Precio"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(67, 246)
        Me.TxtCantidad.MaxLength = 15
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(75, 20)
        Me.TxtCantidad.TabIndex = 146
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 246)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "Cantidad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 149)
        Me.DataGridView1.TabIndex = 174
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(67, 219)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscarArticulo.TabIndex = 145
        Me.BtnBuscarArticulo.Text = "..."
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'TxtDescripcionArticulo
        '
        Me.TxtDescripcionArticulo.BackColor = System.Drawing.Color.Bisque
        Me.TxtDescripcionArticulo.Location = New System.Drawing.Point(170, 220)
        Me.TxtDescripcionArticulo.Name = "TxtDescripcionArticulo"
        Me.TxtDescripcionArticulo.ReadOnly = True
        Me.TxtDescripcionArticulo.Size = New System.Drawing.Size(318, 20)
        Me.TxtDescripcionArticulo.TabIndex = 173
        '
        'TxtCodigoArticulo
        '
        Me.TxtCodigoArticulo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigoArticulo.Location = New System.Drawing.Point(93, 220)
        Me.TxtCodigoArticulo.Name = "TxtCodigoArticulo"
        Me.TxtCodigoArticulo.ReadOnly = True
        Me.TxtCodigoArticulo.Size = New System.Drawing.Size(75, 20)
        Me.TxtCodigoArticulo.TabIndex = 172
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 171
        Me.Label10.Text = "Articulo"
        '
        'TxtOrdendeCompra
        '
        Me.TxtOrdendeCompra.Location = New System.Drawing.Point(106, 125)
        Me.TxtOrdendeCompra.MaxLength = 15
        Me.TxtOrdendeCompra.Name = "TxtOrdendeCompra"
        Me.TxtOrdendeCompra.Size = New System.Drawing.Size(101, 20)
        Me.TxtOrdendeCompra.TabIndex = 143
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 170
        Me.Label9.Text = "Orden de Compra"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(93, 151)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(395, 20)
        Me.txtObservacion.TabIndex = 144
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Observaciones"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Bisque
        Me.txtEstado.Location = New System.Drawing.Point(476, 43)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(87, 20)
        Me.txtEstado.TabIndex = 168
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(420, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 167
        Me.Label7.Text = "Estado"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.BackColor = System.Drawing.Color.Bisque
        Me.TxtImpuesto.Location = New System.Drawing.Point(369, 69)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(87, 20)
        Me.TxtImpuesto.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(313, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Impuesto"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(67, 94)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscarCliente.TabIndex = 142
        Me.BtnBuscarCliente.Text = "..."
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.Bisque
        Me.txtRazonSocial.Location = New System.Drawing.Point(170, 95)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(318, 20)
        Me.txtRazonSocial.TabIndex = 164
        '
        'TxtCodigoCliente
        '
        Me.TxtCodigoCliente.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigoCliente.Location = New System.Drawing.Point(93, 95)
        Me.TxtCodigoCliente.Name = "TxtCodigoCliente"
        Me.TxtCodigoCliente.ReadOnly = True
        Me.TxtCodigoCliente.Size = New System.Drawing.Size(75, 20)
        Me.TxtCodigoCliente.TabIndex = 163
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Cliente"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.Bisque
        Me.txtFecha.Location = New System.Drawing.Point(259, 43)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(148, 20)
        Me.txtFecha.TabIndex = 160
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Fecha"
        '
        'TxtCorrelativo
        '
        Me.TxtCorrelativo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCorrelativo.Location = New System.Drawing.Point(213, 69)
        Me.TxtCorrelativo.Name = "TxtCorrelativo"
        Me.TxtCorrelativo.ReadOnly = True
        Me.TxtCorrelativo.Size = New System.Drawing.Size(87, 20)
        Me.TxtCorrelativo.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Correlativo"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.Bisque
        Me.txtSerie.Location = New System.Drawing.Point(89, 69)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(53, 20)
        Me.txtSerie.TabIndex = 156
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Serie"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigo.Location = New System.Drawing.Point(89, 43)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 155
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Codigo"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Carnes.My.Resources.Resources.salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(600, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 152
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnCerrarEstado
        '
        Me.BtnCerrarEstado.Image = Global.Carnes.My.Resources.Resources.cerrar
        Me.BtnCerrarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarEstado.Location = New System.Drawing.Point(498, 12)
        Me.BtnCerrarEstado.Name = "BtnCerrarEstado"
        Me.BtnCerrarEstado.Size = New System.Drawing.Size(96, 23)
        Me.BtnCerrarEstado.TabIndex = 190
        Me.BtnCerrarEstado.Text = "&Cerrar Estado"
        Me.BtnCerrarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarEstado.UseVisualStyleBackColor = True
        '
        'BtnAnular
        '
        Me.BtnAnular.Image = Global.Carnes.My.Resources.Resources.anular
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(417, 12)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnular.TabIndex = 189
        Me.BtnAnular.Text = "&Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Carnes.My.Resources.Resources.imprimir
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(335, 12)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(80, 23)
        Me.BtnImprimir.TabIndex = 153
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Carnes.My.Resources.Resources.buscar
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(255, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 151
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(174, 12)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 150
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.Carnes.My.Resources.Resources.grabar
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(93, 12)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 149
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 148
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'FrmCotizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 514)
        Me.Controls.Add(Me.TxtCOTCODDET)
        Me.Controls.Add(Me.BtnCerrarEstado)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.LBLTotalLetras)
        Me.Controls.Add(Me.TxtTotalGeneral)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtSubTotalImpuesto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtSubTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnEliminarDetalle)
        Me.Controls.Add(Me.BtnGrabarDetalle)
        Me.Controls.Add(Me.BtnNuevoDetalle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnBuscarArticulo)
        Me.Controls.Add(Me.TxtDescripcionArticulo)
        Me.Controls.Add(Me.TxtCodigoArticulo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtOrdendeCompra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBuscarCliente)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.TxtCodigoCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCorrelativo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmCotizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCOTCODDET As System.Windows.Forms.TextBox
    Friend WithEvents BtnCerrarEstado As System.Windows.Forms.Button
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents LBLTotalLetras As System.Windows.Forms.Label
    Friend WithEvents TxtTotalGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarDetalle As System.Windows.Forms.Button
    Friend WithEvents BtnGrabarDetalle As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnBuscarArticulo As System.Windows.Forms.Button
    Friend WithEvents TxtDescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdendeCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
End Class
