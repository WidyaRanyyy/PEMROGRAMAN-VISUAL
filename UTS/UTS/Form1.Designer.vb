<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblUniversitas = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblOrnamen = New System.Windows.Forms.Label()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblNim = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.lblAngkatan = New System.Windows.Forms.Label()
        Me.txtAngkatan = New System.Windows.Forms.TextBox()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.cmbProdi = New System.Windows.Forms.ComboBox()
        Me.lblIpk = New System.Windows.Forms.Label()
        Me.txtIpk = New System.Windows.Forms.TextBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelHeader.SuspendLayout()
        Me.panelForm.SuspendLayout()
        Me.SuspendLayout()

        ' panelHeader
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(114, 36, 62)
        Me.panelHeader.Controls.Add(Me.lblOrnamen)
        Me.panelHeader.Controls.Add(Me.lblSubtitle)
        Me.panelHeader.Controls.Add(Me.lblUniversitas)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(540, 100)
        Me.panelHeader.TabIndex = 0
        AddHandler Me.panelHeader.Paint, AddressOf panelHeader_Paint

        ' lblUniversitas
        Me.lblUniversitas.AutoSize = False
        Me.lblUniversitas.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUniversitas.ForeColor = System.Drawing.Color.White
        Me.lblUniversitas.Location = New System.Drawing.Point(0, 14)
        Me.lblUniversitas.Name = "lblUniversitas"
        Me.lblUniversitas.Size = New System.Drawing.Size(540, 30)
        Me.lblUniversitas.TabIndex = 0
        Me.lblUniversitas.Text = "UNIVERSITAS MULAWARMAN"
        Me.lblUniversitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblSubtitle
        Me.lblSubtitle.AutoSize = False
        Me.lblSubtitle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(244, 192, 209)
        Me.lblSubtitle.Location = New System.Drawing.Point(0, 48)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(540, 18)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "S A M A R I N D A     *     K A L I M A N T A N   T I M U R"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblOrnamen (hiasan teks bunga)
        Me.lblOrnamen.AutoSize = False
        Me.lblOrnamen.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblOrnamen.ForeColor = System.Drawing.Color.FromArgb(244, 192, 209)
        Me.lblOrnamen.Location = New System.Drawing.Point(0, 70)
        Me.lblOrnamen.Name = "lblOrnamen"
        Me.lblOrnamen.Size = New System.Drawing.Size(540, 20)
        Me.lblOrnamen.TabIndex = 2
        Me.lblOrnamen.Text = "~ * ~ * ~ * ~ * ~ * ~"
        Me.lblOrnamen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' panelForm
        Me.panelForm.BackColor = System.Drawing.Color.White
        Me.panelForm.Controls.Add(Me.lblJudul)
        Me.panelForm.Controls.Add(Me.lblNama)
        Me.panelForm.Controls.Add(Me.txtNama)
        Me.panelForm.Controls.Add(Me.lblNim)
        Me.panelForm.Controls.Add(Me.txtNim)
        Me.panelForm.Controls.Add(Me.lblAngkatan)
        Me.panelForm.Controls.Add(Me.txtAngkatan)
        Me.panelForm.Controls.Add(Me.lblProdi)
        Me.panelForm.Controls.Add(Me.cmbProdi)
        Me.panelForm.Controls.Add(Me.lblIpk)
        Me.panelForm.Controls.Add(Me.txtIpk)
        Me.panelForm.Controls.Add(Me.btnCetak)
        Me.panelForm.Controls.Add(Me.btnClose)
        Me.panelForm.Location = New System.Drawing.Point(24, 116)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(492, 375)
        Me.panelForm.TabIndex = 1

        ' lblJudul
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.FromArgb(114, 36, 62)
        Me.lblJudul.Location = New System.Drawing.Point(20, 20)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Data Mahasiswa"

        ' lblNama
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.lblNama.Location = New System.Drawing.Point(20, 60)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "NAMA LENGKAP"

        ' txtNama
        Me.txtNama.BackColor = System.Drawing.Color.FromArgb(255, 248, 252)
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNama.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtNama.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40)
        Me.txtNama.Location = New System.Drawing.Point(20, 78)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(452, 24)
        Me.txtNama.TabIndex = 2

        ' lblNim
        Me.lblNim.AutoSize = True
        Me.lblNim.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNim.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.lblNim.Location = New System.Drawing.Point(20, 118)
        Me.lblNim.Name = "lblNim"
        Me.lblNim.TabIndex = 3
        Me.lblNim.Text = "NIM"

        ' txtNim
        Me.txtNim.BackColor = System.Drawing.Color.FromArgb(255, 248, 252)
        Me.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNim.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtNim.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40)
        Me.txtNim.Location = New System.Drawing.Point(20, 136)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(216, 24)
        Me.txtNim.TabIndex = 4

        ' lblAngkatan
        Me.lblAngkatan.AutoSize = True
        Me.lblAngkatan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblAngkatan.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.lblAngkatan.Location = New System.Drawing.Point(256, 118)
        Me.lblAngkatan.Name = "lblAngkatan"
        Me.lblAngkatan.TabIndex = 5
        Me.lblAngkatan.Text = "ANGKATAN"

        ' txtAngkatan
        Me.txtAngkatan.BackColor = System.Drawing.Color.FromArgb(255, 248, 252)
        Me.txtAngkatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAngkatan.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAngkatan.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40)
        Me.txtAngkatan.Location = New System.Drawing.Point(256, 136)
        Me.txtAngkatan.Name = "txtAngkatan"
        Me.txtAngkatan.Size = New System.Drawing.Size(216, 24)
        Me.txtAngkatan.TabIndex = 6

        ' lblProdi
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblProdi.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.lblProdi.Location = New System.Drawing.Point(20, 176)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.TabIndex = 7
        Me.lblProdi.Text = "PROGRAM STUDI"

        ' cmbProdi
        Me.cmbProdi.BackColor = System.Drawing.Color.FromArgb(255, 248, 252)
        Me.cmbProdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbProdi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbProdi.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40)
        Me.cmbProdi.Items.AddRange(New Object() {
            "Informatika", "Sistem Informasi", "Teknik Komputer",
            "Ilmu Komputer", "Teknologi Informasi"})
        Me.cmbProdi.Location = New System.Drawing.Point(20, 194)
        Me.cmbProdi.Name = "cmbProdi"
        Me.cmbProdi.Size = New System.Drawing.Size(452, 24)
        Me.cmbProdi.TabIndex = 8

        ' lblIpk
        Me.lblIpk.AutoSize = True
        Me.lblIpk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblIpk.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.lblIpk.Location = New System.Drawing.Point(20, 234)
        Me.lblIpk.Name = "lblIpk"
        Me.lblIpk.TabIndex = 9
        Me.lblIpk.Text = "IPK"

        ' txtIpk
        Me.txtIpk.BackColor = System.Drawing.Color.FromArgb(255, 248, 252)
        Me.txtIpk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIpk.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtIpk.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40)
        Me.txtIpk.Location = New System.Drawing.Point(20, 252)
        Me.txtIpk.Name = "txtIpk"
        Me.txtIpk.Size = New System.Drawing.Size(216, 24)
        Me.txtIpk.TabIndex = 10

        ' btnCetak
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(212, 83, 126)
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(20, 308)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(216, 42)
        Me.btnCetak.TabIndex = 11
        Me.btnCetak.Text = "Cetak Ijazah"
        Me.btnCetak.UseVisualStyleBackColor = False
        Me.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnClose
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(204, 68, 68)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(256, 308)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(216, 42)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(255, 245, 250)
        Me.ClientSize = New System.Drawing.Size(540, 516)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelForm)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Mahasiswa - Universitas Mulawarman"
        Me.panelHeader.ResumeLayout(False)
        Me.panelForm.ResumeLayout(False)
        Me.panelForm.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Private Sub panelHeader_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        Dim g As System.Drawing.Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

        ' Blob lingkaran transparan di kanan header
        g.FillEllipse(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(25, 255, 255, 255)), 420, -30, 160, 160)
        g.FillEllipse(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(15, 255, 255, 255)), 460, 10, 100, 100)

        ' Blob kiri
        g.FillEllipse(New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(20, 255, 200, 220)), -30, -20, 120, 120)

        ' Bunga kecil kanan atas
        DrawSmallFlower(g, 510, 20, 12, System.Drawing.Color.FromArgb(50, 255, 200, 220))
        DrawSmallFlower(g, 480, 60, 8, System.Drawing.Color.FromArgb(35, 244, 192, 209))

        ' Bunga kecil kiri
        DrawSmallFlower(g, 22, 50, 10, System.Drawing.Color.FromArgb(35, 255, 200, 220))
    End Sub

    Private Sub DrawSmallFlower(g As System.Drawing.Graphics, cx As Integer, cy As Integer, r As Integer, col As System.Drawing.Color)
        Using br As New System.Drawing.SolidBrush(col)
            For i As Integer = 0 To 5
                Dim angle As Double = i * (Math.PI * 2 / 6)
                Dim px As Integer = cx + CInt(Math.Cos(angle) * r * 1.5)
                Dim py As Integer = cy + CInt(Math.Sin(angle) * r * 1.5)
                g.FillEllipse(br, px - r \ 2, py - r \ 2, r, r)
            Next
            g.FillEllipse(br, cx - r \ 2, cy - r \ 2, r, r)
        End Using
    End Sub

    Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents lblUniversitas As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblOrnamen As System.Windows.Forms.Label
    Friend WithEvents panelForm As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblNim As System.Windows.Forms.Label
    Friend WithEvents txtNim As System.Windows.Forms.TextBox
    Friend WithEvents lblAngkatan As System.Windows.Forms.Label
    Friend WithEvents txtAngkatan As System.Windows.Forms.TextBox
    Friend WithEvents lblProdi As System.Windows.Forms.Label
    Friend WithEvents cmbProdi As System.Windows.Forms.ComboBox
    Friend WithEvents lblIpk As System.Windows.Forms.Label
    Friend WithEvents txtIpk As System.Windows.Forms.TextBox
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Classs