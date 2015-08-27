
using Xamarin.Forms;
using System.Collections.Generic;

namespace masterwebview
{
    public class MasterPageList
    {
        public string Text { get; set; }

        public string Url { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class MasterPageView : MasterDetailPage
    {
        public MasterPageView()
        {
            // The master page is essentially the page that acts as a menu to serve up a webpage.

            // create a label for the top of the master page

            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);

            var header = new Label
            {
                Text = "MasterPageView",
                FontSize = 28,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                HorizontalOptions = LayoutOptions.Center
            };

            // let's create a list. The list will be used to launch the webpages

            var listOptions = new List<MasterPageList>
            {
                new MasterPageList{ Text = "Packt website", Url = "https://www.packtpub.com" },
                new MasterPageList{ Text = "Farmtrack Live", Url = "http://www.farmapps.co.uk" },
                new MasterPageList{ Text = "Henry Crunn", Url = "" }
            };

            // create the ListView - this is explained later in the book more fully in the What A Bind chapter

            var listView = new ListView
            {
                ItemsSource = listOptions.ToArray()
            };

            // create the master page
            Master = new ContentPage
            {
                Title = "Webviewer",
                Content = new StackLayout
                {
                    Children =
                    {
                        header, listView
                    }
                }
            };

            // we now need to tell the page launcher which page to launch. We get this information from the ListView

            Detail = new NavigationPage(new WebLauncherPage());

            listView.ItemSelected += LaunchPage;

            // the final step is to enable some method to get out of the detail page. iOS handles this without an issue
            // but we need something in for Android and Windows Mobile

            if (Device.OS != TargetPlatform.iOS)
            {
                var tap = new TapGestureRecognizer();
                tap.Tapped += (sender, args) =>
                {
                    IsPresented = true;
                };
            }
        }

        void LaunchPage(object s, SelectedItemChangedEventArgs e)
        {
            var binding = e.SelectedItem as MasterPageList;

            // we need to now see what the URL has in it. If the url is empty, we need to launch the generated webview
            // as we don't actually have a page to point to, we need to create an instance of the type of page being pointed to

            Detail = string.IsNullOrEmpty(binding.Url) ? new NavigationPage(new WebviewGenerated()) :
                new NavigationPage(new Webview(binding.Url));

            // show the distribution page

            IsPresented = false;
        }
    }
}


