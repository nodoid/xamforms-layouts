
using Xamarin.Forms;

namespace navigationpage
{
    public class ThirdPage : ContentPage
    {
        public ThirdPage()
        {   
            // same again, new page, new title
            this.Title = "Page 3";

            // we now need to create something on the title bar. Here we will just add a back button
            this.ToolbarItems.Add(new ToolbarItem{ Command = new Command(async() => await Navigation.PopAsync()), Order = ToolbarItemOrder.Primary });

            // we'll create anothing button slightly differently as we want to do something else to the event
            // notice where the Secondary position is though - it's not where you would expect
            var toolbarItem = new ToolbarItem
            {
                Text = "Click",
                Order = ToolbarItemOrder.Secondary,
            };
            toolbarItem.Clicked += async delegate
            {
                await DisplayAlert("Clicked", "You have clicked the icon", "OK");
            };

            // add to the toolbar
            this.ToolbarItems.Add(toolbarItem);

            var btn = new Button
            {
                Text = "Click here for the next page"
            };
            btn.Clicked += async delegate
            {
                // For Android, to push a page async, we need to use the Navigation system - it's not 
                // available normally.
                await Navigation.PushAsync(new LastPage());
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


