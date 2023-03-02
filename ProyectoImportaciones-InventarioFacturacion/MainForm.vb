Imports System.Threading

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim obj As New SplashScreen
        Dim startSplash = obj.create(My.Resources.splashLogo.Size.Width, My.Resources.splashLogo.Size.Height, My.Resources.splashLogo)

        startSplash.Show()
        Thread.Sleep(3000)
        startSplash.Close()

        Me.Activate()

    End Sub
End Class