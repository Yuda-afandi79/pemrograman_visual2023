<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konversi_Reamur_Ke_Celcius_Fahrenheit_Kelvin_By_Reza_Ramadhan
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
        Me.TextReamur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextCelcius = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextKelvin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reamur Ke C F K"
        '
        'B_Konvert
        '
        Me.B_Konvert.Location = New System.Drawing.Point(145, 208)
        Me.B_Konvert.Name = "B_Konvert"
        Me.B_Konvert.Size = New System.Drawing.Size(171, 42)
        Me.B_Konvert.TabIndex = 1
        Me.B_Konvert.Text = "Konvert"
        Me.B_Konvert.UseVisualStyleBackColor = True
        '
        'TextReamur
        '
        Me.TextReamur.Location = New System.Drawing.Point(145, 160)
        Me.TextReamur.Name = "TextReamur"
        Me.TextReamur.Size = New System.Drawing.Size(171, 30)
        Me.TextReamur.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reamur"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Celcius"
        '
        'TextCelcius
        '
        Me.TextCelcius.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextCelcius.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextCelcius.Location = New System.Drawing.Point(145, 292)
        Me.TextCelcius.Name = "TextCelcius"
        Me.TextCelcius.Size = New System.Drawing.Size(171, 30)
        Me.TextCelcius.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fahrenheit"
        '
        'TextFahrenheit
        '
        Me.TextFahrenheit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextFahrenheit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextFahrenheit.Location = New System.Drawing.Point(145, 363)
        Me.TextFahrenheit.Name = "TextFahrenheit"
        Me.TextFahrenheit.Size = New System.Drawing.Size(171, 30)
        Me.TextFahrenheit.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(195, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kelvin"
        '
        'TextKelvin
        '
        Me.TextKelvin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextKelvin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextKelvin.Location = New System.Drawing.Point(145, 431)
        Me.TextKelvin.Name = "TextKelvin"
        Me.TextKelvin.Size = New System.Drawing.Size(171, 30)
        Me.TextKelvin.TabIndex = 8
        '
        'Konversi_Reamur_Ke_Celcius_Fahrenheit_Kelvin_By_Reza_Ramadhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(461, 515)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextKelvin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextFahrenheit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextCelcius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextReamur)
        Me.Controls.Add(Me.B_Konvert)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Konversi_Reamur_Ke_Celcius_Fahrenheit_Kelvin_By_Reza_Ramadhan"
        Me.Text = "Tugas 4 Reamur Ke C F K"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents B_Konvert As Button
    Friend WithEvents TextReamur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextCelcius As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextFahrenheit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextKelvin As TextBox
End Class
