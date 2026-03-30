Public Class FormIjazah

    '── Data mahasiswa diterima dari Form1 ────────────────────────────
    Private ReadOnly _nama As String
    Private ReadOnly _nim As String
    Private ReadOnly _prodi As String
    Private ReadOnly _angkatan As String
    Private ReadOnly _ipk As Double

    '── Warna tema pink ───────────────────────────────────────────────
    Private ReadOnly PinkAccent As System.Drawing.Color = System.Drawing.Color.FromArgb(212, 83, 126)
    Private ReadOnly PinkHover As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 60, 100)
    Private ReadOnly RedNormal As System.Drawing.Color = System.Drawing.Color.FromArgb(204, 68, 68)
    Private ReadOnly RedHover As System.Drawing.Color = System.Drawing.Color.FromArgb(170, 40, 40)

    '── Constructor ───────────────────────────────────────────────────
    Public Sub New(nama As String, nim As String, prodi As String, angkatan As String, ipk As Double)
        InitializeComponent()
        _nama = nama
        _nim = nim
        _prodi = prodi
        _angkatan = angkatan
        _ipk = ipk
    End Sub

    '── Load form ─────────────────────────────────────────────────────
    Private Sub FormIjazah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsiDataIjazah()
        AddHandler panelIjazahBody.Paint, AddressOf panelIjazahBody_Paint
        AddHandler btnPrint.MouseEnter, Sub() btnPrint.BackColor = PinkHover
        AddHandler btnPrint.MouseLeave, Sub() btnPrint.BackColor = PinkAccent
        AddHandler btnCloseIjazah.MouseEnter, Sub() btnCloseIjazah.BackColor = RedHover
        AddHandler btnCloseIjazah.MouseLeave, Sub() btnCloseIjazah.BackColor = RedNormal
    End Sub

    '── Isi semua label ijazah dengan data mahasiswa ──────────────────
    Private Sub IsiDataIjazah()
        lblNamaMhs.Text = _nama.ToUpper()
        lblNimMhs.Text = "NIM : " & _nim

        Dim tgl As String = DateTime.Now.ToString("dd MMMM yyyy",
            New System.Globalization.CultureInfo("id-ID"))

        lblTelah.Text = "Telah menyelesaikan studi dan memenuhi segala syarat" & vbCrLf &
                        "Pendidikan Strata Satu Program Studi " & _prodi & vbCrLf &
                        "Lulus pada tanggal : " & tgl

        If _ipk > 3.5 Then
            lblPredikat.Text = "CUMLAUDE"
            lblPredikat.ForeColor = System.Drawing.Color.FromArgb(212, 83, 126)
        Else
            lblPredikat.Text = "SANGAT MEMUASKAN"
            lblPredikat.ForeColor = System.Drawing.Color.FromArgb(114, 36, 62)
        End If
    End Sub

    '── Border dekoratif panel ijazah ─────────────────────────────────
    Private Sub panelIjazahBody_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        Using pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(244, 192, 209), 2)
            e.Graphics.DrawRectangle(pen, 1, 1, panelIjazahBody.Width - 3, panelIjazahBody.Height - 3)
        End Using
        Using pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(180, 237, 147, 177), 1)
            e.Graphics.DrawRectangle(pen, 6, 6, panelIjazahBody.Width - 13, panelIjazahBody.Height - 13)
        End Using
        Using pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(212, 83, 126), 1)
            e.Graphics.DrawLine(pen, 16, 54, panelIjazahBody.Width - 16, 54)
        End Using
        Using pen As New System.Drawing.Pen(System.Drawing.Color.FromArgb(244, 192, 209), 1)
            e.Graphics.DrawLine(pen, 16, panelIjazahBody.Height - 28, panelIjazahBody.Width - 16, panelIjazahBody.Height - 28)
        End Using
    End Sub

    '── Tombol Kembali ────────────────────────────────────────────────
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    '── Tombol Print ──────────────────────────────────────────────────
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim pd As New System.Drawing.Printing.PrintDocument()
        AddHandler pd.PrintPage, Sub(s As Object, ev As System.Drawing.Printing.PrintPageEventArgs)
                                     Dim bmp As New System.Drawing.Bitmap(panelIjazahOuter.Width, panelIjazahOuter.Height)
                                     panelIjazahOuter.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height))
                                     Dim margin As Single = 40.0!
                                     Dim maxW As Single = ev.PageBounds.Width - margin * 2
                                     Dim maxH As Single = ev.PageBounds.Height - margin * 2
                                     Dim scale As Single = Math.Min(maxW / bmp.Width, maxH / bmp.Height)
                                     Dim drawW As Single = bmp.Width * scale
                                     Dim drawH As Single = bmp.Height * scale
                                     Dim drawX As Single = margin + (maxW - drawW) / 2.0!
                                     Dim drawY As Single = margin + (maxH - drawH) / 2.0!
                                     ev.Graphics.DrawImage(bmp, New System.Drawing.RectangleF(drawX, drawY, drawW, drawH))
                                 End Sub
        Dim preview As New System.Windows.Forms.PrintPreviewDialog()
        preview.Document = pd
        preview.ShowDialog(Me)
    End Sub

    '── Tombol Close ──────────────────────────────────────────────────
    Private Sub btnCloseIjazah_Click(sender As Object, e As EventArgs) Handles btnCloseIjazah.Click
        Dim result As DialogResult = MessageBox.Show(
            "Yakin ingin keluar dari aplikasi?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class