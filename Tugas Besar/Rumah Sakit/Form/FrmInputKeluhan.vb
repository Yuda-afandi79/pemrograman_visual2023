Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmInputKeluhan
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
    Sub TampilkanLV()
        'listview Tampil
        LV.Items.Clear()
        koneksiSQL.Close()
        koneksiSQL.Open()
        perintahSQL.Connection = koneksiSQL
        perintahSQL.CommandType = CommandType.Text
        perintahSQL.CommandText = "Select * From Tb_Keluhan order by Kode_Penyakit"
        bacadataSQL = perintahSQL.ExecuteReader
        While bacadataSQL.Read
            Dim ls1grid As ListViewItem
            ls1grid = LV.Items.Add(bacadataSQL("Kode_Penyakit"))
            ls1grid.SubItems.Add(bacadataSQL("Keluhan")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("Alamat")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("Kota")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("No_Tlp")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("No_Hp")).ToString()
        End While
        koneksiSQL.Close()
        '--------------------------------------------------------
    End Sub
    Private Sub FrmInputKeluhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilkanLV()
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Penyakit Masih Kosong!!!!")
            TxtKode.Focus()
            GoTo err
        End If
        If TxtKeluhan.Text = "" Then
            MsgBox("Keluhan Masih Kosong!!!!")
            TxtKeluhan.Focus()
            GoTo err
        End If
        If CmdSimpan.Enabled = True Then
            Dim q As String = "select * from Tb_Keluhan where Kode_Penyakit='" & TxtKode.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE Tb_Penyakit set KodePenyakit='{0}',Keluhan='{1}'", TxtKode.Text, TxtKeluhan.Text)
            Else
                q = String.Format("INSERT INTO Tb_Keluhan VALUES ('{0}','{1}')", _
                             TxtKode.Text, TxtKeluhan.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("KELUHAN TELAH DITAMBAH", vbOKOnly, "Input Keluhan")
                TampilkanLV()
                TxtKode.Text = ""
                TxtKeluhan.Text = ""
                CmdEdit.Enabled = False
                CmdHapus.Enabled = False
                TxtKode.Focus()
                FrmKunjungan.loadkode("Tb_Keluhan", "Keluhan", FrmKunjungan.CmbKeluhan)
                ' FrmKunjungan.loadkode("Tb_Diagnosa", "Diagnosa", FrmKunjungan.CmbDiagnosa)
            Catch ex As Exception
                MsgBox("Kode Keluhan : " & TxtKode.Text & " Sudah Ada", vbCritical, "Input Keluhan")
                TxtKode.Text = ""
                TxtKeluhan.Text = ""
                TxtKode.Focus()
            End Try
        End If
Err:
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Dim q As String = "delete from Tb_Keluhan where Kode_Penyakit='" & TxtKode.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        If CmdSimpan.Enabled = True Then
            bukaKoneksi()
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE Tb_Keluhan set Kode_Penyakit='{0}',Keluhan='{1}'", TxtKode.Text, TxtKeluhan.Text)
            Else
                q = String.Format("INSERT INTO Tb_Keluhan VALUES ('{0}','{1}')", _
                             TxtKode.Text, TxtKeluhan.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("KELUHAN TELAH DIEDIT", vbOKOnly, "Input Keluhan")
                TampilkanLV()
                TxtKode.Text = ""
                TxtKeluhan.Text = ""
                TxtKode.Focus()
                CmdEdit.Enabled = False
                CmdHapus.Enabled = False
                TxtKode.ReadOnly = False
                TxtKode.Focus()
                FrmKunjungan.loadkode("Tb_Keluhan", "Keluhan", FrmKunjungan.CmbKeluhan)
                ' FrmKunjungan.loadkode("Tb_Diagnosa", "Diagnosa", FrmKunjungan.CmbDiagnosa)
            Catch ex As Exception
                MsgBox("Kode Keluhan : " & TxtKode.Text & " Sudah Ada", vbCritical, "Input Keluhan")
                TxtKode.Text = ""
                TxtKeluhan.Text = ""
                TxtKode.Focus()
            End Try
        End If
Err:
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        'menampilkan item data ke textbox
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
                        TxtKode.Text = myString
                    Case 1
                        TxtKeluhan.Text = myString
                End Select
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                TxtKode.ReadOnly = True
                innercounter += 1
            Next
        End With
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        'menampilkan item data ke textbox
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
                        TxtKode.Text = myString
                    Case 1
                        TxtKeluhan.Text = myString
                End Select
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                TxtKode.ReadOnly = True
                innercounter += 1
            Next
        End With
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
       
        Dim q As String = "delete from Tb_Keluhan where Kode_Penyakit='" & TxtKode.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Keluhan Telah DiHapus", vbInformation)
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()
            TampilkanLV()
            TxtKode.Text = ""
            TxtKeluhan.Text = ""
            TxtKode.Focus()
            CmdEdit.Enabled = False
            CmdHapus.Enabled = False
            TxtKode.ReadOnly = False
            FrmKunjungan.loadkode("Tb_Keluhan", "Keluhan", FrmKunjungan.CmbKeluhan)
            'FrmKunjungan.loadkode("Tb_Diagnosa", "Diagnosa", FrmKunjungan.CmbDiagnosa)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
Err:
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        TxtKode.Text = ""
        TxtKeluhan.Text = ""
        CmdSimpan.Enabled = True
        CmdEdit.Enabled = False
        CmdHapus.Enabled = False
        TxtKode.ReadOnly = False
        TxtKode.Focus()
    End Sub

    Private Sub TxtKeluhan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtKeluhan.TextChanged
        Dim i As Integer = TxtKeluhan.SelectionStart
        TxtKeluhan.Text = StrConv(TxtKeluhan.Text, VbStrConv.ProperCase)
        TxtKeluhan.SelectionStart = i
    End Sub
End Class