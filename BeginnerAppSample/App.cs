using System;
using Xamarin.Forms;

namespace BeginnerAppSample
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage (new HomePage ());
		}
	}
}

