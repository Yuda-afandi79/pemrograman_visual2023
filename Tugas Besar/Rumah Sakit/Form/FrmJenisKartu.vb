Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmJenisKartu
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
    Private Sub FrmJenisKartu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'untuk load di cmb input barang
        bukaKoneksi()
        loadkode("Jenis_Kartu", "Jenis_Kartu", CmbJenisKartu)
        'loadkode("MerekBarang", "Merek_Barang", CmbMerek)
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If CmbJenisKartu.Text = "" Then
            MsgBox("JENIS KARTU MASIH KOSONG", vbCritical, "Jenis Kartu")
            CmbJenisKartu.Focus()
            GoTo err
        End If
        Dim q As String = "select * from Jenis_Kartu where Jenis_Kartu='" & CmbJenisKartu.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.HasRows Then
            q = String.Format("UPDATE Jenis_Kartu set Jenis_Kartu='{0}'", CmbJenisKartu.Text)
        Else
            q = String.Format("INSERT INTO Jenis_Kartu VALUES ('{0}')", _
                          CmbJenisKartu.Text)
        End If
        myread.Close()
        bukaKoneksi()
        mycmd = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("Jenis Kartu Sudah Ditambah", vbInformation)
            CmbJenisKartu.Text = ""
            CmbJenisKartu.Items.Clear()
            FrmInputPasien.CmbJenisKartu.Items.Clear()
            'untuk load di cmb input barang
            loadkode("Jenis_Kartu", "Jenis_Kartu", CmbJenisKartu)
            FrmInputPasien.loadkode("Jenis_Kartu", "Jenis_Kartu", FrmInputPasien.CmbJenisKartu)
        Catch ex As Exception
            MsgBox("Jenis Barang Sudah Ada")
        End Try
Err:
        CmbJenisKartu.Text = ""
        CmbJenisKartu.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CmbJenisKartu.Text = "" Then
            GoTo Err
        End If
        Dim q As String = "delete from Jenis_Kartu where Jenis_Kartu='" & CmbJenisKartu.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("JENIS KARTU DIHAPUS", vbInformation)
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()


            CmbJenisKartu.Items.Clear()
            FrmInputPasien.CmbJenisKartu.Items.Clear()
            'untuk load di cmb input barang
            loadkode("Jenis_Kartu", "Jenis_Kartu", CmbJenisKartu)
            FrmInputPasien.loadkode("Jenis_Kartu", "Jenis_Kartu", FrmInputPasien.CmbJenisKartu)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        CmbJenisKartu.Text = ""
        CmbJenisKartu.Focus()
Err:
    End Sub

    Private Sub CmbJenisKartu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbJenisKartu.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbJenisKartu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbJenisKartu.SelectedIndexChanged

    End Sub
End Class