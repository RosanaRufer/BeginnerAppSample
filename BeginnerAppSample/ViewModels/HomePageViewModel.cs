using System;
using Xamarin.Forms;
using BeginnerAppSample.ViewModels.Base;

namespace BeginnerAppSample.ViewModels
{
	public class HomePageViewModel : ViewModelBase
	{
		public HomePageViewModel ()
		{
			NavigateToFirstViewCommand = new Command (NavigateToFirstView);
		}

		public Command NavigateToFirstViewCommand { get; set;}

		public void NavigateToFirstView()
		{
			NavigationService.NavigateToView (AppConstants.AppViews.FirstView);
		}
	}
}

