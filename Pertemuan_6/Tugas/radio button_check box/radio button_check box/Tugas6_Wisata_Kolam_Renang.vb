Public Class Tugas6_Wisata_Kolam_Renang
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim TiketMasuk As Decimal
        Dim Member As Decimal
        Dim Total As Decimal

        If rbanak.Checked = True Then
            TiketMasuk = 15000
        ElseIf rbdewasa.Checked = True Then
            TiketMasuk = 20000
        End If

        If cbnonmember.Checked = True Then
            Member = 0
        End If

        If cbmember.Checked = True Then
            Member = (TiketMasuk * 10 / 100)
        End If

        Total = TiketMasuk - Member

        txttotal.Text = Total
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
