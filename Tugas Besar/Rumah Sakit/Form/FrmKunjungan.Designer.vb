<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKunjungan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmKunjungan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdCariPeserta = New System.Windows.Forms.Button()
        Me.TxtNoPeserta = New System.Windows.Forms.TextBox()
        Me.CmbJenisKartu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmdCariDokter = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNik = New System.Windows.Forms.TextBox()
        Me.DTKunjungan = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmbDiagnosa = New System.Windows.Forms.ComboBox()
        Me.CmdDiagnosa = New System.Windows.Forms.Button()
        Me.TxtDiagnosa = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbKeluhan = New System.Windows.Forms.ComboBox()
        Me.TxtKeluhan = New System.Windows.Forms.TextBox()
        Me.CmdKeluhan = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmdBatal = New System.Windows.Forms.Button()
        Me.CmdSimpan = New System.Windows.Forms.Button()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "-- Cek Penyakit Pasien --"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.CmdCariPeserta)
        Me.GroupBox6.Controls.Add(Me.TxtNoPeserta)
        Me.GroupBox6.Controls.Add(Me.CmbJenisKartu)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.CmdCariDokter)
        Me.GroupBox6.Controls.Add(Me.TxtNama)
        Me.GroupBox6.Controls.Add(Me.TxtNik)
        Me.GroupBox6.Controls.Add(Me.DTKunjungan)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 22)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(554, 101)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "No peserta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Jenis Kartu"
        '
        'CmdCariPeserta
        '
        Me.CmdCariPeserta.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCariPeserta.ForeColor = System.Drawing.Color.Black
        Me.CmdCariPeserta.Location = New System.Drawing.Point(240, 18)
        Me.CmdCariPeserta.Name = "CmdCariPeserta"
        Me.CmdCariPeserta.Size = New System.Drawing.Size(25, 23)
        Me.CmdCariPeserta.TabIndex = 3
        Me.CmdCariPeserta.Text = "C"
        Me.CmdCariPeserta.UseVisualStyleBackColor = True
        '
        'TxtNoPeserta
        '
        Me.TxtNoPeserta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoPeserta.ForeColor = System.Drawing.Color.Black
        Me.TxtNoPeserta.Location = New System.Drawing.Point(109, 18)
        Me.TxtNoPeserta.MaxLength = 15
        Me.TxtNoPeserta.Name = "TxtNoPeserta"
        Me.TxtNoPeserta.Size = New System.Drawing.Size(128, 23)
        Me.TxtNoPeserta.TabIndex = 2
        '
        'CmbJenisKartu
        '
        Me.CmbJenisKartu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbJenisKartu.ForeColor = System.Drawing.Color.Black
        Me.CmbJenisKartu.Location = New System.Drawing.Point(109, 43)
        Me.CmbJenisKartu.MaxLength = 15
        Me.CmbJenisKartu.Name = "CmbJenisKartu"
        Me.CmbJenisKartu.ReadOnly = True
        Me.CmbJenisKartu.Size = New System.Drawing.Size(93, 23)
        Me.CmbJenisKartu.TabIndex = 45
        Me.CmbJenisKartu.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(312, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tgl Kunjungan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Nik Dokter"
        '
        'CmdCariDokter
        '
        Me.CmdCariDokter.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCariDokter.ForeColor = System.Drawing.Color.Black
        Me.CmdCariDokter.Location = New System.Drawing.Point(521, 18)
        Me.CmdCariDokter.Name = "CmdCariDokter"
        Me.CmdCariDokter.Size = New System.Drawing.Size(25, 23)
        Me.CmdCariDokter.TabIndex = 5
        Me.CmdCariDokter.Text = "C"
        Me.CmdCariDokter.UseVisualStyleBackColor = True
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNama.ForeColor = System.Drawing.Color.Black
        Me.TxtNama.Location = New System.Drawing.Point(109, 69)
        Me.TxtNama.MaxLength = 60
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(172, 23)
        Me.TxtNama.TabIndex = 4
        Me.TxtNama.TabStop = False
        '
        'TxtNik
        '
        Me.TxtNik.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNik.ForeColor = System.Drawing.Color.Black
        Me.TxtNik.Location = New System.Drawing.Point(409, 18)
        Me.TxtNik.MaxLength = 15
        Me.TxtNik.Name = "TxtNik"
        Me.TxtNik.Size = New System.Drawing.Size(109, 23)
        Me.TxtNik.TabIndex = 4
        '
        'DTKunjungan
        '
        Me.DTKunjungan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTKunjungan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTKunjungan.Location = New System.Drawing.Point(409, 42)
        Me.DTKunjungan.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.DTKunjungan.Name = "DTKunjungan"
        Me.DTKunjungan.Size = New System.Drawing.Size(109, 23)
        Me.DTKunjungan.TabIndex = 6
        '
        'GroupBox5
        '
        Me.GroupBox5.BackgroundImage = CType(resources.GetObject("GroupBox5.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Location = New System.Drawing.Point(379, 172)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(175, 168)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmbDiagnosa)
        Me.GroupBox4.Controls.Add(Me.CmdDiagnosa)
        Me.GroupBox4.Controls.Add(Me.TxtDiagnosa)
        Me.GroupBox4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(19, 259)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(343, 118)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Diagnosa"
        '
        'CmbDiagnosa
        '
        Me.CmbDiagnosa.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDiagnosa.ForeColor = System.Drawing.Color.Black
        Me.CmbDiagnosa.FormattingEnabled = True
        Me.CmbDiagnosa.Location = New System.Drawing.Point(19, 38)
        Me.CmbDiagnosa.MaxLength = 40
        Me.CmbDiagnosa.Name = "CmbDiagnosa"
        Me.CmbDiagnosa.Size = New System.Drawing.Size(96, 26)
        Me.CmbDiagnosa.TabIndex = 11
        '
        'CmdDiagnosa
        '
        Me.CmdDiagnosa.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDiagnosa.ForeColor = System.Drawing.Color.Black
        Me.CmdDiagnosa.Location = New System.Drawing.Point(121, 37)
        Me.CmdDiagnosa.Name = "CmdDiagnosa"
        Me.CmdDiagnosa.Size = New System.Drawing.Size(33, 28)
        Me.CmdDiagnosa.TabIndex = 12
        Me.CmdDiagnosa.Text = "..."
        Me.CmdDiagnosa.UseVisualStyleBackColor = True
        '
        'TxtDiagnosa
        '
        Me.TxtDiagnosa.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiagnosa.ForeColor = System.Drawing.Color.Black
        Me.TxtDiagnosa.Location = New System.Drawing.Point(160, 22)
        Me.TxtDiagnosa.MaxLength = 1000
        Me.TxtDiagnosa.Multiline = True
        Me.TxtDiagnosa.Name = "TxtDiagnosa"
        Me.TxtDiagnosa.ReadOnly = True
        Me.TxtDiagnosa.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDiagnosa.Size = New System.Drawing.Size(172, 80)
        Me.TxtDiagnosa.TabIndex = 39
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CmbKeluhan)
        Me.GroupBox3.Controls.Add(Me.TxtKeluhan)
        Me.GroupBox3.Controls.Add(Me.CmdKeluhan)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(19, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 118)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keluhan"
        '
        'CmbKeluhan
        '
        Me.CmbKeluhan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbKeluhan.ForeColor = System.Drawing.Color.Black
        Me.CmbKeluhan.FormattingEnabled = True
        Me.CmbKeluhan.Location = New System.Drawing.Point(19, 38)
        Me.CmbKeluhan.MaxLength = 40
        Me.CmbKeluhan.Name = "CmbKeluhan"
        Me.CmbKeluhan.Size = New System.Drawing.Size(96, 26)
        Me.CmbKeluhan.TabIndex = 8
        '
        'TxtKeluhan
        '
        Me.TxtKeluhan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKeluhan.ForeColor = System.Drawing.Color.Black
        Me.TxtKeluhan.Location = New System.Drawing.Point(163, 22)
        Me.TxtKeluhan.MaxLength = 1000
        Me.TxtKeluhan.Multiline = True
        Me.TxtKeluhan.Name = "TxtKeluhan"
        Me.TxtKeluhan.ReadOnly = True
        Me.TxtKeluhan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtKeluhan.Size = New System.Drawing.Size(172, 80)
        Me.TxtKeluhan.TabIndex = 41
        '
        'CmdKeluhan
        '
        Me.CmdKeluhan.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdKeluhan.ForeColor = System.Drawing.Color.Black
        Me.CmdKeluhan.Location = New System.Drawing.Point(121, 37)
        Me.CmdKeluhan.Name = "CmdKeluhan"
        Me.CmdKeluhan.Size = New System.Drawing.Size(33, 28)
        Me.CmdKeluhan.TabIndex = 9
        Me.CmdKeluhan.Text = "..."
        Me.CmdKeluhan.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdBatal)
        Me.GroupBox2.Controls.Add(Me.CmdSimpan)
        Me.GroupBox2.Controls.Add(Me.LblTanggal)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(12, 480)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(573, 65)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'CmdBatal
        '
        Me.CmdBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBatal.ForeColor = System.Drawing.Color.Black
        Me.CmdBatal.Location = New System.Drawing.Point(473, 12)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(91, 46)
        Me.CmdBatal.TabIndex = 15
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Enabled = False
        Me.CmdSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSimpan.ForeColor = System.Drawing.Color.Black
        Me.CmdSimpan.Location = New System.Drawing.Point(372, 12)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(91, 46)
        Me.CmdSimpan.TabIndex = 14
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.LblTanggal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTanggal.ForeColor = System.Drawing.Color.White
        Me.LblTanggal.Location = New System.Drawing.Point(16, 27)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(71, 18)
        Me.LblTanggal.TabIndex = 51
        Me.LblTanggal.Text = "Tanggal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(174, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(363, 18)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Menu Ini Digunakan Untuk Menginput Data Kunjungan Pasien"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(132, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(259, 27)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "DATA KUNJUNGAN PASIEN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(84, 81)
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FrmKunjungan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(594, 551)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmKunjungan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = ":::.. Kunjungan Pasien ..:::"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents DTKunjungan As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoPeserta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents TxtNik As System.Windows.Forms.TextBox
    Friend WithEvents TxtKeluhan As System.Windows.Forms.TextBox
    Friend WithEvents CmdKeluhan As System.Windows.Forms.Button
    Friend WithEvents CmdCariDokter As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTanggal As System.Windows.Forms.Label
    Friend WithEvents CmbKeluhan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbDiagnosa As System.Windows.Forms.ComboBox
    Friend WithEvents CmdDiagnosa As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CmdCariPeserta As System.Windows.Forms.Button
    Friend WithEvents CmbJenisKartu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
End Class
