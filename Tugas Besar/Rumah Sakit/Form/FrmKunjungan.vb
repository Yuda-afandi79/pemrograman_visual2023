Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmKunjungan
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
    Sub clear()
        TxtNoPeserta.Text = ""
        TxtNama.Text = ""
        CmbJenisKartu.Text = ""
        TxtKeluhan.Text = ""
        TxtDiagnosa.Text = ""
        CmbKeluhan.Text = ""
        CmbDiagnosa.Text = ""
        TxtNik.Text = ""
        TxtNoPeserta.ReadOnly = False
        TxtNik.ReadOnly = False
        CmdSimpan.Enabled = False
       
        TxtNoPeserta.Focus()
    End Sub
    Private Sub FrmKunjungan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'untuk load di cmb input barang
        bukaKoneksi()
        loadkode("Tb_Keluhan", "Keluhan", CmbKeluhan)
        loadkode("Tb_Diagnosa", "Diagnosa", CmbDiagnosa)

        'loadkode("MerekBarang", "Merek_Barang", CmbMerek)
    End Sub

    Private Sub CmbKeluhan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKeluhan.SelectedIndexChanged
      
    End Sub

    Private Sub CmbKeluhan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbKeluhan.TextChanged

        If CmbKeluhan.Text = "" Then
            clear()
            GoTo Err
        End If
        ' If e.KeyChar = ChrW(13) Then
        bukaKoneksi()
        'Conn.Open()
        Dim update As String
        str = "select * from Tb_Keluhan where Kode_Penyakit = '" & CmbKeluhan.Text & "'"
        dz = New OleDbCommand(str, conn)
        dr = dz.ExecuteReader()
        If dr.Read Then
            update = MsgBox("Diagnosa Ditemukan, Apakah Diagnosa Ini Benar?", vbOKCancel, "Pemeriksaan")
            If update = vbCancel Then
                clear()
                GoTo Err
            End If
            If update = vbOK Then
                'CmbDiagnosa.Text = dr(0)
                TxtKeluhan.Text = dr(1)
                CmbDiagnosa.Text = CmbKeluhan.Text
                'simpan ke histroy barang
                'simpanhistory()
                '-------------

                conn.Close()
            End If
        End If
Err:
    End Sub

    Private Sub CmbDiagnosa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDiagnosa.SelectedIndexChanged

    End Sub

    Private Sub CmbDiagnosa_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDiagnosa.TextChanged
       
        bukaKoneksi()
        'Conn.Open()

        str = "select * from Tb_Diagnosa where Kode_Penyakit = '" & CmbDiagnosa.Text & "'"
        dz = New OleDbCommand(str, conn)
        dr = dz.ExecuteReader()
        If dr.Read Then
            'CmbDiagnosa.Text = dr(0)
            TxtDiagnosa.Text = dr(1)
            'simpan ke histroy barang
            'simpanhistory()
            '-------------

            conn.Close()
        End If
Err:
    End Sub

    Private Sub CmdKeluhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdKeluhan.Click
        FrmInputKeluhan.Show()
    End Sub

    Private Sub CmdDiagnosa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDiagnosa.Click
        FrmInputDiagnosa.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTanggal.Text = Format(Now, "dd/MM/yyyy | HH:mm:ss")
    End Sub

    Private Sub TxtNik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNik.TextChanged
        If TxtNik.Text = "" Then
            clear()
            GoTo Err
        End If
        ' If e.KeyChar = ChrW(13) Then
        bukaKoneksi()
        'Conn.Open()
        Dim update As String
        str = "select * from Tb_Dokter where Nik_Dokter = '" & TxtNik.Text & "'"
        dz = New OleDbCommand(str, conn)
        dr = dz.ExecuteReader()
        If dr.Read Then
            update = MsgBox("NIK Dokter Ditemukan", vbOKOnly, "Data Dokter")
            If update = vbCancel Then
                clear()
                GoTo Err
            End If
            If update = vbOK Then
                TxtNik.Text = dr(0)
               
                TxtNik.ReadOnly = True
                CmdSimpan.Enabled = True
                'simpan ke histroy barang
                'simpanhistory()
                '-------------

                conn.Close()
                TxtNik.Focus()
            End If
        End If
Err:
    End Sub

    Private Sub CmdCariDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCariDokter.Click
        FrmDatabaseDokter.Show()
    End Sub

    Private Sub TxtNoPeserta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNoPeserta.TextChanged
        If TxtNoPeserta.Text = "" Then
            clear()
            GoTo Err
        End If
        ' If e.KeyChar = ChrW(13) Then
        bukaKoneksi()
        'Conn.Open()
        Dim update As String
        str = "select * from Tb_Pasien where No_Peserta = '" & TxtNoPeserta.Text & "'"
        dz = New OleDbCommand(str, conn)
        dr = dz.ExecuteReader()
        If dr.Read Then
            update = MsgBox("No Peserta Ditemukan", vbOKOnly, "Data Pasien")
            If update = vbCancel Then
                clear()
                GoTo Err
            End If
            If update = vbOK Then
                TxtNoPeserta.Text = dr(0)
                CmbJenisKartu.Text = dr(1)
                TxtNama.Text = dr(2)
               
                TxtNoPeserta.ReadOnly = True
                'simpan ke histroy barang
                'simpanhistory()
                '-------------

                conn.Close()
                TxtNoPeserta.Focus()
            End If
        End If
Err:
    End Sub

    Private Sub CmdCariPeserta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCariPeserta.Click
        FrmDatabasePasien.Show()
        FrmDatabasePasien.LblForm.Text = "FormKunjungan"
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        clear()
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TxtNoPeserta.Text = "" Or CmbJenisKartu.Text = "" Or TxtNama.Text = "" Or TxtDiagnosa.Text = "" Or TxtKeluhan.Text = "" Or TxtNik.Text = "" Then
            MsgBox("DATA MEDICAL CHEKUP TIDAK ADA YANG BOLEH KOSONG!!", vbCritical, "Input Medical")
            TxtNoPeserta.Focus()
            GoTo err
        End If
        If CmdSimpan.Enabled = True Then
            Dim q As String = "select * from Tb_Kunjungan where ID='" & LblTanggal.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE Tb_Kunjungan set No_Peserta='{0}',Jenis_Kartu='{1}'Nama_Pasien='{2}',Keluhan='{3}'Hasil_Diagnosa='{4}',Nik_Dokter='{5}'Tgl_Kunjungan='{6}'ID='{7}'", _
                                TxtNoPeserta.Text, CmbJenisKartu.Text, TxtNama.Text, TxtKeluhan.Text, TxtDiagnosa.Text, TxtNik.Text, DTKunjungan.Text, LblTanggal.Text)
            Else
                q = String.Format("INSERT INTO Tb_Kunjungan VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", _
                                 TxtNoPeserta.Text, CmbJenisKartu.Text, TxtNama.Text, TxtKeluhan.Text, TxtDiagnosa.Text, TxtNik.Text, DTKunjungan.Text, LblTanggal.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("DATA REKAM MEDIC PASIEN TELAH DITAMBAH", vbOKOnly, "Input Medical")
                clear()
            Catch ex As Exception
                MsgBox("Pasien Dengan No : " & TxtNoPeserta.Text & " Sudah Terdaftar", vbCritical, "DATA MEDICAL ERORR")
                clear()
            End Try
        End If
Err:
    End Sub
End Class