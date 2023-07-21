Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmLogin

    
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        If TxtUser.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Masukkan username dan password !")
            If TxtUser.Text = "" Then TxtUser.Focus() Else TxtPass.Focus()
            Exit Sub
        End If

        Try
            Dim Source As String = "select * from UserLogin where UserName ='" & TxtUser.Text & "'"
            Dim strCon As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\DB.mdb;"
            Dim Adp As New OleDb.OleDbDataAdapter(Source, strCon)
            Dim DT As New DataTable

            Adp.Fill(DT)

            If DT.Rows.Count > 0 Then
                If DT.Rows(0)("Password") = TxtPass.Text Then
                    'MsgBox("SUCCESS LOGIN !", MsgBoxStyle.Information)
                    'MASUKKAN KODE LANGKAH SELANJUTNYA DISINI

                    TxtPass.Text = ""
                    'TxtUser.Text = ""
                    FrmLoading.Show()
                    FrmLoading.LblForm.Text = "FormAwal"
                    Me.Hide()
                Else
                    MsgBox("Password anda salah !", MsgBoxStyle.Exclamation)
                    TxtPass.Text = ""
                    TxtPass.Focus()
                End If

            Else
                MsgBox("User tidak terdaftar !", MsgBoxStyle.Critical)
                TxtUser.Text = ""
                TxtPass.Text = ""
                TxtUser.Focus()

            End If


        Catch ex As OleDb.OleDbException
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        End
    End Sub

    Private Sub TxtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser.TextChanged
        Dim i As Integer = TxtUser.SelectionStart
        TxtUser.Text = StrConv(TxtUser.Text, VbStrConv.ProperCase)
        TxtUser.SelectionStart = i
    End Sub

    Private Sub TxtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPass.KeyPress
        If e.KeyChar = ChrW(13) Then
            CmdLogin.Focus()
        End If
    End Sub


    Private Sub TxtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPass.TextChanged

    End Sub
End Class