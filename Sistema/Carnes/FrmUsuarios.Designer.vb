<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CmbIdSuperior = New System.Windows.Forms.ComboBox()
        Me.CmbIdFrigorifico = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DgModulo = New System.Windows.Forms.DataGridView()
        Me.CmbJerarquia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckMarcarTodos = New System.Windows.Forms.CheckBox()
        Me.CheckSeleccionarTodos = New System.Windows.Forms.CheckBox()
        Me.ChkCodigo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ChkCodigo_1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgModulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(465, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(598, 165)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 12
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Image = Global.Carnes.My.Resources.Resources.grabar
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.Location = New System.Drawing.Point(679, 165)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrabar.TabIndex = 13
        Me.BtnGrabar.Text = "&Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(760, 165)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "&Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.Carnes.My.Resources.Resources.salir
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(851, 165)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodigo.Location = New System.Drawing.Point(529, 33)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 1
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(529, 59)
        Me.txtusuario.MaxLength = 30
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(166, 20)
        Me.txtusuario.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(760, 59)
        Me.TxtPassword.MaxLength = 30
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(166, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(696, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Usuario"
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(529, 85)
        Me.txtnombres.MaxLength = 100
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(166, 20)
        Me.txtnombres.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombres"
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(760, 85)
        Me.txtapellidos.MaxLength = 100
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(166, 20)
        Me.txtapellidos.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(696, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Apellidos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(465, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Superior"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(697, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Frigorifico"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(413, 150)
        Me.DataGridView1.TabIndex = 27
        '
        'CmbIdSuperior
        '
        Me.CmbIdSuperior.FormattingEnabled = True
        Me.CmbIdSuperior.Location = New System.Drawing.Point(529, 111)
        Me.CmbIdSuperior.Name = "CmbIdSuperior"
        Me.CmbIdSuperior.Size = New System.Drawing.Size(166, 21)
        Me.CmbIdSuperior.TabIndex = 250
        '
        'CmbIdFrigorifico
        '
        Me.CmbIdFrigorifico.FormattingEnabled = True
        Me.CmbIdFrigorifico.Location = New System.Drawing.Point(760, 111)
        Me.CmbIdFrigorifico.Name = "CmbIdFrigorifico"
        Me.CmbIdFrigorifico.Size = New System.Drawing.Size(166, 21)
        Me.CmbIdFrigorifico.TabIndex = 251
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 252
        Me.Label4.Text = "Listado de Usuarios"
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(760, 36)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(56, 17)
        Me.CheckActivo.TabIndex = 253
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChkCodigo_1})
        Me.DataGridView2.Location = New System.Drawing.Point(529, 252)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(397, 150)
        Me.DataGridView2.TabIndex = 254
        '
        'DgModulo
        '
        Me.DgModulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgModulo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChkCodigo})
        Me.DgModulo.Location = New System.Drawing.Point(12, 252)
        Me.DgModulo.Name = "DgModulo"
        Me.DgModulo.Size = New System.Drawing.Size(265, 150)
        Me.DgModulo.TabIndex = 255
        '
        'CmbJerarquia
        '
        Me.CmbJerarquia.FormattingEnabled = True
        Me.CmbJerarquia.Location = New System.Drawing.Point(339, 252)
        Me.CmbJerarquia.Name = "CmbJerarquia"
        Me.CmbJerarquia.Size = New System.Drawing.Size(142, 21)
        Me.CmbJerarquia.TabIndex = 256
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(283, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 257
        Me.Label8.Text = "Jerarquia"
        '
        'Button1
        '
        Me.Button1.Image = Global.Carnes.My.Resources.Resources.aceptar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(372, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 258
        Me.Button1.Text = "Agregar >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Carnes.My.Resources.Resources.eliminar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(372, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 259
        Me.Button2.Text = "<< Quitar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckMarcarTodos
        '
        Me.CheckMarcarTodos.AutoSize = True
        Me.CheckMarcarTodos.Location = New System.Drawing.Point(12, 421)
        Me.CheckMarcarTodos.Name = "CheckMarcarTodos"
        Me.CheckMarcarTodos.Size = New System.Drawing.Size(89, 17)
        Me.CheckMarcarTodos.TabIndex = 260
        Me.CheckMarcarTodos.Text = "Marca Todos"
        Me.CheckMarcarTodos.UseVisualStyleBackColor = True
        '
        'CheckSeleccionarTodos
        '
        Me.CheckSeleccionarTodos.AutoSize = True
        Me.CheckSeleccionarTodos.Location = New System.Drawing.Point(529, 421)
        Me.CheckSeleccionarTodos.Name = "CheckSeleccionarTodos"
        Me.CheckSeleccionarTodos.Size = New System.Drawing.Size(92, 17)
        Me.CheckSeleccionarTodos.TabIndex = 261
        Me.CheckSeleccionarTodos.Text = "Marcar Todos"
        Me.CheckSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'ChkCodigo
        '
        Me.ChkCodigo.HeaderText = ""
        Me.ChkCodigo.Name = "ChkCodigo"
        '
        'ChkCodigo_1
        '
        Me.ChkCodigo_1.HeaderText = ""
        Me.ChkCodigo_1.Name = "ChkCodigo_1"
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 450)
        Me.Controls.Add(Me.CheckSeleccionarTodos)
        Me.Controls.Add(Me.CheckMarcarTodos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbJerarquia)
        Me.Controls.Add(Me.DgModulo)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmbIdFrigorifico)
        Me.Controls.Add(Me.CmbIdSuperior)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnombres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgModulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmbIdSuperior As ComboBox
    Friend WithEvents CmbIdFrigorifico As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DgModulo As DataGridView
    Friend WithEvents CmbJerarquia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckMarcarTodos As CheckBox
    Friend WithEvents CheckSeleccionarTodos As CheckBox
    Friend WithEvents ChkCodigo As DataGridViewCheckBoxColumn
    Friend WithEvents ChkCodigo_1 As DataGridViewCheckBoxColumn
End Class
