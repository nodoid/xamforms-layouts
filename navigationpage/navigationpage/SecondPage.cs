
using Xamarin.Forms;

namespace navigationpage
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            // this time, we will have a bar with a title
            this.Title = "Page 2";

            // we now need to create something on the title bar. Here we will just add a back button. Here we don't need the text Back
            this.ToolbarItems.Add(new ToolbarItem{ Command = new Command(async () => await Navigation.PopAsync()), Order = ToolbarItemOrder.Primary });

            var btn = new Button
            {
                Text = "Click here for the next page"
            };
            btn.Clicked += async delegate
            {
                // For Android, to push a page async, we need to use the Navigation system - it's not 
                // available normally.
                await Navigation.PushAsync(new ThirdPage());
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


