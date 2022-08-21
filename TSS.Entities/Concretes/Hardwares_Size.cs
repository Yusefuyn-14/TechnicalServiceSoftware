using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Hardwares_Size: TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public Hardwares HardwaresID { get; set; }
        public Computer_Unit ComputerUnitID { get; set; }
        public int Size { get; set; }
        public string Description { get; set; }
    }
}
