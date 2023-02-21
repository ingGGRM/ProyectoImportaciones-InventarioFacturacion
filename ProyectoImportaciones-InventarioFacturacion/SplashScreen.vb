Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.AllowTransparency = True
        Me.BackColor = Color.Gray
        PictureBox1.BackColor = Me.BackColor
        Me.TransparencyKey = Me.BackColor

    End Sub

End Class