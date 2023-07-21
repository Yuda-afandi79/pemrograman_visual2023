Public Class Form1

  
   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblWaktu.Text = Format(Now, "dd/MM/yyyy | HH:mm:ss")
    End Sub

    Private Sub CmdInputUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInputUser.Click
        If lblUser.Text = "Admin" Then
            FrmUserLogin.ShowDialog()
        Else
            MsgBox("User : " & lblUser.Text & " Tidak Diizinkan Mengakses Ke-Menu Ini", vbCritical, "Admin User")
            CmdInputUser.Focus()
        End If

    End Sub

    Private Sub CmdInputPasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInputPasien.Click
        FrmInputPasien.ShowDialog()
    End Sub

    Private Sub CmdDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDatabase.Click
        FrmDatabasePasien.Show()
    End Sub

    Private Sub CmdKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdKeluar.Click
        Dim Keluar As String
        Keluar = MsgBox("YAKIN MAU KELUAR DARI PROGRAM INI??", vbOKCancel, "Keluar Dari Program")
        If Keluar = vbCancel Then
            GoTo Err
        End If
        If Keluar = vbOK Then
            Me.Hide()
            FrmLoading.Show()
        End If
Err:
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
 

    Private Sub CmdInputDokter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInputDokter.Click
        FrmInputDokter.ShowDialog()
    End Sub

    Private Sub CmdDaftarPasienKePoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDaftarPasienKePoli.Click
        FrmKunjungan.ShowDialog()
    End Sub

    Private Sub CmdLaporan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLaporan.Click
        FrmReport.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub
End Class
