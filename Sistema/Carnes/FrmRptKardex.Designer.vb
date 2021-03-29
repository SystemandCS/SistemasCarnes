<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRptKardex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRptKardex))
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSALIR = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.txtDesArtDesde = New System.Windows.Forms.TextBox()
        Me.TxtCodArtDesde = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscarArticuloDesde = New System.Windows.Forms.Button()
        Me.BtnBuscarArticuloHasta = New System.Windows.Forms.Button()
        Me.txtDesArtHasta = New System.Windows.Forms.TextBox()
        Me.TxtCodArtHasta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(93, 12)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 19
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'DtpHasta
        '
        Me.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHasta.Location = New System.Drawing.Point(102, 66)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(90, 20)
        Me.DtpHasta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha Hasta"
        '
        'BtnSALIR
        '
        Me.BtnSALIR.Image = Global.Carnes.My.Resources.Resources.salir
        Me.BtnSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSALIR.Location = New System.Drawing.Point(174, 12)
        Me.BtnSALIR.Name = "BtnSALIR"
        Me.BtnSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BtnSALIR.TabIndex = 18
        Me.BtnSALIR.Text = "&Salir"
        Me.BtnSALIR.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Carnes.My.Resources.Resources.aceptar
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(12, 12)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 17
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'txtDesArtDesde
        '
        Me.txtDesArtDesde.BackColor = System.Drawing.Color.Bisque
        Me.txtDesArtDesde.Location = New System.Drawing.Point(208, 98)
        Me.txtDesArtDesde.MaxLength = 250
        Me.txtDesArtDesde.Name = "txtDesArtDesde"
        Me.txtDesArtDesde.ReadOnly = True
        Me.txtDesArtDesde.Size = New System.Drawing.Size(300, 20)
        Me.txtDesArtDesde.TabIndex = 66
        '
        'TxtCodArtDesde
        '
        Me.TxtCodArtDesde.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodArtDesde.Location = New System.Drawing.Point(119, 98)
        Me.TxtCodArtDesde.Name = "TxtCodArtDesde"
        Me.TxtCodArtDesde.ReadOnly = True
        Me.TxtCodArtDesde.Size = New System.Drawing.Size(83, 20)
        Me.TxtCodArtDesde.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Articulo Desde"
        '
        'BtnBuscarArticuloDesde
        '
        Me.BtnBuscarArticuloDesde.Location = New System.Drawing.Point(93, 96)
        Me.BtnBuscarArticuloDesde.Name = "BtnBuscarArticuloDesde"
        Me.BtnBuscarArticuloDesde.Size = New System.Drawing.Size(24, 23)
        Me.BtnBuscarArticuloDesde.TabIndex = 2
        Me.BtnBuscarArticuloDesde.Text = "..."
        Me.BtnBuscarArticuloDesde.UseVisualStyleBackColor = True
        '
        'BtnBuscarArticuloHasta
        '
        Me.BtnBuscarArticuloHasta.Location = New System.Drawing.Point(93, 127)
        Me.BtnBuscarArticuloHasta.Name = "BtnBuscarArticuloHasta"
        Me.BtnBuscarArticuloHasta.Size = New System.Drawing.Size(24, 23)
        Me.BtnBuscarArticuloHasta.TabIndex = 68
        Me.BtnBuscarArticuloHasta.Text = "..."
        Me.BtnBuscarArticuloHasta.UseVisualStyleBackColor = True
        '
        'txtDesArtHasta
        '
        Me.txtDesArtHasta.BackColor = System.Drawing.Color.Bisque
        Me.txtDesArtHasta.Location = New System.Drawing.Point(208, 129)
        Me.txtDesArtHasta.MaxLength = 250
        Me.txtDesArtHasta.Name = "txtDesArtHasta"
        Me.txtDesArtHasta.ReadOnly = True
        Me.txtDesArtHasta.Size = New System.Drawing.Size(300, 20)
        Me.txtDesArtHasta.TabIndex = 70
        '
        'TxtCodArtHasta
        '
        Me.TxtCodArtHasta.BackColor = System.Drawing.Color.Bisque
        Me.TxtCodArtHasta.Location = New System.Drawing.Point(119, 129)
        Me.TxtCodArtHasta.Name = "TxtCodArtHasta"
        Me.TxtCodArtHasta.ReadOnly = True
        Me.TxtCodArtHasta.Size = New System.Drawing.Size(83, 20)
        Me.TxtCodArtHasta.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Articulo Hasta"
        '
        'FrmRptKardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 175)
        Me.Controls.Add(Me.BtnBuscarArticuloHasta)
        Me.Controls.Add(Me.txtDesArtHasta)
        Me.Controls.Add(Me.TxtCodArtHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBuscarArticuloDesde)
        Me.Controls.Add(Me.txtDesArtDesde)
        Me.Controls.Add(Me.TxtCodArtDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSALIR)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmRptKardex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Kardex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLimpiar As System.Windows.Forms.Button
    Friend WithEvents DtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSALIR As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtDesArtDesde As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodArtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscarArticuloDesde As System.Windows.Forms.Button
    Friend WithEvents BtnBuscarArticuloHasta As System.Windows.Forms.Button
    Friend WithEvents txtDesArtHasta As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodArtHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
