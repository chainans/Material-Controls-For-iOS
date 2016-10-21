﻿
using System;

using Foundation;
using MaterialControls.Xamarin.Sample.Core.ViewModels;
using UIKit;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class SliderView : BaseView<SliderViewModel>
	{
		public SliderView () : base ("SliderView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

