using Microsoft.Maui.Layouts;

namespace TallerLayout;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
        InitializeComponent();
      
        for (int i = 0; i < 10; i++)
        {
          
            Image imagen = new Image { Source = "dotnet_bot.png" };
            Label texto = new Label { Text = $"Elemento {i + 1}" };

            
            imagen.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
              
                    Navigation.PushAsync(new AbsoluteLayout());
                })
            });

        }
    }
}