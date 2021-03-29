Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsProveedores

    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaProveedores(PRORAZONSOCIAL As String, PRORUC As String, PRODIRECCION As String, PROTELEFONO As String, PROCELULAR As String, PROEMAIL As String, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_PROVEEDORES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@PRORAZONSOCIAL", PRORAZONSOCIAL)
                .Parameters.AddWithValue("@PRORUC", PRORUC)
                .Parameters.AddWithValue("@PRODIRECCION", PRODIRECCION)
                .Parameters.AddWithValue("@PROTELEFONO", PROTELEFONO)
                .Parameters.AddWithValue("@PROCELULAR", PROCELULAR)
                .Parameters.AddWithValue("@PROEMAIL", PROEMAIL)
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

    Public Function ActualizaProveedores(PROCOD As String, PRORAZONSOCIAL As String, PRORUC As String, PRODIRECCION As String, PROTELEFONO As String, PROCELULAR As String, PROEMAIL As String, USUMOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_PROVEEDORES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@PROCOD", PROCOD)
                .Parameters.AddWithValue("@PRORAZONSOCIAL", PRORAZONSOCIAL)
                .Parameters.AddWithValue("@PRORUC", PRORUC)
                .Parameters.AddWithValue("@PRODIRECCION", PRODIRECCION)
                .Parameters.AddWithValue("@PROTELEFONO", PROTELEFONO)
                .Parameters.AddWithValue("@PROCELULAR", PROCELULAR)
                .Parameters.AddWithValue("@PROEMAIL", PROEMAIL)
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


    Public Function EliminaProveedores(PROCOD As String) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_PROVEEDORES", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@PROCOD", PROCOD)
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

    Public Function ListaProveedores(PROCOD As String, PRORAZONSOCIAL As String, PRORUC As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_PROVEEDORES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@PROCOD", PROCOD)
                .SelectCommand.Parameters.AddWithValue("@PRORAZONSOCIAL", PRORAZONSOCIAL)
                .SelectCommand.Parameters.AddWithValue("@PRORUC", PRORUC)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function RptProveedores() As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_RPT_PROVEEDORES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function BuscaProveedores(Codigo As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_PROVEEDORES", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@PROCOD", Codigo)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function



End Class
