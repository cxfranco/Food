using Food.Mobile.Views.Contact;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Food.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new StackLayout();
            //MainPage = new GridLayoutPage();

            //MainPage = new ContactPage();
            MainPage = new ContactsPage();
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
