using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using WpfModel.Models;

namespace WpfModel.ViewModels
{
    public class DataGridViewModel : Screen, IHandle<EmployeeInfo>
    {
        readonly IEventAggregator _events;
        private IScreen _selectedTab;
        public IScreen SelectedTab
        {
            get => _selectedTab;
            set
            {
                _selectedTab = value;
                NotifyOfPropertyChange();
            }
        }

        public static ObservableCollection<EmployeeInfo> EmployeesBack = new ObservableCollection<EmployeeInfo>();

        ObservableCollection<EmployeeInfo> _Employees;

        public ObservableCollection<EmployeeInfo> Employees
        {
            get { return _Employees; }
            set
            {
                _Employees = value;
                NotifyOfPropertyChange("Employees");
            }
        }
        /// <summary>
        /// The declaration used in case of search Employee
        /// </summary>
        string _EmpName;

        public string EmpName
        {
            get { return _EmpName; }
            set
            {
                _EmpName = value;
                NotifyOfPropertyChange("EmpName");
            }
        }
        /// <summary>
        /// The declaration of the Employee object for Save and Messanger purpose
        /// </summary>
        EmployeeInfo _EmpInfo;

        public EmployeeInfo EmpInfo
        {
            get { return _EmpInfo; }
            set
            {
                _EmpInfo = value;
                NotifyOfPropertyChange("EmpInfo");
            }
        }
        public DataGridViewModel(IEventAggregator events)
        {
            _events = events;
            _events.Subscribe(this);
            Employees = new ObservableCollection<EmployeeInfo>();
            EmpInfo = new EmployeeInfo();
            InitEmployees();
        }
        /// <summary>
        /// The method to search Employee baseed upon the EmpName
        /// </summary>
        public void SearchEmployee()
        {
            InitEmployees();
            var list = Employees.Where(x => x.EmpName.Contains(EmpName)).ToList();
            Employees.Clear();
            foreach (var item in list)
            {
                Employees.Add(item);
            }
        }
        /// <summary>
        /// The method to send the selected Employee from the DataGrid on UI
        /// to the View Model
        /// </summary>
        /// <param name="emp"></param>
        public   void SendEmployeeInfo(EmployeeInfo emp)
        {
            if (emp != null)
            {
                //模拟两个页面之间传值
                //this.EmpInfo = emp;
                //方法一
                //直接传值 viewModel 目标页面的viewModel, Action 为方法名，最后一个即为传递参数
                //   Caliburn.Micro.Action.Invoke(viewModel, Action,
                //null, null, null, new object[] { ((object[])param)[1] });
                //   Caliburn.Micro.Action.Invoke(this, "SendEmployeeInfomsg",
                //null, null, null, new object[] { emp });
                //方法二
                //消息传递
                _events.Publish(emp, action => Task.Factory.StartNew(action));
            }
        }

        public void SendEmployeeInfomsg(object param)
        {
            var emp = param  as EmployeeInfo;
            this.EmpInfo = emp;
        }
        /// <summary>
        /// Method to Save Employees. Once the Employee is added in the database
        /// it will be added in the Employees observable collection and Property Changed will be raised
        /// </summary>
        /// <param name="emp"></param>
        public void SaveEmployee()
        {
            Employees.Add(EmpInfo);
            EmployeesBack.Add(EmpInfo);
        }
        public void InitEmployees()
        {
            var EmpInfo1 = new EmployeeInfo();
            EmpInfo1.EmpName = "留德华";
            EmpInfo1.EmpNo = 000001;
            EmpInfo1.Designation = "行政。。。。。";
            EmpInfo1.DeptName = "行政部门";
            EmpInfo1.Salary = 50000;

            var EmpInfo2 = new EmployeeInfo();
            EmpInfo2.EmpName = "锅富城";
            EmpInfo2.EmpNo = 000002;
            EmpInfo2.Designation = "人事。。。。。";
            EmpInfo2.DeptName = "人事部门";
            EmpInfo2.Salary = 30000;

            var EmpInfo3 = new EmployeeInfo();
            EmpInfo3.EmpName = "李明";
            EmpInfo3.EmpNo = 000002;
            EmpInfo3.Designation = "公关。。。。。";
            EmpInfo3.DeptName = "公关部门";
            EmpInfo3.Salary = 30000;

            Employees.Add(EmpInfo1);
            Employees.Add(EmpInfo2);
            Employees.Add(EmpInfo3);
            foreach (var item in EmployeesBack)
            {
                Employees.Add(item);
            }
        }

        public void Handle(EmployeeInfo message)
        {
            //执行相关操作
            this.EmpInfo = message;
        }
    }
}
