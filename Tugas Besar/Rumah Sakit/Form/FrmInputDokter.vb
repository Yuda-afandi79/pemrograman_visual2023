Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmInputDokter
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dz As OleDbCommand
    Dim dr As OleDbDataReader
    Public str As String
    Sub clear()
        TxtNik.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        CmbBidang.Text = ""
        TxtNoHp.Text = ""
        TxtNik.ReadOnly = False
        CmdSimpan.Enabled = True
        CmdEdit.Enabled = False
        CmdHapus.Enabled = False
        TxtNik.Focus()
    End Sub
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
    Private Sub FrmInputDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilkanlv()
        loadkode("Bidang", "Bidang", CmbBidang)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTanggal.Text = Format(Now, "dd/MM/yyyy | HH:mm:ss")
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If TxtNik.Text = "" Or TxtNama.Text = "" Or TxtAlamat.Text = "" Or CmbBidang.Text = "" Or TxtNoHp.Text = "" Then
            MsgBox("Data Dokter Tidak Boleh Ada Yang Kosong!!", vbCritical, "Input Dokter")
            TxtNik.Focus()
            GoTo err
        End If
        If CmdSimpan.Enabled = True Then
            Dim q As String = "select * from Tb_Dokter where Nik_Dokter='" & TxtNik.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE Tb_Dokter set Nik_Dokter='{0}',Nama_Dokter='{1}'Bidang='{2}',Alamat='{3}'No_Hp='{4}'", _
                                TxtNik.Text, TxtNama.Text, CmbBidang.Text, TxtAlamat.Text, TxtNoHp.Text)
            Else
                q = String.Format("INSERT INTO Tb_Dokter VALUES ('{0}','{1}','{2}','{3}','{4}')", _
                                 TxtNik.Text, TxtNama.Text, CmbBidang.Text, TxtAlamat.Text, TxtNoHp.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("DATA DOKTER TELAH DITAMBAH", vbOKOnly, "Input Dokter")
                tampilkanlv()
                clear()
            Catch ex As Exception
                MsgBox("Dokter Dengan NIK : " & TxtNik.Text & " Sudah Terdaftar", vbCritical, "Data Dokter")
                clear()
            End Try
        End If
Err:
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
            update = MsgBox("NIK Ini Sudah Ada!!!, Apakah Mau Di Edit??", vbOKCancel, "Input Dokter")
            If update = vbCancel Then
                clear()
                GoTo Err
            End If
            If update = vbOK Then
                TxtNik.Text = dr(0)
                TxtNama.Text = dr(1)
                CmbBidang.Text = dr(2)
                TxtAlamat.Text = dr(3)
                TxtNoHp.Text = dr(4)
               

                TxtNik.ReadOnly = True
                CmdSimpan.Enabled = False
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                'simpan ke histroy barang
                'simpanhistory()
                '-------------

                conn.Close()
                TxtNik.Focus()
            End If
        End If
Err:
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        clear()
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        Dim hapus As String
        hapus = MsgBox("Apakah Anda Yakin Menghapus Data Dokter Dengan Nama: " & TxtNama.Text & "", vbOKCancel, "Hapus Dokter")
        If hapus = vbCancel Then
            GoTo Err
        End If
        If hapus = vbOK Then
            Dim q As String = "delete from Tb_Dokter where Nik_Dokter='" & TxtNik.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("Data Dokter Telah Dihapus", vbInformation)
                Application.DoEvents()
                Application.DoEvents()
                Application.DoEvents()
                tampilkanlv()
                clear()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If
Err:
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Dim edit As String
        edit = MsgBox("Apakah Anda Yakin Mengendit Data Dokter Dengan Nama: " & TxtNama.Text & "", vbOKCancel, "Edit Dokter")
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
                "Update Tb_Dokter set Nama_Dokter='" & TxtNama.Text & "', Bidang='" & TxtNama.Text & "', Alamat='" & TxtAlamat.Text & "', No_Hp='" & TxtNoHp.Text & "' Where Nik_Dokter='" & TxtNik.Text & "'"
                sqlquery.ExecuteNonQuery()
                MsgBox("Data Dokter Sudah Di Update")
                tampilkanlv()
                clear()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
Err:
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        Dim sql As String
        bukaKoneksi()
        sql = "select * from Tb_Dokter where Nama_Dokter like '%" & Trim(TxtCari.Text) & "%'"
        dz = New OleDbCommand(sql, conn)
        dr = dz.ExecuteReader
        If dr.HasRows Then
            LV.Items.Clear()
            While dr.Read
                Dim IsiGrid As ListViewItem = LV.Items.Add(dr("Nik_Dokter"))
                IsiGrid.SubItems.Add(dr("Nama_Dokter"))
                IsiGrid.SubItems.Add(dr("Bidang"))
                IsiGrid.SubItems.Add(dr("Alamat"))
                IsiGrid.SubItems.Add(dr("No_Hp"))
  
            End While
        End If
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
                        TxtNik.Text = myString
                        End Select
                        innercounter += 1
                    Next
                End With
                'Me.Dispose()
                '------------------------------------------------


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
                        TxtNik.Text = myString
                End Select
                innercounter += 1
            Next
        End With
        'Me.Dispose()
        '------------------------------------------------


Err:
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

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

    Private Sub TxtNoHp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoHp.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNoHp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNoHp.TextChanged

    End Sub

    Private Sub CmdJenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdJenis.Click
        FrmBidang.ShowDialog()
    End Sub
End Class