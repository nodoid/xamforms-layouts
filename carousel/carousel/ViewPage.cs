using Xamarin.Forms;

namespace carousel
{
    public class ViewPage : ContentPage
    {
        public ViewPage()
        {
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);

            // let's get a page title from the binding context created when the carousel rotates
            this.SetBinding(ContentPage.TitleProperty, "Title");

            // create the image and bind to the ImageName property
            var imgView = new Image();
            imgView.SetBinding(Image.SourceProperty, "ImageName");

            Content = new StackLayout
            { 
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    imgView
                }
            };
        }
    }
}


