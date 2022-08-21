using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Troubles_Price : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Troubles TroubleID { get; set; }
        public Products_Price Product_PriceID { get; set; }
        public DateTime Date { get; set; }
    }
}
