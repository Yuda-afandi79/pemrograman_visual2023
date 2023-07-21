Public Class Form8
    Dim canClose As Boolean = False
    Dim canReset As Boolean = False

    Private Sub Form8_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If canClose = False And canReset = False Then
            Form1.Close()
        ElseIf canClose = True Then
            Form1.Show()
            Form7.PlayLoginSound()
        ElseIf canReset = True Then
            Form7.Show()
        End If
    End Sub

    Private Sub Form8_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Form1.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Or String.IsNullOrWhiteSpace(MaskedTextBox1.Text) Then
            MessageBox.Show("Make sure that all data have been entered.", "Create Account - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If TextBox1.Text <> Form1.userName Or MaskedTextBox1.Text <> Form1.passWord Then
                MessageBox.Show("Wrong username and/or password.", "Create Account - Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                canClose = True
                Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        MaskedTextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            MaskedTextBox1.PasswordChar = ""
        Else
            MaskedTextBox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim msgReply = MessageBox.Show("Reset the account? The username and password will be lost.", "Sistem Rawat Inap Rumah Sakit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            Dim userInput = InputBox("In order to reset your account you must enter your current password.", "Reset Account - Sistem Rawat Inap Rumah Sakit")
            If userInput = Form1.passWord Then
                Form1.userName = ""
                Form1.passWord = ""
                canReset = True
                Close()
            End If
        End If
    End Sub
End Class