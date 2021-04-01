Imports Microsoft.Reporting.WinForms

Public Class FrmPrincipal

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Desea Salir del Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sistema de Ventas     Usuario: " + USUNOM + "     Base de datos: " + USUDB

        'AQUI SE BLOQUEAN MENUS DEL SISTEMA 
        If USUTIPO = "VENDEDOR" Then
            RegistroDeProveedoresToolStripMenuItem.Visible = False
            RegistroDeFamiliarToolStripMenuItem.Visible = False
            RegistroDeSubFamiliasToolStripMenuItem.Visible = False
            RegistroDeMarcasToolStripMenuItem.Visible = False
            RegistroDeArticulosToolStripMenuItem.Visible = False
            ImpuestoToolStripMenuItem.Visible = False
            SeriesToolStripMenuItem.Visible = False
            OrdenDeIngresoToolStripMenuItem.Visible = False
            ReporteDeVentasToolStripMenuItem.Visible = False
            ReporteDeClientesToolStripMenuItem.Visible = False
            ReporteDeProveedoresToolStripMenuItem.Visible = False
            ReporteDeArticulosToolStripMenuItem.Visible = False
            ReporteDeFamiliasToolStripMenuItem.Visible = False
            ReporteDeSubFamiliasToolStripMenuItem.Visible = False
            ReporteDeMarcasToolStripMenuItem.Visible = False
            RegistroDeUsuariosToolStripMenuItem.Visible = False
            ReporteDeIngresosToolStripMenuItem.Visible = False
            ReporteDeKardexToolStripMenuItem.Visible = False
        End If


    End Sub

    Private Sub RegistroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeClientesToolStripMenuItem.Click
        Dim FRM As New FrmClientes
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeProveedoresToolStripMenuItem.Click
        Dim FRM As New FrmProveedores_bak
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeFamiliarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeFamiliarToolStripMenuItem.Click
        Dim FRM As New FrmFamilias
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeSubFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeSubFamiliasToolStripMenuItem.Click
        Dim FRM As New FrmSubFamilias
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeMarcasToolStripMenuItem.Click
        Dim FRM As New FrmMarcas
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeArticulosToolStripMenuItem.Click
        Dim FRM As New FrmArticulos
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ImpuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpuestoToolStripMenuItem.Click
        Dim FRM As New FrmImpuesto
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub SeriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeriesToolStripMenuItem.Click
        Dim FRM As New FrmSeries
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub OrdenDeIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeIngresoToolStripMenuItem.Click
        Dim FRM As New FrmOrdendeIngreso
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Dim FRM As New FrmFacturacion
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub CotizacióToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CotizacióToolStripMenuItem.Click
        Dim FRM As New FrmCotizacion
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub CambiarPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarPasswordToolStripMenuItem.Click
        Dim FRM As New FrmCambiarPassword
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        Dim FRM As New FrmUsuarios
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ReporteDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeClientesToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsClientes

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE CLIENTES"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptClientes.rdlc"
            DT = ClsProc.RptClientes()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeProveedoresToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsProveedores

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE PROVEEDORES"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptProveedores.rdlc"
            DT = ClsProc.RptProveedores()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeArticulosToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsArticulos

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE ARTICULOS"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptArticulos.rdlc"
            DT = ClsProc.RptArticulos()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeFamiliasToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsFamilias

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE FAMILIAS"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptFamilias.rdlc"
            DT = ClsProc.RptFamilias()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeSubFamiliasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeSubFamiliasToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsSubFamilias

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE SUBFAMILIAS"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptSubFamilias.rdlc"
            DT = ClsProc.RptSubFamilias()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeMarcasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeMarcasToolStripMenuItem.Click
        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsMarcas

        Try
            FRM.MdiParent = Me
            FRM.Text = "REPORTE DE MARCAS"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptMarcas.rdlc"
            DT = ClsProc.RptMarcas()
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()
            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReporteDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeVentasToolStripMenuItem.Click
        Dim FRM As New FrmRptVentas
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ReporteDeIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeIngresosToolStripMenuItem.Click
        Dim FRM As New FrmRptIngresos
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ReporteDeKardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeKardexToolStripMenuItem.Click
        Dim FRM As New FrmRptKardex
        FRM.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click

        Dim FRM As New FrmProveedores
        FRM.MdiParent = Me
        FRM.Show()

    End Sub
End Class