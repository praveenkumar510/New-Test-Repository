using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAPI.BO;
using BusinessAPI.DL;
using System.Data.Entity;
using System.Data.EntityModel;
using  System.Data.Entity.Infrastructure;

namespace BusinessAPI.BL
{
    public class Employeedetails
    {
        TestDBEntities Context = new TestDBEntities();
        public List<Employee> GetEmpDetails()
        {
            return Context.t_employee.Select(k => new Employee()
            {
                EmpID = k.EmpiD,
                EmpName = k.EmpName,
                Designation = k.Designation,
                Salary = k.Salary
            }).ToList();         
        }
    }
}
