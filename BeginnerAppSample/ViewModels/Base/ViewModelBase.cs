using System;
using BeginnerAppSample.Services.Contracts;
using BeginnerAppSample.Services.Real;

namespace BeginnerAppSample.ViewModels.Base
{
	public class ViewModelBase
	{
		protected INavigationService NavigationService = new NavigationService ();
	}
}

