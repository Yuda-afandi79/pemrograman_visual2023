Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmDatabasePasien
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
        cc = " Select count(*) from Tb_Pasien "
        dz = New OleDb.OleDbCommand(cc, conn)
        Dim rs As Integer

        rs = dz.ExecuteScalar

        LblJumlahData.Text = rs
    End Sub
    Sub GW()
        Dim i As Integer

        For i = 0 To LV.Items.Count - 2 Step 2
            LV.Items(i + 1).BackColor = Drawing.Color.DarkTurquoise
            LV.Items(i).BackColor = Drawing.Color.DodgerBlue
        Next i

        If (LV.Items.Count And 1) <> 0 Then LV.Items(i).BackColor = Drawing.Color.DodgerBlue
    End Sub
    Sub tampilkanlv()
        'listview Tampil
        LV.Items.Clear()
        koneksiSQL.Close()
        koneksiSQL.Open()
        perintahSQL.Connection = koneksiSQL
        perintahSQL.CommandType = CommandType.Text
        perintahSQL.CommandText = "Select * From Tb_Pasien order by No_Peserta"
        bacadataSQL = perintahSQL.ExecuteReader
        While bacadataSQL.Read
            Dim ls1grid As ListViewItem
            ls1grid = LV.Items.Add(bacadataSQL("No_peserta"))
            ls1grid.SubItems.Add(bacadataSQL("Jenis_Kartu")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Nama")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Alamat")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Jenis_Kelamin")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Tanggal_Lahir")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Agama")).ToString()
            ls1grid.SubItems.Add(bacadataSQL("Tgl_Daftar")).ToString()
            GW()
            hitungrow()
        End While
        koneksiSQL.Close()
        '--------------------------------------------------------
    End Sub
    Private Sub FrmDatabasePasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilkanlv()
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        If LblForm.Text = "FormKunjungan" Then
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
                            FrmKunjungan.TxtNoPeserta.Text = myString
                    End Select
                    innercounter += 1
                Next
            End With
            'Me.Dispose()
            '------------------------------------------------
            Me.Dispose()
        End If

        '------------------------------------------
        If LblForm.Text = "Input Pasien" Then
            'menampilkan item data ke textbox
            Dim nemu As String
            nemu = MsgBox("Data Pasien Ini Mau Di Transfer Ke Form Input Pasien??", vbOKCancel, "Database Pasien")
            If nemu = vbCancel Then
                TxtCari.Focus()
                GoTo Err
            End If
            If nemu = vbOK Then
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
                                FrmInputPasien.TxtNoPeserta.Text = myString
                        End Select
                        innercounter += 1
                    Next
                End With
                'Me.Dispose()
                '------------------------------------------------
                Me.Dispose()
            End If
Err:
        End If
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        If LblForm.Text = "FormKunjungan" Then
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
                            FrmKunjungan.TxtNoPeserta.Text = myString
                    End Select
                    innercounter += 1
                Next
            End With
            'Me.Dispose()
            '------------------------------------------------
            Me.Dispose()
        End If

        '------------------------------------------
        If LblForm.Text = "Input Pasien" Then
            'menampilkan item data ke textbox
            Dim nemu As String
            nemu = MsgBox("Data Pasien Ini Mau Di Transfer Ke Form Input Pasien??", vbOKCancel, "Database Pasien")
            If nemu = vbCancel Then
                TxtCari.Focus()
                GoTo Err
            End If
            If nemu = vbOK Then
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
                                FrmInputPasien.TxtNoPeserta.Text = myString
                        End Select
                        innercounter += 1
                    Next
                End With
                'Me.Dispose()
                '------------------------------------------------
                Me.Dispose()
            End If
        End If
Err:
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        Dim sql As String
        bukaKoneksi()
        sql = "select * from Tb_pasien where Nama like '%" & Trim(TxtCari.Text) & "%'"
        dz = New OleDbCommand(sql, conn)
        dr = dz.ExecuteReader
        If dr.HasRows Then
            LV.Items.Clear()
            While dr.Read
                Dim IsiGrid As ListViewItem = LV.Items.Add(dr("No_Peserta"))
                IsiGrid.SubItems.Add(dr("Jenis_Kartu"))
                IsiGrid.SubItems.Add(dr("Nama"))
                IsiGrid.SubItems.Add(dr("Alamat"))
                IsiGrid.SubItems.Add(dr("Jenis_Kelamin"))
                IsiGrid.SubItems.Add(dr("Tanggal_Lahir"))
                IsiGrid.SubItems.Add(dr("Agama"))
                IsiGrid.SubItems.Add(dr("Tgl_Daftar"))
                GW()
            End While
        End If
    End Sub
End Class