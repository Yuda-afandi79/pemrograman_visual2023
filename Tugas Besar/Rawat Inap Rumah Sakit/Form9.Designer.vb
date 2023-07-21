<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCaseType = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblAppointmentFor = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCaseType)
        Me.GroupBox1.Controls.Add(Me.lblPatientName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info Pasien"
        '
        'lblCaseType
        '
        Me.lblCaseType.AutoSize = True
        Me.lblCaseType.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblCaseType.Location = New System.Drawing.Point(120, 64)
        Me.lblCaseType.Name = "lblCaseType"
        Me.lblCaseType.Size = New System.Drawing.Size(23, 13)
        Me.lblCaseType.TabIndex = 3
        Me.lblCaseType.Text = "null"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPatientName.Location = New System.Drawing.Point(120, 35)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(23, 13)
        Me.lblPatientName.TabIndex = 2
        Me.lblPatientName.Text = "null"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Diagnosa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pasien:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLocation)
        Me.GroupBox2.Controls.Add(Me.lblAppointmentFor)
        Me.GroupBox2.Controls.Add(Me.lblTime)
        Me.GroupBox2.Controls.Add(Me.lblDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 164)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Janji Temu"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLocation.Location = New System.Drawing.Point(120, 119)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(23, 13)
        Me.lblLocation.TabIndex = 7
        Me.lblLocation.Text = "null"
        '
        'lblAppointmentFor
        '
        Me.lblAppointmentFor.AutoSize = True
        Me.lblAppointmentFor.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAppointmentFor.Location = New System.Drawing.Point(120, 90)
        Me.lblAppointmentFor.Name = "lblAppointmentFor"
        Me.lblAppointmentFor.Size = New System.Drawing.Size(23, 13)
        Me.lblAppointmentFor.TabIndex = 6
        Me.lblAppointmentFor.Text = "null"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTime.Location = New System.Drawing.Point(120, 61)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(23, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "null"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDate.Location = New System.Drawing.Point(120, 32)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(23, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "null"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Lokasi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Janji Untuk:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Waktu:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tanggal:"
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Hospital_Management_System.My.Resources.Resources.iconClose
        Me.Button3.Location = New System.Drawing.Point(287, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 28)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Tutup"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Hospital_Management_System.My.Resources.Resources.iconRemove
        Me.Button2.Location = New System.Drawing.Point(108, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Hapus"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Hospital_Management_System.My.Resources.Resources.iconEdit
        Me.Button1.Location = New System.Drawing.Point(12, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Edit"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 340)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form9"
        Me.Text = "Info Janji Pasien"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCaseType As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblAppointmentFor As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
