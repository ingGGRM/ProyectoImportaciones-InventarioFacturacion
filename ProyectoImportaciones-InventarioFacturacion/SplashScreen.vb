''' <summary>
''' This class provides an easy way to create a splashScreen form
''' </summary>
Public Class SplashScreen
    Function create(ByVal Width, ByVal Height, ByVal image)
        Dim splashFrm As New Form

        splashFrm.Width = Width
        splashFrm.Height = Height

        splashFrm.AllowTransparency = True
        splashFrm.StartPosition = FormStartPosition.CenterScreen
        splashFrm.TransparencyKey = splashFrm.BackColor
        splashFrm.FormBorderStyle = FormBorderStyle.None

        'splashFrm.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'splashFrm.BackColor = Color.FromArgb(120, 255, 0, 0)

        splashFrm.BackgroundImage = image

        Return splashFrm

    End Function
End Class
