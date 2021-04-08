<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Me.DgProveedores = New System.Windows.Forms.DataGridView()
        Me.TxtidProveedor = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlDetalle = New System.Windows.Forms.Panel()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.CmbcondIva = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtProcedencia = New System.Windows.Forms.TextBox()
        Me.CmbTipoCaracter = New System.Windows.Forms.ComboBox()
        Me.ChkIngBrutos = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ChkGanancias = New System.Windows.Forms.CheckBox()
        Me.TxtProvNro = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabDomicilio = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtCPostal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Txtpiso = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmbPais = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCalle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDetalle.SuspendLayout()
        Me.TabDomicilio.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgProveedores
        '
        Me.DgProveedores.AllowUserToAddRows = False
        Me.DgProveedores.AllowUserToDeleteRows = False
        Me.DgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgProveedores.Location = New System.Drawing.Point(12, 22)
        Me.DgProveedores.Name = "DgProveedores"
        Me.DgProveedores.Size = New System.Drawing.Size(447, 243)
        Me.DgProveedores.TabIndex = 28
        '
        'TxtidProveedor
        '
        Me.TxtidProveedor.BackColor = System.Drawing.Color.Bisque
        Me.TxtidProveedor.Location = New System.Drawing.Point(182, 3)
        Me.TxtidProveedor.Name = "TxtidProveedor"
        Me.TxtidProveedor.ReadOnly = True
        Me.TxtidProveedor.Size = New System.Drawing.Size(100, 20)
        Me.TxtidProveedor.TabIndex = 255
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(793, 426)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(92, 32)
        Me.BtnSalir.TabIndex = 267
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(793, 388)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(94, 32)
        Me.BtnEliminar.TabIndex = 266
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(793, 350)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(94, 32)
        Me.BtnGrabar.TabIndex = 264
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(793, 312)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(92, 32)
        Me.BtnNuevo.TabIndex = 263
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 254
        Me.Label1.Text = "Codigo"
        '
        'PnlDetalle
        '
        Me.PnlDetalle.Controls.Add(Me.TxtCuit)
        Me.PnlDetalle.Controls.Add(Me.CmbcondIva)
        Me.PnlDetalle.Controls.Add(Me.Label24)
        Me.PnlDetalle.Controls.Add(Me.Label23)
        Me.PnlDetalle.Controls.Add(Me.TxtProcedencia)
        Me.PnlDetalle.Controls.Add(Me.CmbTipoCaracter)
        Me.PnlDetalle.Controls.Add(Me.ChkIngBrutos)
        Me.PnlDetalle.Controls.Add(Me.Label19)
        Me.PnlDetalle.Controls.Add(Me.ChkGanancias)
        Me.PnlDetalle.Controls.Add(Me.TxtProvNro)
        Me.PnlDetalle.Controls.Add(Me.TxtidProveedor)
        Me.PnlDetalle.Controls.Add(Me.Label20)
        Me.PnlDetalle.Controls.Add(Me.Label1)
        Me.PnlDetalle.Controls.Add(Me.Label21)
        Me.PnlDetalle.Controls.Add(Me.TxtRazonSocial)
        Me.PnlDetalle.Controls.Add(Me.Label22)
        Me.PnlDetalle.Location = New System.Drawing.Point(478, 22)
        Me.PnlDetalle.Name = "PnlDetalle"
        Me.PnlDetalle.Size = New System.Drawing.Size(407, 249)
        Me.PnlDetalle.TabIndex = 272
        '
        'TxtCuit
        '
        Me.TxtCuit.Location = New System.Drawing.Point(82, 83)
        Me.TxtCuit.MaxLength = 100
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.Size = New System.Drawing.Size(200, 20)
        Me.TxtCuit.TabIndex = 318
        '
        'CmbcondIva
        '
        Me.CmbcondIva.FormattingEnabled = True
        Me.CmbcondIva.Location = New System.Drawing.Point(82, 110)
        Me.CmbcondIva.Name = "CmbcondIva"
        Me.CmbcondIva.Size = New System.Drawing.Size(200, 21)
        Me.CmbcondIva.TabIndex = 316
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 118)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 317
        Me.Label24.Text = "Cond Iva"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 147)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(67, 13)
        Me.Label23.TabIndex = 314
        Me.Label23.Text = "Procedencia"
        '
        'TxtProcedencia
        '
        Me.TxtProcedencia.Location = New System.Drawing.Point(82, 140)
        Me.TxtProcedencia.MaxLength = 100
        Me.TxtProcedencia.Name = "TxtProcedencia"
        Me.TxtProcedencia.Size = New System.Drawing.Size(200, 20)
        Me.TxtProcedencia.TabIndex = 315
        '
        'CmbTipoCaracter
        '
        Me.CmbTipoCaracter.FormattingEnabled = True
        Me.CmbTipoCaracter.Location = New System.Drawing.Point(82, 170)
        Me.CmbTipoCaracter.Name = "CmbTipoCaracter"
        Me.CmbTipoCaracter.Size = New System.Drawing.Size(200, 21)
        Me.CmbTipoCaracter.TabIndex = 313
        '
        'ChkIngBrutos
        '
        Me.ChkIngBrutos.AutoSize = True
        Me.ChkIngBrutos.Location = New System.Drawing.Point(208, 210)
        Me.ChkIngBrutos.Name = "ChkIngBrutos"
        Me.ChkIngBrutos.Size = New System.Drawing.Size(74, 17)
        Me.ChkIngBrutos.TabIndex = 280
        Me.ChkIngBrutos.Text = "Ing Brutos"
        Me.ChkIngBrutos.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 307
        Me.Label19.Text = "Prov Nro"
        '
        'ChkGanancias
        '
        Me.ChkGanancias.AutoSize = True
        Me.ChkGanancias.Location = New System.Drawing.Point(9, 210)
        Me.ChkGanancias.Name = "ChkGanancias"
        Me.ChkGanancias.Size = New System.Drawing.Size(77, 17)
        Me.ChkGanancias.TabIndex = 279
        Me.ChkGanancias.Text = "Ganancias"
        Me.ChkGanancias.UseVisualStyleBackColor = True
        '
        'TxtProvNro
        '
        Me.TxtProvNro.Location = New System.Drawing.Point(82, 31)
        Me.TxtProvNro.MaxLength = 100
        Me.TxtProvNro.Name = "TxtProvNro"
        Me.TxtProvNro.Size = New System.Drawing.Size(200, 20)
        Me.TxtProvNro.TabIndex = 306
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 13)
        Me.Label20.TabIndex = 308
        Me.Label20.Text = "Razon Social"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 178)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(28, 13)
        Me.Label21.TabIndex = 312
        Me.Label21.Text = "Tipo"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(82, 57)
        Me.TxtRazonSocial.MaxLength = 100
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(200, 20)
        Me.TxtRazonSocial.TabIndex = 311
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 91)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(25, 13)
        Me.Label22.TabIndex = 310
        Me.Label22.Text = "Cuit"
        '
        'TabDomicilio
        '
        Me.TabDomicilio.AccessibleDescription = "Domicilio Legal"
        Me.TabDomicilio.Controls.Add(Me.TabPage1)
        Me.TabDomicilio.Controls.Add(Me.TabPage2)
        Me.TabDomicilio.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.TabDomicilio.Location = New System.Drawing.Point(12, 271)
        Me.TabDomicilio.Name = "TabDomicilio"
        Me.TabDomicilio.SelectedIndex = 0
        Me.TabDomicilio.Size = New System.Drawing.Size(717, 177)
        Me.TabDomicilio.TabIndex = 273
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmbLocalidad)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TextBox4)
        Me.TabPage1.Controls.Add(Me.TxtCPostal)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.TextBox5)
        Me.TabPage1.Controls.Add(Me.Txtpiso)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.TxtNumero)
        Me.TabPage1.Controls.Add(Me.TextBox6)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.CmbPais)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtCalle)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CmbProvincia)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(709, 151)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CmbLocalidad
        '
        Me.CmbLocalidad.FormattingEnabled = True
        Me.CmbLocalidad.Location = New System.Drawing.Point(84, 51)
        Me.CmbLocalidad.Name = "CmbLocalidad"
        Me.CmbLocalidad.Size = New System.Drawing.Size(200, 21)
        Me.CmbLocalidad.TabIndex = 306
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 305
        Me.Label6.Text = "Piso"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(446, 82)
        Me.TextBox4.MaxLength = 100
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(78, 20)
        Me.TextBox4.TabIndex = 290
        '
        'TxtCPostal
        '
        Me.TxtCPostal.Location = New System.Drawing.Point(624, 17)
        Me.TxtCPostal.MaxLength = 100
        Me.TxtCPostal.Name = "TxtCPostal"
        Me.TxtCPostal.Size = New System.Drawing.Size(45, 20)
        Me.TxtCPostal.TabIndex = 304
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 289
        Me.Label5.Text = "Tel Celular"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(579, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 303
        Me.Label17.Text = "Cod Postal"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(575, 45)
        Me.TextBox5.MaxLength = 100
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(96, 20)
        Me.TextBox5.TabIndex = 288
        '
        'Txtpiso
        '
        Me.Txtpiso.Location = New System.Drawing.Point(520, 17)
        Me.Txtpiso.MaxLength = 100
        Me.Txtpiso.Name = "Txtpiso"
        Me.Txtpiso.Size = New System.Drawing.Size(53, 20)
        Me.Txtpiso.TabIndex = 302
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(340, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 13)
        Me.Label18.TabIndex = 301
        Me.Label18.Text = "Nro."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(530, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 287
        Me.Label9.Text = "Tel Fax"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(389, 17)
        Me.TxtNumero.MaxLength = 100
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(86, 20)
        Me.TxtNumero.TabIndex = 300
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(446, 51)
        Me.TextBox6.MaxLength = 100
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(78, 20)
        Me.TextBox6.TabIndex = 286
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(361, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 285
        Me.Label11.Text = "Telefonos"
        '
        'CmbPais
        '
        Me.CmbPais.FormattingEnabled = True
        Me.CmbPais.Location = New System.Drawing.Point(84, 114)
        Me.CmbPais.Name = "CmbPais"
        Me.CmbPais.Size = New System.Drawing.Size(200, 21)
        Me.CmbPais.TabIndex = 284
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 261
        Me.Label3.Text = "Calle"
        '
        'TxtCalle
        '
        Me.TxtCalle.Location = New System.Drawing.Point(84, 16)
        Me.TxtCalle.MaxLength = 100
        Me.TxtCalle.Name = "TxtCalle"
        Me.TxtCalle.Size = New System.Drawing.Size(200, 20)
        Me.TxtCalle.TabIndex = 259
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 269
        Me.Label10.Text = "Localidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 275
        Me.Label4.Text = "Pais"
        '
        'CmbProvincia
        '
        Me.CmbProvincia.FormattingEnabled = True
        Me.CmbProvincia.Location = New System.Drawing.Point(84, 84)
        Me.CmbProvincia.Name = "CmbProvincia"
        Me.CmbProvincia.Size = New System.Drawing.Size(200, 21)
        Me.CmbProvincia.TabIndex = 271
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 273
        Me.Label2.Text = "Provincia"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(709, 151)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(426, 524)
        Me.TextBox1.MaxLength = 100
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 20)
        Me.TextBox1.TabIndex = 279
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(576, 524)
        Me.TextBox2.MaxLength = 100
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(53, 20)
        Me.TextBox2.TabIndex = 281
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 280
        Me.Label7.Text = "RUCA"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(680, 524)
        Me.TextBox3.MaxLength = 100
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(45, 20)
        Me.TextBox3.TabIndex = 283
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(647, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 282
        Me.Label8.Text = "P.V."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 458)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 292
        Me.Label12.Text = "Email"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(100, 454)
        Me.TextBox7.MaxLength = 100
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(271, 20)
        Me.TextBox7.TabIndex = 291
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 493)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = "Email"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(100, 490)
        Me.TextBox8.MaxLength = 100
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(271, 20)
        Me.TextBox8.TabIndex = 293
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(378, 462)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 296
        Me.Label14.Text = "Observaciones"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(462, 458)
        Me.TextBox9.MaxLength = 100
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(263, 25)
        Me.TextBox9.TabIndex = 295
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(378, 493)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 298
        Me.Label15.Text = "Observaciones"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(462, 489)
        Me.TextBox10.MaxLength = 100
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(263, 20)
        Me.TextBox10.TabIndex = 297
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(527, 531)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 299
        Me.Label16.Text = "Rec"
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 562)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TabDomicilio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PnlDetalle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.DgProveedores)
        Me.Name = "FrmProveedores"
        Me.Text = "FrmProveedores"
        CType(Me.DgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDetalle.ResumeLayout(False)
        Me.PnlDetalle.PerformLayout()
        Me.TabDomicilio.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgProveedores As DataGridView
    Friend WithEvents TxtidProveedor As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlDetalle As Panel
    Friend WithEvents ChkIngBrutos As CheckBox
    Friend WithEvents ChkGanancias As CheckBox
    Friend WithEvents TabDomicilio As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCPostal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Txtpiso As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents CmbTipoCaracter As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtProvNro As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CmbPais As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCalle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbProvincia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtProcedencia As TextBox
    Friend WithEvents CmbcondIva As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtCuit As TextBox
    Friend WithEvents CmbLocalidad As ComboBox
End Class
