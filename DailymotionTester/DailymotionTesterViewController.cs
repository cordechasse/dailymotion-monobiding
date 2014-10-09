using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using dailymotion;


namespace DailymotionTester {

	public partial class DailymotionTesterViewController : UIViewController {

		public DailymotionTesterViewController (IntPtr handle) : base (handle) {
		}

		public override void DidReceiveMemoryWarning () {
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad () {
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			bt.TouchUpInside += (object sender, EventArgs e) => {

				//@"webkit-playsinline": @(YES), @"related" : @(NO), @"logo" : @(NO), @"chromeless": @(YES), @"autoplay" : @(YES)}

				NSDictionary videoParams = new NSMutableDictionary();
				videoParams.SetValueForKey(new NSString("1"), new NSString("webkit-playsinline"));
				videoParams.SetValueForKey(new NSString("0"), new NSString("related"));
				videoParams.SetValueForKey(new NSString("0"), new NSString("logo"));
				videoParams.SetValueForKey(new NSString("1"), new NSString("chromeless"));


				DMPlayerViewController player = new DMPlayerViewController("x23bfnk", videoParams);
				player.DidReceiveEvent += (object sender2, DMPlayerViewControllerDidReceiveEventEventArgs e2) => {
					Console.WriteLine("ReceiveEvent");

					if (e2.EventName == "apiready"){
						player.Play();
					}

				};
				AddChildViewController(player);
				player.View.Frame = View.Bounds;
				View.Add(player.View);

			};

		}

		public override void ViewWillAppear (bool animated) {
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated) {
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated) {
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated) {
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

