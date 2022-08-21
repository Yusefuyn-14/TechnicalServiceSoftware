using TSS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Troubles : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Customers Customer { get; set; }
        //public Devices DevicesID { get; set; }
        public Employees Interested { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
    }
}
