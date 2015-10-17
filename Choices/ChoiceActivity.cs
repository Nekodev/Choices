
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Choices
{
	[Activity (Label = "Activity2")]			
	public class ChoiceActivity : Activity
	{

		TextView Choice1;
		TextView Choice2;
		public int Choice1count=0;
		public int Choice2count=0;

		protected override void OnCreate (Bundle bundle)
		{
			
			base.OnCreate (bundle);

			// change screen to Choice screen
			SetContentView(Resource.Layout.Choice);
			Choice1 = FindViewById<TextView>(Resource.Id.choice1);
			Choice2 = FindViewById<TextView>(Resource.Id.choice2);

			Choice1.Click += (sender, e) => {
				Choice1count++;
				Choice1.Text = Choice1count + " votes";
				Choice2.Text = Choice2count + " votes";
				};

			Choice2.Click += (sender, e) => {
				Choice2count++;
				Choice1.Text = Choice1count + " votes";
				Choice2.Text = Choice2count + " votes";
				};
		}
	}
}

