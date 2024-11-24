using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePost { get; set; }
    }

    public class clsEmployeeManager
    {
        public List<Employee> lstemployees = new List<Employee>();

        public clsEmployeeManager()
        {
            lstemployees.Add(new Employee() { EmployeeId = "1", EmployeeName = "Матвей", EmployeePost = "Руководитель"});
            lstemployees.Add(new Employee() { EmployeeId = "2", EmployeeName = "Степан", EmployeePost = "Начальник" });
            lstemployees.Add(new Employee() { EmployeeId = "3", EmployeeName = "Михаил", EmployeePost = "Главный механик" });
        }
    }
}
