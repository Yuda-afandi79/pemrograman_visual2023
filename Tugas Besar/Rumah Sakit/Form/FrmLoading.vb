Public Class FrmLoading
 



    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer1.Stop()
            End

        End If
    End Sub

    Private Sub FrmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Stop()
        Timer2.Stop()
        If LblForm.Text = "FormAwal" Then
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            Timer2.Start()
        Else

            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 2
        ElseIf ProgressBar1.Value = 100 Then
            Timer2.Stop()
            Form1.Show()
            Form1.lblUser.Text = FrmLogin.TxtUser.Text
            Me.Dispose()
        End If
    End Sub

    Private Sub LblForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblForm.Click

    End Sub

    Private Sub LblForm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblForm.TextChanged
        If LblForm.Text = "FormAwal" Then
            PictureBox2.Visible = True
            PictureBox1.Visible = False
            Timer2.Start()
            Timer1.Stop()
        Else

            PictureBox1.Visible = True
            PictureBox2.Visible = False
            Timer1.Start()
            Timer2.Stop()
        End If
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class