using Microsoft.Maui.Layouts;

namespace TallerLayout;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
        InitializeComponent();
      
       
        
    }

    private async void OnImageButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new NavigationPage(new AbsoluteLayout()));
    }
}