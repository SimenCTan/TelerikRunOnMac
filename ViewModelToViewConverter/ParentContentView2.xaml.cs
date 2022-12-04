using ViewModelToViewConverter.ViewModels;

namespace ViewModelToViewConverter;

public partial class ParentContentView2 : ContentView
{
    private readonly ParentViewModel _viewModel;
    public ParentContentView2(string pageTitle)
	{
		InitializeComponent();
        pageTitle = "View2";
        _viewModel = new ParentViewModel(pageTitle);
        BindingContext = _viewModel;
    }
}