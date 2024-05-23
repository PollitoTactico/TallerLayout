namespace TallerLayout;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private async void ButtonClicked2(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new GridLayout()));
    }
}