Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsClientes
    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaClientes(CLIRAZONSOCIAL As String, CLIRUC As String, CLIDIRECCION As String, CLITELEFONO As String, CLICELULAR As String, CLIEMAIL As String, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_CLIENTES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@CLIRAZONSOCIAL", CLIRAZONSOCIAL)
                .Parameters.AddWithValue("@CLIRUC", CLIRUC)
                .Parameters.AddWithValue("@CLIDIRECCION", CLIDIRECCION)
                .Parameters.AddWithValue("@CLITELEFONO", CLITELEFONO)
                .Parameters.AddWithValue("@CLICELULAR", CLICELULAR)
                .Parameters.AddWithValue("@CLIEMAIL", CLIEMAIL)
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

    Public Function ActualizaClientes(CLICOD As String, CLIRAZONSOCIAL As String, CLIRUC As String, CLIDIRECCION As String, CLITELEFONO As String, CLICELULAR As String, CLIEMAIL As String, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_CLIENTES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@CLICOD", CLICOD)
                .Parameters.AddWithValue("@CLIRAZONSOCIAL", CLIRAZONSOCIAL)
                .Parameters.AddWithValue("@CLIRUC", CLIRUC)
                .Parameters.AddWithValue("@CLIDIRECCION", CLIDIRECCION)
                .Parameters.AddWithValue("@CLITELEFONO", CLITELEFONO)
                .Parameters.AddWithValue("@CLICELULAR", CLICELULAR)
                .Parameters.AddWithValue("@CLIEMAIL", CLIEMAIL)
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


    Public Function EliminaClientes(CLICOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_CLIENTES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@CLICOD", CLICOD)
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

    Public Function ListaClientes(CLICOD As String, CLIRAZONSOCIAL As String, CLIRUC As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_CLIENTES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@CLICOD", CLICOD)
                .SelectCommand.Parameters.AddWithValue("@CLIRAZONSOCIAL", CLIRAZONSOCIAL)
                .SelectCommand.Parameters.AddWithValue("@CLIRUC", CLIRUC)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function RptClientes() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_CLIENTES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function



    Public Function BuscaClientes(Codigo As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_CLIENTES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@CLICOD", Codigo)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

End Class
