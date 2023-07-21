Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmBidang
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dz As OleDbCommand
    Dim dr As OleDbDataReader
    Public str As String
    Sub loadkode(ByRef stable$, ByRef skey$, ByRef cmb As ComboBox)
        On Error GoTo Err
        'MENAMBAHKAN KODE PADA COMBO
        Dim q As String = "select * from " & stable & " order by " & skey & " asc"
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        cmb.Items.Clear()
        While myread.Read
            cmb.Items.Add(myread.GetString(0))
        End While
Err:
    End Sub
    Private Sub FrmBidang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'untuk load di cmb input barang
        bukaKoneksi()
        loadkode("Bidang", "Bidang", CmbBidang)
        'loadkode("MerekBarang", "Merek_Barang", CmbMerek)
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If CmbBidang.Text = "" Then
            MsgBox("BIDANG MASIH KOSONG", vbCritical, "Bidang Dokter")
            CmbBidang.Focus()
            GoTo err
        End If
        Dim q As String = "select * from Bidang where Bidang='" & CmbBidang.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.HasRows Then
            q = String.Format("UPDATE Bidang set Bidang='{0}'", CmbBidang.Text)
        Else
            q = String.Format("INSERT INTO Bidang VALUES ('{0}')", _
                          CmbBidang.Text)
        End If
        myread.Close()
        bukaKoneksi()
        mycmd = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Bidang Dokter Sudah Ditambah", vbInformation)
            CmbBidang.Text = ""
            CmbBidang.Items.Clear()
            FrmInputDokter.CmbBidang.Items.Clear()
            'untuk load di cmb input barang
            loadkode("Bidang", "Bidang", CmbBidang)
            FrmInputDokter.loadkode("Bidang", "Bidang", FrmInputDokter.CmbBidang)
        Catch ex As Exception
            MsgBox("Bidang Dokter Sudah Ada")
        End Try
Err:
        CmbBidang.Text = ""
        CmbBidang.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CmbBidang.Text = "" Then
            GoTo Err
        End If
        Dim q As String = "delete from Bidang where Bidang='" & CmbBidang.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("BIDANG DOKTER DIHAPUS", vbInformation)
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()


            CmbBidang.Items.Clear()
            FrmInputPasien.CmbJenisKartu.Items.Clear()
            'untuk load di cmb input barang
            loadkode("Bidang", "Bidang", CmbBidang)
            FrmInputDokter.loadkode("Bidang", "Bidang", FrmInputDokter.CmbBidang)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        CmbBidang.Text = ""
        CmbBidang.Focus()
Err:
    End Sub

    Private Sub CmbBidang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbBidang.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbBidang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBidang.SelectedIndexChanged

    End Sub

    Private Sub CmbBidang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBidang.TextChanged
       
    End Sub
End Class