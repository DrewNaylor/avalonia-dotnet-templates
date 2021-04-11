Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml

Namespace AvaloniaAppTemplate
    Public Class App 
	    Inherits Application
        Public Overrides Sub Initialize()
            AvaloniaXamlLoader.Load(Me)
        End Sub

        Public Overrides Sub OnFrameworkInitializationCompleted()
            If (ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime desktop) Then
                desktop.MainWindow = New MainWindow()
            End If

            MyBase.OnFrameworkInitializationCompleted()
        End Sub
		End Class
End Namespace