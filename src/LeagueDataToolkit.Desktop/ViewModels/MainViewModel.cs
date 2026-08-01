using CommunityToolkit.Mvvm.ComponentModel;

namespace LeagueDataToolkit.Desktop.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
