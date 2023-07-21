Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmInputPasien
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dz As OleDbCommand
    Dim dr As OleDbDataReader
    Public str As String

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTanggal.Text = Format(Now, "dd/MM/yyyy | HH:mm:ss")
    End Sub
    Sub clear()
        TxtNoPeserta.Text = ""
        CmbJenisKartu.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        CmbAgama.Text = ""
        CmbKelamin.Text = ""
        TxtNoPeserta.ReadOnly = False
        CmdSimpan.Enabled = True
        CmdEdit.Enabled = False
        CmdHapus.Enabled = False
        TxtNoPeserta.Focus()
    End Sub
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

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TxtNoPeserta.Text = "" Or CmbJenisKartu.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or CmbAgama.Text = "" Or CmbKelamin.Text = "" Then
            MsgBox("Data Pasien Tidak Boleh Ada Yang Kosong!!", vbCritical, "Input Pasien")
            TxtNoPeserta.Focus()
            GoTo err
        End If
        If CmdSimpan.Enabled = True Then
            Dim q As String = "select * from Tb_Pasien where No_Peserta='" & TxtNoPeserta.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE Tb_Pasien set No_Peserta='{0}',Jenis_Kartu='{1}'Nama='{2}',Alamat='{3}'Jenis_Kelamin='{4}',Tanggal_Lahir='{5}'Agama='{6}',Tgl_Daftar='{7}'", _
                                TxtNoPeserta.Text, CmbJenisKartu.Text, TxtNama.Text, TxtAlamat.Text, CmbKelamin.Text, DTDaftar.Text, CmbAgama.Text, DTlahir.Text)
            Else
                q = String.Format("INSERT INTO Tb_Pasien VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", _
                                 TxtNoPeserta.Text, CmbJenisKartu.Text, TxtNama.Text, TxtAlamat.Text, CmbKelamin.Text, DTDaftar.Text, CmbAgama.Text, DTlahir.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("DATA PASIEN TELAH DITAMBAH", vbOKOnly, "Input Pasien")
                clear()
            Catch ex As Exception
                MsgBox("Pasien Dengan No : " & TxtNoPeserta.Text & " Sudah Terdaftar", vbCritical, "User Login")
                clear()
            End Try
        End If
Err:
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
            update = MsgBox("No Peserta Ini Sudah Ada!!!, Apakah Mau Di Edit??", vbOKCancel, "Input Pasien")
            If update = vbCancel Then
                clear()
                GoTo Err
            End If
            If update = vbOK Then
                TxtNoPeserta.Text = dr(0)
                CmbJenisKartu.Text = dr(1)
                TxtNama.Text = dr(2)
                TxtAlamat.Text = dr(3)
                CmbKelamin.Text = dr(4)
                DTlahir.Text = dr(5)
                CmbAgama.Text = dr(6)
                DTDaftar.Text = dr(7)

                TxtNoPeserta.ReadOnly = True
                CmdSimpan.Enabled = False
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                'simpan ke histroy barang
                'simpanhistory()
                '-------------

                conn.Close()
                TxtNoPeserta.Focus()
            End If
        End If
Err:
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        clear()
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        Dim hapus As String
        hapus = MsgBox("Apakah Anda Yakin Menghapus Data Pasien Dengan Nama: " & TxtNama.Text & "", vbOKCancel, "Hapus Pasien")
        If hapus = vbCancel Then
            GoTo Err
        End If
        If hapus = vbOK Then
            Dim q As String = "delete from Tb_Pasien where No_Peserta='" & TxtNoPeserta.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("Data Pasien Telah Dihapus", vbInformation)
                Application.DoEvents()
                Application.DoEvents()
                Application.DoEvents()
                clear()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
Err:
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Dim edit As String
        edit = MsgBox("Apakah Anda Yakin Mengedit Data Pasien Dengan Nama: " & TxtNama.Text & "", vbOKCancel, "Edit Pasien")
        If edit = vbCancel Then
            GoTo Err
        End If
        If edit = vbOK Then
            Try
                Call bukaKoneksi()
                Dim sqlquery As New OleDb.OleDbCommand()
                sqlquery.Connection = conn
                sqlquery.CommandType = CommandType.Text
                sqlquery.CommandText = _
                "Update Tb_Pasien set Jenis_Kartu='" & CmbJenisKartu.Text & "', Nama='" & TxtNama.Text & "', Alamat='" & TxtAlamat.Text & "', Jenis_Kelamin='" & CmbKelamin.Text & "', Tanggal_Lahir='" & DTlahir.Text & "', Agama='" & CmbAgama.Text & "', Tgl_Daftar='" & DTDaftar.Text & "' Where No_Peserta='" & TxtNoPeserta.Text & "'"
                sqlquery.ExecuteNonQuery()
                MsgBox("Data Pasien Sudah Di Update")
                clear()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
Err:
    End Sub

    Private Sub FrmInputPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaKoneksi()
        loadkode("Jenis_Kartu", "Jenis_Kartu", CmbJenisKartu)
        CmbAgama.Items.Add("Islam")
        CmbAgama.Items.Add("Kristen")
        CmbAgama.Items.Add("Hindu")
        CmbAgama.Items.Add("Budha")
        CmbAgama.Items.Add("Katolik")
        CmbKelamin.Items.Add("Pria")
        CmbKelamin.Items.Add("Wanita")
    End Sub

    Private Sub CmdJenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdJenis.Click
        FrmJenisKartu.ShowDialog()
    End Sub

    Private Sub CmdDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDatabase.Click
        FrmDatabasePasien.Show()
        FrmDatabasePasien.LblForm.Text = "Input Pasien"
    End Sub

    Private Sub TxtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNama.TextChanged
        Dim i As Integer = TxtNama.SelectionStart
        TxtNama.Text = StrConv(TxtNama.Text, VbStrConv.ProperCase)
        TxtNama.SelectionStart = i
    End Sub

    Private Sub TxtAlamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAlamat.TextChanged
        Dim i As Integer = TxtAlamat.SelectionStart
        TxtAlamat.Text = StrConv(TxtAlamat.Text, VbStrConv.ProperCase)
        TxtAlamat.SelectionStart = i
    End Sub
End Class