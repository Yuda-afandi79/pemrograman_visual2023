Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmDatabaseDokter
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dz As OleDbCommand
    Dim dr As OleDbDataReader
    Public str As String
    'Tampilkan Listview
    Public koneksiSQL As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                        "Data Source=" & _
                        Application.StartupPath & _
                        "\DB.mdb;")
    Public perintahSQL As New OleDbCommand
    Public bacadataSQL As OleDbDataReader
    Dim MyListText(10) As String
    Dim MyListItem As ListViewItem
    '---------------
    Sub hitungrow()

        Call bukaKoneksi()
        Dim cc As String
        cc = " Select count(*) from Tb_Dokter "
        dz = New OleDb.OleDbCommand(cc, conn)
        Dim rs As Integer

        rs = dz.ExecuteScalar

        LblJumlahData.Text = rs
    End Sub
    Sub tampilkanlv()
        'listview Tampil
        LV.Items.Clear()
        koneksiSQL.Close()
        koneksiSQL.Open()
        perintahSQL.Connection = koneksiSQL
        perintahSQL.CommandType = CommandType.Text
        perintahSQL.CommandText = "Select * From Tb_Dokter order by Nik_Dokter"
        bacadataSQL = perintahSQL.ExecuteReader
        While bacadataSQL.Read
            Dim ls1grid As ListViewItem
            ls1grid = LV.Items.Add(bacadataSQL("Nik_Dokter"))
            ls1grid.SubItems.Add(bacadataSQL("Nama_Dokter")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Bidang")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Alamat")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("No_Hp")).ToString()


            hitungrow()
        End While
        koneksiSQL.Close()
        '--------------------------------------------------------
    End Sub
    Private Sub FrmDatabaseDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilkanlv()
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        With Me.LV
            Dim i As Integer
            For Each item As ListViewItem In LV.SelectedItems
                i = item.Index
            Next

            Dim innercounter As Integer = 0
            For Each subItem As ListViewItem.ListViewSubItem In LV.Items(i).SubItems
                Dim myString As String = LV.Items(i).SubItems(innercounter).Text
                Select Case innercounter
                    Case 0
                        FrmKunjungan.TxtNik.Text = myString
                End Select
                innercounter += 1
            Next
        End With
        'Me.Dispose()
        '------------------------------------------------
        FrmKunjungan.TxtNik.Focus()
        Me.Dispose()

Err:
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        With Me.LV
            Dim i As Integer
            For Each item As ListViewItem In LV.SelectedItems
                i = item.Index
            Next

            Dim innercounter As Integer = 0
            For Each subItem As ListViewItem.ListViewSubItem In LV.Items(i).SubItems
                Dim myString As String = LV.Items(i).SubItems(innercounter).Text
                Select Case innercounter
                    Case 0
                        FrmKunjungan.TxtNik.Text = myString
                End Select
                innercounter += 1
            Next
        End With
        'Me.Dispose()
        '------------------------------------------------
        FrmKunjungan.TxtNik.Focus()
        Me.Dispose()

Err:
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class