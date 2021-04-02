Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsCotizacionDet
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaCotizacionDet(COTCOD As String, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_COTIZACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@ARTCOD", ARTCOD)
                .Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
                .Parameters.AddWithValue("@PRECIO", PRECIO)
                .Parameters.AddWithValue("@TOTAL", TOTAL)
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


    Public Function ActualizaCotizacionDet(COTCODDET As Long, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUMOD As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_COTIZACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCODDET", COTCODDET)
                .Parameters.AddWithValue("@ARTCOD", ARTCOD)
                .Parameters.AddWithValue("@CANTIDAD", CANTIDAD)
                .Parameters.AddWithValue("@PRECIO", PRECIO)
                .Parameters.AddWithValue("@TOTAL", TOTAL)
                .Parameters.AddWithValue("@USUMOD", USUMOD)
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


    Public Function EliminaCotizacionDet(COTCODDET As Long) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_COTIZACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCODDET", COTCODDET)
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


    Public Function ListaCotizacionDet(COTCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_COTIZACIONDET", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@COTCOD", COTCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function ListaCotizacionDet2(COTCODDET As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_COTIZACIONDET", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@COTCODDET", COTCODDET)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function ListaCotizacionDetTotales(COTCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_COTIZACIONDET_TOT", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@COTCOD", COTCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


End Class
