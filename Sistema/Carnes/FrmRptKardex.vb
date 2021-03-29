Imports Microsoft.Reporting.WinForms
Public Class FrmRptKardex

    Private Sub BuscaArticuloDesde(Codigo As String)
        Try
            Dim CArticulos As New ClsArticulos
            Dim DT As New DataTable
            DT = CArticulos.BuscaArticulos(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodArtDesde.Text = DT.Rows(0).Item("ARTCOD").ToString()
                txtDesArtDesde.Text = DT.Rows(0).Item("ARTDES").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BuscaArticuloHasta(Codigo As String)
        Try
            Dim CArticulos As New ClsArticulos
            Dim DT As New DataTable
            DT = CArticulos.BuscaArticulos(Codigo)
            If DT.Rows.Count > 0 Then
                TxtCodArtHasta.Text = DT.Rows(0).Item("ARTCOD").ToString()
                txtDesArtHasta.Text = DT.Rows(0).Item("ARTDES").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FrmRptKardex_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ENVIAR_ENTER(e.KeyChar)
    End Sub

    Private Sub FrmRptKardex_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmRptKardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub BtnSALIR_Click(sender As Object, e As EventArgs) Handles BtnSALIR.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        DtpHasta.Value = Now
        TxtCodArtDesde.Clear()
        TxtCodArtHasta.Clear()
        txtDesArtDesde.Clear()
        txtDesArtHasta.Clear()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If TxtCodArtDesde.Text = "" Or TxtCodArtHasta.Text = "" Then
            MessageBox.Show("Debe ingresar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim FRM As New FrmReportes
        Dim DT As New DataTable
        Dim RD As New ReportDataSource()
        Dim ClsProc As New ClsArticulos

        Try
            FRM.MdiParent = Me.MdiParent
            FRM.Text = "REPORTE DE KARDEX"
            FRM.ReportViewer1.LocalReport.ReportEmbeddedResource = "Carnes.RptKardex.rdlc"
            DT = ClsProc.RptKardex(DtpHasta.Value, TxtCodArtDesde.Text, TxtCodArtHasta.Text)
            RD.Value = DT
            RD.Name = "DataSet1"

            FRM.ReportViewer1.LocalReport.DataSources.Clear()
            FRM.ReportViewer1.LocalReport.DataSources.Add(RD)
            FRM.ReportViewer1.LocalReport.Refresh()

            Dim PRM1 As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            PRM1.Add(New Microsoft.Reporting.WinForms.ReportParameter("AL", "Kardex al " + DtpHasta.Value.ToShortDateString, False))
            FRM.ReportViewer1.LocalReport.SetParameters(PRM1)

            Dim PRM2 As New List(Of Microsoft.Reporting.WinForms.ReportParameter)
            PRM2.Add(New Microsoft.Reporting.WinForms.ReportParameter("ARTS", "Del articulo " + TxtCodArtDesde.Text + " al articulo " + TxtCodArtHasta.Text, False))
            FRM.ReportViewer1.LocalReport.SetParameters(PRM2)

            FRM.ReportViewer1.RefreshReport()

            FRM.Show()
        Catch EX As Exception
            MessageBox.Show(EX.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BtnBuscarArticuloDesde_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticuloDesde.Click
        Dim FRM As New FrmBuscarArticulos
        Dim ARTCOD As String
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                ARTCOD = .DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
                BuscaArticuloDesde(ARTCOD)
            End If
        End With
    End Sub

    Private Sub BtnBuscarArticuloHasta_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticuloHasta.Click
        Dim FRM As New FrmBuscarArticulos
        Dim ARTCOD As String
        With FRM
            .ShowDialog()
            If .Fila >= 0 Then
                ARTCOD = .DataGridView1.Rows(.DataGridView1.CurrentRow.Index).Cells(0).Value.ToString()
                BuscaArticuloHasta(ARTCOD)
            End If
        End With
    End Sub
End Class