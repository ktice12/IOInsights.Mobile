using Foundation;
using System;
using UIKit;

namespace IOInsights.Mobile
{
    public partial class LoginViewController : UIViewController
    {
        public static UIStoryboard _storyboard = UIStoryboard.FromName("Main", null);

        public LoginViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void LoginTouch(UIButton sender)
		{
			System.Diagnostics.Debug.WriteLine("Touched");
			var window = new UIWindow(UIScreen.MainScreen.Bounds);

			var initialViewController = _storyboard.InstantiateInitialViewController() as UIViewController;

			window.RootViewController = initialViewController;
			window.MakeKeyAndVisible();
		}
	}
}