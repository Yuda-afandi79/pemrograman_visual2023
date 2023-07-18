Public Class Konversi_Fahrenheit_Ke_Celcius_Reamur_Kelvin
    Private Function ToCelcius(F As Decimal) As Decimal
        Dim C As Decimal
        C = (F - 32) * 5 / 9
        Return C
    End Function

    Private Function ToReamur(F As Decimal) As Decimal
        Dim R As Decimal
        R = 4 / 9 * (F - 32)
        Return R
    End Function

    Private Function ToKelvin(F As Decimal) As Decimal
        Dim K As Decimal
        K = (F - 32) * 5 / 9 + 273.15
        Return K
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F, C, R, K As Decimal

        F = Val(TextFahrenheit.Text)

        C = ToCelcius(F)
        R = ToReamur(F)
        K = ToKelvin(F)

        TextCelcius.Text = Str(C)
        TextReamur.Text = Str(R)
        TextKelvin.Text = Str(K)
    End Sub

    Private Sub TextCelcius_TextChanged(sender As Object, e As EventArgs) Handles TextCelcius.TextChanged

    End Sub
End Class
