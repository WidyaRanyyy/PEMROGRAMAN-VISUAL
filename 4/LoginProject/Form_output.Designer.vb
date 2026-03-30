<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_output
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.user_name = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic)
        Me.user_name.Location = New System.Drawing.Point(130, 90)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(103, 24)
        Me.user_name.TabIndex = 0
        Me.user_name.Text = "user_name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(80, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELAMAT DATANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(90, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Semoga hari harinya menyenangkan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form_output
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 270)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user_name)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form_output"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selamat Datang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents user_name As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
