Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class FrmReport
    Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                        "Data Source=" & _
                        Application.StartupPath & _
                        "\DB.mdb;")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Dim sqlQRY As String = ""

    Dim reportPath As String = ("Rumah_Sakit.RptKunjungan.rdlc")
    Dim sReportDataSource As New ReportDataSource
    Sub panggil()
        Try

            cn.Open()
            ' MsgBox("connected", MsgBoxStyle.Information)


            'sqlQRY = "SELECT tblUsers.UserID, tblUsers.Username, tblUsers.Password, tblAccessLevel.AccessLevelName, tblUsers.Date," & _
            '   "tblUsers.Time FROM tblAccessLevel INNER JOIN tblUsers ON tblAccessLevel.AccessLevelID = tblUsers.AccessLevelID;"

            sqlQRY = "Select * from Tb_Kunjungan"
            viewreports()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub viewreports()

        ds = New DataSet
        da = New OleDbDataAdapter(sqlQRY, cn)
        da.Fill(ds, "Tb_Kunjungan")
        ReportViewer1.LocalReport.ReportEmbeddedResource = reportPath
        sReportDataSource.Name = "Kunjungan"
        sReportDataSource.Value = ds.Tables(0)
        ReportViewer1.LocalReport.DataSources.Add(sReportDataSource)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub panggil2()
        Dim dsCustomers As Kunjungan = GetData()
        Dim datasource As New ReportDataSource("Kunjungan", dsCustomers.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function GetData() As Kunjungan
        Dim constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                        "Data Source=" & _
                        Application.StartupPath & _
                        "\DB.mdb;"
        Using con As New OleDbConnection(constr)
            Using cmd As New OleDbCommand("SELECT * FROM Tb_Kunjungan")
                Using sda As New OleDbDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dsCustomers As New Kunjungan
                        sda.Fill(dsCustomers, "Tb_Kunjungan")
                        Return dsCustomers
                    End Using
                End Using
            End Using
        End Using
    End Function
    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panggil2()
    End Sub

   
    
End Class