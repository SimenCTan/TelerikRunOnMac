namespace ViewModelToViewConverter;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        if (Title == "View2")
        {
            Title = "View1";
        }
        else
        {
            Title = "View2";
        }
	}
}

