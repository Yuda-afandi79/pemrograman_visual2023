<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaMk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodemk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHapus.Location = New System.Drawing.Point(668, 165)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(150, 39)
        Me.btnHapus.TabIndex = 33
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSimpan.ForeColor = System.Drawing.Color.Black
        Me.btnSimpan.Location = New System.Drawing.Point(668, 66)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(150, 39)
        Me.btnSimpan.TabIndex = 32
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.Location = New System.Drawing.Point(668, 115)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(150, 39)
        Me.btnReset.TabIndex = 31
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(228, 203)
        Me.txtProdi.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(327, 30)
        Me.txtProdi.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Prodi"
        '
        'txtsks
        '
        Me.txtsks.Location = New System.Drawing.Point(228, 159)
        Me.txtsks.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtsks.Name = "txtsks"
        Me.txtsks.Size = New System.Drawing.Size(327, 30)
        Me.txtsks.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "SKS"
        '
        'txtNamaMk
        '
        Me.txtNamaMk.Location = New System.Drawing.Point(228, 115)
        Me.txtNamaMk.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNamaMk.Name = "txtNamaMk"
        Me.txtNamaMk.Size = New System.Drawing.Size(327, 30)
        Me.txtNamaMk.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nama Mk"
        '
        'txtKodemk
        '
        Me.txtKodemk.Location = New System.Drawing.Point(228, 71)
        Me.txtKodemk.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtKodemk.Name = "txtKodemk"
        Me.txtKodemk.Size = New System.Drawing.Size(327, 30)
        Me.txtKodemk.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Kode Mk"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(56, 288)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(762, 257)
        Me.DataGridView1.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 568)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(256, 25)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Yuda Afandi - 200511003"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(905, 621)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaMk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodemk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaMk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodemk As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
End Class
