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

    ' Limpia el contenido de los casilleros de texto de un formulario.
    Public Shared Sub Limpiar(ByVal formulario As System.Windows.Forms.Form)
        ' Defino variables
        Dim texto As System.Windows.Forms.Control

        ' Recorro la colección de objetos y si es textbox lo pongo en blanco (blanqueo)
        For Each texto In formulario.Controls
            If TypeOf texto Is System.Windows.Forms.TextBox Then
                texto.Text = ""
            End If




        Next
    End Sub



End Class


