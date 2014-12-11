using System;
using Xamarin.Forms;

namespace BeginnerAppSample
{
	public class CurrentPageService
	{	
		private static readonly CurrentPageService _instance = new CurrentPageService();

			static CurrentPageService()
			{

			}

			private CurrentPageService()
			{

			}

			public static CurrentPageService Instance
			{
				get { return _instance; }
			}

			public Page RootPage { get; set; }

			public Page CurrentPage { get; set; }
	}
}

