using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS.Entities.Concretes
{
    public class Mac_Address : TSS.Entities.Abstracts.IEntity
    {
        public int ID { get; set; }
        public string Mac { get; set; }
        public Hardwares HardwaresID { get; set; } 
    }
}
