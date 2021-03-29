Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsFacturacionCab
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaFacturacionCab(SERCOD As String,
    SERIE As String, CLICOD As String, IMPUESTO As Double,
    OBSERVACION As String, COTCOD As String, USUREG As String, CODFORMA As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_FACTURACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SERCOD", SERCOD)
                .Parameters.AddWithValue("@SERIE", SERIE)
                .Parameters.AddWithValue("@CLICOD", CLICOD)
                .Parameters.AddWithValue("@IMPUESTO", IMPUESTO)
                .Parameters.AddWithValue("@OBSERVACION", OBSERVACION)
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@USUREG", USUREG)
                .Parameters.AddWithValue("@CODFORMA", CODFORMA)
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


    Public Function ActualizaFacturacionCab(FACCOD As String,
    CLICOD As String, OBSERVACION As String, COTCOD As String, USUMOD As String, CODFORMA As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_FACTURACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
                .Parameters.AddWithValue("@CLICOD", CLICOD)
                .Parameters.AddWithValue("@OBSERVACION", OBSERVACION)
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@USUMOD", USUMOD)
                .Parameters.AddWithValue("@CODFORMA", CODFORMA)
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

    Public Function EliminaFacturacionCab(FACCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_FACTURACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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

    Public Function ListaFacturacionCab(FACCOD As String, SERIE As String, CORRELATIVO As String,
                                      CLICOD As String, DESDE As Date, HASTA As Date) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_FACTURACIONCAB", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@FACCOD", FACCOD)
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


    Public Function BuscaFacturacionCab(FACCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_FACTURACIONCAB", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@FACCOD", FACCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function AnularFacturacionCab(FACCOD As String, USUANULA As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ANULAR_FACTURACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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

    Public Function CerrarFacturacionCab(FACCOD As String, USUCIERRA As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_CERRAR_FACTURACIONCAB", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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
     
    Public Function SerieFacturacionCab(SERCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_SERIE_FACTURACIONCAB", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@SERCOD", SERCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function DocumentosParaFacturacion() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_DOCUMENTOS_PARA_FACTURACION", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function ActualizarTotales(FACCOD As String, SUBTOTAL As Double, SUBTOTALIMPUESTO As Double, TOTALGENERAL As Double, TOTALLETRAS As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_FACTURACIONCAB_TOT", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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

    Public Function RPTFacturacion(FACCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_FACTURACION", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@FACCOD", FACCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function DetallesCotizacionParaFacturacion(COTCOD As String, FACCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_COTIZACION_PARA_FACTURACION", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@COTCOD", COTCOD)
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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
 

    Public Function RPTVentas(ESTADO As String, DESDE As Date, HASTA As Date) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_VENTAS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ESTADO", ESTADO)
                .SelectCommand.Parameters.AddWithValue("@DESDE", DESDE)
                .SelectCommand.Parameters.AddWithValue("@HASTA", HASTA)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

End Class
