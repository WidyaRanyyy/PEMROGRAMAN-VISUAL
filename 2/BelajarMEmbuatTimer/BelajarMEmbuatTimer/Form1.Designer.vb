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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_loading = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1 - fade out
        '
        Me.Timer1.Interval = 30
        '
        'Timer2 - check close
        '
        Me.Timer2.Interval = 30
        '
        'Timer3 - fade in
        '
        Me.Timer3.Interval = 30
        '
        'Timer_loading - 10 detik loading
        '
        Me.Timer_loading.Enabled = True
        Me.Timer_loading.Interval = 10000
        '
        'PictureBox1 - animated loading GIF
        '
        Me.PictureBox1.Location = New System.Drawing.Point(220, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(80, 80)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 41)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "VISUAL STUDIO"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.BackColor = System.Drawing.Color.Transparent
        Me.lblYear.Font = New System.Drawing.Font("Segoe UI", 72.0!, System.Drawing.FontStyle.Bold)
        Me.lblYear.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblYear.Location = New System.Drawing.Point(60, 110)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(340, 130)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "2012"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(500, 320)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer_loading As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label

End Class
