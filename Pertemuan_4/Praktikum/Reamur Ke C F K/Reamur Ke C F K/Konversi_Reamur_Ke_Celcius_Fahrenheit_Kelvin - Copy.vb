Public Class Konversi_Reamur_Ke_Celcius_Fahrenheit_Kelvin_By_Reza_Ramadhan
    Private Function ToCelcius(R As Decimal) As Decimal
        Dim C As Decimal
        C = (5 / 4) * R
        Return C
    End Function

    Private Function Tofahrenheit(R As Decimal) As Decimal
        Dim F As Decimal
        F = (9 / 4 * R) + 32
        Return F
    End Function

    Private Function ToKelvin(R As Decimal) As Decimal
        Dim K As Decimal
        K = (5 / 4 * R) + 273
        Return K
    End Function
    Private Sub B_Konvert_Click(sender As Object, e As EventArgs) Handles B_Konvert.Click
        Dim R, C, F, K As Decimal

        R = Val(TextReamur.Text)

        C = ToCelcius(R)
        F = Tofahrenheit(R)
        K = ToKelvin(R)

        TextCelcius.Text = Str(C)
        TextFahrenheit.Text = Str(F)
        TextKelvin.Text = Str(K)
    End Sub
End Class
