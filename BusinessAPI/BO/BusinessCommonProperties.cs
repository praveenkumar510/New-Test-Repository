using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAPI.BO
{
    public class Employee
    {
        public long EmpID { set; get; }
        public string EmpName { set; get; }
        public string Designation{ set; get; }
        public long? Salary { set; get; }
    }
}
