using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
    class Users
    {
        public enum UserTypeEnum
        {
            Admin,
            Doctorr,
            Employee
        };
        public int Id { get;set;}
        public string UserName { get;set; }
        public string Password { get; set; }
       
        public int UserType { get; set; }

    }
}
