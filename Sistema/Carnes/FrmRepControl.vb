Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmRepControl
    Private Sub FrmRepControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub RellenarComboFrigorifico()
        Try
            Dim CFacCab As New ClsUsuario
            Dim DT As New DataTable
            DT = CFacCab.ObtenerTodos.Tables(0)
            With CMBFrigorifico
                .DataSource = DT
                .DisplayMember = "Usuario"
                .ValueMember = "idUsuario"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click


    '    Dim crystalReport As New rptLiquiMalefu ' CrystalReport1 CustomerReport()
    '    Dim dsCustomers As STK_liqui_Subdiario =' Customers = GetData()
    '    crystalReport.SetDataSource(dsCustomers)

    '    Me.CrystalReportViewer1.ReportSource = crystalReport
    '    Me.CrystalReportViewer1.RefreshReport()




    'End Sub





    'End Sub

    'Private Function GetData() As Customers
    '    Dim constr As String = "Data Source=.\Sql2005;Initial Catalog=Northwind;Integrated Security = true"
    '    Using con As New SqlConnection(constr)
    '        Using cmd As New SqlCommand("SELECT TOP 20 * FROM Customers")
    '            Using sda As New SqlDataAdapter()
    '                cmd.Connection = con
    '                sda.SelectCommand = cmd
    '                Using dsCustomers As New Customers()
    '                    sda.Fill(dsCustomers, "DataTable1")
    '                    Return dsCustomers
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Function

End Class