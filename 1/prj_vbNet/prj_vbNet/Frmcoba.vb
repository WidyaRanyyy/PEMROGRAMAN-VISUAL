Imports System
Imports System.Windows.Forms

Public Class Frmcoba

    Private Sub btntampilkan_Click(sender As Object, e As EventArgs) Handles btntampilkan.Click
        If txtnama.Text = "" Or cbojeniskelamin.Text = "" Or cbofakultas.Text = "" Then
            MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Nama: " & txtnama.Text & Environment.NewLine &
                        "Jenis Kelamin: " & cbojeniskelamin.Text & Environment.NewLine &
                        "Fakultas: " & cbofakultas.Text,
                        "Hasil Pengisian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        End If
    End Sub
End Class
