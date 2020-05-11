using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangement.Entities
{
    public class MedicalServices
    {
      public  int serviceId;
      public  string serviceName;

        public MedicalServices(int serviceId, string serviceName)
        {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
        }
    }
}
