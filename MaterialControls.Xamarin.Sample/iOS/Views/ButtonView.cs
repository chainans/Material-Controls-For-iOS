﻿
using System;

using Foundation;
using MaterialControls.Xamarin.Sample.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using UIKit;


namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class ButtonView : BaseView<ButtonViewModel>
	{
		public ButtonView () : base ("ButtonView", null)
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
			Title="MDButton";
			
			var set = this.CreateBindingSet<ButtonView, ButtonViewModel> ();
			set.Bind (RaisedButton).To (vm => vm.RaiseButtonCommand);
			set.Bind (FlatButton).To (vm => vm.FlatButtonCommand);
			set.Bind (FloatingActionButton).To (vm => vm.FloatingButtonCommand);
			set.Bind (Label).To (vm => vm.Action);
			set.Apply ();
		}
	}
}

