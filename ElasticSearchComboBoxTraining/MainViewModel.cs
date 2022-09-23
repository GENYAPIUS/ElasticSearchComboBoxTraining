using System.Collections.ObjectModel;
using WPFLibrary;

namespace ElasticSearchComboBoxTraining;

public class MainViewModel : NotifyPropertyBase
{
    public MainViewModel()
    {
        Options = GetOptions();
    }

    private ObservableCollection<string> _options = new();

    public ObservableCollection<string> Options
    {
        get => _options;
        set => SetProperty(ref _options, value);
    }

    private ObservableCollection<string> GetOptions()
    {
        return new ObservableCollection<string>()
        {
            "Option1",
            "Option2",
            "Option3"
        };
    }
}