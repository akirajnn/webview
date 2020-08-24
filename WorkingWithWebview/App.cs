using Xamarin.Forms;

namespace WorkingWithWebview
{
	public class App : Application
	{
		public App ()
		{
			var tabs = new TabbedPage ();
			tabs.Children.Add (new WebPage { Title = "預約抽血宅急便"});
			tabs.Children.Add (new WebPage { Title = "抽血號碼報你知"});
			MainPage = tabs;
		}
	}
}
