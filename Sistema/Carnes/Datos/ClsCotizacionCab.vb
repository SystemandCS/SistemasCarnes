Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsCotizacionCab

    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaCotizacionCab(SERIE As String, CLICOD As String, IMPUESTO As Double,
            OBSERVACION As String, ORDENDECOMPRA As String, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_COTIZACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SERIE", SERIE)
                .Parameters.AddWithValue("@CLICOD", CLICOD)
                .Parameters.AddWithValue("@IMPUESTO", IMPUESTO)
                .Parameters.AddWithValue("@OBSERVACION", OBSERVACION)
                .Parameters.AddWithValue("@ORDENDECOMPRA", ORDENDECOMPRA)
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



    Public Function ActualizaCotizacionCab(COTCOD As String, CLICOD As String,
            OBSERVACION As String, ORDENDECOMPRA As String, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_COTIZACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@CLICOD", CLICOD)
                .Parameters.AddWithValue("@OBSERVACION", OBSERVACION)
                .Parameters.AddWithValue("@ORDENDECOMPRA", ORDENDECOMPRA)
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


    Public Function EliminaCotizacionCab(COTCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_COTIZACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
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

    Public Function ListaCotizacionCab(COTCOD As String, SERIE As String, CORRELATIVO As String,
                                       CLICOD As String, DESDE As Date, HASTA As Date) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_COTIZACIONCAB", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@COTCOD", COTCOD)
                .SelectCommand.Parameters.AddWithValue("@SERIE", SERIE)
                .SelectCommand.Parameters.AddWithValue("@CORRELATIVO", CORRELATIVO)
                .SelectCommand.Parameters.AddWithValue("@CLICOD", CLICOD)
                .SelectCommand.Parameters.AddWithValue("@DESDE", DESDE)
                .SelectCommand.Parameters.AddWithValue("@HASTA", HASTA)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function BuscaCotizacionCab(COTCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_COTIZACIONCAB", cnx)
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

    Public Function AnularCotizacionCab(COTCOD As String, USUANULA As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ANULAR_COTIZACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@USUANULA", USUANULA)
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


    Public Function CerrarCotizacionCab(COTCOD As String, USUCIERRA As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_CERRAR_COTIZACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@USUCIERRA", USUCIERRA)
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



    Public Function SerieCotizacionCab() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_SERIE_COTIZACIONCAB", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function ActualizarTotales(COTCOD As String, SUBTOTAL As Double,
 SUBTOTALIMPUESTO As Double, TOTALGENERAL As Double, TOTALLETRAS As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_COTIZACIONCAB_TOT", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@SUBTOTAL", SUBTOTAL)
                .Parameters.AddWithValue("@SUBTOTALIMPUESTO", SUBTOTALIMPUESTO)
                .Parameters.AddWithValue("@TOTALGENERAL", TOTALGENERAL)
                .Parameters.AddWithValue("@TOTALLETRAS", TOTALLETRAS)
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


    Public Function RPTCotizacion(COTCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_COTIZACION", cnx)
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

    Public Function CotizacionFacturado(COTCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_COTIZACION_FACTURADO", cnx)
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
