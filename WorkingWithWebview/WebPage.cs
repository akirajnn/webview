using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
            browser.Source = "https://www.ylh.gov.tw/ylh/service/bloodreg/index.php";
            Content = browser;
        }
    }
}

