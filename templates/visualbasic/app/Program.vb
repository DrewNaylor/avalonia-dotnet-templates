Imports System
Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Controls.ApplicationLifetimes

Namespace AvaloniaAppTemplate
    Class Program
        ' Initialization code. Don't use any Avalonia, third-party APIs or any
        ' SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        ' yet and stuff might break.
        Public Shared Sub Main(ByVal args As String())
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args)
        End Sub

        ' Avalonia configuration, don't remove; also used by visual designer.
        Public Shared Function BuildAvaloniaApp() As AppBuilder
            Return AppBuilder.Configure(Of App)().UsePlatformDetect().LogToTrace
        End Function
    End Class
End Namespace