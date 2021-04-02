Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsFacturacionDet
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaFacturacionDet(FACCOD As String, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_FACTURACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCOD", FACCOD)
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


    Public Function ActualizaFacturacionDet(FACCODDET As Long, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUMOD As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_FACTURACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCODDET", FACCODDET)
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


    Public Function EliminaFacturacionDet(FACCODDET As Long) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_FACTURACIONDET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FACCODDET", FACCODDET)
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


    Public Function ListaFacturacionDet(FACCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_FACTURACIONDET", cnx)
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


    Public Function ListaFacturacionDet2(FACCODDET As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_FACTURACIONDET", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@FACCODDET", FACCODDET)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function ListaFacturacionDetTotales(FACCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_FACTURACIONDET_TOT", cnx)
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

End Class
