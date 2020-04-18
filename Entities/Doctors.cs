using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
   public class Doctors
    {
        public int doctorId;
        public string doctorUserName;
        public string doctorPassword;

        public Doctors(int doctorId, string doctorUserName, string doctorPassword)
        {
            this.doctorId = doctorId;
            this.doctorUserName = doctorUserName;
            this.doctorPassword = doctorPassword;
        }
    }
}
