using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Choices;

namespace Choices
{
	[Activity (Label = "Choices", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		Button Menu1;
		Button Menu2;
		TextView Result1;
		TextView Result2;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//Find our controls
			Menu1 = FindViewById<Button> (Resource.Id.Menu1);
			Menu2 = FindViewById<Button> (Resource.Id.Menu2);

			// wire up add task button handler
			if(Menu1 != null) {
				Menu1.Click += (sender, e) => {
				StartActivity(typeof(ChoiceActivity));
				};
			}		
		}

		protected override void OnResume ()
		{
			base.OnResume ();
		}
	}
}


