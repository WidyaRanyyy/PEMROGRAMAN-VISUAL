<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_input
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Text_nama = New System.Windows.Forms.TextBox()
        Me.Combo_jurusan = New System.Windows.Forms.ComboBox()
        Me.Text_no_hp = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label_judul1 = New System.Windows.Forms.Label()
        Me.Label_judul2 = New System.Windows.Forms.Label()
        Me.Label_judul3 = New System.Windows.Forms.Label()
        Me.Label_data = New System.Windows.Forms.Label()
        Me.Label_nama = New System.Windows.Forms.Label()
        Me.Label_jurusan = New System.Windows.Forms.Label()
        Me.Label_hp = New System.Windows.Forms.Label()
        Me.Panel_header = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel_header.SuspendLayout()
        Me.SuspendLayout()
        '
        '=== Panel Header (hitam) ===
        '
        Me.Panel_header.BackColor = System.Drawing.Color.Black
        Me.Panel_header.Location = New System.Drawing.Point(12, 12)
        Me.Panel_header.Name = "Panel_header"
        Me.Panel_header.Size = New System.Drawing.Size(360, 130)
        Me.Panel_header.TabIndex = 10
        '
        'Label_judul1 - UNIVERSITAS MULAWARMAN
        '
        Me.Label_judul1.AutoSize = True
        Me.Label_judul1.BackColor = System.Drawing.Color.Black
        Me.Label_judul1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label_judul1.ForeColor = System.Drawing.Color.White
        Me.Label_judul1.Location = New System.Drawing.Point(30, 12)
        Me.Label_judul1.Name = "Label_judul1"
        Me.Label_judul1.Size = New System.Drawing.Size(300, 22)
        Me.Label_judul1.TabIndex = 0
        Me.Label_judul1.Text = "UNIVERSITAS MULAWARMAN"
        Me.Label_judul1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label_judul2 - INFORMATIKA
        '
        Me.Label_judul2.AutoSize = True
        Me.Label_judul2.BackColor = System.Drawing.Color.Black
        Me.Label_judul2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label_judul2.ForeColor = System.Drawing.Color.White
        Me.Label_judul2.Location = New System.Drawing.Point(180, 38)
        Me.Label_judul2.Name = "Label_judul2"
        Me.Label_judul2.Size = New System.Drawing.Size(110, 18)
        Me.Label_judul2.TabIndex = 1
        Me.Label_judul2.Text = "INFORMATIKA"
        '
        'Label_judul3 - 2024
        '
        Me.Label_judul3.AutoSize = True
        Me.Label_judul3.BackColor = System.Drawing.Color.Black
        Me.Label_judul3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label_judul3.ForeColor = System.Drawing.Color.White
        Me.Label_judul3.Location = New System.Drawing.Point(240, 52)
        Me.Label_judul3.Name = "Label_judul3"
        Me.Label_judul3.Size = New System.Drawing.Size(90, 36)
        Me.Label_judul3.TabIndex = 2
        Me.Label_judul3.Text = "2024"
        '
        'Label_data - DATA MAHASISWA
        '
        Me.Label_data.AutoSize = True
        Me.Label_data.BackColor = System.Drawing.Color.Black
        Me.Label_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label_data.ForeColor = System.Drawing.Color.White
        Me.Label_data.Location = New System.Drawing.Point(90, 98)
        Me.Label_data.Name = "Label_data"
        Me.Label_data.Size = New System.Drawing.Size(160, 18)
        Me.Label_data.TabIndex = 3
        Me.Label_data.Text = "DATA MAHASISWA"
        '
        ' Tambahkan label ke panel header
        '
        Me.Panel_header.Controls.Add(Me.Label_judul1)
        Me.Panel_header.Controls.Add(Me.Label_judul2)
        Me.Panel_header.Controls.Add(Me.Label_judul3)
        Me.Panel_header.Controls.Add(Me.Label_data)
        '
        '=== Label Nama Lengkap ===
        '
        Me.Label_nama.AutoSize = True
        Me.Label_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_nama.ForeColor = System.Drawing.Color.White
        Me.Label_nama.Location = New System.Drawing.Point(14, 160)
        Me.Label_nama.Name = "Label_nama"
        Me.Label_nama.Size = New System.Drawing.Size(90, 15)
        Me.Label_nama.TabIndex = 11
        Me.Label_nama.Text = "Nama Lengkap"
        '
        '=== Text_nama ===
        '
        Me.Text_nama.Location = New System.Drawing.Point(170, 157)
        Me.Text_nama.MaxLength = 15
        Me.Text_nama.Name = "Text_nama"
        Me.Text_nama.Size = New System.Drawing.Size(195, 22)
        Me.Text_nama.TabIndex = 0
        '
        '=== Label Program Studi ===
        '
        Me.Label_jurusan.AutoSize = True
        Me.Label_jurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_jurusan.ForeColor = System.Drawing.Color.White
        Me.Label_jurusan.Location = New System.Drawing.Point(14, 200)
        Me.Label_jurusan.Name = "Label_jurusan"
        Me.Label_jurusan.Size = New System.Drawing.Size(82, 15)
        Me.Label_jurusan.TabIndex = 12
        Me.Label_jurusan.Text = "Program Studi"
        '
        '=== Combo_jurusan ===
        '
        Me.Combo_jurusan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_jurusan.Items.AddRange(New Object() {"TI", "SI", "MI"})
        Me.Combo_jurusan.Location = New System.Drawing.Point(170, 197)
        Me.Combo_jurusan.MaxLength = 15
        Me.Combo_jurusan.Name = "Combo_jurusan"
        Me.Combo_jurusan.Size = New System.Drawing.Size(80, 21)
        Me.Combo_jurusan.TabIndex = 1
        '
        '=== Label Nomor HP ===
        '
        Me.Label_hp.AutoSize = True
        Me.Label_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label_hp.ForeColor = System.Drawing.Color.White
        Me.Label_hp.Location = New System.Drawing.Point(14, 240)
        Me.Label_hp.Name = "Label_hp"
        Me.Label_hp.Size = New System.Drawing.Size(60, 15)
        Me.Label_hp.TabIndex = 13
        Me.Label_hp.Text = "Nomor HP"
        '
        '=== Text_no_hp ===
        '
        Me.Text_no_hp.Location = New System.Drawing.Point(170, 237)
        Me.Text_no_hp.MaxLength = 12
        Me.Text_no_hp.Name = "Text_no_hp"
        Me.Text_no_hp.Size = New System.Drawing.Size(195, 22)
        Me.Text_no_hp.TabIndex = 2
        '
        '=== CheckBox2 ===
        '
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(14, 278)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(350, 40)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Saya setuju dan menyatakan bahwa" & vbCrLf & "data yang saya isi adalah benar"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        '=== Button1 (Cetak) ===
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(150, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '=== PrintDocument1 ===
        '
        Me.PrintDocument1.DocumentName = "DataMahasiswa"
        '
        '=== PrintPreviewDialog1 ===
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        '=== Form_input ===
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.ClientSize = New System.Drawing.Size(386, 378)
        Me.Controls.Add(Me.Panel_header)
        Me.Controls.Add(Me.Label_nama)
        Me.Controls.Add(Me.Text_nama)
        Me.Controls.Add(Me.Label_jurusan)
        Me.Controls.Add(Me.Combo_jurusan)
        Me.Controls.Add(Me.Label_hp)
        Me.Controls.Add(Me.Text_no_hp)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_input"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiswa - Universitas Mulawarman"
        Me.Panel_header.ResumeLayout(False)
        Me.Panel_header.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Text_nama As System.Windows.Forms.TextBox
    Friend WithEvents Combo_jurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Text_no_hp As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label_judul1 As System.Windows.Forms.Label
    Friend WithEvents Label_judul2 As System.Windows.Forms.Label
    Friend WithEvents Label_judul3 As System.Windows.Forms.Label
    Friend WithEvents Label_data As System.Windows.Forms.Label
    Friend WithEvents Label_nama As System.Windows.Forms.Label
    Friend WithEvents Label_jurusan As System.Windows.Forms.Label
    Friend WithEvents Label_hp As System.Windows.Forms.Label
    Friend WithEvents Panel_header As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

End Class
