﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
     public  class Users
    {
        internal string useremployeeId;

        public enum UserTypeEnum
        {
            Admin,
            Doctor,
            Employee,
            BloodMember,
            Reception
        };
        public int Id { get;set;}
        public string UserName { get;set; }
        public string Password { get; set; }
       
        public int UserType { get; set; }
        public Users() { }

        public Users(int id, string userName, string password, int userType)
        {
            Id = id;
            UserName = userName;
            Password = password;
            UserType = userType;
        }
    }
}
