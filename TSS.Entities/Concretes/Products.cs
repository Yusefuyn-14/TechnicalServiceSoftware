using TSS.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Products : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Hardwares_Type HardwareTypeID { get; set; }
        public Products_Category CategoryID { get; set; }
    }
}
