using Xamarin.Forms;
using masterwebview;
using Foundation;

[assembly: Dependency(typeof(Webview))]
namespace masterwebview.iOS
{
    public class Webview : IWebUrl
    {
        public string GetBaseUrl()
        {
                return NSBundle.MainBundle.BundlePath;
        }
    }
}

