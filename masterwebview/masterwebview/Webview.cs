using System;

using Xamarin.Forms;

namespace masterwebview
{
    public class Webview : ContentPage
    {
        public Webview(string url)
        {
            var webView = new WebView()
            {
                Source = url,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { webView }
            };
        }
    }
}


