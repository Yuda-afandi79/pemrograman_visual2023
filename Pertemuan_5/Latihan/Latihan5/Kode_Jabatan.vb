Public Class Kode_Jabatan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case txtKodeJabatan.Text
            Case "MGR" : txtKeterangan.Text = "Manager"

            Case "SKR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Kode_Jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class