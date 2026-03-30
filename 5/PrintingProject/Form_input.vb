Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Form_input
    Inherits Form

    ' ============================================================
    ' Deklarasi variabel sesuai modul
    ' ============================================================
    Dim nama_lengkap, no_hp, jurusan1, jurusan2, kajur As String

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    ' ============================================================
    ' Form Load: hubungkan PrintDocument dengan PrintPreviewDialog
    ' ============================================================
    Private Sub Form_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
    End Sub

    ' ============================================================
    ' CheckBox: aktifkan/nonaktifkan tombol Cetak
    ' ============================================================
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    ' ============================================================
    ' Button Cetak: ambil data lalu tampilkan Print Preview
    ' ============================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nama_lengkap = Text_nama.Text
        no_hp = Text_no_hp.Text
        jurusan1 = Combo_jurusan.Text

        If jurusan1 = "TI" Then
            jurusan2 = "Teknik Informatika"
            kajur = "Awang Harsa K, M.Kom"
        ElseIf jurusan1 = "SI" Then
            jurusan2 = "Sistem Informatika"
            kajur = "Indah Fitri Astuti, M.Kom"
        ElseIf jurusan1 = "MI" Then
            jurusan2 = "Manajemen Informatika"
            kajur = "Dedy Cahyadi, M.Kom"
        End If

        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    ' ============================================================
    ' PrintPage: gambar isi dokumen cetak
    ' ============================================================
    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim f As Font = New Font("Calibri", 14, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black)                 'p  = adalah warna garis kotak

        e.Graphics.DrawString("Nama      : " + nama_lengkap, f, br, 60, 60)
        e.Graphics.DrawString("Jurusan   : " + jurusan1, f, br, 60, 90)
        e.Graphics.DrawString("Nomor HP  : " + no_hp, f, br, 60, 120)

        e.Graphics.DrawString("Ketua Jurusan " + kajur, f, br, 110, 180)
        e.Graphics.DrawString("Universitas Mulawarman", f, br, 110, 200)

        e.Graphics.DrawRectangle(p, 50, 50, 400, 200)
    End Sub

End Class
