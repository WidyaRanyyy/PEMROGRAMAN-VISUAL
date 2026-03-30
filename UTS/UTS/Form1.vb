Public Class Form1

    '── Warna tema pink ───────────────────────────────────────────────
    Private ReadOnly PinkAccent As System.Drawing.Color = System.Drawing.Color.FromArgb(212, 83, 126)
    Private ReadOnly PinkHover As System.Drawing.Color = System.Drawing.Color.FromArgb(180, 60, 100)
    Private ReadOnly RedNormal As System.Drawing.Color = System.Drawing.Color.FromArgb(204, 68, 68)
    Private ReadOnly RedHover As System.Drawing.Color = System.Drawing.Color.FromArgb(170, 40, 40)

    '── Load form ─────────────────────────────────────────────────────
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Garis dekoratif atas panelForm
        AddHandler panelForm.Paint, AddressOf panelForm_Paint
        ' Hover effect tombol
        AddHandler btnCetak.MouseEnter, Sub() btnCetak.BackColor = PinkHover
        AddHandler btnCetak.MouseLeave, Sub() btnCetak.BackColor = PinkAccent
        AddHandler btnClose.MouseEnter, Sub() btnClose.BackColor = RedHover
        AddHandler btnClose.MouseLeave, Sub() btnClose.BackColor = RedNormal
    End Sub

    '── Garis dekoratif atas panelForm ────────────────────────────────
    Private Sub panelForm_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs)
        Using pen As New System.Drawing.Pen(PinkAccent, 4)
            e.Graphics.DrawLine(pen, 0, 0, panelForm.Width, 0)
        End Using
    End Sub

    '── Tombol Cetak ──────────────────────────────────────────────────
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ' Validasi semua field
        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtNim.Text) OrElse
           String.IsNullOrWhiteSpace(txtAngkatan.Text) OrElse
           cmbProdi.SelectedIndex < 0 OrElse
           String.IsNullOrWhiteSpace(txtIpk.Text) Then

            MessageBox.Show("Harap lengkapi semua data terlebih dahulu!",
                            "Data Tidak Lengkap",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi nilai IPK
        Dim ipk As Double
        Dim ipkText As String = txtIpk.Text.Replace(",", ".")
        If Not Double.TryParse(ipkText,
                               System.Globalization.NumberStyles.Any,
                               System.Globalization.CultureInfo.InvariantCulture,
                               ipk) OrElse ipk < 0 OrElse ipk > 4 Then
            MessageBox.Show("IPK harus berupa angka antara 0 sampai 4.",
                            "IPK Tidak Valid",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        ' Buka FormIjazah dengan data yang diinput
        Dim fIjazah As New FormIjazah(
            nama:=txtNama.Text.Trim(),
            nim:=txtNim.Text.Trim(),
            prodi:=cmbProdi.SelectedItem.ToString(),
            angkatan:=txtAngkatan.Text.Trim(),
            ipk:=ipk
        )
        fIjazah.ShowDialog(Me)
    End Sub

    '── Tombol Close ──────────────────────────────────────────────────
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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