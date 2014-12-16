using System;
using Xamarin.Forms;
using BeginnerAppSample.Views;

namespace BeginnerAppSample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			var homePageView = new HomePageView ();

			CurrentPageService.Instance.CurrentPage = homePageView;

			return new NavigationPage (homePageView);
		}
	}
}

