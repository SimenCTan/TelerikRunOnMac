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
        if (Title == "ParentView2")
        {
            Title = "ParentView1";
        }
        else
        {
            Title = "ParentView2";
        }
	}
}

