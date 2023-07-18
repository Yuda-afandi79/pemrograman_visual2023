Public Class Masa_Kerja
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Anda mendapat bonus berupa motor"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Anda mendapat bonus sepeda gunung"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Anda mendapat bonus cincin emas 5gr"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat voucher belanja Rp.500rb"

        Else
            txtKeterangan.Text = "Maaf anda belum layak dapat bonus"
        End If
    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub
End Class