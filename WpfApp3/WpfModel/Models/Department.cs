using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfModel.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
