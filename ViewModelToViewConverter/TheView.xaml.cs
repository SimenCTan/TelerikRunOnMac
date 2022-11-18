using System.Diagnostics;
using ViewModelToViewConverter.ViewModels;

namespace ViewModelToViewConverter;

public partial class TheView : ContentView
{
    private ContentViewModel _viewModel;
    public TheView()
	{
        // Starting the Stopwatch
        var watch = Stopwatch.StartNew();
        InitializeComponent();
        _viewModel = new ContentViewModel();
        BindingContext = _viewModel;
        // Stop the Stopwatch
        watch.Stop();
        _viewModel.WatchMS = watch.ElapsedMilliseconds;
    }
}