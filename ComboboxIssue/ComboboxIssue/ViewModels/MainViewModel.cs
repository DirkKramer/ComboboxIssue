using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace ComboboxIssue.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        List<string> items = ["Hey", "Hello", "Hi"];

        [ObservableProperty]
        string greeting = "Welcome to Avalonia!";
    }
}
