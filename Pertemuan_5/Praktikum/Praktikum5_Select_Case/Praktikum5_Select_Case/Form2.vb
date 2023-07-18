Public Class Form2
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case txtJudul.Text
            Case "01" : txtKeterangan.Text = "Sejarah Islam"

            Case "02" : txtKeterangan.Text = "Simple Coding"

            Case "03" : txtKeterangan.Text = "Buku Pantun"

            Case "04" : txtKeterangan.Text = "Profesional Coding"

            Case "05" : txtKeterangan.Text = "Buku Panduan Fullstack"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class