using Microsoft.Maui.Controls;
namespace TallerLayout
{
    public partial class StackLayoutDemo : ContentPage
    {
        public StackLayoutDemo()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FlexLayoutPage()));
        }


    }
}



