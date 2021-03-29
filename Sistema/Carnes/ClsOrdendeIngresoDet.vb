Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class ClsOrdendeIngresoDet

    Dim cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)

    Public Function InsertaOrdIngDet(ORDINGCOD As String, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUREG As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_INSERTA_ORDENDEINGRESODET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ORDINGCOD", ORDINGCOD)
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
 
    Public Function ActualizaOrdIngDet(ORDINGDETCOD As Long, ARTCOD As String, CANTIDAD As Double, PRECIO As Double, TOTAL As Double, USUMOD As String) As String
        Dim retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ACTUALIZA_ORDENDEINGRESODET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ORDINGDETCOD", ORDINGDETCOD)
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


    Public Function EliminaOrdIngDet(ORDINGDETCOD As Long) As String
        Dim Retorno As String = ""
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            Else
                cnx.Open()
            End If
            Dim Cmd As New SqlCommand("SP_ELIMINA_ORDENDEINGRESODET", cnx)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ORDINGDETCOD", ORDINGDETCOD)
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

    Public Function ListaOrdIngDet(ORDINGCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_LISTA_ORDENDEINGRESODET", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ORDINGCOD", ORDINGCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

    Public Function ListaOrdIngDet2(ORDINGDETCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_ORDENDEINGRESODET", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ORDINGDETCOD", ORDINGDETCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function


    Public Function ListaOrIngDetTotales(ORDINGCOD As String) As DataTable
        Dim Dt As New DataTable
        Try
            Dim Sda As New SqlDataAdapter("SP_BUSCA_ORDENDEINGRESODET_TOT", cnx)
            With Sda
                .SelectCommand.CommandType = CommandType.StoredProcedure
                .SelectCommand.Parameters.AddWithValue("@ORDINGCOD", ORDINGCOD)
                .Fill(Dt)
            End With
        Catch ex As SqlException
            Throw ex
        End Try
        Return Dt
    End Function

End Class
