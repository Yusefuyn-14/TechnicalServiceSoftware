using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Devices_Hardware : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public int DevID { get; set; }
        public string DevName { get; set; }
        public string DevModel { get; set; }
        public string DevProd { get; set; }
        public int HardID { get; set; }
        public string HardName { get; set; }
        public string HardProd { get; set; }
        public string HardModel { get; set; }
        public int HardwareTypeID { get; set; }
        public string HardwareTypeName { get; set; }
    }
}
