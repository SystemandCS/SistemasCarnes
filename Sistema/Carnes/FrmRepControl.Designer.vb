<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepControl
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBFrigorifico = New System.Windows.Forms.ComboBox()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSALIR = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Frigorifico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CMBFrigorifico
        '
        Me.CMBFrigorifico.FormattingEnabled = True
        Me.CMBFrigorifico.Location = New System.Drawing.Point(159, 24)
        Me.CMBFrigorifico.Name = "CMBFrigorifico"
        Me.CMBFrigorifico.Size = New System.Drawing.Size(153, 21)
        Me.CMBFrigorifico.TabIndex = 24
        '
        'DtpHasta
        '
        Me.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHasta.Location = New System.Drawing.Point(159, 84)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(90, 20)
        Me.DtpHasta.TabIndex = 19
        '
        'DtpDesde
        '
        Me.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDesde.Location = New System.Drawing.Point(158, 58)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(90, 20)
        Me.DtpDesde.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Desde"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Image = Global.Carnes.My.Resources.Resources.nuevo
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(168, 128)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 23
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSALIR
        '
        Me.BtnSALIR.Image = Global.Carnes.My.Resources.Resources.salir
        Me.BtnSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSALIR.Location = New System.Drawing.Point(249, 128)
        Me.BtnSALIR.Name = "BtnSALIR"
        Me.BtnSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BtnSALIR.TabIndex = 22
        Me.BtnSALIR.Text = "&Salir"
        Me.BtnSALIR.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = Global.Carnes.My.Resources.Resources.aceptar
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(87, 128)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 21
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'FrmRepControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 217)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBFrigorifico)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.DtpHasta)
        Me.Controls.Add(Me.DtpDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSALIR)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Name = "FrmRepControl"
        Me.Text = "FrmRepControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents CMBFrigorifico As ComboBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSALIR As Button
    Friend WithEvents BtnAceptar As Button
End Class
