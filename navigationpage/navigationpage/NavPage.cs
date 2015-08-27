using System;

using Xamarin.Forms;

namespace navigationpage
{
    public class NavPage : ContentPage
    {
        public NavPage()
        {
            // a bit of padding for iOS
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);

            // a navigation bar can have the bar visible, or not visible
            // here, it will be set as not visible

            NavigationPage.SetHasNavigationBar(this, false);

            var btn = new Button
            {
                Text = "Click here for the next page"
            };
            btn.Clicked += async delegate
            {
                // For Android, to push a page async, we need to use the Navigation system - it's not 
                // available normally.
                await Navigation.PushAsync(new SecondPage());
            };

            Content = new StackLayout
            { 
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    btn
                }
            };
        }
    }
}


