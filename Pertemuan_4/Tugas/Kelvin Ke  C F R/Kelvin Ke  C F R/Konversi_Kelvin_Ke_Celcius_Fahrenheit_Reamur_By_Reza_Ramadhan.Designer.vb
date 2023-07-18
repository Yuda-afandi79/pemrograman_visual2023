<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konversi_Kelvin_Ke_Celcius_Fahrenheit_Reamur_By_Reza_Ramadhan
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
        Me.B_Konvert = New System.Windows.Forms.Button()
        Me.TextKelvin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextCelcius = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextReamur = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelvin Ke C F R"
        '
        'B_Konvert
        '
        Me.B_Konvert.Location = New System.Drawing.Point(133, 191)
        Me.B_Konvert.Name = "B_Konvert"
        Me.B_Konvert.Size = New System.Drawing.Size(187, 41)
        Me.B_Konvert.TabIndex = 1
        Me.B_Konvert.Text = "Konvert"
        Me.B_Konvert.UseVisualStyleBackColor = True
        '
        'TextKelvin
        '
        Me.TextKelvin.Location = New System.Drawing.Point(133, 134)
        Me.TextKelvin.Name = "TextKelvin"
        Me.TextKelvin.Size = New System.Drawing.Size(187, 30)
        Me.TextKelvin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kelvin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Celcius"
        '
        'TextCelcius
        '
        Me.TextCelcius.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextCelcius.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextCelcius.Location = New System.Drawing.Point(133, 279)
        Me.TextCelcius.Name = "TextCelcius"
        Me.TextCelcius.Size = New System.Drawing.Size(187, 30)
        Me.TextCelcius.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fahrenheit"
        '
        'TextFahrenheit
        '
        Me.TextFahrenheit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFahrenheit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextFahrenheit.Location = New System.Drawing.Point(133, 349)
        Me.TextFahrenheit.Name = "TextFahrenheit"
        Me.TextFahrenheit.Size = New System.Drawing.Size(187, 30)
        Me.TextFahrenheit.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Reamur"
        '
        'TextReamur
        '
        Me.TextReamur.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextReamur.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextReamur.Location = New System.Drawing.Point(133, 421)
        Me.TextReamur.Name = "TextReamur"
        Me.TextReamur.Size = New System.Drawing.Size(187, 30)
        Me.TextReamur.TabIndex = 8
        '
        'Konversi_Kelvin_Ke_Celcius_Fahrenheit_Reamur_By_Reza_Ramadhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 541)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextReamur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextFahrenheit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextKelvin)
        Me.Controls.Add(Me.B_Konvert)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Konversi_Kelvin_Ke_Celcius_Fahrenheit_Reamur_By_Reza_Ramadhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tugas 4 Kelvin Ke C F R"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents B_Konvert As Button
    Friend WithEvents TextKelvin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCelcius As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextFahrenheit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextReamur As TextBox
End Class
