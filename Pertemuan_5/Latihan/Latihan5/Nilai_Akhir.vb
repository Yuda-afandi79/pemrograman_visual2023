Public Class Nilai_Akhir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Val(txtNilaiAkhir.Text) >= 60) Then
            txtKeterangan.Text = "Anda Dinyatakan Lulus"
        Else
            txtKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub
End Class
