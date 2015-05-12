using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace freetelec
{
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
			entCode.Keyboard = Keyboard.Numeric;
			entCode.Text = Clavier.CodeHD1.ToString ();
			entCode.Completed += (object sender, EventArgs e) => 
			{
				int code;
				if (int.TryParse(entCode.Text,out code)) {
					Clavier.CodeHD1 = code;
				}
				// else Assert(false) // the keyboard type is numeric;
			};
		}
	}
}

