Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksinya()
        cmd = New OdbcCommand("select distinct tanggal as tgl from penjualan order by tanggal asc", conn)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Add("SEMUA")
        ComboBox1.SelectedIndex = 0
        While dr.Read()
            ComboBox1.Items.Add(dr.Item("tgl"))
        End While

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksinya()
        If ComboBox1.SelectedIndex = 0 Then
            CrystalReportViewer1.ReportSource = Nothing
            da = New OdbcDataAdapter("select * from penjualan order by tanggal asc", conn)
            ds = New DataSet()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Dim ReportKu As New ReportDocument
            ReportKu.Load(Application.StartupPath & "\laporan\CrystalReport2.rpt")
            CrystalReportViewer1.ReportSource = ReportKu
            CrystalReportViewer1.Refresh()
        Else
            da = New OdbcDataAdapter("select * from penjualan Where tanggal = '" & ComboBox1.Text & "'", conn)
            ds = New DataSet()
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            Dim ReportKu As New ReportDocument
            ReportKu.Load(Application.StartupPath & "\laporan\CrystalReport1.rpt")
            ReportKu.SetParameterValue("tgl", ComboBox1.Text)
            CrystalReportViewer1.ReportSource = ReportKu
            CrystalReportViewer1.Refresh()
        End If

    End Sub
End Class
