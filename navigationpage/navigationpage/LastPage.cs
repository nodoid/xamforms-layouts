
using Xamarin.Forms;

namespace navigationpage
{
    public class LastPage : ContentPage
    {
        public LastPage()
        {
            // same again, new page, new title
            this.Title = "Page 4";

            // we now need to create something on the title bar. Here we will just add a back button
            this.ToolbarItems.Add(new ToolbarItem{ Command = new Command(async() => await Navigation.PopAsync()) });

            // let's have an icon on there now
            this.ToolbarItems.Add(new ToolbarItem{ Icon = new FileImageSource{ File = Device.OS == TargetPlatform.WinPhone ? "Assets/config.png" : "config.png" },
                Command = new Command(async() => await DisplayAlert("Hello", "You clicked me", "OK")) });

            Content = new StackLayout
            { 
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    new Label { Text = "All done navigating" }
                }
            };
        }
    }
}


