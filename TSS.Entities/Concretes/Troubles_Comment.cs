using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Troubles_Comment : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Troubles TroubleID { get; set; }
        public Employees CommenterID { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
