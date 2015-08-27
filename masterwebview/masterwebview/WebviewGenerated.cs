using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace masterwebview
{
    public class WebviewGenerated : ContentPage
    {
        public WebviewGenerated()
        {
            var webView = new WebView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            // let's have some table data
            var dataList = new Dictionary<string, string>
            {
                { "Name", "Henry Crunn" },
                { "Address", "2, The Spon, Neesden" },
                { "Favourite food", "Spinach" },
                { "Favourite person", "Minnie Bannister" },
                { "Would like to live", "In a pineapple, under the sea" },
                { "Listens to","The sound of my pulse" }
            };

            // generate the table

            var tableData = new StringBuilder();
            tableData.Append("<table>");
            foreach (var info in dataList)
                tableData.Append(string.Format("<tr><td width=\"25%\">{0}</td><td width=\"75%\">{1}</td></tr>", info.Key, info.Value));
            tableData.Append("</table>");

            // create the web page - remember for this to work, the Base URL must be implemented on all
            // platforms included

            var htmlPageSource = new HtmlWebViewSource();
            var url = DependencyService.Get<IWebUrl>().GetBaseUrl();
            htmlPageSource.BaseUrl = url;
            htmlPageSource.Html = @"<html><head>
                    <title>Test webview</title>
                    <link rel=""stylesheet"" href=""myCSS.css"">
                        </head>
                        <body>
<h1 div id=""mainTitle"">It's all about Henry</h1>
<p>Henry Crunn is a mild mannered octagenarian who still has many of his own teeth. We interviewed him in the 
middle of East Acton High Street and asked him some questions. His replies are quite inciteful</p>" +
            tableData.ToString() +
            "<br /><p>Henry Crunn, thank you</p> <img src=\"Images/henrycrunn.png\" /> </body></html>";

            // add this to the webview
            webView.Source = htmlPageSource;

            Content = webView;
        }
    }
}


