using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Button hellobtn = new Button
            {
                Text = "Navigate",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };
            Button plusbtn = new Button
            {
                Text = "Plus",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            hellobtn.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new HelloXamlPagexaml());
            };
            plusbtn.Clicked += async (sender, args) =>
             {
                 await Navigation.PushAsync(new XamlPlusCodePage());
             };
            Content = hellobtn;
            Content = plusbtn;
		}
        
    }
}
