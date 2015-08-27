using Xamarin.Forms;

namespace scrollview
{
    public class App : Application
    {
        public App()
        {
            var titleLabel = new Label()
            {
                Text = "SONG FOR A MISERABLE MUSICAL",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24
            };
            var scrollView = new ScrollView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = new Label()
                { Text = "Where has it gone\n" +
                    "The passion the pain\n" +
                    "Days when the sun\n" +
                    "Followed the rain\n" +
                    "Where have they gone\n" +
                    "The days that we knew\n" +
                    "When the sun always shone\n" +
                    "On me and you.\n\n" +
                    "Where have they gone\n" +
                    "The friends that we knew\n" +
                    "When money was easy\n" +
                    "And problems were few\n" +
                    "Where have they gone\n" +
                    "Will we see them again\n" +
                    "Days without sun\n" +
                    "Eyes filled with pain.\n\n" +
                    "Where has she gone\n" +
                    "The girl that I loved\n" +
                    "To bring back the sun\n" +
                    "Bring back the love\n" +
                    "Will she come home\n" +
                    "Where could she be\n" +
                    "My days are all empty\n" +
                    "When she's not with me.",
                    TextColor = Color.Green
                }
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(8, 20, 0, 0),
                    Children =
                    {
                        titleLabel, scrollView
                    }
                }
            };
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

