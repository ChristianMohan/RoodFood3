using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace RoodFood3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundImage = "image.jpg";
           
        }




        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new McDPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WendyPage());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BK());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaneraPage());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }
    }
}
