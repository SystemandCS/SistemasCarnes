' Esta clase contiene diferentes procedimientos y funciones que se encarga de realizar acciones
' con diferentes tipos de controles.
Public Class ClsFormularios
    ' Colorea con blanco los casilleros de texto de un formulario.
    Public Shared Sub Blanquear(ByVal formulario As System.Windows.Forms.Form)
        ' Defino variables
        Dim texto As System.Windows.Forms.Control

        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)
        For Each texto In formulario.Controls
            If TypeOf texto Is System.Windows.Forms.TextBox Then
                texto.BackColor = System.Drawing.Color.White
            End If
        Next
    End Sub

    ' Colorea con un determinado color los casilleros de texto de un formulario.
    Public Shared Sub Blanquear(ByVal formulario As System.Windows.Forms.Form, ByVal coloracion As System.Drawing.Color)
        ' Defino variables
        Dim texto As System.Windows.Forms.Control

        ' Recorro la colección de objetos y si es textbox le asigno el color pasado por parámetro
        For Each texto In formulario.Controls
            If TypeOf texto Is System.Windows.Forms.TextBox Then
                texto.BackColor = coloracion
            End If
        Next
    End Sub

    ' Colorea con un determinado color los casilleros de texto de un formulario y además limpia sus contenidos.
    Public Shared Sub Blanquear(ByVal formulario As System.Windows.Forms.Form, ByVal coloracion As System.Drawing.Color, ByVal vaciar As Boolean)
        ' Defino variables
        Dim texto As System.Windows.Forms.Control

        ' Recorro la colección de objetos y si es textbox le asigno el color pasado por parámetro
        For Each texto In formulario.Controls
            If TypeOf texto Is System.Windows.Forms.TextBox Then
                texto.BackColor = coloracion
            End If
        Next

        ' Verifico si debo limpiar los casilleros de texto
        If vaciar Then
            Limpiar(formulario)
        End If
    End Sub

#Region "Rutina de Bloquear Habilitar los textbox del Formulario"

    ' Limpia el contenido de los casilleros de texto de un formulario.
    Public Shared Sub Limpiar(ByVal formulario As System.Windows.Forms.Form)

        ' Limpiar los objetos del Formulario

        Dim obj As System.Windows.Forms.Control

        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)
        For Each obj In formulario.Controls
            If TypeOf obj Is System.Windows.Forms.TextBox Then
                obj.Text = ""
                CType(obj, TextBox).ReadOnly = False

                If TypeOf obj Is System.Windows.Forms.ComboBox Then
                    CType(obj, ComboBox).SelectedItem = 0

                    CType(obj, ComboBox).Enabled = True
                End If

            End If



        Next
    End Sub






    Public Shared Sub Limpiar(ByVal GroupBox As System.Windows.Forms.GroupBox)
        ' Limpiar los objetos del GroupBox



        Dim obj As Control
        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)

        For Each obj In GroupBox.Controls
            If TypeOf (obj) Is TextBox Then
                obj.Text = ""
                CType(obj, TextBox).ReadOnly = False
            End If


            If TypeOf obj Is System.Windows.Forms.ComboBox Then
                CType(obj, ComboBox).SelectedItem = 0
                CType(obj, ComboBox).Enabled = True

            End If
        Next


    End Sub



#End Region
#Region "Rutina de Bloquear Habilitar los textbox del Formulario"



    Public Shared Sub Bloquear(ByVal formulario As System.Windows.Forms.Form)


        ' bloquear los objetos del GroupBox

        Dim obj As Control

        ' Recorro la colección de objetos y si es textbox lo pongo en readonly
        For Each obj In formulario.Controls
            If TypeOf obj Is System.Windows.Forms.TextBox Then
                CType(obj, TextBox).ReadOnly = True
            End If


            If TypeOf obj Is System.Windows.Forms.ComboBox Then
                CType(obj, ComboBox).Enabled = False
            End If

            If TypeOf obj Is System.Windows.Forms.CheckBox Then
                CType(obj, CheckBox).Enabled = False
            End If



        Next
    End Sub

    Public Shared Sub Bloquear(ByVal GroupBox As System.Windows.Forms.GroupBox)


        ' bloquear los objetos del GroupBox

        Dim obj As Control
        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)

        For Each obj In GroupBox.Controls
            If TypeOf (obj) Is TextBox Then
                CType(obj, TextBox).ReadOnly = True
            End If


            If TypeOf obj Is System.Windows.Forms.ComboBox Then
                CType(obj, ComboBox).Enabled = False
            End If


            If TypeOf obj Is System.Windows.Forms.CheckBox Then
                CType(obj, CheckBox).Enabled = False
            End If


        Next


    End Sub

#End Region
#Region "Rutina de Habilitar Habilitar los textbox del Formulario"

    ' habilitar los objetos del formulario

    Public Shared Sub Habilitar(ByVal formulario As System.Windows.Forms.Form)
        ' Defino variables
        Dim obj As Control

        ' Recorro la colección de objetos y si es textbox lo pongo en readonly
        For Each obj In formulario.Controls

            If TypeOf obj Is System.Windows.Forms.TextBox Then
                CType(obj, TextBox).ReadOnly = False
            End If

            If TypeOf obj Is System.Windows.Forms.ComboBox Then
                CType(obj, ComboBox).Enabled = True
            End If

            If TypeOf obj Is System.Windows.Forms.CheckBox Then
                CType(obj, CheckBox).Enabled = True
            End If



        Next
    End Sub

    ' habilitar los objetos dentro de un GroupBox

    Public Shared Sub Habilitar(ByVal GroupBox As System.Windows.Forms.GroupBox)


        Dim obj As Control
        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)

        For Each obj In GroupBox.Controls
            If TypeOf (obj) Is TextBox Then

                CType(obj, TextBox).ReadOnly = False
            End If

            If TypeOf obj Is System.Windows.Forms.ComboBox Then
                CType(obj, ComboBox).Enabled = True
            End If

            If TypeOf obj Is System.Windows.Forms.CheckBox Then
                CType(obj, CheckBox).Enabled = True
            End If


        Next


    End Sub


#End Region

End Class


