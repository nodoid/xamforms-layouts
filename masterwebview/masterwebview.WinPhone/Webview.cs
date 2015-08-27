using masterwebview;
using Xamarin.Forms;

[assembly: Dependency(typeof(Webview))]
namespace masterwebview.WinPhone
{
    public class Webview : IWebUrl
    {
        public string GetBaseUrl()
        {
                return "Assets/"; // this is where you set the local content - if it is empty, it is in the root of the app
        }
    }
}
