using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Employees : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string BirthOfDate { get; set; }
        public string BirthOfPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeNumber { get; set; }
        public string Mail { get; set; }
    }
}
