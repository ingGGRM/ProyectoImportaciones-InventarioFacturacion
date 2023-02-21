Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = System.Drawing.Color.Transparent
    End Sub

End Class