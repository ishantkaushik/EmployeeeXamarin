 using Foundation;
using System;
using UIKit;

namespace MDS_Employees_app
{
    public partial class EmployeeDataViewerController : UIViewController
    {
        public string TextName {get; set; }
        public EmployeeDataViewerController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var txtName = new UITextField
            {
                Frame = new CoreGraphics.CGRect(50, 100, 150, 50),
                BackgroundColor = UIColor.Blue
            };
            txtName.Text = TextName;
            View.Add(txtName);
        }
    }
}