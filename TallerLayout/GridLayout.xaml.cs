namespace TallerLayout;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new StackLayoutDemo()));
    }
}