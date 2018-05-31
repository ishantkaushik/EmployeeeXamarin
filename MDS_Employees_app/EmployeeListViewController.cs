using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace MDS_Employees_app
{
    public partial class EmployeeListViewController : UIViewController
    {
        public EmployeeListViewController (IntPtr handle) : base (handle)
        {
        }
        public EmployeeListViewController()
        { }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            //var button = new UIButton
            //{
            //    Frame = new CoreGraphics.CGRect(50, 100, 150, 50),
            //    BackgroundColor = UIColor.Blue
            //};
            //button.SetTitle("IT Employees", UIControlState.Normal);
            //View.Add(button);
            //button.TouchUpInside += (object sender, EventArgs e) => { };
            List<ITEmployees> listk = InitializeList();
            UITableView employeeListView;
            employeeListView = new UITableView {
                Frame = new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height),
                Source = new TableSource(listk)
            };
            View.AddSubview(employeeListView);
        }
        public  void DataViewer(UITableView tableView, NSIndexPath indexPath)
        {
            EmployeeDataViewerController controller = this.Storyboard.InstantiateViewController("EmployeeDataViewerController") as EmployeeDataViewerController;
            this.NavigationController.PushViewController(controller, true);
            controller.TextName = "RamPrasad";
        }
        public List<ITEmployees> InitializeList()
        {
            List<ITEmployees> _ITEmployeeList = new List<ITEmployees>();
            _ITEmployeeList.Add(new ITEmployees(1, "Mike", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(2, "Jay", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(3, "Sue", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(4, "Carl", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(5, "Ken", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(6, "Paul", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(7, "Chris", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(8, "Alan", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(9, "Pete", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(10, "Saul", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(11, "Gary", "Hedge", "Ramzi Hedge", "IT Specialist"));
            _ITEmployeeList.Add(new ITEmployees(12, "Sam", "Hedge", "Ramzi Hedge", "IT Specialist"));
            return _ITEmployeeList;
        }
    }
}