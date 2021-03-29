Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsSeries
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function ActualizaSeries(SERCOD As String, DOCUMENTO As String, SERIE As String, CORRELATIVO As String, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_SERIES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SERCOD", SERCOD)
                .Parameters.AddWithValue("@DOCUMENTO", DOCUMENTO)
                .Parameters.AddWithValue("@SERIE", SERIE)
                .Parameters.AddWithValue("@CORRELATIVO", CORRELATIVO)
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

    Public Function ListaSeries() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_SERIES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function BuscaSeries(Codigo As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_SERIES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@SERCOD", Codigo)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function ComboSeries() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_COMBO_SERIES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function
End Class
