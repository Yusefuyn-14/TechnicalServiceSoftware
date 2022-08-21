using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    class Troubles_Solution
    {
        public int ID { get; set; }
        public Solutions SolutionID { get; set; }
        public Employees EmployeeID { get; set; }
        public DateTime Date { get; set; }
    }
}
