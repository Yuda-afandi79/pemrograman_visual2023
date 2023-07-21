Imports System.Data.OleDb
Imports System.Data
Imports System.IO
Public Class FrmUserLogin
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim dz As OleDbCommand
    Dim dr As OleDbDataReader
    Public str As String
    'Tampilkan Listview
    Public koneksiSQL As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
                        "Data Source=" & _
                        Application.StartupPath & _
                        "\DB.mdb;")
    Public perintahSQL As New OleDbCommand
    Public bacadataSQL As OleDbDataReader
    Dim MyListText(10) As String
    Dim MyListItem As ListViewItem
    '---------------
    Sub TampilkanLV()
        'listview Tampil
        LV.Items.Clear()
        koneksiSQL.Close()
        koneksiSQL.Open()
        perintahSQL.Connection = koneksiSQL
        perintahSQL.CommandType = CommandType.Text
        perintahSQL.CommandText = "Select * From UserLogin order by UserName"
        bacadataSQL = perintahSQL.ExecuteReader
        While bacadataSQL.Read
            Dim ls1grid As ListViewItem
            ls1grid = LV.Items.Add(bacadataSQL("UserName"))
            ls1grid.SubItems.Add(bacadataSQL("Password")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("Alamat")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("Kota")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("No_Tlp")).ToString()
            'ls1grid.SubItems.Add(bacadataSQL("No_Hp")).ToString()
        End While
        koneksiSQL.Close()
        '--------------------------------------------------------
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub FrmUserLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TampilkanLV()

    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        If Txtuser.Text = "" Then
            MsgBox("User Login Masih Kosong!!!!")
            Txtuser.Focus()
            GoTo err
        End If
        If Txtpass.Text = "" Then
            MsgBox("Password Masih Kosong!!!!")
            Txtpass.Focus()
            GoTo err
        End If
        If CmdSimpan.Enabled = True Then
            Dim q As String = "select * from UserLogin where UserName='" & Txtuser.Text & "'"
            bukaKoneksi()
            Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE UserLogin set UserName='{0}',Password='{1}'", Txtuser.Text, Txtpass.Text)
            Else
                q = String.Format("INSERT INTO UserLogin VALUES ('{0}','{1}')", _
                             Txtuser.Text, Txtpass.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("USER LOGIN TELAH DITAMBAH", vbOKOnly, "Input User Login")
                TampilkanLV()
                Txtuser.Text = ""
                Txtpass.Text = ""
                CmdEdit.Enabled = False
                CmdHapus.Enabled = False
                Txtuser.Focus()
            Catch ex As Exception
                MsgBox("User Login : " & Txtuser.Text & " Sudah Terdaftar", vbCritical, "User Login")
                Txtuser.Text = ""
                Txtpass.Text = ""
                Txtuser.Focus()
            End Try
        End If
Err:
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
       Dim q As String = "delete from UserLogin where UserName='" & Txtuser.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()
            
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
      
        If CmdSimpan.Enabled = True Then
            bukaKoneksi()
            Dim myread As OleDbDataReader = mycmd.ExecuteReader
            If myread.HasRows Then
                q = String.Format("UPDATE UserLogin set UserName='{0}',Password='{1}'", Txtuser.Text, Txtpass.Text)
            Else
                q = String.Format("INSERT INTO UserLogin VALUES ('{0}','{1}')", _
                             Txtuser.Text, Txtpass.Text)
            End If
            myread.Close()
            bukaKoneksi()
            mycmd = New OleDbCommand(q, conn)
            Try
                mycmd.ExecuteNonQuery()
                MsgBox("USER LOGIN TELAH DIEDIT", vbOKOnly, "Input User Login")
                TampilkanLV()
                Txtuser.Text = ""
                Txtpass.Text = ""
                Txtuser.Focus()
                CmdEdit.Enabled = False
                CmdHapus.Enabled = False
                Txtuser.ReadOnly = False
                Txtuser.Focus()
            Catch ex As Exception
                MsgBox("User Login : " & Txtuser.Text & "", vbCritical, "User Login")
                Txtuser.Text = ""
                Txtpass.Text = ""
                Txtuser.Focus()
            End Try
        End If
Err:
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        'menampilkan item data ke textbox
        With Me.LV
            Dim i As Integer
            For Each item As ListViewItem In LV.SelectedItems
                i = item.Index
            Next

            Dim innercounter As Integer = 0
            For Each subItem As ListViewItem.ListViewSubItem In LV.Items(i).SubItems
                Dim myString As String = LV.Items(i).SubItems(innercounter).Text
                Select Case innercounter
                    Case 0
                        Txtuser.Text = myString
                    Case 1
                        Txtpass.Text = myString
                End Select
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                Txtuser.ReadOnly = True
                innercounter += 1
            Next
        End With
    End Sub

    Private Sub LV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LV.KeyPress
        'menampilkan item data ke textbox
        With Me.LV
            Dim i As Integer
            For Each item As ListViewItem In LV.SelectedItems
                i = item.Index
            Next

            Dim innercounter As Integer = 0
            For Each subItem As ListViewItem.ListViewSubItem In LV.Items(i).SubItems
                Dim myString As String = LV.Items(i).SubItems(innercounter).Text
                Select Case innercounter
                    Case 0
                        Txtuser.Text = myString
                    Case 1
                        Txtpass.Text = myString
                End Select
                CmdEdit.Enabled = True
                CmdHapus.Enabled = True
                Txtuser.ReadOnly = True
                innercounter += 1
            Next
        End With
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        If Txtuser.Text = "Admin" Then
            MsgBox("User Admin Tidak Boleh Dihapus!!!", vbCritical, "Warning Hapus")
            Txtuser.Text = ""
            Txtpass.Text = ""
            CmdSimpan.Enabled = True
            CmdEdit.Enabled = False
            CmdHapus.Enabled = False
            Txtuser.ReadOnly = False
            Txtuser.Focus()
            GoTo Err
        End If
        Dim q As String = "delete from UserLogin where UserName='" & Txtuser.Text & "'"
        bukaKoneksi()
        Dim mycmd As OleDbCommand = New OleDbCommand(q, conn)
        Try
            mycmd.ExecuteNonQuery()
            MsgBox("User Login Telah DiHapus", vbInformation)
            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()
            TampilkanLV()
            Txtuser.Text = ""
            Txtpass.Text = ""
            Txtuser.Focus()
            CmdEdit.Enabled = False
            CmdHapus.Enabled = False
            Txtuser.ReadOnly = False
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
Err:
    End Sub

  
    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Txtuser.Text = ""
        Txtpass.Text = ""
        CmdSimpan.Enabled = True
        CmdEdit.Enabled = False
        CmdHapus.Enabled = False
        Txtuser.ReadOnly = False
        Txtuser.Focus()
    End Sub

    Private Sub Txtuser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtuser.TextChanged
        Dim i As Integer = Txtuser.SelectionStart
        Txtuser.Text = StrConv(Txtuser.Text, VbStrConv.ProperCase)
        Txtuser.SelectionStart = i
    End Sub
End Class