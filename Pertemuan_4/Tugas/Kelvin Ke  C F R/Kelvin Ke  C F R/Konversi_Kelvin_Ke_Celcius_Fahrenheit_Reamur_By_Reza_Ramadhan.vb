Public Class Konversi_Kelvin_Ke_Celcius_Fahrenheit_Reamur_By_Reza_Ramadhan

    Private Function ToCelcius(K As Decimal) As Decimal
        Dim C As Decimal
        C = K - 273.15
        Return C
    End Function

    Private Function ToFahrenheit(K As Decimal) As Decimal
        Dim F As Decimal
        F = ((K - 273.15) * 9 / 5) + 32
        Return F
    End Function

    Private Function ToReamur(K As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 5 * (K - 273)
        Return R
    End Function
    Private Sub B_Konvert_Click(sender As Object, e As EventArgs) Handles B_Konvert.Click
        Dim K, C, F, R As Decimal

        K = Val(TextKelvin.Text)

        C = ToCelcius(K)
        F = ToFahrenheit(K)
        R = ToReamur(K)

        TextCelcius.Text = Str(C)
        TextFahrenheit.Text = Str(F)
        TextReamur.Text = Str(R)
    End Sub
End Class
