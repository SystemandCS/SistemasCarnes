':::Libreria necesaria para manejo de directorios y archivos
Imports System.IO

Public Class FrmLogueo
    Private Sub FrmLogueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarArchivos()
        LeerArchivo()

    End Sub

    Private Sub CargarArchivos()


        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim Total = My.Computer.FileSystem.GetFiles(ELog.ObtenerUbicacion(), FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
            ' LblTotal.Text = "Total Archivos de Texto: " + CStr(Total.Count)

            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ELog.ObtenerUbicacion(), FileIO.SearchOption.SearchAllSubDirectories, "*.txt")
                ListBox1.Items.Add(archivos)
            Next
        Catch ex As Exception
            MsgBox("No se realizó la operación por: " & ex.Message)
        End Try

    End Sub


    Sub LeerArchivo()
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(ELog.ObtenerUbicacion() & "/20210414.txt")

        ':::Limpiamos nuestro ListBox
        ListBoxClientes.Items.Clear()

        Try
            ':::Indicamos mediante un While que mientras no sea el ultimo caracter repita el proceso
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Agregramos los registros encontrados
                ListBoxClientes.Items.Add(linea)
            End While

            leer.Close()
            ':::Total de registros cargados al ListBox
            '  LblTotal.Text = ListBoxClientes.Items.Count
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::Aprendamos de Programación:::")
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


        ' Obtenemos el valor seleccionado.
        '
        Dim value As Object = ListBox1.SelectedValue

        If (TypeOf value Is DataRowView) Then Return

        ' Mostramos el valor
        '
        MessageBox.Show(CStr(value))


    End Sub
End Class