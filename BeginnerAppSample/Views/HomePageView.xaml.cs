using System;
using System.Collections.Generic;
using Xamarin.Forms;
using BeginnerAppSample.ViewModels;

namespace BeginnerAppSample.Views
{	
	public partial class HomePageView : ContentPage
	{	
		public HomePageView ()
		{
			InitializeComponent ();
			BindingContext = new HomePageViewModel ();
		}
	}
}

