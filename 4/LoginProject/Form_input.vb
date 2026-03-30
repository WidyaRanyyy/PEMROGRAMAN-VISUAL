Imports System.Windows.Forms

Public Class Form_input

    ' ============================================================
    ' SCRIPT UTAMA: Login dengan 1 user
    ' ============================================================
    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '     If Text_user.Text = "aulia" And Text_password.Text = "123456" Then
    '         login_berhasil()
    '     End If
    ' End Sub
    '
    ' Private Sub login_berhasil()
    '     Form_output.user_name.Text = Text_user.Text()
    '     Form_output.Show()
    ' End Sub
    ' ============================================================

    ' ============================================================
    ' SCRIPT LANJUTAN: Login dengan password salah (MsgBox)
    ' ============================================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Text_user.Text = "aulia" And Text_password.Text = "123456") Then
            login_berhasil()
        Else
            MsgBox("maaf password salah")
        End If
    End Sub

    ' ============================================================
    ' CONTOH: Login dengan 2 akun menggunakan OR
    ' ============================================================
    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '     If Text_user.Text = "aulia" And Text_password.Text = "123456" Or _
    '        Text_user.Text = "doni" And Text_password.Text = "123456" Then
    '         login_berhasil()
    '     End If
    ' End Sub
    ' ============================================================

    Private Sub login_berhasil()
        Form_output.user_name.Text = Text_user.Text()
        Form_output.Show()
    End Sub

End Class
