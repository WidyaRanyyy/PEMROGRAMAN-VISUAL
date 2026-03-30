<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIjazah
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
        Me.panelIjazahOuter = New System.Windows.Forms.Panel()
        Me.panelIjazahHeader = New System.Windows.Forms.Panel()
        Me.lblUnivIjazah = New System.Windows.Forms.Label()
        Me.lblKotaIjazah = New System.Windows.Forms.Label()
        Me.panelIjazahBody = New System.Windows.Forms.Panel()
        Me.lblMinistry = New System.Windows.Forms.Label()
        Me.lblOrnament1 = New System.Windows.Forms.Label()
        Me.lblDenganIni = New System.Windows.Forms.Label()
        Me.lblNamaMhs = New System.Windows.Forms.Label()
        Me.lblNimMhs = New System.Windows.Forms.Label()
        Me.lblTelah = New System.Windows.Forms.Label()
        Me.lblDiberikan = New System.Windows.Forms.Label()
        Me.lblGelar = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.lblOrnament2 = New System.Windows.Forms.Label()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCloseIjazah = New System.Windows.Forms.Button()
        Me.panelIjazahOuter.SuspendLayout()
        Me.panelIjazahHeader.SuspendLayout()
        Me.panelIjazahBody.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        Me.SuspendLayout()

        Me.panelIjazahOuter.BackColor = System.Drawing.Color.White
        Me.panelIjazahOuter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelIjazahOuter.Controls.Add(Me.panelIjazahHeader)
        Me.panelIjazahOuter.Controls.Add(Me.panelIjazahBody)
        Me.panelIjazahOuter.Location = New System.Drawing.Point(20, 16)
        Me.panelIjazahOuter.Name = "panelIjazahOuter"
        Me.panelIjazahOuter.Size = New System.Drawing.Size(480, 450)
        Me.panelIjazahOuter.TabIndex = 0

        Me.panelIjazahHeader.BackColor = System.Drawing.Color.FromArgb(114, 36, 62)
        Me.panelIjazahHeader.Controls.Add(Me.lblUnivIjazah)
        Me.panelIjazahHeader.Controls.Add(Me.lblKotaIjazah)
        Me.panelIjazahHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelIjazahHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelIjazahHeader.Name = "panelIjazahHeader"
        Me.panelIjazahHeader.Size = New System.Drawing.Size(478, 70)
        Me.panelIjazahHeader.TabIndex = 0

        Me.lblUnivIjazah.AutoSize = False
        Me.lblUnivIjazah.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblUnivIjazah.ForeColor = System.Drawing.Color.White
        Me.lblUnivIjazah.Location = New System.Drawing.Point(0, 10)
        Me.lblUnivIjazah.Name = "lblUnivIjazah"
        Me.lblUnivIjazah.Size = New System.Drawing.Size(478, 26)
        Me.lblUnivIjazah.TabIndex = 0
        Me.lblUnivIjazah.Text = "UNIVERSITAS MULAWARMAN"
        Me.lblUnivIjazah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblKotaIjazah.AutoSize = False
        Me.lblKotaIjazah.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.lblKotaIjazah.ForeColor = System.Drawing.Color.FromArgb(244, 192, 209)
        Me.lblKotaIjazah.Location = New System.Drawing.Point(0, 42)
        Me.lblKotaIjazah.Name = "lblKotaIjazah"
        Me.lblKotaIjazah.Size = New System.Drawing.Size(478, 18)
        Me.lblKotaIjazah.TabIndex = 1
        Me.lblKotaIjazah.Text = "SAMARINDA  *  KALIMANTAN TIMUR"
        Me.lblKotaIjazah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.panelIjazahBody.BackColor = System.Drawing.Color.White
        Me.panelIjazahBody.Controls.Add(Me.lblMinistry)
        Me.panelIjazahBody.Controls.Add(Me.lblOrnament1)
        Me.panelIjazahBody.Controls.Add(Me.lblDenganIni)
        Me.panelIjazahBody.Controls.Add(Me.lblNamaMhs)
        Me.panelIjazahBody.Controls.Add(Me.lblNimMhs)
        Me.panelIjazahBody.Controls.Add(Me.lblTelah)
        Me.panelIjazahBody.Controls.Add(Me.lblDiberikan)
        Me.panelIjazahBody.Controls.Add(Me.lblGelar)
        Me.panelIjazahBody.Controls.Add(Me.lblPredikat)
        Me.panelIjazahBody.Controls.Add(Me.lblOrnament2)
        Me.panelIjazahBody.Controls.Add(Me.lblFooter)
        Me.panelIjazahBody.Location = New System.Drawing.Point(16, 86)
        Me.panelIjazahBody.Name = "panelIjazahBody"
        Me.panelIjazahBody.Size = New System.Drawing.Size(446, 348)
        Me.panelIjazahBody.TabIndex = 1

        Dim w As Integer = 446 : Dim y As Integer = 14

        Me.lblMinistry.AutoSize = False : Me.lblMinistry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMinistry.ForeColor = System.Drawing.Color.FromArgb(114, 36, 62) : Me.lblMinistry.Location = New System.Drawing.Point(0, y)
        Me.lblMinistry.Name = "lblMinistry" : Me.lblMinistry.Size = New System.Drawing.Size(w, 36) : Me.lblMinistry.TabIndex = 0
        Me.lblMinistry.Text = "KEMENTERIAN PENDIDIKAN" & vbCrLf & "UNIVERSITAS MULAWARMAN"
        Me.lblMinistry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 50

        Me.lblOrnament1.AutoSize = False : Me.lblOrnament1.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.lblOrnament1.ForeColor = System.Drawing.Color.FromArgb(212, 83, 126) : Me.lblOrnament1.Location = New System.Drawing.Point(0, y)
        Me.lblOrnament1.Name = "lblOrnament1" : Me.lblOrnament1.Size = New System.Drawing.Size(w, 22) : Me.lblOrnament1.TabIndex = 1
        Me.lblOrnament1.Text = "* * * * *" : Me.lblOrnament1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 28

        Me.lblDenganIni.AutoSize = False : Me.lblDenganIni.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDenganIni.ForeColor = System.Drawing.Color.FromArgb(100, 60, 70) : Me.lblDenganIni.Location = New System.Drawing.Point(0, y)
        Me.lblDenganIni.Name = "lblDenganIni" : Me.lblDenganIni.Size = New System.Drawing.Size(w, 18) : Me.lblDenganIni.TabIndex = 2
        Me.lblDenganIni.Text = "Dengan ini menyatakan bahwa :" : Me.lblDenganIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 26

        Me.lblNamaMhs.AutoSize = False : Me.lblNamaMhs.Font = New System.Drawing.Font("Georgia", 14.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline)
        Me.lblNamaMhs.ForeColor = System.Drawing.Color.FromArgb(58, 26, 40) : Me.lblNamaMhs.Location = New System.Drawing.Point(0, y)
        Me.lblNamaMhs.Name = "lblNamaMhs" : Me.lblNamaMhs.Size = New System.Drawing.Size(w, 28) : Me.lblNamaMhs.TabIndex = 3
        Me.lblNamaMhs.Text = "NAMA MAHASISWA" : Me.lblNamaMhs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 32

        Me.lblNimMhs.AutoSize = False : Me.lblNimMhs.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblNimMhs.ForeColor = System.Drawing.Color.FromArgb(100, 60, 70) : Me.lblNimMhs.Location = New System.Drawing.Point(0, y)
        Me.lblNimMhs.Name = "lblNimMhs" : Me.lblNimMhs.Size = New System.Drawing.Size(w, 18) : Me.lblNimMhs.TabIndex = 4
        Me.lblNimMhs.Text = "NIM : -" : Me.lblNimMhs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 26

        Me.lblTelah.AutoSize = False : Me.lblTelah.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblTelah.ForeColor = System.Drawing.Color.FromArgb(100, 60, 70) : Me.lblTelah.Location = New System.Drawing.Point(0, y)
        Me.lblTelah.Name = "lblTelah" : Me.lblTelah.Size = New System.Drawing.Size(w, 52) : Me.lblTelah.TabIndex = 5
        Me.lblTelah.Text = "Telah menyelesaikan studi dan memenuhi segala syarat" & vbCrLf & "Pendidikan Strata Satu Program Studi -" & vbCrLf & "Lulus pada tanggal : -"
        Me.lblTelah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 60

        Me.lblDiberikan.AutoSize = False : Me.lblDiberikan.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblDiberikan.ForeColor = System.Drawing.Color.FromArgb(100, 60, 70) : Me.lblDiberikan.Location = New System.Drawing.Point(0, y)
        Me.lblDiberikan.Name = "lblDiberikan" : Me.lblDiberikan.Size = New System.Drawing.Size(w, 18) : Me.lblDiberikan.TabIndex = 6
        Me.lblDiberikan.Text = "Oleh sebab itu kepadanya diberikan gelar" : Me.lblDiberikan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 26

        Me.lblGelar.AutoSize = False : Me.lblGelar.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblGelar.ForeColor = System.Drawing.Color.FromArgb(114, 36, 62) : Me.lblGelar.Location = New System.Drawing.Point(0, y)
        Me.lblGelar.Name = "lblGelar" : Me.lblGelar.Size = New System.Drawing.Size(w, 24) : Me.lblGelar.TabIndex = 7
        Me.lblGelar.Text = "SARJANA KOMPUTER (S.Kom)" : Me.lblGelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 28

        Me.lblPredikat.AutoSize = False : Me.lblPredikat.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPredikat.ForeColor = System.Drawing.Color.FromArgb(212, 83, 126) : Me.lblPredikat.Location = New System.Drawing.Point(0, y)
        Me.lblPredikat.Name = "lblPredikat" : Me.lblPredikat.Size = New System.Drawing.Size(w, 22) : Me.lblPredikat.TabIndex = 8
        Me.lblPredikat.Text = "CUMLAUDE" : Me.lblPredikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 28

        Me.lblOrnament2.AutoSize = False : Me.lblOrnament2.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lblOrnament2.ForeColor = System.Drawing.Color.FromArgb(212, 83, 126) : Me.lblOrnament2.Location = New System.Drawing.Point(0, y)
        Me.lblOrnament2.Name = "lblOrnament2" : Me.lblOrnament2.Size = New System.Drawing.Size(w, 20) : Me.lblOrnament2.TabIndex = 9
        Me.lblOrnament2.Text = "* * * * *" : Me.lblOrnament2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter : y += 26

        Me.lblFooter.AutoSize = False : Me.lblFooter.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(140, 100, 110) : Me.lblFooter.Location = New System.Drawing.Point(0, y)
        Me.lblFooter.Name = "lblFooter" : Me.lblFooter.Size = New System.Drawing.Size(w, 18) : Me.lblFooter.TabIndex = 10
        Me.lblFooter.Text = "Dengan segala kewajiban melekat pada gelar tersebut"
        Me.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.panelButtons.BackColor = System.Drawing.Color.Transparent
        Me.panelButtons.Controls.Add(Me.btnKembali)
        Me.panelButtons.Controls.Add(Me.btnPrint)
        Me.panelButtons.Controls.Add(Me.btnCloseIjazah)
        Me.panelButtons.Location = New System.Drawing.Point(20, 480)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(480, 44)
        Me.panelButtons.TabIndex = 1

        Me.btnKembali.BackColor = System.Drawing.Color.White
        Me.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(237, 147, 177)
        Me.btnKembali.FlatAppearance.BorderSize = 1
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnKembali.ForeColor = System.Drawing.Color.FromArgb(153, 53, 86)
        Me.btnKembali.Location = New System.Drawing.Point(0, 0)
        Me.btnKembali.Name = "btnKembali" : Me.btnKembali.Size = New System.Drawing.Size(148, 40) : Me.btnKembali.TabIndex = 0
        Me.btnKembali.Text = "<  Kembali" : Me.btnKembali.UseVisualStyleBackColor = False : Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(212, 83, 126)
        Me.btnPrint.FlatAppearance.BorderSize = 0 : Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(166, 0)
        Me.btnPrint.Name = "btnPrint" : Me.btnPrint.Size = New System.Drawing.Size(148, 40) : Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print Ijazah" : Me.btnPrint.UseVisualStyleBackColor = False : Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnCloseIjazah.BackColor = System.Drawing.Color.FromArgb(204, 68, 68)
        Me.btnCloseIjazah.FlatAppearance.BorderSize = 0 : Me.btnCloseIjazah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseIjazah.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCloseIjazah.ForeColor = System.Drawing.Color.White
        Me.btnCloseIjazah.Location = New System.Drawing.Point(332, 0)
        Me.btnCloseIjazah.Name = "btnCloseIjazah" : Me.btnCloseIjazah.Size = New System.Drawing.Size(148, 40) : Me.btnCloseIjazah.TabIndex = 2
        Me.btnCloseIjazah.Text = "Close" : Me.btnCloseIjazah.UseVisualStyleBackColor = False : Me.btnCloseIjazah.Cursor = System.Windows.Forms.Cursors.Hand

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(251, 234, 240)
        Me.ClientSize = New System.Drawing.Size(520, 540)
        Me.Controls.Add(Me.panelIjazahOuter)
        Me.Controls.Add(Me.panelButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False : Me.Name = "FormIjazah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ijazah Mahasiswa - Universitas Mulawarman"
        Me.panelIjazahOuter.ResumeLayout(False)
        Me.panelIjazahHeader.ResumeLayout(False)
        Me.panelIjazahBody.ResumeLayout(False)
        Me.panelButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents panelIjazahOuter As System.Windows.Forms.Panel
    Friend WithEvents panelIjazahHeader As System.Windows.Forms.Panel
    Friend WithEvents lblUnivIjazah As System.Windows.Forms.Label
    Friend WithEvents lblKotaIjazah As System.Windows.Forms.Label
    Friend WithEvents panelIjazahBody As System.Windows.Forms.Panel
    Friend WithEvents lblMinistry As System.Windows.Forms.Label
    Friend WithEvents lblOrnament1 As System.Windows.Forms.Label
    Friend WithEvents lblDenganIni As System.Windows.Forms.Label
    Friend WithEvents lblNamaMhs As System.Windows.Forms.Label
    Friend WithEvents lblNimMhs As System.Windows.Forms.Label
    Friend WithEvents lblTelah As System.Windows.Forms.Label
    Friend WithEvents lblDiberikan As System.Windows.Forms.Label
    Friend WithEvents lblGelar As System.Windows.Forms.Label
    Friend WithEvents lblPredikat As System.Windows.Forms.Label
    Friend WithEvents lblOrnament2 As System.Windows.Forms.Label
    Friend WithEvents lblFooter As System.Windows.Forms.Label
    Friend WithEvents panelButtons As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCloseIjazah As System.Windows.Forms.Button

End Class