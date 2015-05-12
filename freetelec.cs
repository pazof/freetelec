using System;

using Xamarin.Forms;

namespace freetelec
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new MyPage();

			// power list tv
			// 0-9
			// back swap
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

