using System;

using UIKit;

namespace MDS_Employees_app
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var button = new UIButton
            {
                Frame = new CoreGraphics.CGRect(50, 100, 150, 50),
                BackgroundColor = UIColor.Red
            };
            button.SetTitle("IT Employees", UIControlState.Normal);
            View.Add(button);
            button.TouchUpInside += (object sender, EventArgs e) => {
                EmployeeListViewController controller = this.Storyboard.InstantiateViewController("EmployeeListViewController") as EmployeeListViewController;
                this.NavigationController.PushViewController(controller, true);
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}