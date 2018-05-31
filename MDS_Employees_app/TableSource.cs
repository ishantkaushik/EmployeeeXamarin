using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace MDS_Employees_app
{
  public  class TableSource : UITableViewSource  
    {
        List<ITEmployees> listITEmp;
        string cellIdentifier = "TableCell";
        public TableSource(List<ITEmployees> list)
        {
            listITEmp = list;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            EmployeeListViewController employeelistviewObj = new EmployeeListViewController();
            employeelistviewObj.DataViewer(tableView,  indexPath);
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return listITEmp.Count();
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            var pt = listITEmp.Where(k => k.employeeID == indexPath.Row);
            cell.TextLabel.Text = listITEmp.ElementAt(indexPath.Row).employeeFirstName;
            return cell;
        }
    }

   public class Employees
    {
        public int employeeID { get; set; }
        public string employeeFirstName { get; set; }
        public string employeeLastName { get; set; }
        public string employeeFatherName { get; set; }
        public string employeeDesignation { get; set; }
      
    }
    public class ITEmployees : Employees
    {
        public ITEmployees(int ID, string firstName, string lastName, string fatherName, string designation)
        {
            employeeID = ID;
            employeeFirstName = firstName;
            employeeLastName = lastName;
            employeeFatherName = fatherName;
            employeeDesignation = designation;
        }
    }
}