using System;

namespace BeginnerAppSample.Services.Contracts
{
	public interface INavigationService
	{
		void NavigateToView (AppConstants.AppViews enumView);

		void NavigateToPreviousView ();

		void NavigateToPreviousViewModal ();
	}
}

