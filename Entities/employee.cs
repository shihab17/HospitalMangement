using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
    public class Employee
    {

        public int employeeId { get; private set; }
        public string employeeUserName { get; private set; }
        public string employeePassword { get; private set; }
        //public int employeeId { get; private set; }
        //public string employeeUserName { get; private set; }
        //public string employeePassword { get; private set; }
        //public string employeeFirstName { get; private set; }
        //public string employeeLastName { get; private set; }
        //public string employeeFatherName { get; private set; }
        //public string employeeMotherName { get; private set; }
        //public string employeeAddress { get; private set; }
        //public string employeeEmail { get; private set; }
        //public string employeeBG { get; private set; }
        //public string employeeGender { get; private set; }
        //public string employeeBirthday { get; private set; }
        //public string employeePhoneNumber { get; private set; }
        //public string employeeProfessionName { get; private set; }
       

       // public Employee(int employeeId, string employeeUserName, string employeePassword, string employeeFirstName, string employeeLastName, string employeeMotherName, string employeeAddress, string employeeEmail, string employeeBG, string employeeGender, string employeeBirthday, string employeePhoneNumber, string employeeProfessionName)
        public Employee(int employeeId, string employeeUserName, string employeePassword)
        {
            this.employeeId = employeeId;
            this.employeeUserName = employeeUserName;
            this.employeePassword = employeePassword;
            //this.employeeFirstName = employeeFirstName;
            //this.employeeLastName = employeeLastName;
            //this.employeeMotherName = employeeMotherName;
            //this.employeeAddress = employeeAddress;
            //this.employeeEmail = employeeEmail;
            //this.employeeBG = employeeBG;
            //this.employeeGender = employeeGender;
            //this.employeeBirthday = employeeBirthday;
            //this.employeePhoneNumber = employeePhoneNumber;
            //this.employeeProfessionName = employeeProfessionName;
            
        }
    }
}
