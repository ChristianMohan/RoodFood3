using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoodFood3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BK : ContentPage
	{
		public BK ()
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundImage = "Menu.jpg";
        }

        protected async override void OnAppearing()
        {
            Random rng = new Random();
            int insult = rng.Next(1, 6);
            if (insult == 1)
            {
                Insult.Text = "Really? Burger King?";
            }

            if (insult == 2)
            {
                Insult.Text = "Try eating a salad for once";
            }

            if (insult == 3)
            {
                Insult.Text = "You'll probably have a heart attack before you get there...";
            }

            if (insult == 4)
            {
                Insult.Text = "I got diabetes just by looking at this menu";
            }

            if (insult == 5)
            {
                Insult.Text = "you have better food in your trash";
            }

            if (insult == 6)
            {
                Insult.Text = "Try eating a salad for once";
            }

            if (insult == 7)
            {
                Insult.Text = "Try eating a salad for once";
            }

            if (insult == 8)
            {
                Insult.Text = "Try eating a salad for once";
            }

            if (insult == 9)
            {
                Insult.Text = "Try eating a salad for once";
            }

            if (insult == 10)
            {
                Insult.Text = "Try eating a salad for once";
            }

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}