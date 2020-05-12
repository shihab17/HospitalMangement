using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
    public class Employee
    {
        public int employeeId;
        public string employeeUserName;
        public string employeePassword;

        public Employee(int employeeId, string employeeUserName, string employeePassword)
        {
            this.employeeId = employeeId;
            this.employeeUserName = employeeUserName;
            this.employeePassword = employeePassword;
        }
    }
}
