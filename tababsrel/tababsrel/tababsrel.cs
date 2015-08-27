using System;

using Xamarin.Forms;

namespace tababsrel
{
    public class App : Application
    {
        public App()
        {
            // we're going to create a tab page to start with. One tab will contain the absolute view, the other relative
            // as always, we tell the MainPage the type of page to expect.
            // what is important here is that normally, we'd say to expect a NavigationPage or a MasterContent page
            // a TabbedPage only requires you to say you want a new page
            MainPage = new TabPage();
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

