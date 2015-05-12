using System;

using Xamarin.Forms;
using Refractored.Xam.Settings;

namespace freetelec
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			Clavier.CodeHD1 = CrossSettings.Current.GetValueOrDefault<int>("codehd1");
			MainPage = new NavigationPage(new Clavier()  { Icon = "drawable/icon.png" } );

			// info mail help pip
			// epg media options
			// vol_inc vol_dec
			// prgm_inc prgm_dec
			// ok
			// up right down left
			// mute home rec bwd (ret arr)
			// prev play fwd
			// next
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}


	}
}

