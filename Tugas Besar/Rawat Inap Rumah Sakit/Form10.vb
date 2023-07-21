Public Class Form10
    Public selectedDoctor As String = Nothing

#Region "Custom Subroutines"
    Private Sub AddDoctor()
        'Check for empty textboxes
        Dim allFilled As Boolean = True
        For Each ctrl In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                If String.IsNullOrWhiteSpace(ctrl.Text) Then
                    allFilled = False
                    Exit For
                End If
            End If
        Next

        'Write doctor to file
        If allFilled Then
            Dim dirPath As String = Nothing
            If String.IsNullOrWhiteSpace(selectedDoctor) Then
                dirPath = Form1.pathDoctors & TextBox1.Text & " - " & TextBox2.Text
            Else
                My.Computer.FileSystem.DeleteDirectory(Form1.pathDoctors & selectedDoctor, FileIO.DeleteDirectoryOption.DeleteAllContents)
                selectedDoctor = TextBox1.Text & " - " & TextBox2.Text
                dirPath = Form1.pathDoctors & selectedDoctor
            End If
            My.Computer.FileSystem.CreateDirectory(dirPath)
            Dim sWriter As New IO.StreamWriter(dirPath & "\doctorInfo.txt")
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    sWriter.WriteLine(ctrl.Text)
                End If
            Next
            sWriter.Close()

            'Visualise doctors
            Form1.UpdateFPanel2()

            'Increment DID
            If String.IsNullOrWhiteSpace(selectedDoctor) Then
                sWriter = New IO.StreamWriter(Form1.pathGeneric & "DID.txt")
                sWriter.Write(Form1.DID + 1)
                sWriter.Close()
            End If
            Close()
        Else
            MessageBox.Show("Please make sure that all data have been entered.", "Hospital Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub RemoveDoctor()
        Dim msgReply = MessageBox.Show("Are you sure you wish to remove this doctor?", "Hospital Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgReply = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(Form1.pathDoctors & selectedDoctor, FileIO.DeleteDirectoryOption.DeleteAllContents)
            If Form1.selectedCategory = "Doctors" Then
                Form1.LoadDoctors()
            End If
            Close()
        End If
    End Sub
#End Region

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Location = New Point(Form1.Left + 25, Form1.Top + 45)
    End Sub

    Private Sub Form10_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Form1.LoadGeneric()
        TextBox1.Text = Form1.DID
        TextBox2.Focus()

        If Not String.IsNullOrWhiteSpace(selectedDoctor) Then
            Dim sReader As New IO.StreamReader(Form1.pathDoctors & selectedDoctor & "\doctorInfo.txt")
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = sReader.ReadLine()
                End If
            Next
            sReader.Close()
            Text = "Edit Dokter"
            Button1.Text = "Simpan"
            Button2.Text = "Hapus"
        End If
    End Sub

    Private Sub Form10_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            AddDoctor()
        ElseIf e.KeyCode = Keys.Delete Then
            RemoveDoctor()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrWhiteSpace(selectedDoctor) Then
            TextBox1.Text = Form1.DID
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddDoctor()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Text = "Reset" Then
            For Each ctrl In GroupBox1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Clear()
                End If
            Next
        Else
            RemoveDoctor()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class