using Xamarin.Forms;
using masterwebview;

[assembly: Dependency(typeof(Webview))]
namespace masterwebview.Droid
{
    public class Webview : IWebUrl
    {
        public string GetBaseUrl()
        {
                return "file:///android_asset";
        }
    }
}

