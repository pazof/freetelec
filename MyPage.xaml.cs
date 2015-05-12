using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;


namespace freetelec
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();

			// http://hd1.freebox.fr/pub/remote_control?key=&code=&long=&repeat=
			// http://www.universfreebox.com/article/10808/Comment-creer-un-telecommande-virtuelle-pour-la-Freebox
				
			// appui long : long=true
			// repetition: repeat=3

			Keys = new Dictionary<object, string> ();
			Keys.Add (bt_1, "1");
			Keys.Add (bt_2, "1");
			Keys.Add (bt_3, "1");
			Keys.Add (bt_4, "1");
			Keys.Add (bt_5, "1");
			Keys.Add (bt_6, "1");
			Keys.Add (bt_7, "1");
			Keys.Add (bt_8, "1");
			Keys.Add (bt_9, "1");
			Keys.Add (bt_0, "1");
			Keys.Add (bt_red, "red");
			Keys.Add (bt_green, "green");
			Keys.Add (bt_blue, "blue");
			Keys.Add (bt_yellow, "yellow");
			Keys.Add (bt_up, "up");
			Keys.Add (bt_down, "down");
			Keys.Add (bt_left, "left");
			Keys.Add (bt_right, "right");
			Keys.Add (bt_tv, "tv");
			Keys.Add (bt_power, "power");
			Keys.Add (bt_home, "home");
			Keys.Add (bt_vol_inc, "vol_inc");
			Keys.Add (bt_vol_dec, "vol_dec");
			Keys.Add (bt_prgm_inc, "prgm_inc");
			Keys.Add (bt_prgm_dec, "prgm_dec");
			Keys.Add (bt_ok, "ok");
			Keys.Add (bt_mute, "mute");
			Keys.Add (bt_rec, "rec");
			Keys.Add (bt_prev, "prev");
			Keys.Add (bt_next, "next");
			Keys.Add (bt_fwd, "fwd");
			Keys.Add (bt_bwd, "bwd");
			Keys.Add (bt_play, "play");

		}

		void KeyHit(string key, bool lgHit=false, int repeat=1) {
			HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create (
				                    string.Format (
					                    "http://hd1.freebox.fr/pub/remote_control?code={0}&key={1}",
					                    "41322886",	key));
			rq.BeginGetResponse (OnHdResponse, rq);
		}

		Dictionary<object,string> Keys;

		void OnKeyClick(object sender, EventArgs e)
		{
			if (Keys.ContainsKey (sender))
				KeyHit (Keys [sender]);
			else
				Debug.WriteLine ("unknown Button"); 
		}

		void OnHdResponse(IAsyncResult result)
		{
			HttpWebRequest rq = (HttpWebRequest) result.AsyncState;
			rq.Abort ();
		}

	}
}

