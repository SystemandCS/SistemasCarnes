Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsSubFamilias
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaSubFamilias(SUBFAMDES As String, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_SUBFAMILIAS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SUBFAMDES", SUBFAMDES)
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

    Public Function ActualizaSubFamilias(SUBFAMCOD As String, SUBFAMDES As String, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_SUBFAMILIAS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SUBFAMCOD", SUBFAMCOD)
                .Parameters.AddWithValue("@SUBFAMDES", SUBFAMDES)
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


    Public Function EliminaSubFamilias(SUBFAMCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_SUBFAMILIAS", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@SUBFAMCOD", SUBFAMCOD)
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

    Public Function ListaSubFamilias(Valor As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_SUBFAMILIAS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@VALOR", Valor)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function RptSubFamilias() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_SUBFAMILIAS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function BuscaSubFamilias(Codigo As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_SUBFAMILIAS", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@SUBFAMCOD", Codigo)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function ComboSubFamilias() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_COMBO_SUBFAMILIAS", cnx)
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
