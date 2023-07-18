Public Class Konversi_Celcius_ke_Fahrenheit_Reamur_kelvin
    Private Function ToFahrenheit(suhu As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 5) * suhu + 32
        Return F
    End Function

    Private Function ToReamur(suhu As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 5 * suhu
        Return R
    End Function

    Private Function ToKelvin(suhu As Decimal) As Decimal
        Dim K As Decimal
        K = suhu + 273
        Return K
    End Function

    Private Sub B_Konvert_Click(sender As Object, e As EventArgs) Handles B_Konvert.Click
        Dim C, F, R, K As Decimal
        C = CDec(TextCelcius.Text)
        F = ToFahrenheit(C)
        R = ToReamur(C)
        K = ToKelvin(C)

        TextFahrenheit.Text = Str(F)
        TextReamur.Text = Str(R)
        TextKelvin.Text = Str(K)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
