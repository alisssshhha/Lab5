using System.Collections.ObjectModel;
using Avalonia.Collections;

namespace MusicCatalog.ViewModels;

public class MainWindowViewModel : ViewModelBase {
    public ObservableCollection<Record> Records { get; }

        public MainWindowViewModel()
        {
            var records = new AvaloniaList<Record>
            {
                new Record("Neil", "Armstrong"),
                new Record("Buzz", "Lightyear"),
                new Record("James", "Kirk")
            };
            Records = new ObservableCollection<Record>(records);
        }
}