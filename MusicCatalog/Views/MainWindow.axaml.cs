using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MusicCatalog.ViewModels;

namespace MusicCatalog;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void AddHandler(object sender, RoutedEventArgs args)
    {
        var source = recordsTable.ItemsSource = new AvaloniaList<Record>
            {
                new Record("Add", "Works"),
            };
        message.Text = "Button clicked!";
    }

    public void DeleteHandler(object sender, RoutedEventArgs args)
    {
    }
}