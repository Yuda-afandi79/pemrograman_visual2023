Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case txtKode.Text
            Case "001" : txtKeterangan.Text = "Samsung"

            Case "002" : txtKeterangan.Text = "Realme 5 pro"

            Case "003" : txtKeterangan.Text = "Vivo"

            Case "004" : txtKeterangan.Text = "Oppo"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub
End Class
