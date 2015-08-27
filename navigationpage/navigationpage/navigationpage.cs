using System;

using Xamarin.Forms;

namespace navigationpage
{
    public class App : Application
    {
        public App()
        {
            // we need to start a new NavigationPage. This is achieved in pretty much the same way
            // as you would any other new page
            MainPage = new NavigationPage(new NavPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

