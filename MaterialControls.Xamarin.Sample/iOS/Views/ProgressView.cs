﻿
using System;

using Foundation;
using MaterialControls.Xamarin.Sample.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using UIKit;


namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class ProgressView : BaseView<ProgressViewModel>
	{
		public ProgressView () : base ("ProgressView", null)
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
			
			Title="MDProgress";
			var set = this.CreateBindingSet<ProgressView, ProgressViewModel> ();
			set.Bind (CircularProgress).To (vm => vm.Progress).For(v=>v.Progress);
			set.Bind (LinearProgress).To (vm => vm.Progress).For(v=>v.Progress);
			set.Apply ();
		}
	}
}

