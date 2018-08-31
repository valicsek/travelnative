using System;
using Foundation;
using UIKit;

namespace TravelNative.iOS
{
    public partial class ViewController : UIViewController
    {

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetupViews();
        }

        void SetupViews()
        {
            this.loginButton.TouchUpInside += OnLoginButtonClicked;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.usernameTextField.Text) || string.IsNullOrEmpty(this.passwordTextField.Text))
            {
                var alert = UIAlertController.Create("Alert", "Username or password is missing!", UIAlertControllerStyle.Alert);
                var cancelAction = UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null);
                alert.AddAction(cancelAction);

                PresentViewController(alert, true, () => {});
            }
            else
            {
                if (this.usernameTextField.Text.ToLower() != "test")
                {
                    var alert = UIAlertController.Create("Alert", "Username or password is not correct!", UIAlertControllerStyle.Alert);
                    var cancelAction = UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null);
                    alert.AddAction(cancelAction);

                    PresentViewController(alert, true, () => { });
                }
                else
                {
                    this.PerformSegue("HomeViewController", null);
                }
            }
        }

    }
}
