Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class ClsArticulos
    Protected cn As New SqlConnection
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaArticulos(FAMCOD As String, SUBFAMCOD As String, MARCOD As String, ARTDES As String, ARTPRECIO As Double, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_ARTICULOS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FAMCOD", FAMCOD)
                .Parameters.AddWithValue("@SUBFAMCOD", SUBFAMCOD)
                .Parameters.AddWithValue("@MARCOD", MARCOD)
                .Parameters.AddWithValue("@ARTDES", ARTDES)
                .Parameters.AddWithValue("@ARTPRECIO", ARTPRECIO)
                .Parameters.AddWithValue("@USUREG", USUREG)
                retorno = .ExecuteScalar
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return retorno
    End Function

    Public Function ActualizaArticulos(ARTCOD As String, FAMCOD As String, SUBFAMCOD As String, MARCOD As String, ARTDES As String, ARTPRECIO As Double, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_ARTICULOS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ARTCOD", ARTCOD)
                .Parameters.AddWithValue("@FAMCOD", FAMCOD)
                .Parameters.AddWithValue("@SUBFAMCOD", SUBFAMCOD)
                .Parameters.AddWithValue("@MARCOD", MARCOD)
                .Parameters.AddWithValue("@ARTDES", ARTDES)
                .Parameters.AddWithValue("@ARTPRECIO", ARTPRECIO)
                .Parameters.AddWithValue("@USUMOD", USUMOD)
                Retorno = .ExecuteScalar
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Retorno
    End Function


    Public Function EliminaArticulos(ARTCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_ARTICULOS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ARTCOD", ARTCOD)
                Retorno = .ExecuteScalar
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Retorno
    End Function

    Public Function ListaArticulos(ARTCOD As String, ARTDES As String, FAMDES As String, SUBFAMDES As String, MARDES As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_ARTICULOS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ARTCOD", ARTCOD)
                .SelectCommand.Parameters.AddWithValue("@ARTDES", ARTDES)
                .SelectCommand.Parameters.AddWithValue("@FAMDES", FAMDES)
                .SelectCommand.Parameters.AddWithValue("@SUBFAMDES", SUBFAMDES)
                .SelectCommand.Parameters.AddWithValue("@MARDES", MARDES)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function RptArticulos() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_ARTICULOS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function BuscaArticulos(Codigo As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_ARTICULOS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ARTCOD", Codigo)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function BuscaImagenArticulos(ARTCOD As String) As Byte()
        Dim Retorno As Byte()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_BUSCAIMAGEN_ARTICULOS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ARTCOD", ARTCOD)
                Retorno = CType(.ExecuteScalar(), Byte())
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Retorno
    End Function

    Public Function GrabaImagenArticulos(ARTCOD As String, ms As System.IO.MemoryStream) As Integer
        Dim Retorno As Integer
        Try
            Dim arrImage() As Byte = ms.GetBuffer
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_GRABAIMAGEN_ARTICULOS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@ARTCOD", SqlDbType.VarChar).Value = ARTCOD
                .Parameters.Add("@FOTO", SqlDbType.Image).Value = arrImage
                Retorno = .ExecuteNonQuery()
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Retorno
    End Function

    Public Function RptKardex(HASTA As DateTime, CODARTDESDE As String, CODARTHASTA As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_KARDEX", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@HASTA", HASTA)
                .SelectCommand.Parameters.AddWithValue("@CODARTDESDE", CODARTDESDE)
                .SelectCommand.Parameters.AddWithValue("@CODARTHASTA", CODARTHASTA)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

End Class
