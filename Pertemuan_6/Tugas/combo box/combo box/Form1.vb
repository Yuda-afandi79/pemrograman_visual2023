Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbprodi.Items.Clear()
        cmbprodi.Items.Add("Manajemen")
        cmbprodi.Items.Add("Teknik Informatika")
        cmbprodi.Items.Add("Ilmu Komunikasi")
        cmbprodi.Items.Add("PGSD")
        cmbprodi.Items.Add("Hukum")
        cmbprodi.Items.Add("Gizi")
    End Sub

    Private Sub cmbprodi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbprodi.SelectedIndexChanged
        If cmbprodi.Text = "Manajemen" Then
            txtbiaya.Text = "9000000"
            txtbayar.Clear()
            txttagihan.Clear()
        ElseIf cmbprodi.Text = "Teknik Informatika" Then
            txtbiaya.Text = "9500000"
            txtbayar.Clear()
            txttagihan.Clear()
        ElseIf cmbprodi.Text = "Ilmu Komunikasi" Then
            txtbiaya.Text = "9400000"
            txtbayar.Clear()
            txttagihan.Clear()
        ElseIf cmbprodi.Text = "PGSD" Then
            txtbiaya.Text = "12000000"
            txtbayar.Clear()
            txttagihan.Clear()
        ElseIf cmbprodi.Text = "Hukum" Then
            txtbiaya.Text = "9600000"
            txtbayar.Clear()
            txttagihan.Clear()
        ElseIf cmbprodi.Text = "Gizi" Then
            txtbiaya.Text = "12500000"
            txtbayar.Clear()
            txttagihan.Clear()
        End If
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        txttagihan.Text = Val(txtbiaya.Text) - Val(txtbayar.Text)
    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub
End Class
