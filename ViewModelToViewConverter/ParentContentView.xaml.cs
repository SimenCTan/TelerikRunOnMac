using ViewModelToViewConverter.ViewModels;

namespace ViewModelToViewConverter;

public partial class ParentContentView : ContentView
{
    private readonly ParentViewModel _viewModel;
	public ParentContentView(string pageTitle)
	{
		InitializeComponent();
        pageTitle = "View1";
        _viewModel = new ParentViewModel(pageTitle);
        BindingContext= _viewModel;
	}
}