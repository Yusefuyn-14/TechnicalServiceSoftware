using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Employees_Account : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Employees EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Activated { get; set; }
    }
}
