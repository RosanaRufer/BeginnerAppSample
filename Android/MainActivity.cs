using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Com.Mixpanel.Android.Mpmetrics;


namespace BeginnerAppSample.Android
{
	[Activity (Label = "BeginnerAppSample.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate (Bundle bundle)
		{

			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			// Mixpanel example
			MixpanelAPI mixpanelAPI = MixpanelAPI.GetInstance (Forms.Context, "bf1cea4e07f277a1ce87f8cb99ba2e04"); //MIXPANEL_APPLICATION_TOKEN
			MixpanelAPI.IPeople newMixpanelProfile = mixpanelAPI.People;

			//Here you can add as many properties to identify the user as you wish using the method people.Set(string key, string value);
			newMixpanelProfile.Identify ("TEST");
			newMixpanelProfile.Set ("$phone", "778777");
			newMixpanelProfile.InitPushHandling ("AIzaSyDWS3i99oBqy7hM3aggLENK4Km-Cx5lCP4"); //ANDROID_GOOGLE_API_TOKEN


			SetPage (App.GetMainPage ());
		}

		protected override void OnDestroy ()
		{
			var mixpanelAPI = MixpanelAPI.GetInstance (this, "bf1cea4e07f277a1ce87f8cb99ba2e04" );
			mixpanelAPI.Flush ();
			base.OnDestroy ();
		}

	}
}

