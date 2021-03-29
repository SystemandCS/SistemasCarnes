<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdendeIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrdendeIngreso))
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodProveedor = New System.Windows.Forms.TextBox()
        Me.txtRazonSocial = New System.Windows.Forms.TextBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.TxtDescripcionArticulo = New System.Windows.Forms.TextBox()
        Me.TxtCodigoArticulo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnEliminarDetalle = New System.Windows.Forms.Button()
        Me.BtnGrabarDetalle = New System.Windows.Forms.Button()
        Me.BtnNuevoDetalle = New System.Windows.Forms.Button()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSubTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtTotalGeneral = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LBLTotalLetras = New System.Windows.Forms.Label()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.BtnCerrarEstado = New System.Windows.Forms.Button()
        Me.TxtORDINGDETCOD = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Image = Global.Carnes.My.Resources.Resources.buscar
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.Location = New System.Drawing.Point(258, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 94
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Carnes.My.Resources.Resources.salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(600, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 95
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(177, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 93
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.Carnes.My.Resources.Resources.grabar
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(96, 4)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 92
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(15, 4)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 91
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Carnes.My.Resources.Resources.imprimir
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.Location = New System.Drawing.Point(339, 4)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BtnImprimir.TabIndex = 96
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigo.Location = New System.Drawing.Point(90, 35)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Codigo"
        '
        'txtSerie
        '
        Me.txtSerie.BackColor = System.Drawing.Color.Bisque
        Me.txtSerie.Location = New System.Drawing.Point(90, 61)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.Size = New System.Drawing.Size(53, 20)
        Me.txtSerie.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Serie"
        '
        'TxtCorrelativo
        '
        Me.TxtCorrelativo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCorrelativo.Location = New System.Drawing.Point(214, 61)
        Me.TxtCorrelativo.Name = "TxtCorrelativo"
        Me.TxtCorrelativo.ReadOnly = True
        Me.TxtCorrelativo.Size = New System.Drawing.Size(87, 20)
        Me.TxtCorrelativo.TabIndex = 101
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Correlativo"
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.Bisque
        Me.txtFecha.Location = New System.Drawing.Point(260, 35)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(148, 20)
        Me.txtFecha.TabIndex = 103
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Proveedor"
        '
        'TxtCodProveedor
        '
        Me.TxtCodProveedor.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodProveedor.Location = New System.Drawing.Point(94, 87)
        Me.TxtCodProveedor.Name = "TxtCodProveedor"
        Me.TxtCodProveedor.ReadOnly = True
        Me.TxtCodProveedor.Size = New System.Drawing.Size(75, 20)
        Me.TxtCodProveedor.TabIndex = 106
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BackColor = System.Drawing.Color.Bisque
        Me.txtRazonSocial.Location = New System.Drawing.Point(171, 87)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.ReadOnly = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(318, 20)
        Me.txtRazonSocial.TabIndex = 107
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(68, 86)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscarProveedor.TabIndex = 1
        Me.BtnBuscarProveedor.Text = "..."
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(314, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Impuesto"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.BackColor = System.Drawing.Color.Bisque
        Me.TxtImpuesto.Location = New System.Drawing.Point(370, 61)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(87, 20)
        Me.TxtImpuesto.TabIndex = 111
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Bisque
        Me.txtEstado.Location = New System.Drawing.Point(477, 35)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(87, 20)
        Me.txtEstado.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(421, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Estado"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(94, 143)
        Me.txtObservacion.MaxLength = 250
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(395, 20)
        Me.txtObservacion.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Observaciones"
        '
        'TxtCotizacion
        '
        Me.TxtCotizacion.Location = New System.Drawing.Point(94, 117)
        Me.TxtCotizacion.MaxLength = 15
        Me.TxtCotizacion.Name = "TxtCotizacion"
        Me.TxtCotizacion.Size = New System.Drawing.Size(114, 20)
        Me.TxtCotizacion.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Nro. Cotizacion"
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(68, 211)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(25, 23)
        Me.BtnBuscarArticulo.TabIndex = 4
        Me.BtnBuscarArticulo.Text = "..."
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'TxtDescripcionArticulo
        '
        Me.TxtDescripcionArticulo.BackColor = System.Drawing.Color.Bisque
        Me.TxtDescripcionArticulo.Location = New System.Drawing.Point(171, 212)
        Me.TxtDescripcionArticulo.Name = "TxtDescripcionArticulo"
        Me.TxtDescripcionArticulo.ReadOnly = True
        Me.TxtDescripcionArticulo.Size = New System.Drawing.Size(318, 20)
        Me.TxtDescripcionArticulo.TabIndex = 120
        '
        'TxtCodigoArticulo
        '
        Me.TxtCodigoArticulo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigoArticulo.Location = New System.Drawing.Point(94, 212)
        Me.TxtCodigoArticulo.Name = "TxtCodigoArticulo"
        Me.TxtCodigoArticulo.ReadOnly = True
        Me.TxtCodigoArticulo.Size = New System.Drawing.Size(75, 20)
        Me.TxtCodigoArticulo.TabIndex = 119
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Articulo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 264)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(660, 149)
        Me.DataGridView1.TabIndex = 122
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(68, 238)
        Me.TxtCantidad.MaxLength = 15
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(75, 20)
        Me.TxtCantidad.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(196, 238)
        Me.TxtPrecio.MaxLength = 15
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(75, 20)
        Me.TxtPrecio.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(153, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Precio"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Bisque
        Me.TxtTotal.Location = New System.Drawing.Point(325, 238)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(75, 20)
        Me.TxtTotal.TabIndex = 127
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(277, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Total"
        '
        'BtnEliminarDetalle
        '
        Me.BtnEliminarDetalle.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.BtnEliminarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarDetalle.Location = New System.Drawing.Point(171, 182)
        Me.BtnEliminarDetalle.Name = "BtnEliminarDetalle"
        Me.BtnEliminarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarDetalle.TabIndex = 131
        Me.BtnEliminarDetalle.Text = "&Eliminar"
        Me.BtnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'BtnGrabarDetalle
        '
        Me.BtnGrabarDetalle.Image = Global.Carnes.My.Resources.Resources.grabar
        Me.BtnGrabarDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabarDetalle.Location = New System.Drawing.Point(90, 182)
        Me.BtnGrabarDetalle.Name = "BtnGrabarDetalle"
        Me.BtnGrabarDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabarDetalle.TabIndex = 130
        Me.BtnGrabarDetalle.Text = "&Grabar"
        Me.BtnGrabarDetalle.UseVisualStyleBackColor = True
        '
        'BtnNuevoDetalle
        '
        Me.BtnNuevoDetalle.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnNuevoDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoDetalle.Location = New System.Drawing.Point(9, 182)
        Me.BtnNuevoDetalle.Name = "BtnNuevoDetalle"
        Me.BtnNuevoDetalle.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevoDetalle.TabIndex = 129
        Me.BtnNuevoDetalle.Text = "&Nuevo"
        Me.BtnNuevoDetalle.UseVisualStyleBackColor = True
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BackColor = System.Drawing.Color.Bisque
        Me.TxtSubTotal.Location = New System.Drawing.Point(592, 419)
        Me.TxtSubTotal.MaxLength = 15
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(75, 20)
        Me.TxtSubTotal.TabIndex = 132
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(535, 419)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 133
        Me.Label14.Text = "SubTotal"
        '
        'txtSubTotalImpuesto
        '
        Me.txtSubTotalImpuesto.BackColor = System.Drawing.Color.Bisque
        Me.txtSubTotalImpuesto.Location = New System.Drawing.Point(592, 445)
        Me.txtSubTotalImpuesto.MaxLength = 15
        Me.txtSubTotalImpuesto.Name = "txtSubTotalImpuesto"
        Me.txtSubTotalImpuesto.ReadOnly = True
        Me.txtSubTotalImpuesto.Size = New System.Drawing.Size(75, 20)
        Me.txtSubTotalImpuesto.TabIndex = 134
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(535, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Impuesto"
        '
        'TxtTotalGeneral
        '
        Me.TxtTotalGeneral.BackColor = System.Drawing.Color.Bisque
        Me.TxtTotalGeneral.Location = New System.Drawing.Point(591, 471)
        Me.TxtTotalGeneral.MaxLength = 15
        Me.TxtTotalGeneral.Name = "TxtTotalGeneral"
        Me.TxtTotalGeneral.ReadOnly = True
        Me.TxtTotalGeneral.Size = New System.Drawing.Size(75, 20)
        Me.TxtTotalGeneral.TabIndex = 136
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(534, 471)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Total"
        '
        'LBLTotalLetras
        '
        Me.LBLTotalLetras.Location = New System.Drawing.Point(11, 426)
        Me.LBLTotalLetras.Name = "LBLTotalLetras"
        Me.LBLTotalLetras.Size = New System.Drawing.Size(501, 65)
        Me.LBLTotalLetras.TabIndex = 138
        '
        'BtnAnular
        '
        Me.BtnAnular.Image = Global.Carnes.My.Resources.Resources.anular
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.Location = New System.Drawing.Point(420, 4)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnular.TabIndex = 139
        Me.BtnAnular.Text = "&Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'BtnCerrarEstado
        '
        Me.BtnCerrarEstado.Image = Global.Carnes.My.Resources.Resources.cerrar
        Me.BtnCerrarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarEstado.Location = New System.Drawing.Point(501, 4)
        Me.BtnCerrarEstado.Name = "BtnCerrarEstado"
        Me.BtnCerrarEstado.Size = New System.Drawing.Size(93, 23)
        Me.BtnCerrarEstado.TabIndex = 140
        Me.BtnCerrarEstado.Text = "&Cerrar Estado"
        Me.BtnCerrarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrarEstado.UseVisualStyleBackColor = True
        '
        'TxtORDINGDETCOD
        '
        Me.TxtORDINGDETCOD.BackColor = System.Drawing.Color.Bisque
        Me.TxtORDINGDETCOD.Location = New System.Drawing.Point(520, 215)
        Me.TxtORDINGDETCOD.Name = "TxtORDINGDETCOD"
        Me.TxtORDINGDETCOD.ReadOnly = True
        Me.TxtORDINGDETCOD.Size = New System.Drawing.Size(100, 20)
        Me.TxtORDINGDETCOD.TabIndex = 141
        '
        'FrmOrdendeIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 493)
        Me.Controls.Add(Me.TxtORDINGDETCOD)
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
        Me.Controls.Add(Me.TxtCotizacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBuscarProveedor)
        Me.Controls.Add(Me.txtRazonSocial)
        Me.Controls.Add(Me.TxtCodProveedor)
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
        Me.Name = "FrmOrdendeIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Ingreso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCodProveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscarProveedor As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarArticulo As System.Windows.Forms.Button
    Friend WithEvents TxtDescripcionArticulo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigoArticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnEliminarDetalle As System.Windows.Forms.Button
    Friend WithEvents BtnGrabarDetalle As System.Windows.Forms.Button
    Friend WithEvents BtnNuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotalImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalGeneral As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LBLTotalLetras As System.Windows.Forms.Label
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents BtnCerrarEstado As System.Windows.Forms.Button
    Friend WithEvents TxtORDINGDETCOD As System.Windows.Forms.TextBox
End Class
