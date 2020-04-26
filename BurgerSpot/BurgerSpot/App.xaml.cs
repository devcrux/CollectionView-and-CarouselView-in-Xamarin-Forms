using BurgerSpot.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("BebasNeue.ttf", Alias = "ThemeFont")]
[assembly: ExportFont("Roboto.ttf", Alias = "LightFont")]
namespace BurgerSpot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
