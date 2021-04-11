Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Namespace AvaloniaAppTemplate
    Partial Public Class MainWindow
	Inherits Window
        Public Sub New()
            InitializeComponent()
'-:cnd:noEmit
#If DEBUG Then
            Me.AttachDevTools()
#End If
'+:cnd:noEmit
        End Sub

        Private Sub InitializeComponent()
            AvaloniaXamlLoader.Load(Me)
        End Sub
    End Class
End Namespace