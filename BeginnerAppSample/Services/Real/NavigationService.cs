using System;
using BeginnerAppSample.Services.Contracts;
using Xamarin.Forms;

namespace BeginnerAppSample.Services.Real
{
	public class NavigationService:INavigationService
	{
		private TargetPlatform _targetPlatform;

		public NavigationService ()
		{
			_targetPlatform = Device.OS;
		}

		public async void NavigateToView (AppConstants.AppViews enumView)
		{
			var view = GetViewFromEnumView (enumView);
			if (IsRootPage (view)) {
				await CurrentPageService.Instance.CurrentPage.Navigation.PushModalAsync (new NavigationPage (view));
			} else
				await CurrentPageService.Instance.CurrentPage.Navigation.PushAsync (view);
		}

		public async void NavigateToPreviousView ()
		{
			await CurrentPageService.Instance.CurrentPage.Navigation.PopAsync ();
		}

		public async void NavigateToPreviousViewModal ()
		{
			await CurrentPageService.Instance.CurrentPage.Navigation.PopModalAsync ();
		}

		private Page GetViewFromEnumView (AppConstants.AppViews enumView)
		{
			Page viewPage = null;

			// Return the appropiated view based on the requested view
			//switch (enumView) {
			//}

			return viewPage;
		}

		private bool IsRootPage (Page page)
		{
			return page == CurrentPageService.Instance.RootPage;
		}
	}
}

