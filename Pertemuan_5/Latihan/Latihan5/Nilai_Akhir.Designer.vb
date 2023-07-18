<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nilai_Akhir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Akhir"
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(12, 108)
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(188, 30)
        Me.txtNilaiAkhir.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.White
        Me.txtKeterangan.Location = New System.Drawing.Point(12, 185)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(549, 30)
        Me.txtKeterangan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 160)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Keterangan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(225, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(169, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Yuda Afandi - 200511003"
        '
        'Nilai_Akhir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(573, 311)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Nilai_Akhir"
        Me.Text = "Latihan 5 Nilai Akhir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
